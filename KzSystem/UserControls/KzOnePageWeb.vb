Imports System.ComponentModel
Imports System.Security.Permissions
Imports System.Net

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<System.Runtime.InteropServices.ComVisibleAttribute(True)>
Public Class KzOnePageWeb

    Private _WebRoot As String

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        'HDBrowser.AllowWebBrowserDrop = False
        'HDBrowser.IsWebBrowserContextMenuEnabled = False
        'HDBrowser.WebBrowserShortcutsEnabled = False
        HDBrowser.ObjectForScripting = Me
        '' Uncomment the following line when you are finished debugging.
        'HDBrowser.ScriptErrorsSuppressed = True

        UISetting()
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

    Public Property ShowSourceInternal As Boolean = True

    Private Sub UISetting()
        HistoryButton.Image = My.Resources.web_history
        HomeButton.Image = My.Resources.web_home
        GoButton.Image = My.Resources.web_go
        GoBackButton.Image = My.Resources.web_goback
        GoForwardButton.Image = My.Resources.web_goforward
        StopButton.Image = My.Resources.web_stop
        FavoritesButton.Image = My.Resources.web_favorites
        ToolsButton.Image = My.Resources.web_toolbox
        RefreshButton.Image = My.Resources.web_refresh
        SourceButton.Image = My.Resources.web_sourcecode
        MenuSwitchButton.Image = My.Resources.web_switch
        SearchButton.Image = My.Resources.web_search
        EnginesButton.Image = My.Resources.web_engines

        SaveAsToolStripMenuItem.Image = My.Resources.web_save
        PageSetupToolStripMenuItem.Image = My.Resources.web_pagesetup
        PreviewToolStripMenuItem.Image = My.Resources.web_preview
        PrintToolStripMenuItem.Image = My.Resources.web_print
        PropertiesToolStripMenuItem.Image = My.Resources.web_properties
        SettingsToolStripMenuItem.Image = My.Resources.web_settings
    End Sub

    Private Sub HDBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles HDBrowser.DocumentCompleted
        HtmlTitleLabel.Text = HDBrowser.Document.Title
    End Sub

    Private Sub HDBrowser_DocumentTitleChanged(sender As Object, e As EventArgs) Handles HDBrowser.DocumentTitleChanged
        Try
            HtmlTitleLabel.Text = HDBrowser.Document.Title
        Catch ex As Exception
            HtmlTitleLabel.Text = "未知..."
        End Try
        IndexButton.Image = My.Resources.web_finished
    End Sub

    Private Sub HDBrowser_NewWindow(sender As Object, e As CancelEventArgs) Handles HDBrowser.NewWindow
        Dim urlNew As String = sender.Document.ActiveElement.GetAttribute("href")
        If urlNew.Trim = "" Then urlNew = ""

        Application.DoEvents()
        HDBrowser.Navigate(urlNew)

        e.Cancel = True
    End Sub

    Private Sub HDBrowser_StatusTextChanged(sender As Object, e As EventArgs) Handles HDBrowser.StatusTextChanged
        NowLabel.Text = HDBrowser.StatusText
    End Sub

    Private Sub HDBrowser_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles HDBrowser.Navigated
        UrlTextBox.Text = HDBrowser.Url.ToString
    End Sub

    Private Sub HDBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles HDBrowser.Navigating
        IndexButton.Image = My.Resources.web_running
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        HDBrowser.GoBack()
        'UrlLabel.Text = HDBrowser.Url.AbsoluteUri
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles GoForwardButton.Click
        HDBrowser.GoForward()
        'UrlLabel.Text = HDBrowser.Url.AbsoluteUri
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        If Not HDBrowser.Url.Equals("about:blank") Then
            HDBrowser.Refresh()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Me.Enabled = False
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        HDBrowser.Navigate(_WebRoot) '("http://www.haodoo.net/")
    End Sub

    Private Sub SourceButton_Click(sender As Object, e As EventArgs) Handles SourceButton.Click
        Dim sce As New SourceCodeExportEventArgs With {
             .Code = Nothing, .Source = Nothing}

        sce.Source = HDBrowser.Url.AbsoluteUri

        Try
            sce.Code = KzWeb.GetWebCode(HDBrowser.Url.AbsoluteUri)
        Catch ex As Exception

        End Try

        RaiseEvent SourceCodeExported(Me, sce)

        If ShowSourceInternal Then
            Dim src As New KzTextViewDialog
            src.TextContents = sce.Code
            src.InfoText = sce.Source
            src.ShowDialog()
        End If
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        HDNavigate(UrlTextBox.Text)
    End Sub

    Private Sub UrlTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles UrlTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            HDNavigate(UrlTextBox.Text)
        End If
    End Sub

    Private Sub HDNavigate(ByVal address As String)
        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") And
            Not address.StartsWith("https://") Then
            address = "http://" & address
        End If

        Try
            HDBrowser.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            Return
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        HDBrowser.ShowSaveAsDialog()
    End Sub

    Private Sub UrlTextBox_Click(sender As Object, e As EventArgs) Handles UrlTextBox.Click
        UrlTextBox.SelectAll()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        HDBrowser.ShowPageSetupDialog()
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewToolStripMenuItem.Click
        HDBrowser.ShowPrintPreviewDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        HDBrowser.ShowPrintDialog()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        HDBrowser.ShowPropertiesDialog()
    End Sub

    Private Sub HDBrowser_CanGoBackChanged(sender As Object, e As EventArgs) Handles HDBrowser.CanGoBackChanged
        GoBackButton.Enabled = HDBrowser.CanGoBack
    End Sub

    Private Sub HDBrowser_CanGoForwardChanged(sender As Object, e As EventArgs) Handles HDBrowser.CanGoForwardChanged
        GoForwardButton.Enabled = HDBrowser.CanGoForward
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        HDBrowser.Stop()
    End Sub

    Private Sub MenuSwitchButton_Click(sender As Object, e As EventArgs) Handles MenuSwitchButton.Click
        HDBrowser.IsWebBrowserContextMenuEnabled = MenuSwitchButton.Checked

        'MsgBox("Btn: " & MenuSwitchButton.Checked.ToString & vbCrLf & "Menu: " & HDBrowser.IsWebBrowserContextMenuEnabled.ToString)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        HDBrowser.GoSearch()
    End Sub

    Private Sub UrlToolStrip_SizeChanged(sender As Object, e As EventArgs) Handles UrlToolStrip.SizeChanged
        Dim w As Integer = 15

        For Each item As ToolStripItem In UrlToolStrip.Items
            If Not item.Equals(UrlTextBox) Then
                w += item.Width
            End If
        Next

        UrlTextBox.Width = UrlToolStrip.Width - w
    End Sub

    Private Sub CmdToolStrip_SizeChanged(sender As Object, e As EventArgs) Handles CmdToolStrip.SizeChanged
        Dim w As Integer = 15

        For Each item As ToolStripItem In CmdToolStrip.Items
            If Not item.Equals(HtmlTitleLabel) Then
                w += item.Width
            End If
        Next

        HtmlTitleLabel.Width = CmdToolStrip.Width - w
    End Sub

    Public Event SourceCodeExported(sender As Object, e As SourceCodeExportEventArgs)

    Private Sub ElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementsToolStripMenuItem.Click
        Dim sce As New SourceCodeExportEventArgs With {
             .Code = Nothing, .Source = Nothing}

        Dim ElemColl As HtmlElementCollection
        Dim Doc As HtmlDocument = HDBrowser.Document

        sce.Source = HDBrowser.Url.AbsoluteUri

        Try
            If (Not (Doc Is Nothing)) Then
                ElemColl = Doc.GetElementsByTagName("HTML")
                Dim Str As String = PrintDom(ElemColl, New System.Text.StringBuilder(), 0)

                sce.Code = Str
            End If
        Catch ex As Exception

        End Try

        RaiseEvent SourceCodeExported(Me, sce)

        If ShowSourceInternal Then
            Dim src As New KzTextViewDialog
            src.TextContents = sce.Code
            src.InfoText = sce.Source
            src.ShowDialog()
        End If
    End Sub

    'Private Sub PrintDomBegin()
    '    If (HDBrowser.Document IsNot Nothing) Then
    '        Dim ElemColl As HtmlElementCollection

    '        Dim Doc As HtmlDocument = HDBrowser.Document
    '        If (Not (Doc Is Nothing)) Then
    '            ElemColl = Doc.GetElementsByTagName("HTML")
    '            Dim Str As String = PrintDom(ElemColl, New System.Text.StringBuilder(), 0)

    '            HDBrowser.DocumentText = Str
    '        End If
    '    End If
    'End Sub

    Private Function PrintDom(ByVal ElemColl As HtmlElementCollection, ByRef ReturnStr As System.Text.StringBuilder, ByVal Depth As Integer) As String
        Dim Str As New System.Text.StringBuilder()

        For Each Elem As HtmlElement In ElemColl
            Dim ElemName As String

            ElemName = Elem.GetAttribute("ID")
            If (ElemName Is Nothing Or ElemName.Length = 0) Then
                ElemName = Elem.GetAttribute("name")
                If (ElemName Is Nothing Or ElemName.Length = 0) Then
                    ElemName = "<no name>"
                End If
            End If

            Str.Append(CChar(" "), Depth * 4)
            Str.Append(ElemName & ": " & Elem.TagName & "(Level " & Depth & ")")
            ReturnStr.AppendLine(Str.ToString())

            If (Elem.CanHaveChildren) Then
                PrintDom(Elem.Children, ReturnStr, Depth + 1)
            End If

            Str.Remove(0, Str.Length)
        Next

        PrintDom = ReturnStr.ToString()
    End Function


End Class

Public Class SourceCodeExportEventArgs
    Inherits EventArgs

    Public Property Code As String
    Public Property Source As String
End Class
