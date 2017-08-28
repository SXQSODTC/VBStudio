<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestExplorer
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
        Me.RgbSticker1 = New KzSystem.RGBSticker()
        Me.KzExplorer1 = New KzSystem.KzExplorer()
        Me.SuspendLayout()
        '
        'RgbSticker1
        '
        Me.RgbSticker1.Checked = False
        Me.RgbSticker1.Color = System.Drawing.Color.Peru
        Me.RgbSticker1.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.RgbSticker1.Location = New System.Drawing.Point(217, 104)
        Me.RgbSticker1.Name = "RgbSticker1"
        Me.RgbSticker1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RgbSticker1.ShowDetail = True
        Me.RgbSticker1.Size = New System.Drawing.Size(225, 45)
        Me.RgbSticker1.TabIndex = 1
        Me.RgbSticker1.Text = "Peru"
        '
        'KzExplorer1
        '
        Me.KzExplorer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzExplorer1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.KzExplorer1.Location = New System.Drawing.Point(0, 0)
        Me.KzExplorer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KzExplorer1.Name = "KzExplorer1"
        Me.KzExplorer1.Size = New System.Drawing.Size(527, 261)
        Me.KzExplorer1.TabIndex = 0
        '
        'TestExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 261)
        Me.Controls.Add(Me.RgbSticker1)
        Me.Controls.Add(Me.KzExplorer1)
        Me.Name = "TestExplorer"
        Me.Text = "TestExplorer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KzExplorer1 As KzExplorer
    Friend WithEvents RgbSticker1 As RGBSticker
End Class
