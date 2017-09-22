<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzLogPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzLogPanel))
        Me.LogStatus = New System.Windows.Forms.StatusStrip()
        Me.LogTools = New System.Windows.Forms.ToolStrip()
        Me.LogBox = New System.Windows.Forms.TextBox()
        Me.LinesStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ReadButton = New System.Windows.Forms.ToolStripButton()
        Me.WriteButton = New System.Windows.Forms.ToolStripButton()
        Me.FileButton = New System.Windows.Forms.ToolStripButton()
        Me.AppenButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearButton = New System.Windows.Forms.ToolStripButton()
        Me.IndexStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatButton = New System.Windows.Forms.ToolStripButton()
        Me.LogStatus.SuspendLayout()
        Me.LogTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogStatus
        '
        Me.LogStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexStatus, Me.LinesStatus})
        Me.LogStatus.Location = New System.Drawing.Point(0, 149)
        Me.LogStatus.Name = "LogStatus"
        Me.LogStatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.LogStatus.Size = New System.Drawing.Size(276, 26)
        Me.LogStatus.TabIndex = 0
        Me.LogStatus.Text = "StatusStrip1"
        '
        'LogTools
        '
        Me.LogTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LogTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileButton, Me.ReadButton, Me.WriteButton, Me.AppenButton, Me.ToolStripSeparator1, Me.ClearButton, Me.ToolStripSeparator2, Me.FormatButton})
        Me.LogTools.Location = New System.Drawing.Point(0, 0)
        Me.LogTools.Name = "LogTools"
        Me.LogTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.LogTools.Size = New System.Drawing.Size(276, 25)
        Me.LogTools.TabIndex = 1
        Me.LogTools.Text = "ToolStrip1"
        '
        'LogBox
        '
        Me.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogBox.Location = New System.Drawing.Point(0, 25)
        Me.LogBox.Multiline = True
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LogBox.Size = New System.Drawing.Size(276, 124)
        Me.LogBox.TabIndex = 2
        '
        'LinesStatus
        '
        Me.LinesStatus.Name = "LinesStatus"
        Me.LinesStatus.Size = New System.Drawing.Size(39, 21)
        Me.LinesStatus.Text = "0 line"
        '
        'ReadButton
        '
        Me.ReadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReadButton.Image = CType(resources.GetObject("ReadButton.Image"), System.Drawing.Image)
        Me.ReadButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(23, 22)
        Me.ReadButton.Text = "ToolStripButton1"
        '
        'WriteButton
        '
        Me.WriteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WriteButton.Image = CType(resources.GetObject("WriteButton.Image"), System.Drawing.Image)
        Me.WriteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WriteButton.Name = "WriteButton"
        Me.WriteButton.Size = New System.Drawing.Size(23, 22)
        Me.WriteButton.Text = "ToolStripButton1"
        '
        'FileButton
        '
        Me.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FileButton.Image = CType(resources.GetObject("FileButton.Image"), System.Drawing.Image)
        Me.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New System.Drawing.Size(23, 22)
        Me.FileButton.Text = "ToolStripButton1"
        '
        'AppenButton
        '
        Me.AppenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AppenButton.Image = CType(resources.GetObject("AppenButton.Image"), System.Drawing.Image)
        Me.AppenButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AppenButton.Name = "AppenButton"
        Me.AppenButton.Size = New System.Drawing.Size(23, 22)
        Me.AppenButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ClearButton
        '
        Me.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearButton.Image = CType(resources.GetObject("ClearButton.Image"), System.Drawing.Image)
        Me.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(23, 22)
        Me.ClearButton.Text = "ToolStripButton1"
        '
        'IndexStatus
        '
        Me.IndexStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.IndexStatus.Name = "IndexStatus"
        Me.IndexStatus.Size = New System.Drawing.Size(34, 21)
        Me.IndexStatus.Text = "Log"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FormatButton
        '
        Me.FormatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FormatButton.Image = CType(resources.GetObject("FormatButton.Image"), System.Drawing.Image)
        Me.FormatButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FormatButton.Name = "FormatButton"
        Me.FormatButton.Size = New System.Drawing.Size(23, 22)
        Me.FormatButton.Text = "ToolStripButton1"
        '
        'KzLogPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.LogTools)
        Me.Controls.Add(Me.LogStatus)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "KzLogPanel"
        Me.Size = New System.Drawing.Size(276, 175)
        Me.LogStatus.ResumeLayout(False)
        Me.LogStatus.PerformLayout()
        Me.LogTools.ResumeLayout(False)
        Me.LogTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogStatus As StatusStrip
    Friend WithEvents LinesStatus As ToolStripStatusLabel
    Friend WithEvents LogTools As ToolStrip
    Friend WithEvents LogBox As TextBox
    Friend WithEvents IndexStatus As ToolStripStatusLabel
    Friend WithEvents FileButton As ToolStripButton
    Friend WithEvents ReadButton As ToolStripButton
    Friend WithEvents WriteButton As ToolStripButton
    Friend WithEvents AppenButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClearButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FormatButton As ToolStripButton
End Class
