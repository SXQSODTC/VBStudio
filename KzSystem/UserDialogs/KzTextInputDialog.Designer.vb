<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzTextInputDialog
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
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.MyOKButton = New System.Windows.Forms.Button()
        Me.MyCancelButton = New System.Windows.Forms.Button()
        Me.ClearTextButton = New System.Windows.Forms.Button()
        Me.RootPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 4
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.RootPanel.Controls.Add(Me.SubjectLabel, 0, 0)
        Me.RootPanel.Controls.Add(Me.InputBox, 0, 1)
        Me.RootPanel.Controls.Add(Me.MyOKButton, 1, 2)
        Me.RootPanel.Controls.Add(Me.MyCancelButton, 2, 2)
        Me.RootPanel.Controls.Add(Me.ClearTextButton, 3, 1)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 3
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.RootPanel.Size = New System.Drawing.Size(274, 86)
        Me.RootPanel.TabIndex = 0
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.RootPanel.SetColumnSpan(Me.SubjectLabel, 4)
        Me.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectLabel.Location = New System.Drawing.Point(3, 0)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(268, 24)
        Me.SubjectLabel.TabIndex = 0
        Me.SubjectLabel.Text = "Subject"
        Me.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InputBox
        '
        Me.RootPanel.SetColumnSpan(Me.InputBox, 3)
        Me.InputBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputBox.Location = New System.Drawing.Point(3, 27)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(246, 23)
        Me.InputBox.TabIndex = 1
        Me.InputBox.Text = "Input"
        '
        'MyOKButton
        '
        Me.MyOKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.MyOKButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyOKButton.Location = New System.Drawing.Point(129, 59)
        Me.MyOKButton.Name = "MyOKButton"
        Me.MyOKButton.Size = New System.Drawing.Size(57, 24)
        Me.MyOKButton.TabIndex = 2
        Me.MyOKButton.Text = "OK"
        Me.MyOKButton.UseVisualStyleBackColor = True
        '
        'MyCancelButton
        '
        Me.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyCancelButton.Location = New System.Drawing.Point(192, 59)
        Me.MyCancelButton.Name = "MyCancelButton"
        Me.MyCancelButton.Size = New System.Drawing.Size(57, 24)
        Me.MyCancelButton.TabIndex = 3
        Me.MyCancelButton.Text = "Cancel"
        Me.MyCancelButton.UseVisualStyleBackColor = True
        '
        'ClearTextButton
        '
        Me.ClearTextButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClearTextButton.Location = New System.Drawing.Point(253, 27)
        Me.ClearTextButton.Margin = New System.Windows.Forms.Padding(1, 3, 1, 1)
        Me.ClearTextButton.Name = "ClearTextButton"
        Me.ClearTextButton.Size = New System.Drawing.Size(20, 23)
        Me.ClearTextButton.TabIndex = 4
        Me.ClearTextButton.Text = "C"
        Me.ClearTextButton.UseVisualStyleBackColor = True
        '
        'KzTextInputDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 86)
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzTextInputDialog"
        Me.Text = "KzTextInputDialog"
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents SubjectLabel As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents MyOKButton As Button
    Friend WithEvents MyCancelButton As Button
    Friend WithEvents ClearTextButton As Button
End Class
