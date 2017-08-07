Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.Text

Public Class HDLibForm

    Private Sub HDLibForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        For i As Integer = 0 To [Enum].GetNames(GetType(KzLibInfType)).Count - 1
            TypeBox.Items.Add(CType(i, KzLibInfType))
        Next

        HDBrowser.Navigate(My.Settings.HDLibHome)

        LinkPopLabel.Text = ""
        LinkPopLabel.BackColor = Color.SeaGreen
        LinkPopLabel.ForeColor = Color.WhiteSmoke

        LibNewLevelCombo.SelectedIndex = 0

        LibView.StartDirectory = My.Settings.HDLibPath
        LibView.RefreshTree()
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
        'AddHandler HDBrowser.Document.MouseOver, AddressOf DisplayHyperlinks

        'Dim hes As HtmlElementCollection = HDBrowser.Document.GetElementsByTagName("input")
        ''MsgBox(hes.Count)
        'For Each he As HtmlElement In hes
        '    'Console.WriteLine(he.GetAttribute("onclick"))
        '    If he.GetAttribute("value") = "下載 updb 檔" Then
        '        Console.WriteLine("下載 updb 檔")
        '        Console.WriteLine(he.GetAttribute("onclick"))
        '        he.InvokeMember("click")
        '        'Dim obj = he.DomElement
        '        'Dim mi = obj.GetType().GetMethod("click")

        '        'Dim objs As Object() = {}
        '        'mi.Invoke(obj, objs)
        '    End If
        'Next
    End Sub

    Public Sub DisplayHyperlinks(ByVal sender As Object, ByVal e As HtmlElementEventArgs)
        'Dim s As String = e.ToElement.GetAttribute("href")
        'Dim s As String = e.ToElement.GetAttribute("src")
        'LinkPopLabel.Text = s
        'If Not s.EndsWith(".jpg") Then
        '   
        'End If
        'Dim es As HtmlElementCollection = e.ToElement.GetElementsByTagName("a")
        'For Each el As HtmlElement In es
        '    LinkPopLabel.Text = el.GetAttribute("href") ' e.ToElement.GetAttribute("href")
        'Next

        'LinkPopLabel.Text = e.ToElement.GetAttribute("href")
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

    'Private Sub HDBrowser_SizeChanged(sender As Object, e As EventArgs) Handles HDBrowser.SizeChanged
    '    'LinkPopLabel.Location = New Point(3, HDBrowser.ClientRectangle.Height - 5)
    '    'Console.WriteLine(LinkPopLabel.Location.ToString + " | " + HDBrowser.Size.ToString)
    'End Sub

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

    Private Sub SwitchListButton_Click(sender As Object, e As EventArgs) Handles SwitchListButton.Click
        If LibSpliter.Panel1Collapsed Then
            LibSpliter.Panel1Collapsed = False
        Else
            LibSpliter.Panel1Collapsed = True
        End If
    End Sub

#End Region 'BrowserCode

