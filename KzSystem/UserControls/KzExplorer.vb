Public Class KzExplorer
    Private Sub KzExplorer_Load(sender As Object, e As EventArgs) Handles Me.Load
        DirViewer.StartDirectory = "E:\HDLib"
        DirViewer.RefreshTree()
    End Sub
End Class
