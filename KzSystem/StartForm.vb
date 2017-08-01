Imports System.ComponentModel

Public Class StartForm

#Region "Friends"

    Friend Sub FormSwitch _
        (ByVal FormToOpen As Form, Optional FormText As String = Nothing,
         Optional ByVal OpenAsMDI As Boolean = True, Optional ByVal OpenMax As Boolean = True)
        Try
            If FormToOpen IsNot Nothing Then
                With FormToOpen
                    For Each f As Form In Me.MdiChildren
                        If f.Name <> .Name Then
                            f.Close()
                            Console.WriteLine("Form [" & f.Name & "] closed. [" & Now().ToString & "]")
                        End If
                    Next

                    If OpenAsMDI Then
                        .MdiParent = Me
                        '.ControlBox = False
                    Else
                        .MdiParent = Nothing
                        .ControlBox = True
                    End If

                    If OpenMax Then
                        .WindowState = FormWindowState.Maximized
                    Else
                        .WindowState = FormWindowState.Normal
                    End If

                    If FormText IsNot Nothing Then
                        .Text = FormText
                    End If

                    .Show()
                    CommandsPanel.Hide()
                End With

            Else
                For Each f As Form In Me.MdiChildren
                    f.Close()
                    CommandsPanel.Show()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Friend Function GetStartBounds(ByVal TryBounds As Rectangle) As Rectangle
        Dim Ans As Rectangle = TryBounds
        Dim Temp As Rectangle = Screen.GetWorkingArea(TryBounds.Location)

        If Temp.Contains(TryBounds) Then
            Ans = TryBounds
        Else
            If Temp.Contains(TryBounds.Location) Then
                If TryBounds.X > (Temp.X + CInt(Temp.Width * 2 / 3)) And TryBounds.Y > CInt(Temp.Height * 2 / 3) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), CInt(Temp.Height * 2 / 3))
                ElseIf TryBounds.X > (Temp.X + CInt(Temp.Width * 2 / 3)) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), TryBounds.Y)
                ElseIf TryBounds.Y > CInt(Temp.Height * 2 / 3) Then
                    Ans.Location = New Point(TryBounds.X, CInt(Temp.Height * 2 / 3))
                End If
            Else
                If TryBounds.Width > Temp.Width And TryBounds.Height > Temp.Height Then
                    Ans = Temp
                ElseIf TryBounds.Width > Temp.Width Then
                    Ans.Location = New Point(Temp.X, TryBounds.Y)
                ElseIf TryBounds.Height > Temp.Height Then
                    Ans.Location = New Point(TryBounds.X, Temp.Y)
                ElseIf TryBounds.X > (Temp.X + Temp.Width) And TryBounds.Y > (Temp.Y + Temp.Height) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), CInt(Temp.Height * 2 / 3))
                ElseIf TryBounds.X > (Temp.X + Temp.Width) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), TryBounds.Y)
                ElseIf TryBounds.Y > (Temp.Y + Temp.Height) Then
                    Ans.Location = New Point(TryBounds.X, CInt(Temp.Height * 2 / 3))
                End If
            End If
        End If

        Return Ans
    End Function

#End Region 'Friends

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ODTC

        With My.Settings
            Me.Text = .AppTitle

            Dim TryBounds As New Rectangle(.StartPoint, .StartSize)
            Me.DesktopBounds = GetStartBounds(TryBounds)
            Me.WindowState = .StartState
        End With

        SetButtons()
    End Sub

    Private Sub StartForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With My.Settings
            .StartState = Me.WindowState
            .StartPoint = Me.Location
            .StartSize = Me.Size
        End With
    End Sub

    Private Sub StartForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        With CommandsPanel
            Dim wRect As Rectangle = Me.ClientRectangle
            Dim side As Integer
            If wRect.Width > wRect.Height Then
                side = CInt(wRect.Height / 2)
            Else
                side = CInt(wRect.Width / 2)
            End If

            .SetBounds(CInt(wRect.Width - side) / 2, CInt(wRect.Height - side) / 2, side, side)
        End With
    End Sub

    Private Sub SetButtons()
        For Each btn As Button In CommandsPanel.Controls
            btn.BackgroundImageLayout = ImageLayout.Zoom
        Next
        'ExitButton.BackgroundImage = My.Resources.PowerLiner
        'EditorButton.BackgroundImage = My.Resources.Notebook
    End Sub


#Region "Commands"
    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click, ExitButton.Click
        FormSwitch(EndForm, "Exiting...", False, False)

        Me.Hide()
    End Sub

    Private Sub HomeMenuItem_Click(sender As Object, e As EventArgs) Handles HomeMenuItem.Click
        FormSwitch(Nothing)
    End Sub

    Private Sub Test01_Click(sender As Object, e As EventArgs) Handles Test01.Click
        FormSwitch(KzTabsDesigner)
    End Sub

    Private Sub Test02_Click(sender As Object, e As EventArgs) Handles Test02.Click
        FormSwitch(KzColorPicker)
    End Sub

    Private Sub Test03_Click(sender As Object, e As EventArgs) Handles Test03.Click
        FormSwitch(TestSlideBar)
    End Sub

    Private Sub Test04_Click(sender As Object, e As EventArgs) Handles Test04.Click
        FormSwitch(PListReaderForm)
    End Sub

    Private Sub HDLibToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HDLibToolStripMenuItem.Click
        FormSwitch(HDLibForm)
    End Sub


#End Region
End Class