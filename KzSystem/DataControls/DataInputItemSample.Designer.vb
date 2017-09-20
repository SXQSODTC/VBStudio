<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataInputItemSample
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
        Me.components = New System.ComponentModel.Container()
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Checker = New System.Windows.Forms.CheckBox()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExpandButton = New System.Windows.Forms.Button()
        Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.RootPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 6
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.Controls.Add(Me.Checker, 0, 0)
        Me.RootPanel.Controls.Add(Me.SubjectLabel, 1, 0)
        Me.RootPanel.Controls.Add(Me.InputBox, 2, 0)
        Me.RootPanel.Controls.Add(Me.ClearButton, 4, 0)
        Me.RootPanel.Controls.Add(Me.ExpandButton, 5, 0)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 3
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0!))
        Me.RootPanel.Size = New System.Drawing.Size(300, 25)
        Me.RootPanel.TabIndex = 0
        '
        'Checker
        '
        Me.Checker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Checker.AutoSize = True
        Me.Checker.FlatAppearance.BorderSize = 0
        Me.Checker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checker.Location = New System.Drawing.Point(6, 7)
        Me.Checker.Name = "Checker"
        Me.Checker.Size = New System.Drawing.Size(12, 11)
        Me.Checker.TabIndex = 0
        Me.Checker.UseVisualStyleBackColor = True
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectLabel.Location = New System.Drawing.Point(28, 0)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(54, 25)
        Me.SubjectLabel.TabIndex = 1
        Me.SubjectLabel.Text = "Subject"
        Me.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InputBox
        '
        Me.InputBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputBox.Location = New System.Drawing.Point(86, 1)
        Me.InputBox.Margin = New System.Windows.Forms.Padding(1)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(80, 23)
        Me.InputBox.TabIndex = 2
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(250, 1)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(23, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExpandButton
        '
        Me.ExpandButton.Location = New System.Drawing.Point(275, 1)
        Me.ExpandButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ExpandButton.Name = "ExpandButton"
        Me.ExpandButton.Size = New System.Drawing.Size(23, 23)
        Me.ExpandButton.TabIndex = 4
        Me.ExpandButton.UseVisualStyleBackColor = True
        '
        'DataInputItemSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DataInputItemSample"
        Me.Size = New System.Drawing.Size(300, 25)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents Checker As CheckBox
    Friend WithEvents SubjectLabel As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExpandButton As Button
    Friend WithEvents Tips As ToolTip
End Class
