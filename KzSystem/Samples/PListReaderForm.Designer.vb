<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PListReaderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PListReaderForm))
        Me.RootStatus = New System.Windows.Forms.StatusStrip()
        Me.RootTools = New System.Windows.Forms.ToolStrip()
        Me.PListView = New System.Windows.Forms.ListView()
        Me.OpenButton = New System.Windows.Forms.ToolStripButton()
        Me.FileNameLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.KeyColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValueColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RootStatus.SuspendLayout()
        Me.RootTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootStatus
        '
        Me.RootStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNameLabel})
        Me.RootStatus.Location = New System.Drawing.Point(0, 239)
        Me.RootStatus.Name = "RootStatus"
        Me.RootStatus.Size = New System.Drawing.Size(284, 22)
        Me.RootStatus.TabIndex = 0
        Me.RootStatus.Text = "StatusStrip1"
        '
        'RootTools
        '
        Me.RootTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenButton})
        Me.RootTools.Location = New System.Drawing.Point(0, 0)
        Me.RootTools.Name = "RootTools"
        Me.RootTools.Size = New System.Drawing.Size(284, 25)
        Me.RootTools.TabIndex = 1
        Me.RootTools.Text = "ToolStrip1"
        '
        'PListView
        '
        Me.PListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.KeyColumn, Me.ValueColumn, Me.TypeColumn})
        Me.PListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PListView.Location = New System.Drawing.Point(0, 25)
        Me.PListView.Name = "PListView"
        Me.PListView.Size = New System.Drawing.Size(284, 214)
        Me.PListView.TabIndex = 2
        Me.PListView.UseCompatibleStateImageBehavior = False
        Me.PListView.View = System.Windows.Forms.View.Details
        '
        'OpenButton
        '
        Me.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenButton.Image = CType(resources.GetObject("OpenButton.Image"), System.Drawing.Image)
        Me.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenButton.Text = "ToolStripButton1"
        '
        'FileNameLabel
        '
        Me.FileNameLabel.Name = "FileNameLabel"
        Me.FileNameLabel.Size = New System.Drawing.Size(62, 17)
        Me.FileNameLabel.Text = "<no file>"
        '
        'KeyColumn
        '
        Me.KeyColumn.Text = "Key"
        '
        'ValueColumn
        '
        Me.ValueColumn.Text = "Value"
        '
        'TypeColumn
        '
        Me.TypeColumn.Text = "Type"
        '
        'PListReaderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.PListView)
        Me.Controls.Add(Me.RootTools)
        Me.Controls.Add(Me.RootStatus)
        Me.Name = "PListReaderForm"
        Me.Text = "PListReaderForm"
        Me.RootStatus.ResumeLayout(False)
        Me.RootStatus.PerformLayout()
        Me.RootTools.ResumeLayout(False)
        Me.RootTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootStatus As StatusStrip
    Friend WithEvents RootTools As ToolStrip
    Friend WithEvents PListView As ListView
    Friend WithEvents OpenButton As ToolStripButton
    Friend WithEvents FileNameLabel As ToolStripStatusLabel
    Friend WithEvents KeyColumn As ColumnHeader
    Friend WithEvents ValueColumn As ColumnHeader
    Friend WithEvents TypeColumn As ColumnHeader
End Class
