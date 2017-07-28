Public Class KzTabsDesigner

    Private iA As KzTabsAppearance
    Private iSwitchs As ToolStripButton() = {
        TabSW, TabHoverSW, SelectedTabSW, SelectedTabHoverSW,
        ButtonSW, ButtonHoverSW, SelectedButtonSW, SelectedButtonHoverSW,
        AddTabSW, AddTabHoverSW}
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

        TabSW.Checked = True

        MyAppearance = New KzTabsAppearance

    End Sub

    Public Property MyAppearance As KzTabsAppearance
        Get
            Return iA
        End Get
        Set(value As KzTabsAppearance)
            If Not iA.Equals(value) Then
                iA = value
                SetUI(iSwitchs(0))

                Dim e As New ToolStripItemClickedEventArgs(SwitchTools.Items(0))
                SwitchStatus(SwitchTools, e)
            End If
        End Set
    End Property

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

            Dim i As Integer = iSwitchs.ToList.IndexOf(typeButton)
            With .Elements(i)
                BorderCK.Checked = .ShowBorder
                BlodBorderCK.Checked = .BlodBorder
                ShadowCK.Checked = .ShowShadow
                RadiusCK.Checked = .ShowRadius
                ShadowSideCB.SelectedItem = .ShadowSide
                RadiusSideCB.SelectedItem = .RadiusSide
                BlodForeCK.Checked = .BlodFore
                BorderColorTB.Text = KzColorHelper.GetColorName(.BorderColor)
                BackColorTB.Text = KzColorHelper.GetColorName(.BackColor)
                ForeColorTB.Text = KzColorHelper.GetColorName(.ForeColor)
            End With
        End With
    End Sub

    Private Sub SwitchStatus(sender As Object, e As ToolStripItemClickedEventArgs) _
        Handles SwitchTools.ItemClicked

        Dim b As ToolStripButton = CType(e.ClickedItem, ToolStripButton)

        For Each item As ToolStripButton In SwitchTools.Controls
            If Not item.Equals(b) Then
                item.Checked = False
            End If
        Next

        b.Checked = True
        iButton = b

        SetUI(b, True)
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
            Dim i As Integer = iSwitchs.ToList.IndexOf(iButton)
            With iA.Elements(i)
                If cb.Equals(ShadowSideCB) Then
                    .ShadowSide = cb.SelectedItem
                ElseIf cb.Equals(RadiusSideCB) Then
                    .RadiusSide = cb.SelectedItem
                End If
            End With
        End If
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
            Dim i As Integer = iSwitchs.ToList.IndexOf(iButton)
            With iA.Elements(i)
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
    End Sub

    Private Sub TB_TextChanged(sender As Object, e As EventArgs) _
        Handles BorderColorTB.TextChanged, BackColorTB.TextChanged, ForeColorTB.TextChanged

        Dim tb As TextBox = CType(sender, TextBox)
        Dim i As Integer = iSwitchs.ToList.IndexOf(iButton)
        With iA.Elements(i)
            If tb.Equals(BorderColorTB) Then
                .BorderColor = KzColorHelper.GetColorByName(tb.Text)
            ElseIf tb.Equals(BackColorTB) Then
                .BackColor = KzColorHelper.GetColorByName(tb.Text)
            ElseIf tb.Equals(ForeColorTB) Then
                .ForeColor = KzColorHelper.GetColorByName(tb.Text)
            End If
        End With

    End Sub
End Class