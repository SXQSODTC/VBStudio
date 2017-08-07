' Copyright (c) Microsoft Corporation. All rights reserved.
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
