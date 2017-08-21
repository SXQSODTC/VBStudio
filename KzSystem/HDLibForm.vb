Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class HDLibForm
    Private OriginInf As KzLibInfo
    Private CurrentInf As KzLibInfo
    Private CopiedNode As TreeNode

    Private Sub HDLibForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        For i As Integer = 0 To [Enum].GetNames(GetType(KzLibInfoType)).Count - 1
            TypeBox.Items.Add(CType(i, KzLibInfoType))
        Next

        HDBrowser.Navigate(My.Settings.HDLibHome)

        LinkPopLabel.Text = ""
        LinkPopLabel.BackColor = Color.SeaGreen
        LinkPopLabel.ForeColor = Color.WhiteSmoke

        LibView.StartDirectory = My.Settings.HDLibPath
        LibView.ExceptNames.Add("LibDB")
        LibView.RefreshTree()

        SaveListButton.Enabled = False
    End Sub

#Region "BrowserCode"

    'Private Sub Navigate(ByVal address As String)
    '    If String.IsNullOrEmpty(address) Then Return
    '    If address.Equals("about:blank") Then Return
    '    If Not address.StartsWith("http://") And
    '        Not address.StartsWith("https://") Then
    '        address = "http://" & address
    '    End If

    '    Try
    '        HDBrowser.Navigate(New Uri(address))
    '        'UrlLabel.Text = address
    '    Catch ex As System.UriFormatException
    '        Return
    '    End Try
    'End Sub

    Private Sub HDBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles HDBrowser.DocumentCompleted
        HtmlTitleLabel.Text = HDBrowser.Document.Title
    End Sub

    Private Sub HDBrowser_DocumentTitleChanged(sender As Object, e As EventArgs) Handles HDBrowser.DocumentTitleChanged
        Try
            HtmlTitleLabel.Text = HDBrowser.Document.Title
        Catch ex As Exception
            Me.Text = "未知..."
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
        LinkPopLabel.Text = HDBrowser.StatusText
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
        RootSpliter.Panel2Collapsed = True
        'LibSpliter.Panel1Collapsed = False
    End Sub

    Private Sub OpenWebButton_Click(sender As Object, e As EventArgs) Handles OpenWebButton.Click
        RootSpliter.Panel2Collapsed = False
        'LibSpliter.Panel1Collapsed = True
    End Sub

#End Region 'BrowserCode

