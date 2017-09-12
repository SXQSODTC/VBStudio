Imports System.IO
Imports System.Text

Public Class HDLibView

    Private OriginInf As HDLibInf
    Private CurrentInf As HDLibInf

    Private NeedUpdateInf As Boolean = True

    Private Sub HDLibView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LibView.LibRoot = My.Settings.HDLibPath
        LibView.ExceptFolders.Add("LibDB")
        LibView.RefreshTree()

        For i As Integer = 0 To [Enum].GetNames(GetType(HDLibInfType)).Count - 1
            TypeComboBox.Items.Add(CType(i, HDLibInfType))
        Next

        PresetLists()
    End Sub


#Region "LibTreeAndList"
    Private Sub LibSearchTools_SizeChanged(sender As Object, e As EventArgs) Handles LibSearchTools.SizeChanged
        LibSearchTextBox.Width = LibSearchTools.Width - LibSearchGoButton.Width - LibSearchAdvanceButton.Width - 10
    End Sub

    Private Sub LibSearchTextBox_GotFocus(sender As Object, e As EventArgs) Handles LibSearchTextBox.GotFocus
        LibSearchTextBox.AutoCompleteCustomSource.Clear()
        LibSearchTextBox.AutoCompleteCustomSource = GetAllNodeText(LibView.Nodes(0))
    End Sub

    Private Sub LibSearchAdvanceButton_Click(sender As Object, e As EventArgs) Handles LibSearchAdvanceButton.Click
        Dim hdls As New HDLibSearch
        If hdls.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub LibView_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles LibView.BeforeSelect
        Try
            If (Not CurrentInf.Equals(OriginInf)) AndAlso (Not CurrentInf.IsEmpty) Then
                Dim s As String = "當前咨詢已經更改，是否保存？" & vbCrLf &
                        "【是】保存當前資訊檔後執行跳轉選定。" & vbCrLf &
                        "【否】不保存當前資訊即跳轉。" & vbCrLf & "【取消】終止執行跳轉。"
                Dim r As MsgBoxResult = MsgBox(s, MsgBoxStyle.YesNoCancel, "跳轉")

                If r = MsgBoxResult.Yes Then
                    Try
                        CurrentInf.Export(LibView.SelectedNode.FullPath)
                    Catch ex As Exception
                        MsgBox("未能保存 Inf。原因：" & vbCrLf & ex.Message)
                        e.Cancel = True
                    End Try

                ElseIf r = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LibView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LibView.AfterSelect
        LibSearchTextBox.Text = e.Node.FullPath

        OriginInf = New HDLibInf
        OriginInf.Import(e.Node.FullPath)
        CurrentInf = New HDLibInf
        CurrentInf.Import(e.Node.FullPath)

        SetUIFromInf(CurrentInf)
        SetHeader(e.Node.FullPath, CurrentInf)

        EntryChecking(e.Node.FullPath, CurrentInf)

        SetManifest(e.Node.FullPath, CurrentInf)
    End Sub

