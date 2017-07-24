Public Class TestListForm
    Dim WithEvents clv As KzColorListPanel
    Dim WithEvents slb As KzTrackBar

    Private Sub TestListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clv = New KzColorListPanel
        clv.DefaultColorListType = KzColorListType.KnownColors
        clv.Dock = DockStyle.Fill
        RootSpliter.Panel1.Controls.Add(clv)
        'InfoChanges(Nothing, Nothing)

        slb = New KzTrackBar
        slb.Height = 25
        slb.Dock = DockStyle.Top
        RootSpliter.Panel2.Controls.Add(slb)
    End Sub

    Private Sub InfoChanges(sender As Object, e As EventArgs) _
        Handles clv.CheckedStickersChanged, clv.SelectedStickerChanged, clv.StickersChanged

        InfoLabel.Text = "Selected: " & If(clv.SelectedSticker Is Nothing, "-", clv.SelectedSticker.Name) & vbCrLf &
                           "Checked Items: " & clv.CheckedStickers.Count
        Try
            InfoLabel.Text = InfoLabel.Text & vbCrLf &
                           "Total Items: " & clv.Stickers.Count '.Controls.Count
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ControlsChanged(sender As Object, e As ControlEventArgs) Handles clv.ControlAdded, clv.ControlRemoved
        InfoLabel.Text = "Selected: " & If(clv.SelectedSticker Is Nothing, "-", clv.SelectedSticker.Name) & vbCrLf &
                           "Checked Items: " & clv.CheckedStickers.Count
        Try
            InfoLabel.Text = InfoLabel.Text & vbCrLf &
                           "Total Items: " & clv.Stickers.Count '.Controls.Count
        Catch ex As Exception

        End Try
    End Sub
End Class