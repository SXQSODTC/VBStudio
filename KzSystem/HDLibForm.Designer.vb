<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDLibForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDLibForm))
        Me.RootMenu = New System.Windows.Forms.MenuStrip()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.LibSpliter = New System.Windows.Forms.SplitContainer()
        Me.LibMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LibLevelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibBookItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibAuthorItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibCategoryItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibSpecialItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibRenameItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibCopyItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibCutItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibPasteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibDeleteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndicatedBox = New System.Windows.Forms.TextBox()
        Me.BookSpliter = New System.Windows.Forms.SplitContainer()
        Me.DataPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.VersionLable = New System.Windows.Forms.Label()
        Me.InfoUpdatedLabel = New System.Windows.Forms.Label()
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.SpecialLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.SubtitleBox = New System.Windows.Forms.TextBox()
        Me.AuthorBox = New System.Windows.Forms.TextBox()
        Me.VersionBox = New System.Windows.Forms.TextBox()
        Me.UpdatedBox = New System.Windows.Forms.TextBox()
        Me.CategoryBox = New System.Windows.Forms.TextBox()
        Me.SpecialBox = New System.Windows.Forms.TextBox()
        Me.IntroBox = New System.Windows.Forms.TextBox()
        Me.AuthorInfoButton = New System.Windows.Forms.Button()
        Me.PublishInfoLabel = New System.Windows.Forms.Label()
        Me.PublishInfoBox = New System.Windows.Forms.TextBox()
        Me.CategoryButton = New System.Windows.Forms.Button()
        Me.SpecialButton = New System.Windows.Forms.Button()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.CoverLinkButton = New System.Windows.Forms.Button()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.SaveInfButton = New System.Windows.Forms.Button()
        Me.AbortInfButton = New System.Windows.Forms.Button()
        Me.SeriesLabel = New System.Windows.Forms.Label()
        Me.SeriesBox = New System.Windows.Forms.TextBox()
        Me.ViewLinkButton = New System.Windows.Forms.Button()
        Me.DownLinkButton = New System.Windows.Forms.Button()
        Me.FileSpliter = New System.Windows.Forms.SplitContainer()
        Me.ImgSpliter = New System.Windows.Forms.SplitContainer()
        Me.CoverBox = New System.Windows.Forms.PictureBox()
        Me.CoverButton = New System.Windows.Forms.Button()
        Me.ImgInfoLabel = New System.Windows.Forms.Label()
        Me.ListSpliter = New System.Windows.Forms.SplitContainer()
        Me.FilesView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IndexColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LengthColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfoColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FilesMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileImportItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileRenameItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilePasteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileDeleteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileSetCoverItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListEditPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SerialLabel = New System.Windows.Forms.Label()
        Me.CommentLabel = New System.Windows.Forms.Label()
        Me.SerialBox = New System.Windows.Forms.TextBox()
        Me.CommentBox = New System.Windows.Forms.TextBox()
        Me.SaveListButton = New System.Windows.Forms.Button()
        Me.LibStatus = New System.Windows.Forms.StatusStrip()
        Me.LibPathLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NodeInfoLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FilesLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LinksLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AnyProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.LibTools = New System.Windows.Forms.ToolStrip()
        Me.OpenWebButton = New System.Windows.Forms.ToolStripButton()
        Me.SwitchListButton = New System.Windows.Forms.ToolStripButton()
        Me.LibPathButton = New System.Windows.Forms.ToolStripButton()
        Me.ImportButton = New System.Windows.Forms.ToolStripButton()
        Me.CleanUpButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowCodeButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateDBButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DataAllItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataBooksItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAuthorsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCategoriesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSpecialsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TryGetFromWebItem = New System.Windows.Forms.ToolStripSplitButton()
        Me.TryCategoryItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TryViewLinkItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkPopLabel = New System.Windows.Forms.Label()
        Me.HDBrowser = New System.Windows.Forms.WebBrowser()
        Me.WebStatus = New System.Windows.Forms.StatusStrip()
        Me.NowLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UrlLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.WebTools = New System.Windows.Forms.ToolStrip()
        Me.HDHistoryItem = New System.Windows.Forms.ToolStripSplitButton()
        Me.BackButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HtmlTitleLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SourceButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseWebButton = New System.Windows.Forms.ToolStripButton()
        Me.CreatedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SizeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AccessedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WritedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LibView = New KzSystem.KzDirectoryTreeView()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.LibSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibSpliter.Panel1.SuspendLayout()
        Me.LibSpliter.Panel2.SuspendLayout()
        Me.LibSpliter.SuspendLayout()
        Me.LibMenu.SuspendLayout()
        CType(Me.BookSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookSpliter.Panel1.SuspendLayout()
        Me.BookSpliter.Panel2.SuspendLayout()
        Me.BookSpliter.SuspendLayout()
        Me.DataPanel.SuspendLayout()
        CType(Me.FileSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FileSpliter.Panel1.SuspendLayout()
        Me.FileSpliter.Panel2.SuspendLayout()
        Me.FileSpliter.SuspendLayout()
        CType(Me.ImgSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImgSpliter.Panel1.SuspendLayout()
        Me.ImgSpliter.Panel2.SuspendLayout()
        Me.ImgSpliter.SuspendLayout()
        CType(Me.CoverBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListSpliter.Panel1.SuspendLayout()
        Me.ListSpliter.Panel2.SuspendLayout()
        Me.ListSpliter.SuspendLayout()
        Me.FilesMenu.SuspendLayout()
        Me.ListEditPanel.SuspendLayout()
        Me.LibStatus.SuspendLayout()
        Me.LibTools.SuspendLayout()
        Me.WebStatus.SuspendLayout()
        Me.WebTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootMenu
        '
        Me.RootMenu.Location = New System.Drawing.Point(0, 0)
        Me.RootMenu.Name = "RootMenu"
        Me.RootMenu.Size = New System.Drawing.Size(746, 24)
        Me.RootMenu.TabIndex = 0
        Me.RootMenu.Text = "MenuStrip1"
        Me.RootMenu.Visible = False
        '
        'RootSpliter
        '
        Me.RootSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.LibSpliter)
        Me.RootSpliter.Panel1.Controls.Add(Me.LibStatus)
        Me.RootSpliter.Panel1.Controls.Add(Me.LibTools)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.LinkPopLabel)
        Me.RootSpliter.Panel2.Controls.Add(Me.HDBrowser)
        Me.RootSpliter.Panel2.Controls.Add(Me.WebStatus)
        Me.RootSpliter.Panel2.Controls.Add(Me.WebTools)
        Me.RootSpliter.Size = New System.Drawing.Size(932, 507)
        Me.RootSpliter.SplitterDistance = 650
        Me.RootSpliter.SplitterWidth = 2
        Me.RootSpliter.TabIndex = 1
        '
        'LibSpliter
        '
        Me.LibSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.LibSpliter.Location = New System.Drawing.Point(0, 25)
        Me.LibSpliter.Name = "LibSpliter"
        '
        'LibSpliter.Panel1
        '
        Me.LibSpliter.Panel1.Controls.Add(Me.LibView)
        Me.LibSpliter.Panel1.Controls.Add(Me.IndicatedBox)
        '
        'LibSpliter.Panel2
        '
        Me.LibSpliter.Panel2.Controls.Add(Me.BookSpliter)
        Me.LibSpliter.Size = New System.Drawing.Size(648, 454)
        Me.LibSpliter.SplitterDistance = 170
        Me.LibSpliter.SplitterWidth = 1
        Me.LibSpliter.TabIndex = 2
        '
        'LibMenu
        '
        Me.LibMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibLevelItem, Me.ToolStripSeparator4, Me.LibBookItem, Me.LibAuthorItem, Me.LibCategoryItem, Me.LibSpecialItem, Me.ToolStripSeparator5, Me.LibRenameItem, Me.ToolStripSeparator6, Me.LibCopyItem, Me.LibCutItem, Me.LibPasteItem, Me.ToolStripSeparator7, Me.LibDeleteItem})
        Me.LibMenu.Name = "LibMenu"
        Me.LibMenu.Size = New System.Drawing.Size(160, 248)
        '
        'LibLevelItem
        '
        Me.LibLevelItem.Checked = True
        Me.LibLevelItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LibLevelItem.Name = "LibLevelItem"
        Me.LibLevelItem.Size = New System.Drawing.Size(159, 22)
        Me.LibLevelItem.Text = "Child level"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(156, 6)
        '
        'LibBookItem
        '
        Me.LibBookItem.Name = "LibBookItem"
        Me.LibBookItem.Size = New System.Drawing.Size(159, 22)
        Me.LibBookItem.Text = "New Book"
        '
        'LibAuthorItem
        '
        Me.LibAuthorItem.Name = "LibAuthorItem"
        Me.LibAuthorItem.Size = New System.Drawing.Size(159, 22)
        Me.LibAuthorItem.Text = "New Author"
        '
        'LibCategoryItem
        '
        Me.LibCategoryItem.Name = "LibCategoryItem"
        Me.LibCategoryItem.Size = New System.Drawing.Size(159, 22)
        Me.LibCategoryItem.Text = "New Category"
        '
        'LibSpecialItem
        '
        Me.LibSpecialItem.Name = "LibSpecialItem"
        Me.LibSpecialItem.Size = New System.Drawing.Size(159, 22)
        Me.LibSpecialItem.Text = "New Special"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(156, 6)
        '
        'LibRenameItem
        '
        Me.LibRenameItem.Name = "LibRenameItem"
        Me.LibRenameItem.Size = New System.Drawing.Size(159, 22)
        Me.LibRenameItem.Text = "Rename"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(156, 6)
        '
        'LibCopyItem
        '
        Me.LibCopyItem.Name = "LibCopyItem"
        Me.LibCopyItem.Size = New System.Drawing.Size(159, 22)
        Me.LibCopyItem.Text = "Copy"
        '
        'LibCutItem
        '
        Me.LibCutItem.Name = "LibCutItem"
        Me.LibCutItem.Size = New System.Drawing.Size(159, 22)
        Me.LibCutItem.Text = "Cut"
        '
        'LibPasteItem
        '
        Me.LibPasteItem.Name = "LibPasteItem"
        Me.LibPasteItem.Size = New System.Drawing.Size(159, 22)
        Me.LibPasteItem.Text = "Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(156, 6)
        '
        'LibDeleteItem
        '
        Me.LibDeleteItem.Name = "LibDeleteItem"
        Me.LibDeleteItem.Size = New System.Drawing.Size(159, 22)
        Me.LibDeleteItem.Text = "Delete"
        '
        'IndicatedBox
        '
        Me.IndicatedBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.IndicatedBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.IndicatedBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.IndicatedBox.Location = New System.Drawing.Point(0, 0)
        Me.IndicatedBox.Name = "IndicatedBox"
        Me.IndicatedBox.Size = New System.Drawing.Size(170, 23)
        Me.IndicatedBox.TabIndex = 0
        Me.IndicatedBox.TabStop = False
        '
        'BookSpliter
        '
        Me.BookSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookSpliter.Location = New System.Drawing.Point(0, 0)
        Me.BookSpliter.Name = "BookSpliter"
        '
        'BookSpliter.Panel1
        '
        Me.BookSpliter.Panel1.Controls.Add(Me.DataPanel)
        '
        'BookSpliter.Panel2
        '
        Me.BookSpliter.Panel2.Controls.Add(Me.FileSpliter)
        Me.BookSpliter.Size = New System.Drawing.Size(477, 454)
        Me.BookSpliter.SplitterDistance = 219
        Me.BookSpliter.SplitterWidth = 2
        Me.BookSpliter.TabIndex = 1
        '
        'DataPanel
        '
        Me.DataPanel.ColumnCount = 5
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.DataPanel.Controls.Add(Me.VersionLable, 0, 7)
        Me.DataPanel.Controls.Add(Me.InfoUpdatedLabel, 0, 10)
        Me.DataPanel.Controls.Add(Me.SubtitleLabel, 0, 3)
        Me.DataPanel.Controls.Add(Me.SpecialLabel, 0, 9)
        Me.DataPanel.Controls.Add(Me.AuthorLabel, 0, 5)
        Me.DataPanel.Controls.Add(Me.TitleLabel, 0, 2)
        Me.DataPanel.Controls.Add(Me.CategoryLabel, 0, 8)
        Me.DataPanel.Controls.Add(Me.IDLabel, 0, 1)
        Me.DataPanel.Controls.Add(Me.IDBox, 1, 1)
        Me.DataPanel.Controls.Add(Me.TitleBox, 1, 2)
        Me.DataPanel.Controls.Add(Me.SubtitleBox, 1, 3)
        Me.DataPanel.Controls.Add(Me.AuthorBox, 1, 5)
        Me.DataPanel.Controls.Add(Me.VersionBox, 1, 7)
        Me.DataPanel.Controls.Add(Me.UpdatedBox, 1, 10)
        Me.DataPanel.Controls.Add(Me.CategoryBox, 1, 8)
        Me.DataPanel.Controls.Add(Me.SpecialBox, 1, 9)
        Me.DataPanel.Controls.Add(Me.IntroBox, 0, 12)
        Me.DataPanel.Controls.Add(Me.AuthorInfoButton, 4, 5)
        Me.DataPanel.Controls.Add(Me.PublishInfoLabel, 0, 6)
        Me.DataPanel.Controls.Add(Me.PublishInfoBox, 1, 6)
        Me.DataPanel.Controls.Add(Me.CategoryButton, 4, 8)
        Me.DataPanel.Controls.Add(Me.SpecialButton, 4, 9)
        Me.DataPanel.Controls.Add(Me.TypeBox, 1, 0)
        Me.DataPanel.Controls.Add(Me.LinkLabel, 0, 11)
        Me.DataPanel.Controls.Add(Me.CoverLinkButton, 3, 11)
        Me.DataPanel.Controls.Add(Me.TypeLabel, 0, 0)
        Me.DataPanel.Controls.Add(Me.SaveInfButton, 3, 0)
        Me.DataPanel.Controls.Add(Me.AbortInfButton, 3, 1)
        Me.DataPanel.Controls.Add(Me.SeriesLabel, 0, 4)
        Me.DataPanel.Controls.Add(Me.SeriesBox, 1, 4)
        Me.DataPanel.Controls.Add(Me.ViewLinkButton, 1, 11)
        Me.DataPanel.Controls.Add(Me.DownLinkButton, 2, 11)
        Me.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPanel.Location = New System.Drawing.Point(0, 0)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.RowCount = 13
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DataPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DataPanel.Size = New System.Drawing.Size(219, 454)
        Me.DataPanel.TabIndex = 0
        '
        'VersionLable
        '
        Me.VersionLable.AutoSize = True
        Me.VersionLable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionLable.Location = New System.Drawing.Point(3, 168)
        Me.VersionLable.Name = "VersionLable"
        Me.VersionLable.Size = New System.Drawing.Size(44, 24)
        Me.VersionLable.TabIndex = 10
        Me.VersionLable.Text = "版本"
        Me.VersionLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InfoUpdatedLabel
        '
        Me.InfoUpdatedLabel.AutoSize = True
        Me.InfoUpdatedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoUpdatedLabel.Location = New System.Drawing.Point(3, 240)
        Me.InfoUpdatedLabel.Name = "InfoUpdatedLabel"
        Me.InfoUpdatedLabel.Size = New System.Drawing.Size(44, 24)
        Me.InfoUpdatedLabel.TabIndex = 8
        Me.InfoUpdatedLabel.Text = "更新"
        Me.InfoUpdatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubtitleLabel
        '
        Me.SubtitleLabel.AutoSize = True
        Me.SubtitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubtitleLabel.Location = New System.Drawing.Point(3, 72)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(44, 24)
        Me.SubtitleLabel.TabIndex = 7
        Me.SubtitleLabel.Text = "副題"
        Me.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpecialLabel
        '
        Me.SpecialLabel.AutoSize = True
        Me.SpecialLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecialLabel.Location = New System.Drawing.Point(3, 216)
        Me.SpecialLabel.Name = "SpecialLabel"
        Me.SpecialLabel.Size = New System.Drawing.Size(44, 24)
        Me.SpecialLabel.TabIndex = 6
        Me.SpecialLabel.Text = "專題"
        Me.SpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorLabel.Location = New System.Drawing.Point(3, 120)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(44, 24)
        Me.AuthorLabel.TabIndex = 5
        Me.AuthorLabel.Text = "作者"
        Me.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Location = New System.Drawing.Point(3, 48)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(44, 24)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "主題"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryLabel.Location = New System.Drawing.Point(3, 192)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(44, 24)
        Me.CategoryLabel.TabIndex = 3
        Me.CategoryLabel.Text = "類別"
        Me.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDLabel.Location = New System.Drawing.Point(3, 24)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(44, 24)
        Me.IDLabel.TabIndex = 0
        Me.IDLabel.Text = "編號"
        Me.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IDBox
        '
        Me.IDBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.IDBox, 2)
        Me.IDBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDBox.Location = New System.Drawing.Point(51, 25)
        Me.IDBox.Margin = New System.Windows.Forms.Padding(1)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(106, 23)
        Me.IDBox.TabIndex = 1
        Me.IDBox.Text = "ID"
        '
        'TitleBox
        '
        Me.TitleBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.TitleBox, 3)
        Me.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleBox.Location = New System.Drawing.Point(51, 49)
        Me.TitleBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(133, 23)
        Me.TitleBox.TabIndex = 2
        Me.TitleBox.Text = "Title"
        '
        'SubtitleBox
        '
        Me.SubtitleBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.SubtitleBox, 3)
        Me.SubtitleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubtitleBox.Location = New System.Drawing.Point(51, 73)
        Me.SubtitleBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SubtitleBox.Name = "SubtitleBox"
        Me.SubtitleBox.Size = New System.Drawing.Size(133, 23)
        Me.SubtitleBox.TabIndex = 3
        Me.SubtitleBox.Text = "Subtitle"
        '
        'AuthorBox
        '
        Me.AuthorBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.AuthorBox, 3)
        Me.AuthorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorBox.Location = New System.Drawing.Point(51, 121)
        Me.AuthorBox.Margin = New System.Windows.Forms.Padding(1)
        Me.AuthorBox.Name = "AuthorBox"
        Me.AuthorBox.Size = New System.Drawing.Size(133, 23)
        Me.AuthorBox.TabIndex = 4
        Me.AuthorBox.Text = "Author"
        '
        'VersionBox
        '
        Me.VersionBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.VersionBox, 3)
        Me.VersionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionBox.Location = New System.Drawing.Point(51, 169)
        Me.VersionBox.Margin = New System.Windows.Forms.Padding(1)
        Me.VersionBox.Name = "VersionBox"
        Me.VersionBox.Size = New System.Drawing.Size(133, 23)
        Me.VersionBox.TabIndex = 6
        Me.VersionBox.Text = "Version"
        '
        'UpdatedBox
        '
        Me.DataPanel.SetColumnSpan(Me.UpdatedBox, 3)
        Me.UpdatedBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdatedBox.Location = New System.Drawing.Point(51, 241)
        Me.UpdatedBox.Margin = New System.Windows.Forms.Padding(1)
        Me.UpdatedBox.Name = "UpdatedBox"
        Me.UpdatedBox.ReadOnly = True
        Me.UpdatedBox.Size = New System.Drawing.Size(133, 23)
        Me.UpdatedBox.TabIndex = 9
        Me.UpdatedBox.Text = "Updated"
        '
        'CategoryBox
        '
        Me.CategoryBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.CategoryBox, 3)
        Me.CategoryBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryBox.Location = New System.Drawing.Point(51, 193)
        Me.CategoryBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(133, 23)
        Me.CategoryBox.TabIndex = 7
        Me.CategoryBox.Text = "Category"
        '
        'SpecialBox
        '
        Me.SpecialBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.SpecialBox, 3)
        Me.SpecialBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecialBox.Location = New System.Drawing.Point(51, 217)
        Me.SpecialBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SpecialBox.Name = "SpecialBox"
        Me.SpecialBox.Size = New System.Drawing.Size(133, 23)
        Me.SpecialBox.TabIndex = 8
        Me.SpecialBox.Text = "Special"
        '
        'IntroBox
        '
        Me.IntroBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.IntroBox, 5)
        Me.IntroBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntroBox.Location = New System.Drawing.Point(1, 289)
        Me.IntroBox.Margin = New System.Windows.Forms.Padding(1)
        Me.IntroBox.Multiline = True
        Me.IntroBox.Name = "IntroBox"
        Me.IntroBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.IntroBox.Size = New System.Drawing.Size(217, 164)
        Me.IntroBox.TabIndex = 10
        Me.IntroBox.Text = "Intro"
        '
        'AuthorInfoButton
        '
        Me.AuthorInfoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorInfoButton.Location = New System.Drawing.Point(185, 120)
        Me.AuthorInfoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorInfoButton.Name = "AuthorInfoButton"
        Me.AuthorInfoButton.Size = New System.Drawing.Size(34, 24)
        Me.AuthorInfoButton.TabIndex = 21
        Me.AuthorInfoButton.Text = ">"
        Me.AuthorInfoButton.UseVisualStyleBackColor = True
        '
        'PublishInfoLabel
        '
        Me.PublishInfoLabel.AutoSize = True
        Me.PublishInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublishInfoLabel.Location = New System.Drawing.Point(3, 144)
        Me.PublishInfoLabel.Name = "PublishInfoLabel"
        Me.PublishInfoLabel.Size = New System.Drawing.Size(44, 24)
        Me.PublishInfoLabel.TabIndex = 22
        Me.PublishInfoLabel.Text = "出版"
        Me.PublishInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PublishInfoBox
        '
        Me.PublishInfoBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.PublishInfoBox, 3)
        Me.PublishInfoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublishInfoBox.Location = New System.Drawing.Point(51, 145)
        Me.PublishInfoBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PublishInfoBox.Name = "PublishInfoBox"
        Me.PublishInfoBox.Size = New System.Drawing.Size(133, 23)
        Me.PublishInfoBox.TabIndex = 5
        Me.PublishInfoBox.Text = "PublishInfo"
        '
        'CategoryButton
        '
        Me.CategoryButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryButton.Location = New System.Drawing.Point(185, 192)
        Me.CategoryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(34, 24)
        Me.CategoryButton.TabIndex = 24
        Me.CategoryButton.Text = ">"
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'SpecialButton
        '
        Me.SpecialButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecialButton.Location = New System.Drawing.Point(185, 216)
        Me.SpecialButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SpecialButton.Name = "SpecialButton"
        Me.SpecialButton.Size = New System.Drawing.Size(34, 24)
        Me.SpecialButton.TabIndex = 25
        Me.SpecialButton.Text = ">"
        Me.SpecialButton.UseVisualStyleBackColor = True
        '
        'TypeBox
        '
        Me.DataPanel.SetColumnSpan(Me.TypeBox, 2)
        Me.TypeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Location = New System.Drawing.Point(50, 0)
        Me.TypeBox.Margin = New System.Windows.Forms.Padding(0)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(108, 25)
        Me.TypeBox.TabIndex = 26
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel.Location = New System.Drawing.Point(3, 264)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(44, 24)
        Me.LinkLabel.TabIndex = 27
        Me.LinkLabel.Text = "鏈接"
        Me.LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CoverLinkButton
        '
        Me.DataPanel.SetColumnSpan(Me.CoverLinkButton, 2)
        Me.CoverLinkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoverLinkButton.Location = New System.Drawing.Point(158, 264)
        Me.CoverLinkButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CoverLinkButton.Name = "CoverLinkButton"
        Me.CoverLinkButton.Size = New System.Drawing.Size(61, 24)
        Me.CoverLinkButton.TabIndex = 29
        Me.CoverLinkButton.Text = "封面"
        Me.CoverLinkButton.UseVisualStyleBackColor = True
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeLabel.Location = New System.Drawing.Point(3, 0)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(44, 24)
        Me.TypeLabel.TabIndex = 30
        Me.TypeLabel.Text = "類型"
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SaveInfButton
        '
        Me.DataPanel.SetColumnSpan(Me.SaveInfButton, 2)
        Me.SaveInfButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveInfButton.Location = New System.Drawing.Point(161, 1)
        Me.SaveInfButton.Margin = New System.Windows.Forms.Padding(1, 1, 2, 0)
        Me.SaveInfButton.Name = "SaveInfButton"
        Me.SaveInfButton.Size = New System.Drawing.Size(56, 23)
        Me.SaveInfButton.TabIndex = 31
        Me.SaveInfButton.Text = "保存"
        Me.SaveInfButton.UseVisualStyleBackColor = True
        '
        'AbortInfButton
        '
        Me.DataPanel.SetColumnSpan(Me.AbortInfButton, 2)
        Me.AbortInfButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AbortInfButton.Location = New System.Drawing.Point(161, 25)
        Me.AbortInfButton.Margin = New System.Windows.Forms.Padding(1, 1, 2, 0)
        Me.AbortInfButton.Name = "AbortInfButton"
        Me.AbortInfButton.Size = New System.Drawing.Size(56, 23)
        Me.AbortInfButton.TabIndex = 32
        Me.AbortInfButton.Text = "放棄"
        Me.AbortInfButton.UseVisualStyleBackColor = True
        '
        'SeriesLabel
        '
        Me.SeriesLabel.AutoSize = True
        Me.SeriesLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeriesLabel.Location = New System.Drawing.Point(3, 96)
        Me.SeriesLabel.Name = "SeriesLabel"
        Me.SeriesLabel.Size = New System.Drawing.Size(44, 24)
        Me.SeriesLabel.TabIndex = 33
        Me.SeriesLabel.Text = "系列"
        Me.SeriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SeriesBox
        '
        Me.SeriesBox.AllowDrop = True
        Me.DataPanel.SetColumnSpan(Me.SeriesBox, 3)
        Me.SeriesBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeriesBox.Location = New System.Drawing.Point(51, 97)
        Me.SeriesBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SeriesBox.Name = "SeriesBox"
        Me.SeriesBox.Size = New System.Drawing.Size(133, 23)
        Me.SeriesBox.TabIndex = 34
        Me.SeriesBox.Text = "Series"
        '
        'ViewLinkButton
        '
        Me.ViewLinkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewLinkButton.Location = New System.Drawing.Point(50, 264)
        Me.ViewLinkButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ViewLinkButton.Name = "ViewLinkButton"
        Me.ViewLinkButton.Size = New System.Drawing.Size(54, 24)
        Me.ViewLinkButton.TabIndex = 35
        Me.ViewLinkButton.Text = "瀏覽"
        Me.ViewLinkButton.UseVisualStyleBackColor = True
        '
        'DownLinkButton
        '
        Me.DownLinkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownLinkButton.Location = New System.Drawing.Point(104, 264)
        Me.DownLinkButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DownLinkButton.Name = "DownLinkButton"
        Me.DownLinkButton.Size = New System.Drawing.Size(54, 24)
        Me.DownLinkButton.TabIndex = 36
        Me.DownLinkButton.Text = "書檔"
        Me.DownLinkButton.UseVisualStyleBackColor = True
        '
        'FileSpliter
        '
        Me.FileSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.FileSpliter.Location = New System.Drawing.Point(0, 0)
        Me.FileSpliter.Name = "FileSpliter"
        Me.FileSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'FileSpliter.Panel1
        '
        Me.FileSpliter.Panel1.Controls.Add(Me.ImgSpliter)
        '
        'FileSpliter.Panel2
        '
        Me.FileSpliter.Panel2.Controls.Add(Me.ListSpliter)
        Me.FileSpliter.Size = New System.Drawing.Size(256, 454)
        Me.FileSpliter.SplitterDistance = 215
        Me.FileSpliter.SplitterWidth = 2
        Me.FileSpliter.TabIndex = 0
        '
        'ImgSpliter
        '
        Me.ImgSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImgSpliter.Location = New System.Drawing.Point(0, 0)
        Me.ImgSpliter.Name = "ImgSpliter"
        '
        'ImgSpliter.Panel1
        '
        Me.ImgSpliter.Panel1.Controls.Add(Me.CoverBox)
        '
        'ImgSpliter.Panel2
        '
        Me.ImgSpliter.Panel2.Controls.Add(Me.CoverButton)
        Me.ImgSpliter.Panel2.Controls.Add(Me.ImgInfoLabel)
        Me.ImgSpliter.Size = New System.Drawing.Size(256, 215)
        Me.ImgSpliter.SplitterDistance = 147
        Me.ImgSpliter.SplitterWidth = 2
        Me.ImgSpliter.TabIndex = 0
        '
        'CoverBox
        '
        Me.CoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CoverBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoverBox.Location = New System.Drawing.Point(0, 0)
        Me.CoverBox.Name = "CoverBox"
        Me.CoverBox.Size = New System.Drawing.Size(147, 215)
        Me.CoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CoverBox.TabIndex = 11
        Me.CoverBox.TabStop = False
        '
        'CoverButton
        '
        Me.CoverButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CoverButton.Location = New System.Drawing.Point(2, 191)
        Me.CoverButton.Name = "CoverButton"
        Me.CoverButton.Size = New System.Drawing.Size(42, 23)
        Me.CoverButton.TabIndex = 1
        Me.CoverButton.Text = "封面"
        Me.CoverButton.UseVisualStyleBackColor = True
        '
        'ImgInfoLabel
        '
        Me.ImgInfoLabel.AutoSize = True
        Me.ImgInfoLabel.Location = New System.Drawing.Point(1, 1)
        Me.ImgInfoLabel.Name = "ImgInfoLabel"
        Me.ImgInfoLabel.Size = New System.Drawing.Size(48, 17)
        Me.ImgInfoLabel.TabIndex = 0
        Me.ImgInfoLabel.Text = "Image:"
        '
        'ListSpliter
        '
        Me.ListSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.ListSpliter.Location = New System.Drawing.Point(0, 0)
        Me.ListSpliter.Name = "ListSpliter"
        Me.ListSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ListSpliter.Panel1
        '
        Me.ListSpliter.Panel1.Controls.Add(Me.FilesView)
        '
        'ListSpliter.Panel2
        '
        Me.ListSpliter.Panel2.Controls.Add(Me.ListEditPanel)
        Me.ListSpliter.Size = New System.Drawing.Size(256, 237)
        Me.ListSpliter.SplitterDistance = 177
        Me.ListSpliter.TabIndex = 1
        '
        'FilesView
        '
        Me.FilesView.AllowDrop = True
        Me.FilesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.IndexColumn, Me.TypeColumn, Me.LengthColumn, Me.SizeColumn, Me.InfoColumn, Me.CreatedColumn, Me.WritedColumn, Me.AccessedColumn})
        Me.FilesView.ContextMenuStrip = Me.FilesMenu
        Me.FilesView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilesView.FullRowSelect = True
        Me.FilesView.GridLines = True
        Me.FilesView.HideSelection = False
        Me.FilesView.LabelEdit = True
        Me.FilesView.Location = New System.Drawing.Point(0, 0)
        Me.FilesView.MultiSelect = False
        Me.FilesView.Name = "FilesView"
        Me.FilesView.Size = New System.Drawing.Size(256, 177)
        Me.FilesView.TabIndex = 0
        Me.FilesView.UseCompatibleStateImageBehavior = False
        Me.FilesView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "檔名"
        '
        'IndexColumn
        '
        Me.IndexColumn.Text = "#"
        Me.IndexColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IndexColumn.Width = 43
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
        'InfoColumn
        '
        Me.InfoColumn.Text = "描述"
        '
        'FilesMenu
        '
        Me.FilesMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileImportItem, Me.FileRenameItem, Me.FilePasteItem, Me.FileDeleteItem, Me.ToolStripSeparator9, Me.FileSetCoverItem})
        Me.FilesMenu.Name = "FilesMenu"
        Me.FilesMenu.Size = New System.Drawing.Size(133, 120)
        '
        'FileImportItem
        '
        Me.FileImportItem.Name = "FileImportItem"
        Me.FileImportItem.Size = New System.Drawing.Size(132, 22)
        Me.FileImportItem.Text = "Import"
        '
        'FileRenameItem
        '
        Me.FileRenameItem.Name = "FileRenameItem"
        Me.FileRenameItem.Size = New System.Drawing.Size(132, 22)
        Me.FileRenameItem.Text = "Rename"
        '
        'FilePasteItem
        '
        Me.FilePasteItem.Name = "FilePasteItem"
        Me.FilePasteItem.Size = New System.Drawing.Size(132, 22)
        Me.FilePasteItem.Text = "Paste"
        '
        'FileDeleteItem
        '
        Me.FileDeleteItem.Name = "FileDeleteItem"
        Me.FileDeleteItem.Size = New System.Drawing.Size(132, 22)
        Me.FileDeleteItem.Text = "Delete"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(129, 6)
        '
        'FileSetCoverItem
        '
        Me.FileSetCoverItem.Name = "FileSetCoverItem"
        Me.FileSetCoverItem.Size = New System.Drawing.Size(132, 22)
        Me.FileSetCoverItem.Text = "Set Cover"
        '
        'ListEditPanel
        '
        Me.ListEditPanel.ColumnCount = 3
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ListEditPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ListEditPanel.Controls.Add(Me.SerialLabel, 0, 0)
        Me.ListEditPanel.Controls.Add(Me.CommentLabel, 0, 1)
        Me.ListEditPanel.Controls.Add(Me.SerialBox, 1, 0)
        Me.ListEditPanel.Controls.Add(Me.CommentBox, 1, 1)
        Me.ListEditPanel.Controls.Add(Me.SaveListButton, 2, 0)
        Me.ListEditPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListEditPanel.Location = New System.Drawing.Point(0, 0)
        Me.ListEditPanel.Name = "ListEditPanel"
        Me.ListEditPanel.RowCount = 3
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ListEditPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ListEditPanel.Size = New System.Drawing.Size(256, 56)
        Me.ListEditPanel.TabIndex = 0
        '
        'SerialLabel
        '
        Me.SerialLabel.AutoSize = True
        Me.SerialLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SerialLabel.Location = New System.Drawing.Point(3, 0)
        Me.SerialLabel.Name = "SerialLabel"
        Me.SerialLabel.Size = New System.Drawing.Size(39, 24)
        Me.SerialLabel.TabIndex = 0
        Me.SerialLabel.Text = "序號"
        Me.SerialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommentLabel
        '
        Me.CommentLabel.AutoSize = True
        Me.CommentLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommentLabel.Location = New System.Drawing.Point(3, 24)
        Me.CommentLabel.Name = "CommentLabel"
        Me.CommentLabel.Size = New System.Drawing.Size(39, 24)
        Me.CommentLabel.TabIndex = 1
        Me.CommentLabel.Text = "描述"
        Me.CommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SerialBox
        '
        Me.SerialBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SerialBox.Location = New System.Drawing.Point(46, 1)
        Me.SerialBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SerialBox.Name = "SerialBox"
        Me.SerialBox.Size = New System.Drawing.Size(103, 23)
        Me.SerialBox.TabIndex = 3
        '
        'CommentBox
        '
        Me.ListEditPanel.SetColumnSpan(Me.CommentBox, 2)
        Me.CommentBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommentBox.Location = New System.Drawing.Point(46, 25)
        Me.CommentBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CommentBox.Name = "CommentBox"
        Me.CommentBox.Size = New System.Drawing.Size(209, 23)
        Me.CommentBox.TabIndex = 4
        '
        'SaveListButton
        '
        Me.SaveListButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveListButton.Location = New System.Drawing.Point(192, 0)
        Me.SaveListButton.Margin = New System.Windows.Forms.Padding(1, 0, 4, 0)
        Me.SaveListButton.Name = "SaveListButton"
        Me.SaveListButton.Size = New System.Drawing.Size(60, 24)
        Me.SaveListButton.TabIndex = 5
        Me.SaveListButton.Text = "保存"
        Me.SaveListButton.UseVisualStyleBackColor = True
        '
        'LibStatus
        '
        Me.LibStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibPathLabel, Me.NodeInfoLabel, Me.FilesLabel, Me.LinksLabel, Me.AnyProgress})
        Me.LibStatus.Location = New System.Drawing.Point(0, 479)
        Me.LibStatus.Name = "LibStatus"
        Me.LibStatus.Size = New System.Drawing.Size(648, 26)
        Me.LibStatus.TabIndex = 1
        Me.LibStatus.Text = "StatusStrip1"
        '
        'LibPathLabel
        '
        Me.LibPathLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LibPathLabel.Name = "LibPathLabel"
        Me.LibPathLabel.Size = New System.Drawing.Size(47, 21)
        Me.LibPathLabel.Text = "HDLib"
        '
        'NodeInfoLabel
        '
        Me.NodeInfoLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.NodeInfoLabel.Name = "NodeInfoLabel"
        Me.NodeInfoLabel.Size = New System.Drawing.Size(45, 21)
        Me.NodeInfoLabel.Text = "Node"
        '
        'FilesLabel
        '
        Me.FilesLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.FilesLabel.Name = "FilesLabel"
        Me.FilesLabel.Size = New System.Drawing.Size(37, 21)
        Me.FilesLabel.Text = "Files"
        '
        'LinksLabel
        '
        Me.LinksLabel.Name = "LinksLabel"
        Me.LinksLabel.Size = New System.Drawing.Size(37, 21)
        Me.LinksLabel.Text = "Links"
        '
        'AnyProgress
        '
        Me.AnyProgress.Name = "AnyProgress"
        Me.AnyProgress.Size = New System.Drawing.Size(100, 20)
        '
        'LibTools
        '
        Me.LibTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenWebButton, Me.SwitchListButton, Me.LibPathButton, Me.ImportButton, Me.CleanUpButton, Me.ToolStripSeparator3, Me.ShowCodeButton, Me.SaveButton, Me.ToolStripSeparator8, Me.UpdateDBButton, Me.TryGetFromWebItem})
        Me.LibTools.Location = New System.Drawing.Point(0, 0)
        Me.LibTools.Name = "LibTools"
        Me.LibTools.Size = New System.Drawing.Size(648, 25)
        Me.LibTools.TabIndex = 0
        Me.LibTools.Text = "ToolStrip1"
        '
        'OpenWebButton
        '
        Me.OpenWebButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenWebButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenWebButton.Image = CType(resources.GetObject("OpenWebButton.Image"), System.Drawing.Image)
        Me.OpenWebButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenWebButton.Name = "OpenWebButton"
        Me.OpenWebButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenWebButton.Text = "Open"
        Me.OpenWebButton.ToolTipText = "Open web panel"
        '
        'SwitchListButton
        '
        Me.SwitchListButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SwitchListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SwitchListButton.Image = CType(resources.GetObject("SwitchListButton.Image"), System.Drawing.Image)
        Me.SwitchListButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SwitchListButton.Name = "SwitchListButton"
        Me.SwitchListButton.Size = New System.Drawing.Size(23, 22)
        Me.SwitchListButton.Text = "LibList"
        Me.SwitchListButton.ToolTipText = "Library List"
        '
        'LibPathButton
        '
        Me.LibPathButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibPathButton.Image = CType(resources.GetObject("LibPathButton.Image"), System.Drawing.Image)
        Me.LibPathButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LibPathButton.Name = "LibPathButton"
        Me.LibPathButton.Size = New System.Drawing.Size(23, 22)
        Me.LibPathButton.Text = "HDLib"
        Me.LibPathButton.ToolTipText = "HDLib directory"
        '
        'ImportButton
        '
        Me.ImportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportButton.Image = CType(resources.GetObject("ImportButton.Image"), System.Drawing.Image)
        Me.ImportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(23, 22)
        Me.ImportButton.Text = "Import"
        Me.ImportButton.ToolTipText = "Import book file"
        '
        'CleanUpButton
        '
        Me.CleanUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CleanUpButton.Image = CType(resources.GetObject("CleanUpButton.Image"), System.Drawing.Image)
        Me.CleanUpButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CleanUpButton.Name = "CleanUpButton"
        Me.CleanUpButton.Size = New System.Drawing.Size(23, 22)
        Me.CleanUpButton.Text = "Clean Lib tree"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ShowCodeButton
        '
        Me.ShowCodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowCodeButton.Image = CType(resources.GetObject("ShowCodeButton.Image"), System.Drawing.Image)
        Me.ShowCodeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowCodeButton.Name = "ShowCodeButton"
        Me.ShowCodeButton.Size = New System.Drawing.Size(23, 22)
        Me.ShowCodeButton.Text = "Code"
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveButton.Text = "Save"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'UpdateDBButton
        '
        Me.UpdateDBButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UpdateDBButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAllItem, Me.ToolStripSeparator10, Me.DataBooksItem, Me.DataAuthorsItem, Me.DataCategoriesItem, Me.DataSpecialsItem})
        Me.UpdateDBButton.Image = CType(resources.GetObject("UpdateDBButton.Image"), System.Drawing.Image)
        Me.UpdateDBButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateDBButton.Name = "UpdateDBButton"
        Me.UpdateDBButton.Size = New System.Drawing.Size(29, 22)
        Me.UpdateDBButton.Text = "ToolStripDropDownButton1"
        '
        'DataAllItem
        '
        Me.DataAllItem.Name = "DataAllItem"
        Me.DataAllItem.Size = New System.Drawing.Size(139, 22)
        Me.DataAllItem.Text = "All"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(136, 6)
        '
        'DataBooksItem
        '
        Me.DataBooksItem.Name = "DataBooksItem"
        Me.DataBooksItem.Size = New System.Drawing.Size(139, 22)
        Me.DataBooksItem.Text = "Books"
        '
        'DataAuthorsItem
        '
        Me.DataAuthorsItem.Name = "DataAuthorsItem"
        Me.DataAuthorsItem.Size = New System.Drawing.Size(139, 22)
        Me.DataAuthorsItem.Text = "Authors"
        '
        'DataCategoriesItem
        '
        Me.DataCategoriesItem.Name = "DataCategoriesItem"
        Me.DataCategoriesItem.Size = New System.Drawing.Size(139, 22)
        Me.DataCategoriesItem.Text = "Categories"
        '
        'DataSpecialsItem
        '
        Me.DataSpecialsItem.Name = "DataSpecialsItem"
        Me.DataSpecialsItem.Size = New System.Drawing.Size(139, 22)
        Me.DataSpecialsItem.Text = "Specials"
        '
        'TryGetFromWebItem
        '
        Me.TryGetFromWebItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TryGetFromWebItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TryCategoryItem, Me.TryViewLinkItem})
        Me.TryGetFromWebItem.Image = CType(resources.GetObject("TryGetFromWebItem.Image"), System.Drawing.Image)
        Me.TryGetFromWebItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TryGetFromWebItem.Name = "TryGetFromWebItem"
        Me.TryGetFromWebItem.Size = New System.Drawing.Size(32, 22)
        Me.TryGetFromWebItem.Text = "Get"
        Me.TryGetFromWebItem.ToolTipText = "Get info from web"
        '
        'TryCategoryItem
        '
        Me.TryCategoryItem.Name = "TryCategoryItem"
        Me.TryCategoryItem.Size = New System.Drawing.Size(129, 22)
        Me.TryCategoryItem.Text = "Category"
        '
        'TryViewLinkItem
        '
        Me.TryViewLinkItem.Name = "TryViewLinkItem"
        Me.TryViewLinkItem.Size = New System.Drawing.Size(129, 22)
        Me.TryViewLinkItem.Text = "ViewLink"
        '
        'LinkPopLabel
        '
        Me.LinkPopLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkPopLabel.AutoSize = True
        Me.LinkPopLabel.BackColor = System.Drawing.Color.Transparent
        Me.LinkPopLabel.ForeColor = System.Drawing.Color.DarkGray
        Me.LinkPopLabel.Location = New System.Drawing.Point(2, 464)
        Me.LinkPopLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkPopLabel.Name = "LinkPopLabel"
        Me.LinkPopLabel.Size = New System.Drawing.Size(13, 17)
        Me.LinkPopLabel.TabIndex = 3
        Me.LinkPopLabel.Text = "-"
        '
        'HDBrowser
        '
        Me.HDBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HDBrowser.Location = New System.Drawing.Point(0, 25)
        Me.HDBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HDBrowser.Name = "HDBrowser"
        Me.HDBrowser.ScriptErrorsSuppressed = True
        Me.HDBrowser.Size = New System.Drawing.Size(278, 454)
        Me.HDBrowser.TabIndex = 2
        Me.HDBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'WebStatus
        '
        Me.WebStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NowLabel, Me.UrlLabel})
        Me.WebStatus.Location = New System.Drawing.Point(0, 479)
        Me.WebStatus.Name = "WebStatus"
        Me.WebStatus.Size = New System.Drawing.Size(278, 26)
        Me.WebStatus.TabIndex = 1
        Me.WebStatus.Text = "StatusStrip2"
        '
        'NowLabel
        '
        Me.NowLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.NowLabel.Name = "NowLabel"
        Me.NowLabel.Size = New System.Drawing.Size(39, 21)
        Me.NowLabel.Text = "Now"
        '
        'UrlLabel
        '
        Me.UrlLabel.ForeColor = System.Drawing.Color.DarkCyan
        Me.UrlLabel.Name = "UrlLabel"
        Me.UrlLabel.Size = New System.Drawing.Size(25, 21)
        Me.UrlLabel.Text = "Url"
        '
        'WebTools
        '
        Me.WebTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HDHistoryItem, Me.BackButton, Me.ForwardButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.HtmlTitleLabel, Me.ToolStripSeparator2, Me.SourceButton, Me.CloseWebButton})
        Me.WebTools.Location = New System.Drawing.Point(0, 0)
        Me.WebTools.Name = "WebTools"
        Me.WebTools.Size = New System.Drawing.Size(278, 25)
        Me.WebTools.TabIndex = 0
        Me.WebTools.Text = "ToolStrip2"
        '
        'HDHistoryItem
        '
        Me.HDHistoryItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HDHistoryItem.Image = CType(resources.GetObject("HDHistoryItem.Image"), System.Drawing.Image)
        Me.HDHistoryItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HDHistoryItem.Name = "HDHistoryItem"
        Me.HDHistoryItem.Size = New System.Drawing.Size(32, 22)
        Me.HDHistoryItem.Text = "Home"
        '
        'BackButton
        '
        Me.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(23, 22)
        Me.BackButton.Text = "Back"
        '
        'ForwardButton
        '
        Me.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardButton.Image = CType(resources.GetObject("ForwardButton.Image"), System.Drawing.Image)
        Me.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(23, 22)
        Me.ForwardButton.Text = "Forward"
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
        Me.HtmlTitleLabel.Name = "HtmlTitleLabel"
        Me.HtmlTitleLabel.Size = New System.Drawing.Size(32, 22)
        Me.HtmlTitleLabel.Text = "Title"
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
        '
        'CloseWebButton
        '
        Me.CloseWebButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseWebButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseWebButton.Image = CType(resources.GetObject("CloseWebButton.Image"), System.Drawing.Image)
        Me.CloseWebButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseWebButton.Name = "CloseWebButton"
        Me.CloseWebButton.Size = New System.Drawing.Size(23, 22)
        Me.CloseWebButton.Text = "Close"
        Me.CloseWebButton.ToolTipText = "Close web panel"
        '
        'CreatedColumn
        '
        Me.CreatedColumn.Text = "最初創建"
        '
        'SizeColumn
        '
        Me.SizeColumn.Text = "容量"
        '
        'AccessedColumn
        '
        Me.AccessedColumn.Text = "最後讀取"
        '
        'WritedColumn
        '
        Me.WritedColumn.Text = "最後寫入"
        '
        'LibView
        '
        Me.LibView.AllowDrop = True
        Me.LibView.ConnectedListView = Nothing
        Me.LibView.ContextMenuStrip = Me.LibMenu
        Me.LibView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibView.ExceptNames = CType(resources.GetObject("LibView.ExceptNames"), System.Collections.Specialized.StringCollection)
        Me.LibView.HideSelection = False
        Me.LibView.ImageIndex = 0
        Me.LibView.LabelEdit = True
        Me.LibView.LineColor = System.Drawing.Color.DarkCyan
        Me.LibView.Location = New System.Drawing.Point(0, 23)
        Me.LibView.Name = "LibView"
        Me.LibView.NeedSort = True
        Me.LibView.SelectedImageIndex = 0
        Me.LibView.ShowAllDirectories = False
        Me.LibView.Size = New System.Drawing.Size(170, 431)
        Me.LibView.StartDirectory = "C:\"
        Me.LibView.TabIndex = 1
        '
        'HDLibForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 507)
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootMenu)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.RootMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HDLibForm"
        Me.Text = "HDLibForm"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel1.PerformLayout()
        Me.RootSpliter.Panel2.ResumeLayout(False)
        Me.RootSpliter.Panel2.PerformLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.LibSpliter.Panel1.ResumeLayout(False)
        Me.LibSpliter.Panel1.PerformLayout()
        Me.LibSpliter.Panel2.ResumeLayout(False)
        CType(Me.LibSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibSpliter.ResumeLayout(False)
        Me.LibMenu.ResumeLayout(False)
        Me.BookSpliter.Panel1.ResumeLayout(False)
        Me.BookSpliter.Panel2.ResumeLayout(False)
        CType(Me.BookSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookSpliter.ResumeLayout(False)
        Me.DataPanel.ResumeLayout(False)
        Me.DataPanel.PerformLayout()
        Me.FileSpliter.Panel1.ResumeLayout(False)
        Me.FileSpliter.Panel2.ResumeLayout(False)
        CType(Me.FileSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FileSpliter.ResumeLayout(False)
        Me.ImgSpliter.Panel1.ResumeLayout(False)
        Me.ImgSpliter.Panel2.ResumeLayout(False)
        Me.ImgSpliter.Panel2.PerformLayout()
        CType(Me.ImgSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImgSpliter.ResumeLayout(False)
        CType(Me.CoverBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListSpliter.Panel1.ResumeLayout(False)
        Me.ListSpliter.Panel2.ResumeLayout(False)
        CType(Me.ListSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListSpliter.ResumeLayout(False)
        Me.FilesMenu.ResumeLayout(False)
        Me.ListEditPanel.ResumeLayout(False)
        Me.ListEditPanel.PerformLayout()
        Me.LibStatus.ResumeLayout(False)
        Me.LibStatus.PerformLayout()
        Me.LibTools.ResumeLayout(False)
        Me.LibTools.PerformLayout()
        Me.WebStatus.ResumeLayout(False)
        Me.WebStatus.PerformLayout()
        Me.WebTools.ResumeLayout(False)
        Me.WebTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootMenu As MenuStrip
    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents LibStatus As StatusStrip
    Friend WithEvents LibTools As ToolStrip
    Friend WithEvents HDBrowser As WebBrowser
    Friend WithEvents WebStatus As StatusStrip
    Friend WithEvents WebTools As ToolStrip
    Friend WithEvents UrlLabel As ToolStripStatusLabel
    Friend WithEvents HDHistoryItem As ToolStripSplitButton
    Friend WithEvents HtmlTitleLabel As ToolStripLabel
    Friend WithEvents BackButton As ToolStripButton
    Friend WithEvents ForwardButton As ToolStripButton
    Friend WithEvents RefreshButton As ToolStripButton
    Friend WithEvents SourceButton As ToolStripButton
    Friend WithEvents NowLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LinkPopLabel As Label
    Friend WithEvents CloseWebButton As ToolStripButton
    Friend WithEvents OpenWebButton As ToolStripButton
    Friend WithEvents LibSpliter As SplitContainer
    Friend WithEvents IndicatedBox As TextBox
    Friend WithEvents DataPanel As TableLayoutPanel
    Friend WithEvents SwitchListButton As ToolStripButton
    Friend WithEvents VersionLable As Label
    Friend WithEvents InfoUpdatedLabel As Label
    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents SpecialLabel As Label
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents CoverBox As PictureBox
    Friend WithEvents IDBox As TextBox
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents SubtitleBox As TextBox
    Friend WithEvents AuthorBox As TextBox
    Friend WithEvents VersionBox As TextBox
    Friend WithEvents UpdatedBox As TextBox
    Friend WithEvents CategoryBox As TextBox
    Friend WithEvents SpecialBox As TextBox
    Friend WithEvents IntroBox As TextBox
    Friend WithEvents LibPathLabel As ToolStripStatusLabel
    Friend WithEvents LibPathButton As ToolStripButton
    Friend WithEvents ImportButton As ToolStripButton
    Friend WithEvents BookSpliter As SplitContainer
    Friend WithEvents FileSpliter As SplitContainer
    Friend WithEvents ImgSpliter As SplitContainer
    Friend WithEvents FilesView As ListView
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents IndexColumn As ColumnHeader
    Friend WithEvents TypeColumn As ColumnHeader
    Friend WithEvents LengthColumn As ColumnHeader
    Friend WithEvents ImgInfoLabel As Label
    Friend WithEvents NodeInfoLabel As ToolStripStatusLabel
    Friend WithEvents FilesLabel As ToolStripStatusLabel
    Friend WithEvents AuthorInfoButton As Button
    Friend WithEvents PublishInfoLabel As Label
    Friend WithEvents PublishInfoBox As TextBox
    Friend WithEvents CategoryButton As Button
    Friend WithEvents SpecialButton As Button
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents InfoColumn As ColumnHeader
    Friend WithEvents TypeBox As ComboBox
    Friend WithEvents CoverButton As Button
    Friend WithEvents LibView As KzDirectoryTreeView
    Friend WithEvents SaveButton As ToolStripButton
    Friend WithEvents ShowCodeButton As ToolStripButton
    Friend WithEvents LibMenu As ContextMenuStrip
    Friend WithEvents LibBookItem As ToolStripMenuItem
    Friend WithEvents FilesMenu As ContextMenuStrip
    Friend WithEvents LinkLabel As Label
    Friend WithEvents CoverLinkButton As Button
    Friend WithEvents LibLevelItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents LibAuthorItem As ToolStripMenuItem
    Friend WithEvents LibCategoryItem As ToolStripMenuItem
    Friend WithEvents LibSpecialItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents LibRenameItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents LibCopyItem As ToolStripMenuItem
    Friend WithEvents LibPasteItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents LibDeleteItem As ToolStripMenuItem
    Friend WithEvents LibCutItem As ToolStripMenuItem
    Friend WithEvents TypeLabel As Label
    Friend WithEvents ListSpliter As SplitContainer
    Friend WithEvents SaveInfButton As Button
    Friend WithEvents AbortInfButton As Button
    Friend WithEvents ListEditPanel As TableLayoutPanel
    Friend WithEvents SerialLabel As Label
    Friend WithEvents CommentLabel As Label
    Friend WithEvents SerialBox As TextBox
    Friend WithEvents CommentBox As TextBox
    Friend WithEvents SaveListButton As Button
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents FileImportItem As ToolStripMenuItem
    Friend WithEvents FileRenameItem As ToolStripMenuItem
    Friend WithEvents FilePasteItem As ToolStripMenuItem
    Friend WithEvents FileDeleteItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents FileSetCoverItem As ToolStripMenuItem
    Friend WithEvents UpdateDBButton As ToolStripDropDownButton
    Friend WithEvents DataAllItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents DataBooksItem As ToolStripMenuItem
    Friend WithEvents DataAuthorsItem As ToolStripMenuItem
    Friend WithEvents DataCategoriesItem As ToolStripMenuItem
    Friend WithEvents DataSpecialsItem As ToolStripMenuItem
    Friend WithEvents SeriesLabel As Label
    Friend WithEvents SeriesBox As TextBox
    Friend WithEvents ViewLinkButton As Button
    Friend WithEvents DownLinkButton As Button
    Friend WithEvents LinksLabel As ToolStripStatusLabel
    Friend WithEvents AnyProgress As ToolStripProgressBar
    Friend WithEvents CleanUpButton As ToolStripButton
    Friend WithEvents TryGetFromWebItem As ToolStripSplitButton
    Friend WithEvents TryCategoryItem As ToolStripMenuItem
    Friend WithEvents TryViewLinkItem As ToolStripMenuItem
    Friend WithEvents CreatedColumn As ColumnHeader
    Friend WithEvents SizeColumn As ColumnHeader
    Friend WithEvents AccessedColumn As ColumnHeader
    Friend WithEvents WritedColumn As ColumnHeader
End Class
