Imports System.ComponentModel
Imports System.Net

Public Class KzOnePageWeb

    Private _WebRoot As String

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Property WebRoot As String
        Get
            Return _WebRoot
        End Get
        Set(value As String)
            _WebRoot = value
            HDBrowser.Navigate(_WebRoot)
        End Set
    End Property

    Private Sub HDBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles HDBrowser.DocumentCompleted
        HtmlTitleLabel.Text = HDBrowser.Document.Title
    End Sub

    Private Sub HDBrowser_DocumentTitleChanged(sender As Object, e As EventArgs) Handles HDBrowser.DocumentTitleChanged
        Try
            HtmlTitleLabel.Text = HDBrowser.Document.Title
        Catch ex As Exception
            HtmlTitleLabel.Text = "未知..."
        End Try
    End Sub

    Private Sub HDBrowser_NewWindow(sender As Object, e As CancelEventArgs) Handles HDBrowser.NewWindow
        Dim urlNew As String = sender.Document.ActiveElement.GetAttribute("href")
        If urlNew.Trim = "" Then urlNew = ""

        Application.DoEvents()
        HDBrowser.Navigate(urlNew)

        e.Cancel = True
    End Sub

    Private Sub HDBrowser_StatusTextChanged(sender As Object, e As EventArgs) Handles HDBrowser.StatusTextChanged
        'LinkPopLabel.Text = HDBrowser.StatusText
    End Sub

    Private Sub HDBrowser_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles HDBrowser.Navigated
        UrlLabel.Text = HDBrowser.Url.ToString
        NowLabel.Text = "就緒"
    End Sub

    Private Sub HDBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles HDBrowser.Navigating
        NowLabel.Text = "尋址"
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HDBrowser.GoBack()
        'UrlLabel.Text = HDBrowser.Url.AbsoluteUri
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        HDBrowser.GoForward()
        'UrlLabel.Text = HDBrowser.Url.AbsoluteUri
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        HDBrowser.Refresh()
    End Sub

    Private Sub SourceButton_Click(sender As Object, e As EventArgs) Handles SourceButton.Click
        Try
            Dim src As New KzTextViewDialog
            src.TextContents = KzWeb.GetWebCode(HDBrowser.Url.AbsoluteUri)
            src.InfoText = "【" + HDBrowser.Document.Title + "】 來自 Url：" + HDBrowser.Url.AbsoluteUri
            src.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HDHistoryItem_ButtonClick(sender As Object, e As EventArgs) Handles HDHistoryItem.ButtonClick
        'HDBrowser.GoHome()
        HDBrowser.Navigate("http://www.haodoo.net/")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseWebButton.Click
        'RootSpliter.Panel2Collapsed = True
        'LibSpliter.Panel1Collapsed = False
    End Sub



    'Private Sub OpenWebButton_Click(sender As Object, e As EventArgs) Handles OpenWebButton.Click
    '    'RootSpliter.Panel2Collapsed = False
    '    'LibSpliter.Panel1Collapsed = True
    'End Sub
End Class
