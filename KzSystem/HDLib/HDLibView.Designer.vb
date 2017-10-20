<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HDLibView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDLibView))
        Me.LibDataContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LibMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.DEditUrlListButton = New System.Windows.Forms.Button()
        Me.LibSpliter = New System.Windows.Forms.SplitContainer()
        Me.InnerSpliter = New System.Windows.Forms.SplitContainer()
        Me.LibView = New KzSystem.HDLibTree()
        Me.LibSearchTools = New System.Windows.Forms.ToolStrip()
        Me.LibSearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.LibSearchGoButton = New System.Windows.Forms.ToolStripButton()
        Me.LibSearchAdvanceButton = New System.Windows.Forms.ToolStripButton()
        Me.DetailSpliter = New System.Windows.Forms.SplitContainer()
        Me.HeaderSpliter = New System.Windows.Forms.SplitContainer()
        Me.HCoverImageBox = New System.Windows.Forms.PictureBox()
        Me.ViewBookInfoPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.HPilotLabel = New System.Windows.Forms.Label()
        Me.LabelHDescreption = New System.Windows.Forms.Label()
        Me.HAuthorLabel = New System.Windows.Forms.Label()
        Me.LabelHAuthor = New System.Windows.Forms.Label()
        Me.HTitleLabel = New System.Windows.Forms.Label()
        Me.LabelHSubject = New System.Windows.Forms.Label()
        Me.LabelHID = New System.Windows.Forms.Label()
        Me.HIDLabel = New System.Windows.Forms.Label()
        Me.HIcon = New System.Windows.Forms.PictureBox()
        Me.DetailTabs = New System.Windows.Forms.TabControl()
        Me.PageBook = New System.Windows.Forms.TabPage()
        Me.BookDataPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.CContansChecker = New System.Windows.Forms.CheckBox()
        Me.CLinksChecker = New System.Windows.Forms.CheckBox()
        Me.CManifestChecker = New System.Windows.Forms.CheckBox()
        Me.CEmptyChecker = New System.Windows.Forms.CheckBox()
        Me.CLogoFileChecker = New System.Windows.Forms.CheckBox()
        Me.CInfFileChecker = New System.Windows.Forms.CheckBox()
        Me.CreatedTextBox = New System.Windows.Forms.TextBox()
        Me.UpdatedTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.RefaddressTextBox = New System.Windows.Forms.TextBox()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.LogoTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.LabelCreated = New System.Windows.Forms.Label()
        Me.LabelUpdated = New System.Windows.Forms.Label()
        Me.LabelRefaddress = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.SeriesTextBox = New System.Windows.Forms.TextBox()
        Me.LabelSeries = New System.Windows.Forms.Label()
        Me.LabelOrigin = New System.Windows.Forms.Label()
        Me.ContributorTextBox = New System.Windows.Forms.TextBox()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelSpecial = New System.Windows.Forms.Label()
        Me.LabelCategory = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelContributor = New System.Windows.Forms.Label()
        Me.LabelAuthor = New System.Windows.Forms.Label()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.OriginComboBox = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CFolderChecker = New System.Windows.Forms.CheckBox()
        Me.SeriesIDUD = New System.Windows.Forms.NumericUpDown()
        Me.PageIntro = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.LabelRemarks = New System.Windows.Forms.Label()
        Me.PageFiles = New System.Windows.Forms.TabPage()
        Me.FilesView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LengthColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SizeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfoColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CreatedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListEditPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LViewButton = New System.Windows.Forms.Button()
        Me.LWritedLabel = New System.Windows.Forms.Label()
        Me.LAccessedLabel = New System.Windows.Forms.Label()
        Me.LCreatedLabel = New System.Windows.Forms.Label()
        Me.LFileNameLabel = New System.Windows.Forms.Label()
        Me.LabelComments = New System.Windows.Forms.Label()
        Me.LCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.LUpdateButton = New System.Windows.Forms.Button()
        Me.LInTimeChecker = New System.Windows.Forms.CheckBox()
        Me.PageLinks = New System.Windows.Forms.TabPage()
        Me.LinksView = New System.Windows.Forms.ListView()
        Me.UKeyColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ULinkColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LinkEditPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.UAddButton = New System.Windows.Forms.Button()
        Me.UDownButton = New System.Windows.Forms.Button()
        Me.UBroButton = New System.Windows.Forms.Button()
        Me.UUpdateButton = New System.Windows.Forms.Button()
        Me.ULinkTextBox = New System.Windows.Forms.TextBox()
        Me.LabelULink = New System.Windows.Forms.Label()
        Me.UKeyTextBox = New System.Windows.Forms.TextBox()
        Me.LabelUKey = New System.Windows.Forms.Label()
        Me.PageDownload = New System.Windows.Forms.TabPage()
        Me.DownloadPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.LabelDFileName = New System.Windows.Forms.Label()
        Me.LabelDUrlList = New System.Windows.Forms.Label()
        Me.DRunButton = New System.Windows.Forms.Button()
        Me.DChangePathButton = New System.Windows.Forms.Button()
        Me.DFolderTextBox = New System.Windows.Forms.TextBox()
        Me.DLinkTextBox = New System.Windows.Forms.TextBox()
        Me.LabelDFolder = New System.Windows.Forms.Label()
        Me.LabelDLink = New System.Windows.Forms.Label()
        Me.DUrlListBox = New System.Windows.Forms.ListBox()
        Me.DProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DMsgLabel = New System.Windows.Forms.Label()
        Me.DFileExistsChecker = New System.Windows.Forms.CheckBox()
        Me.DFolderExistsChecker = New System.Windows.Forms.CheckBox()
        Me.DToCoverChecker = New System.Windows.Forms.CheckBox()
        Me.DPersentageLabel = New System.Windows.Forms.Label()
        Me.InfTools = New System.Windows.Forms.ToolStrip()
        Me.UpdateInfButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelEditButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowInfButton = New System.Windows.Forms.ToolStripButton()
        Me.TryGetButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HDBookInfoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryInfoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OriginListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DBBookTableItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenDataPanelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SettingsButton = New System.Windows.Forms.ToolStripButton()
        Me.LibStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TreeStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CurrentNodeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BrowserTabs = New System.Windows.Forms.TabControl()
        Me.PageWeb = New System.Windows.Forms.TabPage()
        Me.WebViewer = New KzSystem.KzOnePageWeb()
        Me.PageView = New System.Windows.Forms.TabPage()
        Me.QuickViewer = New KzSystem.KzSingleEditor()
        Me.PageImage = New System.Windows.Forms.TabPage()
        Me.InfoGroup = New System.Windows.Forms.GroupBox()
        Me.FileInfoLabel = New System.Windows.Forms.Label()
        Me.ImgGroup = New System.Windows.Forms.GroupBox()
        Me.ImgPreviewBox = New System.Windows.Forms.PictureBox()
        Me.PageLogs = New System.Windows.Forms.TabPage()
        Me.LibMenu.SuspendLayout()
        CType(Me.LibSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibSpliter.Panel1.SuspendLayout()
        Me.LibSpliter.Panel2.SuspendLayout()
        Me.LibSpliter.SuspendLayout()
        CType(Me.InnerSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InnerSpliter.Panel1.SuspendLayout()
        Me.InnerSpliter.Panel2.SuspendLayout()
        Me.InnerSpliter.SuspendLayout()
        Me.LibSearchTools.SuspendLayout()
        CType(Me.DetailSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailSpliter.Panel1.SuspendLayout()
        Me.DetailSpliter.Panel2.SuspendLayout()
        Me.DetailSpliter.SuspendLayout()
        CType(Me.HeaderSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderSpliter.Panel1.SuspendLayout()
        Me.HeaderSpliter.Panel2.SuspendLayout()
        Me.HeaderSpliter.SuspendLayout()
        CType(Me.HCoverImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewBookInfoPanel.SuspendLayout()
        CType(Me.HIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailTabs.SuspendLayout()
        Me.PageBook.SuspendLayout()
        Me.BookDataPanel.SuspendLayout()
        CType(Me.SeriesIDUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageIntro.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PageFiles.SuspendLayout()
        Me.ListEditPanel.SuspendLayout()
        Me.PageLinks.SuspendLayout()
        Me.LinkEditPanel.SuspendLayout()
        Me.PageDownload.SuspendLayout()
        Me.DownloadPanel.SuspendLayout()
        Me.InfTools.SuspendLayout()
        Me.LibStatusStrip.SuspendLayout()
        Me.BrowserTabs.SuspendLayout()
        Me.PageWeb.SuspendLayout()
        Me.PageView.SuspendLayout()
        Me.PageImage.SuspendLayout()
        Me.InfoGroup.SuspendLayout()
        Me.ImgGroup.SuspendLayout()
        CType(Me.ImgPreviewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibDataContextMenu
        '
        Me.LibDataContextMenu.Name = "LibDataContextMenu"
        Me.LibDataContextMenu.Size = New System.Drawing.Size(153, 26)
        '
        'LibMenu
        '
        Me.LibMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.LibMenu.Location = New System.Drawing.Point(0, 0)
        Me.LibMenu.Name = "LibMenu"
        Me.LibMenu.Size = New System.Drawing.Size(843, 25)
        Me.LibMenu.TabIndex = 1
        Me.LibMenu.Text = "MenuStrip1"
        Me.LibMenu.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibRootToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LibRootToolStripMenuItem
        '
        Me.LibRootToolStripMenuItem.Name = "LibRootToolStripMenuItem"
        Me.LibRootToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LibRootToolStripMenuItem.Text = "LibRoot"
        '
        'DEditUrlListButton
        '
        Me.DEditUrlListButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DEditUrlListButton.FlatAppearance.BorderSize = 0
        Me.DEditUrlListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DEditUrlListButton.Location = New System.Drawing.Point(15, 122)
        Me.DEditUrlListButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DEditUrlListButton.Name = "DEditUrlListButton"
        Me.DEditUrlListButton.Size = New System.Drawing.Size(25, 22)
        Me.DEditUrlListButton.TabIndex = 20
        Me.DEditUrlListButton.Text = "+"
        Me.DEditUrlListButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.LibTips.SetToolTip(Me.DEditUrlListButton, "編輯既定填入列表")
        Me.DEditUrlListButton.UseVisualStyleBackColor = True
        '
        'LibSpliter
        '
        Me.LibSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibSpliter.Location = New System.Drawing.Point(0, 0)
        Me.LibSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LibSpliter.Name = "LibSpliter"
        '
        'LibSpliter.Panel1
        '
        Me.LibSpliter.Panel1.Controls.Add(Me.InnerSpliter)
        Me.LibSpliter.Panel1.Controls.Add(Me.LibStatusStrip)
        '
        'LibSpliter.Panel2
        '
        Me.LibSpliter.Panel2.Controls.Add(Me.BrowserTabs)
        Me.LibSpliter.Size = New System.Drawing.Size(843, 505)
        Me.LibSpliter.SplitterDistance = 524
        Me.LibSpliter.SplitterWidth = 5
        Me.LibSpliter.TabIndex = 0
        '
        'InnerSpliter
        '
        Me.InnerSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InnerSpliter.Location = New System.Drawing.Point(0, 0)
        Me.InnerSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InnerSpliter.Name = "InnerSpliter"
        '
        'InnerSpliter.Panel1
        '
        Me.InnerSpliter.Panel1.Controls.Add(Me.LibView)
        Me.InnerSpliter.Panel1.Controls.Add(Me.LibSearchTools)
        '
        'InnerSpliter.Panel2
        '
        Me.InnerSpliter.Panel2.Controls.Add(Me.DetailSpliter)
        Me.InnerSpliter.Panel2.Controls.Add(Me.InfTools)
        Me.InnerSpliter.Size = New System.Drawing.Size(524, 479)
        Me.InnerSpliter.SplitterDistance = 173
        Me.InnerSpliter.SplitterWidth = 5
        Me.InnerSpliter.TabIndex = 0
        '
        'LibView
        '
        Me.LibView.AllowDrop = True
        Me.LibView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibView.ExceptFolders = CType(resources.GetObject("LibView.ExceptFolders"), System.Collections.Specialized.StringCollection)
        Me.LibView.HideSelection = False
        Me.LibView.ImageIndex = 0
        Me.LibView.LabelEdit = True
        Me.LibView.LibRoot = "C:\"
        Me.LibView.LineColor = System.Drawing.Color.DarkCyan
        Me.LibView.Location = New System.Drawing.Point(0, 25)
        Me.LibView.Name = "LibView"
        Me.LibView.SelectedImageIndex = 0
        Me.LibView.Size = New System.Drawing.Size(173, 454)
        Me.LibView.TabIndex = 3
        '
        'LibSearchTools
        '
        Me.LibSearchTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LibSearchTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibSearchTextBox, Me.LibSearchGoButton, Me.LibSearchAdvanceButton})
        Me.LibSearchTools.Location = New System.Drawing.Point(0, 0)
        Me.LibSearchTools.Name = "LibSearchTools"
        Me.LibSearchTools.Size = New System.Drawing.Size(173, 25)
        Me.LibSearchTools.TabIndex = 1
        Me.LibSearchTools.Text = "ToolStrip1"
        '
        'LibSearchTextBox
        '
        Me.LibSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.LibSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.LibSearchTextBox.AutoSize = False
        Me.LibSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibSearchTextBox.Name = "LibSearchTextBox"
        Me.LibSearchTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'LibSearchGoButton
        '
        Me.LibSearchGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibSearchGoButton.Image = CType(resources.GetObject("LibSearchGoButton.Image"), System.Drawing.Image)
        Me.LibSearchGoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LibSearchGoButton.Name = "LibSearchGoButton"
        Me.LibSearchGoButton.Size = New System.Drawing.Size(23, 22)
        Me.LibSearchGoButton.Text = "SearchGo"
        Me.LibSearchGoButton.ToolTipText = "Search Go"
        '
        'LibSearchAdvanceButton
        '
        Me.LibSearchAdvanceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibSearchAdvanceButton.Image = CType(resources.GetObject("LibSearchAdvanceButton.Image"), System.Drawing.Image)
        Me.LibSearchAdvanceButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LibSearchAdvanceButton.Name = "LibSearchAdvanceButton"
        Me.LibSearchAdvanceButton.Size = New System.Drawing.Size(23, 22)
        Me.LibSearchAdvanceButton.Text = "AdvanceSearch"
        Me.LibSearchAdvanceButton.ToolTipText = "Advance Search"
        '
        'DetailSpliter
        '
        Me.DetailSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DetailSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.DetailSpliter.Location = New System.Drawing.Point(0, 25)
        Me.DetailSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DetailSpliter.Name = "DetailSpliter"
        Me.DetailSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'DetailSpliter.Panel1
        '
        Me.DetailSpliter.Panel1.Controls.Add(Me.HeaderSpliter)
        '
        'DetailSpliter.Panel2
        '
        Me.DetailSpliter.Panel2.Controls.Add(Me.DetailTabs)
        Me.DetailSpliter.Size = New System.Drawing.Size(346, 454)
        Me.DetailSpliter.SplitterDistance = 177
        Me.DetailSpliter.SplitterWidth = 3
        Me.DetailSpliter.TabIndex = 0
        '
        'HeaderSpliter
        '
        Me.HeaderSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderSpliter.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HeaderSpliter.Name = "HeaderSpliter"
        '
        'HeaderSpliter.Panel1
        '
        Me.HeaderSpliter.Panel1.AllowDrop = True
        Me.HeaderSpliter.Panel1.Controls.Add(Me.HCoverImageBox)
        '
        'HeaderSpliter.Panel2
        '
        Me.HeaderSpliter.Panel2.Controls.Add(Me.ViewBookInfoPanel)
        Me.HeaderSpliter.Size = New System.Drawing.Size(344, 175)
        Me.HeaderSpliter.SplitterDistance = 125
        Me.HeaderSpliter.SplitterWidth = 5
        Me.HeaderSpliter.TabIndex = 1
        '
        'HCoverImageBox
        '
        Me.HCoverImageBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HCoverImageBox.Location = New System.Drawing.Point(0, 0)
        Me.HCoverImageBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HCoverImageBox.Name = "HCoverImageBox"
        Me.HCoverImageBox.Size = New System.Drawing.Size(125, 175)
        Me.HCoverImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HCoverImageBox.TabIndex = 0
        Me.HCoverImageBox.TabStop = False
        '
        'ViewBookInfoPanel
        '
        Me.ViewBookInfoPanel.ColumnCount = 3
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.ViewBookInfoPanel.Controls.Add(Me.HPilotLabel, 1, 3)
        Me.ViewBookInfoPanel.Controls.Add(Me.LabelHDescreption, 0, 3)
        Me.ViewBookInfoPanel.Controls.Add(Me.HAuthorLabel, 1, 2)
        Me.ViewBookInfoPanel.Controls.Add(Me.LabelHAuthor, 0, 2)
        Me.ViewBookInfoPanel.Controls.Add(Me.HTitleLabel, 1, 1)
        Me.ViewBookInfoPanel.Controls.Add(Me.LabelHSubject, 0, 1)
        Me.ViewBookInfoPanel.Controls.Add(Me.LabelHID, 0, 0)
        Me.ViewBookInfoPanel.Controls.Add(Me.HIDLabel, 1, 0)
        Me.ViewBookInfoPanel.Controls.Add(Me.HIcon, 2, 0)
        Me.ViewBookInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewBookInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.ViewBookInfoPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ViewBookInfoPanel.Name = "ViewBookInfoPanel"
        Me.ViewBookInfoPanel.RowCount = 4
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ViewBookInfoPanel.Size = New System.Drawing.Size(214, 175)
        Me.ViewBookInfoPanel.TabIndex = 0
        '
        'HPilotLabel
        '
        Me.HPilotLabel.AutoEllipsis = True
        Me.ViewBookInfoPanel.SetColumnSpan(Me.HPilotLabel, 2)
        Me.HPilotLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HPilotLabel.Location = New System.Drawing.Point(43, 99)
        Me.HPilotLabel.Name = "HPilotLabel"
        Me.HPilotLabel.Size = New System.Drawing.Size(168, 76)
        Me.HPilotLabel.TabIndex = 7
        Me.HPilotLabel.Text = "Pilot"
        '
        'LabelHDescreption
        '
        Me.LabelHDescreption.AutoSize = True
        Me.LabelHDescreption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelHDescreption.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelHDescreption.Location = New System.Drawing.Point(3, 99)
        Me.LabelHDescreption.Name = "LabelHDescreption"
        Me.LabelHDescreption.Size = New System.Drawing.Size(34, 76)
        Me.LabelHDescreption.TabIndex = 6
        Me.LabelHDescreption.Text = "簡介"
        Me.LabelHDescreption.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HAuthorLabel
        '
        Me.HAuthorLabel.AutoEllipsis = True
        Me.ViewBookInfoPanel.SetColumnSpan(Me.HAuthorLabel, 2)
        Me.HAuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HAuthorLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HAuthorLabel.Location = New System.Drawing.Point(43, 69)
        Me.HAuthorLabel.Name = "HAuthorLabel"
        Me.HAuthorLabel.Size = New System.Drawing.Size(168, 30)
        Me.HAuthorLabel.TabIndex = 5
        Me.HAuthorLabel.Text = "作者"
        Me.HAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelHAuthor
        '
        Me.LabelHAuthor.AutoSize = True
        Me.LabelHAuthor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelHAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelHAuthor.Location = New System.Drawing.Point(3, 69)
        Me.LabelHAuthor.Name = "LabelHAuthor"
        Me.LabelHAuthor.Size = New System.Drawing.Size(34, 30)
        Me.LabelHAuthor.TabIndex = 4
        Me.LabelHAuthor.Text = "作者"
        Me.LabelHAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HTitleLabel
        '
        Me.HTitleLabel.AutoEllipsis = True
        Me.ViewBookInfoPanel.SetColumnSpan(Me.HTitleLabel, 2)
        Me.HTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HTitleLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HTitleLabel.Location = New System.Drawing.Point(43, 24)
        Me.HTitleLabel.Name = "HTitleLabel"
        Me.HTitleLabel.Size = New System.Drawing.Size(168, 45)
        Me.HTitleLabel.TabIndex = 3
        Me.HTitleLabel.Text = "書籍標題"
        Me.HTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelHSubject
        '
        Me.LabelHSubject.AutoSize = True
        Me.LabelHSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelHSubject.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelHSubject.Location = New System.Drawing.Point(3, 24)
        Me.LabelHSubject.Name = "LabelHSubject"
        Me.LabelHSubject.Size = New System.Drawing.Size(34, 45)
        Me.LabelHSubject.TabIndex = 2
        Me.LabelHSubject.Text = "書名"
        Me.LabelHSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelHID
        '
        Me.LabelHID.AutoSize = True
        Me.LabelHID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelHID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelHID.Location = New System.Drawing.Point(3, 0)
        Me.LabelHID.Name = "LabelHID"
        Me.LabelHID.Size = New System.Drawing.Size(34, 24)
        Me.LabelHID.TabIndex = 0
        Me.LabelHID.Text = "編號"
        Me.LabelHID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HIDLabel
        '
        Me.HIDLabel.AutoEllipsis = True
        Me.HIDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HIDLabel.Location = New System.Drawing.Point(43, 0)
        Me.HIDLabel.Name = "HIDLabel"
        Me.HIDLabel.Size = New System.Drawing.Size(115, 24)
        Me.HIDLabel.TabIndex = 1
        Me.HIDLabel.Text = "ID"
        Me.HIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HIcon
        '
        Me.HIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HIcon.Location = New System.Drawing.Point(177, 2)
        Me.HIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.HIcon.Name = "HIcon"
        Me.HIcon.Size = New System.Drawing.Size(20, 20)
        Me.HIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HIcon.TabIndex = 8
        Me.HIcon.TabStop = False
        '
        'DetailTabs
        '
        Me.DetailTabs.Controls.Add(Me.PageBook)
        Me.DetailTabs.Controls.Add(Me.PageIntro)
        Me.DetailTabs.Controls.Add(Me.PageFiles)
        Me.DetailTabs.Controls.Add(Me.PageLinks)
        Me.DetailTabs.Controls.Add(Me.PageDownload)
        Me.DetailTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailTabs.Location = New System.Drawing.Point(0, 0)
        Me.DetailTabs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DetailTabs.Name = "DetailTabs"
        Me.DetailTabs.SelectedIndex = 0
        Me.DetailTabs.Size = New System.Drawing.Size(344, 272)
        Me.DetailTabs.TabIndex = 0
        '
        'PageBook
        '
        Me.PageBook.AutoScroll = True
        Me.PageBook.Controls.Add(Me.BookDataPanel)
        Me.PageBook.Location = New System.Drawing.Point(4, 26)
        Me.PageBook.Name = "PageBook"
        Me.PageBook.Padding = New System.Windows.Forms.Padding(3)
        Me.PageBook.Size = New System.Drawing.Size(336, 242)
        Me.PageBook.TabIndex = 0
        Me.PageBook.Text = "書籍"
        Me.PageBook.UseVisualStyleBackColor = True
        '
        'BookDataPanel
        '
        Me.BookDataPanel.ColumnCount = 6
        Me.BookDataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.BookDataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BookDataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.BookDataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BookDataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BookDataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.BookDataPanel.Controls.Add(Me.CContansChecker, 1, 16)
        Me.BookDataPanel.Controls.Add(Me.CLinksChecker, 3, 15)
        Me.BookDataPanel.Controls.Add(Me.CManifestChecker, 1, 15)
        Me.BookDataPanel.Controls.Add(Me.CEmptyChecker, 4, 12)
        Me.BookDataPanel.Controls.Add(Me.CLogoFileChecker, 1, 14)
        Me.BookDataPanel.Controls.Add(Me.CInfFileChecker, 1, 13)
        Me.BookDataPanel.Controls.Add(Me.CreatedTextBox, 1, 9)
        Me.BookDataPanel.Controls.Add(Me.UpdatedTextBox, 3, 9)
        Me.BookDataPanel.Controls.Add(Me.AddressTextBox, 1, 8)
        Me.BookDataPanel.Controls.Add(Me.RefaddressTextBox, 3, 8)
        Me.BookDataPanel.Controls.Add(Me.VersionTextBox, 1, 7)
        Me.BookDataPanel.Controls.Add(Me.LogoTextBox, 3, 7)
        Me.BookDataPanel.Controls.Add(Me.SpecialTextBox, 1, 6)
        Me.BookDataPanel.Controls.Add(Me.CategoryTextBox, 1, 5)
        Me.BookDataPanel.Controls.Add(Me.LabelCreated, 0, 9)
        Me.BookDataPanel.Controls.Add(Me.LabelUpdated, 2, 9)
        Me.BookDataPanel.Controls.Add(Me.LabelRefaddress, 2, 8)
        Me.BookDataPanel.Controls.Add(Me.LabelAddress, 0, 8)
        Me.BookDataPanel.Controls.Add(Me.LabelLogo, 2, 7)
        Me.BookDataPanel.Controls.Add(Me.SeriesTextBox, 1, 2)
        Me.BookDataPanel.Controls.Add(Me.LabelSeries, 0, 2)
        Me.BookDataPanel.Controls.Add(Me.LabelOrigin, 3, 3)
        Me.BookDataPanel.Controls.Add(Me.ContributorTextBox, 1, 4)
        Me.BookDataPanel.Controls.Add(Me.LabelVersion, 0, 7)
        Me.BookDataPanel.Controls.Add(Me.LabelSpecial, 0, 6)
        Me.BookDataPanel.Controls.Add(Me.LabelCategory, 0, 5)
        Me.BookDataPanel.Controls.Add(Me.AuthorTextBox, 1, 3)
        Me.BookDataPanel.Controls.Add(Me.NameTextBox, 1, 1)
        Me.BookDataPanel.Controls.Add(Me.LabelID, 2, 0)
        Me.BookDataPanel.Controls.Add(Me.LabelContributor, 0, 4)
        Me.BookDataPanel.Controls.Add(Me.LabelAuthor, 0, 3)
        Me.BookDataPanel.Controls.Add(Me.LabelSubject, 0, 1)
        Me.BookDataPanel.Controls.Add(Me.LabelType, 0, 0)
        Me.BookDataPanel.Controls.Add(Me.TypeComboBox, 1, 0)
        Me.BookDataPanel.Controls.Add(Me.IDTextBox, 3, 0)
        Me.BookDataPanel.Controls.Add(Me.OriginComboBox, 4, 3)
        Me.BookDataPanel.Controls.Add(Me.Label18, 0, 11)
        Me.BookDataPanel.Controls.Add(Me.CFolderChecker, 1, 12)
        Me.BookDataPanel.Controls.Add(Me.SeriesIDUD, 4, 2)
        Me.BookDataPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BookDataPanel.Location = New System.Drawing.Point(3, 3)
        Me.BookDataPanel.Name = "BookDataPanel"
        Me.BookDataPanel.RowCount = 17
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BookDataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BookDataPanel.Size = New System.Drawing.Size(313, 388)
        Me.BookDataPanel.TabIndex = 0
        '
        'CContansChecker
        '
        Me.CContansChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CContansChecker, 4)
        Me.CContansChecker.Enabled = False
        Me.CContansChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CContansChecker.Location = New System.Drawing.Point(48, 366)
        Me.CContansChecker.Name = "CContansChecker"
        Me.CContansChecker.Size = New System.Drawing.Size(74, 17)
        Me.CContansChecker.TabIndex = 41
        Me.CContansChecker.Text = "Contains"
        Me.CContansChecker.UseVisualStyleBackColor = True
        '
        'CLinksChecker
        '
        Me.CLinksChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CLinksChecker, 2)
        Me.CLinksChecker.Enabled = False
        Me.CLinksChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLinksChecker.Location = New System.Drawing.Point(189, 344)
        Me.CLinksChecker.Name = "CLinksChecker"
        Me.CLinksChecker.Size = New System.Drawing.Size(90, 16)
        Me.CLinksChecker.TabIndex = 38
        Me.CLinksChecker.Text = "Links exists"
        Me.CLinksChecker.UseVisualStyleBackColor = True
        '
        'CManifestChecker
        '
        Me.CManifestChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CManifestChecker, 2)
        Me.CManifestChecker.Enabled = False
        Me.CManifestChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CManifestChecker.Location = New System.Drawing.Point(48, 344)
        Me.CManifestChecker.Name = "CManifestChecker"
        Me.CManifestChecker.Size = New System.Drawing.Size(116, 16)
        Me.CManifestChecker.TabIndex = 37
        Me.CManifestChecker.Text = "Manifest exists"
        Me.CManifestChecker.UseVisualStyleBackColor = True
        '
        'CEmptyChecker
        '
        Me.CEmptyChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CEmptyChecker, 2)
        Me.CEmptyChecker.Enabled = False
        Me.CEmptyChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEmptyChecker.Location = New System.Drawing.Point(237, 278)
        Me.CEmptyChecker.Name = "CEmptyChecker"
        Me.CEmptyChecker.Size = New System.Drawing.Size(68, 16)
        Me.CEmptyChecker.TabIndex = 36
        Me.CEmptyChecker.Text = "IsEmpty"
        Me.CEmptyChecker.UseVisualStyleBackColor = True
        '
        'CLogoFileChecker
        '
        Me.CLogoFileChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CLogoFileChecker, 3)
        Me.CLogoFileChecker.Enabled = False
        Me.CLogoFileChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLogoFileChecker.Location = New System.Drawing.Point(48, 322)
        Me.CLogoFileChecker.Name = "CLogoFileChecker"
        Me.CLogoFileChecker.Size = New System.Drawing.Size(74, 16)
        Me.CLogoFileChecker.TabIndex = 35
        Me.CLogoFileChecker.Text = "LogoFile"
        Me.CLogoFileChecker.UseVisualStyleBackColor = True
        '
        'CInfFileChecker
        '
        Me.CInfFileChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CInfFileChecker, 3)
        Me.CInfFileChecker.Enabled = False
        Me.CInfFileChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CInfFileChecker.Location = New System.Drawing.Point(48, 300)
        Me.CInfFileChecker.Name = "CInfFileChecker"
        Me.CInfFileChecker.Size = New System.Drawing.Size(68, 16)
        Me.CInfFileChecker.TabIndex = 34
        Me.CInfFileChecker.Text = "InfFile"
        Me.CInfFileChecker.UseVisualStyleBackColor = True
        '
        'CreatedTextBox
        '
        Me.CreatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreatedTextBox.Location = New System.Drawing.Point(46, 218)
        Me.CreatedTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CreatedTextBox.Name = "CreatedTextBox"
        Me.CreatedTextBox.ReadOnly = True
        Me.CreatedTextBox.Size = New System.Drawing.Size(94, 23)
        Me.CreatedTextBox.TabIndex = 29
        '
        'UpdatedTextBox
        '
        Me.BookDataPanel.SetColumnSpan(Me.UpdatedTextBox, 2)
        Me.UpdatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdatedTextBox.Location = New System.Drawing.Point(187, 218)
        Me.UpdatedTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.UpdatedTextBox.Name = "UpdatedTextBox"
        Me.UpdatedTextBox.ReadOnly = True
        Me.UpdatedTextBox.Size = New System.Drawing.Size(94, 23)
        Me.UpdatedTextBox.TabIndex = 28
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressTextBox.Location = New System.Drawing.Point(46, 194)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(94, 23)
        Me.AddressTextBox.TabIndex = 27
        '
        'RefaddressTextBox
        '
        Me.BookDataPanel.SetColumnSpan(Me.RefaddressTextBox, 2)
        Me.RefaddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RefaddressTextBox.Location = New System.Drawing.Point(187, 194)
        Me.RefaddressTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.RefaddressTextBox.Name = "RefaddressTextBox"
        Me.RefaddressTextBox.Size = New System.Drawing.Size(94, 23)
        Me.RefaddressTextBox.TabIndex = 26
        '
        'VersionTextBox
        '
        Me.VersionTextBox.AllowDrop = True
        Me.VersionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionTextBox.Location = New System.Drawing.Point(46, 170)
        Me.VersionTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.Size = New System.Drawing.Size(94, 23)
        Me.VersionTextBox.TabIndex = 25
        '
        'LogoTextBox
        '
        Me.LogoTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.LogoTextBox, 2)
        Me.LogoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoTextBox.Location = New System.Drawing.Point(187, 170)
        Me.LogoTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.LogoTextBox.Name = "LogoTextBox"
        Me.LogoTextBox.Size = New System.Drawing.Size(94, 23)
        Me.LogoTextBox.TabIndex = 24
        '
        'SpecialTextBox
        '
        Me.SpecialTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.SpecialTextBox, 3)
        Me.SpecialTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecialTextBox.Location = New System.Drawing.Point(46, 146)
        Me.SpecialTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SpecialTextBox.Name = "SpecialTextBox"
        Me.SpecialTextBox.Size = New System.Drawing.Size(187, 23)
        Me.SpecialTextBox.TabIndex = 23
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.CategoryTextBox, 3)
        Me.CategoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryTextBox.Location = New System.Drawing.Point(46, 122)
        Me.CategoryTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(187, 23)
        Me.CategoryTextBox.TabIndex = 22
        '
        'LabelCreated
        '
        Me.LabelCreated.AutoSize = True
        Me.LabelCreated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCreated.Location = New System.Drawing.Point(3, 217)
        Me.LabelCreated.Name = "LabelCreated"
        Me.LabelCreated.Size = New System.Drawing.Size(39, 24)
        Me.LabelCreated.TabIndex = 21
        Me.LabelCreated.Text = "創建"
        Me.LabelCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelUpdated
        '
        Me.LabelUpdated.AutoSize = True
        Me.LabelUpdated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUpdated.Location = New System.Drawing.Point(144, 217)
        Me.LabelUpdated.Name = "LabelUpdated"
        Me.LabelUpdated.Size = New System.Drawing.Size(39, 24)
        Me.LabelUpdated.TabIndex = 20
        Me.LabelUpdated.Text = "更改"
        Me.LabelUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelRefaddress
        '
        Me.LabelRefaddress.AutoSize = True
        Me.LabelRefaddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRefaddress.Location = New System.Drawing.Point(144, 193)
        Me.LabelRefaddress.Name = "LabelRefaddress"
        Me.LabelRefaddress.Size = New System.Drawing.Size(39, 24)
        Me.LabelRefaddress.TabIndex = 19
        Me.LabelRefaddress.Text = "參考"
        Me.LabelRefaddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAddress.Location = New System.Drawing.Point(3, 193)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(39, 24)
        Me.LabelAddress.TabIndex = 18
        Me.LabelAddress.Text = "地址"
        Me.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelLogo.Location = New System.Drawing.Point(144, 169)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(39, 24)
        Me.LabelLogo.TabIndex = 17
        Me.LabelLogo.Text = "封面"
        Me.LabelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SeriesTextBox
        '
        Me.SeriesTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.SeriesTextBox, 3)
        Me.SeriesTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeriesTextBox.Location = New System.Drawing.Point(46, 50)
        Me.SeriesTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SeriesTextBox.Name = "SeriesTextBox"
        Me.SeriesTextBox.Size = New System.Drawing.Size(187, 23)
        Me.SeriesTextBox.TabIndex = 16
        '
        'LabelSeries
        '
        Me.LabelSeries.AutoSize = True
        Me.LabelSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSeries.Location = New System.Drawing.Point(3, 49)
        Me.LabelSeries.Name = "LabelSeries"
        Me.LabelSeries.Size = New System.Drawing.Size(39, 24)
        Me.LabelSeries.TabIndex = 15
        Me.LabelSeries.Text = "系列"
        Me.LabelSeries.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelOrigin
        '
        Me.LabelOrigin.AutoSize = True
        Me.LabelOrigin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelOrigin.Location = New System.Drawing.Point(189, 73)
        Me.LabelOrigin.Name = "LabelOrigin"
        Me.LabelOrigin.Size = New System.Drawing.Size(42, 24)
        Me.LabelOrigin.TabIndex = 13
        Me.LabelOrigin.Text = "原語"
        Me.LabelOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContributorTextBox
        '
        Me.ContributorTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.ContributorTextBox, 4)
        Me.ContributorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContributorTextBox.Location = New System.Drawing.Point(46, 98)
        Me.ContributorTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ContributorTextBox.Name = "ContributorTextBox"
        Me.ContributorTextBox.Size = New System.Drawing.Size(235, 23)
        Me.ContributorTextBox.TabIndex = 12
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(3, 169)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(39, 24)
        Me.LabelVersion.TabIndex = 11
        Me.LabelVersion.Text = "版本"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSpecial
        '
        Me.LabelSpecial.AutoSize = True
        Me.LabelSpecial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSpecial.Location = New System.Drawing.Point(3, 145)
        Me.LabelSpecial.Name = "LabelSpecial"
        Me.LabelSpecial.Size = New System.Drawing.Size(39, 24)
        Me.LabelSpecial.TabIndex = 10
        Me.LabelSpecial.Text = "專題"
        Me.LabelSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCategory.Location = New System.Drawing.Point(3, 121)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(39, 24)
        Me.LabelCategory.TabIndex = 9
        Me.LabelCategory.Text = "類別"
        Me.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.AuthorTextBox, 2)
        Me.AuthorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorTextBox.Location = New System.Drawing.Point(46, 74)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(139, 23)
        Me.AuthorTextBox.TabIndex = 8
        '
        'NameTextBox
        '
        Me.NameTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.NameTextBox, 4)
        Me.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTextBox.Location = New System.Drawing.Point(46, 26)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(235, 23)
        Me.NameTextBox.TabIndex = 7
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelID.Location = New System.Drawing.Point(144, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(39, 25)
        Me.LabelID.TabIndex = 4
        Me.LabelID.Text = "ID"
        Me.LabelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelContributor
        '
        Me.LabelContributor.AutoSize = True
        Me.LabelContributor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelContributor.Location = New System.Drawing.Point(3, 97)
        Me.LabelContributor.Name = "LabelContributor"
        Me.LabelContributor.Size = New System.Drawing.Size(39, 24)
        Me.LabelContributor.TabIndex = 3
        Me.LabelContributor.Text = "協作"
        Me.LabelContributor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAuthor
        '
        Me.LabelAuthor.AutoSize = True
        Me.LabelAuthor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAuthor.Location = New System.Drawing.Point(3, 73)
        Me.LabelAuthor.Name = "LabelAuthor"
        Me.LabelAuthor.Size = New System.Drawing.Size(39, 24)
        Me.LabelAuthor.TabIndex = 2
        Me.LabelAuthor.Text = "作者"
        Me.LabelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSubject.Location = New System.Drawing.Point(3, 25)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(39, 24)
        Me.LabelSubject.TabIndex = 1
        Me.LabelSubject.Text = "標題"
        Me.LabelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelType.Location = New System.Drawing.Point(3, 0)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(39, 25)
        Me.LabelType.TabIndex = 0
        Me.LabelType.Text = "類型"
        Me.LabelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TypeComboBox
        '
        Me.TypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Location = New System.Drawing.Point(45, 0)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(0)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(96, 25)
        Me.TypeComboBox.TabIndex = 5
        '
        'IDTextBox
        '
        Me.IDTextBox.AllowDrop = True
        Me.BookDataPanel.SetColumnSpan(Me.IDTextBox, 2)
        Me.IDTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDTextBox.Location = New System.Drawing.Point(187, 1)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(94, 23)
        Me.IDTextBox.TabIndex = 6
        '
        'OriginComboBox
        '
        Me.OriginComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginComboBox.FormattingEnabled = True
        Me.OriginComboBox.Location = New System.Drawing.Point(234, 73)
        Me.OriginComboBox.Margin = New System.Windows.Forms.Padding(0)
        Me.OriginComboBox.Name = "OriginComboBox"
        Me.OriginComboBox.Size = New System.Drawing.Size(48, 25)
        Me.OriginComboBox.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.Label18, 2)
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 253)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 22)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "#Entry checking"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CFolderChecker
        '
        Me.CFolderChecker.AutoSize = True
        Me.BookDataPanel.SetColumnSpan(Me.CFolderChecker, 3)
        Me.CFolderChecker.Enabled = False
        Me.CFolderChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFolderChecker.Location = New System.Drawing.Point(48, 278)
        Me.CFolderChecker.Name = "CFolderChecker"
        Me.CFolderChecker.Size = New System.Drawing.Size(62, 16)
        Me.CFolderChecker.TabIndex = 33
        Me.CFolderChecker.Text = "Folder"
        Me.CFolderChecker.UseVisualStyleBackColor = True
        '
        'SeriesIDUD
        '
        Me.SeriesIDUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeriesIDUD.Location = New System.Drawing.Point(235, 50)
        Me.SeriesIDUD.Margin = New System.Windows.Forms.Padding(1)
        Me.SeriesIDUD.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.SeriesIDUD.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.SeriesIDUD.Name = "SeriesIDUD"
        Me.SeriesIDUD.Size = New System.Drawing.Size(46, 23)
        Me.SeriesIDUD.TabIndex = 42
        Me.SeriesIDUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PageIntro
        '
        Me.PageIntro.Controls.Add(Me.TableLayoutPanel2)
        Me.PageIntro.Location = New System.Drawing.Point(4, 22)
        Me.PageIntro.Name = "PageIntro"
        Me.PageIntro.Size = New System.Drawing.Size(336, 246)
        Me.PageIntro.TabIndex = 1
        Me.PageIntro.Text = "簡介"
        Me.PageIntro.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DescriptionTextBox, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelDescription, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RemarksTextBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelRemarks, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(336, 246)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.AllowDrop = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.DescriptionTextBox, 2)
        Me.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionTextBox.Location = New System.Drawing.Point(1, 99)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DescriptionTextBox.Size = New System.Drawing.Size(334, 146)
        Me.DescriptionTextBox.TabIndex = 9
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDescription.Location = New System.Drawing.Point(3, 74)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(162, 24)
        Me.LabelDescription.TabIndex = 8
        Me.LabelDescription.Text = "簡介"
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.AllowDrop = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.RemarksTextBox, 2)
        Me.RemarksTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemarksTextBox.Location = New System.Drawing.Point(1, 25)
        Me.RemarksTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RemarksTextBox.Size = New System.Drawing.Size(334, 48)
        Me.RemarksTextBox.TabIndex = 7
        '
        'LabelRemarks
        '
        Me.LabelRemarks.AutoSize = True
        Me.LabelRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRemarks.Location = New System.Drawing.Point(3, 0)
        Me.LabelRemarks.Name = "LabelRemarks"
        Me.LabelRemarks.Size = New System.Drawing.Size(162, 24)
        Me.LabelRemarks.TabIndex = 1
        Me.LabelRemarks.Text = "備註"
        Me.LabelRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PageFiles
        '
        Me.PageFiles.AutoScroll = True
        Me.PageFiles.Controls.Add(Me.FilesView)
        Me.PageFiles.Controls.Add(Me.ListEditPanel)
        Me.PageFiles.Location = New System.Drawing.Point(4, 22)
        Me.PageFiles.Name = "PageFiles"
        Me.PageFiles.Size = New System.Drawing.Size(336, 246)
        Me.PageFiles.TabIndex = 3
        Me.PageFiles.Text = "文檔"
        Me.PageFiles.UseVisualStyleBackColor = True
        '
        'FilesView
        '
        Me.FilesView.AllowDrop = True
        Me.FilesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.LengthColumn, Me.SizeColumn, Me.InfoColumn, Me.CreatedColumn})
        Me.FilesView.ContextMenuStrip = Me.LibDataContextMenu
        Me.FilesView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilesView.FullRowSelect = True
        Me.FilesView.GridLines = True
        Me.FilesView.HideSelection = False
        Me.FilesView.LabelEdit = True
        Me.FilesView.Location = New System.Drawing.Point(0, 0)
        Me.FilesView.MultiSelect = False
        Me.FilesView.Name = "FilesView"
        Me.FilesView.Size = New System.Drawing.Size(336, 148)
        Me.FilesView.TabIndex = 2
        Me.FilesView.UseCompatibleStateImageBehavior = False
        Me.FilesView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "檔名"
        '
        'TypeColumn
        '
        Me.TypeColumn.Text = "格式"
        '
        'LengthColumn
        '
        Me.LengthColumn.Text = "長度"
        Me.LengthColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SizeColumn
        '
        Me.SizeColumn.Text = "容量"
        '
        'InfoColumn
        '
        Me.InfoColumn.Text = "描述"
        '
        'CreatedColumn
        '
        Me.CreatedColumn.Text = "創建"
        '
        'ListEditPanel
        '
        Me.ListEditPanel.ColumnCount = 4
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ListEditPanel.Controls.Add(Me.LViewButton, 3, 0)
        Me.ListEditPanel.Controls.Add(Me.LWritedLabel, 2, 2)
        Me.ListEditPanel.Controls.Add(Me.LAccessedLabel, 1, 3)
        Me.ListEditPanel.Controls.Add(Me.LCreatedLabel, 1, 2)
        Me.ListEditPanel.Controls.Add(Me.LFileNameLabel, 0, 0)
        Me.ListEditPanel.Controls.Add(Me.LabelComments, 0, 1)
        Me.ListEditPanel.Controls.Add(Me.LCommentsTextBox, 1, 1)
        Me.ListEditPanel.Controls.Add(Me.LUpdateButton, 2, 0)
        Me.ListEditPanel.Controls.Add(Me.LInTimeChecker, 2, 3)
        Me.ListEditPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListEditPanel.Location = New System.Drawing.Point(0, 148)
        Me.ListEditPanel.Name = "ListEditPanel"
        Me.ListEditPanel.RowCount = 5
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ListEditPanel.Size = New System.Drawing.Size(336, 98)
        Me.ListEditPanel.TabIndex = 1
        '
        'LViewButton
        '
        Me.LViewButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.LViewButton.Location = New System.Drawing.Point(272, 0)
        Me.LViewButton.Margin = New System.Windows.Forms.Padding(1, 0, 4, 0)
        Me.LViewButton.Name = "LViewButton"
        Me.LViewButton.Size = New System.Drawing.Size(60, 24)
        Me.LViewButton.TabIndex = 36
        Me.LViewButton.Text = "預覽"
        Me.LViewButton.UseVisualStyleBackColor = True
        '
        'LWritedLabel
        '
        Me.LWritedLabel.AutoSize = True
        Me.ListEditPanel.SetColumnSpan(Me.LWritedLabel, 2)
        Me.LWritedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LWritedLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LWritedLabel.Location = New System.Drawing.Point(193, 48)
        Me.LWritedLabel.Name = "LWritedLabel"
        Me.LWritedLabel.Size = New System.Drawing.Size(140, 22)
        Me.LWritedLabel.TabIndex = 35
        Me.LWritedLabel.Text = "WritedTime"
        Me.LWritedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LAccessedLabel
        '
        Me.LAccessedLabel.AutoSize = True
        Me.LAccessedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LAccessedLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAccessedLabel.Location = New System.Drawing.Point(48, 70)
        Me.LAccessedLabel.Name = "LAccessedLabel"
        Me.LAccessedLabel.Size = New System.Drawing.Size(139, 22)
        Me.LAccessedLabel.TabIndex = 34
        Me.LAccessedLabel.Text = "AccessedTime"
        Me.LAccessedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LCreatedLabel
        '
        Me.LCreatedLabel.AutoSize = True
        Me.LCreatedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LCreatedLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCreatedLabel.Location = New System.Drawing.Point(48, 48)
        Me.LCreatedLabel.Name = "LCreatedLabel"
        Me.LCreatedLabel.Size = New System.Drawing.Size(139, 22)
        Me.LCreatedLabel.TabIndex = 33
        Me.LCreatedLabel.Text = "CreatedTime"
        Me.LCreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LFileNameLabel
        '
        Me.LFileNameLabel.AutoSize = True
        Me.ListEditPanel.SetColumnSpan(Me.LFileNameLabel, 2)
        Me.LFileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LFileNameLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LFileNameLabel.Location = New System.Drawing.Point(3, 0)
        Me.LFileNameLabel.Name = "LFileNameLabel"
        Me.LFileNameLabel.Size = New System.Drawing.Size(184, 24)
        Me.LFileNameLabel.TabIndex = 0
        Me.LFileNameLabel.Text = "File name"
        Me.LFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelComments
        '
        Me.LabelComments.AutoSize = True
        Me.LabelComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelComments.Location = New System.Drawing.Point(3, 24)
        Me.LabelComments.Name = "LabelComments"
        Me.LabelComments.Size = New System.Drawing.Size(39, 24)
        Me.LabelComments.TabIndex = 1
        Me.LabelComments.Text = "描述"
        Me.LabelComments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LCommentsTextBox
        '
        Me.LCommentsTextBox.AllowDrop = True
        Me.ListEditPanel.SetColumnSpan(Me.LCommentsTextBox, 3)
        Me.LCommentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LCommentsTextBox.Location = New System.Drawing.Point(46, 25)
        Me.LCommentsTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.LCommentsTextBox.Name = "LCommentsTextBox"
        Me.LCommentsTextBox.Size = New System.Drawing.Size(289, 23)
        Me.LCommentsTextBox.TabIndex = 4
        '
        'LUpdateButton
        '
        Me.LUpdateButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.LUpdateButton.Location = New System.Drawing.Point(198, 0)
        Me.LUpdateButton.Margin = New System.Windows.Forms.Padding(1, 0, 4, 0)
        Me.LUpdateButton.Name = "LUpdateButton"
        Me.LUpdateButton.Size = New System.Drawing.Size(60, 24)
        Me.LUpdateButton.TabIndex = 5
        Me.LUpdateButton.Text = "保存"
        Me.LUpdateButton.UseVisualStyleBackColor = True
        '
        'LInTimeChecker
        '
        Me.LInTimeChecker.AutoSize = True
        Me.ListEditPanel.SetColumnSpan(Me.LInTimeChecker, 2)
        Me.LInTimeChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInTimeChecker.Location = New System.Drawing.Point(193, 73)
        Me.LInTimeChecker.Name = "LInTimeChecker"
        Me.LInTimeChecker.Size = New System.Drawing.Size(98, 16)
        Me.LInTimeChecker.TabIndex = 37
        Me.LInTimeChecker.Text = "Show in time"
        Me.LInTimeChecker.UseVisualStyleBackColor = True
        '
        'PageLinks
        '
        Me.PageLinks.Controls.Add(Me.LinksView)
        Me.PageLinks.Controls.Add(Me.LinkEditPanel)
        Me.PageLinks.Location = New System.Drawing.Point(4, 22)
        Me.PageLinks.Name = "PageLinks"
        Me.PageLinks.Size = New System.Drawing.Size(336, 246)
        Me.PageLinks.TabIndex = 4
        Me.PageLinks.Text = "鏈接"
        Me.PageLinks.UseVisualStyleBackColor = True
        '
        'LinksView
        '
        Me.LinksView.AllowDrop = True
        Me.LinksView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.UKeyColumn, Me.ULinkColumn})
        Me.LinksView.ContextMenuStrip = Me.LibDataContextMenu
        Me.LinksView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinksView.FullRowSelect = True
        Me.LinksView.LabelEdit = True
        Me.LinksView.Location = New System.Drawing.Point(0, 0)
        Me.LinksView.Name = "LinksView"
        Me.LinksView.Size = New System.Drawing.Size(336, 192)
        Me.LinksView.TabIndex = 1
        Me.LinksView.UseCompatibleStateImageBehavior = False
        Me.LinksView.View = System.Windows.Forms.View.Details
        '
        'UKeyColumn
        '
        Me.UKeyColumn.Text = "名稱"
        '
        'ULinkColumn
        '
        Me.ULinkColumn.Text = "鏈接"
        '
        'LinkEditPanel
        '
        Me.LinkEditPanel.ColumnCount = 6
        Me.LinkEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.LinkEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LinkEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.LinkEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.LinkEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.LinkEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.LinkEditPanel.Controls.Add(Me.UAddButton, 2, 0)
        Me.LinkEditPanel.Controls.Add(Me.UDownButton, 4, 0)
        Me.LinkEditPanel.Controls.Add(Me.UBroButton, 3, 0)
        Me.LinkEditPanel.Controls.Add(Me.UUpdateButton, 5, 0)
        Me.LinkEditPanel.Controls.Add(Me.ULinkTextBox, 1, 1)
        Me.LinkEditPanel.Controls.Add(Me.LabelULink, 0, 1)
        Me.LinkEditPanel.Controls.Add(Me.UKeyTextBox, 1, 0)
        Me.LinkEditPanel.Controls.Add(Me.LabelUKey, 0, 0)
        Me.LinkEditPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinkEditPanel.Location = New System.Drawing.Point(0, 192)
        Me.LinkEditPanel.Name = "LinkEditPanel"
        Me.LinkEditPanel.RowCount = 3
        Me.LinkEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.LinkEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.LinkEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LinkEditPanel.Size = New System.Drawing.Size(336, 54)
        Me.LinkEditPanel.TabIndex = 0
        '
        'UAddButton
        '
        Me.UAddButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UAddButton.Location = New System.Drawing.Point(176, 0)
        Me.UAddButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UAddButton.Name = "UAddButton"
        Me.UAddButton.Size = New System.Drawing.Size(40, 24)
        Me.UAddButton.TabIndex = 11
        Me.UAddButton.Text = "新增"
        Me.UAddButton.UseVisualStyleBackColor = True
        '
        'UDownButton
        '
        Me.UDownButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UDownButton.Location = New System.Drawing.Point(256, 0)
        Me.UDownButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UDownButton.Name = "UDownButton"
        Me.UDownButton.Size = New System.Drawing.Size(40, 24)
        Me.UDownButton.TabIndex = 10
        Me.UDownButton.Text = "下載"
        Me.UDownButton.UseVisualStyleBackColor = True
        '
        'UBroButton
        '
        Me.UBroButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UBroButton.Location = New System.Drawing.Point(216, 0)
        Me.UBroButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UBroButton.Name = "UBroButton"
        Me.UBroButton.Size = New System.Drawing.Size(40, 24)
        Me.UBroButton.TabIndex = 9
        Me.UBroButton.Text = "跳轉"
        Me.UBroButton.UseVisualStyleBackColor = True
        '
        'UUpdateButton
        '
        Me.UUpdateButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UUpdateButton.Location = New System.Drawing.Point(296, 0)
        Me.UUpdateButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UUpdateButton.Name = "UUpdateButton"
        Me.UUpdateButton.Size = New System.Drawing.Size(40, 24)
        Me.UUpdateButton.TabIndex = 8
        Me.UUpdateButton.Text = "保存"
        Me.UUpdateButton.UseVisualStyleBackColor = True
        '
        'ULinkTextBox
        '
        Me.ULinkTextBox.AllowDrop = True
        Me.LinkEditPanel.SetColumnSpan(Me.ULinkTextBox, 5)
        Me.ULinkTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ULinkTextBox.Location = New System.Drawing.Point(46, 25)
        Me.ULinkTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ULinkTextBox.Name = "ULinkTextBox"
        Me.ULinkTextBox.Size = New System.Drawing.Size(289, 23)
        Me.ULinkTextBox.TabIndex = 7
        '
        'LabelULink
        '
        Me.LabelULink.AutoSize = True
        Me.LabelULink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelULink.Location = New System.Drawing.Point(3, 24)
        Me.LabelULink.Name = "LabelULink"
        Me.LabelULink.Size = New System.Drawing.Size(39, 24)
        Me.LabelULink.TabIndex = 6
        Me.LabelULink.Text = "鏈接"
        Me.LabelULink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UKeyTextBox
        '
        Me.UKeyTextBox.AllowDrop = True
        Me.UKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UKeyTextBox.Location = New System.Drawing.Point(46, 1)
        Me.UKeyTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.UKeyTextBox.Name = "UKeyTextBox"
        Me.UKeyTextBox.Size = New System.Drawing.Size(129, 23)
        Me.UKeyTextBox.TabIndex = 5
        '
        'LabelUKey
        '
        Me.LabelUKey.AutoSize = True
        Me.LabelUKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUKey.Location = New System.Drawing.Point(3, 0)
        Me.LabelUKey.Name = "LabelUKey"
        Me.LabelUKey.Size = New System.Drawing.Size(39, 24)
        Me.LabelUKey.TabIndex = 2
        Me.LabelUKey.Text = "名稱"
        Me.LabelUKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PageDownload
        '
        Me.PageDownload.Controls.Add(Me.DownloadPanel)
        Me.PageDownload.Location = New System.Drawing.Point(4, 22)
        Me.PageDownload.Name = "PageDownload"
        Me.PageDownload.Padding = New System.Windows.Forms.Padding(3)
        Me.PageDownload.Size = New System.Drawing.Size(336, 246)
        Me.PageDownload.TabIndex = 6
        Me.PageDownload.Text = "下載"
        Me.PageDownload.UseVisualStyleBackColor = True
        '
        'DownloadPanel
        '
        Me.DownloadPanel.ColumnCount = 5
        Me.DownloadPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DownloadPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.DownloadPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.DownloadPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DownloadPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DownloadPanel.Controls.Add(Me.DFileNameTextBox, 1, 0)
        Me.DownloadPanel.Controls.Add(Me.LabelDFileName, 0, 0)
        Me.DownloadPanel.Controls.Add(Me.DEditUrlListButton, 0, 5)
        Me.DownloadPanel.Controls.Add(Me.LabelDUrlList, 1, 5)
        Me.DownloadPanel.Controls.Add(Me.DRunButton, 3, 4)
        Me.DownloadPanel.Controls.Add(Me.DChangePathButton, 3, 2)
        Me.DownloadPanel.Controls.Add(Me.DFolderTextBox, 1, 2)
        Me.DownloadPanel.Controls.Add(Me.DLinkTextBox, 1, 1)
        Me.DownloadPanel.Controls.Add(Me.LabelDFolder, 0, 2)
        Me.DownloadPanel.Controls.Add(Me.LabelDLink, 0, 1)
        Me.DownloadPanel.Controls.Add(Me.DUrlListBox, 0, 6)
        Me.DownloadPanel.Controls.Add(Me.DProgressBar, 1, 4)
        Me.DownloadPanel.Controls.Add(Me.DMsgLabel, 2, 6)
        Me.DownloadPanel.Controls.Add(Me.DFileExistsChecker, 2, 3)
        Me.DownloadPanel.Controls.Add(Me.DFolderExistsChecker, 1, 3)
        Me.DownloadPanel.Controls.Add(Me.DToCoverChecker, 2, 0)
        Me.DownloadPanel.Controls.Add(Me.DPersentageLabel, 0, 4)
        Me.DownloadPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadPanel.Location = New System.Drawing.Point(3, 3)
        Me.DownloadPanel.Name = "DownloadPanel"
        Me.DownloadPanel.RowCount = 7
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DownloadPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DownloadPanel.Size = New System.Drawing.Size(330, 240)
        Me.DownloadPanel.TabIndex = 0
        '
        'DFileNameTextBox
        '
        Me.DFileNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DFileNameTextBox.Location = New System.Drawing.Point(41, 1)
        Me.DFileNameTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DFileNameTextBox.Name = "DFileNameTextBox"
        Me.DFileNameTextBox.Size = New System.Drawing.Size(145, 23)
        Me.DFileNameTextBox.TabIndex = 23
        '
        'LabelDFileName
        '
        Me.LabelDFileName.AutoSize = True
        Me.LabelDFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDFileName.Location = New System.Drawing.Point(3, 0)
        Me.LabelDFileName.Name = "LabelDFileName"
        Me.LabelDFileName.Size = New System.Drawing.Size(34, 24)
        Me.LabelDFileName.TabIndex = 22
        Me.LabelDFileName.Text = "檔名"
        Me.LabelDFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDUrlList
        '
        Me.LabelDUrlList.AutoSize = True
        Me.LabelDUrlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDUrlList.Location = New System.Drawing.Point(43, 120)
        Me.LabelDUrlList.Name = "LabelDUrlList"
        Me.LabelDUrlList.Size = New System.Drawing.Size(141, 24)
        Me.LabelDUrlList.TabIndex = 18
        Me.LabelDUrlList.Text = "既定填寫鏈接"
        Me.LabelDUrlList.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DRunButton
        '
        Me.DRunButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DRunButton.Location = New System.Drawing.Point(250, 96)
        Me.DRunButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DRunButton.Name = "DRunButton"
        Me.DRunButton.Size = New System.Drawing.Size(40, 24)
        Me.DRunButton.TabIndex = 16
        Me.DRunButton.Text = "下載"
        Me.DRunButton.UseVisualStyleBackColor = True
        '
        'DChangePathButton
        '
        Me.DChangePathButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DChangePathButton.Location = New System.Drawing.Point(250, 48)
        Me.DChangePathButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DChangePathButton.Name = "DChangePathButton"
        Me.DChangePathButton.Size = New System.Drawing.Size(40, 24)
        Me.DChangePathButton.TabIndex = 11
        Me.DChangePathButton.Text = "更改"
        Me.DChangePathButton.UseVisualStyleBackColor = True
        '
        'DFolderTextBox
        '
        Me.DownloadPanel.SetColumnSpan(Me.DFolderTextBox, 2)
        Me.DFolderTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DFolderTextBox.Location = New System.Drawing.Point(41, 49)
        Me.DFolderTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DFolderTextBox.Name = "DFolderTextBox"
        Me.DFolderTextBox.ReadOnly = True
        Me.DFolderTextBox.Size = New System.Drawing.Size(208, 23)
        Me.DFolderTextBox.TabIndex = 6
        '
        'DLinkTextBox
        '
        Me.DLinkTextBox.AllowDrop = True
        Me.DownloadPanel.SetColumnSpan(Me.DLinkTextBox, 3)
        Me.DLinkTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DLinkTextBox.Location = New System.Drawing.Point(41, 25)
        Me.DLinkTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DLinkTextBox.Name = "DLinkTextBox"
        Me.DLinkTextBox.Size = New System.Drawing.Size(248, 23)
        Me.DLinkTextBox.TabIndex = 5
        '
        'LabelDFolder
        '
        Me.LabelDFolder.AutoSize = True
        Me.LabelDFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDFolder.Location = New System.Drawing.Point(3, 48)
        Me.LabelDFolder.Name = "LabelDFolder"
        Me.LabelDFolder.Size = New System.Drawing.Size(34, 24)
        Me.LabelDFolder.TabIndex = 3
        Me.LabelDFolder.Text = "檔夾"
        Me.LabelDFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDLink
        '
        Me.LabelDLink.AutoSize = True
        Me.LabelDLink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDLink.Location = New System.Drawing.Point(3, 24)
        Me.LabelDLink.Name = "LabelDLink"
        Me.LabelDLink.Size = New System.Drawing.Size(34, 24)
        Me.LabelDLink.TabIndex = 2
        Me.LabelDLink.Text = "鏈接"
        Me.LabelDLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DUrlListBox
        '
        Me.DUrlListBox.AllowDrop = True
        Me.DownloadPanel.SetColumnSpan(Me.DUrlListBox, 2)
        Me.DUrlListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DUrlListBox.FormattingEnabled = True
        Me.DUrlListBox.ItemHeight = 17
        Me.DUrlListBox.Location = New System.Drawing.Point(3, 147)
        Me.DUrlListBox.Name = "DUrlListBox"
        Me.DUrlListBox.Size = New System.Drawing.Size(181, 90)
        Me.DUrlListBox.TabIndex = 12
        '
        'DProgressBar
        '
        Me.DownloadPanel.SetColumnSpan(Me.DProgressBar, 2)
        Me.DProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DProgressBar.Location = New System.Drawing.Point(43, 99)
        Me.DProgressBar.Name = "DProgressBar"
        Me.DProgressBar.Size = New System.Drawing.Size(204, 18)
        Me.DProgressBar.TabIndex = 13
        '
        'DMsgLabel
        '
        Me.DMsgLabel.AutoSize = True
        Me.DownloadPanel.SetColumnSpan(Me.DMsgLabel, 3)
        Me.DMsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DMsgLabel.Location = New System.Drawing.Point(190, 144)
        Me.DMsgLabel.Name = "DMsgLabel"
        Me.DMsgLabel.Size = New System.Drawing.Size(137, 96)
        Me.DMsgLabel.TabIndex = 19
        Me.DMsgLabel.Text = "Message:"
        '
        'DFileExistsChecker
        '
        Me.DFileExistsChecker.AutoSize = True
        Me.DownloadPanel.SetColumnSpan(Me.DFileExistsChecker, 2)
        Me.DFileExistsChecker.Enabled = False
        Me.DFileExistsChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFileExistsChecker.Location = New System.Drawing.Point(190, 75)
        Me.DFileExistsChecker.Name = "DFileExistsChecker"
        Me.DFileExistsChecker.Size = New System.Drawing.Size(92, 17)
        Me.DFileExistsChecker.TabIndex = 7
        Me.DFileExistsChecker.Text = "File Exists"
        Me.DFileExistsChecker.UseVisualStyleBackColor = True
        '
        'DFolderExistsChecker
        '
        Me.DFolderExistsChecker.AutoSize = True
        Me.DFolderExistsChecker.Enabled = False
        Me.DFolderExistsChecker.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFolderExistsChecker.Location = New System.Drawing.Point(43, 75)
        Me.DFolderExistsChecker.Name = "DFolderExistsChecker"
        Me.DFolderExistsChecker.Size = New System.Drawing.Size(104, 17)
        Me.DFolderExistsChecker.TabIndex = 21
        Me.DFolderExistsChecker.Text = "Folder Exists"
        Me.DFolderExistsChecker.UseVisualStyleBackColor = True
        '
        'DToCoverChecker
        '
        Me.DToCoverChecker.AutoSize = True
        Me.DownloadPanel.SetColumnSpan(Me.DToCoverChecker, 3)
        Me.DToCoverChecker.Location = New System.Drawing.Point(190, 3)
        Me.DToCoverChecker.Name = "DToCoverChecker"
        Me.DToCoverChecker.Size = New System.Drawing.Size(75, 18)
        Me.DToCoverChecker.TabIndex = 24
        Me.DToCoverChecker.Text = "設為封面"
        Me.DToCoverChecker.UseVisualStyleBackColor = True
        '
        'DPersentageLabel
        '
        Me.DPersentageLabel.AutoSize = True
        Me.DPersentageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DPersentageLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPersentageLabel.Location = New System.Drawing.Point(3, 96)
        Me.DPersentageLabel.Name = "DPersentageLabel"
        Me.DPersentageLabel.Size = New System.Drawing.Size(34, 24)
        Me.DPersentageLabel.TabIndex = 25
        Me.DPersentageLabel.Text = "0%"
        Me.DPersentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InfTools
        '
        Me.InfTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.InfTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateInfButton, Me.CancelEditButton, Me.ShowInfButton, Me.TryGetButton, Me.DBButton, Me.BackupButton, Me.SettingsButton})
        Me.InfTools.Location = New System.Drawing.Point(0, 0)
        Me.InfTools.Name = "InfTools"
        Me.InfTools.Size = New System.Drawing.Size(346, 25)
        Me.InfTools.TabIndex = 1
        Me.InfTools.Text = "ToolStrip1"
        '
        'UpdateInfButton
        '
        Me.UpdateInfButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UpdateInfButton.Image = CType(resources.GetObject("UpdateInfButton.Image"), System.Drawing.Image)
        Me.UpdateInfButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateInfButton.Name = "UpdateInfButton"
        Me.UpdateInfButton.Size = New System.Drawing.Size(23, 22)
        Me.UpdateInfButton.Text = "Save"
        Me.UpdateInfButton.ToolTipText = "Save current inf file"
        '
        'CancelEditButton
        '
        Me.CancelEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelEditButton.Image = CType(resources.GetObject("CancelEditButton.Image"), System.Drawing.Image)
        Me.CancelEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelEditButton.Text = "Cancel"
        Me.CancelEditButton.ToolTipText = "Cancel current edit"
        '
        'ShowInfButton
        '
        Me.ShowInfButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowInfButton.Image = CType(resources.GetObject("ShowInfButton.Image"), System.Drawing.Image)
        Me.ShowInfButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowInfButton.Name = "ShowInfButton"
        Me.ShowInfButton.Size = New System.Drawing.Size(23, 22)
        Me.ShowInfButton.Text = "Show"
        Me.ShowInfButton.ToolTipText = "Show inf text"
        '
        'TryGetButton
        '
        Me.TryGetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TryGetButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HDBookInfoItem, Me.CategoryInfoItem, Me.ToolStripSeparator1, Me.OriginListItem, Me.VersionListItem})
        Me.TryGetButton.Image = CType(resources.GetObject("TryGetButton.Image"), System.Drawing.Image)
        Me.TryGetButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TryGetButton.Name = "TryGetButton"
        Me.TryGetButton.ShowDropDownArrow = False
        Me.TryGetButton.Size = New System.Drawing.Size(20, 22)
        Me.TryGetButton.Text = "TryGet"
        Me.TryGetButton.ToolTipText = "Try to get info from webpage"
        '
        'HDBookInfoItem
        '
        Me.HDBookInfoItem.Name = "HDBookInfoItem"
        Me.HDBookInfoItem.Size = New System.Drawing.Size(152, 22)
        Me.HDBookInfoItem.Text = "HDBookInfo"
        '
        'CategoryInfoItem
        '
        Me.CategoryInfoItem.Name = "CategoryInfoItem"
        Me.CategoryInfoItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoryInfoItem.Text = "CategoryInfo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'OriginListItem
        '
        Me.OriginListItem.Name = "OriginListItem"
        Me.OriginListItem.Size = New System.Drawing.Size(152, 22)
        Me.OriginListItem.Text = "OriginList"
        '
        'VersionListItem
        '
        Me.VersionListItem.Name = "VersionListItem"
        Me.VersionListItem.Size = New System.Drawing.Size(152, 22)
        Me.VersionListItem.Text = "VersionList"
        '
        'DBButton
        '
        Me.DBButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DBButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DBBookTableItem, Me.CompletListItem, Me.ToolStripSeparator2, Me.OpenDataPanelItem})
        Me.DBButton.Image = CType(resources.GetObject("DBButton.Image"), System.Drawing.Image)
        Me.DBButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DBButton.Name = "DBButton"
        Me.DBButton.ShowDropDownArrow = False
        Me.DBButton.Size = New System.Drawing.Size(20, 22)
        Me.DBButton.Text = "DBCreate"
        Me.DBButton.ToolTipText = "Create data table"
        '
        'DBBookTableItem
        '
        Me.DBBookTableItem.Name = "DBBookTableItem"
        Me.DBBookTableItem.Size = New System.Drawing.Size(166, 22)
        Me.DBBookTableItem.Text = "DBBookTable"
        '
        'CompletListItem
        '
        Me.CompletListItem.Name = "CompletListItem"
        Me.CompletListItem.Size = New System.Drawing.Size(166, 22)
        Me.CompletListItem.Text = "CompletList"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'OpenDataPanelItem
        '
        Me.OpenDataPanelItem.Name = "OpenDataPanelItem"
        Me.OpenDataPanelItem.Size = New System.Drawing.Size(166, 22)
        Me.OpenDataPanelItem.Text = "OpenDataPanel"
        '
        'BackupButton
        '
        Me.BackupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackupButton.Image = CType(resources.GetObject("BackupButton.Image"), System.Drawing.Image)
        Me.BackupButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.ShowDropDownArrow = False
        Me.BackupButton.Size = New System.Drawing.Size(20, 22)
        Me.BackupButton.Text = "Backup"
        Me.BackupButton.ToolTipText = "Backup to specified device"
        '
        'SettingsButton
        '
        Me.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SettingsButton.Image = CType(resources.GetObject("SettingsButton.Image"), System.Drawing.Image)
        Me.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(23, 22)
        Me.SettingsButton.Text = "ToolStripButton1"
        '
        'LibStatusStrip
        '
        Me.LibStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreeStatusLabel, Me.CurrentNodeLabel})
        Me.LibStatusStrip.Location = New System.Drawing.Point(0, 479)
        Me.LibStatusStrip.Name = "LibStatusStrip"
        Me.LibStatusStrip.Size = New System.Drawing.Size(524, 26)
        Me.LibStatusStrip.TabIndex = 1
        Me.LibStatusStrip.Text = "StatusStrip1"
        '
        'TreeStatusLabel
        '
        Me.TreeStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.TreeStatusLabel.Name = "TreeStatusLabel"
        Me.TreeStatusLabel.Size = New System.Drawing.Size(36, 21)
        Me.TreeStatusLabel.Text = "就緒"
        '
        'CurrentNodeLabel
        '
        Me.CurrentNodeLabel.Name = "CurrentNodeLabel"
        Me.CurrentNodeLabel.Size = New System.Drawing.Size(41, 21)
        Me.CurrentNodeLabel.Text = "Node"
        '
        'BrowserTabs
        '
        Me.BrowserTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.BrowserTabs.Controls.Add(Me.PageWeb)
        Me.BrowserTabs.Controls.Add(Me.PageView)
        Me.BrowserTabs.Controls.Add(Me.PageImage)
        Me.BrowserTabs.Controls.Add(Me.PageLogs)
        Me.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserTabs.Location = New System.Drawing.Point(0, 0)
        Me.BrowserTabs.Name = "BrowserTabs"
        Me.BrowserTabs.Padding = New System.Drawing.Point(0, 0)
        Me.BrowserTabs.SelectedIndex = 0
        Me.BrowserTabs.Size = New System.Drawing.Size(314, 505)
        Me.BrowserTabs.TabIndex = 0
        '
        'PageWeb
        '
        Me.PageWeb.BackColor = System.Drawing.SystemColors.Control
        Me.PageWeb.Controls.Add(Me.WebViewer)
        Me.PageWeb.Location = New System.Drawing.Point(4, 29)
        Me.PageWeb.Margin = New System.Windows.Forms.Padding(0)
        Me.PageWeb.Name = "PageWeb"
        Me.PageWeb.Size = New System.Drawing.Size(306, 472)
        Me.PageWeb.TabIndex = 0
        Me.PageWeb.Text = "聯網"
        '
        'WebViewer
        '
        Me.WebViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebViewer.Location = New System.Drawing.Point(0, 0)
        Me.WebViewer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WebViewer.Name = "WebViewer"
        Me.WebViewer.ShowSourceInternal = True
        Me.WebViewer.Size = New System.Drawing.Size(306, 472)
        Me.WebViewer.TabIndex = 0
        Me.WebViewer.WebRoot = Nothing
        '
        'PageView
        '
        Me.PageView.Controls.Add(Me.QuickViewer)
        Me.PageView.Location = New System.Drawing.Point(4, 25)
        Me.PageView.Name = "PageView"
        Me.PageView.Padding = New System.Windows.Forms.Padding(3)
        Me.PageView.Size = New System.Drawing.Size(306, 476)
        Me.PageView.TabIndex = 2
        Me.PageView.Text = "文字"
        Me.PageView.UseVisualStyleBackColor = True
        '
        'QuickViewer
        '
        Me.QuickViewer.Contents = ""
        Me.QuickViewer.DefaultEncoding = CType(resources.GetObject("QuickViewer.DefaultEncoding"), System.Text.Encoding)
        Me.QuickViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuickViewer.FilePath = "(New)"
        Me.QuickViewer.Location = New System.Drawing.Point(3, 3)
        Me.QuickViewer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuickViewer.Name = "QuickViewer"
        Me.QuickViewer.Size = New System.Drawing.Size(300, 470)
        Me.QuickViewer.TabIndex = 0
        '
        'PageImage
        '
        Me.PageImage.Controls.Add(Me.InfoGroup)
        Me.PageImage.Controls.Add(Me.ImgGroup)
        Me.PageImage.Location = New System.Drawing.Point(4, 25)
        Me.PageImage.Name = "PageImage"
        Me.PageImage.Padding = New System.Windows.Forms.Padding(3)
        Me.PageImage.Size = New System.Drawing.Size(306, 476)
        Me.PageImage.TabIndex = 4
        Me.PageImage.Text = "圖像"
        Me.PageImage.UseVisualStyleBackColor = True
        '
        'InfoGroup
        '
        Me.InfoGroup.Controls.Add(Me.FileInfoLabel)
        Me.InfoGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.InfoGroup.Location = New System.Drawing.Point(3, 245)
        Me.InfoGroup.Name = "InfoGroup"
        Me.InfoGroup.Size = New System.Drawing.Size(300, 176)
        Me.InfoGroup.TabIndex = 1
        Me.InfoGroup.TabStop = False
        Me.InfoGroup.Text = "Info"
        '
        'FileInfoLabel
        '
        Me.FileInfoLabel.AutoSize = True
        Me.FileInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileInfoLabel.Location = New System.Drawing.Point(3, 19)
        Me.FileInfoLabel.Name = "FileInfoLabel"
        Me.FileInfoLabel.Size = New System.Drawing.Size(53, 17)
        Me.FileInfoLabel.TabIndex = 38
        Me.FileInfoLabel.Text = "[Image]"
        '
        'ImgGroup
        '
        Me.ImgGroup.Controls.Add(Me.ImgPreviewBox)
        Me.ImgGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImgGroup.Location = New System.Drawing.Point(3, 3)
        Me.ImgGroup.Name = "ImgGroup"
        Me.ImgGroup.Size = New System.Drawing.Size(300, 242)
        Me.ImgGroup.TabIndex = 0
        Me.ImgGroup.TabStop = False
        Me.ImgGroup.Text = "Preview"
        '
        'ImgPreviewBox
        '
        Me.ImgPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImgPreviewBox.Location = New System.Drawing.Point(3, 19)
        Me.ImgPreviewBox.Name = "ImgPreviewBox"
        Me.ImgPreviewBox.Size = New System.Drawing.Size(294, 220)
        Me.ImgPreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPreviewBox.TabIndex = 37
        Me.ImgPreviewBox.TabStop = False
        '
        'PageLogs
        '
        Me.PageLogs.Location = New System.Drawing.Point(4, 25)
        Me.PageLogs.Name = "PageLogs"
        Me.PageLogs.Padding = New System.Windows.Forms.Padding(3)
        Me.PageLogs.Size = New System.Drawing.Size(306, 476)
        Me.PageLogs.TabIndex = 3
        Me.PageLogs.Text = "履歷"
        Me.PageLogs.UseVisualStyleBackColor = True
        '
        'HDLibView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 505)
        Me.Controls.Add(Me.LibSpliter)
        Me.Controls.Add(Me.LibMenu)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.LibMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HDLibView"
        Me.Text = "HDLibView"
        Me.LibMenu.ResumeLayout(False)
        Me.LibMenu.PerformLayout()
        Me.LibSpliter.Panel1.ResumeLayout(False)
        Me.LibSpliter.Panel1.PerformLayout()
        Me.LibSpliter.Panel2.ResumeLayout(False)
        CType(Me.LibSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibSpliter.ResumeLayout(False)
        Me.InnerSpliter.Panel1.ResumeLayout(False)
        Me.InnerSpliter.Panel1.PerformLayout()
        Me.InnerSpliter.Panel2.ResumeLayout(False)
        Me.InnerSpliter.Panel2.PerformLayout()
        CType(Me.InnerSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InnerSpliter.ResumeLayout(False)
        Me.LibSearchTools.ResumeLayout(False)
        Me.LibSearchTools.PerformLayout()
        Me.DetailSpliter.Panel1.ResumeLayout(False)
        Me.DetailSpliter.Panel2.ResumeLayout(False)
        CType(Me.DetailSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailSpliter.ResumeLayout(False)
        Me.HeaderSpliter.Panel1.ResumeLayout(False)
        Me.HeaderSpliter.Panel2.ResumeLayout(False)
        CType(Me.HeaderSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSpliter.ResumeLayout(False)
        CType(Me.HCoverImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewBookInfoPanel.ResumeLayout(False)
        Me.ViewBookInfoPanel.PerformLayout()
        CType(Me.HIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailTabs.ResumeLayout(False)
        Me.PageBook.ResumeLayout(False)
        Me.BookDataPanel.ResumeLayout(False)
        Me.BookDataPanel.PerformLayout()
        CType(Me.SeriesIDUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageIntro.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.PageFiles.ResumeLayout(False)
        Me.ListEditPanel.ResumeLayout(False)
        Me.ListEditPanel.PerformLayout()
        Me.PageLinks.ResumeLayout(False)
        Me.LinkEditPanel.ResumeLayout(False)
        Me.LinkEditPanel.PerformLayout()
        Me.PageDownload.ResumeLayout(False)
        Me.DownloadPanel.ResumeLayout(False)
        Me.DownloadPanel.PerformLayout()
        Me.InfTools.ResumeLayout(False)
        Me.InfTools.PerformLayout()
        Me.LibStatusStrip.ResumeLayout(False)
        Me.LibStatusStrip.PerformLayout()
        Me.BrowserTabs.ResumeLayout(False)
        Me.PageWeb.ResumeLayout(False)
        Me.PageView.ResumeLayout(False)
        Me.PageImage.ResumeLayout(False)
        Me.InfoGroup.ResumeLayout(False)
        Me.InfoGroup.PerformLayout()
        Me.ImgGroup.ResumeLayout(False)
        CType(Me.ImgPreviewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LibSpliter As SplitContainer
    Friend WithEvents InnerSpliter As SplitContainer
    Friend WithEvents DetailSpliter As SplitContainer
    Friend WithEvents LibMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibRootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibSearchTools As ToolStrip
    Friend WithEvents LibSearchTextBox As ToolStripTextBox
    Friend WithEvents LibSearchGoButton As ToolStripButton
    Friend WithEvents LibSearchAdvanceButton As ToolStripButton
    Friend WithEvents LibView As HDLibTree
    Friend WithEvents LibStatusStrip As StatusStrip
    Friend WithEvents InfTools As ToolStrip
    Friend WithEvents UpdateInfButton As ToolStripButton
    Friend WithEvents HeaderSpliter As SplitContainer
    Friend WithEvents HCoverImageBox As PictureBox
    Friend WithEvents ViewBookInfoPanel As TableLayoutPanel
    Friend WithEvents HPilotLabel As Label
    Friend WithEvents LabelHDescreption As Label
    Friend WithEvents HAuthorLabel As Label
    Friend WithEvents LabelHAuthor As Label
    Friend WithEvents HTitleLabel As Label
    Friend WithEvents LabelHSubject As Label
    Friend WithEvents LabelHID As Label
    Friend WithEvents HIDLabel As Label
    Friend WithEvents CancelEditButton As ToolStripButton
    Friend WithEvents ShowInfButton As ToolStripButton
    Friend WithEvents TryGetButton As ToolStripDropDownButton
    Friend WithEvents HDBookInfoItem As ToolStripMenuItem
    Friend WithEvents CategoryInfoItem As ToolStripMenuItem
    Friend WithEvents LibDataContextMenu As ContextMenuStrip
    Friend WithEvents BrowserTabs As TabControl
    Friend WithEvents PageWeb As TabPage
    Friend WithEvents WebViewer As KzOnePageWeb
    Friend WithEvents PageView As TabPage
    Friend WithEvents QuickViewer As KzSingleEditor
    Friend WithEvents CurrentNodeLabel As ToolStripStatusLabel
    Friend WithEvents LibTips As ToolTip
    Friend WithEvents DBButton As ToolStripDropDownButton
    Friend WithEvents PageLogs As TabPage
    Friend WithEvents DBBookTableItem As ToolStripMenuItem
    Friend WithEvents BackupButton As ToolStripDropDownButton
    Friend WithEvents SettingsButton As ToolStripButton
    Friend WithEvents DetailTabs As TabControl
    Friend WithEvents PageBook As TabPage
    Friend WithEvents BookDataPanel As TableLayoutPanel
    Friend WithEvents CContansChecker As CheckBox
    Friend WithEvents CLinksChecker As CheckBox
    Friend WithEvents CManifestChecker As CheckBox
    Friend WithEvents CEmptyChecker As CheckBox
    Friend WithEvents CLogoFileChecker As CheckBox
    Friend WithEvents CInfFileChecker As CheckBox
    Friend WithEvents CreatedTextBox As TextBox
    Friend WithEvents UpdatedTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents RefaddressTextBox As TextBox
    Friend WithEvents VersionTextBox As TextBox
    Friend WithEvents LogoTextBox As TextBox
    Friend WithEvents SpecialTextBox As TextBox
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents LabelCreated As Label
    Friend WithEvents LabelUpdated As Label
    Friend WithEvents LabelRefaddress As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelLogo As Label
    Friend WithEvents SeriesTextBox As TextBox
    Friend WithEvents LabelSeries As Label
    Friend WithEvents LabelOrigin As Label
    Friend WithEvents ContributorTextBox As TextBox
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelSpecial As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelContributor As Label
    Friend WithEvents LabelAuthor As Label
    Friend WithEvents LabelSubject As Label
    Friend WithEvents LabelType As Label
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents OriginComboBox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CFolderChecker As CheckBox
    Friend WithEvents SeriesIDUD As NumericUpDown
    Friend WithEvents PageIntro As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents LabelDescription As Label
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents LabelRemarks As Label
    Friend WithEvents PageFiles As TabPage
    Friend WithEvents ListEditPanel As TableLayoutPanel
    Friend WithEvents LViewButton As Button
    Friend WithEvents LWritedLabel As Label
    Friend WithEvents LAccessedLabel As Label
    Friend WithEvents LCreatedLabel As Label
    Friend WithEvents LFileNameLabel As Label
    Friend WithEvents LabelComments As Label
    Friend WithEvents LCommentsTextBox As TextBox
    Friend WithEvents LUpdateButton As Button
    Friend WithEvents ImgPreviewBox As PictureBox
    Friend WithEvents FilesView As ListView
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents TypeColumn As ColumnHeader
    Friend WithEvents LengthColumn As ColumnHeader
    Friend WithEvents SizeColumn As ColumnHeader
    Friend WithEvents InfoColumn As ColumnHeader
    Friend WithEvents CreatedColumn As ColumnHeader
    Friend WithEvents PageLinks As TabPage
    Friend WithEvents LinksView As ListView
    Friend WithEvents UKeyColumn As ColumnHeader
    Friend WithEvents ULinkColumn As ColumnHeader
    Friend WithEvents LinkEditPanel As TableLayoutPanel
    Friend WithEvents UAddButton As Button
    Friend WithEvents UDownButton As Button
    Friend WithEvents UBroButton As Button
    Friend WithEvents UUpdateButton As Button
    Friend WithEvents ULinkTextBox As TextBox
    Friend WithEvents LabelULink As Label
    Friend WithEvents UKeyTextBox As TextBox
    Friend WithEvents LabelUKey As Label
    Friend WithEvents PageDownload As TabPage
    Friend WithEvents DownloadPanel As TableLayoutPanel
    Friend WithEvents DFileNameTextBox As TextBox
    Friend WithEvents LabelDFileName As Label
    Friend WithEvents DEditUrlListButton As Button
    Friend WithEvents LabelDUrlList As Label
    Friend WithEvents DRunButton As Button
    Friend WithEvents DChangePathButton As Button
    Friend WithEvents DFolderTextBox As TextBox
    Friend WithEvents DLinkTextBox As TextBox
    Friend WithEvents LabelDFolder As Label
    Friend WithEvents LabelDLink As Label
    Friend WithEvents DUrlListBox As ListBox
    Friend WithEvents DProgressBar As ProgressBar
    Friend WithEvents DMsgLabel As Label
    Friend WithEvents DFileExistsChecker As CheckBox
    Friend WithEvents DFolderExistsChecker As CheckBox
    Friend WithEvents DToCoverChecker As CheckBox
    Friend WithEvents PageImage As TabPage
    Friend WithEvents InfoGroup As GroupBox
    Friend WithEvents FileInfoLabel As Label
    Friend WithEvents ImgGroup As GroupBox
    Friend WithEvents LInTimeChecker As CheckBox
    Friend WithEvents HIcon As PictureBox
    Friend WithEvents TreeStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OriginListItem As ToolStripMenuItem
    Friend WithEvents DPersentageLabel As Label
    Friend WithEvents VersionListItem As ToolStripMenuItem
    Friend WithEvents CompletListItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents OpenDataPanelItem As ToolStripMenuItem
End Class
