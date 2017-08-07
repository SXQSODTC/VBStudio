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
        Me.LibView = New KzSystem.KzDirectoryTreeView()
        Me.LibMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LibNewLevelCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.LibNewBookItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.FileSpliter = New System.Windows.Forms.SplitContainer()
        Me.ImgSpliter = New System.Windows.Forms.SplitContainer()
        Me.CoverBox = New System.Windows.Forms.PictureBox()
        Me.ReCoverButton = New System.Windows.Forms.Button()
        Me.CoverButton = New System.Windows.Forms.Button()
        Me.ImgInfoLabel = New System.Windows.Forms.Label()
        Me.FilesView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IndexColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SizeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfoColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FilesMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LibStatus = New System.Windows.Forms.StatusStrip()
        Me.LibPathLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NodeInfoLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FilesLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LibTools = New System.Windows.Forms.ToolStrip()
        Me.OpenWebButton = New System.Windows.Forms.ToolStripButton()
        Me.SwitchListButton = New System.Windows.Forms.ToolStripButton()
        Me.LibPathButton = New System.Windows.Forms.ToolStripButton()
        Me.ImportButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddNewSelector = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowButton = New System.Windows.Forms.ToolStripButton()
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
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.LinkBox = New System.Windows.Forms.TextBox()
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
        Me.RootSpliter.Size = New System.Drawing.Size(932, 492)
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
        Me.LibSpliter.Size = New System.Drawing.Size(648, 439)
        Me.LibSpliter.SplitterDistance = 145
        Me.LibSpliter.SplitterWidth = 1
        Me.LibSpliter.TabIndex = 2
        '
        'LibView
        '
        Me.LibView.ConnectedListView = Nothing
        Me.LibView.ContextMenuStrip = Me.LibMenu
        Me.LibView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibView.HideSelection = False
        Me.LibView.ImageIndex = 0
        Me.LibView.LabelEdit = True
        Me.LibView.LineColor = System.Drawing.Color.DimGray
        Me.LibView.Location = New System.Drawing.Point(0, 23)
        Me.LibView.Name = "LibView"
        Me.LibView.NeedSort = True
        Me.LibView.SelectedImageIndex = 0
        Me.LibView.ShowAllDirectories = False
        Me.LibView.Size = New System.Drawing.Size(145, 416)
        Me.LibView.StartDirectory = "C:\"
        Me.LibView.TabIndex = 1
        '
        'LibMenu
        '
        Me.LibMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibNewLevelCombo, Me.LibNewBookItem, Me.ParentItem})
        Me.LibMenu.Name = "LibMenu"
        Me.LibMenu.Size = New System.Drawing.Size(182, 73)
        '
        'LibNewLevelCombo
        '
        Me.LibNewLevelCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LibNewLevelCombo.Items.AddRange(New Object() {"Same level", "Child level"})
        Me.LibNewLevelCombo.Margin = New System.Windows.Forms.Padding(0)
        Me.LibNewLevelCombo.MaxDropDownItems = 2
        Me.LibNewLevelCombo.Name = "LibNewLevelCombo"
        Me.LibNewLevelCombo.Size = New System.Drawing.Size(121, 25)
        '
        'LibNewBookItem
        '
        Me.LibNewBookItem.Name = "LibNewBookItem"
        Me.LibNewBookItem.Size = New System.Drawing.Size(181, 22)
        Me.LibNewBookItem.Text = "New Book"
        '
        'ParentItem
        '
        Me.ParentItem.CheckOnClick = True
        Me.ParentItem.Name = "ParentItem"
        Me.ParentItem.Size = New System.Drawing.Size(181, 22)
        Me.ParentItem.Text = "Parent"
        '
        'IndicatedBox
        '
        Me.IndicatedBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.IndicatedBox.Location = New System.Drawing.Point(0, 0)
        Me.IndicatedBox.Name = "IndicatedBox"
        Me.IndicatedBox.Size = New System.Drawing.Size(145, 23)
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
        Me.BookSpliter.Size = New System.Drawing.Size(502, 439)
        Me.BookSpliter.SplitterDistance = 251
        Me.BookSpliter.SplitterWidth = 2
        Me.BookSpliter.TabIndex = 1
        '
        'DataPanel
        '
        Me.DataPanel.ColumnCount = 4
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DataPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.DataPanel.Controls.Add(Me.VersionLable, 0, 5)
        Me.DataPanel.Controls.Add(Me.InfoUpdatedLabel, 0, 8)
        Me.DataPanel.Controls.Add(Me.SubtitleLabel, 0, 2)
        Me.DataPanel.Controls.Add(Me.SpecialLabel, 0, 7)
        Me.DataPanel.Controls.Add(Me.AuthorLabel, 0, 3)
        Me.DataPanel.Controls.Add(Me.TitleLabel, 0, 1)
        Me.DataPanel.Controls.Add(Me.CategoryLabel, 0, 6)
        Me.DataPanel.Controls.Add(Me.IDLabel, 0, 0)
        Me.DataPanel.Controls.Add(Me.IDBox, 1, 0)
        Me.DataPanel.Controls.Add(Me.TitleBox, 1, 1)
        Me.DataPanel.Controls.Add(Me.SubtitleBox, 1, 2)
        Me.DataPanel.Controls.Add(Me.AuthorBox, 1, 3)
        Me.DataPanel.Controls.Add(Me.VersionBox, 1, 5)
        Me.DataPanel.Controls.Add(Me.UpdatedBox, 1, 8)
        Me.DataPanel.Controls.Add(Me.CategoryBox, 1, 6)
        Me.DataPanel.Controls.Add(Me.SpecialBox, 1, 7)
        Me.DataPanel.Controls.Add(Me.IntroBox, 0, 10)
        Me.DataPanel.Controls.Add(Me.AuthorInfoButton, 3, 3)
        Me.DataPanel.Controls.Add(Me.PublishInfoLabel, 0, 4)
        Me.DataPanel.Controls.Add(Me.PublishInfoBox, 1, 4)
        Me.DataPanel.Controls.Add(Me.CategoryButton, 3, 6)
        Me.DataPanel.Controls.Add(Me.SpecialButton, 3, 7)
        Me.DataPanel.Controls.Add(Me.TypeBox, 2, 0)
        Me.DataPanel.Controls.Add(Me.LinkLabel, 0, 9)
        Me.DataPanel.Controls.Add(Me.LinkBox, 1, 9)
        Me.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPanel.Location = New System.Drawing.Point(0, 0)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.RowCount = 11
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
        Me.DataPanel.Size = New System.Drawing.Size(251, 439)
        Me.DataPanel.TabIndex = 0
        '
        'VersionLable
        '
        Me.VersionLable.AutoSize = True
        Me.VersionLable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionLable.Location = New System.Drawing.Point(3, 120)
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
        Me.InfoUpdatedLabel.Location = New System.Drawing.Point(3, 192)
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
        Me.SubtitleLabel.Location = New System.Drawing.Point(3, 48)
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
        Me.SpecialLabel.Location = New System.Drawing.Point(3, 168)
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
        Me.AuthorLabel.Location = New System.Drawing.Point(3, 72)
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
        Me.TitleLabel.Location = New System.Drawing.Point(3, 24)
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
        Me.CategoryLabel.Location = New System.Drawing.Point(3, 144)
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
        Me.IDLabel.Location = New System.Drawing.Point(3, 0)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(44, 24)
        Me.IDLabel.TabIndex = 0
        Me.IDLabel.Text = "編號"
        Me.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IDBox
        '
        Me.IDBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDBox.Location = New System.Drawing.Point(51, 1)
        Me.IDBox.Margin = New System.Windows.Forms.Padding(1)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(88, 23)
        Me.IDBox.TabIndex = 1
        Me.IDBox.Text = "ID"
        '
        'TitleBox
        '
        Me.DataPanel.SetColumnSpan(Me.TitleBox, 2)
        Me.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleBox.Location = New System.Drawing.Point(51, 25)
        Me.TitleBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(178, 23)
        Me.TitleBox.TabIndex = 2
        Me.TitleBox.Text = "Title"
        '
        'SubtitleBox
        '
        Me.DataPanel.SetColumnSpan(Me.SubtitleBox, 2)
        Me.SubtitleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubtitleBox.Location = New System.Drawing.Point(51, 49)
        Me.SubtitleBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SubtitleBox.Name = "SubtitleBox"
        Me.SubtitleBox.Size = New System.Drawing.Size(178, 23)
        Me.SubtitleBox.TabIndex = 3
        Me.SubtitleBox.Text = "Subtitle"
        '
        'AuthorBox
        '
        Me.DataPanel.SetColumnSpan(Me.AuthorBox, 2)
        Me.AuthorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorBox.Location = New System.Drawing.Point(51, 73)
        Me.AuthorBox.Margin = New System.Windows.Forms.Padding(1)
        Me.AuthorBox.Name = "AuthorBox"
        Me.AuthorBox.Size = New System.Drawing.Size(178, 23)
        Me.AuthorBox.TabIndex = 4
        Me.AuthorBox.Text = "Author"
        '
        'VersionBox
        '
        Me.DataPanel.SetColumnSpan(Me.VersionBox, 2)
        Me.VersionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionBox.Location = New System.Drawing.Point(51, 121)
        Me.VersionBox.Margin = New System.Windows.Forms.Padding(1)
        Me.VersionBox.Name = "VersionBox"
        Me.VersionBox.Size = New System.Drawing.Size(178, 23)
        Me.VersionBox.TabIndex = 6
        Me.VersionBox.Text = "Version"
        '
        'UpdatedBox
        '
        Me.DataPanel.SetColumnSpan(Me.UpdatedBox, 2)
        Me.UpdatedBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdatedBox.Location = New System.Drawing.Point(51, 193)
        Me.UpdatedBox.Margin = New System.Windows.Forms.Padding(1)
        Me.UpdatedBox.Name = "UpdatedBox"
        Me.UpdatedBox.Size = New System.Drawing.Size(178, 23)
        Me.UpdatedBox.TabIndex = 9
        Me.UpdatedBox.Text = "Updated"
        '
        'CategoryBox
        '
        Me.DataPanel.SetColumnSpan(Me.CategoryBox, 2)
        Me.CategoryBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryBox.Location = New System.Drawing.Point(51, 145)
        Me.CategoryBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(178, 23)
        Me.CategoryBox.TabIndex = 7
        Me.CategoryBox.Text = "Category"
        '
        'SpecialBox
        '
        Me.DataPanel.SetColumnSpan(Me.SpecialBox, 2)
        Me.SpecialBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecialBox.Location = New System.Drawing.Point(51, 169)
        Me.SpecialBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SpecialBox.Name = "SpecialBox"
        Me.SpecialBox.Size = New System.Drawing.Size(178, 23)
        Me.SpecialBox.TabIndex = 8
        Me.SpecialBox.Text = "Special"
        '
        'IntroBox
        '
        Me.DataPanel.SetColumnSpan(Me.IntroBox, 4)
        Me.IntroBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntroBox.Location = New System.Drawing.Point(1, 241)
        Me.IntroBox.Margin = New System.Windows.Forms.Padding(1)
        Me.IntroBox.Multiline = True
        Me.IntroBox.Name = "IntroBox"
        Me.IntroBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.IntroBox.Size = New System.Drawing.Size(249, 197)
        Me.IntroBox.TabIndex = 10
        Me.IntroBox.Text = "Intro"
        '
        'AuthorInfoButton
        '
        Me.AuthorInfoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorInfoButton.Location = New System.Drawing.Point(230, 72)
        Me.AuthorInfoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorInfoButton.Name = "AuthorInfoButton"
        Me.AuthorInfoButton.Size = New System.Drawing.Size(21, 24)
        Me.AuthorInfoButton.TabIndex = 21
        Me.AuthorInfoButton.Text = ">"
        Me.AuthorInfoButton.UseVisualStyleBackColor = True
        '
        'PublishInfoLabel
        '
        Me.PublishInfoLabel.AutoSize = True
        Me.PublishInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublishInfoLabel.Location = New System.Drawing.Point(3, 96)
        Me.PublishInfoLabel.Name = "PublishInfoLabel"
        Me.PublishInfoLabel.Size = New System.Drawing.Size(44, 24)
        Me.PublishInfoLabel.TabIndex = 22
        Me.PublishInfoLabel.Text = "出版"
        Me.PublishInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PublishInfoBox
        '
        Me.DataPanel.SetColumnSpan(Me.PublishInfoBox, 2)
        Me.PublishInfoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublishInfoBox.Location = New System.Drawing.Point(51, 97)
        Me.PublishInfoBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PublishInfoBox.Name = "PublishInfoBox"
        Me.PublishInfoBox.Size = New System.Drawing.Size(178, 23)
        Me.PublishInfoBox.TabIndex = 5
        Me.PublishInfoBox.Text = "PublishInfo"
        '
        'CategoryButton
        '
        Me.CategoryButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryButton.Location = New System.Drawing.Point(230, 144)
        Me.CategoryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(21, 24)
        Me.CategoryButton.TabIndex = 24
        Me.CategoryButton.Text = ">"
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'SpecialButton
        '
        Me.SpecialButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecialButton.Location = New System.Drawing.Point(230, 168)
        Me.SpecialButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SpecialButton.Name = "SpecialButton"
        Me.SpecialButton.Size = New System.Drawing.Size(21, 24)
        Me.SpecialButton.TabIndex = 25
        Me.SpecialButton.Text = ">"
        Me.SpecialButton.UseVisualStyleBackColor = True
        '
        'TypeBox
        '
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Location = New System.Drawing.Point(140, 0)
        Me.TypeBox.Margin = New System.Windows.Forms.Padding(0)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(90, 25)
        Me.TypeBox.TabIndex = 26
        '
        'FileSpliter
        '
        Me.FileSpliter.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.FileSpliter.Panel2.Controls.Add(Me.FilesView)
        Me.FileSpliter.Size = New System.Drawing.Size(249, 439)
        Me.FileSpliter.SplitterDistance = 200
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
        Me.ImgSpliter.Panel2.Controls.Add(Me.ReCoverButton)
        Me.ImgSpliter.Panel2.Controls.Add(Me.CoverButton)
        Me.ImgSpliter.Panel2.Controls.Add(Me.ImgInfoLabel)
        Me.ImgSpliter.Size = New System.Drawing.Size(249, 200)
        Me.ImgSpliter.SplitterDistance = 143
        Me.ImgSpliter.SplitterWidth = 2
        Me.ImgSpliter.TabIndex = 0
        '
        'CoverBox
        '
        Me.CoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CoverBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoverBox.Location = New System.Drawing.Point(0, 0)
        Me.CoverBox.Name = "CoverBox"
        Me.CoverBox.Size = New System.Drawing.Size(143, 200)
        Me.CoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CoverBox.TabIndex = 11
        Me.CoverBox.TabStop = False
        '
        'ReCoverButton
        '
        Me.ReCoverButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ReCoverButton.Location = New System.Drawing.Point(43, 176)
        Me.ReCoverButton.Name = "ReCoverButton"
        Me.ReCoverButton.Size = New System.Drawing.Size(42, 23)
        Me.ReCoverButton.TabIndex = 2
        Me.ReCoverButton.Text = "更換"
        Me.ReCoverButton.UseVisualStyleBackColor = True
        '
        'CoverButton
        '
        Me.CoverButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CoverButton.Location = New System.Drawing.Point(2, 176)
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
        'FilesView
        '
        Me.FilesView.AllowDrop = True
        Me.FilesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.IndexColumn, Me.TypeColumn, Me.SizeColumn, Me.InfoColumn})
        Me.FilesView.ContextMenuStrip = Me.FilesMenu
        Me.FilesView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilesView.FullRowSelect = True
        Me.FilesView.GridLines = True
        Me.FilesView.HideSelection = False
        Me.FilesView.Location = New System.Drawing.Point(0, 0)
        Me.FilesView.MultiSelect = False
        Me.FilesView.Name = "FilesView"
        Me.FilesView.Size = New System.Drawing.Size(249, 237)
        Me.FilesView.TabIndex = 0
        Me.FilesView.UseCompatibleStateImageBehavior = False
        Me.FilesView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        '
        'IndexColumn
        '
        Me.IndexColumn.Text = "#"
        Me.IndexColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IndexColumn.Width = 43
        '
        'TypeColumn
        '
        Me.TypeColumn.Text = "Type"
        '
        'SizeColumn
        '
        Me.SizeColumn.Text = "Size"
        Me.SizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InfoColumn
        '
        Me.InfoColumn.Text = "Info"
        '
        'FilesMenu
        '
        Me.FilesMenu.Name = "FilesMenu"
        Me.FilesMenu.Size = New System.Drawing.Size(61, 4)
        '
        'LibStatus
        '
        Me.LibStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibPathLabel, Me.NodeInfoLabel, Me.FilesLabel})
        Me.LibStatus.Location = New System.Drawing.Point(0, 464)
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
        Me.FilesLabel.Name = "FilesLabel"
        Me.FilesLabel.Size = New System.Drawing.Size(33, 21)
        Me.FilesLabel.Text = "Files"
        '
        'LibTools
        '
        Me.LibTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenWebButton, Me.SwitchListButton, Me.LibPathButton, Me.ImportButton, Me.ToolStripSeparator3, Me.AddNewSelector, Me.SaveButton, Me.ShowButton})
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'AddNewSelector
        '
        Me.AddNewSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNewSelector.Image = CType(resources.GetObject("AddNewSelector.Image"), System.Drawing.Image)
        Me.AddNewSelector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddNewSelector.Name = "AddNewSelector"
        Me.AddNewSelector.Size = New System.Drawing.Size(29, 22)
        Me.AddNewSelector.Text = "ToolStripDropDownButton1"
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveButton.Text = "ToolStripButton1"
        '
        'ShowButton
        '
        Me.ShowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowButton.Image = CType(resources.GetObject("ShowButton.Image"), System.Drawing.Image)
        Me.ShowButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(23, 22)
        Me.ShowButton.Text = "ToolStripButton1"
        '
        'LinkPopLabel
        '
        Me.LinkPopLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkPopLabel.AutoSize = True
        Me.LinkPopLabel.BackColor = System.Drawing.Color.Transparent
        Me.LinkPopLabel.ForeColor = System.Drawing.Color.DarkGray
        Me.LinkPopLabel.Location = New System.Drawing.Point(2, 449)
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
        Me.HDBrowser.Size = New System.Drawing.Size(278, 439)
        Me.HDBrowser.TabIndex = 2
        Me.HDBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'WebStatus
        '
        Me.WebStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NowLabel, Me.UrlLabel})
        Me.WebStatus.Location = New System.Drawing.Point(0, 464)
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
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel.Location = New System.Drawing.Point(3, 216)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(44, 24)
        Me.LinkLabel.TabIndex = 27
        Me.LinkLabel.Text = "鏈接"
        Me.LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkBox
        '
        Me.DataPanel.SetColumnSpan(Me.LinkBox, 2)
        Me.LinkBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkBox.Location = New System.Drawing.Point(51, 217)
        Me.LinkBox.Margin = New System.Windows.Forms.Padding(1)
        Me.LinkBox.Name = "LinkBox"
        Me.LinkBox.Size = New System.Drawing.Size(178, 23)
        Me.LinkBox.TabIndex = 28
        '
        'HDLibForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 492)
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
    Friend WithEvents SizeColumn As ColumnHeader
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
    Friend WithEvents ReCoverButton As Button
    Friend WithEvents LibView As KzDirectoryTreeView
    Friend WithEvents AddNewSelector As ToolStripDropDownButton
    Friend WithEvents SaveButton As ToolStripButton
    Friend WithEvents ShowButton As ToolStripButton
    Friend WithEvents LibMenu As ContextMenuStrip
    Friend WithEvents LibNewLevelCombo As ToolStripComboBox
    Friend WithEvents LibNewBookItem As ToolStripMenuItem
    Friend WithEvents FilesMenu As ContextMenuStrip
    Friend WithEvents ParentItem As ToolStripMenuItem
    Friend WithEvents LinkLabel As Label
    Friend WithEvents LinkBox As TextBox
End Class
