<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HDLibDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDLibDB))
        Me.DBSpliter = New System.Windows.Forms.SplitContainer()
        Me.CmdSpliter = New System.Windows.Forms.SplitContainer()
        Me.CmdTabs = New System.Windows.Forms.TabControl()
        Me.PageGetFiles = New System.Windows.Forms.TabPage()
        Me.SourcesPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OtherPathButton = New System.Windows.Forms.Button()
        Me.CatCmdMenu = New System.Windows.Forms.MenuStrip()
        Me.SourcesMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcGetHomeItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcCreateCatListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcGetMainItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcGetDetailItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcGetAllItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SrcShowHomeItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcShowMainItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SrcShowDetailItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatsGetListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatsRefreshItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatsShowItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatsSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CatsGetListFilesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatGetListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CombineBooksItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CatShowItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatShowAllItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatedMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpGetListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpCompareItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpShowItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StructureMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrCreateItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrCheckItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrFillInfoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrShowItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.StrPageEntries = New System.Windows.Forms.ToolStripComboBox()
        Me.StrCreateAllItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DbScanItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesListView = New System.Windows.Forms.ListView()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrefix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPages = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColLink = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCheckSource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCheckList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OtherPathLabel = New System.Windows.Forms.Label()
        Me.OtherPathCheck = New System.Windows.Forms.CheckBox()
        Me.PageCategories = New System.Windows.Forms.TabPage()
        Me.CmdTools = New System.Windows.Forms.ToolStrip()
        Me.RootLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RootTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.LogsGroup = New System.Windows.Forms.GroupBox()
        Me.LogsTextBox = New System.Windows.Forms.TextBox()
        Me.RunStatus = New System.Windows.Forms.StatusStrip()
        Me.RunningLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RCategoryLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RAuthorLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RBookLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NCategoriesLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataTabs = New System.Windows.Forms.TabControl()
        Me.PageText = New System.Windows.Forms.TabPage()
        Me.TextDataViewer = New KzSystem.KzSingleEditor()
        Me.PageCompare = New System.Windows.Forms.TabPage()
        Me.PageStructure = New System.Windows.Forms.TabPage()
        CType(Me.DBSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DBSpliter.Panel1.SuspendLayout()
        Me.DBSpliter.Panel2.SuspendLayout()
        Me.DBSpliter.SuspendLayout()
        CType(Me.CmdSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmdSpliter.Panel1.SuspendLayout()
        Me.CmdSpliter.Panel2.SuspendLayout()
        Me.CmdSpliter.SuspendLayout()
        Me.CmdTabs.SuspendLayout()
        Me.PageGetFiles.SuspendLayout()
        Me.SourcesPanel.SuspendLayout()
        Me.CatCmdMenu.SuspendLayout()
        Me.CmdTools.SuspendLayout()
        Me.LogsGroup.SuspendLayout()
        Me.RunStatus.SuspendLayout()
        Me.DataTabs.SuspendLayout()
        Me.PageText.SuspendLayout()
        Me.SuspendLayout()
        '
        'DBSpliter
        '
        Me.DBSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBSpliter.Location = New System.Drawing.Point(0, 0)
        Me.DBSpliter.Name = "DBSpliter"
        '
        'DBSpliter.Panel1
        '
        Me.DBSpliter.Panel1.Controls.Add(Me.CmdSpliter)
        Me.DBSpliter.Panel1.Controls.Add(Me.RunStatus)
        '
        'DBSpliter.Panel2
        '
        Me.DBSpliter.Panel2.Controls.Add(Me.DataTabs)
        Me.DBSpliter.Size = New System.Drawing.Size(721, 482)
        Me.DBSpliter.SplitterDistance = 316
        Me.DBSpliter.TabIndex = 0
        '
        'CmdSpliter
        '
        Me.CmdSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdSpliter.Location = New System.Drawing.Point(0, 0)
        Me.CmdSpliter.Name = "CmdSpliter"
        Me.CmdSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'CmdSpliter.Panel1
        '
        Me.CmdSpliter.Panel1.Controls.Add(Me.CmdTabs)
        Me.CmdSpliter.Panel1.Controls.Add(Me.CmdTools)
        '
        'CmdSpliter.Panel2
        '
        Me.CmdSpliter.Panel2.Controls.Add(Me.LogsGroup)
        Me.CmdSpliter.Size = New System.Drawing.Size(316, 460)
        Me.CmdSpliter.SplitterDistance = 282
        Me.CmdSpliter.TabIndex = 0
        '
        'CmdTabs
        '
        Me.CmdTabs.Controls.Add(Me.PageGetFiles)
        Me.CmdTabs.Controls.Add(Me.PageCategories)
        Me.CmdTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdTabs.Location = New System.Drawing.Point(0, 25)
        Me.CmdTabs.Name = "CmdTabs"
        Me.CmdTabs.SelectedIndex = 0
        Me.CmdTabs.Size = New System.Drawing.Size(316, 257)
        Me.CmdTabs.TabIndex = 2
        '
        'PageGetFiles
        '
        Me.PageGetFiles.Controls.Add(Me.SourcesPanel)
        Me.PageGetFiles.Location = New System.Drawing.Point(4, 26)
        Me.PageGetFiles.Name = "PageGetFiles"
        Me.PageGetFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.PageGetFiles.Size = New System.Drawing.Size(308, 227)
        Me.PageGetFiles.TabIndex = 0
        Me.PageGetFiles.Text = "Sources"
        Me.PageGetFiles.UseVisualStyleBackColor = True
        '
        'SourcesPanel
        '
        Me.SourcesPanel.ColumnCount = 3
        Me.SourcesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SourcesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SourcesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SourcesPanel.Controls.Add(Me.OtherPathButton, 2, 0)
        Me.SourcesPanel.Controls.Add(Me.CatCmdMenu, 1, 3)
        Me.SourcesPanel.Controls.Add(Me.CategoriesListView, 0, 0)
        Me.SourcesPanel.Controls.Add(Me.OtherPathLabel, 1, 1)
        Me.SourcesPanel.Controls.Add(Me.OtherPathCheck, 2, 2)
        Me.SourcesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourcesPanel.Location = New System.Drawing.Point(3, 3)
        Me.SourcesPanel.Name = "SourcesPanel"
        Me.SourcesPanel.RowCount = 4
        Me.SourcesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.SourcesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.SourcesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SourcesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.SourcesPanel.Size = New System.Drawing.Size(302, 221)
        Me.SourcesPanel.TabIndex = 0
        '
        'OtherPathButton
        '
        Me.OtherPathButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OtherPathButton.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OtherPathButton.Location = New System.Drawing.Point(253, 1)
        Me.OtherPathButton.Margin = New System.Windows.Forms.Padding(1)
        Me.OtherPathButton.Name = "OtherPathButton"
        Me.OtherPathButton.Size = New System.Drawing.Size(48, 23)
        Me.OtherPathButton.TabIndex = 2
        Me.OtherPathButton.Text = "RUN"
        Me.OtherPathButton.UseVisualStyleBackColor = True
        '
        'CatCmdMenu
        '
        Me.CatCmdMenu.AllowMerge = False
        Me.SourcesPanel.SetColumnSpan(Me.CatCmdMenu, 2)
        Me.CatCmdMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatCmdMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourcesMenu, Me.CategoriesMenu, Me.CategoryMenu, Me.UpdatedMenu, Me.StructureMenu, Me.DatabaseMenu})
        Me.CatCmdMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.CatCmdMenu.Location = New System.Drawing.Point(202, 89)
        Me.CatCmdMenu.Name = "CatCmdMenu"
        Me.CatCmdMenu.Size = New System.Drawing.Size(100, 132)
        Me.CatCmdMenu.TabIndex = 3
        Me.CatCmdMenu.Text = "MenuStrip1"
        '
        'SourcesMenu
        '
        Me.SourcesMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SrcGetHomeItem, Me.SrcCreateCatListItem, Me.SrcGetMainItem, Me.SrcGetDetailItem, Me.SrcGetAllItem, Me.SrcSeparator, Me.SrcShowHomeItem, Me.SrcShowMainItem, Me.SrcShowDetailItem})
        Me.SourcesMenu.Name = "SourcesMenu"
        Me.SourcesMenu.Size = New System.Drawing.Size(93, 21)
        Me.SourcesMenu.Text = "Sources"
        '
        'SrcGetHomeItem
        '
        Me.SrcGetHomeItem.Name = "SrcGetHomeItem"
        Me.SrcGetHomeItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcGetHomeItem.Text = "Get home source"
        '
        'SrcCreateCatListItem
        '
        Me.SrcCreateCatListItem.Name = "SrcCreateCatListItem"
        Me.SrcCreateCatListItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcCreateCatListItem.Text = "Create category list"
        '
        'SrcGetMainItem
        '
        Me.SrcGetMainItem.Name = "SrcGetMainItem"
        Me.SrcGetMainItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcGetMainItem.Text = "Get main sources"
        '
        'SrcGetDetailItem
        '
        Me.SrcGetDetailItem.Name = "SrcGetDetailItem"
        Me.SrcGetDetailItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcGetDetailItem.Text = "Get detail by category"
        '
        'SrcGetAllItem
        '
        Me.SrcGetAllItem.Name = "SrcGetAllItem"
        Me.SrcGetAllItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcGetAllItem.Text = "Get all detail sources"
        '
        'SrcSeparator
        '
        Me.SrcSeparator.Name = "SrcSeparator"
        Me.SrcSeparator.Size = New System.Drawing.Size(213, 6)
        '
        'SrcShowHomeItem
        '
        Me.SrcShowHomeItem.Name = "SrcShowHomeItem"
        Me.SrcShowHomeItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcShowHomeItem.Text = "Show home source"
        '
        'SrcShowMainItem
        '
        Me.SrcShowMainItem.Name = "SrcShowMainItem"
        Me.SrcShowMainItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcShowMainItem.Text = "Show main by category"
        '
        'SrcShowDetailItem
        '
        Me.SrcShowDetailItem.Name = "SrcShowDetailItem"
        Me.SrcShowDetailItem.Size = New System.Drawing.Size(216, 22)
        Me.SrcShowDetailItem.Text = "Show detail by category"
        '
        'CategoriesMenu
        '
        Me.CategoriesMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatsGetListItem, Me.CatsRefreshItem, Me.CatsShowItem, Me.CatsSeparator, Me.CatsGetListFilesItem})
        Me.CategoriesMenu.Name = "CategoriesMenu"
        Me.CategoriesMenu.Size = New System.Drawing.Size(93, 21)
        Me.CategoriesMenu.Text = "Categories"
        '
        'CatsGetListItem
        '
        Me.CatsGetListItem.Name = "CatsGetListItem"
        Me.CatsGetListItem.Size = New System.Drawing.Size(195, 22)
        Me.CatsGetListItem.Text = "Get category list"
        Me.CatsGetListItem.ToolTipText = "Get categories list file from source file."
        '
        'CatsRefreshItem
        '
        Me.CatsRefreshItem.Name = "CatsRefreshItem"
        Me.CatsRefreshItem.Size = New System.Drawing.Size(195, 22)
        Me.CatsRefreshItem.Text = "Refresh list"
        Me.CatsRefreshItem.ToolTipText = "Read categories list file and set to list view."
        '
        'CatsShowItem
        '
        Me.CatsShowItem.Name = "CatsShowItem"
        Me.CatsShowItem.Size = New System.Drawing.Size(195, 22)
        Me.CatsShowItem.Text = "Show text"
        Me.CatsShowItem.ToolTipText = "Show categories list file in text."
        '
        'CatsSeparator
        '
        Me.CatsSeparator.Name = "CatsSeparator"
        Me.CatsSeparator.Size = New System.Drawing.Size(192, 6)
        '
        'CatsGetListFilesItem
        '
        Me.CatsGetListFilesItem.Name = "CatsGetListFilesItem"
        Me.CatsGetListFilesItem.Size = New System.Drawing.Size(195, 22)
        Me.CatsGetListFilesItem.Text = "Get all book list files"
        '
        'CategoryMenu
        '
        Me.CategoryMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatGetListItem, Me.CombineBooksItem, Me.CatSeparator, Me.CatShowItem, Me.CatShowAllItem})
        Me.CategoryMenu.Name = "CategoryMenu"
        Me.CategoryMenu.Size = New System.Drawing.Size(93, 21)
        Me.CategoryMenu.Text = "Category"
        '
        'CatGetListItem
        '
        Me.CatGetListItem.Name = "CatGetListItem"
        Me.CatGetListItem.Size = New System.Drawing.Size(210, 22)
        Me.CatGetListItem.Text = "Get books by category"
        '
        'CombineBooksItem
        '
        Me.CombineBooksItem.Name = "CombineBooksItem"
        Me.CombineBooksItem.Size = New System.Drawing.Size(210, 22)
        Me.CombineBooksItem.Text = "Combine books"
        '
        'CatSeparator
        '
        Me.CatSeparator.Name = "CatSeparator"
        Me.CatSeparator.Size = New System.Drawing.Size(207, 6)
        '
        'CatShowItem
        '
        Me.CatShowItem.Name = "CatShowItem"
        Me.CatShowItem.Size = New System.Drawing.Size(210, 22)
        Me.CatShowItem.Text = "Show text by category"
        '
        'CatShowAllItem
        '
        Me.CatShowAllItem.Name = "CatShowAllItem"
        Me.CatShowAllItem.Size = New System.Drawing.Size(210, 22)
        Me.CatShowAllItem.Text = "Show all books text"
        '
        'UpdatedMenu
        '
        Me.UpdatedMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpGetListItem, Me.UpCompareItem, Me.UpShowItem})
        Me.UpdatedMenu.Name = "UpdatedMenu"
        Me.UpdatedMenu.Size = New System.Drawing.Size(93, 21)
        Me.UpdatedMenu.Text = "Updated"
        '
        'UpGetListItem
        '
        Me.UpGetListItem.Name = "UpGetListItem"
        Me.UpGetListItem.Size = New System.Drawing.Size(169, 22)
        Me.UpGetListItem.Text = "Get updated list"
        '
        'UpCompareItem
        '
        Me.UpCompareItem.Name = "UpCompareItem"
        Me.UpCompareItem.Size = New System.Drawing.Size(169, 22)
        Me.UpCompareItem.Text = "Compare"
        '
        'UpShowItem
        '
        Me.UpShowItem.Name = "UpShowItem"
        Me.UpShowItem.Size = New System.Drawing.Size(169, 22)
        Me.UpShowItem.Text = "Show text"
        '
        'StructureMenu
        '
        Me.StructureMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StrCreateItem, Me.StrCheckItem, Me.StrFillInfoItem, Me.StrShowItem, Me.StrSeparator, Me.StrPageEntries, Me.StrCreateAllItem})
        Me.StructureMenu.Name = "StructureMenu"
        Me.StructureMenu.Size = New System.Drawing.Size(93, 21)
        Me.StructureMenu.Text = "Structure"
        '
        'StrCreateItem
        '
        Me.StrCreateItem.Name = "StrCreateItem"
        Me.StrCreateItem.Size = New System.Drawing.Size(187, 22)
        Me.StrCreateItem.Text = "Create by category"
        '
        'StrCheckItem
        '
        Me.StrCheckItem.Name = "StrCheckItem"
        Me.StrCheckItem.Size = New System.Drawing.Size(187, 22)
        Me.StrCheckItem.Text = "Check updated"
        '
        'StrFillInfoItem
        '
        Me.StrFillInfoItem.Name = "StrFillInfoItem"
        Me.StrFillInfoItem.Size = New System.Drawing.Size(187, 22)
        Me.StrFillInfoItem.Text = "Fill info"
        '
        'StrShowItem
        '
        Me.StrShowItem.Name = "StrShowItem"
        Me.StrShowItem.Size = New System.Drawing.Size(187, 22)
        Me.StrShowItem.Text = "Show tree"
        '
        'StrSeparator
        '
        Me.StrSeparator.Name = "StrSeparator"
        Me.StrSeparator.Size = New System.Drawing.Size(184, 6)
        '
        'StrPageEntries
        '
        Me.StrPageEntries.AutoSize = False
        Me.StrPageEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StrPageEntries.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StrPageEntries.Items.AddRange(New Object() {"5", "10", "20", "50", "All"})
        Me.StrPageEntries.Margin = New System.Windows.Forms.Padding(0)
        Me.StrPageEntries.Name = "StrPageEntries"
        Me.StrPageEntries.Size = New System.Drawing.Size(64, 24)
        '
        'StrCreateAllItem
        '
        Me.StrCreateAllItem.Name = "StrCreateAllItem"
        Me.StrCreateAllItem.Size = New System.Drawing.Size(187, 22)
        Me.StrCreateAllItem.Text = "Create all"
        '
        'DatabaseMenu
        '
        Me.DatabaseMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DbScanItem})
        Me.DatabaseMenu.Name = "DatabaseMenu"
        Me.DatabaseMenu.Size = New System.Drawing.Size(93, 21)
        Me.DatabaseMenu.Text = "Database"
        '
        'DbScanItem
        '
        Me.DbScanItem.Name = "DbScanItem"
        Me.DbScanItem.Size = New System.Drawing.Size(103, 22)
        Me.DbScanItem.Text = "Scan"
        '
        'CategoriesListView
        '
        Me.CategoriesListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColMark, Me.ColPrefix, Me.ColPages, Me.ColLink, Me.ColCheckSource, Me.ColSource, Me.ColCheckList, Me.ColList})
        Me.CategoriesListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoriesListView.FullRowSelect = True
        Me.CategoriesListView.GridLines = True
        Me.CategoriesListView.HideSelection = False
        Me.CategoriesListView.Location = New System.Drawing.Point(2, 2)
        Me.CategoriesListView.Margin = New System.Windows.Forms.Padding(2)
        Me.CategoriesListView.Name = "CategoriesListView"
        Me.SourcesPanel.SetRowSpan(Me.CategoriesListView, 4)
        Me.CategoriesListView.Size = New System.Drawing.Size(198, 217)
        Me.CategoriesListView.TabIndex = 4
        Me.CategoriesListView.UseCompatibleStateImageBehavior = False
        Me.CategoriesListView.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Name"
        '
        'ColMark
        '
        Me.ColMark.Text = "Mark"
        '
        'ColPrefix
        '
        Me.ColPrefix.Text = "#"
        '
        'ColPages
        '
        Me.ColPages.Text = "Pages"
        '
        'ColLink
        '
        Me.ColLink.Text = "MainLink"
        '
        'ColCheckSource
        '
        Me.ColCheckSource.Text = "-"
        Me.ColCheckSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColSource
        '
        Me.ColSource.Text = "Source"
        '
        'ColCheckList
        '
        Me.ColCheckList.Text = "-"
        Me.ColCheckList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColList
        '
        Me.ColList.Text = "List"
        '
        'OtherPathLabel
        '
        Me.OtherPathLabel.AutoEllipsis = True
        Me.SourcesPanel.SetColumnSpan(Me.OtherPathLabel, 2)
        Me.OtherPathLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OtherPathLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OtherPathLabel.Location = New System.Drawing.Point(205, 25)
        Me.OtherPathLabel.Name = "OtherPathLabel"
        Me.OtherPathLabel.Size = New System.Drawing.Size(94, 22)
        Me.OtherPathLabel.TabIndex = 5
        Me.OtherPathLabel.Text = "C:\Temp"
        Me.OtherPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OtherPathCheck
        '
        Me.OtherPathCheck.AutoSize = True
        Me.OtherPathCheck.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OtherPathCheck.Location = New System.Drawing.Point(255, 50)
        Me.OtherPathCheck.Name = "OtherPathCheck"
        Me.OtherPathCheck.Size = New System.Drawing.Size(41, 20)
        Me.OtherPathCheck.TabIndex = 6
        Me.OtherPathCheck.Text = "CK"
        Me.OtherPathCheck.UseVisualStyleBackColor = True
        '
        'PageCategories
        '
        Me.PageCategories.Location = New System.Drawing.Point(4, 22)
        Me.PageCategories.Name = "PageCategories"
        Me.PageCategories.Padding = New System.Windows.Forms.Padding(3)
        Me.PageCategories.Size = New System.Drawing.Size(308, 231)
        Me.PageCategories.TabIndex = 1
        Me.PageCategories.Text = "Tables"
        Me.PageCategories.UseVisualStyleBackColor = True
        '
        'CmdTools
        '
        Me.CmdTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CmdTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RootLabel, Me.RootTextBox})
        Me.CmdTools.Location = New System.Drawing.Point(0, 0)
        Me.CmdTools.Name = "CmdTools"
        Me.CmdTools.Size = New System.Drawing.Size(316, 25)
        Me.CmdTools.TabIndex = 1
        Me.CmdTools.Text = "ToolStrip1"
        '
        'RootLabel
        '
        Me.RootLabel.Name = "RootLabel"
        Me.RootLabel.Size = New System.Drawing.Size(36, 22)
        Me.RootLabel.Text = "Root"
        '
        'RootTextBox
        '
        Me.RootTextBox.Name = "RootTextBox"
        Me.RootTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'LogsGroup
        '
        Me.LogsGroup.Controls.Add(Me.LogsTextBox)
        Me.LogsGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogsGroup.Location = New System.Drawing.Point(0, 0)
        Me.LogsGroup.Name = "LogsGroup"
        Me.LogsGroup.Size = New System.Drawing.Size(316, 174)
        Me.LogsGroup.TabIndex = 0
        Me.LogsGroup.TabStop = False
        Me.LogsGroup.Text = "Logs"
        '
        'LogsTextBox
        '
        Me.LogsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogsTextBox.Location = New System.Drawing.Point(3, 19)
        Me.LogsTextBox.Multiline = True
        Me.LogsTextBox.Name = "LogsTextBox"
        Me.LogsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LogsTextBox.Size = New System.Drawing.Size(310, 152)
        Me.LogsTextBox.TabIndex = 0
        Me.LogsTextBox.WordWrap = False
        '
        'RunStatus
        '
        Me.RunStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunningLabel, Me.RCategoryLabel, Me.RAuthorLabel, Me.RBookLabel, Me.NCategoriesLabel})
        Me.RunStatus.Location = New System.Drawing.Point(0, 460)
        Me.RunStatus.Name = "RunStatus"
        Me.RunStatus.Size = New System.Drawing.Size(316, 22)
        Me.RunStatus.TabIndex = 1
        Me.RunStatus.Text = "StatusStrip1"
        '
        'RunningLabel
        '
        Me.RunningLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RunningLabel.Image = CType(resources.GetObject("RunningLabel.Image"), System.Drawing.Image)
        Me.RunningLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RunningLabel.Name = "RunningLabel"
        Me.RunningLabel.Size = New System.Drawing.Size(18, 17)
        Me.RunningLabel.Text = "N"
        '
        'RCategoryLabel
        '
        Me.RCategoryLabel.Name = "RCategoryLabel"
        Me.RCategoryLabel.Size = New System.Drawing.Size(71, 17)
        Me.RCategoryLabel.Text = "Categories"
        '
        'RAuthorLabel
        '
        Me.RAuthorLabel.Name = "RAuthorLabel"
        Me.RAuthorLabel.Size = New System.Drawing.Size(53, 17)
        Me.RAuthorLabel.Text = "Authors"
        '
        'RBookLabel
        '
        Me.RBookLabel.Name = "RBookLabel"
        Me.RBookLabel.Size = New System.Drawing.Size(45, 17)
        Me.RBookLabel.Text = "Books"
        '
        'NCategoriesLabel
        '
        Me.NCategoriesLabel.Name = "NCategoriesLabel"
        Me.NCategoriesLabel.Size = New System.Drawing.Size(57, 17)
        Me.NCategoriesLabel.Text = "Selected"
        '
        'DataTabs
        '
        Me.DataTabs.Controls.Add(Me.PageText)
        Me.DataTabs.Controls.Add(Me.PageCompare)
        Me.DataTabs.Controls.Add(Me.PageStructure)
        Me.DataTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTabs.Location = New System.Drawing.Point(0, 0)
        Me.DataTabs.Name = "DataTabs"
        Me.DataTabs.SelectedIndex = 0
        Me.DataTabs.Size = New System.Drawing.Size(401, 482)
        Me.DataTabs.TabIndex = 0
        '
        'PageText
        '
        Me.PageText.Controls.Add(Me.TextDataViewer)
        Me.PageText.Location = New System.Drawing.Point(4, 26)
        Me.PageText.Name = "PageText"
        Me.PageText.Padding = New System.Windows.Forms.Padding(3)
        Me.PageText.Size = New System.Drawing.Size(393, 452)
        Me.PageText.TabIndex = 0
        Me.PageText.Text = "Source"
        Me.PageText.UseVisualStyleBackColor = True
        '
        'TextDataViewer
        '
        Me.TextDataViewer.Contents = ""
        Me.TextDataViewer.DefaultEncoding = CType(resources.GetObject("TextDataViewer.DefaultEncoding"), System.Text.Encoding)
        Me.TextDataViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextDataViewer.FilePath = "(New)"
        Me.TextDataViewer.Location = New System.Drawing.Point(3, 3)
        Me.TextDataViewer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextDataViewer.Name = "TextDataViewer"
        Me.TextDataViewer.Size = New System.Drawing.Size(387, 446)
        Me.TextDataViewer.TabIndex = 0
        '
        'PageCompare
        '
        Me.PageCompare.Location = New System.Drawing.Point(4, 22)
        Me.PageCompare.Name = "PageCompare"
        Me.PageCompare.Padding = New System.Windows.Forms.Padding(3)
        Me.PageCompare.Size = New System.Drawing.Size(393, 456)
        Me.PageCompare.TabIndex = 1
        Me.PageCompare.Text = "Compare"
        Me.PageCompare.UseVisualStyleBackColor = True
        '
        'PageStructure
        '
        Me.PageStructure.Location = New System.Drawing.Point(4, 26)
        Me.PageStructure.Name = "PageStructure"
        Me.PageStructure.Padding = New System.Windows.Forms.Padding(3)
        Me.PageStructure.Size = New System.Drawing.Size(393, 452)
        Me.PageStructure.TabIndex = 2
        Me.PageStructure.Text = "Structure"
        Me.PageStructure.UseVisualStyleBackColor = True
        '
        'HDLibDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 482)
        Me.Controls.Add(Me.DBSpliter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HDLibDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HDLibDB"
        Me.DBSpliter.Panel1.ResumeLayout(False)
        Me.DBSpliter.Panel1.PerformLayout()
        Me.DBSpliter.Panel2.ResumeLayout(False)
        CType(Me.DBSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DBSpliter.ResumeLayout(False)
        Me.CmdSpliter.Panel1.ResumeLayout(False)
        Me.CmdSpliter.Panel1.PerformLayout()
        Me.CmdSpliter.Panel2.ResumeLayout(False)
        CType(Me.CmdSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmdSpliter.ResumeLayout(False)
        Me.CmdTabs.ResumeLayout(False)
        Me.PageGetFiles.ResumeLayout(False)
        Me.SourcesPanel.ResumeLayout(False)
        Me.SourcesPanel.PerformLayout()
        Me.CatCmdMenu.ResumeLayout(False)
        Me.CatCmdMenu.PerformLayout()
        Me.CmdTools.ResumeLayout(False)
        Me.CmdTools.PerformLayout()
        Me.LogsGroup.ResumeLayout(False)
        Me.LogsGroup.PerformLayout()
        Me.RunStatus.ResumeLayout(False)
        Me.RunStatus.PerformLayout()
        Me.DataTabs.ResumeLayout(False)
        Me.PageText.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DBSpliter As SplitContainer
    Friend WithEvents TextDataViewer As KzSingleEditor
    Friend WithEvents CmdSpliter As SplitContainer
    Friend WithEvents CmdTools As ToolStrip
    Friend WithEvents CmdTabs As TabControl
    Friend WithEvents PageGetFiles As TabPage
    Friend WithEvents PageCategories As TabPage
    Friend WithEvents RootLabel As ToolStripLabel
    Friend WithEvents RootTextBox As ToolStripTextBox
    Friend WithEvents LogsGroup As GroupBox
    Friend WithEvents LogsTextBox As TextBox
    Friend WithEvents DataTabs As TabControl
    Friend WithEvents PageText As TabPage
    Friend WithEvents PageCompare As TabPage
    Friend WithEvents PageStructure As TabPage
    Friend WithEvents RunStatus As StatusStrip
    Friend WithEvents RCategoryLabel As ToolStripStatusLabel
    Friend WithEvents RAuthorLabel As ToolStripStatusLabel
    Friend WithEvents RBookLabel As ToolStripStatusLabel
    Friend WithEvents SourcesPanel As TableLayoutPanel
    Friend WithEvents OtherPathButton As Button
    Friend WithEvents CatCmdMenu As MenuStrip
    Friend WithEvents CategoriesMenu As ToolStripMenuItem
    Friend WithEvents CatsRefreshItem As ToolStripMenuItem
    Friend WithEvents CatsShowItem As ToolStripMenuItem
    Friend WithEvents CategoryMenu As ToolStripMenuItem
    Friend WithEvents CatGetListItem As ToolStripMenuItem
    Friend WithEvents CatShowItem As ToolStripMenuItem
    Friend WithEvents UpdatedMenu As ToolStripMenuItem
    Friend WithEvents UpGetListItem As ToolStripMenuItem
    Friend WithEvents UpCompareItem As ToolStripMenuItem
    Friend WithEvents UpShowItem As ToolStripMenuItem
    Friend WithEvents StructureMenu As ToolStripMenuItem
    Friend WithEvents StrCreateItem As ToolStripMenuItem
    Friend WithEvents StrCheckItem As ToolStripMenuItem
    Friend WithEvents StrFillInfoItem As ToolStripMenuItem
    Friend WithEvents StrShowItem As ToolStripMenuItem
    Friend WithEvents CategoriesListView As ListView
    Friend WithEvents ColName As ColumnHeader
    Friend WithEvents ColMark As ColumnHeader
    Friend WithEvents ColPrefix As ColumnHeader
    Friend WithEvents ColPages As ColumnHeader
    Friend WithEvents CatsGetListItem As ToolStripMenuItem
    Friend WithEvents DatabaseMenu As ToolStripMenuItem
    Friend WithEvents DbScanItem As ToolStripMenuItem
    Friend WithEvents ColLink As ColumnHeader
    Friend WithEvents SourcesMenu As ToolStripMenuItem
    Friend WithEvents SrcGetMainItem As ToolStripMenuItem
    Friend WithEvents SrcGetHomeItem As ToolStripMenuItem
    Friend WithEvents SrcCreateCatListItem As ToolStripMenuItem
    Friend WithEvents SrcGetDetailItem As ToolStripMenuItem
    Friend WithEvents SrcSeparator As ToolStripSeparator
    Friend WithEvents SrcGetAllItem As ToolStripMenuItem
    Friend WithEvents CatSeparator As ToolStripSeparator
    Friend WithEvents CombineBooksItem As ToolStripMenuItem
    Friend WithEvents ColSource As ColumnHeader
    Friend WithEvents ColList As ColumnHeader
    Friend WithEvents ColCheckSource As ColumnHeader
    Friend WithEvents ColCheckList As ColumnHeader
    Friend WithEvents RunningLabel As ToolStripStatusLabel
    Friend WithEvents SrcShowHomeItem As ToolStripMenuItem
    Friend WithEvents SrcShowMainItem As ToolStripMenuItem
    Friend WithEvents SrcShowDetailItem As ToolStripMenuItem
    Friend WithEvents CatShowAllItem As ToolStripMenuItem
    Friend WithEvents StrSeparator As ToolStripSeparator
    Friend WithEvents StrPageEntries As ToolStripComboBox
    Friend WithEvents NCategoriesLabel As ToolStripStatusLabel
    Friend WithEvents CatsSeparator As ToolStripSeparator
    Friend WithEvents CatsGetListFilesItem As ToolStripMenuItem
    Friend WithEvents OtherPathLabel As Label
    Friend WithEvents OtherPathCheck As CheckBox
    Friend WithEvents StrCreateAllItem As ToolStripMenuItem
End Class
