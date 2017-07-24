<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzColorPicker
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.RootStatus = New System.Windows.Forms.StatusStrip()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.KzColorListPanel1 = New KzSystem.KzColorListPanel()
        Me.RightSpliter = New System.Windows.Forms.SplitContainer()
        Me.RTopSpliter = New System.Windows.Forms.SplitContainer()
        Me.OpTabControl = New System.Windows.Forms.TabControl()
        Me.KnownColorTab = New System.Windows.Forms.TabPage()
        Me.CombineTab = New System.Windows.Forms.TabPage()
        Me.ToningTab = New System.Windows.Forms.TabPage()
        Me.KzTrackBar1 = New KzSystem.KzTrackBar()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.RightSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightSpliter.Panel1.SuspendLayout()
        Me.RightSpliter.Panel2.SuspendLayout()
        Me.RightSpliter.SuspendLayout()
        CType(Me.RTopSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RTopSpliter.SuspendLayout()
        Me.OpTabControl.SuspendLayout()
        Me.KnownColorTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootTools
        '
        Me.RootTools.Location = New System.Drawing.Point(0, 0)
        Me.RootTools.Name = "RootTools"
        Me.RootTools.Size = New System.Drawing.Size(813, 25)
        Me.RootTools.TabIndex = 0
        Me.RootTools.Text = "ToolStrip1"
        '
        'RootStatus
        '
        Me.RootStatus.Location = New System.Drawing.Point(0, 427)
        Me.RootStatus.Name = "RootStatus"
        Me.RootStatus.Size = New System.Drawing.Size(813, 22)
        Me.RootStatus.TabIndex = 1
        Me.RootStatus.Text = "StatusStrip1"
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 25)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.KzColorListPanel1)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.RightSpliter)
        Me.RootSpliter.Size = New System.Drawing.Size(813, 402)
        Me.RootSpliter.SplitterDistance = 312
        Me.RootSpliter.TabIndex = 2
        '
        'KzColorListPanel1
        '
        Me.KzColorListPanel1.AutoScroll = True
        Me.KzColorListPanel1.BackColor = System.Drawing.Color.DarkGray
        Me.KzColorListPanel1.DefaultColorListType = KzSystem.KzColorListType.None
        Me.KzColorListPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzColorListPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.KzColorListPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KzColorListPanel1.Name = "KzColorListPanel1"
        Me.KzColorListPanel1.Size = New System.Drawing.Size(312, 402)
        Me.KzColorListPanel1.TabIndex = 0
        Me.KzColorListPanel1.WrapContents = False
        '
        'RightSpliter
        '
        Me.RightSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RightSpliter.Name = "RightSpliter"
        Me.RightSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'RightSpliter.Panel1
        '
        Me.RightSpliter.Panel1.Controls.Add(Me.RTopSpliter)
        '
        'RightSpliter.Panel2
        '
        Me.RightSpliter.Panel2.Controls.Add(Me.OpTabControl)
        Me.RightSpliter.Size = New System.Drawing.Size(497, 402)
        Me.RightSpliter.SplitterDistance = 160
        Me.RightSpliter.TabIndex = 0
        '
        'RTopSpliter
        '
        Me.RTopSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTopSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RTopSpliter.Name = "RTopSpliter"
        Me.RTopSpliter.Size = New System.Drawing.Size(497, 160)
        Me.RTopSpliter.SplitterDistance = 339
        Me.RTopSpliter.TabIndex = 0
        '
        'OpTabControl
        '
        Me.OpTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.OpTabControl.Controls.Add(Me.KnownColorTab)
        Me.OpTabControl.Controls.Add(Me.CombineTab)
        Me.OpTabControl.Controls.Add(Me.ToningTab)
        Me.OpTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpTabControl.Location = New System.Drawing.Point(0, 0)
        Me.OpTabControl.Name = "OpTabControl"
        Me.OpTabControl.SelectedIndex = 0
        Me.OpTabControl.Size = New System.Drawing.Size(497, 238)
        Me.OpTabControl.TabIndex = 0
        '
        'KnownColorTab
        '
        Me.KnownColorTab.Controls.Add(Me.KzTrackBar1)
        Me.KnownColorTab.Location = New System.Drawing.Point(4, 4)
        Me.KnownColorTab.Name = "KnownColorTab"
        Me.KnownColorTab.Padding = New System.Windows.Forms.Padding(3)
        Me.KnownColorTab.Size = New System.Drawing.Size(489, 208)
        Me.KnownColorTab.TabIndex = 0
        Me.KnownColorTab.Text = "Known"
        Me.KnownColorTab.UseVisualStyleBackColor = True
        '
        'CombineTab
        '
        Me.CombineTab.Location = New System.Drawing.Point(4, 4)
        Me.CombineTab.Name = "CombineTab"
        Me.CombineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CombineTab.Size = New System.Drawing.Size(251, 111)
        Me.CombineTab.TabIndex = 1
        Me.CombineTab.Text = "Combine"
        Me.CombineTab.UseVisualStyleBackColor = True
        '
        'ToningTab
        '
        Me.ToningTab.Location = New System.Drawing.Point(4, 4)
        Me.ToningTab.Name = "ToningTab"
        Me.ToningTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ToningTab.Size = New System.Drawing.Size(251, 111)
        Me.ToningTab.TabIndex = 2
        Me.ToningTab.Text = "Toning"
        Me.ToningTab.UseVisualStyleBackColor = True
        '
        'KzTrackBar1
        '
        Me.KzTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.KzTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.KzTrackBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KzTrackBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.KzTrackBar1.IndentHeight = 6
        Me.KzTrackBar1.Location = New System.Drawing.Point(6, 33)
        Me.KzTrackBar1.Maximum = 255
        Me.KzTrackBar1.Minimum = 0
        Me.KzTrackBar1.Name = "KzTrackBar1"
        Me.KzTrackBar1.Size = New System.Drawing.Size(217, 31)
        Me.KzTrackBar1.TabIndex = 0
        Me.KzTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None
        Me.KzTrackBar1.TickColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.KzTrackBar1.TickFrequency = 15
        Me.KzTrackBar1.TickHeight = 2
        Me.KzTrackBar1.TrackerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KzTrackBar1.TrackerSize = New System.Drawing.Size(10, 16)
        Me.KzTrackBar1.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.KzTrackBar1.TrackLineHeight = 3
        Me.KzTrackBar1.Value = 0
        '
        'KzColorPicker
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(813, 449)
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootStatus)
        Me.Controls.Add(Me.RootTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "KzColorPicker"
        Me.Text = "KzColorPicker"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.RightSpliter.Panel1.ResumeLayout(False)
        Me.RightSpliter.Panel2.ResumeLayout(False)
        CType(Me.RightSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightSpliter.ResumeLayout(False)
        CType(Me.RTopSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RTopSpliter.ResumeLayout(False)
        Me.OpTabControl.ResumeLayout(False)
        Me.KnownColorTab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootTools As ToolStrip
    Friend WithEvents RootStatus As StatusStrip
    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents KzColorListPanel1 As KzColorListPanel
    Friend WithEvents RightSpliter As SplitContainer
    Friend WithEvents RTopSpliter As SplitContainer
    Friend WithEvents OpTabControl As TabControl
    Friend WithEvents KnownColorTab As TabPage
    Friend WithEvents CombineTab As TabPage
    Friend WithEvents ToningTab As TabPage
    Friend WithEvents KzTrackBar1 As KzTrackBar
End Class
