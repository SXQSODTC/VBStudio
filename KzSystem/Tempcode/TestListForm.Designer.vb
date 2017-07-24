<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestListForm
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
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.InfoLabel = New System.Windows.Forms.Label()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.InfoLabel)
        Me.RootSpliter.Size = New System.Drawing.Size(439, 261)
        Me.RootSpliter.SplitterDistance = 211
        Me.RootSpliter.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(31, 124)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(41, 12)
        Me.InfoLabel.TabIndex = 0
        Me.InfoLabel.Text = "Label1"
        '
        'TestListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 261)
        Me.Controls.Add(Me.RootSpliter)
        Me.Name = "TestListForm"
        Me.Text = "TestListForm"
        Me.RootSpliter.Panel2.ResumeLayout(False)
        Me.RootSpliter.Panel2.PerformLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents InfoLabel As Label
End Class
