<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzColorPicker
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
        Me.RootTools = New System.Windows.Forms.ToolStrip()
        Me.ImportButton = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowColorsButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.KnownItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckedItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchButton = New System.Windows.Forms.ToolStripButton()
        Me.Separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.CopyButton = New System.Windows.Forms.ToolStripButton()
        Me.Separator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditListButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCheckedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveCurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RootStatus = New System.Windows.Forms.StatusStrip()
        Me.TypeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ColorsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckedLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.ColorsPanel = New KzSystem.KzColorListPanel()
        Me.ColorPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.HueLB = New System.Windows.Forms.Label()
        Me.SaturationLB = New System.Windows.Forms.Label()
        Me.BrightnessLB = New System.Windows.Forms.Label()
        Me.NameLB = New System.Windows.Forms.Label()
        Me.ColorShowPanel = New System.Windows.Forms.Panel()
        Me.HueTB = New System.Windows.Forms.TextBox()
        Me.SaturationTB = New System.Windows.Forms.TextBox()
        Me.BrightnessTB = New System.Windows.Forms.TextBox()
        Me.RedBar = New KzSystem.KzSlideBar()
        Me.GreenBar = New KzSystem.KzSlideBar()
        Me.BlueBar = New KzSystem.KzSlideBar()
        Me.AlphaBar = New KzSystem.KzSlideBar()
        Me.OkBT = New System.Windows.Forms.Button()
        Me.CancelBT = New System.Windows.Forms.Button()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.NumTB = New System.Windows.Forms.TextBox()
        Me.NumBT = New System.Windows.Forms.Button()
        Me.HasCodeLB = New System.Windows.Forms.Label()
        Me.HandleChecker = New System.Windows.Forms.CheckBox()
        Me.RootTools.SuspendLayout()
        Me.RootStatus.SuspendLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        Me.ColorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootTools
        '
        Me.RootTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportButton, Me.Separator1, Me.ShowColorsButton, Me.Separator7, Me.SearchBox, Me.SearchButton, Me.Separator3, Me.CodeCombo, Me.CopyButton, Me.Separator6, Me.EditListButton, Me.ExportButton})
        Me.RootTools.Location = New System.Drawing.Point(0, 0)
        Me.RootTools.Name = "RootTools"
        Me.RootTools.Size = New System.Drawing.Size(460, 25)
        Me.RootTools.TabIndex = 1
        Me.RootTools.Text = "ToolStrip1"
        '
        'ImportButton
        '
        Me.ImportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportButton.Image = Global.KzSystem.My.Resources.Resources.liner_import
        Me.ImportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(23, 22)
        Me.ImportButton.Text = "IM"
        Me.ImportButton.ToolTipText = "Import from constructed file"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
        '
        'ShowColorsButton
        '
        Me.ShowColorsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowColorsButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KnownItem, Me.SystemItem, Me.WebItem, Me.CustomItem, Me.Separator4, Me.CheckedItem, Me.Separator5, Me.ClearListItem})
        Me.ShowColorsButton.Image = Global.KzSystem.My.Resources.Resources.liner_view
        Me.ShowColorsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowColorsButton.Name = "ShowColorsButton"
        Me.ShowColorsButton.Size = New System.Drawing.Size(29, 22)
        Me.ShowColorsButton.Text = "V"
        Me.ShowColorsButton.ToolTipText = "Show color list"
        '
        'KnownItem
        '
        Me.KnownItem.Name = "KnownItem"
        Me.KnownItem.Size = New System.Drawing.Size(164, 22)
        Me.KnownItem.Text = "KnownColors"
        '
        'SystemItem
        '
        Me.SystemItem.Name = "SystemItem"
        Me.SystemItem.Size = New System.Drawing.Size(164, 22)
        Me.SystemItem.Text = "SystemColors"
        '
        'WebItem
        '
        Me.WebItem.Name = "WebItem"
        Me.WebItem.Size = New System.Drawing.Size(164, 22)
        Me.WebItem.Text = "WebColors"
        '
        'CustomItem
        '
        Me.CustomItem.Name = "CustomItem"
        Me.CustomItem.Size = New System.Drawing.Size(164, 22)
        Me.CustomItem.Text = "CustomColors"
        '
        'Separator4
        '
        Me.Separator4.Name = "Separator4"
        Me.Separator4.Size = New System.Drawing.Size(161, 6)
        '
        'CheckedItem
        '
        Me.CheckedItem.Name = "CheckedItem"
        Me.CheckedItem.Size = New System.Drawing.Size(164, 22)
        Me.CheckedItem.Text = "CheckedColors"
        '
        'Separator5
        '
        Me.Separator5.Name = "Separator5"
        Me.Separator5.Size = New System.Drawing.Size(161, 6)
        '
        'ClearListItem
        '
        Me.ClearListItem.Name = "ClearListItem"
        Me.ClearListItem.Size = New System.Drawing.Size(164, 22)
        Me.ClearListItem.Text = "ClearList"
        '
        'Separator7
        '
        Me.Separator7.Name = "Separator7"
        Me.Separator7.Size = New System.Drawing.Size(6, 25)
        '
        'SearchBox
        '
        Me.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(100, 25)
        '
        'SearchButton
        '
        Me.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchButton.Image = Global.KzSystem.My.Resources.Resources.liner_search
        Me.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(23, 22)
        Me.SearchButton.Text = "S"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(6, 25)
        '
        'CodeCombo
        '
        Me.CodeCombo.AutoSize = False
        Me.CodeCombo.DropDownWidth = 256
        Me.CodeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CodeCombo.Name = "CodeCombo"
        Me.CodeCombo.Size = New System.Drawing.Size(128, 25)
        '
        'CopyButton
        '
        Me.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyButton.Image = Global.KzSystem.My.Resources.Resources.liner_copy
        Me.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyButton.Text = "C"
        Me.CopyButton.ToolTipText = "Copy to clipboard"
        '
        'Separator6
        '
        Me.Separator6.Name = "Separator6"
        Me.Separator6.Size = New System.Drawing.Size(6, 25)
        '
        'EditListButton
        '
        Me.EditListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditListButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToToolStripMenuItem, Me.InsertToToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveSelectedToolStripMenuItem, Me.RemoveCheckedToolStripMenuItem})
        Me.EditListButton.Image = Global.KzSystem.My.Resources.Resources.liner_edit
        Me.EditListButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditListButton.Name = "EditListButton"
        Me.EditListButton.Size = New System.Drawing.Size(29, 22)
        Me.EditListButton.Text = "ED"
        '
        'AddToToolStripMenuItem
        '
        Me.AddToToolStripMenuItem.Name = "AddToToolStripMenuItem"
        Me.AddToToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AddToToolStripMenuItem.Text = "AddTo"
        '
        'InsertToToolStripMenuItem
        '
        Me.InsertToToolStripMenuItem.Name = "InsertToToolStripMenuItem"
        Me.InsertToToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.InsertToToolStripMenuItem.Text = "InsertTo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "RemoveSelected"
        '
        'RemoveCheckedToolStripMenuItem
        '
        Me.RemoveCheckedToolStripMenuItem.Name = "RemoveCheckedToolStripMenuItem"
        Me.RemoveCheckedToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RemoveCheckedToolStripMenuItem.Text = "RemoveChecked"
        '
        'ExportButton
        '
        Me.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCurrentToolStripMenuItem, Me.ExportListToolStripMenuItem})
        Me.ExportButton.Image = Global.KzSystem.My.Resources.Resources.liner_export
        Me.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(29, 22)
        Me.ExportButton.Text = "EX"
        Me.ExportButton.ToolTipText = "Export or save current color"
        '
        'SaveCurrentToolStripMenuItem
        '
        Me.SaveCurrentToolStripMenuItem.Name = "SaveCurrentToolStripMenuItem"
        Me.SaveCurrentToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveCurrentToolStripMenuItem.Text = "SaveCurrent"
        '
        'ExportListToolStripMenuItem
        '
        Me.ExportListToolStripMenuItem.Name = "ExportListToolStripMenuItem"
        Me.ExportListToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExportListToolStripMenuItem.Text = "ExportList"
        '
        'RootStatus
        '
        Me.RootStatus.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.RootStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TypeLabel, Me.ColorsLabel, Me.CheckedLabel})
        Me.RootStatus.Location = New System.Drawing.Point(0, 389)
        Me.RootStatus.Name = "RootStatus"
        Me.RootStatus.Size = New System.Drawing.Size(460, 26)
        Me.RootStatus.TabIndex = 2
        Me.RootStatus.Text = "StatusStrip1"
        '
        'TypeLabel
        '
        Me.TypeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(89, 21)
        Me.TypeLabel.Text = "KnownColors"
        '
        'ColorsLabel
        '
        Me.ColorsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ColorsLabel.Name = "ColorsLabel"
        Me.ColorsLabel.Size = New System.Drawing.Size(57, 21)
        Me.ColorsLabel.Text = "0 Listed"
        '
        'CheckedLabel
        '
        Me.CheckedLabel.Name = "CheckedLabel"
        Me.CheckedLabel.Size = New System.Drawing.Size(69, 21)
        Me.CheckedLabel.Text = "0 Checked"
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.RootSpliter.Location = New System.Drawing.Point(0, 25)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.ColorsPanel)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.AutoScroll = True
        Me.RootSpliter.Panel2.Controls.Add(Me.ColorPanel)
        Me.RootSpliter.Size = New System.Drawing.Size(460, 364)
        Me.RootSpliter.SplitterDistance = 205
        Me.RootSpliter.TabIndex = 3
        '
        'ColorsPanel
        '
        Me.ColorsPanel.AutoScroll = True
        Me.ColorsPanel.BackColor = System.Drawing.Color.DarkGray
        Me.ColorsPanel.DefaultColorListType = KzSystem.KzColorListType.None
        Me.ColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ColorsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ColorsPanel.Name = "ColorsPanel"
        Me.ColorsPanel.Size = New System.Drawing.Size(205, 364)
        Me.ColorsPanel.TabIndex = 0
        Me.ColorsPanel.WrapContents = False
        '
        'ColorPanel
        '
        Me.ColorPanel.ColumnCount = 3
        Me.ColorPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.ColorPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ColorPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ColorPanel.Controls.Add(Me.HueLB, 2, 1)
        Me.ColorPanel.Controls.Add(Me.SaturationLB, 2, 3)
        Me.ColorPanel.Controls.Add(Me.BrightnessLB, 2, 5)
        Me.ColorPanel.Controls.Add(Me.NameLB, 0, 8)
        Me.ColorPanel.Controls.Add(Me.ColorShowPanel, 0, 0)
        Me.ColorPanel.Controls.Add(Me.HueTB, 2, 2)
        Me.ColorPanel.Controls.Add(Me.SaturationTB, 2, 4)
        Me.ColorPanel.Controls.Add(Me.BrightnessTB, 2, 6)
        Me.ColorPanel.Controls.Add(Me.RedBar, 0, 11)
        Me.ColorPanel.Controls.Add(Me.GreenBar, 0, 12)
        Me.ColorPanel.Controls.Add(Me.BlueBar, 0, 13)
        Me.ColorPanel.Controls.Add(Me.AlphaBar, 0, 14)
        Me.ColorPanel.Controls.Add(Me.OkBT, 2, 8)
        Me.ColorPanel.Controls.Add(Me.CancelBT, 2, 9)
        Me.ColorPanel.Controls.Add(Me.NameTB, 1, 8)
        Me.ColorPanel.Controls.Add(Me.NumTB, 1, 9)
        Me.ColorPanel.Controls.Add(Me.NumBT, 0, 9)
        Me.ColorPanel.Controls.Add(Me.HasCodeLB, 0, 15)
        Me.ColorPanel.Controls.Add(Me.HandleChecker, 2, 0)
        Me.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ColorPanel.Location = New System.Drawing.Point(0, 0)
        Me.ColorPanel.Name = "ColorPanel"
        Me.ColorPanel.RowCount = 16
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ColorPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ColorPanel.Size = New System.Drawing.Size(251, 362)
        Me.ColorPanel.TabIndex = 0
        '
        'HueLB
        '
        Me.HueLB.AutoSize = True
        Me.HueLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HueLB.Location = New System.Drawing.Point(154, 25)
        Me.HueLB.Name = "HueLB"
        Me.HueLB.Size = New System.Drawing.Size(94, 20)
        Me.HueLB.TabIndex = 2
        Me.HueLB.Text = "Hue"
        Me.HueLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'SaturationLB
        '
        Me.SaturationLB.AutoSize = True
        Me.SaturationLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaturationLB.Location = New System.Drawing.Point(154, 65)
        Me.SaturationLB.Name = "SaturationLB"
        Me.SaturationLB.Size = New System.Drawing.Size(94, 20)
        Me.SaturationLB.TabIndex = 3
        Me.SaturationLB.Text = "Saturation"
        Me.SaturationLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'BrightnessLB
        '
        Me.BrightnessLB.AutoSize = True
        Me.BrightnessLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrightnessLB.Location = New System.Drawing.Point(154, 105)
        Me.BrightnessLB.Name = "BrightnessLB"
        Me.BrightnessLB.Size = New System.Drawing.Size(94, 20)
        Me.BrightnessLB.TabIndex = 4
        Me.BrightnessLB.Text = "Brightness"
        Me.BrightnessLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'NameLB
        '
        Me.NameLB.AutoSize = True
        Me.NameLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameLB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NameLB.Location = New System.Drawing.Point(3, 155)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(44, 25)
        Me.NameLB.TabIndex = 0
        Me.NameLB.Text = "Name"
        Me.NameLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColorShowPanel
        '
        Me.ColorShowPanel.BackColor = System.Drawing.Color.Transparent
        Me.ColorShowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorPanel.SetColumnSpan(Me.ColorShowPanel, 2)
        Me.ColorShowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorShowPanel.Location = New System.Drawing.Point(10, 10)
        Me.ColorShowPanel.Margin = New System.Windows.Forms.Padding(10)
        Me.ColorShowPanel.Name = "ColorShowPanel"
        Me.ColorPanel.SetRowSpan(Me.ColorShowPanel, 7)
        Me.ColorShowPanel.Size = New System.Drawing.Size(131, 125)
        Me.ColorShowPanel.TabIndex = 5
        '
        'HueTB
        '
        Me.HueTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HueTB.Location = New System.Drawing.Point(151, 45)
        Me.HueTB.Margin = New System.Windows.Forms.Padding(0)
        Me.HueTB.Name = "HueTB"
        Me.HueTB.Size = New System.Drawing.Size(100, 16)
        Me.HueTB.TabIndex = 6
        Me.HueTB.TabStop = False
        '
        'SaturationTB
        '
        Me.SaturationTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SaturationTB.Location = New System.Drawing.Point(151, 85)
        Me.SaturationTB.Margin = New System.Windows.Forms.Padding(0)
        Me.SaturationTB.Name = "SaturationTB"
        Me.SaturationTB.Size = New System.Drawing.Size(100, 16)
        Me.SaturationTB.TabIndex = 7
        Me.SaturationTB.TabStop = False
        '
        'BrightnessTB
        '
        Me.BrightnessTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrightnessTB.Location = New System.Drawing.Point(151, 125)
        Me.BrightnessTB.Margin = New System.Windows.Forms.Padding(0)
        Me.BrightnessTB.Name = "BrightnessTB"
        Me.BrightnessTB.Size = New System.Drawing.Size(100, 16)
        Me.BrightnessTB.TabIndex = 8
        Me.BrightnessTB.TabStop = False
        '
        'RedBar
        '
        Me.ColorPanel.SetColumnSpan(Me.RedBar, 3)
        Me.RedBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.RedBar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedBar.Location = New System.Drawing.Point(0, 215)
        Me.RedBar.Margin = New System.Windows.Forms.Padding(0)
        Me.RedBar.Maximum = 255
        Me.RedBar.Minimum = 0
        Me.RedBar.Name = "RedBar"
        Me.RedBar.NumberWidth = 55
        Me.RedBar.Size = New System.Drawing.Size(251, 28)
        Me.RedBar.TabIndex = 1
        Me.RedBar.TickFrequency = 20
        Me.RedBar.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.RedBar.Title = "Red"
        Me.RedBar.TitleWidth = 45
        Me.RedBar.Value = 0
        '
        'GreenBar
        '
        Me.ColorPanel.SetColumnSpan(Me.GreenBar, 3)
        Me.GreenBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.GreenBar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenBar.Location = New System.Drawing.Point(0, 243)
        Me.GreenBar.Margin = New System.Windows.Forms.Padding(0)
        Me.GreenBar.Maximum = 255
        Me.GreenBar.Minimum = 0
        Me.GreenBar.Name = "GreenBar"
        Me.GreenBar.NumberWidth = 55
        Me.GreenBar.Size = New System.Drawing.Size(251, 28)
        Me.GreenBar.TabIndex = 2
        Me.GreenBar.TickFrequency = 20
        Me.GreenBar.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.GreenBar.Title = "Green"
        Me.GreenBar.TitleWidth = 45
        Me.GreenBar.Value = 0
        '
        'BlueBar
        '
        Me.ColorPanel.SetColumnSpan(Me.BlueBar, 3)
        Me.BlueBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BlueBar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueBar.Location = New System.Drawing.Point(0, 271)
        Me.BlueBar.Margin = New System.Windows.Forms.Padding(0)
        Me.BlueBar.Maximum = 255
        Me.BlueBar.Minimum = 0
        Me.BlueBar.Name = "BlueBar"
        Me.BlueBar.NumberWidth = 55
        Me.BlueBar.Size = New System.Drawing.Size(251, 28)
        Me.BlueBar.TabIndex = 3
        Me.BlueBar.TickFrequency = 20
        Me.BlueBar.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.BlueBar.Title = "Blue"
        Me.BlueBar.TitleWidth = 45
        Me.BlueBar.Value = 0
        '
        'AlphaBar
        '
        Me.ColorPanel.SetColumnSpan(Me.AlphaBar, 3)
        Me.AlphaBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlphaBar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaBar.Location = New System.Drawing.Point(0, 299)
        Me.AlphaBar.Margin = New System.Windows.Forms.Padding(0)
        Me.AlphaBar.Maximum = 255
        Me.AlphaBar.Minimum = 0
        Me.AlphaBar.Name = "AlphaBar"
        Me.AlphaBar.NumberWidth = 55
        Me.AlphaBar.Size = New System.Drawing.Size(251, 28)
        Me.AlphaBar.TabIndex = 4
        Me.AlphaBar.TickFrequency = 20
        Me.AlphaBar.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.AlphaBar.Title = "Alpha"
        Me.AlphaBar.TitleWidth = 45
        Me.AlphaBar.Value = 0
        '
        'OkBT
        '
        Me.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkBT.Location = New System.Drawing.Point(152, 156)
        Me.OkBT.Margin = New System.Windows.Forms.Padding(1)
        Me.OkBT.Name = "OkBT"
        Me.OkBT.Size = New System.Drawing.Size(98, 23)
        Me.OkBT.TabIndex = 7
        Me.OkBT.Text = "OK"
        Me.OkBT.UseVisualStyleBackColor = True
        '
        'CancelBT
        '
        Me.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelBT.Location = New System.Drawing.Point(152, 181)
        Me.CancelBT.Margin = New System.Windows.Forms.Padding(1)
        Me.CancelBT.Name = "CancelBT"
        Me.CancelBT.Size = New System.Drawing.Size(98, 23)
        Me.CancelBT.TabIndex = 8
        Me.CancelBT.Text = "Cancel"
        Me.CancelBT.UseVisualStyleBackColor = True
        '
        'NameTB
        '
        Me.NameTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NameTB.Location = New System.Drawing.Point(52, 157)
        Me.NameTB.Margin = New System.Windows.Forms.Padding(2)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(97, 23)
        Me.NameTB.TabIndex = 6
        '
        'NumTB
        '
        Me.NumTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumTB.Location = New System.Drawing.Point(52, 182)
        Me.NumTB.Margin = New System.Windows.Forms.Padding(2)
        Me.NumTB.Name = "NumTB"
        Me.NumTB.Size = New System.Drawing.Size(97, 23)
        Me.NumTB.TabIndex = 5
        '
        'NumBT
        '
        Me.NumBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumBT.FlatAppearance.BorderSize = 0
        Me.NumBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumBT.Location = New System.Drawing.Point(3, 181)
        Me.NumBT.Margin = New System.Windows.Forms.Padding(3, 1, 3, 2)
        Me.NumBT.Name = "NumBT"
        Me.NumBT.Size = New System.Drawing.Size(44, 22)
        Me.NumBT.TabIndex = 17
        Me.NumBT.Text = "HEX"
        Me.NumBT.UseVisualStyleBackColor = True
        '
        'HasCodeLB
        '
        Me.HasCodeLB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.HasCodeLB.AutoSize = True
        Me.ColorPanel.SetColumnSpan(Me.HasCodeLB, 3)
        Me.HasCodeLB.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasCodeLB.Location = New System.Drawing.Point(101, 337)
        Me.HasCodeLB.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.HasCodeLB.Name = "HasCodeLB"
        Me.HasCodeLB.Size = New System.Drawing.Size(49, 14)
        Me.HasCodeLB.TabIndex = 18
        Me.HasCodeLB.Text = "Label2"
        '
        'HandleChecker
        '
        Me.HandleChecker.AutoSize = True
        Me.HandleChecker.Location = New System.Drawing.Point(154, 3)
        Me.HandleChecker.Name = "HandleChecker"
        Me.HandleChecker.Size = New System.Drawing.Size(68, 19)
        Me.HandleChecker.TabIndex = 19
        Me.HandleChecker.TabStop = False
        Me.HandleChecker.Text = "Handle"
        Me.HandleChecker.UseVisualStyleBackColor = True
        '
        'KzColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootStatus)
        Me.Controls.Add(Me.RootTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzColorPicker"
        Me.Size = New System.Drawing.Size(460, 415)
        Me.RootTools.ResumeLayout(False)
        Me.RootTools.PerformLayout()
        Me.RootStatus.ResumeLayout(False)
        Me.RootStatus.PerformLayout()
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.ColorPanel.ResumeLayout(False)
        Me.ColorPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootTools As ToolStrip
    Friend WithEvents ImportButton As ToolStripButton
    Friend WithEvents Separator1 As ToolStripSeparator
    Friend WithEvents ShowColorsButton As ToolStripDropDownButton
    Friend WithEvents KnownItem As ToolStripMenuItem
    Friend WithEvents SystemItem As ToolStripMenuItem
    Friend WithEvents WebItem As ToolStripMenuItem
    Friend WithEvents CustomItem As ToolStripMenuItem
    Friend WithEvents Separator4 As ToolStripSeparator
    Friend WithEvents CheckedItem As ToolStripMenuItem
    Friend WithEvents Separator5 As ToolStripSeparator
    Friend WithEvents ClearListItem As ToolStripMenuItem
    Friend WithEvents Separator7 As ToolStripSeparator
    Friend WithEvents SearchBox As ToolStripTextBox
    Friend WithEvents SearchButton As ToolStripButton
    Friend WithEvents Separator3 As ToolStripSeparator
    Friend WithEvents CodeCombo As ToolStripComboBox
    Friend WithEvents CopyButton As ToolStripButton
    Friend WithEvents Separator6 As ToolStripSeparator
    Friend WithEvents EditListButton As ToolStripDropDownButton
    Friend WithEvents AddToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RemoveSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveCheckedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportButton As ToolStripDropDownButton
    Friend WithEvents SaveCurrentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RootStatus As StatusStrip
    Friend WithEvents TypeLabel As ToolStripStatusLabel
    Friend WithEvents ColorsLabel As ToolStripStatusLabel
    Friend WithEvents CheckedLabel As ToolStripStatusLabel
    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents ColorsPanel As KzColorListPanel
    Friend WithEvents ColorPanel As TableLayoutPanel
    Friend WithEvents HueLB As Label
    Friend WithEvents SaturationLB As Label
    Friend WithEvents BrightnessLB As Label
    Friend WithEvents NameLB As Label
    Friend WithEvents ColorShowPanel As Panel
    Friend WithEvents HueTB As TextBox
    Friend WithEvents SaturationTB As TextBox
    Friend WithEvents BrightnessTB As TextBox
    Friend WithEvents RedBar As KzSlideBar
    Friend WithEvents GreenBar As KzSlideBar
    Friend WithEvents BlueBar As KzSlideBar
    Friend WithEvents AlphaBar As KzSlideBar
    Friend WithEvents OkBT As Button
    Friend WithEvents CancelBT As Button
    Friend WithEvents NameTB As TextBox
    Friend WithEvents NumTB As TextBox
    Friend WithEvents NumBT As Button
    Friend WithEvents HasCodeLB As Label
    Friend WithEvents HandleChecker As CheckBox
End Class