#Region "LibCode"

    Public ReadOnly Property LibInf As KzLibInfItem
        Get
            CurrentInf = GetInfFromUI()
            Return CurrentInf
        End Get
    End Property

    Private Sub LibPathButton_Click(sender As Object, e As EventArgs) Handles LibPathButton.Click
        Dim fbd As New FolderBrowserDialog
        fbd.ShowNewFolderButton = True

        If Directory.Exists(LibView.StartDirectory) Then
            fbd.RootFolder = LibView.StartDirectory
        End If

        If fbd.ShowDialog = DialogResult.OK Then
            LibView.StartDirectory = fbd.SelectedPath
            My.Settings.HDLibPath = fbd.SelectedPath
            LibView.RefreshTree()
        End If
    End Sub

    Private Sub LibView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LibView.AfterSelect
        IndicatedBox.Text = e.Node.Text
        LibPathLabel.Text = e.Node.FullPath

        Dim di As New DirectoryInfo(e.Node.FullPath)
        Dim fis As FileInfo()
        '===================================================================
        '判斷資料夾形式，如為 Book，將內容投放至 UI
        fis = di.GetFiles("*.kzinf", SearchOption.TopDirectoryOnly)
        CurrentInf = New KzLibInfItem
        If fis.Length = 1 Then
            CurrentInf = GetInfFromFile(fis(0))
            If fis(0).Name = "book.kzinf" Then
                NodeInfoLabel.Text = "Node:Book"
                'DataPanel.BackColor = Color.Ivory
            Else
                If fis(0).Name = "lib.kzinf" Then
                    NodeInfoLabel.Text = "Node:Lib"
                    'DataPanel.BackColor = Color.AliceBlue
                ElseIf fis(0).Name = "category.kzinf" Then
                    NodeInfoLabel.Text = "Node:Category"
                    'DataPanel.BackColor = Color.LightCoral
                ElseIf fis(0).Name = "special.kzinf" Then
                    NodeInfoLabel.Text = "Node:Special"
                    'DataPanel.BackColor = Color.LightCyan
                ElseIf fis(0).Name = "author.kzinf" Then
                    NodeInfoLabel.Text = "Node:Author"
                    'DataPanel.BackColor = Color.LightGreen
                Else
                    NodeInfoLabel.Text = "Node:Other"
                    'DataPanel.BackColor = Color.LightGray
                End If
            End If
        ElseIf fis.Length > 1 Then
            NodeInfoLabel.Text = "Node:Sample"
            'DataPanel.BackColor = Color.LightGray
        Else
            NodeInfoLabel.Text = "Node:Blank"
            'DataPanel.BackColor = Color.WhiteSmoke
        End If

        PutInfToUI(CurrentInf)
        '===================================================================
        '將當前資料夾中的文檔列表投放至 ListView
        fis = di.GetFiles
        FilesLabel.Text = "Files: " & fis.Count
        Dim item As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem()
        Dim ext As String
        Dim canbebook As Boolean = False
        FilesView.Items.Clear()
        For i = 0 To fis.Length - 1
            ext = GetFileType(fis(i).Extension)

            If ext = "書籍" Then
                canbebook = True
            End If

            item = New ListViewItem(fis(i).Name)
            subitems = {
                New ListViewItem.ListViewSubItem(item, "-"),
                New ListViewItem.ListViewSubItem(item, ext),
                New ListViewItem.ListViewSubItem(item, fis(i).Length),
                New ListViewItem.ListViewSubItem(item, "")}
            item.SubItems.AddRange(subitems)
            FilesView.Items.Add(item)
        Next

        If canbebook And NodeInfoLabel.Text = "Node:Blank" Then
            NodeInfoLabel.Text = "Node:Potential"
        End If
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

        CoverButton.Enabled = False
        ReCoverButton.Enabled = False
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim tid As New KzTextInputDialog
        tid.Subject = "Test input:"
        tid.LongText = True
        If tid.ShowDialog() = DialogResult.OK Then
            MsgBox(tid.Contents)
        End If

        tid.Dispose()
    End Sub

    Private Sub FilesView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilesView.SelectedIndexChanged
        With FilesView
            If .SelectedItems.Count > 0 Then
                If .SelectedItems(0).SubItems(2).Text = "圖像" Then
                    ShowImg(Path.Combine(LibPathLabel.Text, .SelectedItems(0).Text))
                    CoverButton.Enabled = True
                    ReCoverButton.Enabled = True
                Else
                    CoverButton.Enabled = False
                    ReCoverButton.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub ReCoverButton_Click(sender As Object, e As EventArgs) Handles ReCoverButton.Click
        If FilesView.SelectedItems.Count > 0 Then
            If FilesView.SelectedItems(0).SubItems(2).Text = "圖像" Then
                CoverBox.Tag = FilesView.SelectedItems(0).SubItems(0).Text
            End If
        End If
    End Sub

    Private Sub CoverButton_Click(sender As Object, e As EventArgs) Handles CoverButton.Click
        ShowImg(Path.Combine(LibPathLabel.Text, CoverBox.Tag))
    End Sub

    'Private Sub LibTreeView_AfterExpand(sender As Object, e As TreeViewEventArgs)
    '    e.Node.Expand()
    '    'ShowSubDirectories(CType(e.Node, DirectoryNode))
    'End Sub

