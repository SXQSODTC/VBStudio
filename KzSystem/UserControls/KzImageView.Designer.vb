<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzImageView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzImageView))
        Me.IViewTools = New System.Windows.Forms.ToolStrip()
        Me.IViewStatus = New System.Windows.Forms.StatusStrip()
        Me.IViewSpliter = New System.Windows.Forms.SplitContainer()
        Me.ISpliter = New System.Windows.Forms.SplitContainer()
        Me.IListFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.ITable = New System.Windows.Forms.TableLayoutPanel()
        Me.IBox = New System.Windows.Forms.PictureBox()
        Me.ToFirstButton = New System.Windows.Forms.Button()
        Me.ToPreviousButton = New System.Windows.Forms.Button()
        Me.ToCenterButton = New System.Windows.Forms.Button()
        Me.ToNextButton = New System.Windows.Forms.Button()
        Me.ToLastButton = New System.Windows.Forms.Button()
        Me.IInfoLabel = New System.Windows.Forms.Label()
        Me.ICommentsLabel = New System.Windows.Forms.Label()
        Me.OpenFolderButton = New System.Windows.Forms.ToolStripButton()
        Me.IViewList = New System.Windows.Forms.ImageList(Me.components)
        Me.IStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IViewCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IIndexLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListSettingButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ISizeModeButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LMovementButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.IZoomButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.IMoveButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.IRoleButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ViewSettingButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LMakingButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdvanceButton = New System.Windows.Forms.ToolStripButton()
        Me.SpanLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IViewTools.SuspendLayout()
        Me.IViewStatus.SuspendLayout()
        CType(Me.IViewSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IViewSpliter.Panel1.SuspendLayout()
        Me.IViewSpliter.Panel2.SuspendLayout()
        Me.IViewSpliter.SuspendLayout()
        CType(Me.ISpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ISpliter.Panel1.SuspendLayout()
        Me.ISpliter.Panel2.SuspendLayout()
        Me.ISpliter.SuspendLayout()
        Me.ITable.SuspendLayout()
        CType(Me.IBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IViewTools
        '
        Me.IViewTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.IViewTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFolderButton, Me.ToolStripSeparator1, Me.LMakingButton, Me.LMovementButton, Me.ListSettingButton, Me.ToolStripSeparator2, Me.ISizeModeButton, Me.IZoomButton, Me.IMoveButton, Me.IRoleButton, Me.ViewSettingButton, Me.ToolStripSeparator3, Me.AdvanceButton})
        Me.IViewTools.Location = New System.Drawing.Point(0, 0)
        Me.IViewTools.Name = "IViewTools"
        Me.IViewTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.IViewTools.Size = New System.Drawing.Size(322, 25)
        Me.IViewTools.TabIndex = 0
        Me.IViewTools.Text = "ToolStrip1"
        '
        'IViewStatus
        '
        Me.IViewStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IStatusLabel, Me.IViewCountLabel, Me.IIndexLabel, Me.SpanLabel})
        Me.IViewStatus.Location = New System.Drawing.Point(0, 232)
        Me.IViewStatus.Name = "IViewStatus"
        Me.IViewStatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.IViewStatus.Size = New System.Drawing.Size(322, 26)
        Me.IViewStatus.TabIndex = 1
        Me.IViewStatus.Text = "StatusStrip1"
        '
        'IViewSpliter
        '
        Me.IViewSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IViewSpliter.Location = New System.Drawing.Point(0, 25)
        Me.IViewSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IViewSpliter.Name = "IViewSpliter"
        '
        'IViewSpliter.Panel1
        '
        Me.IViewSpliter.Panel1.Controls.Add(Me.IListFlow)
        '
        'IViewSpliter.Panel2
        '
        Me.IViewSpliter.Panel2.Controls.Add(Me.ISpliter)
        Me.IViewSpliter.Size = New System.Drawing.Size(322, 207)
        Me.IViewSpliter.SplitterDistance = 107
        Me.IViewSpliter.TabIndex = 2
        '
        'ISpliter
        '
        Me.ISpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ISpliter.Location = New System.Drawing.Point(0, 0)
        Me.ISpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ISpliter.Name = "ISpliter"
        Me.ISpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ISpliter.Panel1
        '
        Me.ISpliter.Panel1.Controls.Add(Me.IBox)
        Me.ISpliter.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'ISpliter.Panel2
        '
        Me.ISpliter.Panel2.Controls.Add(Me.ITable)
        Me.ISpliter.Size = New System.Drawing.Size(211, 207)
        Me.ISpliter.SplitterDistance = 135
        Me.ISpliter.SplitterWidth = 2
        Me.ISpliter.TabIndex = 0
        '
        'IListFlow
        '
        Me.IListFlow.AllowDrop = True
        Me.IListFlow.AutoScroll = True
        Me.IListFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IListFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.IListFlow.Location = New System.Drawing.Point(0, 0)
        Me.IListFlow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IListFlow.Name = "IListFlow"
        Me.IListFlow.Size = New System.Drawing.Size(107, 207)
        Me.IListFlow.TabIndex = 0
        Me.IListFlow.WrapContents = False
        '
        'ITable
        '
        Me.ITable.ColumnCount = 5
        Me.ITable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ITable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ITable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ITable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ITable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ITable.Controls.Add(Me.ToFirstButton, 0, 0)
        Me.ITable.Controls.Add(Me.ToPreviousButton, 1, 0)
        Me.ITable.Controls.Add(Me.ToCenterButton, 2, 0)
        Me.ITable.Controls.Add(Me.ToNextButton, 3, 0)
        Me.ITable.Controls.Add(Me.ToLastButton, 4, 0)
        Me.ITable.Controls.Add(Me.IInfoLabel, 0, 1)
        Me.ITable.Controls.Add(Me.ICommentsLabel, 3, 1)
        Me.ITable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITable.Location = New System.Drawing.Point(0, 0)
        Me.ITable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ITable.Name = "ITable"
        Me.ITable.RowCount = 2
        Me.ITable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ITable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ITable.Size = New System.Drawing.Size(211, 70)
        Me.ITable.TabIndex = 0
        '
        'IBox
        '
        Me.IBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IBox.Location = New System.Drawing.Point(5, 5)
        Me.IBox.Margin = New System.Windows.Forms.Padding(0)
        Me.IBox.Name = "IBox"
        Me.IBox.Size = New System.Drawing.Size(201, 125)
        Me.IBox.TabIndex = 0
        Me.IBox.TabStop = False
        '
        'ToFirstButton
        '
        Me.ToFirstButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToFirstButton.FlatAppearance.BorderSize = 0
        Me.ToFirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToFirstButton.Location = New System.Drawing.Point(0, 0)
        Me.ToFirstButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ToFirstButton.Name = "ToFirstButton"
        Me.ToFirstButton.Size = New System.Drawing.Size(42, 24)
        Me.ToFirstButton.TabIndex = 0
        Me.ToFirstButton.UseVisualStyleBackColor = True
        '
        'ToPreviousButton
        '
        Me.ToPreviousButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToPreviousButton.FlatAppearance.BorderSize = 0
        Me.ToPreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToPreviousButton.Location = New System.Drawing.Point(42, 0)
        Me.ToPreviousButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ToPreviousButton.Name = "ToPreviousButton"
        Me.ToPreviousButton.Size = New System.Drawing.Size(42, 24)
        Me.ToPreviousButton.TabIndex = 1
        Me.ToPreviousButton.UseVisualStyleBackColor = True
        '
        'ToCenterButton
        '
        Me.ToCenterButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToCenterButton.FlatAppearance.BorderSize = 0
        Me.ToCenterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToCenterButton.Location = New System.Drawing.Point(84, 0)
        Me.ToCenterButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ToCenterButton.Name = "ToCenterButton"
        Me.ToCenterButton.Size = New System.Drawing.Size(42, 24)
        Me.ToCenterButton.TabIndex = 2
        Me.ToCenterButton.UseVisualStyleBackColor = True
        '
        'ToNextButton
        '
        Me.ToNextButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToNextButton.FlatAppearance.BorderSize = 0
        Me.ToNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToNextButton.Location = New System.Drawing.Point(126, 0)
        Me.ToNextButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ToNextButton.Name = "ToNextButton"
        Me.ToNextButton.Size = New System.Drawing.Size(42, 24)
        Me.ToNextButton.TabIndex = 3
        Me.ToNextButton.UseVisualStyleBackColor = True
        '
        'ToLastButton
        '
        Me.ToLastButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToLastButton.FlatAppearance.BorderSize = 0
        Me.ToLastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToLastButton.Location = New System.Drawing.Point(168, 0)
        Me.ToLastButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ToLastButton.Name = "ToLastButton"
        Me.ToLastButton.Size = New System.Drawing.Size(43, 24)
        Me.ToLastButton.TabIndex = 4
        Me.ToLastButton.UseVisualStyleBackColor = True
        '
        'IInfoLabel
        '
        Me.IInfoLabel.AutoSize = True
        Me.ITable.SetColumnSpan(Me.IInfoLabel, 3)
        Me.IInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IInfoLabel.Location = New System.Drawing.Point(3, 24)
        Me.IInfoLabel.Name = "IInfoLabel"
        Me.IInfoLabel.Size = New System.Drawing.Size(120, 46)
        Me.IInfoLabel.TabIndex = 5
        Me.IInfoLabel.Text = "Label1"
        '
        'ICommentsLabel
        '
        Me.ICommentsLabel.AutoSize = True
        Me.ITable.SetColumnSpan(Me.ICommentsLabel, 2)
        Me.ICommentsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ICommentsLabel.Location = New System.Drawing.Point(129, 24)
        Me.ICommentsLabel.Name = "ICommentsLabel"
        Me.ICommentsLabel.Size = New System.Drawing.Size(79, 46)
        Me.ICommentsLabel.TabIndex = 6
        Me.ICommentsLabel.Text = "Label2"
        '
        'OpenFolderButton
        '
        Me.OpenFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenFolderButton.Image = CType(resources.GetObject("OpenFolderButton.Image"), System.Drawing.Image)
        Me.OpenFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenFolderButton.Name = "OpenFolderButton"
        Me.OpenFolderButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenFolderButton.Text = "OpenFolder"
        Me.OpenFolderButton.ToolTipText = "Open folder to get image list"
        '
        'IViewList
        '
        Me.IViewList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IViewList.ImageSize = New System.Drawing.Size(16, 16)
        Me.IViewList.TransparentColor = System.Drawing.Color.Transparent
        '
        'IStatusLabel
        '
        Me.IStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.IStatusLabel.Name = "IStatusLabel"
        Me.IStatusLabel.Size = New System.Drawing.Size(17, 21)
        Me.IStatusLabel.Text = "*"
        '
        'IViewCountLabel
        '
        Me.IViewCountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.IViewCountLabel.Name = "IViewCountLabel"
        Me.IViewCountLabel.Size = New System.Drawing.Size(19, 21)
        Me.IViewCountLabel.Text = "0"
        '
        'IIndexLabel
        '
        Me.IIndexLabel.Name = "IIndexLabel"
        Me.IIndexLabel.Size = New System.Drawing.Size(15, 21)
        Me.IIndexLabel.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ListSettingButton
        '
        Me.ListSettingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListSettingButton.Image = CType(resources.GetObject("ListSettingButton.Image"), System.Drawing.Image)
        Me.ListSettingButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ListSettingButton.Name = "ListSettingButton"
        Me.ListSettingButton.Size = New System.Drawing.Size(23, 22)
        Me.ListSettingButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ISizeModeButton
        '
        Me.ISizeModeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ISizeModeButton.Image = CType(resources.GetObject("ISizeModeButton.Image"), System.Drawing.Image)
        Me.ISizeModeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ISizeModeButton.Name = "ISizeModeButton"
        Me.ISizeModeButton.ShowDropDownArrow = False
        Me.ISizeModeButton.Size = New System.Drawing.Size(20, 22)
        Me.ISizeModeButton.Text = "ToolStripButton1"
        '
        'LMovementButton
        '
        Me.LMovementButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LMovementButton.Image = CType(resources.GetObject("LMovementButton.Image"), System.Drawing.Image)
        Me.LMovementButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LMovementButton.Name = "LMovementButton"
        Me.LMovementButton.ShowDropDownArrow = False
        Me.LMovementButton.Size = New System.Drawing.Size(20, 22)
        Me.LMovementButton.Text = "ToolStripButton1"
        '
        'IZoomButton
        '
        Me.IZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IZoomButton.Image = CType(resources.GetObject("IZoomButton.Image"), System.Drawing.Image)
        Me.IZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IZoomButton.Name = "IZoomButton"
        Me.IZoomButton.ShowDropDownArrow = False
        Me.IZoomButton.Size = New System.Drawing.Size(20, 22)
        Me.IZoomButton.Text = "ToolStripButton2"
        '
        'IMoveButton
        '
        Me.IMoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IMoveButton.Image = CType(resources.GetObject("IMoveButton.Image"), System.Drawing.Image)
        Me.IMoveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IMoveButton.Name = "IMoveButton"
        Me.IMoveButton.ShowDropDownArrow = False
        Me.IMoveButton.Size = New System.Drawing.Size(20, 22)
        Me.IMoveButton.Text = "ToolStripButton1"
        '
        'IRoleButton
        '
        Me.IRoleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IRoleButton.Image = CType(resources.GetObject("IRoleButton.Image"), System.Drawing.Image)
        Me.IRoleButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IRoleButton.Name = "IRoleButton"
        Me.IRoleButton.ShowDropDownArrow = False
        Me.IRoleButton.Size = New System.Drawing.Size(20, 22)
        Me.IRoleButton.Text = "ToolStripButton2"
        '
        'ViewSettingButton
        '
        Me.ViewSettingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViewSettingButton.Image = CType(resources.GetObject("ViewSettingButton.Image"), System.Drawing.Image)
        Me.ViewSettingButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewSettingButton.Name = "ViewSettingButton"
        Me.ViewSettingButton.ShowDropDownArrow = False
        Me.ViewSettingButton.Size = New System.Drawing.Size(20, 22)
        Me.ViewSettingButton.Text = "ToolStripDropDownButton1"
        '
        'LMakingButton
        '
        Me.LMakingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LMakingButton.Image = CType(resources.GetObject("LMakingButton.Image"), System.Drawing.Image)
        Me.LMakingButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LMakingButton.Name = "LMakingButton"
        Me.LMakingButton.ShowDropDownArrow = False
        Me.LMakingButton.Size = New System.Drawing.Size(20, 22)
        Me.LMakingButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'AdvanceButton
        '
        Me.AdvanceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdvanceButton.Image = CType(resources.GetObject("AdvanceButton.Image"), System.Drawing.Image)
        Me.AdvanceButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdvanceButton.Name = "AdvanceButton"
        Me.AdvanceButton.Size = New System.Drawing.Size(23, 22)
        Me.AdvanceButton.Text = "ToolStripButton1"
        '
        'SpanLabel
        '
        Me.SpanLabel.Name = "SpanLabel"
        Me.SpanLabel.Size = New System.Drawing.Size(13, 21)
        Me.SpanLabel.Text = "-"
        '
        'KzImageView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IViewSpliter)
        Me.Controls.Add(Me.IViewStatus)
        Me.Controls.Add(Me.IViewTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzImageView"
        Me.Size = New System.Drawing.Size(322, 258)
        Me.IViewTools.ResumeLayout(False)
        Me.IViewTools.PerformLayout()
        Me.IViewStatus.ResumeLayout(False)
        Me.IViewStatus.PerformLayout()
        Me.IViewSpliter.Panel1.ResumeLayout(False)
        Me.IViewSpliter.Panel2.ResumeLayout(False)
        CType(Me.IViewSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IViewSpliter.ResumeLayout(False)
        Me.ISpliter.Panel1.ResumeLayout(False)
        Me.ISpliter.Panel2.ResumeLayout(False)
        CType(Me.ISpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ISpliter.ResumeLayout(False)
        Me.ITable.ResumeLayout(False)
        Me.ITable.PerformLayout()
        CType(Me.IBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IViewTools As ToolStrip
    Friend WithEvents IViewStatus As StatusStrip
    Friend WithEvents IViewSpliter As SplitContainer
    Friend WithEvents IListFlow As FlowLayoutPanel
    Friend WithEvents ISpliter As SplitContainer
    Friend WithEvents IBox As PictureBox
    Friend WithEvents ITable As TableLayoutPanel
    Friend WithEvents OpenFolderButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LMakingButton As ToolStripDropDownButton
    Friend WithEvents LMovementButton As ToolStripDropDownButton
    Friend WithEvents ListSettingButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ISizeModeButton As ToolStripDropDownButton
    Friend WithEvents IZoomButton As ToolStripDropDownButton
    Friend WithEvents IMoveButton As ToolStripDropDownButton
    Friend WithEvents IRoleButton As ToolStripDropDownButton
    Friend WithEvents ViewSettingButton As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AdvanceButton As ToolStripButton
    Friend WithEvents IStatusLabel As ToolStripStatusLabel
    Friend WithEvents IViewCountLabel As ToolStripStatusLabel
    Friend WithEvents IIndexLabel As ToolStripStatusLabel
    Friend WithEvents SpanLabel As ToolStripStatusLabel
    Friend WithEvents ToFirstButton As Button
    Friend WithEvents ToPreviousButton As Button
    Friend WithEvents ToCenterButton As Button
    Friend WithEvents ToNextButton As Button
    Friend WithEvents ToLastButton As Button
    Friend WithEvents IInfoLabel As Label
    Friend WithEvents ICommentsLabel As Label
    Friend WithEvents IViewList As ImageList
End Class
