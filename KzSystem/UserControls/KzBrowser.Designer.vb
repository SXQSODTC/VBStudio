<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzBrowser
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
        Dim KzTabsAppearance1 As KzSystem.KzTabsAppearance = New KzSystem.KzTabsAppearance()
        Dim KzTabStatusAppearance1 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance2 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance3 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance4 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance5 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance6 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance7 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance8 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance9 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim KzTabStatusAppearance10 As KzSystem.KzTabStatusAppearance = New KzSystem.KzTabStatusAppearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzBrowser))
        Me.BroTools = New System.Windows.Forms.ToolStrip()
        Me.GoBackButton = New System.Windows.Forms.ToolStripButton()
        Me.GoForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UrlTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GoToButton = New System.Windows.Forms.ToolStripButton()
        Me.BroStatus = New System.Windows.Forms.StatusStrip()
        Me.WebStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BroTabs = New KzSystem.KzTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.CommandButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HistoryButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoHomeButton = New System.Windows.Forms.ToolStripButton()
        Me.BroTools.SuspendLayout()
        Me.BroStatus.SuspendLayout()
        Me.BroTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'BroTools
        '
        Me.BroTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryButton, Me.GoBackButton, Me.GoForwardButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.UrlTextBox, Me.GoToButton, Me.ToolStripSeparator2, Me.GoHomeButton})
        Me.BroTools.Location = New System.Drawing.Point(0, 0)
        Me.BroTools.Name = "BroTools"
        Me.BroTools.Size = New System.Drawing.Size(1016, 25)
        Me.BroTools.TabIndex = 0
        Me.BroTools.Text = "ToolStrip1"
        '
        'GoBackButton
        '
        Me.GoBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoBackButton.Image = CType(resources.GetObject("GoBackButton.Image"), System.Drawing.Image)
        Me.GoBackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(23, 22)
        Me.GoBackButton.Text = "ToolStripButton2"
        '
        'GoForwardButton
        '
        Me.GoForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoForwardButton.Image = CType(resources.GetObject("GoForwardButton.Image"), System.Drawing.Image)
        Me.GoForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoForwardButton.Name = "GoForwardButton"
        Me.GoForwardButton.Size = New System.Drawing.Size(23, 22)
        Me.GoForwardButton.Text = "ToolStripButton3"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshButton.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UrlTextBox
        '
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'GoToButton
        '
        Me.GoToButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoToButton.Image = CType(resources.GetObject("GoToButton.Image"), System.Drawing.Image)
        Me.GoToButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToButton.Name = "GoToButton"
        Me.GoToButton.Size = New System.Drawing.Size(23, 22)
        Me.GoToButton.Text = "ToolStripButton5"
        '
        'BroStatus
        '
        Me.BroStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommandButton, Me.WebStatusLabel})
        Me.BroStatus.Location = New System.Drawing.Point(0, 631)
        Me.BroStatus.Name = "BroStatus"
        Me.BroStatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.BroStatus.Size = New System.Drawing.Size(1016, 22)
        Me.BroStatus.TabIndex = 1
        Me.BroStatus.Text = "StatusStrip1"
        '
        'WebStatusLabel
        '
        Me.WebStatusLabel.Name = "WebStatusLabel"
        Me.WebStatusLabel.Size = New System.Drawing.Size(134, 17)
        Me.WebStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'BroTabs
        '
        Me.BroTabs.Controls.Add(Me.TabPage1)
        Me.BroTabs.Controls.Add(Me.TabPage2)
        Me.BroTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BroTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.BroTabs.ImageList = Me.Icons
        Me.BroTabs.ItemSize = New System.Drawing.Size(168, 24)
        Me.BroTabs.Location = New System.Drawing.Point(0, 25)
        Me.BroTabs.Name = "BroTabs"
        Me.BroTabs.NewAddedAutoSelect = True
        Me.BroTabs.NewTabType = KzSystem.KzTabControlNewTabType.DefaultTab
        Me.BroTabs.NewTitlePrefix = "NewTab"
        Me.BroTabs.SelectAfterAdd = True
        Me.BroTabs.SelectedIndex = 0
        Me.BroTabs.ShowAddNewTab = False
        Me.BroTabs.SignLabel = Nothing
        Me.BroTabs.Size = New System.Drawing.Size(1016, 606)
        Me.BroTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.BroTabs.TabIndex = 2
        KzTabsAppearance1.BoldLine = 2
        KzTabsAppearance1.ButtonMargin = New System.Windows.Forms.Padding(2)
        KzTabsAppearance1.NormalLine = 1
        KzTabsAppearance1.NormalTabCanClose = False
        KzTabsAppearance1.Radius = 5
        KzTabsAppearance1.RadiusSide = KzSystem.KzFlatCorners.None
        KzTabsAppearance1.SelectedTabCanClose = False
        KzTabStatusAppearance1.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance1.BoldBorder = False
        KzTabStatusAppearance1.BoldFore = False
        KzTabStatusAppearance1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance1.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance1.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance1.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance1.ShowBorder = False
        KzTabStatusAppearance1.ShowShadow = False
        KzTabsAppearance1.SetOfAddNewTab = KzTabStatusAppearance1
        KzTabStatusAppearance2.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance2.BoldBorder = False
        KzTabStatusAppearance2.BoldFore = False
        KzTabStatusAppearance2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance2.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance2.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance2.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance2.ShowBorder = False
        KzTabStatusAppearance2.ShowShadow = False
        KzTabsAppearance1.SetOfAddNewTabHover = KzTabStatusAppearance2
        KzTabStatusAppearance3.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance3.BoldBorder = False
        KzTabStatusAppearance3.BoldFore = False
        KzTabStatusAppearance3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance3.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance3.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance3.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance3.ShowBorder = False
        KzTabStatusAppearance3.ShowShadow = False
        KzTabsAppearance1.SetOfNormalButton = KzTabStatusAppearance3
        KzTabStatusAppearance4.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance4.BoldBorder = False
        KzTabStatusAppearance4.BoldFore = False
        KzTabStatusAppearance4.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance4.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance4.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance4.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance4.ShowBorder = False
        KzTabStatusAppearance4.ShowShadow = False
        KzTabsAppearance1.SetOfNormalButtonHover = KzTabStatusAppearance4
        KzTabStatusAppearance5.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance5.BoldBorder = False
        KzTabStatusAppearance5.BoldFore = False
        KzTabStatusAppearance5.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance5.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance5.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance5.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance5.ShowBorder = False
        KzTabStatusAppearance5.ShowShadow = False
        KzTabsAppearance1.SetOfNormalTab = KzTabStatusAppearance5
        KzTabStatusAppearance6.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance6.BoldBorder = False
        KzTabStatusAppearance6.BoldFore = False
        KzTabStatusAppearance6.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance6.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance6.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance6.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance6.ShowBorder = False
        KzTabStatusAppearance6.ShowShadow = False
        KzTabsAppearance1.SetOfNormalTabHover = KzTabStatusAppearance6
        KzTabStatusAppearance7.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance7.BoldBorder = False
        KzTabStatusAppearance7.BoldFore = False
        KzTabStatusAppearance7.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance7.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance7.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance7.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance7.ShowBorder = False
        KzTabStatusAppearance7.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedButton = KzTabStatusAppearance7
        KzTabStatusAppearance8.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance8.BoldBorder = False
        KzTabStatusAppearance8.BoldFore = False
        KzTabStatusAppearance8.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance8.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance8.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance8.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance8.ShowBorder = False
        KzTabStatusAppearance8.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedButtonHover = KzTabStatusAppearance8
        KzTabStatusAppearance9.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance9.BoldBorder = False
        KzTabStatusAppearance9.BoldFore = False
        KzTabStatusAppearance9.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance9.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance9.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance9.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance9.ShowBorder = False
        KzTabStatusAppearance9.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedTab = KzTabStatusAppearance9
        KzTabStatusAppearance10.BackColor = System.Drawing.SystemColors.Control
        KzTabStatusAppearance10.BoldBorder = False
        KzTabStatusAppearance10.BoldFore = False
        KzTabStatusAppearance10.BorderColor = System.Drawing.SystemColors.ActiveBorder
        KzTabStatusAppearance10.ForeColor = System.Drawing.SystemColors.ControlText
        KzTabStatusAppearance10.ShadowColor = System.Drawing.SystemColors.ButtonShadow
        KzTabStatusAppearance10.ShadowSide = KzSystem.KzFlatSides.None
        KzTabStatusAppearance10.ShowBorder = False
        KzTabStatusAppearance10.ShowShadow = False
        KzTabsAppearance1.SetOfSelectedTabHover = KzTabStatusAppearance10
        KzTabsAppearance1.ShowIcon = False
        KzTabsAppearance1.ShowRadius = False
        KzTabsAppearance1.TabPageStyle = KzSystem.KzTabPageStyle.None
        KzTabsAppearance1.TabsAutoWidth = False
        KzTabsAppearance1.TextMargin = New System.Windows.Forms.Padding(1)
        Me.BroTabs.TabsAppearance = KzTabsAppearance1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1008, 574)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1008, 574)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1008, 576)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "+"
        Me.TabPage4.Visible = False
        '
        'Icons
        '
        Me.Icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.Icons.ImageSize = New System.Drawing.Size(16, 16)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'CommandButton
        '
        Me.CommandButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CommandButton.Image = CType(resources.GetObject("CommandButton.Image"), System.Drawing.Image)
        Me.CommandButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CommandButton.Name = "CommandButton"
        Me.CommandButton.Size = New System.Drawing.Size(29, 20)
        Me.CommandButton.Text = "ToolStripDropDownButton1"
        '
        'HistoryButton
        '
        Me.HistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HistoryButton.Image = CType(resources.GetObject("HistoryButton.Image"), System.Drawing.Image)
        Me.HistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(29, 22)
        Me.HistoryButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'GoHomeButton
        '
        Me.GoHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoHomeButton.Image = CType(resources.GetObject("GoHomeButton.Image"), System.Drawing.Image)
        Me.GoHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoHomeButton.Name = "GoHomeButton"
        Me.GoHomeButton.Size = New System.Drawing.Size(23, 22)
        Me.GoHomeButton.Text = "ToolStripButton1"
        '
        'KzBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BroTabs)
        Me.Controls.Add(Me.BroStatus)
        Me.Controls.Add(Me.BroTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzBrowser"
        Me.Size = New System.Drawing.Size(1016, 653)
        Me.BroTools.ResumeLayout(False)
        Me.BroTools.PerformLayout()
        Me.BroStatus.ResumeLayout(False)
        Me.BroStatus.PerformLayout()
        Me.BroTabs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BroTools As ToolStrip
    Friend WithEvents BroStatus As StatusStrip
    Friend WithEvents BroTabs As KzTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Icons As ImageList
    Friend WithEvents GoBackButton As ToolStripButton
    Friend WithEvents GoForwardButton As ToolStripButton
    Friend WithEvents RefreshButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UrlTextBox As ToolStripTextBox
    Friend WithEvents GoToButton As ToolStripButton
    Friend WithEvents WebStatusLabel As ToolStripStatusLabel
    Friend WithEvents CommandButton As ToolStripDropDownButton
    Friend WithEvents HistoryButton As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents GoHomeButton As ToolStripButton
End Class
