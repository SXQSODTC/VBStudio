Imports System.IO

Public Class HDLibTree
    Inherits TreeView

    Public Sub New()

        Me.SuspendLayout()

        '' Get images for tree.
        ImageList = New ImageList()
        With ImageList.Images
            .Add(My.Resources.ico_Lib)
            .Add(My.Resources.ico_book)
            .Add(My.Resources.ico_author)
            .Add(My.Resources.ico_category)
            .Add(My.Resources.ico_special)
            .Add(My.Resources.ico_series)
            .Add(My.Resources.ico_list)
            .Add(My.Resources.ico_unknown)
        End With

        LineColor = Color.DarkCyan
        HideSelection = False
        LabelEdit = True

        CreateMenu()

        Me.ResumeLayout(False)
    End Sub

    Public Property LibRoot As String = "C:\"

    Public Property ExceptFolders As Specialized.StringCollection = New Specialized.StringCollection

    Public Sub RefreshTree()

        ' For performance reasons and to avoid TreeView "flickering" during an 
        ' large node update, it is best to wrap the update code in BeginUpdate...
        ' EndUpdate statements.
        BeginUpdate()

        Nodes.Clear()

        If Directory.Exists(LibRoot) Then
            Dim tnFolder As New TreeNode(LibRoot, 0, 0)
            Nodes.Add(tnFolder)
            AddDirectories(tnFolder)

            SelectedNode = tnFolder

        Else
            Dim tnBlank As New TreeNode("Empty")
            Nodes.Add(tnBlank)
        End If

        Sort()
        EndUpdate()
    End Sub

    ' Handles the BeforeExpand event for the subclassed TreeView. See further 
    ' comments about the Before_____ and After_______ TreeView event pairs in 
    ' /DirectoryScanner/DirectoryScanner.vb.
    Protected Overrides Sub OnBeforeExpand(ByVal tvcea As TreeViewCancelEventArgs)
        MyBase.OnBeforeExpand(tvcea)

        ' For performance reasons and to avoid TreeView "flickering" during an 
        ' large node update, it is best to wrap the update code in BeginUpdate...
        ' EndUpdate statements.
        BeginUpdate()

        Dim tn As TreeNode
        ' Add child nodes for each child node in the node clicked by the user. 
        ' For performance reasons each node in the DirectoryTreeView 
        ' contains only the next level of child nodes in order to display the + sign 
        ' to indicate whether the user can expand the node. So when the user expands
        ' a node, in order for the + sign to be appropriately displayed for the next
        ' level of child nodes, *their* child nodes have to be added.
        For Each tn In tvcea.Node.Nodes
            AddDirectories(tn)
        Next tn

        EndUpdate()
    End Sub

    ' This subroutine is used to add a child node for every directory under its
    ' parent node, which is passed as an argument. See further comments in the
    ' OnBeforeExpand event handler.
    Private Sub AddDirectories(ByVal tn As TreeNode)
        tn.Nodes.Clear()

        Dim strPath As String = tn.FullPath
        Dim diDirectory As New DirectoryInfo(strPath)
        Dim adiDirectories() As DirectoryInfo

        Try
            ' Get an array of all sub-directories as DirectoryInfo objects.
            adiDirectories = diDirectory.GetDirectories()
        Catch exp As Exception
            Exit Sub
        End Try

        Dim di As DirectoryInfo
        For Each di In adiDirectories
            Dim go As Boolean = True
            If ExceptFolders.Count > 0 Then
                For Each tx As String In ExceptFolders
                    If tx = di.Name Then
                        go = False
                        Exit For
                    End If
                Next
            End If

            If go Then
                ' Create a child node for every sub-directory, passing in the directory
                ' name and the images its node will use.
                Dim i As Integer = GetImgId(di)
                Dim tnDir As New TreeNode(di.Name, i, i)
                ' Add the new child node to the parent node.
                tn.Nodes.Add(tnDir)

                ' We could now fill up the whole tree by recursively calling 
                ' AddDirectories():
                '
                '   AddDirectories(tnDir)
                '
                ' This is way too slow, however. Give it a try!
            End If

        Next
    End Sub

    '====================
    'Additional for HDLib
    '====================
    'Private _OriginInf As HDLibInf
    'Private _OriginManifest As HDManifest
    'Private _OriginLinks As HDLinkList

    'Public ReadOnly Property OriginInf As HDLibInf
    '    Get
    '        Return _OriginInf
    '    End Get
    'End Property

    'Public ReadOnly Property OriginManifest As HDManifest
    '    Get
    '        Return _OriginManifest
    '    End Get
    'End Property

    'Public ReadOnly Property OriginLinks As HDLinkList
    '    Get
    '        Return _OriginLinks
    '    End Get
    'End Property

    'Public Property LibInf As HDLibInf
    'Public Property Manifest As HDManifest
    'Public Property Links As HDLinkList

