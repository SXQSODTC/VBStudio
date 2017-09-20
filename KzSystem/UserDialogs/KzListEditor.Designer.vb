<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzListEditor
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
        Me.TheListBox = New System.Windows.Forms.ListBox()
        Me.EditTextBox = New System.Windows.Forms.TextBox()
        Me.CommandsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.MoveUpButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.MoveDownButton = New System.Windows.Forms.Button()
        Me.TheOKButton = New System.Windows.Forms.Button()
        Me.TheCancelButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.CommandsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TheListBox
        '
        Me.TheListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheListBox.FormattingEnabled = True
        Me.TheListBox.ItemHeight = 14
        Me.TheListBox.Location = New System.Drawing.Point(0, 22)
        Me.TheListBox.Name = "TheListBox"
        Me.TheListBox.Size = New System.Drawing.Size(357, 106)
        Me.TheListBox.TabIndex = 0
        '
        'EditTextBox
        '
        Me.EditTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditTextBox.Location = New System.Drawing.Point(0, 128)
        Me.EditTextBox.Name = "EditTextBox"
        Me.EditTextBox.Size = New System.Drawing.Size(357, 22)
        Me.EditTextBox.TabIndex = 1
        '
        'CommandsPanel
        '
        Me.CommandsPanel.ColumnCount = 5
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.CommandsPanel.Controls.Add(Me.AddButton, 0, 0)
        Me.CommandsPanel.Controls.Add(Me.UpdateButton, 1, 0)
        Me.CommandsPanel.Controls.Add(Me.MoveUpButton, 2, 0)
        Me.CommandsPanel.Controls.Add(Me.DeleteButton, 0, 1)
        Me.CommandsPanel.Controls.Add(Me.ClearButton, 1, 1)
        Me.CommandsPanel.Controls.Add(Me.MoveDownButton, 2, 1)
        Me.CommandsPanel.Controls.Add(Me.TheOKButton, 4, 0)
        Me.CommandsPanel.Controls.Add(Me.TheCancelButton, 4, 1)
        Me.CommandsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CommandsPanel.Location = New System.Drawing.Point(0, 150)
        Me.CommandsPanel.Name = "CommandsPanel"
        Me.CommandsPanel.RowCount = 2
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CommandsPanel.Size = New System.Drawing.Size(357, 57)
        Me.CommandsPanel.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(3, 3)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(65, 22)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(74, 3)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(65, 22)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'MoveUpButton
        '
        Me.MoveUpButton.Location = New System.Drawing.Point(145, 3)
        Me.MoveUpButton.Name = "MoveUpButton"
        Me.MoveUpButton.Size = New System.Drawing.Size(65, 22)
        Me.MoveUpButton.TabIndex = 2
        Me.MoveUpButton.Text = "Up"
        Me.MoveUpButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(3, 31)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(65, 23)
        Me.DeleteButton.TabIndex = 3
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(74, 31)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(65, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'MoveDownButton
        '
        Me.MoveDownButton.Location = New System.Drawing.Point(145, 31)
        Me.MoveDownButton.Name = "MoveDownButton"
        Me.MoveDownButton.Size = New System.Drawing.Size(65, 23)
        Me.MoveDownButton.TabIndex = 5
        Me.MoveDownButton.Text = "Down"
        Me.MoveDownButton.UseVisualStyleBackColor = True
        '
        'TheOKButton
        '
        Me.TheOKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.TheOKButton.Location = New System.Drawing.Point(287, 3)
        Me.TheOKButton.Name = "TheOKButton"
        Me.TheOKButton.Size = New System.Drawing.Size(67, 22)
        Me.TheOKButton.TabIndex = 6
        Me.TheOKButton.Text = "OK"
        Me.TheOKButton.UseVisualStyleBackColor = True
        '
        'TheCancelButton
        '
        Me.TheCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.TheCancelButton.Location = New System.Drawing.Point(287, 31)
        Me.TheCancelButton.Name = "TheCancelButton"
        Me.TheCancelButton.Size = New System.Drawing.Size(67, 23)
        Me.TheCancelButton.TabIndex = 7
        Me.TheCancelButton.Text = "Cancel"
        Me.TheCancelButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(357, 22)
        Me.SearchTextBox.TabIndex = 3
        '
        'KzListEditor
        '
        Me.AcceptButton = Me.TheOKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.TheCancelButton
        Me.ClientSize = New System.Drawing.Size(357, 207)
        Me.Controls.Add(Me.TheListBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.EditTextBox)
        Me.Controls.Add(Me.CommandsPanel)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "KzListEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "KzListEditor"
        Me.CommandsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TheListBox As ListBox
    Friend WithEvents EditTextBox As TextBox
    Friend WithEvents CommandsPanel As TableLayoutPanel
    Friend WithEvents AddButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents MoveUpButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents MoveDownButton As Button
    Friend WithEvents TheOKButton As Button
    Friend WithEvents TheCancelButton As Button
    Friend WithEvents SearchTextBox As TextBox
End Class
