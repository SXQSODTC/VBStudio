<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzPadingSetter
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
        Me.LeftUD = New System.Windows.Forms.NumericUpDown()
        Me.TopUD = New System.Windows.Forms.NumericUpDown()
        Me.RightUD = New System.Windows.Forms.NumericUpDown()
        Me.BottomUD = New System.Windows.Forms.NumericUpDown()
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AllUD = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LeftUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootPanel.SuspendLayout()
        CType(Me.AllUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftUD
        '
        Me.LeftUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftUD.Location = New System.Drawing.Point(40, 14)
        Me.LeftUD.Margin = New System.Windows.Forms.Padding(0)
        Me.LeftUD.Name = "LeftUD"
        Me.LeftUD.Size = New System.Drawing.Size(40, 22)
        Me.LeftUD.TabIndex = 0
        Me.LeftUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TopUD
        '
        Me.TopUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopUD.Location = New System.Drawing.Point(80, 14)
        Me.TopUD.Margin = New System.Windows.Forms.Padding(0)
        Me.TopUD.Name = "TopUD"
        Me.TopUD.Size = New System.Drawing.Size(40, 22)
        Me.TopUD.TabIndex = 1
        Me.TopUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightUD
        '
        Me.RightUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightUD.Location = New System.Drawing.Point(120, 14)
        Me.RightUD.Margin = New System.Windows.Forms.Padding(0)
        Me.RightUD.Name = "RightUD"
        Me.RightUD.Size = New System.Drawing.Size(40, 22)
        Me.RightUD.TabIndex = 2
        Me.RightUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BottomUD
        '
        Me.BottomUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomUD.Location = New System.Drawing.Point(160, 14)
        Me.BottomUD.Margin = New System.Windows.Forms.Padding(0)
        Me.BottomUD.Name = "BottomUD"
        Me.BottomUD.Size = New System.Drawing.Size(42, 22)
        Me.BottomUD.TabIndex = 3
        Me.BottomUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 5
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RootPanel.Controls.Add(Me.Label5, 4, 0)
        Me.RootPanel.Controls.Add(Me.Label4, 3, 0)
        Me.RootPanel.Controls.Add(Me.Label3, 2, 0)
        Me.RootPanel.Controls.Add(Me.Label2, 1, 0)
        Me.RootPanel.Controls.Add(Me.AllUD, 0, 1)
        Me.RootPanel.Controls.Add(Me.BottomUD, 4, 1)
        Me.RootPanel.Controls.Add(Me.LeftUD, 1, 1)
        Me.RootPanel.Controls.Add(Me.RightUD, 3, 1)
        Me.RootPanel.Controls.Add(Me.TopUD, 2, 1)
        Me.RootPanel.Controls.Add(Me.Label1, 0, 0)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 2
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.Size = New System.Drawing.Size(202, 36)
        Me.RootPanel.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bottom"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Right"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Top"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Left"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AllUD
        '
        Me.AllUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllUD.Location = New System.Drawing.Point(0, 14)
        Me.AllUD.Margin = New System.Windows.Forms.Padding(0)
        Me.AllUD.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.AllUD.Name = "AllUD"
        Me.AllUD.Size = New System.Drawing.Size(40, 22)
        Me.AllUD.TabIndex = 5
        Me.AllUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "All"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'KzPadingSetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "KzPadingSetter"
        Me.Size = New System.Drawing.Size(202, 36)
        CType(Me.LeftUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.AllUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftUD As NumericUpDown
    Friend WithEvents TopUD As NumericUpDown
    Friend WithEvents RightUD As NumericUpDown
    Friend WithEvents BottomUD As NumericUpDown
    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents AllUD As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