#Region "OverridesMethods"
    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        If e.Button = MouseButtons.Left Or e.Button = MouseButtons.Right Then
            Dim nd As TreeNode = Me.GetNodeAt(e.Location)
            If Not nd.Equals(Me.SelectedNode) Then
                Me.SelectedNode = nd
            End If
        End If

        MyBase.OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnBeforeLabelEdit(e As NodeLabelEditEventArgs)
        If e.Node.Parent Is Nothing Then e.CancelEdit = True

        MyBase.OnBeforeLabelEdit(e)
    End Sub

    Protected Overrides Sub OnAfterLabelEdit(e As NodeLabelEditEventArgs)
        '如果是根目錄則取消編輯
        If e.Node.Parent Is Nothing Then
            e.CancelEdit = True
            Exit Sub
        End If

        '如果編輯結果為空，新建節點則重新編輯，更名節點則放棄編輯
        If e.Label Is Nothing Then
            If e.Node.Tag = "New" Then
                e.Node.BeginEdit()
            Else
                e.CancelEdit = True
            End If
            Exit Sub
        End If

        '如果編輯結果為 New，則繼續編輯
        If e.Label = "New" Then
            MsgBox("資料夾不能為 New")
            e.Node.BeginEdit()
            Exit Sub
        End If

        '執行
        Dim np As String = Path.Combine(e.Node.Parent.FullPath, e.Label)

        If Directory.Exists(np) Then
            Dim s As String = "資料夾已存在，是否繼續改名？" & vbCrLf &
                       "【是】關閉本提示繼續改名。" & vbCrLf & "【否】放棄編輯，如為新增則刪除項目。"

            If MsgBox(s, MsgBoxStyle.YesNo, "更名") = MsgBoxResult.Yes Then
                e.Node.BeginEdit()
            Else
                e.CancelEdit = True

                If e.Node.Tag = "New" Then
                    e.Node.Remove()
                End If
            End If

            Exit Sub

        Else

            If e.Node.Tag = "New" Then
                Try
                    Directory.CreateDirectory(np)
                    e.Node.Text = e.Label
                    e.Node.EndEdit(False)
                    e.Node.Tag = Nothing
                    SelectedNode = e.Node
                Catch ex As Exception
                    MsgBox("未能應用更改。原因：" & vbCrLf &
                       ex.Message, MsgBoxStyle.OkOnly, "更名")
                    e.CancelEdit = True
                    e.Node.Remove()
                    Exit Sub
                End Try

            Else

                If Directory.Exists(e.Node.FullPath) And (Not (e.Label = e.Node.Text)) Then
                    FileIO.FileSystem.RenameDirectory(e.Node.FullPath, e.Label)
                    e.Node.Text = e.Label
                    e.Node.EndEdit(False)
                    SelectedNode = e.Node
                Else
                    e.CancelEdit = True
                End If
            End If
        End If

        MyBase.OnAfterLabelEdit(e)
    End Sub

    'Protected Overrides Sub OnBeforeSelect(e As TreeViewCancelEventArgs)
    '    'If Me.SelectedNode IsNot Nothing Then
    '    '    If (Not LibInf.Equals(_OriginInf)) Or
    '    '        (Not Manifest.Equals(_OriginManifest)) Or
    '    '        (Not Links.Equals(_OriginLinks)) Then

    '    '        Dim s As String = "當前資訊檔已經更改，是否保存？" & vbCrLf &
    '    '            "【是】保存當前資訊檔後執行跳轉。" & vbCrLf &
    '    '            "【否】不保存當前資訊即跳轉。" & vbCrLf & "【取消】終止跳轉。"
    '    '        Dim r As MsgBoxResult = MsgBox(s, MsgBoxStyle.YesNo, "跳轉")

    '    '        If r = MsgBoxResult.Yes Then
    '    '            'SaveInf(Me.SelectedNode)

    '    '        ElseIf r = MsgBoxResult.Cancel Then
    '    '            e.Cancel = True
    '    '        End If
    '    '    End If
    '    'End If

    '    MyBase.OnBeforeSelect(e)
    'End Sub

    'Protected Overrides Sub OnAfterSelect(e As TreeViewEventArgs)
    '    MyBase.OnAfterSelect(e)

    '    'GetInf(e.Node)

    'End Sub

    'Public Event InfoChanged(sender As Object, e As EventArgs)
