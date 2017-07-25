<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzSlideBar
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
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Bar = New System.Windows.Forms.TrackBar()
        Me.NumberUD = New System.Windows.Forms.NumericUpDown()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.RootPanel.SuspendLayout()
        CType(Me.Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.RootPanel.Controls.Add(Me.Bar, 1, 0)
        Me.RootPanel.Controls.Add(Me.NumberUD, 2, 0)
        Me.RootPanel.Controls.Add(Me.TitleLabel, 0, 0)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 1
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.Size = New System.Drawing.Size(282, 30)
        Me.RootPanel.TabIndex = 0
        '
        'Bar
        '
        Me.Bar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bar.Location = New System.Drawing.Point(45, 0)
        Me.Bar.Margin = New System.Windows.Forms.Padding(0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(182, 30)
        Me.Bar.TabIndex = 0
        '
        'NumberUD
        '
        Me.NumberUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumberUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumberUD.Location = New System.Drawing.Point(227, 4)
        Me.NumberUD.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.NumberUD.Name = "NumberUD"
        Me.NumberUD.Size = New System.Drawing.Size(55, 22)
        Me.NumberUD.TabIndex = 1
        Me.NumberUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Location = New System.Drawing.Point(0, 6)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(45, 24)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Title"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'KzSlideBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "KzSlideBar"
        Me.Size = New System.Drawing.Size(282, 30)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents NumberUD As NumericUpDown
    Private WithEvents Bar As TrackBar
    Private WithEvents TitleLabel As Label
End Class
