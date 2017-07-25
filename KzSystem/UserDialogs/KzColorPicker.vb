Public Class KzColorPicker

    Private iColor As Color = Color.FromArgb(&HFFFFFF)

    Private Sub KzColorPicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetColorToUI()
        TypeLabel.Text = "None"
    End Sub

    Private Sub KzColorPicker_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        Me.SuspendLayout()
    End Sub

    Private Sub KzColorPicker_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.ResumeLayout()
        Me.PerformLayout()
    End Sub



    Public Property Color As Color
        Get
            Return iColor
        End Get
        Set(value As Color)
            iColor = value
            SetColorToUI(iColor)
        End Set
    End Property

    Private Sub SetColorToUI(Optional ByVal theColor As Color = Nothing)
        'HandleChecker.Checked = False

        If theColor.Equals(Nothing) Then
            theColor = iColor
        End If

        With theColor
            ColorShowPanel.BackColor = theColor
            NameTB.Text = KzColorHelper.GetColorName(theColor)

            If NumBT.Text = "HEX" Then
                NumTB.Text = "&H" & Hex(.ToArgb).ToUpper
            Else
                NumTB.Text = .ToArgb
            End If

            RedBar.Value = .R
            GreenBar.Value = .G
            BlueBar.Value = .B
            AlphaBar.Value = .A

            HueTB.Text = .GetHue
            BrightnessTB.Text = .GetBrightness
            SaturationTB.Text = .GetSaturation

            HasCodeLB.Text = "ARGB(" & .A & ", " & .R & ", " & .G & ", " & .B & ")    Ref: " & .GetHashCode

            CodeCombo.Items.Clear()
            CodeCombo.Items.AddRange _
                ({"= Color.FromARGB(" & .A & ", " & .R & ", " & .G & ", " & .B & ")",
                "= Color.FromARGB(" & .ToArgb & ")",
                "= Color.FromARGB(" & "&H" & Hex(.ToArgb).ToUpper & ")"})
            If .IsNamedColor Then CodeCombo.Items.Add("= Color.FromName(""" & .Name & """)")
            If .IsKnownColor Then CodeCombo.Items.Add("= Color.FromKnownColor(Color." & .Name & ")")

            CodeCombo.SelectedIndex = 0
        End With
    End Sub

    Private Sub NumBT_Click(sender As Object, e As EventArgs) Handles NumBT.Click
        With NumBT
            If .Text = "HEX" Then
                .Text = "INT"
                NumTB.Text = iColor.ToArgb
            Else
                .Text = "HEX"
                NumTB.Text = "&H" & Hex(iColor.ToArgb).ToUpper
            End If
        End With

    End Sub

    Private Sub ShowColorsButton_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ShowColorsButton.DropDownItemClicked
        With ColorsPanel
            Me.Cursor = Cursors.WaitCursor

            If e.ClickedItem.Equals(KnownItem) Then
                .DefaultColorListType = KzColorListType.KnownColors

            ElseIf e.ClickedItem.Equals(SystemItem) Then
                .DefaultColorListType = KzColorListType.SystemColors
            ElseIf e.ClickedItem.Equals(WebItem) Then
                .DefaultColorListType = KzColorListType.WebColors
            ElseIf e.ClickedItem.Equals(CheckedItem) Then
                .DefaultColorListType = KzColorListType.CheckedColors
            ElseIf e.ClickedItem.Equals(CustomItem) Then

            ElseIf e.ClickedItem.Equals(ClearListItem) Then
                .DefaultColorListType = KzColorListType.None
            End If

            TypeLabel.Text = e.ClickedItem.Text

            SearchBox.AutoCompleteCustomSource.Clear()
            For Each cs As KzColorSticker In .Stickers
                SearchBox.AutoCompleteCustomSource.Add(cs.Name)
            Next

            Me.Cursor = Cursors.Default
        End With
    End Sub

    'Private iHandleMode As Boolean = False

    Private Sub ColorsPanel_SelectedStickerChanged _
        (sender As Object, e As EventArgs) Handles ColorsPanel.SelectedStickerChanged

        Me.Color = ColorsPanel.SelectedSticker.ColorLabel.BackColor
    End Sub

    Private Sub ColorsPanel_StickersChanged _
        (sender As Object, e As EventArgs) Handles _
        ColorsPanel.StickersChanged, ColorsPanel.CheckedStickersChanged

        ColorsLabel.Text = ColorsPanel.Stickers.Count
        CheckedLabel.Text = ColorsPanel.CheckedStickers.Count
    End Sub

    Private Sub AlphaBar_ValueChanged _
        (sender As Object, e As EventArgs) Handles _
        AlphaBar.ValueChanged, RedBar.ValueChanged, GreenBar.ValueChanged, BlueBar.ValueChanged

        'If iHandleMode Then
        '    SetColorToUI(Color.FromArgb(AlphaBar.Value, RedBar.Value, GreenBar.Value, BlueBar.Value))
        'End If
    End Sub

    Private Sub HandleChecker_CheckedChanged(sender As Object, e As EventArgs) Handles HandleChecker.CheckedChanged

    End Sub
End Class