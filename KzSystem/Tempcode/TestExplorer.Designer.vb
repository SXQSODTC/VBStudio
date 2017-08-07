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
        Me.KzExplorer1 = New KzSystem.KzExplorer()
        Me.SuspendLayout()
        '
        'KzExplorer1
        '
        Me.KzExplorer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzExplorer1.Location = New System.Drawing.Point(0, 0)
        Me.KzExplorer1.Name = "KzExplorer1"
        Me.KzExplorer1.Size = New System.Drawing.Size(284, 261)
        Me.KzExplorer1.TabIndex = 0
        '
        'TestExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.KzExplorer1)
        Me.Name = "TestExplorer"
        Me.Text = "TestExplorer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KzExplorer1 As KzExplorer
End Class
