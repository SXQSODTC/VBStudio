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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.RootSpliter.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.RootSpliter.Panel2.Controls.Add(Me.InfoLabel)
        Me.RootSpliter.Size = New System.Drawing.Size(556, 298)
        Me.RootSpliter.SplitterDistance = 267
        Me.RootSpliter.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(3, 9)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(41, 12)
        Me.InfoLabel.TabIndex = 0
        Me.InfoLabel.Text = "Label1"
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrackBar1.Location = New System.Drawing.Point(0, 0)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(199, 30)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.Value = 128
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TrackBar1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 237)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(285, 61)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TestListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 298)
        Me.Controls.Add(Me.RootSpliter)
        Me.Name = "TestListForm"
        Me.Text = "TestListForm"
        Me.RootSpliter.Panel2.ResumeLayout(False)
        Me.RootSpliter.Panel2.PerformLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents InfoLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TrackBar1 As TrackBar
End Class