#End Region 'OverridesMethods

#Region "PrivateMethods"
    Private Function GetImgId(di As DirectoryInfo) As Integer
        Dim fn As String
        Try
            fn = di.GetFiles("*.kzinf", SearchOption.TopDirectoryOnly)(0).Name
        Catch ex As Exception
            fn = Nothing
        End Try

        Select Case fn
            Case "Lib.kzinf" : Return 0
            Case "Book.kzinf" : Return 1
            Case "Author.kzinf" : Return 2
            Case "Category.kzinf" : Return 3
            Case "Special.kzinf" : Return 4
            Case "Series.kzinf" : Return 5
            Case Else : Return 7
        End Select
    End Function

    'Private Sub GetInf(node As TreeNode)
    '    _OriginInf = New HDLibInf
    '    _OriginManifest = New HDManifest
    '    _OriginLinks = New HDLinkList

    '    Dim IsOrigin As Boolean = True

    '    If node IsNot Nothing Then
    '        Try
    '            _OriginInf.Import(node.FullPath)
    '            IsOrigin = False
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            _OriginManifest.Import(node.FullPath)
    '            IsOrigin = False
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            _OriginLinks.Import(node.FullPath)
    '            IsOrigin = False
    '        Catch ex As Exception
    '        End Try
    '    End If

    '    If Not IsOrigin Then
    '        RaiseEvent InfoChanged(Me, Nothing)
    '    End If

    '    LibInf = _OriginInf
    '    Manifest = _OriginManifest
    '    Links = _OriginLinks
    'End Sub

    'Private Sub SaveInf(node As TreeNode)
    '    If (node Is Nothing) OrElse
    '        (node.Parent Is Nothing) Then
    '        Exit Sub
    '    End If

    '    If Not LibInf.Equals(_OriginInf) Then
    '        LibInf.Export(node.FullPath)
    '        node.ImageIndex = GetImgId(New DirectoryInfo(node.FullPath))
    '        node.SelectedImageIndex = node.ImageIndex
    '    End If
    '    If Not Manifest.Equals(_OriginManifest) Then Manifest.Export(node.FullPath)
    '    If Not Links.Equals(_OriginLinks) Then Links.Export(node.FullPath)
    'End Sub
#End Region 'PrivateMethods

