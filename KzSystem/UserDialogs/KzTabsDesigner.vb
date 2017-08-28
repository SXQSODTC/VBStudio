'Imports System.ComponentModel

Public Class KzTabsDesigner
    Friend WithEvents NormalLineLP As KzLinePresentation
    Friend WithEvents BoldLineLP As KzLinePresentation
    Friend WithEvents RadiusLP As KzLinePresentation
    'Friend WithEvents TheTabs As KzTabControl

    Private iA As KzTabsAppearance
    Private iB As ToolStripButton

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        InitializeKzComponent()
    End Sub

    Private Sub InitializeKzComponent()
        Me.SettingPanel.SuspendLayout()
        Me.TheTabs.SuspendLayout()
        Me.SuspendLayout()

        RadiusLP = New KzLinePresentation With {.Dock = DockStyle.Fill, .SidePadding = 4, .ShowCorner = True}
        SettingPanel.Controls.Add(RadiusLP, 2, 13)
        SettingPanel.SetColumnSpan(RadiusLP, 2)

        NormalLineLP = New KzLinePresentation With {.Dock = DockStyle.Fill, .SidePadding = 4}
        SettingPanel.Controls.Add(NormalLineLP, 2, 14)
        SettingPanel.SetColumnSpan(NormalLineLP, 2)

        BoldLineLP = New KzLinePresentation With {.Dock = DockStyle.Fill, .SidePadding = 4}
        SettingPanel.Controls.Add(BoldLineLP, 2, 15)
        SettingPanel.SetColumnSpan(BoldLineLP, 2)

        Dim i, ub As Integer

        With AlignmentCB
            ub = [Enum].GetNames(GetType(TabAlignment)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, TabAlignment))
            Next
            .SelectedItem = TheTabs.Alignment ' TabAlignment.Top
        End With

        With AppearanceCB
            ub = [Enum].GetNames(GetType(TabAppearance)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, TabAppearance))
            Next
            .SelectedItem = TheTabs.Appearance ' TabAppearance.Normal
        End With

        ShowAddCK.Checked = TheTabs.ShowAddNewTab

        With TabPageStyleCB
            ub = [Enum].GetNames(GetType(KzTabPageStyle)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzTabPageStyle))
            Next
            '.SelectedItem = KzTabPageStyle.None
        End With

        With ShadowSideCB
            ub = [Enum].GetNames(GetType(KzFlatSides)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzFlatSides))
            Next
            '.SelectedItem = KzFlatSides.None
        End With

        With RadiusSideCB
            ub = [Enum].GetNames(GetType(KzFlatCorners)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzFlatCorners))
            Next
            '.SelectedItem = KzFlatCorners.None
        End With

        For Each b As ToolStripButton In SwitchTools.Controls
            b.Text = b.Name.Replace("SW", " Appearance")
        Next

        For i = 0 To 9
            SwitchTools.Items(i).Image = My.Resources.ResourceManager.GetObject("Number_" & i)
        Next
        TabSW.Checked = True

        ImportItem.Image = My.Resources.liner_import
        ExportItem.Image = My.Resources.liner_export
        PreviewButton.Image = My.Resources.liner_view
        PresetItem.Image = My.Resources.liner_setting
        ShowCodeItem.Image = My.Resources.liner_code

        MyAppearance = New KzTabsAppearance
        ANameBox.Text = "NewLook"

        TheTabs.TabsAppearance = iA
        TheTabs.SignLabel = HoveringItem

        Me.SettingPanel.ResumeLayout(False)
        Me.SettingPanel.PerformLayout()
        Me.TheTabs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Public Property MyAppearance As KzTabsAppearance
        Get
            Return iA
        End Get
        Set(value As KzTabsAppearance)
            iA = value
            SetButtons(iA)

            iB = CType(SwitchTools.Items(0), ToolStripButton)
            SetUI(iB)
            SwitchLabel.Text = iB.Text
        End Set
    End Property

    Private Sub SetButtons(theAppearance As KzTabsAppearance)
        With theAppearance
            TabSW.Tag = .SetOfNormalTab
            TabHoverSW.Tag = .SetOfNormalTabHover
            SelectedTabSW.Tag = .SetOfSelectedTab
            SelectedTabHoverSW.Tag = .SetOfSelectedTabHover
            ButtonSW.Tag = .SetOfNormalButton
            ButtonHoverSW.Tag = .SetOfNormalButtonHover
            SelectedButtonSW.Tag = .SetOfSelectedButton
            SelectedButtonHoverSW.Tag = .SetOfSelectedButtonHover
            AddTabSW.Tag = .SetOfAddNewTab
            AddTabHoverSW.Tag = .SetOfAddNewTabHover
        End With

        SentToMenu.Items.Clear()
        Dim stmi As ToolStripMenuItem
        For i As Integer = 0 To SwitchTools.Items.Count - 1
            With SwitchTools.Items(i)
                stmi = New ToolStripMenuItem
                stmi.Text = "Sent to " & .Text
                stmi.Image = .Image
                stmi.Tag = Tag
                If i = 0 Then
                    stmi.Enabled = False
                End If
            End With
            SentToMenu.Items.Add(stmi)
        Next
        SentToMenu.Items.Add(New ToolStripSeparator)

        stmi = New ToolStripMenuItem
        stmi.Text = "Sent to All"
        SentToMenu.Items.Add(stmi)
    End Sub

    Private Sub SetUI(TheButton As ToolStripButton, Optional StatusOnly As Boolean = False)
        With iA
            If Not StatusOnly Then
                TabPageStyleCB.SelectedItem = .TabPageStyle
                AutoWidthCK.Checked = .TabsAutoWidth
                ButtonMarginSetter.Value = .ButtonMargin
                TextMarginSetter.Value = .TextMargin
                ShowIconCK.Checked = .ShowIcon
                SelectedCloseCK.Checked = .SelectedTabCanClose
                NormalCloseCK.Checked = .NormalTabCanClose
                RadiusCK.Checked = .ShowRadius
                RadiusSideCB.SelectedItem = .RadiusSide
                RadiusUD.Value = .Radius
                NormalLineUD.Value = .NormalLine
                BoldLineUD.Value = .BoldLine
            End If

            With CType(TheButton.Tag, KzTabStatusAppearance)
                BorderCK.Checked = .ShowBorder
                BoldBorderCK.Checked = .BoldBorder
                ShadowCK.Checked = .ShowShadow
                ShadowSideCB.SelectedItem = .ShadowSide
                ShadowColorTB.Text = KzColorHelper.GetColorName(.ShadowColor)
                ShadowColorButton.BackColor = .ShadowColor
                BorderColorTB.Text = KzColorHelper.GetColorName(.BorderColor)
                BorderColorButton.BackColor = .BorderColor
                BackColorTB.Text = KzColorHelper.GetColorName(.BackColor)
                BackColorButton.BackColor = .BackColor
                ForeColorTB.Text = KzColorHelper.GetColorName(.ForeColor)
                ForeColorButton.BackColor = .ForeColor
                BoldForeCK.Checked = .BoldFore
            End With
        End With
    End Sub

    Private Sub CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
            AppearanceCB.SelectedIndexChanged, AlignmentCB.SelectedIndexChanged,
            TabPageStyleCB.SelectedIndexChanged, ShadowSideCB.SelectedIndexChanged,
            RadiusSideCB.SelectedIndexChanged

        Dim cb As ComboBox = CType(sender, ComboBox)

        If cb.Equals(AppearanceCB) Then
            TheTabs.Appearance = cb.SelectedItem
        ElseIf cb.Equals(AlignmentCB) Then
            TheTabs.Alignment = cb.SelectedItem
        ElseIf cb.Equals(TabPageStyleCB) Then
            iA.TabPageStyle = cb.SelectedItem
        ElseIf cb.Equals(RadiusSideCB) Then
            iA.RadiusSide = cb.SelectedItem
        Else
            With CType(iB.Tag, KzTabStatusAppearance)
                If cb.Equals(ShadowSideCB) Then
                    .ShadowSide = cb.SelectedItem
                End If
            End With
        End If

        TheTabs.TabsAppearance = iA
    End Sub

    Private Sub CK_CheckedChanged(sender As Object, e As EventArgs) Handles _
        ShowAddCK.CheckedChanged, SelectedCloseCK.CheckedChanged, ShowIconCK.CheckedChanged,
        NormalCloseCK.CheckedChanged, RadiusCK.CheckedChanged, BorderCK.CheckedChanged,
        BoldBorderCK.CheckedChanged, BoldForeCK.CheckedChanged, ShadowCK.CheckedChanged,
        AutoWidthCK.CheckedChanged

        Dim ck As CheckBox = CType(sender, CheckBox)

        If ck.Equals(ShowAddCK) Then
            TheTabs.ShowAddNewTab = ck.Checked
        ElseIf ck.Equals(AutoWidthCK) Then
            iA.TabsAutoWidth = ck.Checked
        ElseIf ck.Equals(SelectedCloseCK) Then
            iA.SelectedTabCanClose = ck.Checked
        ElseIf ck.Equals(NormalCloseCK) Then
            iA.NormalTabCanClose = ck.Checked
        ElseIf ck.Equals(ShowIconCK) Then
            iA.ShowIcon = ck.Checked
        ElseIf ck.Equals(RadiusCK) Then
            iA.ShowRadius = ck.Checked
        Else
            With CType(iB.Tag, KzTabStatusAppearance)
                If ck.Equals(BorderCK) Then
                    .ShowBorder = ck.Checked
                ElseIf ck.Equals(BoldBorderCK) Then
                    .BoldBorder = ck.Checked
                ElseIf ck.Equals(BoldForeCK) Then
                    .BoldFore = ck.Checked
                ElseIf ck.Equals(ShadowCK) Then
                    .ShowShadow = ck.Checked
                End If
            End With
        End If

        TheTabs.TabsAppearance = iA
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles _
         BorderColorButton.Click, BackColorButton.Click,
         ForeColorButton.Click, ShadowColorButton.Click

        If Not ColorPicker.Color = Color.FromArgb(&HFFFFFF) Then
            Dim cb As Button = CType(sender, Button)
            Dim t As String

            With ColorPicker
                cb.BackColor = .Color
                t = KzColorHelper.GetColorName(.Color)
            End With

            If cb.Equals(BorderColorButton) Then
                BorderColorTB.Text = t
            ElseIf cb.Equals(BackColorButton) Then
                BackColorTB.Text = t
            ElseIf cb.Equals(ForeColorButton) Then
                ForeColorTB.Text = t
            ElseIf cb.Equals(ShadowColorButton) Then
                ShadowColorTB.Text = t
            End If
        End If
    End Sub

    Private Sub ColorButton_BackColorChanged(sender As Object, e As EventArgs) Handles _
         BorderColorButton.BackColorChanged, BackColorButton.BackColorChanged,
         ForeColorButton.BackColorChanged, ShadowColorButton.BackColorChanged

        Dim bt As Button = CType(sender, Button)

        Try
            With CType(iB.Tag, KzTabStatusAppearance)
                If bt.Equals(BorderColorButton) Then
                    .BorderColor = bt.BackColor
                ElseIf bt.Equals(BackColorButton) Then
                    .BackColor = bt.BackColor
                ElseIf bt.Equals(ForeColorButton) Then
                    .ForeColor = bt.BackColor
                ElseIf bt.Equals(ShadowColorButton) Then
                    .ShadowColor = bt.BackColor
                End If
            End With

            TheTabs.TabsAppearance = iA
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UD_ValueChanged(sender As Object, e As EventArgs) Handles _
        RadiusUD.ValueChanged, BoldLineUD.ValueChanged, NormalLineUD.ValueChanged

        Dim ud As NumericUpDown = CType(sender, NumericUpDown)

        If ud.Equals(RadiusUD) Then
            iA.Radius = ud.Value
            RadiusLP.Radius = ud.Value
        ElseIf ud.Equals(BoldLineUD) Then
            iA.BoldLine = ud.Value
            BoldLineLP.LineWidth = ud.Value
        ElseIf ud.Equals(NormalLineUD) Then
            iA.NormalLine = ud.Value
            NormalLineLP.LineWidth = ud.Value
        End If

        TheTabs.TabsAppearance = iA
    End Sub

    Private Sub Setter_ValueChanged(sender As Object, e As EventArgs) Handles _
        TextMarginSetter.ValueChanged, ButtonMarginSetter.ValueChanged

        Dim ms As KzPadingSetter = CType(sender, KzPadingSetter)

        If ms.Equals(TextMarginSetter) Then
            iA.TextMargin = ms.Value
        ElseIf ms.Equals(ButtonMarginSetter) Then
            iA.ButtonMargin = ms.Value
        End If

        TheTabs.TabsAppearance = iA
    End Sub

    Private Sub SwitchTools_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles _
        SwitchTools.ItemClicked

        iB = CType(e.ClickedItem, ToolStripButton)

        For Each b As ToolStripButton In SwitchTools.Items
            If Not b.Equals(iB) Then
                b.Checked = False
            End If
        Next

        SetUI(iB, True)
        SwitchLabel.Text = iB.Text

        For Each i As ToolStripItem In SentToMenu.Items
            If i.Text.Replace("Sent to ", "") = iB.Text Then
                i.Enabled = False
            Else
                i.Enabled = True
            End If
        Next
    End Sub

    Private Sub ShowCodeItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) _
       Handles ShowCodeItem.DropDownItemClicked

        If ANameBox.TextLength > 0 Then
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
                tvd.TextContents = CType(iB.Tag, KzTabStatusAppearance).GetCode(ANameBox.Text & iB.Text)
            End If

            tvd.ShowDialog()
        End If
    End Sub

    Private Sub ANameBox_TextChanged(sender As Object, e As EventArgs) Handles ANameBox.TextChanged
        ParentTB.Text = ANameBox.Text
    End Sub

    Private Sub SentToMenu_ItemClicked(sender As Object,
                    e As ToolStripItemClickedEventArgs) Handles SentToMenu.ItemClicked

        Dim x As KzTabStatusAppearance
        Dim c As Control = SettingPanel.GetChildAtPoint(SentToMenu.Location)

        If e.ClickedItem.Tag Is Nothing Then
            For Each item As ToolStripItem In SentToMenu.Items
                If (Not item.GetType = GetType(ToolStripSeparator)) And
                    (item.Tag IsNot Nothing) And (Not item.Equals(e.ClickedItem)) Then

                    x = CType(item.Tag, KzTabStatusAppearance)

                    If c.Equals(BorderCK) Then
                        x.ShowBorder = BorderCK.Checked
                    ElseIf c.Equals(BoldBorderCK) Then
                        x.BoldBorder = BoldBorderCK.Checked
                    ElseIf c.Equals(ShadowCK) Then
                        x.ShowShadow = ShadowCK.Checked
                    ElseIf c.Equals(ShadowSideCB) Then
                        x.ShadowSide = ShadowSideCB.SelectedItem
                    ElseIf x.Equals(ShadowColorTB) Or x.Equals(ShadowColorButton) Then
                        x.ShadowColor = ShadowColorButton.BackColor
                    ElseIf x.Equals(BorderColorTB) Or x.Equals(BorderColorButton) Then
                        x.BorderColor = BorderColorButton.BackColor
                    ElseIf x.Equals(BackColorTB) Or x.Equals(BackColorButton) Then
                        x.BackColor = BackColorButton.BackColor
                    ElseIf x.Equals(ForeColorTB) Or x.Equals(ForeColorButton) Then
                        x.ForeColor = ForeColorButton.BackColor
                    ElseIf x.Equals(BoldForeCK) Then
                        x.BoldFore = BoldForeCK.Checked
                    End If
                End If
            Next
            MsgBox(c.GetType.ToString & " " & c.Name & "'s value " & vbCrLf & "have been send to all StatusAppearances.")
        Else
            x = CType(e.ClickedItem.Tag, KzTabStatusAppearance)
            If c.Equals(BorderCK) Then
                x.ShowBorder = BorderCK.Checked
            ElseIf c.Equals(BoldBorderCK) Then
                x.BoldBorder = BoldBorderCK.Checked
            ElseIf c.Equals(ShadowCK) Then
                x.ShowShadow = ShadowCK.Checked
            ElseIf c.Equals(ShadowSideCB) Then
                x.ShadowSide = ShadowSideCB.SelectedItem
            ElseIf x.Equals(ShadowColorTB) Or x.Equals(ShadowColorButton) Then
                x.ShadowColor = ShadowColorButton.BackColor
            ElseIf x.Equals(BorderColorTB) Or x.Equals(BorderColorButton) Then
                x.BorderColor = BorderColorButton.BackColor
            ElseIf x.Equals(BackColorTB) Or x.Equals(BackColorButton) Then
                x.BackColor = BackColorButton.BackColor
            ElseIf x.Equals(ForeColorTB) Or x.Equals(ForeColorButton) Then
                x.ForeColor = ForeColorButton.BackColor
            ElseIf x.Equals(BoldForeCK) Then
                x.BoldFore = BoldForeCK.Checked
            End If
            MsgBox(c.GetType.ToString & " " & c.Name & "'s value " & vbCrLf & "have been send to " & e.ClickedItem.Text & ".")
        End If
    End Sub
End Class