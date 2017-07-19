Public Class KzTextDialog
    Inherits Form

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RootSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.TextDialogToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.OKCmd = New System.Windows.Forms.Button()
        Me.CancelCmd = New System.Windows.Forms.Button()
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSplitContainer.Panel1.SuspendLayout()
        Me.RootSplitContainer.Panel2.SuspendLayout()
        Me.RootSplitContainer.SuspendLayout()
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
        Me.RootSplitContainer.Panel1.Controls.Add(Me.MessageTextBox)
        Me.RootSplitContainer.Panel1.Controls.Add(Me.TextDialogToolStrip)
        '
        'RootSplitContainer.Panel2
        '
        Me.RootSplitContainer.Panel2.Controls.Add(Me.CountLabel)
        Me.RootSplitContainer.Panel2.Controls.Add(Me.OKCmd)
        Me.RootSplitContainer.Panel2.Controls.Add(Me.CancelCmd)
        Me.RootSplitContainer.Size = New System.Drawing.Size(471, 291)
        Me.RootSplitContainer.SplitterDistance = 228
        Me.RootSplitContainer.SplitterWidth = 6
        Me.RootSplitContainer.TabIndex = 0
        '
        'MessageTextBox
        '
        Me.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageTextBox.Location = New System.Drawing.Point(0, 25)
        Me.MessageTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MessageTextBox.Size = New System.Drawing.Size(471, 203)
        Me.MessageTextBox.TabIndex = 1
        '
        'TextDialogToolStrip
        '
        Me.TextDialogToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TextDialogToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.CopyToolStripButton, Me.ToolStripSeparator1, Me.SearchToolStripTextBox, Me.GoToolStripButton})
        Me.TextDialogToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.TextDialogToolStrip.Name = "TextDialogToolStrip"
        Me.TextDialogToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TextDialogToolStrip.Size = New System.Drawing.Size(471, 25)
        Me.TextDialogToolStrip.TabIndex = 0
        Me.TextDialogToolStrip.Text = "ToolStrip1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "ToolStripButton1"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "複製到剪貼板"
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
        '
        'GoToolStripButton
        '
        Me.GoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToolStripButton.Name = "GoToolStripButton"
        Me.GoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GoToolStripButton.Text = "搜索"
        '
        'CountLabel
        '
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Location = New System.Drawing.Point(5, 11)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(46, 17)
        Me.CountLabel.TabIndex = 2
        Me.CountLabel.Text = "Label1"
        '
        'OKCmd
        '
        Me.OKCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKCmd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKCmd.Location = New System.Drawing.Point(275, 10)
        Me.OKCmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OKCmd.Name = "OKCmd"
        Me.OKCmd.Size = New System.Drawing.Size(87, 33)
        Me.OKCmd.TabIndex = 1
        Me.OKCmd.Text = "確定"
        Me.OKCmd.UseVisualStyleBackColor = True
        '
        'CancelCmd
        '
        Me.CancelCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelCmd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelCmd.Location = New System.Drawing.Point(370, 10)
        Me.CancelCmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelCmd.Name = "CancelCmd"
        Me.CancelCmd.Size = New System.Drawing.Size(87, 33)
        Me.CancelCmd.TabIndex = 0
        Me.CancelCmd.Text = "取消"
        Me.CancelCmd.UseVisualStyleBackColor = True
        '
        'KzTextDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 291)
        Me.Controls.Add(Me.RootSplitContainer)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzTextDialog"
        Me.Text = "TextDialog"
        Me.RootSplitContainer.Panel1.ResumeLayout(False)
        Me.RootSplitContainer.Panel1.PerformLayout()
        Me.RootSplitContainer.Panel2.ResumeLayout(False)
        Me.RootSplitContainer.Panel2.PerformLayout()
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSplitContainer.ResumeLayout(False)
        Me.TextDialogToolStrip.ResumeLayout(False)
        Me.TextDialogToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSplitContainer As SplitContainer
    Friend WithEvents MessageTextBox As TextBox
    Friend WithEvents TextDialogToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SearchToolStripTextBox As ToolStripTextBox
    Friend WithEvents GoToolStripButton As ToolStripButton
    Friend WithEvents OKCmd As Button
    Friend WithEvents CancelCmd As Button
    Friend WithEvents CountLabel As Label

    '<STAThread()>
    'Shared Sub Main()
    '    Application.EnableVisualStyles()
    '    Application.Run(New InputDialog())
    'End Sub

    Public Sub New(ByVal text As String)
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        Me.MessageTextBox.Text = text
        Me.CountLabel.Text = "文本長度：" & Strings.Format(Me.MessageTextBox.TextLength, "#,0")
    End Sub
End Class