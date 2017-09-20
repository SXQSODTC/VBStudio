<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzOnePageWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzOnePageWeb))
        Me.CmdToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolsButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBackButton = New System.Windows.Forms.ToolStripButton()
        Me.GoForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HtmlTitleLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SourceButton = New System.Windows.Forms.ToolStripButton()
        Me.SearchButton = New System.Windows.Forms.ToolStripButton()
        Me.EnginesButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSwitchButton = New System.Windows.Forms.ToolStripButton()
        Me.WebStatus = New System.Windows.Forms.StatusStrip()
        Me.IndexButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NowLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HDBrowser = New System.Windows.Forms.WebBrowser()
        Me.UrlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.HistoryButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HomeButton = New System.Windows.Forms.ToolStripButton()
        Me.UrlTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GoButton = New System.Windows.Forms.ToolStripButton()
        Me.StopButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.FavoritesButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmdToolStrip.SuspendLayout()
        Me.WebStatus.SuspendLayout()
        Me.UrlToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdToolStrip
        '
        Me.CmdToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CmdToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsButton, Me.GoBackButton, Me.GoForwardButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.HtmlTitleLabel, Me.ToolStripSeparator2, Me.SourceButton, Me.SearchButton, Me.EnginesButton, Me.ToolStripSeparator7, Me.MenuSwitchButton})
        Me.CmdToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.CmdToolStrip.Name = "CmdToolStrip"
        Me.CmdToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CmdToolStrip.Size = New System.Drawing.Size(317, 25)
        Me.CmdToolStrip.TabIndex = 1
        Me.CmdToolStrip.Text = "ToolStrip2"
        '
        'ToolsButton
        '
        Me.ToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolsButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator3, Me.PageSetupToolStripMenuItem, Me.PreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator4, Me.PropertiesToolStripMenuItem, Me.ToolStripSeparator6, Me.SettingsToolStripMenuItem})
        Me.ToolsButton.Image = CType(resources.GetObject("ToolsButton.Image"), System.Drawing.Image)
        Me.ToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolsButton.Name = "ToolsButton"
        Me.ToolsButton.Size = New System.Drawing.Size(29, 22)
        Me.ToolsButton.Text = "ToolBox"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(138, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page setup"
        '
        'PreviewToolStripMenuItem
        '
        Me.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem"
        Me.PreviewToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PreviewToolStripMenuItem.Text = "Preview"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(138, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(138, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'GoBackButton
        '
        Me.GoBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoBackButton.Image = CType(resources.GetObject("GoBackButton.Image"), System.Drawing.Image)
        Me.GoBackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(23, 22)
        Me.GoBackButton.Text = "Back"
        Me.GoBackButton.ToolTipText = "Go back"
        '
        'GoForwardButton
        '
        Me.GoForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoForwardButton.Image = CType(resources.GetObject("GoForwardButton.Image"), System.Drawing.Image)
        Me.GoForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoForwardButton.Name = "GoForwardButton"
        Me.GoForwardButton.Size = New System.Drawing.Size(23, 22)
        Me.GoForwardButton.Text = "Forward"
        Me.GoForwardButton.ToolTipText = "Go forward"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshButton.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HtmlTitleLabel
        '
        Me.HtmlTitleLabel.AutoSize = False
        Me.HtmlTitleLabel.BackColor = System.Drawing.SystemColors.Control
        Me.HtmlTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.HtmlTitleLabel.Name = "HtmlTitleLabel"
        Me.HtmlTitleLabel.Size = New System.Drawing.Size(32, 22)
        Me.HtmlTitleLabel.Text = "Title"
        Me.HtmlTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SourceButton
        '
        Me.SourceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SourceButton.Image = CType(resources.GetObject("SourceButton.Image"), System.Drawing.Image)
        Me.SourceButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SourceButton.Name = "SourceButton"
        Me.SourceButton.Size = New System.Drawing.Size(23, 22)
        Me.SourceButton.Text = "Source"
        Me.SourceButton.ToolTipText = "Show source"
        '
        'SearchButton
        '
        Me.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchButton.Image = CType(resources.GetObject("SearchButton.Image"), System.Drawing.Image)
        Me.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(23, 22)
        Me.SearchButton.Text = "Search"
        '
        'EnginesButton
        '
        Me.EnginesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnginesButton.Image = CType(resources.GetObject("EnginesButton.Image"), System.Drawing.Image)
        Me.EnginesButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnginesButton.Name = "EnginesButton"
        Me.EnginesButton.Size = New System.Drawing.Size(29, 22)
        Me.EnginesButton.Text = "ToolStripDropDownButton1"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'MenuSwitchButton
        '
        Me.MenuSwitchButton.CheckOnClick = True
        Me.MenuSwitchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuSwitchButton.Image = CType(resources.GetObject("MenuSwitchButton.Image"), System.Drawing.Image)
        Me.MenuSwitchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuSwitchButton.Name = "MenuSwitchButton"
        Me.MenuSwitchButton.Size = New System.Drawing.Size(23, 22)
        Me.MenuSwitchButton.Text = "Switch"
        Me.MenuSwitchButton.ToolTipText = "Switch right-clicked menu type"
        '
        'WebStatus
        '
        Me.WebStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexButton, Me.NowLabel})
        Me.WebStatus.Location = New System.Drawing.Point(0, 308)
        Me.WebStatus.Name = "WebStatus"
        Me.WebStatus.Size = New System.Drawing.Size(317, 26)
        Me.WebStatus.TabIndex = 2
        Me.WebStatus.Text = "StatusStrip2"
        '
        'IndexButton
        '
        Me.IndexButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IndexButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElementsToolStripMenuItem})
        Me.IndexButton.Image = CType(resources.GetObject("IndexButton.Image"), System.Drawing.Image)
        Me.IndexButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IndexButton.Name = "IndexButton"
        Me.IndexButton.ShowDropDownArrow = False
        Me.IndexButton.Size = New System.Drawing.Size(20, 24)
        Me.IndexButton.Text = "ToolStripDropDownButton1"
        '
        'NowLabel
        '
        Me.NowLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.NowLabel.ForeColor = System.Drawing.Color.Brown
        Me.NowLabel.Name = "NowLabel"
        Me.NowLabel.Size = New System.Drawing.Size(39, 21)
        Me.NowLabel.Text = "Now"
        '
        'HDBrowser
        '
        Me.HDBrowser.AllowWebBrowserDrop = False
        Me.HDBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HDBrowser.Location = New System.Drawing.Point(0, 50)
        Me.HDBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HDBrowser.Name = "HDBrowser"
        Me.HDBrowser.ScriptErrorsSuppressed = True
        Me.HDBrowser.Size = New System.Drawing.Size(317, 258)
        Me.HDBrowser.TabIndex = 3
        Me.HDBrowser.Url = New System.Uri("", System.UriKind.Relative)
        Me.HDBrowser.WebBrowserShortcutsEnabled = False
        '
        'UrlToolStrip
        '
        Me.UrlToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.UrlToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryButton, Me.HomeButton, Me.UrlTextBox, Me.GoButton, Me.StopButton, Me.ToolStripSeparator5, Me.FavoritesButton})
        Me.UrlToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.UrlToolStrip.Name = "UrlToolStrip"
        Me.UrlToolStrip.Size = New System.Drawing.Size(317, 25)
        Me.UrlToolStrip.TabIndex = 4
        Me.UrlToolStrip.Text = "ToolStrip1"
        '
        'HistoryButton
        '
        Me.HistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HistoryButton.Image = CType(resources.GetObject("HistoryButton.Image"), System.Drawing.Image)
        Me.HistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(29, 22)
        Me.HistoryButton.Text = "History"
        '
        'HomeButton
        '
        Me.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), System.Drawing.Image)
        Me.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(23, 22)
        Me.HomeButton.Text = "Home"
        '
        'UrlTextBox
        '
        Me.UrlTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UrlTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.UrlTextBox.AutoSize = False
        Me.UrlTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(100, 25)
        Me.UrlTextBox.Text = "text"
        '
        'GoButton
        '
        Me.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoButton.Image = CType(resources.GetObject("GoButton.Image"), System.Drawing.Image)
        Me.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(23, 22)
        Me.GoButton.Text = "Go"
        Me.GoButton.ToolTipText = "Go to address"
        '
        'StopButton
        '
        Me.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StopButton.Image = CType(resources.GetObject("StopButton.Image"), System.Drawing.Image)
        Me.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(23, 22)
        Me.StopButton.Text = "Stop"
        Me.StopButton.ToolTipText = "Stop reading"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'FavoritesButton
        '
        Me.FavoritesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FavoritesButton.Image = CType(resources.GetObject("FavoritesButton.Image"), System.Drawing.Image)
        Me.FavoritesButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FavoritesButton.Name = "FavoritesButton"
        Me.FavoritesButton.Size = New System.Drawing.Size(29, 22)
        Me.FavoritesButton.Text = "Favorites"
        '
        'ElementsToolStripMenuItem
        '
        Me.ElementsToolStripMenuItem.Name = "ElementsToolStripMenuItem"
        Me.ElementsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ElementsToolStripMenuItem.Text = "Elements"
        '
        'KzOnePageWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HDBrowser)
        Me.Controls.Add(Me.CmdToolStrip)
        Me.Controls.Add(Me.UrlToolStrip)
        Me.Controls.Add(Me.WebStatus)
        Me.Name = "KzOnePageWeb"
        Me.Size = New System.Drawing.Size(317, 334)
        Me.CmdToolStrip.ResumeLayout(False)
        Me.CmdToolStrip.PerformLayout()
        Me.WebStatus.ResumeLayout(False)
        Me.WebStatus.PerformLayout()
        Me.UrlToolStrip.ResumeLayout(False)
        Me.UrlToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdToolStrip As ToolStrip
    Friend WithEvents GoBackButton As ToolStripButton
    Friend WithEvents GoForwardButton As ToolStripButton
    Friend WithEvents RefreshButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HtmlTitleLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SourceButton As ToolStripButton
    Friend WithEvents WebStatus As StatusStrip
    Friend WithEvents NowLabel As ToolStripStatusLabel
    Friend WithEvents HDBrowser As WebBrowser
    Friend WithEvents UrlToolStrip As ToolStrip
    Friend WithEvents HomeButton As ToolStripButton
    Friend WithEvents UrlTextBox As ToolStripTextBox
    Friend WithEvents GoButton As ToolStripButton
    Friend WithEvents HistoryButton As ToolStripDropDownButton
    Friend WithEvents SearchButton As ToolStripButton
    Friend WithEvents StopButton As ToolStripButton
    Friend WithEvents ToolsButton As ToolStripDropDownButton
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuSwitchButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents FavoritesButton As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnginesButton As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents IndexButton As ToolStripDropDownButton
    Friend WithEvents ElementsToolStripMenuItem As ToolStripMenuItem
End Class
