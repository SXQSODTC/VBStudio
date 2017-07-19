<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzAppearancePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzAppearancePanel))
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BorderSizeLB = New System.Windows.Forms.Label()
        Me.BorderColorLB = New System.Windows.Forms.Label()
        Me.FontStyleLB = New System.Windows.Forms.Label()
        Me.FontSizeLB = New System.Windows.Forms.Label()
        Me.ShadowColorLB = New System.Windows.Forms.Label()
        Me.ShadowDirectionLB = New System.Windows.Forms.Label()
        Me.ForeColorLB = New System.Windows.Forms.Label()
        Me.LineSizeLB = New System.Windows.Forms.Label()
        Me.BackColorLB = New System.Windows.Forms.Label()
        Me.BorderSizeUD = New System.Windows.Forms.NumericUpDown()
        Me.BorderColorTB = New System.Windows.Forms.TextBox()
        Me.BackColorTB = New System.Windows.Forms.TextBox()
        Me.LineSizeUD = New System.Windows.Forms.NumericUpDown()
        Me.ForeColorTB = New System.Windows.Forms.TextBox()
        Me.ShadowDirectionCB = New System.Windows.Forms.ComboBox()
        Me.ShadowColorTB = New System.Windows.Forms.TextBox()
        Me.FontSizeCB = New System.Windows.Forms.ComboBox()
        Me.FontStyleCB = New System.Windows.Forms.ComboBox()
        Me.BorderRadiusLB = New System.Windows.Forms.Label()
        Me.BorderRadiusUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowWidthLB = New System.Windows.Forms.Label()
        Me.ShadowWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.NameLB = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.RootTools = New System.Windows.Forms.ToolStrip()
        Me.ResetButton = New System.Windows.Forms.ToolStripButton()
        Me.BraceButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyButton = New System.Windows.Forms.ToolStripButton()
        Me.CodeButton = New System.Windows.Forms.ToolStripButton()
        Me.RootPanel.SuspendLayout()
        CType(Me.BorderSizeUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineSizeUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRadiusUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.Controls.Add(Me.BorderSizeLB, 0, 1)
        Me.RootPanel.Controls.Add(Me.BorderColorLB, 0, 2)
        Me.RootPanel.Controls.Add(Me.FontStyleLB, 0, 11)
        Me.RootPanel.Controls.Add(Me.FontSizeLB, 0, 10)
        Me.RootPanel.Controls.Add(Me.ShadowColorLB, 0, 9)
        Me.RootPanel.Controls.Add(Me.ShadowDirectionLB, 0, 8)
        Me.RootPanel.Controls.Add(Me.ForeColorLB, 0, 6)
        Me.RootPanel.Controls.Add(Me.LineSizeLB, 0, 5)
        Me.RootPanel.Controls.Add(Me.BackColorLB, 0, 4)
        Me.RootPanel.Controls.Add(Me.BorderSizeUD, 1, 1)
        Me.RootPanel.Controls.Add(Me.BorderColorTB, 1, 2)
        Me.RootPanel.Controls.Add(Me.BackColorTB, 1, 4)
        Me.RootPanel.Controls.Add(Me.LineSizeUD, 1, 5)
        Me.RootPanel.Controls.Add(Me.ForeColorTB, 1, 6)
        Me.RootPanel.Controls.Add(Me.ShadowDirectionCB, 1, 8)
        Me.RootPanel.Controls.Add(Me.ShadowColorTB, 1, 9)
        Me.RootPanel.Controls.Add(Me.FontSizeCB, 1, 10)
        Me.RootPanel.Controls.Add(Me.FontStyleCB, 1, 11)
        Me.RootPanel.Controls.Add(Me.BorderRadiusLB, 0, 3)
        Me.RootPanel.Controls.Add(Me.BorderRadiusUD, 1, 3)
        Me.RootPanel.Controls.Add(Me.ShadowWidthLB, 0, 7)
        Me.RootPanel.Controls.Add(Me.ShadowWidthUD, 1, 7)
        Me.RootPanel.Controls.Add(Me.NameLB, 0, 0)
        Me.RootPanel.Controls.Add(Me.NameTB, 1, 0)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.RootPanel.Location = New System.Drawing.Point(0, 25)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 13
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.Size = New System.Drawing.Size(293, 312)
        Me.RootPanel.TabIndex = 0
        '
        'BorderSizeLB
        '
        Me.BorderSizeLB.AutoSize = True
        Me.BorderSizeLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderSizeLB.Location = New System.Drawing.Point(3, 25)
        Me.BorderSizeLB.Name = "BorderSizeLB"
        Me.BorderSizeLB.Size = New System.Drawing.Size(114, 25)
        Me.BorderSizeLB.TabIndex = 1
        Me.BorderSizeLB.Text = "BorderSize"
        Me.BorderSizeLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BorderColorLB
        '
        Me.BorderColorLB.AutoSize = True
        Me.BorderColorLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorLB.Location = New System.Drawing.Point(3, 50)
        Me.BorderColorLB.Name = "BorderColorLB"
        Me.BorderColorLB.Size = New System.Drawing.Size(114, 25)
        Me.BorderColorLB.TabIndex = 2
        Me.BorderColorLB.Text = "BorderColor"
        Me.BorderColorLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FontStyleLB
        '
        Me.FontStyleLB.AutoSize = True
        Me.FontStyleLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyleLB.Location = New System.Drawing.Point(3, 275)
        Me.FontStyleLB.Name = "FontStyleLB"
        Me.FontStyleLB.Size = New System.Drawing.Size(114, 25)
        Me.FontStyleLB.TabIndex = 9
        Me.FontStyleLB.Text = "FontStyle"
        Me.FontStyleLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FontSizeLB
        '
        Me.FontSizeLB.AutoSize = True
        Me.FontSizeLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontSizeLB.Location = New System.Drawing.Point(3, 250)
        Me.FontSizeLB.Name = "FontSizeLB"
        Me.FontSizeLB.Size = New System.Drawing.Size(114, 25)
        Me.FontSizeLB.TabIndex = 8
        Me.FontSizeLB.Text = "FontSize"
        Me.FontSizeLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowColorLB
        '
        Me.ShadowColorLB.AutoSize = True
        Me.ShadowColorLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorLB.Location = New System.Drawing.Point(3, 225)
        Me.ShadowColorLB.Name = "ShadowColorLB"
        Me.ShadowColorLB.Size = New System.Drawing.Size(114, 25)
        Me.ShadowColorLB.TabIndex = 7
        Me.ShadowColorLB.Text = "ShadowColor"
        Me.ShadowColorLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowDirectionLB
        '
        Me.ShadowDirectionLB.AutoSize = True
        Me.ShadowDirectionLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowDirectionLB.Location = New System.Drawing.Point(3, 200)
        Me.ShadowDirectionLB.Name = "ShadowDirectionLB"
        Me.ShadowDirectionLB.Size = New System.Drawing.Size(114, 25)
        Me.ShadowDirectionLB.TabIndex = 6
        Me.ShadowDirectionLB.Text = "ShadowDirection"
        Me.ShadowDirectionLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ForeColorLB
        '
        Me.ForeColorLB.AutoSize = True
        Me.ForeColorLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorLB.Location = New System.Drawing.Point(3, 150)
        Me.ForeColorLB.Name = "ForeColorLB"
        Me.ForeColorLB.Size = New System.Drawing.Size(114, 25)
        Me.ForeColorLB.TabIndex = 5
        Me.ForeColorLB.Text = "ForeColor"
        Me.ForeColorLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LineSizeLB
        '
        Me.LineSizeLB.AutoSize = True
        Me.LineSizeLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineSizeLB.Location = New System.Drawing.Point(3, 125)
        Me.LineSizeLB.Name = "LineSizeLB"
        Me.LineSizeLB.Size = New System.Drawing.Size(114, 25)
        Me.LineSizeLB.TabIndex = 4
        Me.LineSizeLB.Text = "LineSize"
        Me.LineSizeLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BackColorLB
        '
        Me.BackColorLB.AutoSize = True
        Me.BackColorLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorLB.Location = New System.Drawing.Point(3, 100)
        Me.BackColorLB.Name = "BackColorLB"
        Me.BackColorLB.Size = New System.Drawing.Size(114, 25)
        Me.BackColorLB.TabIndex = 3
        Me.BackColorLB.Text = "BackColor"
        Me.BackColorLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BorderSizeUD
        '
        Me.BorderSizeUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderSizeUD.Location = New System.Drawing.Point(121, 26)
        Me.BorderSizeUD.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderSizeUD.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.BorderSizeUD.Name = "BorderSizeUD"
        Me.BorderSizeUD.Size = New System.Drawing.Size(84, 23)
        Me.BorderSizeUD.TabIndex = 10
        Me.BorderSizeUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BorderColorTB
        '
        Me.RootPanel.SetColumnSpan(Me.BorderColorTB, 2)
        Me.BorderColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorTB.Location = New System.Drawing.Point(121, 51)
        Me.BorderColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderColorTB.Name = "BorderColorTB"
        Me.BorderColorTB.Size = New System.Drawing.Size(171, 23)
        Me.BorderColorTB.TabIndex = 11
        '
        'BackColorTB
        '
        Me.RootPanel.SetColumnSpan(Me.BackColorTB, 2)
        Me.BackColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorTB.Location = New System.Drawing.Point(121, 101)
        Me.BackColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.BackColorTB.Name = "BackColorTB"
        Me.BackColorTB.Size = New System.Drawing.Size(171, 23)
        Me.BackColorTB.TabIndex = 12
        '
        'LineSizeUD
        '
        Me.LineSizeUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineSizeUD.Location = New System.Drawing.Point(121, 126)
        Me.LineSizeUD.Margin = New System.Windows.Forms.Padding(1)
        Me.LineSizeUD.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.LineSizeUD.Name = "LineSizeUD"
        Me.LineSizeUD.Size = New System.Drawing.Size(84, 23)
        Me.LineSizeUD.TabIndex = 13
        Me.LineSizeUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForeColorTB
        '
        Me.RootPanel.SetColumnSpan(Me.ForeColorTB, 2)
        Me.ForeColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorTB.Location = New System.Drawing.Point(121, 151)
        Me.ForeColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeColorTB.Name = "ForeColorTB"
        Me.ForeColorTB.Size = New System.Drawing.Size(171, 23)
        Me.ForeColorTB.TabIndex = 14
        '
        'ShadowDirectionCB
        '
        Me.RootPanel.SetColumnSpan(Me.ShadowDirectionCB, 2)
        Me.ShadowDirectionCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowDirectionCB.FormattingEnabled = True
        Me.ShadowDirectionCB.Location = New System.Drawing.Point(121, 201)
        Me.ShadowDirectionCB.Margin = New System.Windows.Forms.Padding(1)
        Me.ShadowDirectionCB.Name = "ShadowDirectionCB"
        Me.ShadowDirectionCB.Size = New System.Drawing.Size(171, 25)
        Me.ShadowDirectionCB.TabIndex = 15
        '
        'ShadowColorTB
        '
        Me.RootPanel.SetColumnSpan(Me.ShadowColorTB, 2)
        Me.ShadowColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorTB.Location = New System.Drawing.Point(121, 226)
        Me.ShadowColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.ShadowColorTB.Name = "ShadowColorTB"
        Me.ShadowColorTB.Size = New System.Drawing.Size(171, 23)
        Me.ShadowColorTB.TabIndex = 16
        '
        'FontSizeCB
        '
        Me.FontSizeCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontSizeCB.FormattingEnabled = True
        Me.FontSizeCB.Location = New System.Drawing.Point(121, 251)
        Me.FontSizeCB.Margin = New System.Windows.Forms.Padding(1)
        Me.FontSizeCB.Name = "FontSizeCB"
        Me.FontSizeCB.Size = New System.Drawing.Size(84, 25)
        Me.FontSizeCB.TabIndex = 17
        '
        'FontStyleCB
        '
        Me.RootPanel.SetColumnSpan(Me.FontStyleCB, 2)
        Me.FontStyleCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyleCB.FormattingEnabled = True
        Me.FontStyleCB.Location = New System.Drawing.Point(121, 276)
        Me.FontStyleCB.Margin = New System.Windows.Forms.Padding(1)
        Me.FontStyleCB.Name = "FontStyleCB"
        Me.FontStyleCB.Size = New System.Drawing.Size(171, 25)
        Me.FontStyleCB.TabIndex = 18
        '
        'BorderRadiusLB
        '
        Me.BorderRadiusLB.AutoSize = True
        Me.BorderRadiusLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderRadiusLB.Location = New System.Drawing.Point(3, 75)
        Me.BorderRadiusLB.Name = "BorderRadiusLB"
        Me.BorderRadiusLB.Size = New System.Drawing.Size(114, 25)
        Me.BorderRadiusLB.TabIndex = 20
        Me.BorderRadiusLB.Text = "BorderRadius"
        Me.BorderRadiusLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BorderRadiusUD
        '
        Me.BorderRadiusUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderRadiusUD.Location = New System.Drawing.Point(121, 76)
        Me.BorderRadiusUD.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderRadiusUD.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.BorderRadiusUD.Name = "BorderRadiusUD"
        Me.BorderRadiusUD.Size = New System.Drawing.Size(84, 23)
        Me.BorderRadiusUD.TabIndex = 21
        Me.BorderRadiusUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShadowWidthLB
        '
        Me.ShadowWidthLB.AutoSize = True
        Me.ShadowWidthLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowWidthLB.Location = New System.Drawing.Point(3, 175)
        Me.ShadowWidthLB.Name = "ShadowWidthLB"
        Me.ShadowWidthLB.Size = New System.Drawing.Size(114, 25)
        Me.ShadowWidthLB.TabIndex = 22
        Me.ShadowWidthLB.Text = "ShadowWidth"
        Me.ShadowWidthLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowWidthUD
        '
        Me.ShadowWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowWidthUD.Location = New System.Drawing.Point(121, 176)
        Me.ShadowWidthUD.Margin = New System.Windows.Forms.Padding(1)
        Me.ShadowWidthUD.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.ShadowWidthUD.Name = "ShadowWidthUD"
        Me.ShadowWidthUD.Size = New System.Drawing.Size(84, 23)
        Me.ShadowWidthUD.TabIndex = 23
        Me.ShadowWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NameLB
        '
        Me.NameLB.AutoSize = True
        Me.NameLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameLB.Location = New System.Drawing.Point(3, 0)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(114, 25)
        Me.NameLB.TabIndex = 24
        Me.NameLB.Text = "Name"
        Me.NameLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTB
        '
        Me.RootPanel.SetColumnSpan(Me.NameTB, 2)
        Me.NameTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTB.Location = New System.Drawing.Point(121, 1)
        Me.NameTB.Margin = New System.Windows.Forms.Padding(1)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(171, 23)
        Me.NameTB.TabIndex = 25
        '
        'RootTools
        '
        Me.RootTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RootTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetButton, Me.BraceButton, Me.CopyButton, Me.CodeButton})
        Me.RootTools.Location = New System.Drawing.Point(0, 0)
        Me.RootTools.Name = "RootTools"
        Me.RootTools.Size = New System.Drawing.Size(293, 25)
        Me.RootTools.TabIndex = 3
        Me.RootTools.Text = "ToolStrip1"
        '
        'ResetButton
        '
        Me.ResetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetButton.Image = CType(resources.GetObject("ResetButton.Image"), System.Drawing.Image)
        Me.ResetButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(44, 22)
        Me.ResetButton.Text = "Reset"
        '
        'BraceButton
        '
        Me.BraceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BraceButton.Image = CType(resources.GetObject("BraceButton.Image"), System.Drawing.Image)
        Me.BraceButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BraceButton.Name = "BraceButton"
        Me.BraceButton.Size = New System.Drawing.Size(38, 22)
        Me.BraceButton.Text = "With"
        '
        'CopyButton
        '
        Me.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CopyButton.Image = CType(resources.GetObject("CopyButton.Image"), System.Drawing.Image)
        Me.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(42, 22)
        Me.CopyButton.Text = "Copy"
        '
        'CodeButton
        '
        Me.CodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CodeButton.Image = CType(resources.GetObject("CodeButton.Image"), System.Drawing.Image)
        Me.CodeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CodeButton.Name = "CodeButton"
        Me.CodeButton.Size = New System.Drawing.Size(43, 22)
        Me.CodeButton.Text = "Code"
        '
        'KzAppearancePanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.RootPanel)
        Me.Controls.Add(Me.RootTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Name = "KzAppearancePanel"
        Me.Size = New System.Drawing.Size(293, 337)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.BorderSizeUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineSizeUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRadiusUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootTools.ResumeLayout(False)
        Me.RootTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents BorderSizeLB As Label
    Friend WithEvents BorderColorLB As Label
    Friend WithEvents FontStyleLB As Label
    Friend WithEvents FontSizeLB As Label
    Friend WithEvents ShadowColorLB As Label
    Friend WithEvents ShadowDirectionLB As Label
    Friend WithEvents ForeColorLB As Label
    Friend WithEvents LineSizeLB As Label
    Friend WithEvents BackColorLB As Label
    Friend WithEvents BorderSizeUD As NumericUpDown
    Friend WithEvents BorderColorTB As TextBox
    Friend WithEvents BackColorTB As TextBox
    Friend WithEvents LineSizeUD As NumericUpDown
    Friend WithEvents ForeColorTB As TextBox
    Friend WithEvents ShadowDirectionCB As ComboBox
    Friend WithEvents ShadowColorTB As TextBox
    Friend WithEvents FontSizeCB As ComboBox
    Friend WithEvents FontStyleCB As ComboBox
    Friend WithEvents BorderRadiusLB As Label
    Friend WithEvents BorderRadiusUD As NumericUpDown
    Friend WithEvents ShadowWidthLB As Label
    Friend WithEvents ShadowWidthUD As NumericUpDown
    Friend WithEvents NameLB As Label
    Friend WithEvents NameTB As TextBox
    Friend WithEvents RootTools As ToolStrip
    Friend WithEvents ResetButton As ToolStripButton
    Friend WithEvents BraceButton As ToolStripButton
    Friend WithEvents CopyButton As ToolStripButton
    Friend WithEvents CodeButton As ToolStripButton
End Class
