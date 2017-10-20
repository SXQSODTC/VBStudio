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
        LibView.ExceptFolders.AddRange({"LibDB", "LibApp"})
        LibView.RefreshTree()
        LibView.Nodes(0).Expand()

        For i As Integer = 0 To [Enum].GetNames(GetType(HDLibInfType)).Count - 1
            TypeComboBox.Items.Add(CType(i, HDLibInfType))
        Next

        PresetLists()
        SetIcons()

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
                    CurrentInf.Address = LibView.SelectedNode.FullPath.Replace(LibView.LibRoot & "\", "")
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
        If LibView.SelectedNode Is Nothing Then Exit Sub
        CurrentNodeLabel.Text = e.Node.FullPath
        LibSearchTextBox.Text = e.Node.Text

        CurrentInf = New HDLibInf
        CurrentInf.Import(e.Node.FullPath)

        SetUIFromInf(CurrentInf)
        SetHeader(e.Node.FullPath, CurrentInf)
        EntryChecking(e.Node.FullPath, CurrentInf)
        SetManifest(e.Node.FullPath, CurrentInf)
        SetLinks(CurrentInf)
        ShowImg("")
        UpdateInfButton.Enabled = False
    End Sub

    Private Sub ReSelected(Node As TreeNode)
        Try
            Dim fp As String = Node.FullPath

            CurrentNodeLabel.Text = fp
            LibSearchTextBox.Text = Node.Text

            CurrentInf = New HDLibInf
            CurrentInf.Import(fp)

            SetUIFromInf(CurrentInf)
            SetHeader(fp, CurrentInf)
            EntryChecking(fp, CurrentInf)
            SetManifest(fp, CurrentInf)
            SetLinks(CurrentInf)
            ShowImg("")
            UpdateInfButton.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

#End Region 'LibTree

#Region "ToolButtons"
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
            LibView.ExceptFolders.AddRange({"LibDB", "LibApp"})
            My.Settings.HDLibPath = fbd.SelectedPath
            LibView.RefreshTree()
            LibView.Nodes(0).Expand()
        End If
    End Sub

    Private Sub UpdateInfButton_EnabledChanged(sender As Object, e As EventArgs) Handles UpdateInfButton.EnabledChanged
        CancelEditButton.Enabled = UpdateInfButton.Enabled
    End Sub

    Private Sub UpdateInfButton_Click(sender As Object, e As EventArgs) Handles UpdateInfButton.Click
        'MsgBox(LibView.SelectedNode.FullPath & "\" & CurrentInf.FileName)
        Try
            Dim fp As String = LibView.SelectedNode.FullPath
            CurrentInf.Address = fp.Replace(LibView.LibRoot & "\", "")
            CurrentInf.Export(fp)
            UpdateInfButton.Enabled = False

            ReSelected(LibView.SelectedNode)
        Catch ex As Exception
            MsgBox("未能保存 Inf。原因：" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub CancelEditButton_Click(sender As Object, e As EventArgs) Handles CancelEditButton.Click
        If LibView.SelectedNode IsNot Nothing Then
            ReSelected(LibView.SelectedNode)
            UpdateInfButton.Enabled = False
        End If
    End Sub

    Private Sub ShowInfButton_Click(sender As Object, e As EventArgs) Handles ShowInfButton.Click
        QuickViewer.Contents = CurrentInf.ToString
        BrowserTabs.SelectedTab = PageView
    End Sub

    Private Sub HDBookInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HDBookInfoItem.Click
        If iBro.Document Is Nothing Then Exit Sub

        If Not TypeComboBox.SelectedItem = HDLibInfType.BookInfo Then
            MsgBox("請選定此項目為 BookInfo。")
            Exit Sub
        End If

        Dim src As String = KzWeb.GetWebCode(iBro.Url.AbsoluteUri)
        Dim key As String
        Dim t As String
        Dim sb As New StringBuilder

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
            sb.AppendLine("[ ][SetTitle] 取得 Title 及 Author。")
        Catch ex As Exception
            sb.AppendLine("[X][SetTitle] 未能取得 Title 及 Author。")
        End Try

        Try
            key = Regex.Match(src, "SetLink\(.+\);").ToString
            t = key.Substring(key.IndexOf(">") + 1, key.IndexOf("</a>") - key.IndexOf(">") - 1)
            CategoryTextBox.Text = t.Replace(" 書目", "")
            sb.AppendLine("[ ][SetLink] 取得 Category。")
        Catch ex As Exception
            sb.AppendLine("[X][SetLink] 未能取得 Category。")
        End Try

        Try
            Dim rgx As New Regex("<font color.+?<input type=""button"" value=""線上閱讀"".+?下載 updb 檔.+?font>") '  .+\<input type\=""button""  value\=""下載 updb 檔"".+\<input type\=""button""")
            Dim mts As MatchCollection = rgx.Matches(src)

            Dim mtstr, id, vr As String
            Dim ck As Boolean = True
            For Each mt As Match In mts
                mtstr = mt.ToString
                key = Regex.Match(mtstr, "font>.+?<input").ToString.Replace("font>", "").Replace("<input", "").Replace("《", "").Replace("》", "")
                id = Regex.Match(mtstr, "DownloadUpdb\('.+?'\)").ToString.Replace("DownloadUpdb('", "").Replace("')", "")
                t = "http://www.haodoo.net/?M=d&P=" & id & ".updb"
                vr = Regex.Match(mtstr, "<font size=2>.+</font>").ToString.Replace("<font size=2>", "").Replace("</font>", "")

                LinksViewAdd(key, t, True)

                If ck Then
                    IDTextBox.Text = id
                    VersionTextBox.Text = Regex.Replace(vr, "\(.+\)", "-").Trim
                    ck = False
                End If
            Next
            sb.AppendLine("[ ][Links] 取得Links、ID 及 Version。")
        Catch ex As Exception
            sb.AppendLine("[X][Links] 未能取得Links 或 ID 或 Version。"）
        End Try

        Try
            Dim rgx As New Regex("<img src=""covers/.+?""")
            Dim mts As MatchCollection = rgx.Matches(src)

            If mts.Count > 0 Then
                For Each mt As Match In mts
                    key = mt.ToString.Replace("<img src=""covers/", "").Replace("""", "")
                    t = "http://www.haodoo.net/covers/" & key
                    LinksViewAdd(key, t, True)
                Next
                sb.AppendLine("[ ][Images] 取得 Cover 等圖像。"）
            Else
                sb.AppendLine("[X][Images] 未能取得 Cover。"）
            End If
        Catch ex As Exception
            sb.AppendLine("[X][Images] 未能取得 Cover。"）
        End Try

        Try
            key = Regex.Match(src, "好讀書櫃《.+?》.+?勘誤表", RegexOptions.Singleline).ToString
            t = key.Replace("勘誤表", "")
            t = Regex.Replace(t, "\<.+?\>", "")
            t = t.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf & vbCrLf).Replace(vbCrLf & vbCrLf, vbCrLf)
            DescriptionTextBox.Text = t

            If t.Trim.Length > 0 Then
                sb.AppendLine("[ ][Intro] 取得 Intro。"）
            Else
                sb.AppendLine("[X][Intro] 未能取得 Intro。"）
            End If
        Catch ex As Exception
            sb.AppendLine("[X][Intro] 未能取得 Intro。"）
        End Try

        MsgBox("TryGet 結果：" & vbCrLf & sb.ToString)
        LinksViewAdd("BookView", iBro.Url.ToString, True)
    End Sub

#End Region 'ToolButton

#Region "PrivateMethods"
    Private Sub SetIcons()
        LibSearchGoButton.Image = My.Resources.lib_search
        LibSearchAdvanceButton.Image = My.Resources.lib_advsearch
        UpdateInfButton.Image = My.Resources.lib_update
        CancelEditButton.Image = My.Resources.lib_reset
        ShowInfButton.Image = My.Resources.lib_show
        TryGetButton.Image = My.Resources.lib_tryget
        DBButton.Image = My.Resources.lib_db
        BackupButton.Image = My.Resources.lib_backup
        SettingsButton.Image = My.Resources.lib_settings
    End Sub

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
            SeriesIDUD.Value = .SID
            AuthorTextBox.Text = .Author
            If .Origin IsNot Nothing AndAlso (OriginComboBox.Items.Contains(.Origin)) Then
                OriginComboBox.SelectedItem = .Origin
            Else
                If OriginComboBox.Items.Count > 0 Then
                    OriginComboBox.SelectedIndex = 0
                End If
            End If
            ContributorTextBox.Text = .InternalRef
            CategoryTextBox.Text = .Category
            SpecialTextBox.Text = .Special
            VersionTextBox.Text = .Version
            LogoTextBox.Text = .Logo
            AddressTextBox.Text = .Address
            RefaddressTextBox.Text = .ExternalRef
            CreatedTextBox.Text = .Created.ToString
            UpdatedTextBox.Text = .Updated.ToString
            RemarksTextBox.Text = .Remarks
            DescriptionTextBox.Text = .Description

            SetUIDisplay(TypeComboBox.SelectedItem)
        End With
        NeedUpdateInf = True

    End Sub

    Private Sub SetUIDisplay(InfType As HDLibInfType)
        Select Case InfType
            Case HDLibInfType.AuthorInfo
                LabelSubject.Text = "姓名"
                LabelAuthor.Text = "原名"
                LabelHAuthor.Text = LabelAuthor.Text
                SeriesTextBox.Enabled = False
                SeriesIDUD.Enabled = False
                OriginComboBox.Enabled = True
                AuthorTextBox.Enabled = True
            Case HDLibInfType.BookInfo
                LabelSubject.Text = "書名"
                LabelAuthor.Text = "作者"
                LabelHAuthor.Text = LabelAuthor.Text
                SeriesTextBox.Enabled = True
                If SeriesTextBox.Text Is Nothing Or SeriesTextBox.Text.Trim.Length <= 0 Then
                    SeriesIDUD.Enabled = False
                Else
                    SeriesIDUD.Enabled = True
                End If
                OriginComboBox.Enabled = True
                AuthorTextBox.Enabled = True
            Case HDLibInfType.CategoryInfo, HDLibInfType.SeriesInfo, HDLibInfType.SpecialInfo
                LabelSubject.Text = "名稱"
                LabelAuthor.Text = "作者"
                LabelHAuthor.Text = ""
                SeriesTextBox.Enabled = False
                SeriesIDUD.Enabled = False
                OriginComboBox.Enabled = False
                AuthorTextBox.Enabled = False
            Case HDLibInfType.LibInfo
                LabelSubject.Text = "書庫"
                LabelAuthor.Text = "作者"
                LabelHAuthor.Text = ""
                SeriesTextBox.Enabled = False
                SeriesIDUD.Enabled = False
                OriginComboBox.Enabled = False
                AuthorTextBox.Enabled = False
            Case Else
        End Select

        LabelHSubject.Text = LabelSubject.Text
        ContributorTextBox.Enabled = SeriesTextBox.Enabled
        CategoryTextBox.Enabled = SeriesTextBox.Enabled
        SpecialTextBox.Enabled = SeriesTextBox.Enabled
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

        Try
            HIcon.Image = LibView.ImageList.Images.Item(LibView.SelectedNode.ImageIndex)
        Catch ex As Exception
            HIcon.Image = Nothing
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
                    (it.SubItems(4).Text.Trim.Length > 0) Then

                    mf.Add(it.Text, it.SubItems(4).Text)
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
            .InternalRef = ContributorTextBox.Text
            .Category = CategoryTextBox.Text
            .Special = SpecialTextBox.Text
            .Version = VersionTextBox.Text
            .Logo = LogoTextBox.Text
            .Address = AddressTextBox.Text
            .ExternalRef = RefaddressTextBox.Text
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

            SetUIDisplay(TypeComboBox.SelectedItem)
        End If

        If sender.Equals(OriginComboBox) Then
            CurrentInf.Origin = OriginComboBox.SelectedItem
        End If

        UpdateInfButton.Enabled = True
    End Sub

    Private Sub UDValueChanged(sender As Object, e As EventArgs) Handles SeriesIDUD.ValueChanged
        If Not NeedUpdateInf Then Exit Sub

        If SeriesTextBox.Text Is Nothing Or SeriesTextBox.Text.Trim.Length <= 0 Then
            SeriesIDUD.Value = 0
        Else
            CurrentInf.SID = SeriesIDUD.Value
        End If
    End Sub

    Private Sub TextDataChanged(sender As Object, e As EventArgs) Handles _
        IDTextBox.TextChanged, NameTextBox.TextChanged, SeriesTextBox.TextChanged,
        AuthorTextBox.TextChanged, ContributorTextBox.TextChanged, CategoryTextBox.TextChanged,
        SpecialTextBox.TextChanged, VersionTextBox.TextChanged, LogoTextBox.TextChanged,
        AddressTextBox.TextChanged, RefaddressTextBox.TextChanged, RemarksTextBox.TextChanged,
        DescriptionTextBox.TextChanged, LCommentsTextBox.TextChanged,
        UKeyTextBox.TextChanged, ULinkTextBox.TextChanged

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
            If SeriesTextBox.Text Is Nothing Or SeriesTextBox.Text.Trim.Length <= 0 Then
                SeriesIDUD.Enabled = False
            Else
                SeriesIDUD.Enabled = True
            End If
        End If

        If sender.Equals(AuthorTextBox) Then
            CurrentInf.Author = AuthorTextBox.Text
            HAuthorLabel.Text = AuthorTextBox.Text
        End If

        If sender.Equals(ContributorTextBox) Then
            CurrentInf.InternalRef = ContributorTextBox.Text
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
            CurrentInf.ExternalRef = RefaddressTextBox.Text
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

        If sender.Equals(LCommentsTextBox) Then
            LUpdateButton.Enabled = True
        End If

        If sender.Equals(UKeyTextBox) Or sender.Equals(DLinkTextBox) Then
            UUpdateButton.Enabled = True
        End If

        UpdateInfButton.Enabled = True
    End Sub

    Private Sub TextBoxes_DragEnter(sender As Object, e As DragEventArgs) Handles _
        IDTextBox.DragEnter, NameTextBox.DragEnter, SeriesTextBox.DragEnter,
        AuthorTextBox.DragEnter, ContributorTextBox.DragEnter, CategoryTextBox.DragEnter,
        SpecialTextBox.DragEnter, VersionTextBox.DragEnter, LogoTextBox.DragEnter,
        AddressTextBox.DragEnter, RefaddressTextBox.DragEnter, RemarksTextBox.DragEnter,
        DescriptionTextBox.DragEnter, LCommentsTextBox.DragEnter, UKeyTextBox.DragEnter,
        ULinkTextBox.DragEnter, DFileNameTextBox.DragEnter, DLinkTextBox.DragEnter

        If (e.Data.GetDataPresent("Text")) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub TextBoxes_DragDrop(sender As Object, e As DragEventArgs) Handles _
        IDTextBox.DragDrop, NameTextBox.DragDrop, SeriesTextBox.DragDrop,
        AuthorTextBox.DragDrop, ContributorTextBox.DragDrop, CategoryTextBox.DragDrop,
        SpecialTextBox.DragDrop, VersionTextBox.DragDrop, LogoTextBox.DragDrop,
        AddressTextBox.DragDrop, RefaddressTextBox.DragDrop, RemarksTextBox.DragDrop,
        DescriptionTextBox.DragDrop, LCommentsTextBox.DragDrop, UKeyTextBox.DragDrop,
        ULinkTextBox.DragDrop, DFileNameTextBox.DragDrop, DLinkTextBox.DragDrop

        CType(sender, TextBox).Paste(e.Data.GetData("Text"))
    End Sub

    Private Sub TextBox_DoubleClick(sender As Object, e As EventArgs) Handles _
        IDTextBox.DoubleClick, NameTextBox.DoubleClick, SeriesTextBox.DoubleClick,
        AuthorTextBox.DoubleClick, ContributorTextBox.DoubleClick, CategoryTextBox.DoubleClick,
        SpecialTextBox.DoubleClick, VersionTextBox.DoubleClick, LogoTextBox.DoubleClick,
        AddressTextBox.DoubleClick, RefaddressTextBox.DoubleClick, RemarksTextBox.DoubleClick,
        DescriptionTextBox.DoubleClick, LCommentsTextBox.DoubleClick, UKeyTextBox.DoubleClick,
        ULinkTextBox.DoubleClick, DFileNameTextBox.DoubleClick, DLinkTextBox.DoubleClick

        CType(sender, TextBox).SelectAll()
    End Sub


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

    Private Sub FilesView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilesView.SelectedIndexChanged
        If FilesView.SelectedItems.Count > 0 AndAlso LibView.SelectedNode IsNot Nothing Then
            Dim fi As New FileInfo(Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).SubItems(0).Text))

            LFileNameLabel.Text = fi.Name
            LCommentsTextBox.Text = FilesView.SelectedItems(0).SubItems(4).Text
            LCreatedLabel.Text = "Created: " & fi.CreationTime.ToString
            LWritedLabel.Text = "Writed: " & fi.LastWriteTime.ToString
            LAccessedLabel.Text = "Read: " & fi.LastAccessTime.ToString

            LViewButton.Enabled = (fi.Extension = ".txt")

            If LInTimeChecker.Checked AndAlso FilesView.SelectedItems(0).SubItems(1).Text = "圖像" Then
                ShowImg(fi)
            Else
                ShowImg("")
            End If
        Else
            LFileNameLabel.Text = "[None]"
            LCommentsTextBox.Text = ""
            LCreatedLabel.Text = "Created: "
            LWritedLabel.Text = "Writed: "
            LAccessedLabel.Text = "Read: "
            LViewButton.Enabled = False
            ShowImg("")
        End If

        LUpdateButton.Enabled = False
    End Sub

    Private Sub LInTimeChecker_CheckedChanged(sender As Object, e As EventArgs) Handles LInTimeChecker.CheckedChanged
        If FilesView.SelectedItems.Count > 0 AndAlso
            LibView.SelectedNode IsNot Nothing AndAlso
            LInTimeChecker.Checked AndAlso
            FilesView.SelectedItems(0).SubItems(1).Text = "圖像" Then

            ShowImg(Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).SubItems(0).Text))
        Else
            ShowImg("")
        End If
    End Sub

    Private Sub ShowImg(imgFile As FileInfo)
        Dim sb As New StringBuilder("[Image]" & vbCrLf)
        Try
            Dim img As Image = Image.FromFile(imgFile.FullName)
            Dim l As Long = imgFile.Length
            With img
                sb.AppendLine("File: " & imgFile.FullName)
                sb.AppendLine("Type: " & imgFile.Extension)
                sb.AppendLine("Size: " & .Width & " x " & .Height & " pixel")
                sb.AppendLine("Resolution: " & If(.HorizontalResolution = .VerticalResolution, .HorizontalResolution & "dpi", .HorizontalResolution & " x " & .VerticalResolution & "dpi"))
                sb.AppendLine("AbsSize: " & Math.Round(.HorizontalResolution / .Width * 2.54, 2) & " x " & Math.Round(.VerticalResolution / .Height * 2.54, 2) & " cm")
                sb.AppendLine("Length: " & KzStr.GetFileLength(l, True, False, True) & " " & If(l < 1024, "", "(" & KzStr.GetFileLength(l, True, True) & ")"))
            End With

            ImgPreviewBox.Image = img
        Catch ex As Exception
            sb.AppendLine("[-]")
            ImgPreviewBox.Image = Nothing
        End Try

        FileInfoLabel.Text = sb.ToString
    End Sub

    Private Sub ShowImg(imgFile As String)
        Try
            Dim fi As New FileInfo(imgFile)
            ShowImg(fi)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FilesView_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) Handles FilesView.AfterLabelEdit
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

    Private Sub FilesView_DragEnter(sender As Object, e As DragEventArgs) Handles FilesView.DragEnter
        If (e.Data.GetDataPresent("FileDrop")) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub FilesView_DragDrop(sender As Object, e As DragEventArgs) Handles FilesView.DragDrop
        Try
            Dim folder As String = LibView.SelectedNode.FullPath
            For Each s As String In e.Data.GetData(DataFormats.FileDrop)
                File.Copy(s, Path.Combine(folder, Path.GetFileName(s)))
            Next

            SetManifest(folder, CurrentInf)
        Catch ex As Exception
            MsgBox("未能接受文檔。原因：" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub LViewButton_Click(sender As Object, e As EventArgs) Handles LViewButton.Click
        Try
            Dim fn As String = Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).SubItems(0).Text)
            QuickViewer.Contents = File.ReadAllText(fn, Encoding.UTF8)
            QuickViewer.DefaultEncoding = Encoding.UTF8
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
        Else
            UKeyTextBox.Text = ""
            ULinkTextBox.Text = ""
        End If

        UUpdateButton.Enabled = False
    End Sub

    Private Sub UDownButton_Click(sender As Object, e As EventArgs) Handles UDownButton.Click
        If LinksView.SelectedItems.Count > 0 And LibView.SelectedNode IsNot Nothing Then
            DLinkTextBox.Text = LinksView.SelectedItems(0).SubItems(1).Text
            DFolderTextBox.Text = LibView.SelectedNode.FullPath
            DFileNameTextBox.Text = KzStr.GetLinkFileName(DLinkTextBox.Text).Replace("?M=d&P=", "")
            DProgressBar.Value = 0
            DMsgLabel.Text = "【即時資訊】" & vbCrLf
            DetailTabs.SelectedTab = PageDownload
        End If
    End Sub

    Private Sub UAddButton_Click(sender As Object, e As EventArgs) Handles UAddButton.Click
        LinksViewAdd(UKeyTextBox.Text, ULinkTextBox.Text, False)
        'If ListViewHelper.ContainsItemText(LinksView, UKeyTextBox.Text) Then
        '    If MsgBox("鏈接名稱已存在，是否覆蓋？", MsgBoxStyle.YesNo, "新增") = MsgBoxResult.Yes Then
        '        LinksViewAdd(UKeyTextBox.Text, ULinkTextBox.Text, True)
        '    Else
        '        LinksViewAdd(UKeyTextBox.Text, ULinkTextBox.Text, False)
        '    End If
        'End If
    End Sub

    Private Sub LinksViewAdd(key As String, value As String, Optional replace As Boolean = False)
        If LinksView.Items.Count > 0 And ListViewHelper.ContainsItemText(LinksView, key) Then
            If replace Then
                Dim TheItem As ListViewItem = ListViewHelper.GetItemByText(LinksView, key)
                TheItem.SubItems(1).Text = value
            Else
                Dim newkey As String = ListViewHelper.GetNewItemText(LinksView, key)
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
        DPersentageLabel.Text = Fix(DProgressBar.Value) & "%"
    End Sub

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        DMsgLabel.Text = "【即時資訊】" & vbCrLf

        If e.Error Is Nothing Then
            DMsgLabel.Text &= "下載完成。"

            If DToCoverChecker.Checked Then
                If LogoTextBox.Text IsNot Nothing AndAlso LogoTextBox.Text.Trim.Length > 0 Then
                    If MsgBox("已存在指定封面，是否替換？", MsgBoxStyle.YesNo, "封面") = MsgBoxResult.Yes Then
                        LogoTextBox.Text = DFileNameTextBox.Text
                    End If
                Else
                    LogoTextBox.Text = DFileNameTextBox.Text
                End If
            End If

            SetManifest(LibView.SelectedNode.FullPath, CurrentInf)
        Else
            DMsgLabel.Text &= "未能完成下載，原因：" & vbCrLf & e.Error.Message
        End If
    End Sub

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

    Private Sub DChangePathButton_Click(sender As Object, e As EventArgs) Handles DChangePathButton.Click
        Dim fbd As New FolderBrowserDialog
        If Directory.Exists(LibView.LibRoot) Then fbd.RootFolder = LibView.LibRoot

        If fbd.ShowDialog = DialogResult.OK Then
            DFolderTextBox.Text = fbd.SelectedPath
        End If
    End Sub
#End Region 'DownloadActions

#Region "DataMenus"
    Private Sub LibDataContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles LibDataContextMenu.Opening
        Dim c As Control = LibDataContextMenu.SourceControl

        With LibDataContextMenu.Items
            .Clear()

            If c.Equals(FilesView) Then
                .Add("Import...")
                .Add("Rename", Nothing, AddressOf FilesMenuRename)
                .Add(New ToolStripSeparator)
                .Add("Copy")
                .Add("Cut")
                .Add("Paste")
                .Add("Delete", Nothing, AddressOf FilesMenuDelete)
                .Add(New ToolStripSeparator)
                .Add("Set Cover", Nothing, AddressOf FilesMenuSetToCover)

                Dim sc As ToolStripMenuItem = MenuHelper.GetItemByText(LibDataContextMenu, "Set Cover")
                If FilesView.SelectedItems.Count > 0 And FilesView.SelectedItems(0).SubItems(1).Text = "圖像" Then
                    sc.Enabled = True
                Else
                    sc.Enabled = False
                End If
            End If

            If c.Equals(LinksView) Then
                .Add("Navigate...")
                .Add("Download...")
                .Add(New ToolStripSeparator)
                .Add("Copy link")
                .Add("Delete")
            End If
        End With
    End Sub

    Private Sub FilesMenuRename()
        If FilesView.SelectedItems.Count > 0 Then
            FilesView.SelectedItems(0).BeginEdit()
        End If
    End Sub

    Private Sub FilesMenuDelete()
        If FilesView.SelectedItems.Count > 0 Then
            Dim go As Boolean = True

            If FilesView.SelectedItems(0).Text = LogoTextBox.Text Then
                If MsgBox("此文檔已被設為封面，是否刪除？", MsgBoxStyle.YesNo, "刪除") = MsgBoxResult.No Then
                    go = False
                End If
            ElseIf FilesView.SelectedItems(0).Text.Contains(".kzinf") Then
                MsgBox("此文檔為書庫系統檔，不可刪除！", MsgBoxStyle.OkOnly, "刪除")
                go = False
            End If

            If go Then
                Try
                    'Dim fn As String = Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).Text)
                    File.Delete(Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).Text))
                    FilesView.Items.Remove(FilesView.SelectedItems(0))
                    SetManifest(LibView.SelectedNode.FullPath, CurrentInf)
                Catch ex As Exception
                    MsgBox("未能正常刪除文檔。原因：" & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub FilesMenuSetToCover()
        If FilesView.Items.Count > 0 AndAlso FilesView.SelectedItems.Count > 0 Then
            If LogoTextBox.Text IsNot Nothing AndAlso LogoTextBox.Text.Trim.Length > 0 Then
                If MsgBox("已存在指定封面，是否替換？", MsgBoxStyle.YesNo, "封面") = MsgBoxResult.Yes Then
                    LogoTextBox.Text = FilesView.SelectedItems(0).Text
                End If
            Else
                LogoTextBox.Text = FilesView.SelectedItems(0).Text
            End If
        End If
    End Sub

#End Region 'DataMenus


    Private Sub WebViewer_SourceCodeExported(sender As Object, e As SourceCodeExportEventArgs) Handles WebViewer.SourceCodeExported
        If Not WebViewer.ShowSourceInternal Then
            QuickViewer.Contents = e.Code
            QuickViewer.DefaultEncoding = Encoding.UTF8
            QuickViewer.FilePath = e.Source
            BrowserTabs.SelectedTab = PageView
        End If
    End Sub

    Private Sub HDLibView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If UpdateInfButton.Enabled Then
            If MsgBox("當前 Inf 未保存。是否保存？", MsgBoxStyle.YesNo, "退出") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UpdateInfButton_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub OriginListItem_Click(sender As Object, e As EventArgs) Handles OriginListItem.Click
        If iBro.Document Is Nothing Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim src As String = KzWeb.GetWebCode(iBro.Url.AbsoluteUri)
        QuickViewer.Contents = HDLibHelper.GetHDList(src)
        BrowserTabs.SelectedTab = PageView
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub VersionListItem_Click(sender As Object, e As EventArgs) Handles VersionListItem.Click
        If iBro.Document Is Nothing Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim src As String = KzWeb.GetWebCode(iBro.Url.AbsoluteUri)
        QuickViewer.Contents = HDLibHelper.GetHDVersionList(src)
        BrowserTabs.SelectedTab = PageView
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CompletListItem_Click(sender As Object, e As EventArgs) Handles CompletListItem.Click
        HDLibHelper.CreateCompletList(HDCategories.Mystery, Path.Combine(LibView.LibRoot, "LibDB"))
        'MsgBox(HDLibHelper.GetCombinedSource(HDCategories.Mystery))
    End Sub

    Private Sub OpenDataPanelItem_Click(sender As Object, e As EventArgs) Handles OpenDataPanelItem.Click
        Dim ldb As New HDLibDB
        ldb.RootTextBox.Text = LibView.LibRoot
        ldb.ShowDialog()
    End Sub
End Class

