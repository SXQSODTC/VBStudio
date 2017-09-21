Imports System.IO
Imports System.Text
Imports System.Net
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class HDLibView

    Private CurrentInf As HDLibInf
    Private NeedUpdateInf As Boolean = True
    Private WithEvents iBro As WebBrowser

    Private Sub HDLibView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LibView.LibRoot = My.Settings.HDLibPath
        LibView.ExceptFolders.Add("LibDB")
        LibView.RefreshTree()
        LibView.Nodes(0).Expand()

        For i As Integer = 0 To [Enum].GetNames(GetType(HDLibInfType)).Count - 1
            TypeComboBox.Items.Add(CType(i, HDLibInfType))
        Next

        PresetLists()

        WebViewer.WebRoot = My.Settings.HDLibHome
        WebViewer.ShowSourceInternal = False
        iBro = WebViewer.HDBrowser

    End Sub


#Region "LibTree"
    Private Sub LibSearchTools_SizeChanged(sender As Object, e As EventArgs) Handles LibSearchTools.SizeChanged
        Dim w As Integer = 15

        For Each item As ToolStripItem In LibSearchTools.Items
            If Not item.Equals(LibSearchTextBox) Then
                w += item.Width
            End If
        Next

        LibSearchTextBox.Width = LibSearchTools.Width - w
    End Sub

    Private Sub LibSearchAdvanceButton_Click(sender As Object, e As EventArgs) Handles LibSearchAdvanceButton.Click
        Dim hdls As New HDLibSearch
        If hdls.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub LibView_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles LibView.BeforeSelect
        Try
            If UpdateInfButton.Enabled AndAlso (Not CurrentInf.IsEmpty) Then
                Try
                    CurrentInf.Export(LibView.SelectedNode.FullPath)
                Catch ex As Exception
                    MsgBox("未能保存 Inf。原因：" & vbCrLf & ex.Message)
                    'e.Cancel = True
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LibView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LibView.AfterSelect
        CurrentNodeLabel.Text = e.Node.FullPath
        LibSearchTextBox.Text = e.Node.Text

        CurrentInf = New HDLibInf
        CurrentInf.Import(e.Node.FullPath)

        SetUIFromInf(CurrentInf)
        SetHeader(e.Node.FullPath, CurrentInf)
        EntryChecking(e.Node.FullPath, CurrentInf)
        SetManifest(e.Node.FullPath, CurrentInf)
        SetLinks(CurrentInf)

        UpdateInfButton.Enabled = False
    End Sub

#End Region 'LibTree

