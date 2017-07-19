Public Class TestColorListForm
    Private Sub TestColorListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cs As KzColorSticker
        'cs = New KzColorSticker(Color.Orange)
        'cs.Size = New Size(200, 45)
        'cs.Dock = DockStyle.Top
        'Me.RootSpliter.Panel1.Controls.Add(cs)

        'cs = New KzColorSticker(Color.Bisque)
        'cs.Size = New Size(200, 45)
        'cs.Dock = DockStyle.Top
        'Me.RootSpliter.Panel1.Controls.Add(cs)

        Dim ub As Integer = [Enum].GetNames(GetType(KzActionStatus)).Count - 1
        With AppearanceTabs
            .TabPages.Clear()
            For i As Integer = 0 To ub
                Dim tp As New TabPage([Enum].GetNames(GetType(KzActionStatus))(i))
                Dim kap As New KzAppearancePanel With {
                    .Dock = DockStyle.Fill}
                tp.Controls.Add(kap)
                .TabPages.Add(tp)
            Next
        End With
    End Sub
End Class