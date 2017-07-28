<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KzTabsDesigner
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzTabsDesigner))
        Dim KzTabsAppearance1 As KzSystem.KzTabsAppearance = New KzSystem.KzTabsAppearance()
        Me.RootTools = New System.Windows.Forms.ToolStrip()
        Me.ImportItem = New System.Windows.Forms.ToolStripButton()
        Me.RootStatus = New System.Windows.Forms.StatusStrip()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.LeftSpliter = New System.Windows.Forms.SplitContainer()
        Me.TAPPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AppearanceCB = New System.Windows.Forms.ComboBox()
        Me.AlignmentCB = New System.Windows.Forms.ComboBox()
        Me.TabPageStyleCB = New System.Windows.Forms.ComboBox()
        Me.ShowAddCK = New System.Windows.Forms.CheckBox()
        Me.SelectedCloseCK = New System.Windows.Forms.CheckBox()
        Me.NormalCloseCK = New System.Windows.Forms.CheckBox()
        Me.TSAPPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ShadowSideCB = New System.Windows.Forms.ComboBox()
        Me.RadiusSideCB = New System.Windows.Forms.ComboBox()
        Me.BorderCK = New System.Windows.Forms.CheckBox()
        Me.BlodBorderCK = New System.Windows.Forms.CheckBox()
        Me.ShadowCK = New System.Windows.Forms.CheckBox()
        Me.RadiusCK = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BlodForeCK = New System.Windows.Forms.CheckBox()
        Me.BorderColorTB = New System.Windows.Forms.TextBox()
        Me.BackColorTB = New System.Windows.Forms.TextBox()
        Me.ForeColorTB = New System.Windows.Forms.TextBox()
        Me.SwitchTools = New System.Windows.Forms.ToolStrip()
        Me.TabSW = New System.Windows.Forms.ToolStripButton()
        Me.TabHoverSW = New System.Windows.Forms.ToolStripButton()
        Me.SelectedTabSW = New System.Windows.Forms.ToolStripButton()
        Me.SelectedTabHoverSW = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSW = New System.Windows.Forms.ToolStripButton()
        Me.ButtonHoverSW = New System.Windows.Forms.ToolStripButton()
        Me.SelectedButtonSW = New System.Windows.Forms.ToolStripButton()
        Me.SelectedButtonHoverSW = New System.Windows.Forms.ToolStripButton()
        Me.AddTabSW = New System.Windows.Forms.ToolStripButton()
        Me.AddTabHoverSW = New System.Windows.Forms.ToolStripButton()
        Me.TheKzTabControl = New KzSystem.KzTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RootTools.SuspendLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.LeftSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeftSpliter.Panel1.SuspendLayout()
        Me.LeftSpliter.Panel2.SuspendLayout()
        Me.LeftSpliter.SuspendLayout()
        Me.TAPPanel.SuspendLayout()
        Me.TSAPPanel.SuspendLayout()
        Me.SwitchTools.SuspendLayout()
        Me.TheKzTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootTools
        '
        Me.RootTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportItem})
        Me.RootTools.Location = New System.Drawing.Point(0, 0)
        Me.RootTools.Name = "RootTools"
        Me.RootTools.Size = New System.Drawing.Size(656, 25)
        Me.RootTools.TabIndex = 0
        Me.RootTools.Text = "ToolStrip1"
        '
        'ImportItem
        '
        Me.ImportItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportItem.Image = CType(resources.GetObject("ImportItem.Image"), System.Drawing.Image)
        Me.ImportItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportItem.Name = "ImportItem"
        Me.ImportItem.Size = New System.Drawing.Size(23, 22)
        Me.ImportItem.Text = "ToolStripButton1"
        '
        'RootStatus
        '
        Me.RootStatus.Location = New System.Drawing.Point(0, 434)
        Me.RootStatus.Name = "RootStatus"
        Me.RootStatus.Size = New System.Drawing.Size(656, 22)
        Me.RootStatus.TabIndex = 1
        Me.RootStatus.Text = "StatusStrip1"
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 25)
        Me.RootSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.LeftSpliter)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.TheKzTabControl)
        Me.RootSpliter.Size = New System.Drawing.Size(656, 409)
        Me.RootSpliter.SplitterDistance = 297
        Me.RootSpliter.SplitterWidth = 5
        Me.RootSpliter.TabIndex = 2
        '
        'LeftSpliter
        '
        Me.LeftSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.LeftSpliter.Location = New System.Drawing.Point(0, 0)
        Me.LeftSpliter.Name = "LeftSpliter"
        Me.LeftSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'LeftSpliter.Panel1
        '
        Me.LeftSpliter.Panel1.AutoScroll = True
        Me.LeftSpliter.Panel1.Controls.Add(Me.TAPPanel)
        '
        'LeftSpliter.Panel2
        '
        Me.LeftSpliter.Panel2.AutoScroll = True
        Me.LeftSpliter.Panel2.Controls.Add(Me.TSAPPanel)
        Me.LeftSpliter.Panel2.Controls.Add(Me.SwitchTools)
        Me.LeftSpliter.Size = New System.Drawing.Size(297, 409)
        Me.LeftSpliter.SplitterDistance = 159
        Me.LeftSpliter.TabIndex = 0
        '
        'TAPPanel
        '
        Me.TAPPanel.ColumnCount = 4
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.Controls.Add(Me.Label1, 0, 0)
        Me.TAPPanel.Controls.Add(Me.Label2, 0, 1)
        Me.TAPPanel.Controls.Add(Me.Label3, 0, 2)
        Me.TAPPanel.Controls.Add(Me.AppearanceCB, 1, 0)
        Me.TAPPanel.Controls.Add(Me.AlignmentCB, 1, 1)
        Me.TAPPanel.Controls.Add(Me.TabPageStyleCB, 1, 2)
        Me.TAPPanel.Controls.Add(Me.ShowAddCK, 0, 3)
        Me.TAPPanel.Controls.Add(Me.SelectedCloseCK, 0, 4)
        Me.TAPPanel.Controls.Add(Me.NormalCloseCK, 0, 5)
        Me.TAPPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TAPPanel.Location = New System.Drawing.Point(0, 0)
        Me.TAPPanel.Name = "TAPPanel"
        Me.TAPPanel.RowCount = 7
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TAPPanel.Size = New System.Drawing.Size(297, 153)
        Me.TAPPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Appearance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alignment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TabPageStyle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AppearanceCB
        '
        Me.TAPPanel.SetColumnSpan(Me.AppearanceCB, 2)
        Me.AppearanceCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppearanceCB.FormattingEnabled = True
        Me.AppearanceCB.Location = New System.Drawing.Point(100, 0)
        Me.AppearanceCB.Margin = New System.Windows.Forms.Padding(0)
        Me.AppearanceCB.Name = "AppearanceCB"
        Me.AppearanceCB.Size = New System.Drawing.Size(171, 25)
        Me.AppearanceCB.TabIndex = 6
        '
        'AlignmentCB
        '
        Me.TAPPanel.SetColumnSpan(Me.AlignmentCB, 2)
        Me.AlignmentCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlignmentCB.FormattingEnabled = True
        Me.AlignmentCB.Location = New System.Drawing.Point(100, 25)
        Me.AlignmentCB.Margin = New System.Windows.Forms.Padding(0)
        Me.AlignmentCB.Name = "AlignmentCB"
        Me.AlignmentCB.Size = New System.Drawing.Size(171, 25)
        Me.AlignmentCB.TabIndex = 7
        '
        'TabPageStyleCB
        '
        Me.TAPPanel.SetColumnSpan(Me.TabPageStyleCB, 2)
        Me.TabPageStyleCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPageStyleCB.FormattingEnabled = True
        Me.TabPageStyleCB.Location = New System.Drawing.Point(100, 50)
        Me.TabPageStyleCB.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageStyleCB.Name = "TabPageStyleCB"
        Me.TabPageStyleCB.Size = New System.Drawing.Size(171, 25)
        Me.TabPageStyleCB.TabIndex = 8
        '
        'ShowAddCK
        '
        Me.ShowAddCK.AutoSize = True
        Me.ShowAddCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TAPPanel.SetColumnSpan(Me.ShowAddCK, 2)
        Me.ShowAddCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowAddCK.Location = New System.Drawing.Point(70, 78)
        Me.ShowAddCK.Name = "ShowAddCK"
        Me.ShowAddCK.Size = New System.Drawing.Size(130, 19)
        Me.ShowAddCK.TabIndex = 9
        Me.ShowAddCK.Text = "ShowAddNewTab"
        Me.ShowAddCK.UseVisualStyleBackColor = True
        '
        'SelectedCloseCK
        '
        Me.SelectedCloseCK.AutoSize = True
        Me.SelectedCloseCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TAPPanel.SetColumnSpan(Me.SelectedCloseCK, 2)
        Me.SelectedCloseCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.SelectedCloseCK.Location = New System.Drawing.Point(48, 103)
        Me.SelectedCloseCK.Name = "SelectedCloseCK"
        Me.SelectedCloseCK.Size = New System.Drawing.Size(152, 19)
        Me.SelectedCloseCK.TabIndex = 10
        Me.SelectedCloseCK.Text = "SelectedTabCanClose"
        Me.SelectedCloseCK.UseVisualStyleBackColor = True
        '
        'NormalCloseCK
        '
        Me.NormalCloseCK.AutoSize = True
        Me.NormalCloseCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TAPPanel.SetColumnSpan(Me.NormalCloseCK, 2)
        Me.NormalCloseCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.NormalCloseCK.Location = New System.Drawing.Point(53, 128)
        Me.NormalCloseCK.Name = "NormalCloseCK"
        Me.NormalCloseCK.Size = New System.Drawing.Size(147, 19)
        Me.NormalCloseCK.TabIndex = 11
        Me.NormalCloseCK.Text = "NormalTabCanClose"
        Me.NormalCloseCK.UseVisualStyleBackColor = True
        '
        'TSAPPanel
        '
        Me.TSAPPanel.ColumnCount = 4
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TSAPPanel.Controls.Add(Me.ShadowSideCB, 1, 3)
        Me.TSAPPanel.Controls.Add(Me.RadiusSideCB, 1, 5)
        Me.TSAPPanel.Controls.Add(Me.BorderCK, 0, 0)
        Me.TSAPPanel.Controls.Add(Me.BlodBorderCK, 0, 1)
        Me.TSAPPanel.Controls.Add(Me.ShadowCK, 0, 2)
        Me.TSAPPanel.Controls.Add(Me.RadiusCK, 0, 4)
        Me.TSAPPanel.Controls.Add(Me.Label4, 0, 3)
        Me.TSAPPanel.Controls.Add(Me.Label5, 0, 5)
        Me.TSAPPanel.Controls.Add(Me.Label6, 0, 6)
        Me.TSAPPanel.Controls.Add(Me.Label7, 0, 7)
        Me.TSAPPanel.Controls.Add(Me.Label8, 0, 8)
        Me.TSAPPanel.Controls.Add(Me.BlodForeCK, 0, 9)
        Me.TSAPPanel.Controls.Add(Me.BorderColorTB, 1, 6)
        Me.TSAPPanel.Controls.Add(Me.BackColorTB, 1, 7)
        Me.TSAPPanel.Controls.Add(Me.ForeColorTB, 1, 8)
        Me.TSAPPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TSAPPanel.Location = New System.Drawing.Point(0, 25)
        Me.TSAPPanel.Name = "TSAPPanel"
        Me.TSAPPanel.RowCount = 11
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TSAPPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TSAPPanel.Size = New System.Drawing.Size(280, 259)
        Me.TSAPPanel.TabIndex = 1
        '
        'ShadowSideCB
        '
        Me.TSAPPanel.SetColumnSpan(Me.ShadowSideCB, 2)
        Me.ShadowSideCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowSideCB.FormattingEnabled = True
        Me.ShadowSideCB.Location = New System.Drawing.Point(100, 75)
        Me.ShadowSideCB.Margin = New System.Windows.Forms.Padding(0)
        Me.ShadowSideCB.Name = "ShadowSideCB"
        Me.ShadowSideCB.Size = New System.Drawing.Size(160, 25)
        Me.ShadowSideCB.TabIndex = 8
        '
        'RadiusSideCB
        '
        Me.TSAPPanel.SetColumnSpan(Me.RadiusSideCB, 2)
        Me.RadiusSideCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadiusSideCB.FormattingEnabled = True
        Me.RadiusSideCB.Location = New System.Drawing.Point(100, 125)
        Me.RadiusSideCB.Margin = New System.Windows.Forms.Padding(0)
        Me.RadiusSideCB.Name = "RadiusSideCB"
        Me.RadiusSideCB.Size = New System.Drawing.Size(160, 25)
        Me.RadiusSideCB.TabIndex = 9
        '
        'BorderCK
        '
        Me.BorderCK.AutoSize = True
        Me.BorderCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSAPPanel.SetColumnSpan(Me.BorderCK, 2)
        Me.BorderCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderCK.Location = New System.Drawing.Point(46, 3)
        Me.BorderCK.Name = "BorderCK"
        Me.BorderCK.Size = New System.Drawing.Size(99, 19)
        Me.BorderCK.TabIndex = 0
        Me.BorderCK.Text = "ShowBorder"
        Me.BorderCK.UseVisualStyleBackColor = True
        '
        'BlodBorderCK
        '
        Me.BlodBorderCK.AutoSize = True
        Me.BlodBorderCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSAPPanel.SetColumnSpan(Me.BlodBorderCK, 2)
        Me.BlodBorderCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.BlodBorderCK.Location = New System.Drawing.Point(50, 28)
        Me.BlodBorderCK.Name = "BlodBorderCK"
        Me.BlodBorderCK.Size = New System.Drawing.Size(95, 19)
        Me.BlodBorderCK.TabIndex = 1
        Me.BlodBorderCK.Text = "BlodBorder"
        Me.BlodBorderCK.UseVisualStyleBackColor = True
        '
        'ShadowCK
        '
        Me.ShadowCK.AutoSize = True
        Me.ShadowCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSAPPanel.SetColumnSpan(Me.ShadowCK, 2)
        Me.ShadowCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShadowCK.Location = New System.Drawing.Point(41, 53)
        Me.ShadowCK.Name = "ShadowCK"
        Me.ShadowCK.Size = New System.Drawing.Size(104, 19)
        Me.ShadowCK.TabIndex = 2
        Me.ShadowCK.Text = "ShowShadow"
        Me.ShadowCK.UseVisualStyleBackColor = True
        '
        'RadiusCK
        '
        Me.RadiusCK.AutoSize = True
        Me.RadiusCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSAPPanel.SetColumnSpan(Me.RadiusCK, 2)
        Me.RadiusCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadiusCK.Location = New System.Drawing.Point(48, 103)
        Me.RadiusCK.Name = "RadiusCK"
        Me.RadiusCK.Size = New System.Drawing.Size(97, 19)
        Me.RadiusCK.TabIndex = 3
        Me.RadiusCK.Text = "ShowRadius"
        Me.RadiusCK.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ShadowSide"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "RadiusSide"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "BorderColor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "BackColor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ForeColor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BlodForeCK
        '
        Me.BlodForeCK.AutoSize = True
        Me.BlodForeCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSAPPanel.SetColumnSpan(Me.BlodForeCK, 2)
        Me.BlodForeCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.BlodForeCK.Location = New System.Drawing.Point(65, 228)
        Me.BlodForeCK.Name = "BlodForeCK"
        Me.BlodForeCK.Size = New System.Drawing.Size(80, 19)
        Me.BlodForeCK.TabIndex = 15
        Me.BlodForeCK.Text = "BlodFore"
        Me.BlodForeCK.UseVisualStyleBackColor = True
        '
        'BorderColorTB
        '
        Me.TSAPPanel.SetColumnSpan(Me.BorderColorTB, 2)
        Me.BorderColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorTB.Location = New System.Drawing.Point(101, 151)
        Me.BorderColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderColorTB.Name = "BorderColorTB"
        Me.BorderColorTB.Size = New System.Drawing.Size(158, 23)
        Me.BorderColorTB.TabIndex = 16
        '
        'BackColorTB
        '
        Me.TSAPPanel.SetColumnSpan(Me.BackColorTB, 2)
        Me.BackColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorTB.Location = New System.Drawing.Point(101, 176)
        Me.BackColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.BackColorTB.Name = "BackColorTB"
        Me.BackColorTB.Size = New System.Drawing.Size(158, 23)
        Me.BackColorTB.TabIndex = 17
        '
        'ForeColorTB
        '
        Me.TSAPPanel.SetColumnSpan(Me.ForeColorTB, 2)
        Me.ForeColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorTB.Location = New System.Drawing.Point(101, 201)
        Me.ForeColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeColorTB.Name = "ForeColorTB"
        Me.ForeColorTB.Size = New System.Drawing.Size(158, 23)
        Me.ForeColorTB.TabIndex = 18
        '
        'SwitchTools
        '
        Me.SwitchTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabSW, Me.TabHoverSW, Me.SelectedTabSW, Me.SelectedTabHoverSW, Me.ButtonSW, Me.ButtonHoverSW, Me.SelectedButtonSW, Me.SelectedButtonHoverSW, Me.AddTabSW, Me.AddTabHoverSW})
        Me.SwitchTools.Location = New System.Drawing.Point(0, 0)
        Me.SwitchTools.Name = "SwitchTools"
        Me.SwitchTools.Size = New System.Drawing.Size(280, 25)
        Me.SwitchTools.TabIndex = 0
        Me.SwitchTools.Text = "ToolStrip1"
        '
        'TabSW
        '
        Me.TabSW.CheckOnClick = True
        Me.TabSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TabSW.Image = CType(resources.GetObject("TabSW.Image"), System.Drawing.Image)
        Me.TabSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TabSW.Name = "TabSW"
        Me.TabSW.Size = New System.Drawing.Size(23, 22)
        Me.TabSW.Text = "ToolStripButton1"
        '
        'TabHoverSW
        '
        Me.TabHoverSW.CheckOnClick = True
        Me.TabHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TabHoverSW.Image = CType(resources.GetObject("TabHoverSW.Image"), System.Drawing.Image)
        Me.TabHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TabHoverSW.Name = "TabHoverSW"
        Me.TabHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.TabHoverSW.Text = "ToolStripButton2"
        '
        'SelectedTabSW
        '
        Me.SelectedTabSW.CheckOnClick = True
        Me.SelectedTabSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedTabSW.Image = CType(resources.GetObject("SelectedTabSW.Image"), System.Drawing.Image)
        Me.SelectedTabSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedTabSW.Name = "SelectedTabSW"
        Me.SelectedTabSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedTabSW.Text = "ToolStripButton3"
        '
        'SelectedTabHoverSW
        '
        Me.SelectedTabHoverSW.CheckOnClick = True
        Me.SelectedTabHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedTabHoverSW.Image = CType(resources.GetObject("SelectedTabHoverSW.Image"), System.Drawing.Image)
        Me.SelectedTabHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedTabHoverSW.Name = "SelectedTabHoverSW"
        Me.SelectedTabHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedTabHoverSW.Text = "ToolStripButton4"
        '
        'ButtonSW
        '
        Me.ButtonSW.CheckOnClick = True
        Me.ButtonSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSW.Image = CType(resources.GetObject("ButtonSW.Image"), System.Drawing.Image)
        Me.ButtonSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSW.Name = "ButtonSW"
        Me.ButtonSW.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSW.Text = "ToolStripButton5"
        '
        'ButtonHoverSW
        '
        Me.ButtonHoverSW.CheckOnClick = True
        Me.ButtonHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonHoverSW.Image = CType(resources.GetObject("ButtonHoverSW.Image"), System.Drawing.Image)
        Me.ButtonHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonHoverSW.Name = "ButtonHoverSW"
        Me.ButtonHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.ButtonHoverSW.Text = "ToolStripButton6"
        '
        'SelectedButtonSW
        '
        Me.SelectedButtonSW.CheckOnClick = True
        Me.SelectedButtonSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedButtonSW.Image = CType(resources.GetObject("SelectedButtonSW.Image"), System.Drawing.Image)
        Me.SelectedButtonSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedButtonSW.Name = "SelectedButtonSW"
        Me.SelectedButtonSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedButtonSW.Text = "ToolStripButton7"
        '
        'SelectedButtonHoverSW
        '
        Me.SelectedButtonHoverSW.CheckOnClick = True
        Me.SelectedButtonHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedButtonHoverSW.Image = CType(resources.GetObject("SelectedButtonHoverSW.Image"), System.Drawing.Image)
        Me.SelectedButtonHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedButtonHoverSW.Name = "SelectedButtonHoverSW"
        Me.SelectedButtonHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedButtonHoverSW.Text = "ToolStripButton8"
        '
        'AddTabSW
        '
        Me.AddTabSW.CheckOnClick = True
        Me.AddTabSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddTabSW.Image = CType(resources.GetObject("AddTabSW.Image"), System.Drawing.Image)
        Me.AddTabSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTabSW.Name = "AddTabSW"
        Me.AddTabSW.Size = New System.Drawing.Size(23, 22)
        Me.AddTabSW.Text = "ToolStripButton9"
        '
        'AddTabHoverSW
        '
        Me.AddTabHoverSW.CheckOnClick = True
        Me.AddTabHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddTabHoverSW.Image = CType(resources.GetObject("AddTabHoverSW.Image"), System.Drawing.Image)
        Me.AddTabHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTabHoverSW.Name = "AddTabHoverSW"
        Me.AddTabHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.AddTabHoverSW.Text = "ToolStripButton10"
        '
        'TheKzTabControl
        '
        Me.TheKzTabControl.Controls.Add(Me.TabPage1)
        Me.TheKzTabControl.Controls.Add(Me.TabPage2)
        Me.TheKzTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheKzTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TheKzTabControl.Location = New System.Drawing.Point(0, 0)
        Me.TheKzTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TheKzTabControl.Multiline = True
        Me.TheKzTabControl.Name = "TheKzTabControl"
        Me.TheKzTabControl.NewAddedAutoSelect = True
        Me.TheKzTabControl.NewTitlePrefix = "NewTab"
        Me.TheKzTabControl.SelectedIndex = 0
        Me.TheKzTabControl.Size = New System.Drawing.Size(354, 409)
        Me.TheKzTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TheKzTabControl.TabIndex = 2
        KzTabsAppearance1.AddTab = Nothing
        KzTabsAppearance1.AddTabHover = Nothing
        KzTabsAppearance1.Alignment = System.Windows.Forms.TabAlignment.Top
        KzTabsAppearance1.Appearance = System.Windows.Forms.TabAppearance.Normal
        KzTabsAppearance1.Button = Nothing
        KzTabsAppearance1.ButtonHover = Nothing
        KzTabsAppearance1.NormalTabCanClose = False
        KzTabsAppearance1.SelectedButton = Nothing
        KzTabsAppearance1.SelectedButtonHover = Nothing
        KzTabsAppearance1.SelectedTab = Nothing
        KzTabsAppearance1.SelectedTabCanClose = False
        KzTabsAppearance1.SelectedTabHover = Nothing
        KzTabsAppearance1.ShowAddNewTab = False
        KzTabsAppearance1.Tab = Nothing
        KzTabsAppearance1.TabHover = Nothing
        KzTabsAppearance1.TabPageStyle = KzSystem.KzTabPageStyle.None
        Me.TheKzTabControl.TabsAppearance = KzTabsAppearance1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(346, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(346, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'KzTabsDesigner
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(656, 456)
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootStatus)
        Me.Controls.Add(Me.RootTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "KzTabsDesigner"
        Me.Text = "KzTabsDesigner"
        Me.RootTools.ResumeLayout(False)
        Me.RootTools.PerformLayout()
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.LeftSpliter.Panel1.ResumeLayout(False)
        Me.LeftSpliter.Panel2.ResumeLayout(False)
        Me.LeftSpliter.Panel2.PerformLayout()
        CType(Me.LeftSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeftSpliter.ResumeLayout(False)
        Me.TAPPanel.ResumeLayout(False)
        Me.TAPPanel.PerformLayout()
        Me.TSAPPanel.ResumeLayout(False)
        Me.TSAPPanel.PerformLayout()
        Me.SwitchTools.ResumeLayout(False)
        Me.SwitchTools.PerformLayout()
        Me.TheKzTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootTools As ToolStrip
    Friend WithEvents RootStatus As StatusStrip
    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents TheKzTabControl As KzTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImportItem As ToolStripButton
    Friend WithEvents LeftSpliter As SplitContainer
    Friend WithEvents TAPPanel As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AppearanceCB As ComboBox
    Friend WithEvents AlignmentCB As ComboBox
    Friend WithEvents TabPageStyleCB As ComboBox
    Friend WithEvents ShowAddCK As CheckBox
    Friend WithEvents SelectedCloseCK As CheckBox
    Friend WithEvents NormalCloseCK As CheckBox
    Friend WithEvents TSAPPanel As TableLayoutPanel
    Friend WithEvents SwitchTools As ToolStrip
    Friend WithEvents BorderCK As CheckBox
    Friend WithEvents BlodBorderCK As CheckBox
    Friend WithEvents ShadowCK As CheckBox
    Friend WithEvents RadiusCK As CheckBox
    Friend WithEvents ShadowSideCB As ComboBox
    Friend WithEvents RadiusSideCB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BlodForeCK As CheckBox
    Friend WithEvents BorderColorTB As TextBox
    Friend WithEvents BackColorTB As TextBox
    Friend WithEvents ForeColorTB As TextBox
    Friend WithEvents TabSW As ToolStripButton
    Friend WithEvents TabHoverSW As ToolStripButton
    Friend WithEvents SelectedTabSW As ToolStripButton
    Friend WithEvents SelectedTabHoverSW As ToolStripButton
    Friend WithEvents ButtonSW As ToolStripButton
    Friend WithEvents ButtonHoverSW As ToolStripButton
    Friend WithEvents SelectedButtonSW As ToolStripButton
    Friend WithEvents SelectedButtonHoverSW As ToolStripButton
    Friend WithEvents AddTabSW As ToolStripButton
    Friend WithEvents AddTabHoverSW As ToolStripButton
End Class