#Region "ButtonsOnToolStrip"
    Private Sub SwitchListButton_Click(sender As Object, e As EventArgs) Handles SwitchListButton.Click
        '展開或折疊樹形圖
        If LibSpliter.Panel1Collapsed Then
            LibSpliter.Panel1Collapsed = False
        Else
            LibSpliter.Panel1Collapsed = True
        End If
    End Sub

    Private Sub LibPathButton_Click(sender As Object, e As EventArgs) Handles LibPathButton.Click
        '更改書庫目錄（資料夾）
        Dim fbd As New FolderBrowserDialog
        fbd.ShowNewFolderButton = True

        If Directory.Exists(LibView.StartDirectory) Then
            fbd.RootFolder = LibView.StartDirectory
        End If

        If fbd.ShowDialog = DialogResult.OK Then
            LibView.StartDirectory = fbd.SelectedPath
            LibView.ExceptNames.Add("LibDB")
            My.Settings.HDLibPath = fbd.SelectedPath
            LibView.RefreshTree()
        End If
    End Sub

    Private Sub SaveInf(Optional FromInf As KzLibInfo = Nothing, Optional UIAfterSaving As Boolean = True)
        If FromInf Is Nothing Then
            FromInf = CurrentInf
        End If


    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click, SaveInfButton.Click
        If LibView.SelectedNode.Parent IsNot Nothing Then
            If TypeBox.SelectedItem = KzLibInfoType.Root Then
                MsgBox("文檔類型不能為 Root，請返回選擇正確的類型。" & vbCrLf & "未保存任何文檔。", MsgBoxStyle.OkOnly, "提示")
                Exit Sub
            End If
        End If

        Dim sf As String = TypeBox.SelectedItem.ToString & ".kzinf"  ' [Enum].GetName(GetType(KzLibInfoType), TypeBox.SelectedItem) & ".kzinf"

        Dim di As New DirectoryInfo(LibView.SelectedNode.FullPath)
        Dim fn As FileInfo() = di.GetFiles
        Dim fs As New List(Of String)
        For Each f As FileInfo In fn
            If f.Name.EndsWith(".kzinf") And Not f.Name.ToLower = sf.ToLower Then
                fs.Add(f.FullName)
            End If
        Next

        If fs.Count > 0 Then
            Dim m As String =
                "本資料夾存在不同定義的資訊文檔，是否繼續保存？" & vbCrLf &
                "【確定】將刪除不同定義的文檔，保存 " & sf & "。" & vbCrLf &
                "【取消】退出保存。將不保存任何文檔。"

            If MsgBox(m, MsgBoxStyle.OkCancel, "保存") = MsgBoxResult.Ok Then
                For Each f As String In fs
                    File.Delete(f)
                Next
            Else
                Exit Sub
            End If
        End If

        Try
            PutInfToFile(GetInfFromUI(), Path.Combine(LibView.SelectedNode.FullPath, sf))
            MsgBox("資訊檔 ..\" & Path.GetFileName(LibView.SelectedNode.FullPath) & "\" & sf & " 保存完畢。", MsgBoxStyle.OkOnly, "存檔")

            Dim tvea As New TreeViewEventArgs(LibView.SelectedNode)
            LibView_AfterSelect(LibView, tvea)

            SaveButton.Enabled = False
        Catch ex As Exception
            MsgBox("資訊檔 " & Path.Combine(LibView.SelectedNode.FullPath, sf) & " 未能保存。原因：" & vbCrLf & ex.Message, MsgBoxStyle.OkOnly, "存檔")
        End Try

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowCodeButton.Click
        Dim tvd As New KzTextViewDialog
        tvd.TextContents = PutInfToText(GetInfFromUI())
        tvd.InfoText = "Save Path: " & Path.Combine(LibView.SelectedNode.FullPath, [Enum].GetName(GetType(KzLibInfoType), TypeBox.SelectedItem) & ".kzinf")
        tvd.ShowDialog()
    End Sub

#End Region 'ButtonsOnToolStrip


#Region "LibViewActions"

    Private Sub UpdateUI()

    End Sub

    Private Sub LibView_AfterSelect(sender As Object, e As TreeViewEventArgs) _
        Handles LibView.AfterSelect

        Console.WriteLine(LibView.SelectedNode.Name)
        IndicatedBox.Text = e.Node.Text
        LibPathLabel.Text = e.Node.FullPath

        Dim di As New DirectoryInfo(e.Node.FullPath)
        Dim fis As FileInfo()
        '===================================================================
        '判斷資料夾形式，如為 Book，將內容投放至 UI
        fis = di.GetFiles("*.kzinf", SearchOption.TopDirectoryOnly)
        CurrentInf = New KzLibInfo
        If fis.Length = 1 Then
            CurrentInf = GetInfFromFile(fis(0))

            With NodeInfoLabel
                Select Case fis(0).Name.ToLower
                    Case "book.kzinf" : .Text = "[Book]"
                    Case "lib.kzinf" : .Text = "[Root]"
                    Case "category.kzinf" : .Text = "[Category]"
                    Case "special.kzinf" : .Text = "[Special]"
                    Case "author.kzinf" : .Text = "[Author]"
                    Case Else : .Text = "[Others]"
                End Select
            End With

            'Dim fn As String = fis(0).Name.ToLower
            'If fn = "book.kzinf" Then
            '    NodeInfoLabel.Text = "[Book]"
            'Else
            '    If fn = "lib.kzinf" Then
            '        NodeInfoLabel.Text = "[LibRoot]"
            '    ElseIf fn = "category.kzinf" Then
            '        NodeInfoLabel.Text = "[Category]"
            '    ElseIf fn = "special.kzinf" Then
            '        NodeInfoLabel.Text = "[Special]"
            '    ElseIf fn = "author.kzinf" Then
            '        NodeInfoLabel.Text = "[Author]"
            '    Else
            '        NodeInfoLabel.Text = "[Other]"
            '    End If
            'End If
        ElseIf fis.Length > 1 Then
            NodeInfoLabel.Text = "[System]"
        Else
            NodeInfoLabel.Text = "[Blank]"
        End If

        PutInfToUI(CurrentInf)
        '===================================================================
        '將當前資料夾中的文檔列表投放至 ListView
        fis = di.GetFiles
        FilesLabel.Text = "Files: " & fis.Count
        Dim item As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem()
        Dim ext As String
        Dim l As Long
        FilesView.Items.Clear()
        For i = 0 To fis.Length - 1
            ext = GetFileType(fis(i).Extension)

            If ext = "書籍" And NodeInfoLabel.Text = "[Blank]" Then NodeInfoLabel.Text = "[Potential]"

            item = New ListViewItem(fis(i).Name)
            item.Name = fis(i).Name
            l = fis(i).Length
            subitems = {
                New ListViewItem.ListViewSubItem(item, "-"),
                New ListViewItem.ListViewSubItem(item, ext),
                New ListViewItem.ListViewSubItem(item, KzStr.GetFileLength(l, True, False, True)),
                New ListViewItem.ListViewSubItem(item, "(" & If(l < 1024, "", KzStr.GetFileLength(l, True, True)) & ")"),
                New ListViewItem.ListViewSubItem(item, ""),
                New ListViewItem.ListViewSubItem(item, fis(i).CreationTime.ToString),
                New ListViewItem.ListViewSubItem(item, fis(i).LastWriteTime.ToString),
                New ListViewItem.ListViewSubItem(item, fis(i).LastAccessTime.ToString)}
            item.SubItems.AddRange(subitems)
            FilesView.Items.Add(item)
        Next

        '===================================================================
        '向 ListView 添加 FileComments（如存在）
        Dim fcs As String()
        Dim it As ListViewItem
        If CurrentInf IsNot Nothing Then
            With CurrentInf
                If .FileComments.Length > 0 And FilesView.Items.Count > 0 Then
                    For i As Integer = 0 To .FileComments.Length - 1
                        fcs = .FileComments(i).Split("^")

                        For Each it In FilesView.Items
                            If it.SubItems.Item(0).Text = fcs(0) Then
                                it.SubItems.Item(1).Text = fcs(1)
                                it.SubItems.Item(4).Text = fcs(2)
                                Exit For
                            End If
                        Next
                    Next
                End If
            End With
        End If

        FilesView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        FileSetCoverItem.Enabled = False
        SaveInfButton.Enabled = False
    End Sub

    'Private Sub LibTreeView_AfterExpand(sender As Object, e As TreeViewEventArgs)
    '    e.Node.Expand()
    '    'ShowSubDirectories(CType(e.Node, DirectoryNode))
    'End Sub

    Private Sub LibView_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) _
        Handles LibView.AfterLabelEdit

        If e.Node.Parent Is Nothing Then
            e.CancelEdit = True
            Exit Sub
        End If

        Dim t As String = e.Node.Tag

        If e.Label Is Nothing Then
            e.CancelEdit = True

            If t IsNot Nothing Then
                If t.EndsWith(".kzinf") Then
                    e.Node.Remove()
                End If
            End If

            Exit Sub
        End If

        If e.Label = "New" Then
            Dim s As String = "新資料夾未改名或名稱不能為 New。是否繼續改名？" + vbCrLf +
                "【是】關閉本提示繼續改名。" + vbCrLf + "【否】將刪除當前已新增的項目。"

            If MsgBox(s, MsgBoxStyle.YesNo, "新增") = MsgBoxResult.Yes Then
                e.Node.BeginEdit()
            Else
                e.CancelEdit = True
                e.Node.Remove()
            End If

            Exit Sub
        End If

        If t IsNot Nothing Then

            If t.EndsWith(".kzinf") Then
                Dim np As String = Path.Combine(e.Node.Parent.FullPath, e.Label)

                If Directory.Exists(np) Then
                    Dim s As String = "資料夾已存在，是否繼續改名？" + vbCrLf +
                        "【是】關閉本提示繼續改名。" + vbCrLf + "【否】將刪除當前已新增的項目。"

                    If MsgBox(s, MsgBoxStyle.YesNo, "新增") = MsgBoxResult.Yes Then
                        e.Node.BeginEdit()
                    Else
                        e.CancelEdit = True
                        e.Node.Remove()
                    End If

                    Exit Sub

                Else
                    Try
                        Directory.CreateDirectory(np)
                    Catch ex As Exception
                        MsgBox("未能創建資料夾。原因：" +
                               vbCrLf + ex.Message, MsgBoxStyle.OkOnly, "新增")
                        e.CancelEdit = True
                        e.Node.Remove()
                        Exit Sub
                    End Try
                End If

                Dim inf As New KzLibInfo
                With inf
                    Select Case t
                        Case "Book.kzinf" : .Type = KzLibInfoType.Book
                        Case "Author.kzinf" : .Type = KzLibInfoType.Author
                        Case "Category.kzinf" : .Type = KzLibInfoType.Category
                        Case "Special.kzinf" : .Type = KzLibInfoType.Special
                    End Select
                    .Title = Path.GetFileName(np)
                    .Updated = Now().ToString
                End With

                PutInfToUI(inf)
                PutInfToFile(inf, Path.Combine(np, t))

                e.Node.Text = e.Label
                e.Node.EndEdit(False)

                LibView.SelectedNode = e.Node
            End If

        Else
            If Directory.Exists(e.Node.FullPath) And Not (e.Label = e.Node.Text) Then
                FileIO.FileSystem.RenameDirectory(e.Node.FullPath, e.Label)
                e.Node.Text = e.Label
                e.Node.EndEdit(False)
                LibView.SelectedNode = e.Node
            Else
                e.CancelEdit = True
            End If
        End If

    End Sub

    Private Sub LibView_BeforeLabelEdit(sender As Object, e As NodeLabelEditEventArgs) _
        Handles LibView.BeforeLabelEdit

        If e.Node.Parent Is Nothing Then e.CancelEdit = True
    End Sub

    Private Sub LibView_MouseClick(sender As Object, e As MouseEventArgs) _
        Handles LibView.MouseClick

        If e.Button = MouseButtons.Left Or e.Button = MouseButtons.Right Then
            Dim nd As TreeNode = LibView.GetNodeAt(e.Location)
            If Not nd.Equals(LibView.SelectedNode) Then
                LibView.SelectedNode = nd
            End If
        End If
    End Sub
