<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzRegexTester
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
        Me.components = New System.ComponentModel.Container()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.RegexSpliter = New System.Windows.Forms.SplitContainer()
        Me.RegexBox = New System.Windows.Forms.TextBox()
        Me.OpSpliter = New System.Windows.Forms.SplitContainer()
        Me.GroupsButton = New System.Windows.Forms.Button()
        Me.OptNone = New System.Windows.Forms.CheckBox()
        Me.OptIgnoreSpace = New System.Windows.Forms.CheckBox()
        Me.OptSingleLine = New System.Windows.Forms.CheckBox()
        Me.OptMultiLine = New System.Windows.Forms.CheckBox()
        Me.OptIgnoreCase = New System.Windows.Forms.CheckBox()
        Me.MatchesButton = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.SourceBox = New System.Windows.Forms.TextBox()
        Me.RegexStatus = New System.Windows.Forms.StatusStrip()
        Me.LengthLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OptTools = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.RegexSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegexSpliter.Panel1.SuspendLayout()
        Me.RegexSpliter.Panel2.SuspendLayout()
        Me.RegexSpliter.SuspendLayout()
        CType(Me.OpSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpSpliter.Panel1.SuspendLayout()
        Me.OpSpliter.Panel2.SuspendLayout()
        Me.OpSpliter.SuspendLayout()
        Me.RegexStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RootSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.RegexSpliter)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.SourceBox)
        Me.RootSpliter.Size = New System.Drawing.Size(496, 348)
        Me.RootSpliter.SplitterDistance = 256
        Me.RootSpliter.SplitterWidth = 5
        Me.RootSpliter.TabIndex = 0
        '
        'RegexSpliter
        '
        Me.RegexSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegexSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RegexSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RegexSpliter.Name = "RegexSpliter"
        Me.RegexSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'RegexSpliter.Panel1
        '
        Me.RegexSpliter.Panel1.Controls.Add(Me.RegexBox)
        '
        'RegexSpliter.Panel2
        '
        Me.RegexSpliter.Panel2.Controls.Add(Me.OpSpliter)
        Me.RegexSpliter.Size = New System.Drawing.Size(256, 348)
        Me.RegexSpliter.SplitterDistance = 103
        Me.RegexSpliter.SplitterWidth = 6
        Me.RegexSpliter.TabIndex = 0
        '
        'RegexBox
        '
        Me.RegexBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegexBox.Location = New System.Drawing.Point(0, 0)
        Me.RegexBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RegexBox.Multiline = True
        Me.RegexBox.Name = "RegexBox"
        Me.RegexBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RegexBox.Size = New System.Drawing.Size(256, 103)
        Me.RegexBox.TabIndex = 0
        '
        'OpSpliter
        '
        Me.OpSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.OpSpliter.Location = New System.Drawing.Point(0, 0)
        Me.OpSpliter.Name = "OpSpliter"
        Me.OpSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'OpSpliter.Panel1
        '
        Me.OpSpliter.Panel1.Controls.Add(Me.GroupsButton)
        Me.OpSpliter.Panel1.Controls.Add(Me.OptNone)
        Me.OpSpliter.Panel1.Controls.Add(Me.OptIgnoreSpace)
        Me.OpSpliter.Panel1.Controls.Add(Me.OptSingleLine)
        Me.OpSpliter.Panel1.Controls.Add(Me.OptMultiLine)
        Me.OpSpliter.Panel1.Controls.Add(Me.OptIgnoreCase)
        Me.OpSpliter.Panel1.Controls.Add(Me.MatchesButton)
        '
        'OpSpliter.Panel2
        '
        Me.OpSpliter.Panel2.Controls.Add(Me.ResultBox)
        Me.OpSpliter.Size = New System.Drawing.Size(256, 239)
        Me.OpSpliter.SplitterDistance = 78
        Me.OpSpliter.TabIndex = 0
        '
        'GroupsButton
        '
        Me.GroupsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupsButton.Location = New System.Drawing.Point(187, 40)
        Me.GroupsButton.Name = "GroupsButton"
        Me.GroupsButton.Size = New System.Drawing.Size(66, 36)
        Me.GroupsButton.TabIndex = 6
        Me.GroupsButton.Text = "Groups"
        Me.GroupsButton.UseVisualStyleBackColor = True
        '
        'OptNone
        '
        Me.OptNone.AutoSize = True
        Me.OptNone.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNone.Location = New System.Drawing.Point(5, 11)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.Size = New System.Drawing.Size(50, 17)
        Me.OptNone.TabIndex = 5
        Me.OptNone.Text = "None"
        Me.OptTools.SetToolTip(Me.OptNone, "指定不设置任何选项。")
        Me.OptNone.UseVisualStyleBackColor = True
        '
        'OptIgnoreSpace
        '
        Me.OptIgnoreSpace.AutoSize = True
        Me.OptIgnoreSpace.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptIgnoreSpace.Location = New System.Drawing.Point(5, 53)
        Me.OptIgnoreSpace.Name = "OptIgnoreSpace"
        Me.OptIgnoreSpace.Size = New System.Drawing.Size(164, 17)
        Me.OptIgnoreSpace.TabIndex = 4
        Me.OptIgnoreSpace.Text = "IgnorePatternWhitespace"
        Me.OptTools.SetToolTip(Me.OptIgnoreSpace, "消除模式中的非转义空白并启用由 # 标记的注释。 但是，此值不影响或消除标记单独的 正则表达式语言元素的开头的 字符类、数值 量词或令牌中的空白。")
        Me.OptIgnoreSpace.UseVisualStyleBackColor = True
        '
        'OptSingleLine
        '
        Me.OptSingleLine.AutoSize = True
        Me.OptSingleLine.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptSingleLine.Location = New System.Drawing.Point(5, 31)
        Me.OptSingleLine.Name = "OptSingleLine"
        Me.OptSingleLine.Size = New System.Drawing.Size(86, 17)
        Me.OptSingleLine.TabIndex = 3
        Me.OptSingleLine.Text = "SingleLine"
        Me.OptTools.SetToolTip(Me.OptSingleLine, "指定单行模式。 更改点 (.) 的含义，以使它与每个字符（而不是除 \n 之外的所有字符）匹配。")
        Me.OptSingleLine.UseVisualStyleBackColor = True
        '
        'OptMultiLine
        '
        Me.OptMultiLine.AutoSize = True
        Me.OptMultiLine.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMultiLine.Location = New System.Drawing.Point(97, 31)
        Me.OptMultiLine.Name = "OptMultiLine"
        Me.OptMultiLine.Size = New System.Drawing.Size(80, 17)
        Me.OptMultiLine.TabIndex = 2
        Me.OptMultiLine.Text = "MultiLine"
        Me.OptTools.SetToolTip(Me.OptMultiLine, "多行模式。 更改 ^ 和 $ 的含义，使它们分别在任意一行的行首和行尾匹配，而不仅仅在整个字符串的开头和结尾匹配。")
        Me.OptMultiLine.UseVisualStyleBackColor = True
        '
        'OptIgnoreCase
        '
        Me.OptIgnoreCase.AutoSize = True
        Me.OptIgnoreCase.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptIgnoreCase.Location = New System.Drawing.Point(97, 11)
        Me.OptIgnoreCase.Name = "OptIgnoreCase"
        Me.OptIgnoreCase.Size = New System.Drawing.Size(86, 17)
        Me.OptIgnoreCase.TabIndex = 1
        Me.OptIgnoreCase.Text = "IgnoreCase"
        Me.OptTools.SetToolTip(Me.OptIgnoreCase, "指定不区分大小写的匹配。 ")
        Me.OptIgnoreCase.UseVisualStyleBackColor = True
        '
        'MatchesButton
        '
        Me.MatchesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatchesButton.Location = New System.Drawing.Point(187, 3)
        Me.MatchesButton.Name = "MatchesButton"
        Me.MatchesButton.Size = New System.Drawing.Size(66, 36)
        Me.MatchesButton.TabIndex = 0
        Me.MatchesButton.Text = "Matches"
        Me.MatchesButton.UseVisualStyleBackColor = True
        '
        'ResultBox
        '
        Me.ResultBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultBox.Location = New System.Drawing.Point(0, 0)
        Me.ResultBox.Multiline = True
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultBox.Size = New System.Drawing.Size(256, 157)
        Me.ResultBox.TabIndex = 0
        '
        'SourceBox
        '
        Me.SourceBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceBox.Location = New System.Drawing.Point(0, 0)
        Me.SourceBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SourceBox.Multiline = True
        Me.SourceBox.Name = "SourceBox"
        Me.SourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SourceBox.Size = New System.Drawing.Size(235, 348)
        Me.SourceBox.TabIndex = 0
        '
        'RegexStatus
        '
        Me.RegexStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LengthLabel, Me.CountLabel})
        Me.RegexStatus.Location = New System.Drawing.Point(0, 348)
        Me.RegexStatus.Name = "RegexStatus"
        Me.RegexStatus.Size = New System.Drawing.Size(496, 22)
        Me.RegexStatus.TabIndex = 1
        Me.RegexStatus.Text = "StatusStrip1"
        '
        'LengthLabel
        '
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(47, 17)
        Me.LengthLabel.Text = "Length"
        '
        'CountLabel
        '
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(44, 17)
        Me.CountLabel.Text = "Found"
        '
        'KzRegexTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 370)
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RegexStatus)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzRegexTester"
        Me.Text = "KzRegexTester"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        Me.RootSpliter.Panel2.PerformLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.RegexSpliter.Panel1.ResumeLayout(False)
        Me.RegexSpliter.Panel1.PerformLayout()
        Me.RegexSpliter.Panel2.ResumeLayout(False)
        CType(Me.RegexSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegexSpliter.ResumeLayout(False)
        Me.OpSpliter.Panel1.ResumeLayout(False)
        Me.OpSpliter.Panel1.PerformLayout()
        Me.OpSpliter.Panel2.ResumeLayout(False)
        Me.OpSpliter.Panel2.PerformLayout()
        CType(Me.OpSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpSpliter.ResumeLayout(False)
        Me.RegexStatus.ResumeLayout(False)
        Me.RegexStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents RegexSpliter As SplitContainer
    Friend WithEvents RegexBox As TextBox
    Friend WithEvents SourceBox As TextBox
    Friend WithEvents OpSpliter As SplitContainer
    Friend WithEvents MatchesButton As Button
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents RegexStatus As StatusStrip
    Friend WithEvents CountLabel As ToolStripStatusLabel
    Friend WithEvents OptNone As CheckBox
    Friend WithEvents OptIgnoreSpace As CheckBox
    Friend WithEvents OptSingleLine As CheckBox
    Friend WithEvents OptMultiLine As CheckBox
    Friend WithEvents OptIgnoreCase As CheckBox
    Friend WithEvents OptTools As ToolTip
    Friend WithEvents LengthLabel As ToolStripStatusLabel
    Friend WithEvents GroupsButton As Button
End Class
