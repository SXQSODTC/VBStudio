﻿' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.IO
Imports System.Windows.Forms
Imports System.Diagnostics ' For Process.Start


' Copyright (c) Microsoft Corporation. All rights reserved.
' This class simply extends the TreeNode class by adding a Size field to support
' indicated directory size by color.
Public Class DirectoryNode
    Inherits TreeNode

    Public Size As Long

End Class

' Copyright (c) Microsoft Corporation. All rights reserved.


' Copyright (c) Microsoft Corporation. All rights reserved.
' This class is needed because the 
' System.Windows.Forms.Design.FolderNameEditor.FolderBrowser is Protected and thus 
' is not accessible in this context. Deriving a Public class from it enables you to
' use the dialog in your code.
Public Class FolderBrowser
    Inherits System.Windows.Forms.Design.FolderNameEditor

    Public Shared Function ShowDialog() As String
        Dim folders As New FolderBrowser()
        folders.Description = "Select a Directory to Scan"
        folders.Style = Design.FolderNameEditor.FolderBrowserStyles.RestrictToFilesystem
        folders.ShowDialog()


        Return folders.DirectoryPath
    End Function
End Class

Public Class KzDirectoryTreeView
    Inherits TreeView

    ' This is the Class constructor.
    Public Sub New()
        '' Make a little more room for long directory names.
        'Me.Width *= 2

        '' Get images for tree.
        Me.ImageList = New ImageList()
        With Me.ImageList.Images
            .Add(My.Resources.drive_hdd)
            .Add(My.Resources.folder_close)
            .Add(My.Resources.folder_open)
        End With

        '' Construct tree.
        'RefreshTree()
    End Sub

