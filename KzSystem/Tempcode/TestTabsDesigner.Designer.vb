<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestTabsDesigner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestTabsDesigner))
        Dim KzTabsAppearance1 As KzSystem.KzTabsAppearance = New KzSystem.KzTabsAppearance()
        Dim KzTabStatusAppearance1 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance2 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance3 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance4 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance5 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance6 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance7 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance8 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance9 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Dim KzTabStatusAppearance10 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance(KzTabsAppearance1)
        Me.RootTools = New System.Windows.Forms.ToolStrip()
        Me.ImportItem = New System.Windows.Forms.ToolStripButton()
        Me.ExportItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ANameBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowCodeItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FullCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabsCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.PresetsCB = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviewButton = New System.Windows.Forms.ToolStripButton()
        Me.RootStatus = New System.Windows.Forms.StatusStrip()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.LeftSpliter = New System.Windows.Forms.SplitContainer()
        Me.TAPPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPageStyleCB = New System.Windows.Forms.ComboBox()
        Me.ShowAddCK = New System.Windows.Forms.CheckBox()
        Me.SelectedCloseCK = New System.Windows.Forms.CheckBox()
        Me.NormalCloseCK = New System.Windows.Forms.CheckBox()
        Me.ButtonMarginSetter = New KzSystem.KzPadingSetter()
        Me.TextMarginSetter = New KzSystem.KzPadingSetter()
        Me.ShowImageCK = New System.Windows.Forms.CheckBox()
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
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.CKLabel = New System.Windows.Forms.Label()
        Me.BorderColorButton = New System.Windows.Forms.Button()
        Me.BackColorButton = New System.Windows.Forms.Button()
        Me.ForeColorButton = New System.Windows.Forms.Button()
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
        Me.TheTabControl = New KzSystem.KzTabControl()
        Me.ColorPickerPage = New System.Windows.Forms.TabPage()
        Me.ColorPicker = New KzSystem.KzColorPicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DesignerToolTip = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.TheTabControl.SuspendLayout()
        Me.ColorPickerPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootTools
        '
        Me.RootTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RootTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportItem, Me.ExportItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ANameBox, Me.ToolStripSeparator2, Me.ShowCodeItem, Me.ToolStripSeparator4, Me.ToolStripLabel2, Me.PresetsCB, Me.ToolStripSeparator5, Me.PreviewButton})
        Me.RootTools.Location = New System.Drawing.Point(0, 0)
        Me.RootTools.Name = "RootTools"
        Me.RootTools.Size = New System.Drawing.Size(741, 25)
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
        Me.ImportItem.Text = "Import"
        Me.ImportItem.ToolTipText = "Import from file"
        '
        'ExportItem
        '
        Me.ExportItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportItem.Image = CType(resources.GetObject("ExportItem.Image"), System.Drawing.Image)
        Me.ExportItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportItem.Name = "ExportItem"
        Me.ExportItem.Size = New System.Drawing.Size(23, 22)
        Me.ExportItem.Text = "Export"
        Me.ExportItem.ToolTipText = "Export to file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "Name:"
        '
        'ANameBox
        '
        Me.ANameBox.Name = "ANameBox"
        Me.ANameBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ShowCodeItem
        '
        Me.ShowCodeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowCodeItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullCodeToolStripMenuItem, Me.TabsCodeToolStripMenuItem, Me.StatusCodeToolStripMenuItem, Me.ToolStripSeparator3, Me.FunctionToolStripMenuItem})
        Me.ShowCodeItem.Image = CType(resources.GetObject("ShowCodeItem.Image"), System.Drawing.Image)
        Me.ShowCodeItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowCodeItem.Name = "ShowCodeItem"
        Me.ShowCodeItem.Size = New System.Drawing.Size(29, 22)
        Me.ShowCodeItem.Text = "Code"
        Me.ShowCodeItem.ToolTipText = "Show code"
        '
        'FullCodeToolStripMenuItem
        '
        Me.FullCodeToolStripMenuItem.Name = "FullCodeToolStripMenuItem"
        Me.FullCodeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FullCodeToolStripMenuItem.Text = "Full Code"
        '
        'TabsCodeToolStripMenuItem
        '
        Me.TabsCodeToolStripMenuItem.Name = "TabsCodeToolStripMenuItem"
        Me.TabsCodeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TabsCodeToolStripMenuItem.Text = "Tabs Code"
        '
        'StatusCodeToolStripMenuItem
        '
        Me.StatusCodeToolStripMenuItem.Name = "StatusCodeToolStripMenuItem"
        Me.StatusCodeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.StatusCodeToolStripMenuItem.Text = "Status Code"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FunctionToolStripMenuItem.Text = "Function"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel2.Text = "Presets:"
        '
        'PresetsCB
        '
        Me.PresetsCB.Name = "PresetsCB"
        Me.PresetsCB.Size = New System.Drawing.Size(196, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'PreviewButton
        '
        Me.PreviewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PreviewButton.Image = CType(resources.GetObject("PreviewButton.Image"), System.Drawing.Image)
        Me.PreviewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(23, 22)
        Me.PreviewButton.Text = "Preview"
        Me.PreviewButton.ToolTipText = "Preview to the TabControl"
        '
        'RootStatus
        '
        Me.RootStatus.Location = New System.Drawing.Point(0, 469)
        Me.RootStatus.Name = "RootStatus"
        Me.RootStatus.Size = New System.Drawing.Size(741, 22)
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
        Me.RootSpliter.Panel2.Controls.Add(Me.TheTabControl)
        Me.RootSpliter.Size = New System.Drawing.Size(741, 444)
        Me.RootSpliter.SplitterDistance = 300
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
        Me.LeftSpliter.Size = New System.Drawing.Size(300, 444)
        Me.LeftSpliter.SplitterDistance = 159
        Me.LeftSpliter.TabIndex = 0
        '
        'TAPPanel
        '
        Me.TAPPanel.ColumnCount = 4
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TAPPanel.Controls.Add(Me.Label1, 0, 0)
        Me.TAPPanel.Controls.Add(Me.Label2, 0, 1)
        Me.TAPPanel.Controls.Add(Me.Label3, 0, 2)
        Me.TAPPanel.Controls.Add(Me.TabPageStyleCB, 1, 2)
        Me.TAPPanel.Controls.Add(Me.ShowAddCK, 0, 3)
        Me.TAPPanel.Controls.Add(Me.SelectedCloseCK, 0, 4)
        Me.TAPPanel.Controls.Add(Me.NormalCloseCK, 0, 5)
        Me.TAPPanel.Controls.Add(Me.ButtonMarginSetter, 1, 0)
        Me.TAPPanel.Controls.Add(Me.TextMarginSetter, 1, 1)
        Me.TAPPanel.Controls.Add(Me.ShowImageCK, 2, 3)
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
        Me.TAPPanel.Size = New System.Drawing.Size(300, 153)
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
        Me.Label1.Text = "ButtonMargin"
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
        Me.Label2.Text = "TextMargin"
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
        'TabPageStyleCB
        '
        Me.TAPPanel.SetColumnSpan(Me.TabPageStyleCB, 2)
        Me.TabPageStyleCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPageStyleCB.FormattingEnabled = True
        Me.TabPageStyleCB.Location = New System.Drawing.Point(100, 50)
        Me.TabPageStyleCB.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageStyleCB.Name = "TabPageStyleCB"
        Me.TabPageStyleCB.Size = New System.Drawing.Size(174, 25)
        Me.TabPageStyleCB.TabIndex = 8
        '
        'ShowAddCK
        '
        Me.ShowAddCK.AutoSize = True
        Me.ShowAddCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TAPPanel.SetColumnSpan(Me.ShowAddCK, 2)
        Me.ShowAddCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShowAddCK.Location = New System.Drawing.Point(54, 78)
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
        Me.SelectedCloseCK.Location = New System.Drawing.Point(32, 103)
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
        Me.NormalCloseCK.Location = New System.Drawing.Point(37, 128)
        Me.NormalCloseCK.Name = "NormalCloseCK"
        Me.NormalCloseCK.Size = New System.Drawing.Size(147, 19)
        Me.NormalCloseCK.TabIndex = 11
        Me.NormalCloseCK.Text = "NormalTabCanClose"
        Me.NormalCloseCK.UseVisualStyleBackColor = True
        '
        'ButtonMarginSetter
        '
        Me.TAPPanel.SetColumnSpan(Me.ButtonMarginSetter, 2)
        Me.ButtonMarginSetter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMarginSetter.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMarginSetter.Location = New System.Drawing.Point(101, 1)
        Me.ButtonMarginSetter.Margin = New System.Windows.Forms.Padding(1)
        Me.ButtonMarginSetter.Name = "ButtonMarginSetter"
        Me.ButtonMarginSetter.Size = New System.Drawing.Size(172, 23)
        Me.ButtonMarginSetter.TabIndex = 12
        Me.ButtonMarginSetter.Value = New System.Windows.Forms.Padding(0)
        '
        'TextMarginSetter
        '
        Me.TAPPanel.SetColumnSpan(Me.TextMarginSetter, 2)
        Me.TextMarginSetter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextMarginSetter.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMarginSetter.Location = New System.Drawing.Point(101, 26)
        Me.TextMarginSetter.Margin = New System.Windows.Forms.Padding(1)
        Me.TextMarginSetter.Name = "TextMarginSetter"
        Me.TextMarginSetter.Size = New System.Drawing.Size(172, 23)
        Me.TextMarginSetter.TabIndex = 13
        Me.TextMarginSetter.Value = New System.Windows.Forms.Padding(0)
        '
        'ShowImageCK
        '
        Me.ShowImageCK.AutoSize = True
        Me.TAPPanel.SetColumnSpan(Me.ShowImageCK, 2)
        Me.ShowImageCK.Dock = System.Windows.Forms.DockStyle.Left
        Me.ShowImageCK.Location = New System.Drawing.Point(190, 78)
        Me.ShowImageCK.Name = "ShowImageCK"
        Me.ShowImageCK.Size = New System.Drawing.Size(95, 19)
        Me.ShowImageCK.TabIndex = 14
        Me.ShowImageCK.Text = "ShowImage"
        Me.ShowImageCK.UseVisualStyleBackColor = True
        '
        'TSAPPanel
        '
        Me.TSAPPanel.ColumnCount = 4
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TSAPPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
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
        Me.TSAPPanel.Controls.Add(Me.IDLabel, 2, 0)
        Me.TSAPPanel.Controls.Add(Me.CKLabel, 2, 1)
        Me.TSAPPanel.Controls.Add(Me.BorderColorButton, 3, 6)
        Me.TSAPPanel.Controls.Add(Me.BackColorButton, 3, 7)
        Me.TSAPPanel.Controls.Add(Me.ForeColorButton, 3, 8)
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
        Me.TSAPPanel.Size = New System.Drawing.Size(283, 259)
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
        Me.ShadowSideCB.Size = New System.Drawing.Size(152, 25)
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
        Me.RadiusSideCB.Size = New System.Drawing.Size(152, 25)
        Me.RadiusSideCB.TabIndex = 9
        '
        'BorderCK
        '
        Me.BorderCK.AutoSize = True
        Me.BorderCK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSAPPanel.SetColumnSpan(Me.BorderCK, 2)
        Me.BorderCK.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderCK.Location = New System.Drawing.Point(43, 3)
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
        Me.BlodBorderCK.Location = New System.Drawing.Point(47, 28)
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
        Me.ShadowCK.Location = New System.Drawing.Point(38, 53)
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
        Me.RadiusCK.Location = New System.Drawing.Point(45, 103)
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
        Me.BlodForeCK.Location = New System.Drawing.Point(62, 228)
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
        Me.BorderColorTB.Size = New System.Drawing.Size(150, 23)
        Me.BorderColorTB.TabIndex = 16
        '
        'BackColorTB
        '
        Me.TSAPPanel.SetColumnSpan(Me.BackColorTB, 2)
        Me.BackColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorTB.Location = New System.Drawing.Point(101, 176)
        Me.BackColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.BackColorTB.Name = "BackColorTB"
        Me.BackColorTB.Size = New System.Drawing.Size(150, 23)
        Me.BackColorTB.TabIndex = 17
        '
        'ForeColorTB
        '
        Me.TSAPPanel.SetColumnSpan(Me.ForeColorTB, 2)
        Me.ForeColorTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorTB.Location = New System.Drawing.Point(101, 201)
        Me.ForeColorTB.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeColorTB.Name = "ForeColorTB"
        Me.ForeColorTB.Size = New System.Drawing.Size(150, 23)
        Me.ForeColorTB.TabIndex = 18
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(148, 0)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(101, 25)
        Me.IDLabel.TabIndex = 19
        Me.IDLabel.Text = "0"
        Me.IDLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'CKLabel
        '
        Me.CKLabel.AutoSize = True
        Me.CKLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CKLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CKLabel.Location = New System.Drawing.Point(148, 25)
        Me.CKLabel.Name = "CKLabel"
        Me.CKLabel.Size = New System.Drawing.Size(101, 25)
        Me.CKLabel.TabIndex = 20
        Me.CKLabel.Text = "0"
        Me.CKLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BorderColorButton
        '
        Me.BorderColorButton.BackColor = System.Drawing.Color.Transparent
        Me.BorderColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BorderColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorderColorButton.Location = New System.Drawing.Point(253, 151)
        Me.BorderColorButton.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderColorButton.Name = "BorderColorButton"
        Me.BorderColorButton.Size = New System.Drawing.Size(29, 23)
        Me.BorderColorButton.TabIndex = 21
        Me.BorderColorButton.UseVisualStyleBackColor = False
        '
        'BackColorButton
        '
        Me.BackColorButton.BackColor = System.Drawing.Color.Transparent
        Me.BackColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackColorButton.Location = New System.Drawing.Point(253, 176)
        Me.BackColorButton.Margin = New System.Windows.Forms.Padding(1)
        Me.BackColorButton.Name = "BackColorButton"
        Me.BackColorButton.Size = New System.Drawing.Size(29, 23)
        Me.BackColorButton.TabIndex = 22
        Me.BackColorButton.UseVisualStyleBackColor = False
        '
        'ForeColorButton
        '
        Me.ForeColorButton.BackColor = System.Drawing.Color.Transparent
        Me.ForeColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ForeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForeColorButton.Location = New System.Drawing.Point(253, 201)
        Me.ForeColorButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeColorButton.Name = "ForeColorButton"
        Me.ForeColorButton.Size = New System.Drawing.Size(29, 23)
        Me.ForeColorButton.TabIndex = 23
        Me.ForeColorButton.UseVisualStyleBackColor = False
        '
        'SwitchTools
        '
        Me.SwitchTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabSW, Me.TabHoverSW, Me.SelectedTabSW, Me.SelectedTabHoverSW, Me.ButtonSW, Me.ButtonHoverSW, Me.SelectedButtonSW, Me.SelectedButtonHoverSW, Me.AddTabSW, Me.AddTabHoverSW})
        Me.SwitchTools.Location = New System.Drawing.Point(0, 0)
        Me.SwitchTools.Name = "SwitchTools"
        Me.SwitchTools.Size = New System.Drawing.Size(283, 25)
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
        Me.TabSW.Text = "Tab"
        '
        'TabHoverSW
        '
        Me.TabHoverSW.CheckOnClick = True
        Me.TabHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TabHoverSW.Image = CType(resources.GetObject("TabHoverSW.Image"), System.Drawing.Image)
        Me.TabHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TabHoverSW.Name = "TabHoverSW"
        Me.TabHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.TabHoverSW.Text = "TabHover"
        '
        'SelectedTabSW
        '
        Me.SelectedTabSW.CheckOnClick = True
        Me.SelectedTabSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedTabSW.Image = CType(resources.GetObject("SelectedTabSW.Image"), System.Drawing.Image)
        Me.SelectedTabSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedTabSW.Name = "SelectedTabSW"
        Me.SelectedTabSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedTabSW.Text = "SelectedTab"
        '
        'SelectedTabHoverSW
        '
        Me.SelectedTabHoverSW.CheckOnClick = True
        Me.SelectedTabHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedTabHoverSW.Image = CType(resources.GetObject("SelectedTabHoverSW.Image"), System.Drawing.Image)
        Me.SelectedTabHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedTabHoverSW.Name = "SelectedTabHoverSW"
        Me.SelectedTabHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedTabHoverSW.Text = "SelectedTabHover"
        '
        'ButtonSW
        '
        Me.ButtonSW.CheckOnClick = True
        Me.ButtonSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSW.Image = CType(resources.GetObject("ButtonSW.Image"), System.Drawing.Image)
        Me.ButtonSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSW.Name = "ButtonSW"
        Me.ButtonSW.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSW.Text = "Button"
        '
        'ButtonHoverSW
        '
        Me.ButtonHoverSW.CheckOnClick = True
        Me.ButtonHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonHoverSW.Image = CType(resources.GetObject("ButtonHoverSW.Image"), System.Drawing.Image)
        Me.ButtonHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonHoverSW.Name = "ButtonHoverSW"
        Me.ButtonHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.ButtonHoverSW.Text = "ButtonHover"
        '
        'SelectedButtonSW
        '
        Me.SelectedButtonSW.CheckOnClick = True
        Me.SelectedButtonSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedButtonSW.Image = CType(resources.GetObject("SelectedButtonSW.Image"), System.Drawing.Image)
        Me.SelectedButtonSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedButtonSW.Name = "SelectedButtonSW"
        Me.SelectedButtonSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedButtonSW.Text = "SelectedButton"
        '
        'SelectedButtonHoverSW
        '
        Me.SelectedButtonHoverSW.CheckOnClick = True
        Me.SelectedButtonHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedButtonHoverSW.Image = CType(resources.GetObject("SelectedButtonHoverSW.Image"), System.Drawing.Image)
        Me.SelectedButtonHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedButtonHoverSW.Name = "SelectedButtonHoverSW"
        Me.SelectedButtonHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.SelectedButtonHoverSW.Text = "SelectedButtonHover"
        '
        'AddTabSW
        '
        Me.AddTabSW.CheckOnClick = True
        Me.AddTabSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddTabSW.Image = CType(resources.GetObject("AddTabSW.Image"), System.Drawing.Image)
        Me.AddTabSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTabSW.Name = "AddTabSW"
        Me.AddTabSW.Size = New System.Drawing.Size(23, 22)
        Me.AddTabSW.Text = "AddTab"
        '
        'AddTabHoverSW
        '
        Me.AddTabHoverSW.CheckOnClick = True
        Me.AddTabHoverSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddTabHoverSW.Image = CType(resources.GetObject("AddTabHoverSW.Image"), System.Drawing.Image)
        Me.AddTabHoverSW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTabHoverSW.Name = "AddTabHoverSW"
        Me.AddTabHoverSW.Size = New System.Drawing.Size(23, 22)
        Me.AddTabHoverSW.Text = "AddTabHover"
        '
        'TheTabControl
        '
        Me.TheTabControl.Controls.Add(Me.ColorPickerPage)
        Me.TheTabControl.Controls.Add(Me.TabPage2)
        Me.TheTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TheTabControl.Location = New System.Drawing.Point(0, 0)
        Me.TheTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.TheTabControl.Multiline = True
        Me.TheTabControl.Name = "TheTabControl"
        Me.TheTabControl.NewAddedAutoSelect = True
        Me.TheTabControl.NewTitlePrefix = "NewTab"
        Me.TheTabControl.SelectedIndex = 0
        Me.TheTabControl.Size = New System.Drawing.Size(436, 444)
        Me.TheTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TheTabControl.TabIndex = 2
        KzTabStatusAppearance1.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance1.BlodBorder = False
        KzTabStatusAppearance1.BlodFore = False
        KzTabStatusAppearance1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance1.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance1.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance1.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance1.ShowBorder = False
        'KzTabStatusAppearance1.ShowRadius = False
        KzTabStatusAppearance1.ShowShadow = False
        KzTabsAppearance1.SetOfAddNewTab = KzTabStatusAppearance1
        KzTabStatusAppearance2.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance2.BlodBorder = False
        KzTabStatusAppearance2.BlodFore = False
        KzTabStatusAppearance2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance2.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance2.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance2.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance2.ShowBorder = False
        'KzTabStatusAppearance2.ShowRadius = False
        KzTabStatusAppearance2.ShowShadow = False
        KzTabsAppearance1.SetOfAddNewTabHover = KzTabStatusAppearance2
        KzTabStatusAppearance3.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance3.BlodBorder = False
        KzTabStatusAppearance3.BlodFore = False
        KzTabStatusAppearance3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance3.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance3.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance3.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance3.ShowBorder = False
        'KzTabStatusAppearance3.ShowRadius = False
        KzTabStatusAppearance3.ShowShadow = False
        KzTabsAppearance1.SetOfNormalButton = KzTabStatusAppearance3
        KzTabStatusAppearance4.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance4.BlodBorder = False
        KzTabStatusAppearance4.BlodFore = False
        KzTabStatusAppearance4.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance4.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance4.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance4.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance4.ShowBorder = False
        'KzTabStatusAppearance4.ShowRadius = False
        KzTabStatusAppearance4.ShowShadow = False
        KzTabsAppearance1.SetOfNormalButtonHover = KzTabStatusAppearance4
        KzTabsAppearance1.ButtonMargin = New System.Windows.Forms.Padding(2)
        KzTabsAppearance1.NormalTabCanClose = False
        KzTabStatusAppearance5.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance5.BlodBorder = False
        KzTabStatusAppearance5.BlodFore = False
        KzTabStatusAppearance5.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance5.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance5.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance5.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance5.ShowBorder = False
        'KzTabStatusAppearance5.ShowRadius = False
        KzTabStatusAppearance5.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedButton = KzTabStatusAppearance5
        KzTabStatusAppearance6.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance6.BlodBorder = False
        KzTabStatusAppearance6.BlodFore = False
        KzTabStatusAppearance6.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance6.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance6.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance6.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance6.ShowBorder = False
        'KzTabStatusAppearance6.ShowRadius = False
        KzTabStatusAppearance6.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedButtonHover = KzTabStatusAppearance6
        KzTabStatusAppearance7.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance7.BlodBorder = False
        KzTabStatusAppearance7.BlodFore = False
        KzTabStatusAppearance7.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance7.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance7.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance7.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance7.ShowBorder = False
        'KzTabStatusAppearance7.ShowRadius = False
        KzTabStatusAppearance7.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedTab = KzTabStatusAppearance7
        KzTabsAppearance1.SelectedTabCanClose = False
        KzTabStatusAppearance8.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance8.BlodBorder = False
        KzTabStatusAppearance8.BlodFore = False
        KzTabStatusAppearance8.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance8.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance8.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance8.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance8.ShowBorder = False
        'KzTabStatusAppearance8.ShowRadius = False
        KzTabStatusAppearance8.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedTabHover = KzTabStatusAppearance8
        'KzTabsAppearance1.ShowAddNewTab = False
        KzTabsAppearance1.ShowIcon = False
        KzTabStatusAppearance9.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance9.BlodBorder = False
        KzTabStatusAppearance9.BlodFore = False
        KzTabStatusAppearance9.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance9.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance9.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance9.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance9.ShowBorder = False
        'KzTabStatusAppearance9.ShowRadius = False
        KzTabStatusAppearance9.ShowShadow = False
        KzTabsAppearance1.SetOfNormalTab = KzTabStatusAppearance9
        KzTabStatusAppearance10.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance10.BlodBorder = False
        KzTabStatusAppearance10.BlodFore = False
        KzTabStatusAppearance10.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance10.ForeColor = System.Drawing.SystemColors.ControlText
        'KzTabStatusAppearance10.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabStatusAppearance10.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance10.ShowBorder = False
        'KzTabStatusAppearance10.ShowRadius = False
        KzTabStatusAppearance10.ShowShadow = False
        KzTabsAppearance1.SetOfNormalTabHover = KzTabStatusAppearance10
        KzTabsAppearance1.TabPageStyle = KzSystem.KzTabPageStyle.None
        KzTabsAppearance1.TextMargin = New System.Windows.Forms.Padding(1)
        Me.TheTabControl.TabsAppearance = KzTabsAppearance1
        '
        'ColorPickerPage
        '
        Me.ColorPickerPage.BackColor = System.Drawing.SystemColors.Control
        Me.ColorPickerPage.Controls.Add(Me.ColorPicker)
        Me.ColorPickerPage.Location = New System.Drawing.Point(4, 26)
        Me.ColorPickerPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ColorPickerPage.Name = "ColorPickerPage"
        Me.ColorPickerPage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ColorPickerPage.Size = New System.Drawing.Size(428, 414)
        Me.ColorPickerPage.TabIndex = 0
        Me.ColorPickerPage.Text = "TabPage1"
        '
        'ColorPicker
        '
        Me.ColorPicker.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorPicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorPicker.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ColorPicker.Location = New System.Drawing.Point(3, 4)
        Me.ColorPicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ColorPicker.Name = "ColorPicker"
        Me.ColorPicker.Size = New System.Drawing.Size(422, 406)
        Me.ColorPicker.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(428, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TestTabsDesigner
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(741, 491)
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootStatus)
        Me.Controls.Add(Me.RootTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Name = "TestTabsDesigner"
        Me.Text = "TestTabsDesigner"
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
        Me.TheTabControl.ResumeLayout(False)
        Me.ColorPickerPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootTools As ToolStrip
    Friend WithEvents RootStatus As StatusStrip
    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents TheTabControl As KzTabControl
    Friend WithEvents ColorPickerPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImportItem As ToolStripButton
    Friend WithEvents LeftSpliter As SplitContainer
    Friend WithEvents TAPPanel As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents ExportItem As ToolStripButton
    Friend WithEvents IDLabel As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ANameBox As ToolStripTextBox
    Friend WithEvents CKLabel As Label
    Friend WithEvents BorderColorButton As Button
    Friend WithEvents BackColorButton As Button
    Friend WithEvents ForeColorButton As Button
    Friend WithEvents ColorPicker As KzColorPicker
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ShowCodeItem As ToolStripDropDownButton
    Friend WithEvents FullCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabsCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FunctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonMarginSetter As KzPadingSetter
    Friend WithEvents TextMarginSetter As KzPadingSetter
    Friend WithEvents DesignerToolTip As ToolTip
    Friend WithEvents ShowImageCK As CheckBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents PresetsCB As ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents PreviewButton As ToolStripButton
End Class