#End Region 'LibViewActions


#Region "FilesViewActions"
    Private Sub FilesView_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles FilesView.SelectedIndexChanged

        With FilesView
            If .SelectedItems.Count > 0 Then
                If .SelectedItems(0).SubItems(2).Text = "圖像" Then
                    ShowImg(Path.Combine(LibPathLabel.Text, .SelectedItems(0).Text))
                    CoverButton.Enabled = True
                    FileSetCoverItem.Enabled = True
                Else
                    FileSetCoverItem.Enabled = False
                End If

                SerialBox.Text = .SelectedItems(0).SubItems(1).Text
                CommentBox.Text = .SelectedItems(0).SubItems(5).Text
            Else
                SerialBox.Text = Nothing
                CommentBox.Text = Nothing
            End If
        End With

        SaveListButton.Enabled = False
    End Sub

    Private Sub FilesView_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) _
        Handles FilesView.AfterLabelEdit

        If e.Label Is Nothing Or e.Label = FilesView.Items.Item(e.Item).Text Then
            e.CancelEdit = True
            Exit Sub
        End If

        Dim ofn As String = FilesView.Items.Item(e.Item).Text
        Dim oext As String = ofn.Substring(ofn.LastIndexOf("."))
        Dim dext As String = e.Label.Substring(e.Label.LastIndexOf("."))

        If Not oext = dext Then
            Dim s As String = "擴展名已被更改，可能導致文檔不能開啟。是否繼續？" + vbCrLf +
                "【是】繼續改名，擴展名將更改為 " + dext + vbCrLf +
                "【否】返回文檔名編輯。"

            If MsgBox(s, MsgBoxStyle.YesNo, "改名") = MsgBoxResult.No Then
                FilesView.Items.Item(e.Item).BeginEdit()
                Exit Sub
            End If
        End If

        Try
            FileIO.FileSystem.RenameFile(Path.Combine(LibView.SelectedNode.FullPath, FilesView.Items.Item(e.Item).Text), e.Label)
            FilesView.Items.Item(e.Item).Text = e.Label
        Catch ex As Exception
            MsgBox("文檔未能改名。原因：" + vbCrLf + ex.Message)
            e.CancelEdit = True
        End Try
    End Sub

    Private Sub SerialBox_TextChanged(sender As Object, e As EventArgs) _
        Handles SerialBox.TextChanged, CommentBox.TextChanged

        SaveListButton.Enabled = True
    End Sub

    Private Sub SaveListButton_Click(sender As Object, e As EventArgs) Handles SaveListButton.Click
        With FilesView
            If .SelectedItems.Count > 0 Then
                .SelectedItems(0).SubItems(1).Text = SerialBox.Text
                .SelectedItems(0).SubItems(4).Text = CommentBox.Text
            End If
        End With
        SaveListButton.Enabled = False
        SaveInfButton.Enabled = True
    End Sub
#End Region 'FilesViewActions


