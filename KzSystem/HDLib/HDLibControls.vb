﻿Imports System.IO

Public Class HDLibTree
    Inherits TreeView

    Public Sub New()

        Me.SuspendLayout()

        '' Get images for tree.
        ImageList = New ImageList()
        With ImageList.Images
            .Add(My.Resources.ico_Lib) '0
            .Add(My.Resources.ico_book) '1
            .Add(My.Resources.ico_author) '2
            .Add(My.Resources.ico_category) '3
            .Add(My.Resources.ico_special) '4
            .Add(My.Resources.ico_series) '5
            .Add(My.Resources.ico_list) '6
            .Add(My.Resources.ico_unknown) '7
        End With

        LineColor = Color.DarkCyan
        HideSelection = False
        LabelEdit = True
        AllowDrop = True
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
                    If tx.ToLower = di.Name.ToLower Then
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

#Region "OverridesMethods"
    ' Clean up any resources being used. 
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            LibTreeMenu.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

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

    Protected Overrides Sub OnItemDrag(e As ItemDragEventArgs)
        MyBase.OnItemDrag(e)
        'Set the drag node and initiate the DragDrop
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Protected Overrides Sub OnDragEnter(e As DragEventArgs)
        MyBase.OnDragEnter(e)
        'See if there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
            'TreeNode found allow move effect
            e.Effect = DragDropEffects.Move
        Else
            'No TreeNode found, prevent move
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Protected Overrides Sub OnDragOver(e As DragEventArgs)
        MyBase.OnDragOver(e)
        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'As the mouse moves over nodes, provide feedback to
        'the user by highlighting the node that is the
        'current drop target
        Dim pt As Point = PointToClient(New Point(e.X, e.Y))
        Dim targetNode As TreeNode = GetNodeAt(pt)

        'See if the targetNode is currently selected,
        'if so no need to validate again
        If Not (SelectedNode Is targetNode) Then
            'Select the node currently under the cursor
            SelectedNode = targetNode

            'Check that the selected node is not the dropNode and
            'also that it is not a child of the dropNode and
            'therefore an invalid target
            Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)

            Do Until targetNode Is Nothing
                If targetNode Is dropNode Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If
                targetNode = targetNode.Parent
            Loop
        End If

        'Currently selected node is a suitable target
        e.Effect = DragDropEffects.Move
    End Sub

    Protected Overrides Sub OnDragDrop(e As DragEventArgs)
        MyBase.OnDragDrop(e)
        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeNode being dragged
        Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
        Dim sourceDir As String = dropNode.FullPath

        'The target node should be selected from the DragOver event
        Dim targetNode As TreeNode = SelectedNode
        Dim targetDir As String = targetNode.FullPath
        'MsgBox("<s>" & sourceDir & vbCrLf & "<t>" & Path.Combine(targetDir, Path.GetFileName(sourceDir)))
        Dim go As Boolean = False
        Try
            Directory.Move(sourceDir, Path.Combine(targetDir, Path.GetFileName(sourceDir)))
            go = True
        Catch ex As Exception
            MsgBox("未能移動資料夾。原因：" & vbCrLf & ex.Message)
        End Try

        If go Then
            'Remove the drop node from its current location
            dropNode.Remove()

            'If there is no targetNode add dropNode to the bottom of
            'the TreeView root nodes, otherwise add it to the end of
            'the dropNode child nodes
            If targetNode Is Nothing Then
                Nodes.Add(dropNode) ' selectedTreeview.Nodes.Add(dropNode)
            Else
                targetNode.Nodes.Add(dropNode)
            End If

            'Ensure the newley created node is visible to
            'the user and select it
            dropNode.EnsureVisible()
            SelectedNode = dropNode
        End If
    End Sub

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

    Public Function GetImgId(InfType As HDLibInfType) As Integer
        Select Case InfType
            Case HDLibInfType.LibInfo : Return 0
            Case HDLibInfType.BookInfo : Return 1
            Case HDLibInfType.AuthorInfo : Return 2
            Case HDLibInfType.CategoryInfo : Return 3
            Case HDLibInfType.SpecialInfo : Return 4
            Case HDLibInfType.SeriesInfo : Return 5
            Case Else : Return 7
        End Select
    End Function

    Public Sub ExpandToNode(NodePath As String)
        If NodePath.EndsWith(PathSeparator) Then NodePath = NodePath.Remove(NodePath.Length - 1, 1)
        If NodePath = LibRoot Then Exit Sub

        Dim base As TreeNode = Nodes(0)
        Dim nt As String = NodePath.Replace(LibRoot & "\", "")
        Dim nts As String() = nt.Split(PathSeparator)

        base.Expand()
        Dim nextnode As TreeNode
        For i As Integer = 0 To nts.Length - 1
            nextnode = FindNode(base.Nodes, nts(i))

            If Not i = nts.Length - 1 Then
                nextnode.Expand()
                base = nextnode
            Else
                SelectedNode = nextnode
            End If
        Next
    End Sub

    Private Function FindNode(Nodes As TreeNodeCollection, NodeText As String) As TreeNode
        For Each node As TreeNode In Nodes
            If node.Text = NodeText Then
                Return node
            End If
        Next

        Return Nothing
    End Function

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
    Friend WithEvents RefreshItem As ToolStripMenuItem
    Friend WithEvents SortingItem As ToolStripMenuItem

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
        RefreshItem = New ToolStripMenuItem("Refresh")
        SortingItem = New ToolStripMenuItem("Sorting")

        LibTreeMenu.Items.AddRange(
            New ToolStripItem() {
            AddSubItem, AddHereItem, New ToolStripSeparator,
            RenameItem, New ToolStripSeparator,
            CopyItem, CutItem, PasteItem, New ToolStripSeparator,
            DeleteItem, New ToolStripSeparator,
            SortingItem, RefreshItem})
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

        If e.ClickedItem.Equals(SortingItem) Then
            Sort()
        End If

        If e.ClickedItem.Equals(RefreshItem) Then
            'If SelectedNode IsNot Nothing Then
            '    Dim TempNode As TreeNode = SelectedNode

            '    Try
            '        RefreshTree()
            '        TempNode.EnsureVisible()
            '    Catch ex As Exception

            '    End Try
            'End If

            Dim TempPath As String

            If SelectedNode Is Nothing Then
                TempPath = Nothing
            Else
                TempPath = SelectedNode.FullPath
            End If

            Try
                RefreshTree()
                ExpandToNode(TempPath)
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region 'ContextMenu
End Class
