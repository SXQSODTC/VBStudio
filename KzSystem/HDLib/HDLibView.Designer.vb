<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDLibView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDLibView))
        Me.LibSpliter = New System.Windows.Forms.SplitContainer()
        Me.InnerSpliter = New System.Windows.Forms.SplitContainer()
        Me.LibView = New KzSystem.KzDirectoryTreeView()
        Me.LibSearchTools = New System.Windows.Forms.ToolStrip()
        Me.LibSearchTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.LibSearchGoButton = New System.Windows.Forms.ToolStripButton()
        Me.LibSearchAdvanceButton = New System.Windows.Forms.ToolStripButton()
        Me.DetailSpliter = New System.Windows.Forms.SplitContainer()
        Me.HeaderSpliter = New System.Windows.Forms.SplitContainer()
        Me.DetailTabs = New System.Windows.Forms.TabControl()
        Me.PageIntro = New System.Windows.Forms.TabPage()
        Me.PageAuthor = New System.Windows.Forms.TabPage()
        Me.PageFiles = New System.Windows.Forms.TabPage()
        Me.PageLinks = New System.Windows.Forms.TabPage()
        Me.ViewTabs = New System.Windows.Forms.TabControl()
        Me.PageWeb = New System.Windows.Forms.TabPage()
        Me.PageText = New System.Windows.Forms.TabPage()
        Me.LibMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibStatus = New System.Windows.Forms.StatusStrip()
        Me.PageImages = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.HeaderSpliter.SuspendLayout()
        Me.DetailTabs.SuspendLayout()
        Me.ViewTabs.SuspendLayout()
        Me.LibMenu.SuspendLayout()
        Me.SuspendLayout()
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
        '
        'LibSpliter.Panel2
        '
        Me.LibSpliter.Panel2.Controls.Add(Me.ViewTabs)
        Me.LibSpliter.Size = New System.Drawing.Size(799, 430)
        Me.LibSpliter.SplitterDistance = 554
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
        Me.InnerSpliter.Size = New System.Drawing.Size(554, 430)
        Me.InnerSpliter.SplitterDistance = 184
        Me.InnerSpliter.SplitterWidth = 5
        Me.InnerSpliter.TabIndex = 0
        '
        'LibView
        '
        Me.LibView.AllowDrop = True
        'Me.LibView.ConnectedListView = Nothing
        Me.LibView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibView.ExceptNames = CType(resources.GetObject("LibView.ExceptNames"), System.Collections.Specialized.StringCollection)
        Me.LibView.HideSelection = False
        Me.LibView.ImageIndex = 0
        Me.LibView.LabelEdit = True
        Me.LibView.LineColor = System.Drawing.Color.DarkCyan
        Me.LibView.Location = New System.Drawing.Point(0, 25)
        Me.LibView.Name = "LibView"
        Me.LibView.NeedSort = True
        Me.LibView.SelectedImageIndex = 0
        Me.LibView.ShowAllDirectories = False
        Me.LibView.Size = New System.Drawing.Size(184, 405)
        Me.LibView.StartDirectory = "C:\"
        Me.LibView.TabIndex = 2
        '
        'LibSearchTools
        '
        Me.LibSearchTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LibSearchTools.Location = New System.Drawing.Point(0, 0)
        Me.LibSearchTools.Name = "LibSearchTools"
        Me.LibSearchTools.Size = New System.Drawing.Size(184, 25)
        Me.LibSearchTools.TabIndex = 1
        Me.LibSearchTools.Text = "ToolStrip1"
        '
        'LibSearchTextBox
        '
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
        Me.DetailSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailSpliter.Location = New System.Drawing.Point(0, 0)
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
        Me.DetailSpliter.Size = New System.Drawing.Size(365, 430)
        Me.DetailSpliter.SplitterDistance = 147
        Me.DetailSpliter.SplitterWidth = 6
        Me.DetailSpliter.TabIndex = 0
        '
        'HeaderSpliter
        '
        Me.HeaderSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderSpliter.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSpliter.Name = "HeaderSpliter"
        Me.HeaderSpliter.Size = New System.Drawing.Size(365, 147)
        Me.HeaderSpliter.SplitterDistance = 162
        Me.HeaderSpliter.TabIndex = 0
        '
        'DetailTabs
        '
        Me.DetailTabs.Controls.Add(Me.PageImages)
        Me.DetailTabs.Controls.Add(Me.PageIntro)
        Me.DetailTabs.Controls.Add(Me.PageAuthor)
        Me.DetailTabs.Controls.Add(Me.PageFiles)
        Me.DetailTabs.Controls.Add(Me.PageLinks)
        Me.DetailTabs.Controls.Add(Me.TabPage1)
        Me.DetailTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailTabs.Location = New System.Drawing.Point(0, 0)
        Me.DetailTabs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DetailTabs.Name = "DetailTabs"
        Me.DetailTabs.SelectedIndex = 0
        Me.DetailTabs.Size = New System.Drawing.Size(365, 277)
        Me.DetailTabs.TabIndex = 0
        '
        'PageIntro
        '
        Me.PageIntro.Location = New System.Drawing.Point(4, 26)
        Me.PageIntro.Name = "PageIntro"
        Me.PageIntro.Size = New System.Drawing.Size(357, 247)
        Me.PageIntro.TabIndex = 1
        Me.PageIntro.Text = "簡介"
        Me.PageIntro.UseVisualStyleBackColor = True
        '
        'PageAuthor
        '
        Me.PageAuthor.Location = New System.Drawing.Point(4, 26)
        Me.PageAuthor.Name = "PageAuthor"
        Me.PageAuthor.Size = New System.Drawing.Size(357, 247)
        Me.PageAuthor.TabIndex = 2
        Me.PageAuthor.Text = "作者"
        Me.PageAuthor.UseVisualStyleBackColor = True
        '
        'PageFiles
        '
        Me.PageFiles.Location = New System.Drawing.Point(4, 26)
        Me.PageFiles.Name = "PageFiles"
        Me.PageFiles.Size = New System.Drawing.Size(357, 247)
        Me.PageFiles.TabIndex = 3
        Me.PageFiles.Text = "文檔"
        Me.PageFiles.UseVisualStyleBackColor = True
        '
        'PageLinks
        '
        Me.PageLinks.Location = New System.Drawing.Point(4, 26)
        Me.PageLinks.Name = "PageLinks"
        Me.PageLinks.Size = New System.Drawing.Size(357, 247)
        Me.PageLinks.TabIndex = 4
        Me.PageLinks.Text = "鏈接"
        Me.PageLinks.UseVisualStyleBackColor = True
        '
        'ViewTabs
        '
        Me.ViewTabs.Controls.Add(Me.PageWeb)
        Me.ViewTabs.Controls.Add(Me.PageText)
        Me.ViewTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewTabs.Location = New System.Drawing.Point(0, 0)
        Me.ViewTabs.Name = "ViewTabs"
        Me.ViewTabs.SelectedIndex = 0
        Me.ViewTabs.Size = New System.Drawing.Size(240, 430)
        Me.ViewTabs.TabIndex = 0
        '
        'PageWeb
        '
        Me.PageWeb.Location = New System.Drawing.Point(4, 26)
        Me.PageWeb.Name = "PageWeb"
        Me.PageWeb.Padding = New System.Windows.Forms.Padding(3)
        Me.PageWeb.Size = New System.Drawing.Size(232, 400)
        Me.PageWeb.TabIndex = 0
        Me.PageWeb.Text = "聯網"
        Me.PageWeb.UseVisualStyleBackColor = True
        '
        'PageText
        '
        Me.PageText.Location = New System.Drawing.Point(4, 22)
        Me.PageText.Name = "PageText"
        Me.PageText.Padding = New System.Windows.Forms.Padding(3)
        Me.PageText.Size = New System.Drawing.Size(232, 379)
        Me.PageText.TabIndex = 1
        Me.PageText.Text = "閱覽"
        Me.PageText.UseVisualStyleBackColor = True
        '
        'LibMenu
        '
        Me.LibMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.LibMenu.Location = New System.Drawing.Point(0, 0)
        Me.LibMenu.Name = "LibMenu"
        Me.LibMenu.Size = New System.Drawing.Size(799, 25)
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
        'LibStatus
        '
        Me.LibStatus.Location = New System.Drawing.Point(0, 430)
        Me.LibStatus.Name = "LibStatus"
        Me.LibStatus.Size = New System.Drawing.Size(799, 22)
        Me.LibStatus.TabIndex = 3
        Me.LibStatus.Text = "StatusStrip1"
        '
        'PageImages
        '
        Me.PageImages.Location = New System.Drawing.Point(4, 26)
        Me.PageImages.Name = "PageImages"
        Me.PageImages.Padding = New System.Windows.Forms.Padding(3)
        Me.PageImages.Size = New System.Drawing.Size(357, 247)
        Me.PageImages.TabIndex = 0
        Me.PageImages.Text = "書籍"
        Me.PageImages.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(357, 247)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "圖像"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HDLibView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 452)
        Me.Controls.Add(Me.LibSpliter)
        Me.Controls.Add(Me.LibStatus)
        Me.Controls.Add(Me.LibMenu)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.LibMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HDLibView"
        Me.Text = "HDLibView"
        Me.LibSpliter.Panel1.ResumeLayout(False)
        Me.LibSpliter.Panel2.ResumeLayout(False)
        CType(Me.LibSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibSpliter.ResumeLayout(False)
        Me.InnerSpliter.Panel1.ResumeLayout(False)
        Me.InnerSpliter.Panel1.PerformLayout()
        Me.InnerSpliter.Panel2.ResumeLayout(False)
        CType(Me.InnerSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InnerSpliter.ResumeLayout(False)
        Me.LibSearchTools.ResumeLayout(False)
        Me.LibSearchTools.PerformLayout()
        Me.DetailSpliter.Panel1.ResumeLayout(False)
        Me.DetailSpliter.Panel2.ResumeLayout(False)
        CType(Me.DetailSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailSpliter.ResumeLayout(False)
        CType(Me.HeaderSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSpliter.ResumeLayout(False)
        Me.DetailTabs.ResumeLayout(False)
        Me.ViewTabs.ResumeLayout(False)
        Me.LibMenu.ResumeLayout(False)
        Me.LibMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LibSpliter As SplitContainer
    Friend WithEvents InnerSpliter As SplitContainer
    Friend WithEvents DetailSpliter As SplitContainer
    Friend WithEvents HeaderSpliter As SplitContainer
    Friend WithEvents DetailTabs As TabControl
    Friend WithEvents PageIntro As TabPage
    Friend WithEvents PageAuthor As TabPage
    Friend WithEvents PageFiles As TabPage
    Friend WithEvents PageLinks As TabPage
    Friend WithEvents ViewTabs As TabControl
    Friend WithEvents PageWeb As TabPage
    Friend WithEvents PageText As TabPage
    Friend WithEvents LibMenu As MenuStrip
    Friend WithEvents LibStatus As StatusStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibRootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibSearchTools As ToolStrip
    Friend WithEvents LibSearchTextBox As ToolStripTextBox
    Friend WithEvents LibSearchGoButton As ToolStripButton
    Friend WithEvents LibSearchAdvanceButton As ToolStripButton
    Friend WithEvents LibView As KzDirectoryTreeView
    Friend WithEvents PageImages As TabPage
    Friend WithEvents TabPage1 As TabPage
End Class