#Region "ControlsOnPanel"
    Private Sub CoverButton_Click(sender As Object, e As EventArgs) Handles CoverButton.Click
        If CoverBox.Tag IsNot Nothing Then
            ShowImg(Path.Combine(LibPathLabel.Text, CoverBox.Tag))
        End If
    End Sub

    Private Sub IndicatedBox_TextChanged(sender As Object, e As EventArgs) Handles IndicatedBox.TextChanged

    End Sub

    Private Sub IndicatedBox_GotFocus(sender As Object, e As EventArgs) Handles IndicatedBox.GotFocus
        IndicatedBox.AutoCompleteCustomSource = GetAllNodeText(LibView.Nodes(0))
    End Sub

    Private Function GetAllNodeText(node As TreeNode) As AutoCompleteStringCollection
        Dim acsc As New AutoCompleteStringCollection

        If node.Nodes.Count > 0 Then
            For Each subnode As TreeNode In node.Nodes
                acsc.Add(subnode.Text)
                Dim subacsc As AutoCompleteStringCollection = GetAllNodeText(subnode)
                For Each tx As String In subacsc
                    acsc.Add(tx)
                Next
            Next
        End If

        Return acsc
    End Function
#End Region 'ControlsOnPanel


#Region "PrivateMethods"
    Private Function GetFileType(extension As String) As String
        Select Case extension.ToLower
            Case ".updb", ".prc", ".mobi", ".epub"
                Return "書籍"' "Package"
            Case ".doc", ".docx", ".txt", ".rtf"
                Return "文檔" '"Editable"
            Case ".pdf", ".djvu"
                Return "發佈" '"Published"
            Case ".html", ".htm"
                Return "網頁" '"Webpage"
            Case ".jpg", ".jepg", ".png", ".bmp", ".tif", ".tiff", ".gif"
                Return "圖像" '"Image"
            Case ".kzinf", ".inf", ".info", ".ini"
                Return "資訊" '"Libinfo"
            Case ".rar", ".zip", ".7z"
                Return "壓縮" '"Compressed"
            Case ".avi", ".mkv", ".mov", ".ts", ".rmvb", ".mp4"
                Return "視訊"
            Case ".mp3", ".flac", ".wav"
                Return "音訊"
            Case Else
                Return "-"
        End Select
    End Function

    Private Function GetInfFromUI() As KzLibInfo
        Dim lif As New KzLibInfo

        With lif
            .Type = TypeBox.SelectedItem
            .ID = IDBox.Text
            .Title = TitleBox.Text
            .Subtitle = SubtitleBox.Text
            .Series = SeriesBox.Text
            .Author = AuthorBox.Text
            .AuthorInfo = ""
            .PublishInfo = PublishInfoBox.Text
            .Version = VersionBox.Text
            .Category = CategoryBox.Text
            .Special = SpecialBox.Text
            If CoverBox.Tag Is Nothing Then
                .Cover = ""
            Else
                .Cover = CoverBox.Tag.ToString
            End If
            .Address = "\" & Path.GetFileName(LibView.SelectedNode.FullPath)
            .FileComments = GetFileComments().Split("|")
            .Updated = Now().ToString
            .ViewLink = If(ViewLinkButton.Tag IsNot Nothing, ViewLinkButton.Tag, "")
            .DownloadLink = If(DownLinkButton.Tag IsNot Nothing, DownLinkButton.Tag, "")
            .CoverLink = If(CoverLinkButton.Tag IsNot Nothing, CoverLinkButton.Tag, "")
            .Intro = IntroBox.Text
        End With

        Return lif
    End Function

    Private Function GetInfFromFile(InfFile As FileInfo) As KzLibInfo
        Dim lif As New KzLibInfo

        Using fs As FileStream = New FileStream(InfFile.FullName, FileMode.Open, FileAccess.Read)
            Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                Dim line, head, value As String
                Dim pos As Integer

                Do
                    line = sr.ReadLine()

                    If line.Contains(":") Then
                        pos = line.IndexOf(":")
                        head = line.Substring(0, pos)
                        value = line.Substring(pos + 1)

                        Select Case head
                            Case "Type" : lif.Type = [Enum].Parse(GetType(KzLibInfoType), value)
                            Case "ID" : lif.ID = value
                            Case "Title" : lif.Title = value
                            Case "Subtitle" : lif.Subtitle = value
                            Case "Series" : lif.Series = value
                            Case "Author" : lif.Author = value
                            Case "AuthorInfo" : lif.AuthorInfo = value
                            Case "PublishInfo" : lif.PublishInfo = value
                            Case "Version" : lif.Version = value
                            Case "Category" : lif.Category = value
                            Case "Special" : lif.Special = value
                            Case "Cover" : lif.Cover = value
                            Case "Address" : lif.Address = value
                            Case "FileComments" : lif.FileComments = value.Split("|")
                            Case "Updated" : lif.Updated = value
                            Case "ViewLink" : lif.ViewLink = value
                            Case "DownloadLink" : lif.DownloadLink = value
                            Case "CoverLink" : lif.CoverLink = value
                            Case "Intro" : lif.Intro = sr.ReadToEnd
                        End Select
                    End If

                Loop Until sr.EndOfStream
            End Using
        End Using

        Return lif
    End Function

    Private Sub PutInfToUI(InfItem As KzLibInfo)
        With InfItem
            TypeBox.SelectedItem = .Type
            IDBox.Text = .ID
            TitleBox.Text = .Title
            SubtitleBox.Text = .Subtitle
            SeriesBox.Text = .Series
            AuthorBox.Text = .Author
            AuthorInfoButton.Tag = .AuthorInfo
            PublishInfoBox.Text = .PublishInfo
            VersionBox.Text = .Version
            CategoryBox.Text = .Category
            SpecialBox.Text = .Special
            UpdatedBox.Text = .Updated
            'LinkBox.Text = .ViewLink
            ViewLinkButton.Tag = .ViewLink
            DownLinkButton.Tag = .DownloadLink
            CoverLinkButton.Tag = .CoverLink
            IntroBox.Text = .Intro
            CoverBox.Tag = .Cover
            If .Cover Is Nothing Or .Cover = "" Then .Cover = "cover"
            ShowImg(Path.Combine(LibPathLabel.Text, .Cover))
        End With
    End Sub

    Private Function PutInfToText(InfItem As KzLibInfo) As String
        Dim dsb As New StringBuilder
        dsb.AppendLine("Type:" & [Enum].GetName(GetType(KzLibInfoType), TypeBox.SelectedItem))
        dsb.AppendLine("ID:" & IDBox.Text)
        dsb.AppendLine("Title:" & TitleBox.Text)
        dsb.AppendLine("Subtitle:" & SubtitleBox.Text)
        dsb.AppendLine("Series:" & SeriesBox.Text)
        dsb.AppendLine("Author:" & AuthorBox.Text)
        dsb.AppendLine("AuthorInfo:")
        dsb.AppendLine("PublishInfo:" & PublishInfoBox.Text)
        dsb.AppendLine("Version:" & VersionBox.Text)
        dsb.AppendLine("Category:" & CategoryBox.Text)
        dsb.AppendLine("Special:" & SpecialBox.Text)
        If CoverBox.Tag Is Nothing Then
            dsb.AppendLine("Cover:")
        Else
            dsb.AppendLine("Cover:" & CoverBox.Tag.ToString)
        End If

        dsb.AppendLine("Address:\" & Path.GetFileName(LibView.SelectedNode.FullPath))

        Dim sb As New StringBuilder
        With FilesView
            For i As Integer = 0 To .Items.Count - 1
                If .Items(i).SubItems(4).Text.Length > 0 Then
                    sb.Append(.Items(i).SubItems(0).Text)
                    sb.Append("^")
                    sb.Append(.Items(i).SubItems(1).Text)
                    sb.Append("^")
                    sb.Append(.Items(i).SubItems(4).Text)
                    sb.Append("|")
                End If
            Next

            If sb.ToString.EndsWith("|") Then
                sb.Remove(sb.Length - 1, 1)
            End If
        End With

        dsb.AppendLine("FileComments:" & sb.ToString)
        dsb.AppendLine("Updated:" & Now().ToString)
        dsb.AppendLine("ViewLink:" & If(ViewLinkButton.Tag IsNot Nothing, ViewLinkButton.Tag, ""))
        dsb.AppendLine("DownloadLink:" & If(DownLinkButton.Tag IsNot Nothing, DownLinkButton.Tag, ""))
        dsb.AppendLine("CoverLink:" & If(CoverLinkButton.Tag IsNot Nothing, CoverLinkButton.Tag, ""))
        dsb.AppendLine("Intro:")
        dsb.Append(IntroBox.Text)

        Return dsb.ToString
    End Function

    Private Sub PutInfToFile(InfItem As KzLibInfo, FilePath As String)
        File.WriteAllText(FilePath, PutInfToText(InfItem), Encoding.UTF8)
        'Using fs As FileStream = New FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite)
        '    Using sw As StreamWriter = New StreamWriter(fs, Encoding.UTF8)
        '        sw.WriteLine("Type:" & [Enum].GetName(GetType(KzLibInfoType), TypeBox.SelectedItem))
        '        sw.WriteLine("ID:" & IDBox.Text)
        '        sw.WriteLine("Title:" & TitleBox.Text)
        '        sw.WriteLine("Subtitle:" & SubtitleBox.Text)
        '        sw.WriteLine("Author:" & AuthorBox.Text)
        '        sw.WriteLine("AuthorInfo:")
        '        sw.WriteLine("PublishInfo:" & PublishInfoBox.Text)
        '        sw.WriteLine("Version:" & VersionBox.Text)
        '        sw.WriteLine("Category:" & CategoryBox.Text)
        '        sw.WriteLine("Special:" & SpecialBox.Text)
        '        If CoverBox.Tag Is Nothing Then
        '            sw.WriteLine("Cover:")
        '        Else
        '            sw.WriteLine("Cover:" & CoverBox.Tag.ToString)
        '        End If

        '        sw.WriteLine("Address:\" & Path.GetFileName(LibView.SelectedNode.FullPath))

        '        Dim sb As New StringBuilder
        '        With FilesView
        '            For i As Integer = 0 To .Items.Count - 1
        '                If .Items(i).SubItems(4).Text.Length > 0 Then
        '                    sb.Append(.Items(i).SubItems(0).Text)
        '                    sb.Append("^")
        '                    sb.Append(.Items(i).SubItems(1).Text)
        '                    sb.Append("^")
        '                    sb.Append(.Items(i).SubItems(4).Text)
        '                    sb.Append("|")
        '                End If
        '            Next

        '            If sb.ToString.EndsWith("|") Then
        '                sb.Remove(sb.Length - 1, 1)
        '            End If
        '        End With

        '        sw.WriteLine("FileComments:" & sb.ToString)
        '        sw.WriteLine("Updated:" & Now().ToString)
        '        sw.WriteLine("Intro:")
        '        sw.Write(IntroBox.Text)
        '    End Using
        'End Using
    End Sub

    Private Function GetFileComments() As String
        Dim sb As New StringBuilder
        With FilesView
            For i As Integer = 0 To .Items.Count - 1
                If .Items(i).SubItems(4).Text.Length > 0 Then
                    sb.Append(.Items(i).SubItems(0).Text)
                    sb.Append("^")
                    sb.Append(.Items(i).SubItems(1).Text)
                    sb.Append("^")
                    sb.Append(.Items(i).SubItems(4).Text)
                    sb.Append("|")
                End If
            Next

            If sb.ToString.EndsWith("|") Then
                sb.Remove(sb.Length - 1, 1)
            End If
        End With

        Return sb.ToString
    End Function

    Private Sub ShowImg(imgFile As String)
        Dim sb As New StringBuilder("Image ")
        Try
            Dim fi As New FileInfo(imgFile)
            Dim img As Image = Image.FromFile(imgFile)
            With img
                sb.AppendLine(" [" & fi.Extension & "]")
                sb.AppendLine("Size: ")
                sb.AppendLine(" " & .Width & " x " & .Height & " pixel")
                sb.AppendLine("Resolution: ")
                sb.AppendLine(If(.HorizontalResolution = .VerticalResolution, " " & .HorizontalResolution & "dpi", " " & .HorizontalResolution & " x " & .VerticalResolution & "dpi"))
                sb.AppendLine("AbsSize: ")
                sb.AppendLine(" " & Math.Round(.HorizontalResolution / .Width * 2.54, 2) & " x " & Math.Round(.VerticalResolution / .Height * 2.54, 2) & " cm")
                sb.AppendLine("Length: ")
                sb.AppendLine(" " & fi.Length)
            End With

            CoverBox.Image = img
        Catch ex As Exception
            sb.AppendLine("[-]")
            CoverBox.Image = Nothing
        End Try

        ImgInfoLabel.Text = sb.ToString
    End Sub

    Private Sub Download(Link As String, Optional SaveTo As String = Nothing)
        If SaveTo Is Nothing Then
            Dim sfd As New SaveFileDialog
            If LibView.SelectedNode IsNot Nothing Then
                sfd.InitialDirectory = LibView.SelectedNode.FullPath
            Else
                Try
                    sfd.InitialDirectory = My.Settings.HDLibPath
                Catch ex As Exception

                End Try
            End If

            If sfd.ShowDialog = DialogResult.OK Then
                SaveTo = sfd.FileName
            Else
                Exit Sub
            End If
        End If

        Dim wc As WebClient = New WebClient
        Dim url As Uri = New Uri(Link)

        AddHandler wc.DownloadProgressChanged, AddressOf wc_DownloadProgressChanged
        AddHandler wc.DownloadFileCompleted, AddressOf wc_DownloadFileCompleted
        wc.DownloadFileAsync(url, SaveTo)
    End Sub

    Private Sub wc_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        AnyProgress.Maximum = 100
        AnyProgress.Value = CInt(Math.Floor(e.BytesReceived * 100 / e.TotalBytesToReceive))
    End Sub

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        MsgBox("下載完成。")
    End Sub


#End Region 'PrivateMethods


#Region "ClickedMenuActions"
    Private Sub LibMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles LibMenu.ItemClicked

        If e.ClickedItem.Equals(LibLevelItem) Then
            LibLevelItem.Checked = Not LibLevelItem.Checked
        End If
        '新增
        If e.ClickedItem.Equals(LibBookItem) Or
            e.ClickedItem.Equals(LibAuthorItem) Or
            e.ClickedItem.Equals(LibCategoryItem) Or
            e.ClickedItem.Equals(LibSpecialItem) Then

            If Not LibView.SelectedNode.IsEditing Then
                Dim NewNode As New TreeNode("New")

                If e.ClickedItem.Equals(LibBookItem) Then NewNode.Tag = "Book.kzinf"
                If e.ClickedItem.Equals(LibAuthorItem) Then NewNode.Tag = "Author.kzinf"
                If e.ClickedItem.Equals(LibCategoryItem) Then NewNode.Tag = "Category.kzinf"
                If e.ClickedItem.Equals(LibSpecialItem) Then NewNode.Tag = "Special.kzinf"

                If LibLevelItem.Checked Then
                    LibView.SelectedNode.Nodes.Add(NewNode)
                    LibView.SelectedNode.Expand()
                Else
                    If Not LibView.SelectedNode.Parent Is Nothing Then
                        LibView.SelectedNode.Parent.Nodes.Add(NewNode)
                    End If
                End If

                NewNode.BeginEdit()
            End If
        End If
        '更名
        If e.ClickedItem.Equals(LibRenameItem) Then
            If Not LibView.SelectedNode.Parent Is Nothing Then
                LibView.SelectedNode.Tag = "Rename"
                LibView.SelectedNode.BeginEdit()
            End If
        End If
        '複製，剪切
        If e.ClickedItem.Equals(LibCopyItem) Or
            e.ClickedItem.Equals(LibCutItem) Then

            If Not LibView.SelectedNode.Parent Is Nothing Then
                CopiedNode = LibView.SelectedNode
            End If

            LibPasteItem.Enabled = True
        End If
        '粘貼
        If e.ClickedItem.Equals(LibPasteItem) Then


            LibAuthorItem.Enabled = False
        End If
        '刪除
        If e.ClickedItem.Equals(LibDeleteItem) Then
            If Not LibView.SelectedNode.Parent Is Nothing Then
                Dim s As String = "此舉將刪除選定的資料夾。是否繼續？" + vbCrLf +
                    "【是】資料夾 " + LibView.SelectedNode.FullPath + " 及其子項目將被刪除。" + vbCrLf +
                    "【否】將不執行任何操作。"

                If MsgBox(s, MsgBoxStyle.YesNo, "刪除") = MsgBoxResult.Yes Then
                    Try
                        Directory.Delete(LibView.SelectedNode.FullPath, True)

                        Dim tempNode As TreeNode
                        If LibView.SelectedNode.NextNode IsNot Nothing Then
                            tempNode = LibView.SelectedNode.NextNode
                        ElseIf LibView.SelectedNode.PrevNode IsNot Nothing Then
                            tempNode = LibView.SelectedNode.PrevNode
                        Else
                            tempNode = LibView.SelectedNode.Parent
                        End If
                        LibView.SelectedNode.Remove()
                        LibView.SelectedNode = tempNode
                    Catch ex As Exception
                        MsgBox("資料夾未能刪除。原因：" + vbCrLf + ex.Message, MsgBoxStyle.OkOnly, "刪除")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub FilesMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles FilesMenu.ItemClicked

        If FilesView.SelectedItems.Count > 0 Then
            With FilesView.SelectedItems(0)
                If e.ClickedItem.Equals(FileImportItem) Then

                End If

                If e.ClickedItem.Equals(FileRenameItem) Then
                    FilesView.SelectedItems(0).BeginEdit()
                End If

                If e.ClickedItem.Equals(FileDeleteItem) Then

                End If

                If e.ClickedItem.Equals(FileSetCoverItem) Then
                    If .SubItems(2).Text = "圖像" Then
                        CoverBox.Tag = .SubItems(0).Text
                        .SubItems(4).Text = "封面"

                        SaveInfButton.Enabled = True
                    End If
                End If
            End With
        End If

        If e.ClickedItem.Equals(FilePasteItem) Then

        End If
    End Sub

    Private Sub UpdateDBButton_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles UpdateDBButton.DropDownItemClicked

        If e.ClickedItem.Equals(DataAllItem) Then

        End If
    End Sub

    Private Sub TryGetFromWebItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TryGetFromWebItem.DropDownItemClicked
        If e.ClickedItem.Equals(TryCategoryItem) Then

        End If

        If e.ClickedItem.Equals(TryViewLinkItem) Then
            If ViewLinkButton.Tag Is Nothing Then
                ViewLinkButton.Tag = HDBrowser.Url.ToString
            Else
                Dim s As String = "瀏覽鏈接已被設置為 " & ViewLinkButton.Tag & vbCrLf &
                    "，是否更改為 " & HDBrowser.Url.ToString

                If MsgBox(s, MsgBoxStyle.YesNo, "更改") = MsgBoxResult.Yes Then
                    ViewLinkButton.Tag = HDBrowser.Url.ToString
                End If
            End If
        End If
    End Sub

#End Region 'ClickedMenuActions

#Region "TempBlock"
    Private Sub TryGetFromWebItem_Click(sender As Object, e As EventArgs) Handles TryGetFromWebItem.Click
        If HDBrowser.Document Is Nothing Then
            Exit Sub
        End If

        If Not (NodeInfoLabel.Text = "[Book]" Or
            NodeInfoLabel.Text = "[Potential]" Or
            NodeInfoLabel.Text = "[Blank]") Then
            Exit Sub
        End If

        Dim src As String = KzWeb.GetWebCode(HDBrowser.Url.AbsoluteUri)
        Dim key As String
        Dim t As String
        Dim err As String = ""

        Try
            key = Regex.Match(src, "SetTitle\(.+\);").ToString.Replace("SetTitle(""", "").Replace(""");", "")
            Dim l, r As Char
            If key.Contains("《") Then
                l = "《"
                r = "》"
            ElseIf key.Contains("【") Then
                l = "【"
                r = "】"
            End If
            AuthorBox.Text = key.Substring(0, key.IndexOf(l))
            TitleBox.Text = key.Substring(key.IndexOf(l) + 1, key.IndexOf(r) - key.IndexOf(l) - 1)
        Catch ex As Exception
            err &= "[SetTitle] 未能取得 Title 及 Author。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "SetLink\(.+\);").ToString
            t = key.Substring(key.IndexOf(">") + 1, key.IndexOf("</a>") - key.IndexOf(">") - 1)
            CategoryBox.Text = t.Replace(" 書目", "")
        Catch ex As Exception
            err &= "[SetLink] 未能取得 Category。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "DownloadUpdb\(.+?\<br").ToString
            IDBox.Text = key.Substring(key.IndexOf("(") + 1, key.IndexOf(")") - key.IndexOf("(") - 1).Replace("'", "")
            t = key.Substring(key.IndexOf("<font size=2>") + 14, key.IndexOf("</font><br") - key.IndexOf("<font size=2>") - 14)
            t = Regex.Replace(t, "\(.+\)", "-")
            If t.EndsWith("-") Then t.Replace("-", "").Trim()
            VersionBox.Text = t
            DownLinkButton.Tag = "http://www.haodoo.net/?M=d&P=" & IDBox.Text
        Catch ex As Exception
            err &= "[DownloadUpdb] 未能取得 ID 或 Version。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "\<img src\=""covers.+HSPACE\=").ToString
            t = key.Substring(key.IndexOf("covers"), key.IndexOf("""", key.IndexOf("covers")) - key.IndexOf("covers"))
            CoverLinkButton.Tag = "http://www.haodoo.net/" & t
        Catch ex As Exception
            err &= "[img src] 未能取得 Cover。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "HSPACE\=.+勘誤表", RegexOptions.Singleline).ToString
            t = key.Replace("勘誤表", "")
            t = Regex.Replace(t, "HSPACE\=.+?\>", "")
            t = Regex.Replace(t, "\<.+?\>", "")
            t = t.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf & vbCrLf)
            IntroBox.Text = t
        Catch ex As Exception
            err &= "[Intro] 未能取得 Intro。"            '
        End Try

        If err.Length > 0 Then
            MsgBox("源格式不匹配。以下元素未能取得：" & vbCrLf & err)
        End If

        ViewLinkButton.Tag = HDBrowser.Url.ToString
        TypeBox.SelectedItem = KzLibInfoType.Book
    End Sub

    Private Sub IntroBox_TextChanged(sender As Object, e As EventArgs) _
        Handles IntroBox.TextChanged, IDBox.TextChanged, AuthorBox.TextChanged, TitleBox.TextChanged,
        SubtitleBox.TextChanged, SerialBox.TextChanged, PublishInfoBox.TextChanged,
        VersionBox.TextChanged, CategoryBox.TextChanged, SpecialBox.TextChanged,
        TypeBox.SelectedIndexChanged

        Try
            If LibView.SelectedNode.Equals(LibView.Nodes.Item(0)) Then
                SaveInfButton.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub IntroBox_DragEnter(sender As Object, e As DragEventArgs) _
        Handles IntroBox.DragEnter, IDBox.DragEnter, AuthorBox.DragEnter, TitleBox.DragEnter,
        SubtitleBox.DragEnter, SerialBox.DragEnter, PublishInfoBox.DragEnter,
        VersionBox.DragEnter, CategoryBox.DragEnter, SpecialBox.DragEnter

        If (e.Data.GetDataPresent("Text")) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub IntroBox_DragDrop(sender As Object, e As DragEventArgs) _
        Handles IntroBox.DragDrop, IDBox.DragDrop, AuthorBox.DragDrop, TitleBox.DragDrop,
        SubtitleBox.DragDrop, SerialBox.DragDrop, PublishInfoBox.DragDrop,
        VersionBox.DragDrop, CategoryBox.DragDrop, SpecialBox.DragDrop

        CType(sender, TextBox).Paste(e.Data.GetData("Text"))
    End Sub

    Private Sub ViewLinkButton_MouseEnter(sender As Object, e As EventArgs) _
        Handles ViewLinkButton.MouseEnter, CoverLinkButton.MouseEnter, DownLinkButton.MouseEnter

        LinksLabel.Text = CType(sender, Button).Tag
        If LinksLabel.Text Is Nothing Or LinksLabel.Text = "" Then
            LinksLabel.Text = "<Empty>"
        End If
    End Sub

    Private Sub ViewLinkButton_MouseLeave(sender As Object, e As EventArgs) _
        Handles ViewLinkButton.MouseLeave, CoverLinkButton.MouseLeave, DownLinkButton.MouseLeave

        LinksLabel.Text = "<Link>"
    End Sub

    Private Sub LinkButton_Click(sender As Object, e As EventArgs) _
        Handles DownLinkButton.Click, CoverLinkButton.Click, ViewLinkButton.Click

        Dim bt As Button = CType(sender, Button)
        With bt
            If bt.Tag Is Nothing Then
                MsgBox(bt.Text & " 鏈接未設置，中斷操作。")
                Exit Sub
            End If

            Dim wc As New WebClient
            Dim link As String
            Try
                link = CType(.Tag, String)
                Dim str As String = wc.DownloadString(CType(.Tag, String))
            Catch ex As Exception
                MsgBox(bt.Text & " 鏈接訪問異常，中斷操作。")
                Exit Sub
            End Try

            If Not .Equals(ViewLinkButton) Then
                Try
                    Dim fn As String = link.Substring(link.LastIndexOf("/") + 1)
                    Dim saveto As String = Path.Combine(LibView.SelectedNode.FullPath, fn)

                    If File.Exists(saveto) Then
                        Dim s As String = "即將下載的文檔已經存在同名檔，是否更名繼續？" & vbCrLf &
                            "【是】下載文檔將更名後保存。" & vbCrLf & "【否】覆蓋同名檔保存。" & vbCrLf & "【取消】終止下載。"
                        Dim r As MsgBoxResult = MsgBox(s, MsgBoxStyle.YesNo, "保存")

                        If r = MsgBoxResult.Yes Then
                            saveto = Path.GetDirectoryName(saveto) &
                                Path.GetFileNameWithoutExtension(saveto) & "_" &
                                KzStr.GetTimeSerial(Now()) & Path.GetExtension(saveto)

                        ElseIf r = MsgBoxResult.Cancel Then
                            MsgBox("下載操作已被用戶終止。")
                            Exit Sub
                        End If
                    End If

                    Download(link, saveto)

                    If .Equals(CoverLinkButton) Then
                        CoverBox.Tag = fn
                        ShowImg(saveto)
                    End If

                    SaveInfButton.Enabled = True
                Catch ex As Exception
                    MsgBox("未能下載文檔。原因：" & vbCrLf & ex.Message)
                End Try

            Else
                HDBrowser.Navigate(link)
            End If
        End With
    End Sub

    Private Sub UrlLabel_Click(sender As Object, e As EventArgs) Handles UrlLabel.DoubleClick
        ViewLinkButton.Tag = UrlLabel.Text
    End Sub

    Private Sub CleanUpButton_Click(sender As Object, e As EventArgs) Handles CleanUpButton.Click
        LibView.Sort()
    End Sub

    Private Sub AbortInfButton_Click(sender As Object, e As EventArgs) Handles AbortInfButton.Click
        PutInfToUI(CurrentInf)
    End Sub

    Private Sub LibView_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles LibView.BeforeSelect
        If Not LibView.SelectedNode Is Nothing Then
            If SaveInfButton.Enabled Then
                Dim s As String = "當前咨詢已經更改，是否保存？" & vbCrLf &
                    "【是】保存當前資訊檔後執行跳轉選定。" & vbCrLf &
                    "【否】不保存當前資訊即跳轉。" & vbCrLf & "【取消】終止執行跳轉。"
                Dim r As MsgBoxResult = MsgBox(s, MsgBoxStyle.YesNo, "跳轉")

                If r = MsgBoxResult.Yes Then
                    MsgBox("Need save")
                ElseIf r = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub



#End Region


End Class

Public Class KzLibInfo
    Public Sub New()

    End Sub

    Public Property Type As KzLibInfoType = KzLibInfoType.Root
    Public Property ID As String '= "<id>"
    Public Property Title As String '= "<title>"
    Public Property Subtitle As String '= "<subtitle>"
    Public Property Author As String '= "<author>"
    Public Property AuthorInfo As String '= "<authorinfo>"
    Public Property PublishInfo As String '= "<publishinfo>"
    Public Property Version As String '= "<version>"
    Public Property Category As String '= "<category>"
    Public Property Special As String '= "<special>"
    Public Property Cover As String '= "<cover>"
    Public Property Address As String '= ""
    Public Property FileComments As String() = {}
    Public Property Updated As String '= "<updated>"
    Public Property Intro As String '= "<intro>"
    Public Property ViewLink As String
    Public Property DownloadLink As String
    Public Property CoverLink As String
    Public Property Series As String
End Class

Public Enum KzLibInfoType
    Root
    Book
    Author
    Category
    Special
End Enum

