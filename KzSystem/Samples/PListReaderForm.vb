Public Class PListReaderForm

    Dim plist As PList

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "plist files (*.plist)|*.plist|all files (*.*)|*.*"

        If ofd.ShowDialog = DialogResult.OK Then
            FileNameLabel.Text = ofd.FileName

            plist = New PList(ofd.FileName)

            Dim item As ListViewItem
            Dim subitems As ListViewItem.ListViewSubItem()

            For i As Integer = 0 To plist.Count - 1
                item = New ListViewItem()
                subitems = {
                    New ListViewItem.ListViewSubItem(item, plist.Keys(i).ToString),
                    New ListViewItem.ListViewSubItem(item, plist.Values(i).ToString)}
                item.SubItems.AddRange(subitems)
            Next
        End If

    End Sub
End Class