Imports System.IO

Public Class HDLibView

    Private _Origin As HDLibInf
    Private _Current As HDLibInf
    Private _TempNode As TreeNode

    Private Sub HDLibView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LibView.StartDirectory = My.Settings.HDLibPath
        LibView.ExceptNames.Add("LibDB")
        LibView.RefreshTree()

    End Sub


#Region "LibTreeAndList"
    Private Sub LibSearchTools_SizeChanged(sender As Object, e As EventArgs) Handles LibSearchTools.SizeChanged
        LibSearchTextBox.Width = LibSearchTools.Width - LibSearchGoButton.Width - LibSearchAdvanceButton.Width - 10
    End Sub

#End Region 'LibTreeAndList

#Region "MenuActions"
    Private Sub LibRootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibRootToolStripMenuItem.Click
        '更改書庫目錄（資料夾）
        Dim fbd As New FolderBrowserDialog
        fbd.ShowNewFolderButton = True

        If Directory.Exists(LibView.StartDirectory) Then
            fbd.RootFolder = LibView.StartDirectory
        End If

        If fbd.ShowDialog = DialogResult.OK Then
            LibView.StartDirectory = fbd.SelectedPath
            LibView.ExceptNames.Add("LibDB")
            My.Settings.HDLibPath = fbd.SelectedPath
            LibView.RefreshTree()
        End If
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

#End Region 'PrivateMethods



#Region "TempArea"

    Private Sub LibSearchTextBox_GotFocus(sender As Object, e As EventArgs) Handles LibSearchTextBox.GotFocus
        LibSearchTextBox.AutoCompleteCustomSource.Clear()
        LibSearchTextBox.AutoCompleteCustomSource = GetAllNodeText(LibView.Nodes(0))
    End Sub

    Private Sub LibSearchAdvanceButton_Click(sender As Object, e As EventArgs) Handles LibSearchAdvanceButton.Click
        Dim hdls As New HDLibSearch
        If hdls.ShowDialog() = DialogResult.OK Then

        End If
    End Sub


#End Region 'TempArea

End Class