Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.Text

Public Class HDLibForm

    Private Sub HDLibForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With TypeBox
            For i = 0 To [Enum].GetNames(GetType(KzLibInfType)).Count - 1
                .Items.Add(CType(i, KzLibInfType))
            Next
        End With

        HDBrowser.Navigate(My.Settings.HDLibHome)

        LinkPopLabel.Text = ""
        LinkPopLabel.BackColor = Color.MediumSeaGreen
        LinkPopLabel.ForeColor = Color.WhiteSmoke

        'RootSpliter.Panel2Collapsed = True
        LibPathButton_Click(Nothing, Nothing)
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
        AddHandler HDBrowser.Document.MouseOver, AddressOf DisplayHyperlinks

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

        LinkPopLabel.Text = e.ToElement.GetAttribute("href")
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
        NowLabel.Text = HDBrowser.StatusText
    End Sub

    'Private Sub HDBrowser_SizeChanged(sender As Object, e As EventArgs) Handles HDBrowser.SizeChanged
    '    'LinkPopLabel.Location = New Point(3, HDBrowser.ClientRectangle.Height - 5)
    '    'Console.WriteLine(LinkPopLabel.Location.ToString + " | " + HDBrowser.Size.ToString)
    'End Sub

    Private Sub HDBrowser_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles HDBrowser.Navigated
        UrlLabel.Text = HDBrowser.Url.ToString
    End Sub

    Private Sub HDBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles HDBrowser.Navigating

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

    Private Sub LibPathButton_Click(sender As Object, e As EventArgs) Handles LibPathButton.Click
        'Dim ofd As New FolderBrowserDialog
        Dim SelectedDirectory As String
        Dim SelectedDirectoryNode As DirectoryNode

        If Directory.Exists(My.Settings.HDLibPath) Then
            SelectedDirectory = My.Settings.HDLibPath
        Else
            SelectedDirectory = FolderBrowser.ShowDialog() ' = Environment.SpecialFolder.MyDocuments
            My.Settings.HDLibPath = SelectedDirectory
        End If

        LibView.Nodes.Clear()

        Try
            ' Add the DirectoryNode that represents the selected directory to the
            ' TreeView.
            SelectedDirectoryNode = New DirectoryNode()
            SelectedDirectoryNode.Text = SelectedDirectory
            LibView.Nodes.Add(SelectedDirectoryNode)

            ' Calculate the size of the selected directory by adding up the size of 
            ' all its sub-directories.
            SelectedDirectoryNode.Size += GetDirectorySize(SelectedDirectory, SelectedDirectoryNode)
            'SelectedDirectoryNode.ToolTipText = SelectedDirectoryNode.Size
            LibPathLabel.Text = SelectedDirectory
        Catch exc As Exception
            ' Do nothing. Simply skip any directories that can't be read. Control
            ' passes to the first line after End Try.
            LibPathLabel.Text = "#None"
        End Try

        LibView.Sort()
        LibView.SelectedNode = LibView.Nodes(0)
    End Sub

    Const MB As Long = 1024 * 1024

    ''' <summary>
    ''' This function returns a Color based on the combined size of the directory 
    ''' and all its subdirectories. This is the second of two overloads.
    ''' </summary>
    ''' <param name="intSize"></param>
    ''' <returns></returns>
    Private Function GetSizeColor(ByVal intSize As Long) As System.Drawing.Color
        Select Case intSize
            Case 200 * MB To 500 * MB
                Return System.Drawing.Color.Gold
            Case Is > 500 * MB
                Return System.Drawing.Color.Red
            Case Else
                Return System.Drawing.Color.Green
        End Select
    End Function

    ''' <summary>
    ''' This function returns the size of a directory, and all its sub-directories.
    ''' </summary>
    ''' <param name="strDirPath"></param>
    ''' <param name="dnDriveOrDirectory"></param>
    ''' <returns></returns>
    Public Function GetDirectorySize(ByVal strDirPath As String, ByVal dnDriveOrDirectory As DirectoryNode) As Long
        Try
            Dim astrSubDirectories As String() = Directory.GetDirectories(strDirPath)
            Dim strSubDirectory As String

            ' The size of the current directory is dependent on the size 
            ' of the sub-directories in the array astrSubDirectories. So iterate
            ' through the array and use recursion to end up with the total
            ' size of the current directory and all its sub-directories.
            For Each strSubDirectory In astrSubDirectories
                Dim dnSubDirectoryNode As DirectoryNode
                dnSubDirectoryNode = New DirectoryNode()

                ' Set the node text = to only the last part of the full path.
                dnSubDirectoryNode.Text =
                    strSubDirectory.Remove(0, strSubDirectory.LastIndexOf("\") + 1)

                ' Note that the following line is recursive.
                dnDriveOrDirectory.Size += GetDirectorySize(strSubDirectory, dnSubDirectoryNode)
                dnDriveOrDirectory.Nodes.Add(dnSubDirectoryNode)
            Next

            ' Add to the size calcutate above all of the files in the current 
            ' directory.
            Dim astrFiles As String() = Directory.GetFiles(strDirPath)
            Dim strFileName As String
            Dim Size As Long = 0

            For Each strFileName In astrFiles
                dnDriveOrDirectory.Size += New FileInfo(strFileName).Length
            Next

            ' Set the color of the TreeNode based on the total calculated size.
            dnDriveOrDirectory.ForeColor = GetSizeColor(dnDriveOrDirectory.Size)

        Catch exc As Exception
            ' Do nothing. Simply skip any directories that can't be read. Control
            ' passes to the first line after End Try.
        End Try

        ' Return the total size for this directory.
        Return dnDriveOrDirectory.Size
    End Function

    '''' <summary>
    '''' When a directory node is expanded, add its subdirectories to the ListView. 
    '''' </summary>
    'Public Sub ShowSubDirectories(ByVal dnDrive As DirectoryNode)
    '    Dim strSubDirectory As DirectoryNode

    '    ListView1.Items.Clear()

    '    For Each strSubDirectory In dnDrive.Nodes
    '        AddToListView(Format(strSubDirectory.Size / MB, "F") + "MB",
    '            strSubDirectory.Text)
    '    Next
    'End Sub

    Private Sub LibTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LibView.AfterSelect
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
    End Sub

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

    Private Sub LibTreeView_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles LibView.AfterExpand
        e.Node.Expand()
        'ShowSubDirectories(CType(e.Node, DirectoryNode))
    End Sub

#End Region 'LibCode

    Private CurrentInf As KzLibInfItem

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
            .Cover = CoverBox.Tag.ToString
            .Address = "\" & Path.GetFileName(LibView.SelectedNode.FullPath)
            .FileComments = GetFileComments().Split("|")
            .InfoUpdated = Now().ToString
            .Intro = IntroBox.Text
        End With

        Return lif
    End Function

    Private Function GetInfFromFile(InfFile As FileInfo) As KzLibInfItem
        'LibPathLabel.Text = node.FullPath
        Dim lif As New KzLibInfItem

        Using fs As FileStream = New FileStream(InfFile.FullName, FileMode.Open, FileAccess.Read)
            Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                Dim line, head, value As String
                Dim pos As Integer

                Do
                    line = sr.ReadLine()
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
                        Case "InfoUpdated" : lif.InfoUpdated = value
                        Case "Intro" : lif.Intro = sr.ReadToEnd
                    End Select
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
            InfoUpdatedBox.Text = .InfoUpdated
            IntroBox.Text = .Intro
            CoverBox.Tag = .Cover
            If .Cover Is Nothing Or .Cover = "" Then .Cover = "cover"
            ShowImg(Path.Combine(LibPathLabel.Text, .Cover))
            'Try
            '    CoverBox.Image = Image.FromFile(Path.Combine(LibPathLabel.Text, .Cover))
            'Catch ex As Exception
            '    CoverBox.Image = Nothing
            'End Try
        End With

    End Sub

    Private Sub PutInfToFile(InfItem As KzLibInfItem, FilePath As String)
        Using fs As FileStream = New FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite)
            Using sw As StreamWriter = New StreamWriter(fs, Encoding.UTF8)
                sw.WriteLine("Type:" & [Enum].GetName(GetType(KzLibInfType), TypeBox.SelectedItem))
                sw.WriteLine("ID:" & IDBox.Text)
                sw.WriteLine("Title:" & TitleBox.Text)
                sw.WriteLine("Subtitle:" & SubtitleBox.Text)
                sw.WriteLine("Author:" & AuthorBox.Text)
                sw.WriteLine("AuthorInfo:")
                sw.WriteLine("PublishInfo:" & PublishInfoBox.Text)
                sw.WriteLine("Version:" & VersionBox.Text)
                sw.WriteLine("Category:" & CategoryBox.Text)
                sw.WriteLine("Special:" & SpecialBox.Text)
                sw.WriteLine("Cover:" & CoverBox.Tag.ToString)
                sw.WriteLine("Address:\" & Path.GetFileName(LibView.SelectedNode.FullPath))

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

                sw.WriteLine("FileComments:" & sb.ToString)
                sw.WriteLine("Intro:")
                sw.Write(IntroBox.Text)
            End Using
        End Using
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
                Else
                    CoverButton.Enabled = False
                End If
            End If
        End With
    End Sub

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
            'CoverBox.Tag = Path.GetFileName(imgFile)
        Catch ex As Exception
            sb.AppendLine("[-]")
            CoverBox.Image = Nothing
            'CoverBox.Tag = Nothing
        End Try

        ImgInfoLabel.Text = sb.ToString
    End Sub

    Private Sub CoverButton_Click(sender As Object, e As EventArgs) Handles CoverButton.Click
        If FilesView.SelectedItems.Count > 0 Then
            If FilesView.SelectedItems(0).SubItems(2).Text = "圖像" Then
                CoverBox.Tag = FilesView.SelectedItems(0).SubItems(0).Text
            End If
        End If
    End Sub
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
    Public Property InfoUpdated As String '= "<updated>"
    Public Property Intro As String '= "<intro>"

End Class

Public Enum KzLibInfType
    None
    Book
    Author
    Category
    Special
End Enum