#Region "PublicSecssion"
    ''' <summary>
    ''' 指示是否顯示全系統的資料夾樹形結構，True：全部顯示；False：從指定的分支開始顯示。
    ''' </summary>
    ''' <returns></returns>
    Public Property ShowAllDirectories As Boolean = False
    ''' <summary>
    ''' 指定樹形結構的開始資料夾，用以創建路徑起點。 
    ''' 如 ShowAllDirectories 設為 True，本屬性將失效。
    ''' </summary>
    ''' <returns></returns>
    Public Property StartDirectory As String = "C:\"

    Public Property NeedSort As Boolean = True

    Public Property ExceptNames As System.Collections.Specialized.StringCollection = New System.Collections.Specialized.StringCollection

    ' This subroutine clears out the existing TreeNode objects and rebuilds the 
    ' DirectoryTreeView, showing the logical drives.
    Public Sub RefreshTree()

        ' For performance reasons and to avoid TreeView "flickering" during an 
        ' large node update, it is best to wrap the update code in BeginUpdate...
        ' EndUpdate statements.
        BeginUpdate()

        Nodes.Clear()

        If ShowAllDirectories Then

            ' Make disk drives the root nodes. 
            Dim astrDrives As String() = Directory.GetLogicalDrives()

            Dim strDrive As String
            For Each strDrive In astrDrives
                Dim tnDrive As New TreeNode(strDrive, 0, 0)
                Nodes.Add(tnDrive)
                AddDirectories(tnDrive)

                ' Set the C drive as the default selection.
                If strDrive = "C:\" Then
                    SelectedNode = tnDrive
                End If
            Next

        Else

            If Directory.Exists(StartDirectory) Then
                Dim tnFolder As New TreeNode(StartDirectory, 0, 0)
                Nodes.Add(tnFolder)
                AddDirectories(tnFolder)

                SelectedNode = tnFolder

            Else
                Dim tnBlank As New TreeNode("Empty")
                Nodes.Add(tnBlank)
            End If
        End If

        If NeedSort Then
            Sort()
        End If

        EndUpdate()
    End Sub
#End Region 'PublicSecssion


    ' Handles the BeforeExpand event for the subclassed TreeView. See further 
    ' comments about the Before_____ and After_______ TreeView event pairs in 
    ' /DirectoryScanner/DirectoryScanner.vb.
    Protected Overrides Sub OnBeforeExpand(ByVal tvcea As TreeViewCancelEventArgs)
        MyBase.OnBeforeExpand(tvcea)

        ' For performance reasons and to avoid TreeView "flickering" during an 
        ' large node update, it is best to wrap the update code in BeginUpdate...
        ' EndUpdate statements.
        Me.BeginUpdate()

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

        Me.EndUpdate()
    End Sub

    ' This subroutine is used to add a child node for every directory under its
    ' parent node, which is passed as an argument. See further comments in the
    ' OnBeforeExpand event handler.
    Sub AddDirectories(ByVal tn As TreeNode)
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
            If Me.ExceptNames.Count > 0 Then
                For Each tx As String In Me.ExceptNames
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

    'Public Property ConnectedListView As KzFileListView = Nothing

    'Protected Overrides Sub OnAfterSelect(e As TreeViewEventArgs)
    '    MyBase.OnAfterSelect(e)

    '    If ConnectedListView IsNot Nothing Then
    '        Try
    '            ConnectedListView.Directory = New DirectoryInfo(Me.SelectedNode.FullPath)
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub
End Class


Public Class KzFileListView
    Inherits ListView

    Private strDirectory As String

    Public Sub New()
        ' Set the default View enumeration to Details.
        Me.View = System.Windows.Forms.View.Details

        ' Get images as icons for some of the common file types.
        Dim img As New ImageList()
        'With img.Images
        '    .Add(My.Resources.DOC)
        '    .Add(My.Resources.EXE)
        'End With

        ' The Small and Large image lists for the ListView use the same set of
        ' images.
        Me.SmallImageList = img
        Me.LargeImageList = img

        ' Create the columns.
        With Columns
            .Add("Name", 100, HorizontalAlignment.Left)
            .Add("Size", 100, HorizontalAlignment.Right)
            .Add("Modified", 100, HorizontalAlignment.Left)
            .Add("Attribute", 100, HorizontalAlignment.Left)
        End With
    End Sub

    Public Property Directory As DirectoryInfo = Nothing


    ''' <summary>
    ''' Overrides the base class OnItemActivate event handler. Extends the base
    ''' class implementation to run any .exe or file with an associated executable.
    ''' </summary>
    Protected Overrides Sub OnItemActivate(ByVal ea As EventArgs)
        MyBase.OnItemActivate(ea)

        Dim lvi As ListViewItem
        For Each lvi In SelectedItems
            Process.Start(Path.Combine(strDirectory, lvi.Text))
        Next lvi
    End Sub

    ''' <summary>
    ''' This subroutine is used to display a list of all files in the directory
    ''' currently selected by the user from the custom TreeView control.
    ''' </summary>
    Public Sub ShowFiles(ByVal strDirectory As String)
        ' Save the directory name as a field.
        Me.strDirectory = strDirectory

        Items.Clear()

        Dim diDirectories As New DirectoryInfo(strDirectory)
        Dim afiFiles() As FileInfo

        Try
            ' Call the convenient GetFiles method to get an array of all files
            ' in the directory.
            afiFiles = diDirectories.GetFiles()
        Catch
            Return
        End Try

        Dim fi As FileInfo
        For Each fi In afiFiles
            ' Create ListViewItem.
            Dim lvi As New ListViewItem(fi.Name)

            ' Assign ImageIndex based on filename extension.
            Select Case Path.GetExtension(fi.Name).ToUpper()
                Case ".EXE"
                    lvi.ImageIndex = 1
                Case Else
                    lvi.ImageIndex = 0
            End Select

            ' Add file length and last modified time sub-items.
            lvi.SubItems.Add(fi.Length.ToString("N0"))
            lvi.SubItems.Add(fi.LastWriteTime.ToString())

            ' Add attribute subitem.
            Dim strAttr As String = ""

            If (fi.Attributes And FileAttributes.Archive) <> 0 Then
                strAttr += "A"
            End If
            If (fi.Attributes And FileAttributes.Hidden) <> 0 Then
                strAttr += "H"
            End If
            If (fi.Attributes And FileAttributes.ReadOnly) <> 0 Then
                strAttr += "R"
            End If
            If (fi.Attributes And FileAttributes.System) <> 0 Then
                strAttr += "S"
            End If
            lvi.SubItems.Add(strAttr)

            ' Add completed ListViewItem to FileListView.
            Items.Add(lvi)
        Next fi
    End Sub

End Class

Public Class KzFiles
    Public Shared Function IsImageFile(NameOrExtension As String) As Boolean
        If Not NameOrExtension.Contains(".") Then Return False
        If Not NameOrExtension.StartsWith(".") Then NameOrExtension = Path.GetExtension(NameOrExtension)

        Dim iforms As String() = My.Settings.ImageFormats.Split("|")
        For Each s As String In iforms
            If NameOrExtension = s Then Return True
        Next

        Return False
    End Function

    Public Shared Function IsImageFile(TheFile As FileInfo) As Boolean
        Return IsImageFile(TheFile.Extension)
    End Function
End Class