#Region "ContextMenu"
    Friend WithEvents LibTreeMenu As ContextMenuStrip
    Friend WithEvents AddSubItem As ToolStripMenuItem
    Friend WithEvents AddHereItem As ToolStripMenuItem
    Friend WithEvents RenameItem As ToolStripMenuItem
    Friend WithEvents CopyItem As ToolStripMenuItem
    Friend WithEvents CutItem As ToolStripMenuItem
    Friend WithEvents PasteItem As ToolStripMenuItem
    Friend WithEvents DeleteItem As ToolStripMenuItem

    Private Sub CreateMenu()
        LibTreeMenu = New ContextMenuStrip
        LibTreeMenu.SuspendLayout()
        AddSubItem = New ToolStripMenuItem("Add Sub")
        AddHereItem = New ToolStripMenuItem("Add Here")
        RenameItem = New ToolStripMenuItem("Rename")
        CopyItem = New ToolStripMenuItem("Copy")
        CutItem = New ToolStripMenuItem("Cut")
        PasteItem = New ToolStripMenuItem("Paste")
        DeleteItem = New ToolStripMenuItem("Delete")

        LibTreeMenu.Items.AddRange(
            New ToolStripItem() {
            AddSubItem, AddHereItem, New ToolStripSeparator,
            RenameItem, New ToolStripSeparator,
            CopyItem, CutItem, PasteItem, New ToolStripSeparator,
            DeleteItem})
        LibTreeMenu.ResumeLayout(False)
        Me.ContextMenuStrip = LibTreeMenu
    End Sub

    Private Sub LibTreeMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles LibTreeMenu.ItemClicked

        If SelectedNode Is Nothing Then Exit Sub
        '新增至子項
        If e.ClickedItem.Equals(AddSubItem) Then
            If Not SelectedNode.IsEditing Then
                Dim NewNode As New TreeNode("New", 7, 7)
                NewNode.Tag = "New"
                SelectedNode.Nodes.Add(NewNode)
                SelectedNode.Expand()
                NewNode.BeginEdit()
            End If
        End If
        '新增至同層
        If e.ClickedItem.Equals(AddHereItem) Then
            If Not SelectedNode.IsEditing Then
                If Not SelectedNode.Parent Is Nothing Then
                    Dim NewNode As New TreeNode("New", 7, 7)
                    NewNode.Tag = "New"
                    SelectedNode.Parent.Nodes.Add(NewNode)
                    NewNode.BeginEdit()
                End If
            End If
        End If
        '更名
        If e.ClickedItem.Equals(RenameItem) Then
            If Not SelectedNode.Parent Is Nothing Then
                SelectedNode.BeginEdit()
            End If
        End If
        '移除
        If e.ClickedItem.Equals(DeleteItem) Then
            If Not SelectedNode.Parent Is Nothing Then
                Dim s As String = "此舉將刪除選定的資料夾。是否繼續？" + vbCrLf +
                    "【是】資料夾 " + SelectedNode.FullPath + " 及其子項目將被刪除。" + vbCrLf +
                    "【否】將不執行任何操作。"

                If MsgBox(s, MsgBoxStyle.YesNo, "刪除") = MsgBoxResult.Yes Then
                    Try
                        Directory.Delete(SelectedNode.FullPath, True)

                        Dim tempNode As TreeNode
                        If SelectedNode.NextNode IsNot Nothing Then
                            tempNode = SelectedNode.NextNode
                        ElseIf SelectedNode.PrevNode IsNot Nothing Then
                            tempNode = SelectedNode.PrevNode
                        Else
                            tempNode = SelectedNode.Parent
                        End If
                        SelectedNode.Remove()
                        SelectedNode = tempNode
                    Catch ex As Exception
                        MsgBox("資料夾未能刪除。原因：" + vbCrLf + ex.Message, MsgBoxStyle.OkOnly, "刪除")
                    End Try
                End If
            End If
        End If
        '複製，剪切
        If e.ClickedItem.Equals(CopyItem) Or
            e.ClickedItem.Equals(CutItem) Then

            If Not SelectedNode.Parent Is Nothing Then
                'CopiedNode = SelectedNode
            End If

            PasteItem.Enabled = True
        End If
        '粘貼
        If e.ClickedItem.Equals(PasteItem) Then


            PasteItem.Enabled = False
        End If
    End Sub
#End Region 'ContextMenu
End Class
