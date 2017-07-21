Public Class KzColorListView
    Private Sub KzColorListView_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 0 To 10
            Dim cs As New KzColorSticker(Color.OrangeRed)
            cs.Height = 45
            cs.Dock = DockStyle.Top
            ' cs.Width = ColorsPanel.ClientRectangle.Width
            RootSpliter.Panel2.AutoScroll = True
            RootSpliter.Panel2.Controls.Add(cs)
        Next
    End Sub
End Class
