Public Class KzTabsDesigner

    Private iA As KzTabsAppearance ' = New KzTabsAppearance
    Private iButton As ToolStripButton

    Private Sub KzTabsDesigner_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i, ub As Integer

        With AlignmentCB
            ub = [Enum].GetNames(GetType(TabAlignment)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, TabAlignment))
            Next
        End With

        With AppearanceCB
            ub = [Enum].GetNames(GetType(TabAppearance)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, TabAppearance))
            Next
        End With

        With TabPageStyleCB
            ub = [Enum].GetNames(GetType(KzTabPageStyle)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzTabPageStyle))
            Next
        End With

        With ShadowSideCB
            ub = [Enum].GetNames(GetType(KzFlatSides)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzFlatSides))
            Next
        End With

        With RadiusSideCB
            ub = [Enum].GetNames(GetType(KzFlatCorners)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzFlatCorners))
            Next
        End With

        For Each b As ToolStripButton In SwitchTools.Controls
            b.Text = b.Name.Replace("SW", " Appearance")
            b.ToolTipText = b.Text
        Next
        TabSW.Checked = True

        MyAppearance = New KzTabsAppearance
        ANameBox.Text = "NewLook"

        TheTabControl.TabsAppearance = iA
    End Sub

    Public Property MyAppearance As KzTabsAppearance
        Get
            Return iA
        End Get
        Set(value As KzTabsAppearance)
            iA = value
            SetButtons(iA)

            iButton = CType(SwitchTools.Items(0), ToolStripButton)
            SetUI(iButton)
            IDLabel.Text = iButton.Text
            If iButton.Tag IsNot Nothing Then
                CKLabel.Text = "Ready"
            Else
                CKLabel.Text = "Empty"
            End If
        End Set
    End Property

    Private Sub SetButtons(theAppearance As KzTabsAppearance)
        With theAppearance
            TabSW.Tag = .Tab
            TabHoverSW.Tag = .TabHover
            SelectedTabSW.Tag = .SelectedTab
            SelectedTabHoverSW.Tag = .SelectedTabHover
            ButtonSW.Tag = .Button
            ButtonHoverSW.Tag = .ButtonHover
            SelectedButtonSW.Tag = .SelectedButton
            SelectedButtonHoverSW.Tag = .SelectedButtonHover
            AddTabSW.Tag = .AddTab
            AddTabHoverSW.Tag = .AddTabHover
        End With
    End Sub

    Private Sub SetUI(typeButton As ToolStripButton, Optional setStatusOnly As Boolean = False)
        With iA
            If Not setStatusOnly Then
                AppearanceCB.SelectedItem = .Appearance
                AlignmentCB.SelectedItem = .Alignment
                TabPageStyleCB.SelectedItem = .TabPageStyle
                ShowAddCK.Checked = .ShowAddNewTab
                SelectedCloseCK.Checked = .SelectedTabCanClose
                NormalCloseCK.Checked = .NormalTabCanClose
            End If

            With CType(typeButton.Tag, KzTabStatusAppearance)
                BorderCK.Checked = .ShowBorder
                BlodBorderCK.Checked = .BlodBorder
                ShadowCK.Checked = .ShowShadow
                RadiusCK.Checked = .ShowRadius
                ShadowSideCB.SelectedItem = .ShadowSide
                RadiusSideCB.SelectedItem = .RadiusSide
                BlodForeCK.Checked = .BlodFore
                BorderColorTB.Text = KzColorHelper.GetColorName(.BorderColor)
                BorderColorButton.BackColor = .BorderColor
                BackColorTB.Text = KzColorHelper.GetColorName(.BackColor)
                BackColorButton.BackColor = .BackColor
                ForeColorTB.Text = KzColorHelper.GetColorName(.ForeColor)
                ForeColorButton.BackColor = .ForeColor
            End With
        End With
    End Sub

    Private Sub CB_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles AppearanceCB.SelectedIndexChanged, AlignmentCB.SelectedIndexChanged,
        TabPageStyleCB.SelectedIndexChanged, ShadowSideCB.SelectedIndexChanged,
        RadiusSideCB.SelectedIndexChanged

        Dim cb As ComboBox = CType(sender, ComboBox)
        If cb.Equals(AppearanceCB) Then
            iA.Appearance = cb.SelectedItem
        ElseIf cb.Equals(AlignmentCB) Then
            iA.Alignment = cb.SelectedItem
        ElseIf cb.Equals(TabPageStyleCB) Then
            iA.TabPageStyle = cb.SelectedItem
        Else
            With CType(iButton.Tag, KzTabStatusAppearance)
                If cb.Equals(ShadowSideCB) Then
                    .ShadowSide = cb.SelectedItem
                ElseIf cb.Equals(RadiusSideCB) Then
                    .RadiusSide = cb.SelectedItem
                End If
            End With
        End If

        TheTabControl.TabsAppearance = iA
    End Sub

    Private Sub CK_CheckedChanged(sender As Object, e As EventArgs) _
        Handles ShowAddCK.CheckedChanged, SelectedCloseCK.CheckedChanged,
        NormalCloseCK.CheckedChanged, BorderCK.CheckedChanged, BlodBorderCK.CheckedChanged,
        BlodForeCK.CheckedChanged, RadiusCK.CheckedChanged, ShadowCK.CheckedChanged

        Dim ck As CheckBox = CType(sender, CheckBox)
        If ck.Equals(ShowAddCK) Then
            iA.ShowAddNewTab = ck.Checked
        ElseIf ck.Equals(SelectedCloseCK) Then
            iA.SelectedTabCanClose = ck.Checked
        ElseIf ck.Equals(NormalCloseCK) Then
            iA.NormalTabCanClose = ck.Checked
        Else
            With CType(iButton.Tag, KzTabStatusAppearance)
                If ck.Equals(BorderCK) Then
                    .ShowBorder = ck.Checked
                ElseIf ck.Equals(BlodBorderCK) Then
                    .BlodBorder = ck.Checked
                ElseIf ck.Equals(BlodForeCK) Then
                    .BlodFore = ck.Checked
                ElseIf ck.Equals(RadiusCK) Then
                    .ShowRadius = ck.Checked
                ElseIf ck.Equals(ShadowCK) Then
                    .ShowShadow = ck.Checked
                End If
            End With
        End If

        TheTabControl.TabsAppearance = iA
    End Sub

    'Private Sub TB_TextChanged(sender As Object, e As EventArgs) _
    '    Handles BorderColorTB.TextChanged, BackColorTB.TextChanged, ForeColorTB.TextChanged

    '    Dim tb As TextBox = CType(sender, TextBox)
    '    With CType(iButton.Tag, KzTabStatusAppearance)
    '        If tb.Equals(BorderColorTB) Then
    '            .BorderColor = KzColorHelper.GetColorByName(tb.Text)
    '        ElseIf tb.Equals(BackColorTB) Then
    '            .BackColor = KzColorHelper.GetColorByName(tb.Text)
    '        ElseIf tb.Equals(ForeColorTB) Then
    '            .ForeColor = KzColorHelper.GetColorByName(tb.Text)
    '        End If
    '    End With

    'End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) _
        Handles BorderColorButton.Click, BackColorButton.Click, ForeColorButton.Click

        Dim cb As Button = CType(sender, Button)
        Dim c As Color
        Dim t As String

        With ColorPicker
            c = .Color
            t = KzColorHelper.GetColorName(.Color) '& " (" & .Color.A & "," & .Color.R & "," & .Color.G & "," & .Color.B & ")"
        End With

        If cb.Equals(BorderColorButton) Then
            BorderColorButton.BackColor = c
            BorderColorTB.Text = t
        End If
        If cb.Equals(BackColorButton) Then
            BackColorButton.BackColor = c
            BackColorTB.Text = t
        End If
        If cb.Equals(ForeColorButton) Then
            ForeColorButton.BackColor = c
            ForeColorTB.Text = t
        End If

    End Sub

    Private Sub ColorButton_BackColorChanged(sender As Object, e As EventArgs) _
        Handles BorderColorButton.BackColorChanged, BackColorButton.BackColorChanged, ForeColorButton.BackColorChanged

        Dim bt As Button = CType(sender, Button)

        Try
            With CType(iButton.Tag, KzTabStatusAppearance)
                If bt.Equals(BorderColorButton) Then
                    .BorderColor = BorderColorButton.BackColor
                ElseIf bt.Equals(BackColorButton) Then
                    .BackColor = BackColorButton.BackColor
                ElseIf bt.Equals(ForeColorButton) Then
                    .ForeColor = ForeColorButton.BackColor
                End If
            End With

            TheTabControl.TabsAppearance = iA
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SwitchTools_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles SwitchTools.ItemClicked
        iButton = CType(e.ClickedItem, ToolStripButton)

        For Each b As ToolStripButton In SwitchTools.Items
            If Not b.Equals(iButton) Then
                b.Checked = False
            End If
        Next

        SetUI(iButton, True)
        IDLabel.Text = iButton.Text
        If iButton.Tag IsNot Nothing Then
            CKLabel.Text = "Ready"
        Else
            CKLabel.Text = "Empty"
        End If
    End Sub

    'Private Sub ShowCodeButton_Click(sender As Object, e As EventArgs) Handles ShowSingleCodeButton.Click
    '    Dim tvd As New KzTextViewDialog
    '    tvd.TextContents = CType(iButton.Tag, KzTabStatusAppearance).GetCode(ANameBox.Text & iButton.Text)
    '    tvd.ShowDialog()
    'End Sub

    Private Sub ShowCodeItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ShowCodeItem.DropDownItemClicked
        Dim tvd As New KzTextViewDialog
        If e.ClickedItem.Equals(FullCodeToolStripMenuItem) Then
            Dim sb As New System.Text.StringBuilder

            For Each b As ToolStripButton In SwitchTools.Items
                sb.Append(CType(b.Tag, KzTabStatusAppearance).GetCode(ANameBox.Text & b.Text))
                sb.AppendLine()
            Next

            sb.Append(iA.GetCode(ANameBox.Text))

            tvd.TextContents = sb.ToString
        ElseIf e.ClickedItem.Equals(TabsCodeToolStripMenuItem) Then
            tvd.TextContents = iA.GetCode(ANameBox.Text)
        ElseIf e.ClickedItem.Equals(StatusCodeToolStripMenuItem) Then
            tvd.TextContents = CType(iButton.Tag, KzTabStatusAppearance).GetCode(ANameBox.Text & iButton.Text)
        End If

        tvd.ShowDialog()
    End Sub
End Class