#End Region 'LibCode

#Region "PrivateMethods"
    Private CurrentInf As KzLibInfItem

    Private Function GetFileType(extension As String) As String
        Select Case extension.ToLower
            Case ".updb", ".prc", ".mobi", ".epub"
                Return "書籍"' "Package"
            Case ".doc", ".docx", ".txt", ".rtf"
                Return "文檔" '"Editable"
            Case ".pdf"
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

    Private Function GetInfFromUI() As KzLibInfItem
        Dim lif As New KzLibInfItem

        With lif
            .Type = TypeBox.SelectedItem
            .ID = IDBox.Text
            .Title = TitleBox.Text
            .Subtitle = SubtitleBox.Text
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
            .Intro = IntroBox.Text
        End With

        Return lif
    End Function

    Private Function GetInfFromFile(InfFile As FileInfo) As KzLibInfItem
        Dim lif As New KzLibInfItem

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
                            Case "Type" : lif.Type = [Enum].Parse(GetType(KzLibInfType), value)
                            Case "ID" : lif.ID = value
                            Case "Title" : lif.Title = value
                            Case "Subtitle" : lif.Subtitle = value
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
                            Case "Intro" : lif.Intro = sr.ReadToEnd
                        End Select
                    End If

                Loop Until sr.EndOfStream
            End Using
        End Using

        Return lif
    End Function

    Private Sub PutInfToUI(InfItem As KzLibInfItem)
        With InfItem
            TypeBox.SelectedItem = .Type
            IDBox.Text = .ID
            TitleBox.Text = .Title
            SubtitleBox.Text = .Subtitle
            AuthorBox.Text = .Author
            AuthorInfoButton.Tag = .AuthorInfo
            PublishInfoBox.Text = .PublishInfo
            VersionBox.Text = .Version
            CategoryBox.Text = .Category
            SpecialBox.Text = .Special
            UpdatedBox.Text = .Updated
            IntroBox.Text = .Intro
            CoverBox.Tag = .Cover
            If .Cover Is Nothing Or .Cover = "" Then .Cover = "cover"
            ShowImg(Path.Combine(LibPathLabel.Text, .Cover))
        End With
    End Sub

    Private Function PutInfToText(InfItem As KzLibInfItem) As String
        Dim dsb As New StringBuilder
        dsb.AppendLine("Type:" & [Enum].GetName(GetType(KzLibInfType), TypeBox.SelectedItem))
        dsb.AppendLine("ID:" & IDBox.Text)
        dsb.AppendLine("Title:" & TitleBox.Text)
        dsb.AppendLine("Subtitle:" & SubtitleBox.Text)
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
        dsb.AppendLine("Intro:")
        dsb.Append(IntroBox.Text)

        Return dsb.ToString
    End Function

    Private Sub PutInfToFile(InfItem As KzLibInfItem, FilePath As String)
        File.WriteAllText(FilePath, PutInfToText(InfItem), Encoding.UTF8)
        'Using fs As FileStream = New FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite)
        '    Using sw As StreamWriter = New StreamWriter(fs, Encoding.UTF8)
        '        sw.WriteLine("Type:" & [Enum].GetName(GetType(KzLibInfType), TypeBox.SelectedItem))
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