#End Region 'LibTreeAndList

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

        End If
    End Sub

    Private Sub SaveInfButton_Click(sender As Object, e As EventArgs) Handles SaveInfButton.Click
        'MsgBox(LibView.SelectedNode.FullPath & "\" & CurrentInf.FileName)
        Try
            CurrentInf.Address = LibView.SelectedNode.FullPath.Replace(LibView.LibRoot & "\", "")
            CurrentInf.Export(LibView.SelectedNode.FullPath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShowInfButton_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ShowInfButton.DropDownItemClicked
        If e.ClickedItem.Equals(CurrentInfToolStripMenuItem) Then SourceTextBox.Text = CurrentInf.ToString
        If e.ClickedItem.Equals(OriginInfToolStripMenuItem) Then SourceTextBox.Text = OriginInf.ToString

        BrowserTabs.SelectedTab = PageSource
    End Sub

#End Region 'MenuActions

#Region "PrivateMethods"
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
        Dim di As New DirectoryInfo(Folder)
        Dim fis As FileInfo() = di.GetFiles

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

            If extstr = "書籍" And Not extList.Contains(ext) Then extList.Add(ext)

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

        For Each it As ListViewItem In FilesView.Items
            If (it.SubItems.Item(4).Text IsNot Nothing) Or
                (it.SubItems.Item(4).Text.Length) > 0 Then

                mf.Add(it.SubItems.Item(0).Text, it.SubItems.Item(4).Text)
            End If
        Next

        Return mf
    End Function

    Private Sub SetLinks()

    End Sub

    Private Sub GetLinks()

    End Sub


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
    End Sub

    Private Sub EntryChecking(Folder As String, Inf As HDLibInf)
        Dim Fn As String

        CFolderChecker.Text = "Folder: " & Folder
        If Directory.Exists(Folder) Then
            CFolderChecker.Checked = True

            'Dim di As New DirectoryInfo(Folder)
            'If di.GetFiles().Count > 0 Then
            '    CEmptyChecker.Checked = False
            'Else
            '    CEmptyChecker.Checked = True
            'End If

        Else
            CFolderChecker.Checked = False
            'CEmptyChecker.Checked = True
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

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged
        If NeedUpdateInf Then
            CurrentInf.Type = TypeComboBox.SelectedItem

            Try
                Dim fn As String = Path.Combine(LibView.SelectedNode.FullPath, CurrentInf.FileName)
                CInfFileChecker.Text = "Inf: " & fn
                CInfFileChecker.Checked = File.Exists(fn)
            Catch ex As Exception
                CInfFileChecker.Text = "Inf: "
                CInfFileChecker.Checked = False
            End Try
        End If
    End Sub

    Private Sub OriginComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OriginComboBox.SelectedIndexChanged
        If NeedUpdateInf Then CurrentInf.Origin = OriginComboBox.SelectedItem
    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged
        If NeedUpdateInf Then
            CurrentInf.ID = IDTextBox.Text
            HIDLabel.Text = IDTextBox.Text
        End If
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NeedUpdateInf Then
            CurrentInf.Name = NameTextBox.Text
            HTitleLabel.Text = NameTextBox.Text
        End If
    End Sub

    Private Sub SeriesTextBox_TextChanged(sender As Object, e As EventArgs) Handles SeriesTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Series = SeriesTextBox.Text
    End Sub

    Private Sub AuthorTextBox_TextChanged(sender As Object, e As EventArgs) Handles AuthorTextBox.TextChanged
        If NeedUpdateInf Then
            CurrentInf.Author = AuthorTextBox.Text
            HAuthorLabel.Text = AuthorTextBox.Text
        End If
    End Sub

    Private Sub ContributorTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContributorTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Contributor = ContributorTextBox.Text
    End Sub

    Private Sub CategoryTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Category = CategoryTextBox.Text
    End Sub

    Private Sub SpecialTextBox_TextChanged(sender As Object, e As EventArgs) Handles SpecialTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Special = SpecialTextBox.Text
    End Sub

    Private Sub VersionTextBox_TextChanged(sender As Object, e As EventArgs) Handles VersionTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Version = VersionTextBox.Text
    End Sub

    Private Sub LogoTextBox_TextChanged(sender As Object, e As EventArgs) Handles LogoTextBox.TextChanged
        If NeedUpdateInf Then
            CurrentInf.Logo = LogoTextBox.Text
            HCoverImageBox.Image = Image.FromFile(Path.Combine(LibView.SelectedNode.FullPath, LogoTextBox.Text))
        End If
    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Address = AddressTextBox.Text
    End Sub

    Private Sub RefaddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles RefaddressTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.RefAddress = RefaddressTextBox.Text
    End Sub

    Private Sub CreatedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CreatedTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Created = CDate(CreatedTextBox.Text)
    End Sub

    Private Sub UpdatedTextBox_TextChanged(sender As Object, e As EventArgs) Handles UpdatedTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Updated = CDate(UpdatedTextBox.Text)
    End Sub

    Private Sub RemarksTextBox_TextChanged(sender As Object, e As EventArgs) Handles RemarksTextBox.TextChanged
        If NeedUpdateInf Then CurrentInf.Remarks = RemarksTextBox.Text
    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged
        If NeedUpdateInf Then
            CurrentInf.Description = DescriptionTextBox.Text
            HPilotLabel.Text = DescriptionTextBox.Text
        End If
    End Sub

#End Region 'DataChangedAction

    'TempArea

    Private Sub LUpdateButton_Click(sender As Object, e As EventArgs) Handles LUpdateButton.Click
        If FilesView.SelectedItems.Count > 0 Then
            If LCommentsTextBox.Text IsNot Nothing AndAlso LCommentsTextBox.Text.Length > 0 Then
                FilesView.SelectedItems(0).SubItems(4).Text = LCommentsTextBox.Text
            End If
        End If

        Try
            CurrentInf.Manifest = GetManifest()
        Catch ex As Exception

        End Try

        LUpdateButton.Enabled = False
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
            LViewButton.Enabled = False
        End If
        LUpdateButton.Enabled = False
    End Sub

    Private Sub LViewButton_Click(sender As Object, e As EventArgs) Handles LViewButton.Click
        Try
            Dim fn As String = Path.Combine(LibView.SelectedNode.FullPath, FilesView.SelectedItems(0).SubItems(0).Text)
            SourceTextBox.Text = File.ReadAllText(fn, Encoding.UTF8)
            TEncodingLabel.Text = "UTF8"
            TPathLabel.Text = fn
            BrowserTabs.SelectedTab = PageSource
        Catch ex As Exception

        End Try
    End Sub
End Class