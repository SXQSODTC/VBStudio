Public Class TestListForm
    Dim clv As New KzColorListView

    Private Sub TestListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clv.Dock = DockStyle.Fill
        Me.Controls.Add(clv)
    End Sub
End Class