#Region "MenuActions"
    Private Sub LibRootToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LibRootToolStripMenuItem.Click

        '更改書庫目錄（資料夾）
        Dim fbd As New FolderBrowserDialog
        fbd.ShowNewFolderButton = True

        If Directory.Exists(LibView.LibRoot) Then
            fbd.RootFolder = LibView.LibRoot
        End If

        If fbd.ShowDialog = DialogResult.OK Then
            LibView.LibRoot = fbd.SelectedPath
            LibView.ExceptFolders.Add("LibDB")
            My.Settings.HDLibPath = fbd.SelectedPath
            LibView.RefreshTree()
            LibView.Nodes(0).Expand()
        End If
    End Sub

    Private Sub SaveInfButton_Click(sender As Object, e As EventArgs) Handles UpdateInfButton.Click
        'MsgBox(LibView.SelectedNode.FullPath & "\" & CurrentInf.FileName)
        Dim fp As String = LibView.SelectedNode.FullPath

        Try
            CurrentInf.Address = fp.Replace(LibView.LibRoot & "\", "")
            CurrentInf.Export(fp)

            'LibView.SelectedNode.ImageIndex = LibView.GetImgId(New DirectoryInfo(fp))

            'OriginInf.Import(fp)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShowInfButton_Click(sender As Object, e As EventArgs) Handles ShowInfButton.Click
        'SourceTextBox.Text = CurrentInf.ToString
        QuickViewer.Contents = CurrentInf.ToString
        BrowserTabs.SelectedTab = PageView
    End Sub

    Private Sub HDBookInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HDBookInfoToolStripMenuItem.Click
        If iBro.Document Is Nothing Then
            Exit Sub
        End If

        If Not TypeComboBox.SelectedItem = HDLibInfType.BookInfo Then
            MsgBox("請選定此項目為 BookInfo。")
            Exit Sub
        End If

        Dim src As String = KzWeb.GetWebCode(iBro.Url.AbsoluteUri)
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
            AuthorTextBox.Text = key.Substring(0, key.IndexOf(l))
            NameTextBox.Text = key.Substring(key.IndexOf(l) + 1, key.IndexOf(r) - key.IndexOf(l) - 1)
        Catch ex As Exception
            err &= "[SetTitle] 未能取得 Title 及 Author。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "SetLink\(.+\);").ToString
            t = key.Substring(key.IndexOf(">") + 1, key.IndexOf("</a>") - key.IndexOf(">") - 1)
            CategoryTextBox.Text = t.Replace(" 書目", "")
        Catch ex As Exception
            err &= "[SetLink] 未能取得 Category。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "DownloadUpdb\(.+?\<br").ToString
            IDTextBox.Text = key.Substring(key.IndexOf("(") + 1, key.IndexOf(")") - key.IndexOf("(") - 1).Replace("'", "")
            t = key.Substring(key.IndexOf("<font size=2>") + 14, key.IndexOf("</font><br") - key.IndexOf("<font size=2>") - 14)
            t = Regex.Replace(t, "\(.+\)", "-")
            If t.EndsWith("-") Then t.Replace("-", "").Trim()
            VersionTextBox.Text = t
            LinksViewAdd("BookFile", "http://www.haodoo.net/?M=d&P=" & IDTextBox.Text & ".updb")
        Catch ex As Exception
            err &= "[DownloadUpdb] 未能取得 ID 或 Version。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "\<img src\=""covers.+"" ").ToString
            t = key.Substring(key.IndexOf("covers"), key.IndexOf("""", key.IndexOf("covers")) - key.IndexOf("covers"))
            LinksViewAdd("Cover", "http://www.haodoo.net/" & t, True)
        Catch ex As Exception
            err &= "[img src] 未能取得 Cover。" & vbCrLf
        End Try

        Try
            key = Regex.Match(src, "HSPACE\=.+勘誤表", RegexOptions.Singleline).ToString
            t = key.Replace("勘誤表", "")
            t = Regex.Replace(t, "HSPACE\=.+?\>", "")
            t = Regex.Replace(t, "\<.+?\>", "")
            t = t.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf & vbCrLf)
            DescriptionTextBox.Text = t
        Catch ex As Exception
            err &= "[Intro] 未能取得 Intro。"            '
        End Try

        If err.Length > 0 Then
            MsgBox("源格式不匹配。以下元素未能取得：" & vbCrLf & err)
        End If

        LinksViewAdd("BookView", iBro.Url.ToString, True)
    End Sub

#End Region 'MenuActions

#Region "PrivateMethods"
    'Private Function GetAllNodeText(node As TreeNode) As AutoCompleteStringCollection
    '    Dim acsc As New AutoCompleteStringCollection

    '    If node.Nodes.Count > 0 Then
    '        For Each subnode As TreeNode In node.Nodes
    '            acsc.Add(subnode.Text)
    '            Dim subacsc As AutoCompleteStringCollection = GetAllNodeText(subnode)
    '            For Each tx As String In subacsc
    '                acsc.Add(tx)
    '            Next
    '        Next
    '    End If

    '    Return acsc
    'End Function

    Private Sub SetUIFromInf(Optional TheInf As HDLibInf = Nothing)
        If TheInf Is Nothing Then
            TheInf = CurrentInf
        End If

        NeedUpdateInf = False
        With TheInf
            TypeComboBox.SelectedItem = .Type
            IDTextBox.Text = .ID
            NameTextBox.Text = .Name
            SeriesTextBox.Text = .Series
            AuthorTextBox.Text = .Author
            If .Origin IsNot Nothing AndAlso (OriginComboBox.Items.Contains(.Origin)) Then
                OriginComboBox.SelectedItem = .Origin
            Else
                If OriginComboBox.Items.Count > 0 Then
                    OriginComboBox.SelectedIndex = 0
                End If
            End If
            ContributorTextBox.Text = .Contributor
            CategoryTextBox.Text = .Category
            SpecialTextBox.Text = .Special
            VersionTextBox.Text = .Version
            LogoTextBox.Text = .Logo
            AddressTextBox.Text = .Address
            RefaddressTextBox.Text = .RefAddress
            CreatedTextBox.Text = .Created.ToString
            UpdatedTextBox.Text = .Updated.ToString
            RemarksTextBox.Text = .Remarks
            DescriptionTextBox.Text = .Description
        End With
        NeedUpdateInf = True

    End Sub

    Private Sub SetHeader(Folder As String, Inf As HDLibInf)
        HIDLabel.Text = Inf.ID
        HTitleLabel.Text = Inf.Name
        HAuthorLabel.Text = Inf.Author
        HPilotLabel.Text = Inf.Description

        Try
            HCoverImageBox.Image = Image.FromFile(Path.Combine(Folder, Inf.Logo))
        Catch ex As Exception
            HCoverImageBox.Image = My.Resources.lib_nocover
        End Try
    End Sub

    Private Sub SetManifest(Folder As String, Inf As HDLibInf)
        Dim di As DirectoryInfo
        Dim fis As FileInfo()

        Try
            di = New DirectoryInfo(Folder)
            fis = di.GetFiles
        Catch ex As Exception
            Exit Sub
        End Try

        FilesView.Items.Clear()

        If fis.Count = 0 Then
            CEmptyChecker.Checked = True
            Exit Sub
        Else
            CEmptyChecker.Checked = False
        End If

        Dim i As Integer
        Dim item As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem()
        Dim ext, extStr As String
        Dim l As Long
        Dim extList As New List(Of String)

        For i = 0 To fis.Length - 1
            ext = fis(i).Extension ' GetFileType(fis(i).Extension)
            extStr = GetFileType(ext)

            If extStr = "書籍" And Not extList.Contains(ext) Then extList.Add(ext)

            item = New ListViewItem(fis(i).Name)
            item.Name = fis(i).Name
            l = fis(i).Length

            subitems = {
                New ListViewItem.ListViewSubItem(item, extStr),
                New ListViewItem.ListViewSubItem(item, KzStr.GetFileLength(l, True, False, True)),
                New ListViewItem.ListViewSubItem(item, If(l < 1024, "", "(" & KzStr.GetFileLength(l, True, True) & ")")),
                New ListViewItem.ListViewSubItem(item, ""),
                New ListViewItem.ListViewSubItem(item, fis(i).CreationTime.ToString)}
            item.SubItems.AddRange(subitems)
            FilesView.Items.Add(item)

            '===================================================================
            '向 ListView 添加 FileComments（如存在）
            Try
                If Inf.Manifest.Count > 0 And FilesView.Items.Count > 0 Then
                    For Each kvp As KeyValuePair(Of String, String) In Inf.Manifest
                        For Each it As ListViewItem In FilesView.Items
                            If it.SubItems.Item(0).Text = kvp.Key Then
                                it.SubItems.Item(4).Text = kvp.Value
                                Exit For
                            End If
                        Next
                    Next
                End If
            Catch ex As Exception

            End Try
        Next
        FilesView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        CContansChecker.Text = "Contans: "
        If extList.Count > 0 Then
            For Each s As String In extList
                CContansChecker.Text &= s & " "
            Next
            CContansChecker.Checked = True
        Else
            CContansChecker.Checked = False
        End If

    End Sub

    Private Function GetManifest() As HDList
        Dim mf As New HDList

        If FilesView.Items.Count > 0 Then
            For Each it As ListViewItem In FilesView.Items
                If (it.SubItems(4).Text IsNot Nothing) Or
                    (it.SubItems(4).Text.Length) > 0 Then

                    mf.Add(it.SubItems(0).Text, it.SubItems(4).Text)
                End If
            Next
        End If

        Return mf
    End Function

    Private Sub SetLinks(Inf As HDLibInf)
        LinksView.Items.Clear()

        Try
            If Inf.Links.Count > 0 Then
                Dim item As ListViewItem

                For Each kvp As KeyValuePair(Of String, String) In Inf.Links
                    item = New ListViewItem(kvp.Key)
                    item.SubItems.Add(kvp.Value)
                    LinksView.Items.Add(item)
                Next
            End If
            LinksView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetLinks() As HDList
        Dim mf As New HDList

        If LinksView.Items.Count > 0 Then
            For Each it As ListViewItem In LinksView.Items
                mf.Add(it.SubItems(0).Text, it.SubItems(1).Text)
            Next
        End If

        Return mf
    End Function


    Private Sub GetInfFromUI(Optional TheInf As HDLibInf = Nothing)
        If TheInf Is Nothing Then
            TheInf = CurrentInf
        End If

        With TheInf
            .Type = TypeComboBox.SelectedItem
            .ID = IDTextBox.Text
            .Name = NameTextBox.Text
            .Series = SeriesTextBox.Text
            .Author = AuthorTextBox.Text
            .Origin = OriginComboBox.SelectedItem
            .Contributor = ContributorTextBox.Text
            .Category = CategoryTextBox.Text
            .Special = SpecialTextBox.Text
            .Version = VersionTextBox.Text
            .Logo = LogoTextBox.Text
            .Address = AddressTextBox.Text
            .RefAddress = RefaddressTextBox.Text
            .Created = CDate(CreatedTextBox.Text)
            .Updated = CDate(UpdatedTextBox.Text)
            .Remarks = RemarksTextBox.Text
            .Description = DescriptionTextBox.Text
        End With
    End Sub

    Private Sub PresetLists()
        Dim ss As String()
        Dim s As String

        ss = My.Settings.HDLibOrigins.Split("|")
        OriginComboBox.Items.Clear()
        For Each s In ss
            OriginComboBox.Items.Add(s)
        Next

        For Each s In My.Settings.HDLibUrlList
            DUrlListBox.Items.Add(s)
        Next

    End Sub

    Private Sub EntryChecking(Folder As String, Inf As HDLibInf)
        Dim Fn As String

        CFolderChecker.Text = "Folder: " & Folder
        If Directory.Exists(Folder) Then
            CFolderChecker.Checked = True
        Else
            CFolderChecker.Checked = False
        End If

        Try
            Fn = Path.Combine(Folder, Inf.FileName)
        Catch ex As Exception
            Fn = ""
        End Try
        CInfFileChecker.Text = "Inf: " & Fn
        If File.Exists(Fn) Then
            CInfFileChecker.Checked = True
        Else
            CInfFileChecker.Checked = False
        End If

        Try
            Fn = Path.Combine(Folder, Inf.Logo)
        Catch ex As Exception
            Fn = ""
        End Try
        CLogoFileChecker.Text = "Img: " & Fn
        If File.Exists(Fn) Then
            CLogoFileChecker.Checked = True
        Else
            CLogoFileChecker.Checked = False
        End If

        Try
            If Inf.Manifest.Count > 0 Then
                CManifestChecker.Checked = True
            Else
                CManifestChecker.Checked = False
            End If
        Catch ex As Exception
            CManifestChecker.Checked = False
        End Try

        Try
            If Inf.Links.Count > 0 Then
                CLinksChecker.Checked = True
            Else
                CLinksChecker.Checked = False
            End If
        Catch ex As Exception
            CLinksChecker.Checked = False
        End Try
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

        DMsgLabel.Text = "【即時資訊】" & vbCrLf & "下載中..."
    End Sub

    Private Sub wc_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        DProgressBar.Maximum = 100
        DProgressBar.Value = CInt(Math.Floor(e.BytesReceived * 100 / e.TotalBytesToReceive))
    End Sub

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        DMsgLabel.Text = "【即時資訊】" & vbCrLf

        If e.Error Is Nothing Then
            DMsgLabel.Text &= "下載完成。"
        Else
            DMsgLabel.Text &= "未能完成下載，原因：" & vbCrLf & e.Error.Message
        End If
    End Sub



#End Region 'PrivateMethods

#Region "DataChangedAction"

    Private Sub ComboDataChanged(sender As Object, e As EventArgs) Handles _
        TypeComboBox.SelectedIndexChanged, OriginComboBox.SelectedIndexChanged

        If Not NeedUpdateInf Then Exit Sub

        If sender.Equals(TypeComboBox) Then
            CurrentInf.Type = TypeComboBox.SelectedItem

            Try
                Dim fn As String = Path.Combine(LibView.SelectedNode.FullPath, CurrentInf.FileName)
                CInfFileChecker.Text = "Inf: " & fn
                CInfFileChecker.Checked = File.Exists(fn)

                LibView.SelectedNode.ImageIndex = LibView.GetImgId(CurrentInf.Type)
                LibView.SelectedNode.SelectedImageIndex = LibView.SelectedNode.ImageIndex
            Catch ex As Exception
                CInfFileChecker.Text = "Inf: "
                CInfFileChecker.Checked = False
            End Try
        End If

        If sender.Equals(OriginComboBox) Then
            CurrentInf.Origin = OriginComboBox.SelectedItem
        End If

        UpdateInfButton.Enabled = True
    End Sub

    Private Sub TextDataChanged(sender As Object, e As EventArgs) Handles _
        IDTextBox.TextChanged, NameTextBox.TextChanged, SeriesTextBox.TextChanged,
        AuthorTextBox.TextChanged, ContributorTextBox.TextChanged, CategoryTextBox.TextChanged,
        SpecialTextBox.TextChanged, VersionTextBox.TextChanged, LogoTextBox.TextChanged,
        AddressTextBox.TextChanged, RefaddressTextBox.TextChanged, RemarksTextBox.TextChanged,
        DescriptionTextBox.TextChanged

        If Not NeedUpdateInf Then Exit Sub

        If sender.Equals(IDTextBox) Then
            CurrentInf.ID = IDTextBox.Text
            HIDLabel.Text = IDTextBox.Text
        End If

        If sender.Equals(NameTextBox) Then
            CurrentInf.Name = NameTextBox.Text
            HTitleLabel.Text = NameTextBox.Text
        End If

        If sender.Equals(SeriesTextBox) Then
            CurrentInf.Series = SeriesTextBox.Text
        End If

        If sender.Equals(AuthorTextBox) Then
            CurrentInf.Author = AuthorTextBox.Text
            HAuthorLabel.Text = AuthorTextBox.Text
        End If

        If sender.Equals(ContributorTextBox) Then
            CurrentInf.Contributor = ContributorTextBox.Text
        End If

        If sender.Equals(CategoryTextBox) Then
            CurrentInf.Category = CategoryTextBox.Text
        End If

        If sender.Equals(SpecialTextBox) Then
            CurrentInf.Special = SpecialTextBox.Text
        End If

        If sender.Equals(AddressTextBox) Then
            CurrentInf.Address = AddressTextBox.Text
        End If

        If sender.Equals(RefaddressTextBox) Then
            CurrentInf.RefAddress = RefaddressTextBox.Text
        End If

        If sender.Equals(RemarksTextBox) Then
            CurrentInf.Remarks = RemarksTextBox.Text
        End If

        If sender.Equals(DescriptionTextBox) Then
            CurrentInf.Description = DescriptionTextBox.Text
            HPilotLabel.Text = DescriptionTextBox.Text
        End If

        If sender.Equals(VersionTextBox) Then
            CurrentInf.Version = VersionTextBox.Text
        End If

        If sender.Equals(LogoTextBox) Then
            CurrentInf.Logo = LogoTextBox.Text
            HCoverImageBox.Image = Image.FromFile(Path.Combine(LibView.SelectedNode.FullPath, LogoTextBox.Text))
        End If

        UpdateInfButton.Enabled = True
    End Sub

    'Private Sub CreatedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CreatedTextBox.TextChanged
    '    If NeedUpdateInf Then CurrentInf.Created = CDate(CreatedTextBox.Text)
    'End Sub

    'Private Sub UpdatedTextBox_TextChanged(sender As Object, e As EventArgs) Handles UpdatedTextBox.TextChanged
    '    If NeedUpdateInf Then CurrentInf.Updated = CDate(UpdatedTextBox.Text)
    'End Sub



#End Region 'DataChangedAction

#Region "FileListActions"
    Private Sub LUpdateButton_Click(sender As Object, e As EventArgs) Handles LUpdateButton.Click
        If FilesView.SelectedItems.Count > 0 Then
            If LCommentsTextBox.Text IsNot Nothing AndAlso LCommentsTextBox.Text.Length > 0 Then
                FilesView.SelectedItems(0).SubItems(4).Text = LCommentsTextBox.Text
                LUpdateButton.Enabled = False

                Try
                    CurrentInf.Manifest = GetManifest()
                    UpdateInfButton.Enabled = True
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub LCommentsTextBox_TextChanged(sender As Object, e As EventArgs) Handles LCommentsTextBox.TextChanged
        LUpdateButton.Enabled = True
    End Sub

    Private Sub FilesView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilesView.SelectedIndexChanged
        If FilesView.SelectedItems.Count > 0 And LibView.SelectedNode IsNot Nothing Then
            Dim fi As New FileInfo(Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).SubItems(0).Text))

            LFileNameLabel.Text = fi.Name
            LCommentsTextBox.Text = FilesView.SelectedItems(0).SubItems(4).Text
            LCreatedLabel.Text = "Created: " & fi.CreationTime.ToString
            LWritedLabel.Text = "Writed: " & fi.LastWriteTime.ToString
            LAccessedLabel.Text = "Read: " & fi.LastAccessTime.ToString

            LViewButton.Enabled = (fi.Extension = ".txt")
        Else
            LFileNameLabel.Text = "[None]"
            LCommentsTextBox.Text = ""
            LCreatedLabel.Text = "Created: "
            LWritedLabel.Text = "Writed: "
            LAccessedLabel.Text = "Read: "
            LViewButton.Enabled = False
        End If

        LUpdateButton.Enabled = False
    End Sub

    Private Sub LViewButton_Click(sender As Object, e As EventArgs) Handles LViewButton.Click
        Try
            Dim fn As String = Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).SubItems(0).Text)
            'SourceTextBox.Text = File.ReadAllText(fn, Encoding.UTF8)
            QuickViewer.Contents = File.ReadAllText(fn, Encoding.UTF8)
            'TEncodingLabel.Text = "UTF8"
            QuickViewer.DefaultEncoding = Encoding.UTF8
            'TPathLabel.Text = fn
            QuickViewer.FilePath = fn
            BrowserTabs.SelectedTab = PageView
        Catch ex As Exception

        End Try
    End Sub
#End Region 'FileListActions

#Region "LinkListAction"
    Private Sub UUpdateButton_Click(sender As Object, e As EventArgs) Handles UUpdateButton.Click
        If LinksView.SelectedItems.Count > 0 And
            UKeyTextBox.Text.Length > 0 And ULinkTextBox.Text.Length > 0 Then

            LinksView.SelectedItems(0).Text = UKeyTextBox.Text
            LinksView.SelectedItems(0).SubItems(1).Text = ULinkTextBox.Text

            UUpdateButton.Enabled = False

            Try
                CurrentInf.Links = GetLinks()
                UpdateInfButton.Enabled = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub LinksView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LinksView.SelectedIndexChanged
        If LinksView.SelectedItems.Count > 0 Then
            UKeyTextBox.Text = LinksView.SelectedItems(0).Text
            ULinkTextBox.Text = LinksView.SelectedItems(0).SubItems(1).Text
        End If

        UUpdateButton.Enabled = False
    End Sub

    Private Sub UTextBox_TextChanged(sender As Object, e As EventArgs) Handles UKeyTextBox.TextChanged, ULinkTextBox.TextChanged
        UUpdateButton.Enabled = True
    End Sub

    Private Sub UDownButton_Click(sender As Object, e As EventArgs) Handles UDownButton.Click
        If LinksView.SelectedItems.Count > 0 And LibView.SelectedNode IsNot Nothing Then
            DLinkTextBox.Text = LinksView.SelectedItems(0).SubItems(1).Text
            DFolderTextBox.Text = LibView.SelectedNode.FullPath
            DFileNameTextBox.Text = KzStr.GetLinkFileName(DLinkTextBox.Text)
            DetailTabs.SelectedTab = PageDownload
        End If
    End Sub

    Private Sub UAddButton_Click(sender As Object, e As EventArgs) Handles UAddButton.Click
        If ListViewHelper.ContainsItemText(LinksView, UKeyTextBox.Text) Then
            If MsgBox("鏈接名稱已存在，是否覆蓋？", MsgBoxStyle.YesNo, "新增") = MsgBoxResult.Yes Then
                LinksViewAdd(UKeyTextBox.Text, ULinkTextBox.Text, True)
            Else
                LinksViewAdd(UKeyTextBox.Text, ULinkTextBox.Text, False)
            End If
        End If
    End Sub

    Private Sub LinksViewAdd(key As String, value As String, Optional replace As Boolean = False)
        If LinksView.Items.Count > 0 And ListViewHelper.ContainsItemText(LinksView, key) Then
            If replace Then
                Dim TheItem As ListViewItem = ListViewHelper.GetItemByText(LinksView, key) ' GetListViewItemByText(LinksView, key)
                TheItem.SubItems(1).Text = value
            Else
                Dim newkey As String = ListViewHelper.GetNewItemText(LinksView, key) ' GetNewListViewItemText(LinksView, key)
                Dim item As New ListViewItem(newkey)
                item.SubItems.Add(value)
                LinksView.Items.Add(item)
            End If

        Else
            Dim item As New ListViewItem(key)
            item.SubItems.Add(value)
            LinksView.Items.Add(item)
        End If
        LinksView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        CurrentInf.Links = GetLinks()
        UpdateInfButton.Enabled = True
    End Sub

    Private Sub UBroButton_Click(sender As Object, e As EventArgs) Handles UBroButton.Click
        If LinksView.SelectedItems.Count > 0 Then
            iBro.Navigate(LinksView.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub
#End Region 'LinkListAction

#Region "DownloadActions"
    Private Sub DEditUrlListButton_Click(sender As Object, e As EventArgs) Handles DEditUrlListButton.Click
        Dim le As New KzListEditor
        le.ListSource = My.Settings.HDLibUrlList

        If le.ShowDialog = DialogResult.OK Then
            Dim ss(le.ListSource.Count - 1) As String
            le.ListSource.CopyTo(ss, 0)

            DUrlListBox.Items.Clear()
            DUrlListBox.Items.AddRange(ss)
            My.Settings.HDLibUrlList = le.ListSource
        End If
    End Sub

    Private Sub DRunButton_Click(sender As Object, e As EventArgs) Handles DRunButton.Click
        Dim sf As String = Path.Combine(DFolderTextBox.Text, DFileNameTextBox.Text)

        Download(DLinkTextBox.Text, sf)
    End Sub

    Private Sub DFolderTextBox_TextChanged(sender As Object, e As EventArgs) Handles DFolderTextBox.TextChanged
        DFolderExistsChecker.Checked = Directory.Exists(DFolderTextBox.Text)
        DFileExistsChecker.Checked = File.Exists(Path.Combine(DFolderTextBox.Text, DFileNameTextBox.Text))
    End Sub

    Private Sub DFileNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles DFileNameTextBox.TextChanged
        DFileExistsChecker.Checked = File.Exists(Path.Combine(DFolderTextBox.Text, DFileNameTextBox.Text))
        DToCoverChecker.Enabled = KzFiles.IsImageFile(DFileNameTextBox.Text)
    End Sub

    Private Sub DClearLinkButton_Click(sender As Object, e As EventArgs) Handles DClearLinkButton.Click
        DLinkTextBox.Clear()
    End Sub

    Private Sub DClearPathButton_Click(sender As Object, e As EventArgs) Handles DClearPathButton.Click
        DFolderTextBox.Clear()
    End Sub
#End Region 'DownloadActions

    'TempArea

    Private Sub WebViewer_SourceCodeExported(sender As Object, e As SourceCodeExportEventArgs) Handles WebViewer.SourceCodeExported
        If Not WebViewer.ShowSourceInternal Then
            QuickViewer.Contents = e.Code
            QuickViewer.DefaultEncoding = Encoding.UTF8
            QuickViewer.FilePath = e.Source
            BrowserTabs.SelectedTab = PageView
        End If
    End Sub




    Private Sub LibDataContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles LibDataContextMenu.Opening
        Dim c As Control = LibDataContextMenu.SourceControl

        With LibDataContextMenu.Items
            .Clear()

            If c.Equals(FilesView) Then
                .Add("Import...")
                .Add("Rename")
                .Add(New ToolStripSeparator)
                .Add("Copy")
                .Add("Cut")
                .Add("Paste")
                .Add("Delete")
                .Add(New ToolStripSeparator)
                .Add("Set Cover", Nothing, AddressOf MenuSetToCover)
            End If

            If c.Equals(LinksView) Then
                .Add("Navigate...")
                .Add("Download...")
                .Add(New ToolStripSeparator)
                .Add("Copy link")
                .Add("Rename key")
                .Add("Delete")
            End If
        End With
    End Sub

    Private Sub MenuSetToCover()
        If FilesView.Items.Count > 0 AndAlso FilesView.SelectedItems.Count > 0 Then
            If FilesView.SelectedItems(0).SubItems(2).Text = "圖像" Then
                If LogoTextBox.Text IsNot Nothing AndAlso LogoTextBox.Text.Trim.Length > 0 Then
                    LogoTextBox.Text = FilesView.SelectedItems(0).Text
                Else
                    If MsgBox("已存在指定封面，是否替換？", MsgBoxStyle.YesNo, "封面") = MsgBoxResult.Yes Then
                        LogoTextBox.Text = FilesView.SelectedItems(0).Text
                    End If
                End If
            End If
        End If
    End Sub
End Class