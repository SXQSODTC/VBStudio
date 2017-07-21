<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KzTextViewDialog
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RootSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ContentsTextBox = New System.Windows.Forms.TextBox()
        Me.TextDialogStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.CountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SelectionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PositionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextDialogToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.OKCmd = New System.Windows.Forms.Button()
        Me.CancelCmd = New System.Windows.Forms.Button()
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSplitContainer.Panel1.SuspendLayout()
        Me.RootSplitContainer.Panel2.SuspendLayout()
        Me.RootSplitContainer.SuspendLayout()
        Me.TextDialogStatusStrip.SuspendLayout()
        Me.TextDialogToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSplitContainer
        '
        Me.RootSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.RootSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.RootSplitContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootSplitContainer.Name = "RootSplitContainer"
        Me.RootSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'RootSplitContainer.Panel1
        '
        Me.RootSplitContainer.Panel1.Controls.Add(Me.ContentsTextBox)
        Me.RootSplitContainer.Panel1.Controls.Add(Me.TextDialogStatusStrip)
        Me.RootSplitContainer.Panel1.Controls.Add(Me.TextDialogToolStrip)
        '
        'RootSplitContainer.Panel2
        '
        Me.RootSplitContainer.Panel2.Controls.Add(Me.InfoLabel)
        Me.RootSplitContainer.Panel2.Controls.Add(Me.OKCmd)
        Me.RootSplitContainer.Panel2.Controls.Add(Me.CancelCmd)
        Me.RootSplitContainer.Size = New System.Drawing.Size(443, 357)
        Me.RootSplitContainer.SplitterDistance = 305
        Me.RootSplitContainer.SplitterWidth = 6
        Me.RootSplitContainer.TabIndex = 1
        '
        'ContentsTextBox
        '
        Me.ContentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentsTextBox.Location = New System.Drawing.Point(0, 25)
        Me.ContentsTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContentsTextBox.Multiline = True
        Me.ContentsTextBox.Name = "ContentsTextBox"
        Me.ContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentsTextBox.Size = New System.Drawing.Size(443, 254)
        Me.ContentsTextBox.TabIndex = 1
        '
        'TextDialogStatusStrip
        '
        Me.TextDialogStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CountLabel, Me.SelectionLabel, Me.PositionLabel})
        Me.TextDialogStatusStrip.Location = New System.Drawing.Point(0, 279)
        Me.TextDialogStatusStrip.Name = "TextDialogStatusStrip"
        Me.TextDialogStatusStrip.Size = New System.Drawing.Size(443, 26)
        Me.TextDialogStatusStrip.TabIndex = 2
        Me.TextDialogStatusStrip.Text = "StatusStrip1"
        '
        'CountLabel
        '
        Me.CountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(46, 21)
        Me.CountLabel.Text = "Count"
        '
        'SelectionLabel
        '
        Me.SelectionLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.SelectionLabel.Name = "SelectionLabel"
        Me.SelectionLabel.Size = New System.Drawing.Size(64, 21)
        Me.SelectionLabel.Text = "Selection"
        '
        'PositionLabel
        '
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(54, 21)
        Me.PositionLabel.Text = "Position"
        '
        'TextDialogToolStrip
        '
        Me.TextDialogToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TextDialogToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.CopyToolStripButton, Me.ToolStripSeparator1, Me.SearchToolStripTextBox, Me.GoToolStripButton})
        Me.TextDialogToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.TextDialogToolStrip.Name = "TextDialogToolStrip"
        Me.TextDialogToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TextDialogToolStrip.Size = New System.Drawing.Size(443, 25)
        Me.TextDialogToolStrip.TabIndex = 0
        Me.TextDialogToolStrip.Text = "ToolStrip1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.CopyToolStripButton.Text = "Copy"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchToolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.SearchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(117, 25)
        Me.SearchToolStripTextBox.Text = "Search"
        '
        'GoToolStripButton
        '
        Me.GoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToolStripButton.Name = "GoToolStripButton"
        Me.GoToolStripButton.Size = New System.Drawing.Size(29, 22)
        Me.GoToolStripButton.Text = "Go"
        '
        'InfoLabel
        '
        Me.InfoLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.InfoLabel.Location = New System.Drawing.Point(0, 0)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(245, 46)
        Me.InfoLabel.TabIndex = 2
        Me.InfoLabel.Text = "Description"
        '
        'OKCmd
        '
        Me.OKCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKCmd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKCmd.Location = New System.Drawing.Point(254, 7)
        Me.OKCmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OKCmd.Name = "OKCmd"
        Me.OKCmd.Size = New System.Drawing.Size(87, 28)
        Me.OKCmd.TabIndex = 1
        Me.OKCmd.Text = "OK"
        Me.OKCmd.UseVisualStyleBackColor = True
        '
        'CancelCmd
        '
        Me.CancelCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelCmd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelCmd.Location = New System.Drawing.Point(347, 7)
        Me.CancelCmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelCmd.Name = "CancelCmd"
        Me.CancelCmd.Size = New System.Drawing.Size(87, 28)
        Me.CancelCmd.TabIndex = 0
        Me.CancelCmd.Text = "Cancel"
        Me.CancelCmd.UseVisualStyleBackColor = True
        '
        'KzTextViewDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 357)
        Me.Controls.Add(Me.RootSplitContainer)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzTextViewDialog"
        Me.Text = "KzTextViewDialog"
        Me.RootSplitContainer.Panel1.ResumeLayout(False)
        Me.RootSplitContainer.Panel1.PerformLayout()
        Me.RootSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSplitContainer.ResumeLayout(False)
        Me.TextDialogStatusStrip.ResumeLayout(False)
        Me.TextDialogStatusStrip.PerformLayout()
        Me.TextDialogToolStrip.ResumeLayout(False)
        Me.TextDialogToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSplitContainer As SplitContainer
    Friend WithEvents ContentsTextBox As TextBox
    Friend WithEvents TextDialogToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SearchToolStripTextBox As ToolStripTextBox
    Friend WithEvents GoToolStripButton As ToolStripButton
    Friend WithEvents OKCmd As Button
    Friend WithEvents CancelCmd As Button
    Friend WithEvents TextDialogStatusStrip As StatusStrip
    Friend WithEvents CountLabel As ToolStripStatusLabel
    Friend WithEvents SelectionLabel As ToolStripStatusLabel
    Friend WithEvents PositionLabel As ToolStripStatusLabel
    Friend WithEvents InfoLabel As Label
End Class
