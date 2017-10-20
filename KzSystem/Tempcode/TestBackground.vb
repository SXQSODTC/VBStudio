Imports System.ComponentModel
Imports KzHelper

Public Class TestBackground
    Implements IClient '该窗体需要实现 IClient，以便 Controller 对象与之交互

    '该窗体还需要 Controller 对象和一个标志，用以跟踪后台操作是处于活动状态还是处于完成状态。
    Private mController As New Controller(Me)
    Private mActive As Boolean

    Private Sub TestBackground_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = mActive
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        mController.Start(New Worker(2000000, 1000))

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        Label1.Text = "Cancelling ..."
        mController.Cancel()

    End Sub


#Region " IClient "
    '添加方法，以实现由 IClient 定义的接口。建议将这些方法放在 Region 中，以表示它们实现的是辅助接口

    Private Sub TaskStarted(ByVal Controller As Controller) Implements IClient.Start

        mActive = True
        Label1.Text = "Starting"
        Label2.Text = "0%"
        ProgressBar1.Value = 0
        ActivityBar1.Start()

    End Sub

    Private Sub TaskStatus(ByVal Text As String) Implements IClient.Display

        Label1.Text = Text
        Label2.Text = CStr(mController.Percent) & "%"
        ProgressBar1.Value = mController.Percent

    End Sub

    Private Sub TaskFailed(ByVal e As Exception) Implements IClient.Failed

        ActivityBar1.Stop()
        Label1.Text = e.Message
        MsgBox(e.ToString)
        mActive = False

    End Sub

    Private Sub TaskCompleted(ByVal Cancelled As Boolean) Implements IClient.Completed

        Label1.Text = "Completed"
        Label2.Text = CStr(mController.Percent) & "%"
        ProgressBar1.Value = mController.Percent
        ActivityBar1.Stop()
        mActive = False

    End Sub

    '注意，这一段代码中的所有内容均与线程无关，其中的每一部分代码都可以
    '在我们得知后台操作的状态时做出相应的响应。每次响应后，我们都会更新
    '显示以表明进程的状态和完成百分比（以文字的形式或通过 ProgressBar 显示），
    '并启动和停止 ActivityBar 控件。
    'mActive 标志非常重要。如果用户在辅助线程处于活动状态时关闭窗体，
    '应用程序可能会挂起或变得不稳定。要防止出现这种情况，我们可以打断窗体的 
    'Closing 事件并取消关闭尝试（如果后台进程处于活动状态）。

#End Region

End Class

Public Class Worker
    Implements IWorker '创建 Worker 类，实现 IWorker 接口

    Private mController As IController
    Private mInner As Integer
    Private mOuter As Integer

    Public Sub New(ByVal InnerSize As Integer, ByVal OuterSize As Integer)
        mInner = InnerSize
        mOuter = OuterSize
    End Sub

    ' 由 Controller 调用，以便获取
    ' Controller 的引用
    Private Sub Init(ByVal Controller As IController) Implements IWorker.Initialize

        mController = Controller

    End Sub

    Private Sub Work() Implements IWorker.Start
        Dim innerIndex As Integer
        Dim outerIndex As Integer

        Dim value As Double

        Try
            For outerIndex = 0 To mOuter
                If mController.Running Then
                    mController.Display("Outer loop " & outerIndex & " starting")
                    mController.SetPercent(CInt(outerIndex / mOuter * 100))

                Else
                    ' 它们请求取消
                    mController.Completed(True)
                    Exit Sub
                End If

                For innerIndex = 0 To mInner
                    ' 此处进行一些有意思的计算
                    value = Math.Sqrt(CDbl(innerIndex - outerIndex))
                Next
            Next
            mController.SetPercent(100)
            mController.Completed(False)

        Catch e As Exception
            mController.Failed(e)

        End Try
    End Sub

    '添加了能够实现 IWorker.Initialize 的 Init 方法。Controller 将调用此方法，
    '因此以后我们可以引用 Controller 对象。

    '我们还将 Work 方法更改为 Private，只是为了实现 IWorker.Start 方法。
    '此方法将在辅助线程上运行。

    '我们增强了 Work 方法，使其可以使用 Try..Catch 块。这样我们可以使用 
    'Controller 上的 Failed 方法捕捉任何错误并将其返回给 UI。

    '假设代码正在运行，我们调用 Controller 对象的 Display 和 SetPercent 
    '方法，使它们随着代码的运行更新其状态和完成的百分比。

    '我们还定期检查 Controller 对象的 Running 属性，查看是否存在取消请求。
    '如果存在取消请求，则停止进程，并指示由于取消请求而停止操作。

End Class
