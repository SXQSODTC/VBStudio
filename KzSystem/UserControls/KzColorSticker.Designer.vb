<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzColorSticker
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PropertyLabel = New System.Windows.Forms.Label()
        Me.Checker = New System.Windows.Forms.CheckBox()
        Me.ClassifyLabel = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.RootPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.RootPanel.Controls.Add(Me.NameLabel, 1, 0)
        Me.RootPanel.Controls.Add(Me.PropertyLabel, 1, 1)
        Me.RootPanel.Controls.Add(Me.Checker, 2, 0)
        Me.RootPanel.Controls.Add(Me.ClassifyLabel, 2, 1)
        Me.RootPanel.Controls.Add(Me.ColorLabel, 0, 0)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 2
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.Size = New System.Drawing.Size(168, 38)
        Me.RootPanel.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NameLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(53, 2)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 14)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NameLabel.UseMnemonic = False
        '
        'PropertyLabel
        '
        Me.PropertyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PropertyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PropertyLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyLabel.ForeColor = System.Drawing.Color.DimGray
        Me.PropertyLabel.Location = New System.Drawing.Point(53, 21)
        Me.PropertyLabel.Name = "PropertyLabel"
        Me.PropertyLabel.Size = New System.Drawing.Size(63, 14)
        Me.PropertyLabel.TabIndex = 2
        Me.PropertyLabel.Text = "Property"
        Me.PropertyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PropertyLabel.UseMnemonic = False
        '
        'Checker
        '
        Me.Checker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Checker.AutoSize = True
        Me.Checker.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Checker.FlatAppearance.BorderSize = 0
        Me.Checker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checker.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checker.Location = New System.Drawing.Point(153, 3)
        Me.Checker.Name = "Checker"
        Me.Checker.Size = New System.Drawing.Size(12, 11)
        Me.Checker.TabIndex = 3
        Me.Checker.UseVisualStyleBackColor = True
        '
        'ClassifyLabel
        '
        Me.ClassifyLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClassifyLabel.AutoSize = True
        Me.ClassifyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClassifyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClassifyLabel.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassifyLabel.ForeColor = System.Drawing.Color.DimGray
        Me.ClassifyLabel.Location = New System.Drawing.Point(148, 21)
        Me.ClassifyLabel.Name = "ClassifyLabel"
        Me.ClassifyLabel.Size = New System.Drawing.Size(12, 14)
        Me.ClassifyLabel.TabIndex = 4
        Me.ClassifyLabel.Text = "A"
        Me.ClassifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorLabel
        '
        Me.ColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorLabel.Location = New System.Drawing.Point(0, 0)
        Me.ColorLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ColorLabel.Name = "ColorLabel"
        Me.RootPanel.SetRowSpan(Me.ColorLabel, 2)
        Me.ColorLabel.Size = New System.Drawing.Size(50, 38)
        Me.ColorLabel.TabIndex = 5
        Me.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KzColorSticker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "KzColorSticker"
        Me.Size = New System.Drawing.Size(168, 38)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents PropertyLabel As Label
    Friend WithEvents Checker As CheckBox
    Friend WithEvents ClassifyLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents ColorLabel As Label
End Class
