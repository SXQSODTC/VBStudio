Imports System.IO

Public Class HDLibTree
    Inherits TreeView

    Public Sub New()

        Me.SuspendLayout()

        '' Get images for tree.
        ImageList = New ImageList()
        With ImageList.Images
            .Add(My.Resources.drive_hdd)
            .Add(My.Resources.folder_close)
            .Add(My.Resources.folder_open)
        End With

        LineColor = Color.DarkCyan
        HideSelection = False
        LabelEdit = True

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
                Dim tnDir As New TreeNode(di.Name, 1, 2)
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
    Private _OriginInf As HDLibInf
    Private _OriginManifest As HDManifest
    Private _OriginLinks As HDLinkList

    Public ReadOnly Property OriginInf As HDLibInf
        Get
            Return _OriginInf
        End Get
    End Property

    Public ReadOnly Property OriginManifest As HDManifest
        Get
            Return _OriginManifest
        End Get
    End Property

    Public ReadOnly Property OriginLinks As HDLinkList
        Get
            Return _OriginLinks
        End Get
    End Property

    Public Property LibInf As HDLibInf
    Public Property Manifest As HDManifest
    Public Property Links As HDLinkList

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

        MyBase.OnAfterLabelEdit(e)
    End Sub

    Protected Overrides Sub OnBeforeSelect(e As TreeViewCancelEventArgs)
        If Me.SelectedNode IsNot Nothing Then
            If (Not LibInf.Equals(_OriginInf)) Or
                (Not Manifest.Equals(_OriginManifest)) Or
                (Not Links.Equals(_OriginLinks)) Then

                Dim s As String = "當前資訊檔已經更改，是否保存？" & vbCrLf &
                    "【是】保存當前資訊檔後執行跳轉。" & vbCrLf &
                    "【否】不保存當前資訊即跳轉。" & vbCrLf & "【取消】終止跳轉。"
                Dim r As MsgBoxResult = MsgBox(s, MsgBoxStyle.YesNo, "跳轉")

                If r = MsgBoxResult.Yes Then
                    SaveInf()

                ElseIf r = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If

        MyBase.OnBeforeSelect(e)
    End Sub

    Protected Overrides Sub OnAfterSelect(e As TreeViewEventArgs)

        MyBase.OnAfterSelect(e)
    End Sub

    Private Sub GetInf()
        _OriginInf = New HDLibInf
        _OriginManifest = New HDManifest
        _OriginLinks = New HDLinkList

        If Me.SelectedNode IsNot Nothing Then
            Try
                _OriginInf.Import(Me.SelectedNode.FullPath)
                _OriginManifest.Import(Me.SelectedNode.FullPath)
                _OriginLinks.Import(Me.SelectedNode.FullPath)
            Catch ex As Exception

            End Try
        End If

        LibInf = _OriginInf
        Manifest = _OriginManifest
        Links = _OriginLinks
    End Sub

    Private Sub SaveInf()
        If (Me.SelectedNode Is Nothing) OrElse
            (Me.SelectedNode.Parent Is Nothing) Then
            Exit Sub
        End If

        Dim p As String = Me.SelectedNode.FullPath

        If Not LibInf.Equals(_OriginInf) Then LibInf.Export(p)
        If Not Manifest.Equals(_OriginManifest) Then Manifest.Export(p)
        If Not Links.Equals(_OriginLinks) Then Links.Export(p)
    End Sub
End Class