#End Region 'PrivateMethods

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim sf As String = [Enum].GetName(GetType(KzLibInfType), TypeBox.SelectedItem) & ".kzinf"

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
            End If
        End If

        Try
            PutInfToFile(GetInfFromUI(), Path.Combine(LibView.SelectedNode.FullPath, sf))
            MsgBox("資訊檔 \" & Path.GetFileName(LibView.SelectedNode.FullPath) & "\" & sf & " 保存完畢。", MsgBoxStyle.OkOnly, "存檔")
        Catch ex As Exception
            MsgBox("資訊檔 " & Path.Combine(LibView.SelectedNode.FullPath, sf) & " 未能保存。原因：" & vbCrLf & ex.Message, MsgBoxStyle.OkOnly, "存檔")
        End Try

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim tvd As New KzTextViewDialog
        tvd.TextContents = PutInfToText(GetInfFromUI())
        tvd.InfoText = "Save Path: " & Path.Combine(LibView.SelectedNode.FullPath, [Enum].GetName(GetType(KzLibInfType), TypeBox.SelectedItem) & ".kzinf")
        tvd.ShowDialog()
    End Sub

    'Private Sub LibNewBookItem_Click(sender As Object, e As EventArgs) Handles LibNewBookItem.Click
    '    Dim NewBook As New TreeNode("NewBook")

    '    If LibNewLevelCombo.SelectedIndex = 0 Then
    '        LibView.SelectedNode.Parent.Nodes.Add(NewBook)
    '    Else
    '        LibView.SelectedNode.Nodes.Add(NewBook)
    '        LibView.SelectedNode.Expand()
    '    End If

    '    NewBook.BeginEdit()
    'End Sub

    Private Sub LibView_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles LibView.AfterLabelEdit
        MsgBox(e.Node.FullPath & vbCrLf & e.Label & vbCrLf & e.Node.Parent.FullPath & "\" & e.Label)
        Dim np As String = Path.Combine(e.Node.Parent.FullPath, e.Label)

        Try
            If Directory.Exists(e.Node.FullPath) Then
                If e.Label IsNot Nothing Then
                    FileIO.FileSystem.RenameDirectory(e.Node.FullPath, e.Label)
                End If
            Else
                Directory.CreateDirectory(np)
            End If

            Dim fn As String = ""
            Select Case e.Node.Text
                Case "NewBook" : fn = "Book"
                Case "Author" : fn = "Author"
                Case "Category" : fn = "Category"
                Case "Special" : fn = "Special"
                Case Else : fn = "None"
            End Select

            Dim inf As New KzLibInfItem With {
                .Type = KzLibInfType.Book,
                .Title = Path.GetFileName(np),
                .Updated = Now()}


            'TypeBox.SelectedItem = [Enum].Parse(GetType(KzLibInfType), fn)
            'TitleBox.Text = Path.GetFileName(np)
            PutInfToUI(inf)
            PutInfToFile(inf, Path.Combine(np, fn & ".kzinf"))

            LibView.SelectedNode = e.Node

        Catch ex As Exception
            'MsgBox("未能創建資料夾。原因：" & vbCrLf & ex.Message, MsgBoxStyle.OkOnly, "創建")
            'LibView.Nodes.Remove(e.Node)
        End Try
    End Sub

    Private Sub LibView_MouseClick(sender As Object, e As MouseEventArgs) Handles LibView.MouseClick
        If e.Button = MouseButtons.Left Or e.Button = MouseButtons.Right Then
            Dim nd As TreeNode = LibView.GetNodeAt(e.Location)
            If Not nd.Equals(LibView.SelectedNode) Then
                LibView.SelectedNode = nd
            End If
        End If
    End Sub

    Private Sub LibMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles LibMenu.ItemClicked
        If e.ClickedItem.Equals(LibNewBookItem) Then
            Dim NewBook As New TreeNode("NewBook")

            If LibNewLevelCombo.SelectedIndex = 0 Then
                LibView.SelectedNode.Parent.Nodes.Add(NewBook)
            Else
                LibView.SelectedNode.Nodes.Add(NewBook)
                LibView.SelectedNode.Expand()
            End If

            NewBook.BeginEdit()
        End If

        If e.ClickedItem.Equals(ParentItem) Then

        End If
    End Sub

    Private Sub LibView_BeforeLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles LibView.BeforeLabelEdit

    End Sub




#Region "CommandPanels"

#End Region 'CommandPanels
End Class

Public Class KzLibInfItem
    Public Sub New()

    End Sub

    Public Property Type As KzLibInfType = KzLibInfType.None
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
    Public Property Link As String
End Class

Public Enum KzLibInfType
    None
    Book
    Author
    Category
    Special
End Enum

