<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.CommandsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.C7Button = New System.Windows.Forms.Button()
        Me.C6Button = New System.Windows.Forms.Button()
        Me.C5Button = New System.Windows.Forms.Button()
        Me.C4Button = New System.Windows.Forms.Button()
        Me.C3Button = New System.Windows.Forms.Button()
        Me.UnButton = New System.Windows.Forms.Button()
        Me.FindReplaceButton = New System.Windows.Forms.Button()
        Me.EditorButton = New System.Windows.Forms.Button()
        Me.StartMenu = New System.Windows.Forms.MenuStrip()
        Me.MainMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HDLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HomeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test03 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test04 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test05 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test06 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CommandsPanel.SuspendLayout()
        Me.StartMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandsPanel
        '
        Me.CommandsPanel.ColumnCount = 3
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CommandsPanel.Controls.Add(Me.ExitButton, 2, 2)
        Me.CommandsPanel.Controls.Add(Me.C7Button, 1, 2)
        Me.CommandsPanel.Controls.Add(Me.C6Button, 0, 2)
        Me.CommandsPanel.Controls.Add(Me.C5Button, 2, 1)
        Me.CommandsPanel.Controls.Add(Me.C4Button, 1, 1)
        Me.CommandsPanel.Controls.Add(Me.C3Button, 0, 1)
        Me.CommandsPanel.Controls.Add(Me.UnButton, 2, 0)
        Me.CommandsPanel.Controls.Add(Me.FindReplaceButton, 1, 0)
        Me.CommandsPanel.Controls.Add(Me.EditorButton, 0, 0)
        Me.CommandsPanel.Location = New System.Drawing.Point(152, 95)
        Me.CommandsPanel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CommandsPanel.Name = "CommandsPanel"
        Me.CommandsPanel.RowCount = 3
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.CommandsPanel.Size = New System.Drawing.Size(218, 265)
        Me.CommandsPanel.TabIndex = 8
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitButton.Location = New System.Drawing.Point(147, 182)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(68, 77)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'C7Button
        '
        Me.C7Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C7Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C7Button.Location = New System.Drawing.Point(75, 182)
        Me.C7Button.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.C7Button.Name = "C7Button"
        Me.C7Button.Size = New System.Drawing.Size(66, 77)
        Me.C7Button.TabIndex = 8
        Me.C7Button.UseVisualStyleBackColor = True
        '
        'C6Button
        '
        Me.C6Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C6Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C6Button.Location = New System.Drawing.Point(3, 182)
        Me.C6Button.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.C6Button.Name = "C6Button"
        Me.C6Button.Size = New System.Drawing.Size(66, 77)
        Me.C6Button.TabIndex = 7
        Me.C6Button.UseVisualStyleBackColor = True
        '
        'C5Button
        '
        Me.C5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C5Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C5Button.Location = New System.Drawing.Point(147, 94)
        Me.C5Button.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.C5Button.Name = "C5Button"
        Me.C5Button.Size = New System.Drawing.Size(68, 76)
        Me.C5Button.TabIndex = 5
        Me.C5Button.UseVisualStyleBackColor = True
        '
        'C4Button
        '
        Me.C4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C4Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C4Button.Location = New System.Drawing.Point(75, 94)
        Me.C4Button.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.C4Button.Name = "C4Button"
        Me.C4Button.Size = New System.Drawing.Size(66, 76)
        Me.C4Button.TabIndex = 4
        Me.C4Button.UseVisualStyleBackColor = True
        '
        'C3Button
        '
        Me.C3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.C3Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C3Button.Location = New System.Drawing.Point(3, 94)
        Me.C3Button.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.C3Button.Name = "C3Button"
        Me.C3Button.Size = New System.Drawing.Size(66, 76)
        Me.C3Button.TabIndex = 3
        Me.C3Button.UseVisualStyleBackColor = True
        '
        'UnButton
        '
        Me.UnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UnButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnButton.Location = New System.Drawing.Point(147, 6)
        Me.UnButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UnButton.Name = "UnButton"
        Me.UnButton.Size = New System.Drawing.Size(68, 76)
        Me.UnButton.TabIndex = 2
        Me.UnButton.UseVisualStyleBackColor = True
        '
        'FindReplaceButton
        '
        Me.FindReplaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FindReplaceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindReplaceButton.Location = New System.Drawing.Point(75, 6)
        Me.FindReplaceButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.FindReplaceButton.Name = "FindReplaceButton"
        Me.FindReplaceButton.Size = New System.Drawing.Size(66, 76)
        Me.FindReplaceButton.TabIndex = 1
        Me.FindReplaceButton.UseVisualStyleBackColor = True
        '
        'EditorButton
        '
        Me.EditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditorButton.Location = New System.Drawing.Point(3, 6)
        Me.EditorButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.EditorButton.Name = "EditorButton"
        Me.EditorButton.Size = New System.Drawing.Size(66, 76)
        Me.EditorButton.TabIndex = 0
        Me.EditorButton.UseVisualStyleBackColor = True
        '
        'StartMenu
        '
        Me.StartMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuItem, Me.TestMenuItem})
        Me.StartMenu.Location = New System.Drawing.Point(0, 0)
        Me.StartMenu.Name = "StartMenu"
        Me.StartMenu.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.StartMenu.Size = New System.Drawing.Size(607, 27)
        Me.StartMenu.TabIndex = 9
        Me.StartMenu.Text = "MenuStrip1"
        '
        'MainMenuItem
        '
        Me.MainMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorMenuItem, Me.HDLibraryToolStripMenuItem, Me.TextLibraryToolStripMenuItem, Me.ToolStripSeparator1, Me.HomeMenuItem, Me.ExitMenuItem})
        Me.MainMenuItem.Name = "MainMenuItem"
        Me.MainMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.MainMenuItem.Text = "Main"
        '
        'EditorMenuItem
        '
        Me.EditorMenuItem.Name = "EditorMenuItem"
        Me.EditorMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditorMenuItem.Text = "Editor"
        '
        'HDLibraryToolStripMenuItem
        '
        Me.HDLibraryToolStripMenuItem.Name = "HDLibraryToolStripMenuItem"
        Me.HDLibraryToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.HDLibraryToolStripMenuItem.Text = "HDLibrary"
        '
        'TextLibraryToolStripMenuItem
        '
        Me.TextLibraryToolStripMenuItem.Name = "TextLibraryToolStripMenuItem"
        Me.TextLibraryToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TextLibraryToolStripMenuItem.Text = "TextLibrary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'HomeMenuItem
        '
        Me.HomeMenuItem.Name = "HomeMenuItem"
        Me.HomeMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.HomeMenuItem.Text = "Home"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitMenuItem.Text = "Exit"
        '
        'TestMenuItem
        '
        Me.TestMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test01, Me.Test02, Me.Test03, Me.Test04, Me.Test05, Me.Test06})
        Me.TestMenuItem.Name = "TestMenuItem"
        Me.TestMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.TestMenuItem.Text = "Test"
        '
        'Test01
        '
        Me.Test01.Name = "Test01"
        Me.Test01.Size = New System.Drawing.Size(156, 22)
        Me.Test01.Text = "TabsDesigner"
        '
        'Test02
        '
        Me.Test02.Name = "Test02"
        Me.Test02.Size = New System.Drawing.Size(156, 22)
        Me.Test02.Text = "ColorPicker"
        '
        'Test03
        '
        Me.Test03.Name = "Test03"
        Me.Test03.Size = New System.Drawing.Size(156, 22)
        Me.Test03.Text = "TestSlideBar"
        '
        'Test04
        '
        Me.Test04.Name = "Test04"
        Me.Test04.Size = New System.Drawing.Size(156, 22)
        Me.Test04.Text = "PListReader"
        '
        'Test05
        '
        Me.Test05.Name = "Test05"
        Me.Test05.Size = New System.Drawing.Size(156, 22)
        Me.Test05.Text = "RegexTester"
        '
        'Test06
        '
        Me.Test06.Name = "Test06"
        Me.Test06.Size = New System.Drawing.Size(156, 22)
        Me.Test06.Text = "HDLibDB"
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 397)
        Me.Controls.Add(Me.CommandsPanel)
        Me.Controls.Add(Me.StartMenu)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.StartMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StartForm"
        Me.Text = "StartForm"
        Me.CommandsPanel.ResumeLayout(False)
        Me.StartMenu.ResumeLayout(False)
        Me.StartMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CommandsPanel As TableLayoutPanel
    Friend WithEvents ExitButton As Button
    Friend WithEvents C7Button As Button
    Friend WithEvents C6Button As Button
    Friend WithEvents C5Button As Button
    Friend WithEvents C4Button As Button
    Friend WithEvents C3Button As Button
    Friend WithEvents UnButton As Button
    Friend WithEvents FindReplaceButton As Button
    Friend WithEvents EditorButton As Button
    Friend WithEvents StartMenu As MenuStrip
    Friend WithEvents MainMenuItem As ToolStripMenuItem
    Friend WithEvents EditorMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HomeMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents TestMenuItem As ToolStripMenuItem
    Friend WithEvents Test01 As ToolStripMenuItem
    Friend WithEvents Test02 As ToolStripMenuItem
    Friend WithEvents Test03 As ToolStripMenuItem
    Friend WithEvents GenToolTip As ToolTip
    Friend WithEvents Test04 As ToolStripMenuItem
    Friend WithEvents Test05 As ToolStripMenuItem
    Friend WithEvents Test06 As ToolStripMenuItem
    Friend WithEvents HDLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextLibraryToolStripMenuItem As ToolStripMenuItem
End Class
