<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDLibSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDLibSearch))
        Me.SearchTools = New System.Windows.Forms.ToolStrip()
        Me.AllBooksButton = New System.Windows.Forms.ToolStripButton()
        Me.AuthorBooksButton = New System.Windows.Forms.ToolStripButton()
        Me.CategoryBooksButton = New System.Windows.Forms.ToolStripButton()
        Me.SpecialBooksButton = New System.Windows.Forms.ToolStripButton()
        Me.SeriesBooksButton = New System.Windows.Forms.ToolStripButton()
        Me.SearchStatus = New System.Windows.Forms.StatusStrip()
        Me.SearchSpliter = New System.Windows.Forms.SplitContainer()
        Me.KeyListView = New System.Windows.Forms.ListView()
        Me.ColKeys = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KeyLookupBox = New System.Windows.Forms.TextBox()
        Me.BookListView = New System.Windows.Forms.ListView()
        Me.ColBook = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmdPanel = New System.Windows.Forms.Panel()
        Me.CancelCmd = New System.Windows.Forms.Button()
        Me.OKCmd = New System.Windows.Forms.Button()
        Me.BookLookupBox = New System.Windows.Forms.TextBox()
        Me.SearchTools.SuspendLayout()
        CType(Me.SearchSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchSpliter.Panel1.SuspendLayout()
        Me.SearchSpliter.Panel2.SuspendLayout()
        Me.SearchSpliter.SuspendLayout()
        Me.CmdPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTools
        '
        Me.SearchTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SearchTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllBooksButton, Me.AuthorBooksButton, Me.CategoryBooksButton, Me.SpecialBooksButton, Me.SeriesBooksButton})
        Me.SearchTools.Location = New System.Drawing.Point(0, 0)
        Me.SearchTools.Name = "SearchTools"
        Me.SearchTools.Size = New System.Drawing.Size(435, 25)
        Me.SearchTools.TabIndex = 0
        Me.SearchTools.Text = "ToolStrip1"
        '
        'AllBooksButton
        '
        Me.AllBooksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AllBooksButton.Image = CType(resources.GetObject("AllBooksButton.Image"), System.Drawing.Image)
        Me.AllBooksButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AllBooksButton.Name = "AllBooksButton"
        Me.AllBooksButton.Size = New System.Drawing.Size(23, 22)
        Me.AllBooksButton.Text = "ToolStripButton1"
        '
        'AuthorBooksButton
        '
        Me.AuthorBooksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AuthorBooksButton.Image = CType(resources.GetObject("AuthorBooksButton.Image"), System.Drawing.Image)
        Me.AuthorBooksButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AuthorBooksButton.Name = "AuthorBooksButton"
        Me.AuthorBooksButton.Size = New System.Drawing.Size(23, 22)
        Me.AuthorBooksButton.Text = "ToolStripButton2"
        '
        'CategoryBooksButton
        '
        Me.CategoryBooksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoryBooksButton.Image = CType(resources.GetObject("CategoryBooksButton.Image"), System.Drawing.Image)
        Me.CategoryBooksButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CategoryBooksButton.Name = "CategoryBooksButton"
        Me.CategoryBooksButton.Size = New System.Drawing.Size(23, 22)
        Me.CategoryBooksButton.Text = "ToolStripButton3"
        '
        'SpecialBooksButton
        '
        Me.SpecialBooksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpecialBooksButton.Image = CType(resources.GetObject("SpecialBooksButton.Image"), System.Drawing.Image)
        Me.SpecialBooksButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpecialBooksButton.Name = "SpecialBooksButton"
        Me.SpecialBooksButton.Size = New System.Drawing.Size(23, 22)
        Me.SpecialBooksButton.Text = "ToolStripButton4"
        '
        'SeriesBooksButton
        '
        Me.SeriesBooksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SeriesBooksButton.Image = CType(resources.GetObject("SeriesBooksButton.Image"), System.Drawing.Image)
        Me.SeriesBooksButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeriesBooksButton.Name = "SeriesBooksButton"
        Me.SeriesBooksButton.Size = New System.Drawing.Size(23, 22)
        Me.SeriesBooksButton.Text = "ToolStripButton1"
        '
        'SearchStatus
        '
        Me.SearchStatus.Location = New System.Drawing.Point(0, 441)
        Me.SearchStatus.Name = "SearchStatus"
        Me.SearchStatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SearchStatus.Size = New System.Drawing.Size(435, 22)
        Me.SearchStatus.TabIndex = 1
        Me.SearchStatus.Text = "StatusStrip1"
        '
        'SearchSpliter
        '
        Me.SearchSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchSpliter.Location = New System.Drawing.Point(0, 25)
        Me.SearchSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchSpliter.Name = "SearchSpliter"
        '
        'SearchSpliter.Panel1
        '
        Me.SearchSpliter.Panel1.Controls.Add(Me.KeyListView)
        Me.SearchSpliter.Panel1.Controls.Add(Me.KeyLookupBox)
        '
        'SearchSpliter.Panel2
        '
        Me.SearchSpliter.Panel2.Controls.Add(Me.BookListView)
        Me.SearchSpliter.Panel2.Controls.Add(Me.CmdPanel)
        Me.SearchSpliter.Panel2.Controls.Add(Me.BookLookupBox)
        Me.SearchSpliter.Size = New System.Drawing.Size(435, 416)
        Me.SearchSpliter.SplitterDistance = 145
        Me.SearchSpliter.SplitterWidth = 5
        Me.SearchSpliter.TabIndex = 2
        '
        'KeyListView
        '
        Me.KeyListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColKeys})
        Me.KeyListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KeyListView.Location = New System.Drawing.Point(0, 23)
        Me.KeyListView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyListView.Name = "KeyListView"
        Me.KeyListView.Size = New System.Drawing.Size(145, 393)
        Me.KeyListView.TabIndex = 1
        Me.KeyListView.UseCompatibleStateImageBehavior = False
        Me.KeyListView.View = System.Windows.Forms.View.Details
        '
        'KeyLookupBox
        '
        Me.KeyLookupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.KeyLookupBox.Location = New System.Drawing.Point(0, 0)
        Me.KeyLookupBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeyLookupBox.Name = "KeyLookupBox"
        Me.KeyLookupBox.Size = New System.Drawing.Size(145, 23)
        Me.KeyLookupBox.TabIndex = 0
        '
        'BookListView
        '
        Me.BookListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColBook})
        Me.BookListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookListView.Location = New System.Drawing.Point(0, 23)
        Me.BookListView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BookListView.Name = "BookListView"
        Me.BookListView.Size = New System.Drawing.Size(285, 360)
        Me.BookListView.TabIndex = 2
        Me.BookListView.UseCompatibleStateImageBehavior = False
        Me.BookListView.View = System.Windows.Forms.View.Details
        '
        'CmdPanel
        '
        Me.CmdPanel.Controls.Add(Me.CancelCmd)
        Me.CmdPanel.Controls.Add(Me.OKCmd)
        Me.CmdPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CmdPanel.Location = New System.Drawing.Point(0, 383)
        Me.CmdPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmdPanel.Name = "CmdPanel"
        Me.CmdPanel.Size = New System.Drawing.Size(285, 33)
        Me.CmdPanel.TabIndex = 1
        '
        'CancelCmd
        '
        Me.CancelCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelCmd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelCmd.Location = New System.Drawing.Point(145, 4)
        Me.CancelCmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelCmd.Name = "CancelCmd"
        Me.CancelCmd.Size = New System.Drawing.Size(68, 27)
        Me.CancelCmd.TabIndex = 1
        Me.CancelCmd.Text = "Button2"
        Me.CancelCmd.UseVisualStyleBackColor = True
        '
        'OKCmd
        '
        Me.OKCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKCmd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKCmd.Location = New System.Drawing.Point(215, 4)
        Me.OKCmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OKCmd.Name = "OKCmd"
        Me.OKCmd.Size = New System.Drawing.Size(68, 27)
        Me.OKCmd.TabIndex = 0
        Me.OKCmd.Text = "Button1"
        Me.OKCmd.UseVisualStyleBackColor = True
        '
        'BookLookupBox
        '
        Me.BookLookupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.BookLookupBox.Location = New System.Drawing.Point(0, 0)
        Me.BookLookupBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BookLookupBox.Name = "BookLookupBox"
        Me.BookLookupBox.Size = New System.Drawing.Size(285, 23)
        Me.BookLookupBox.TabIndex = 0
        '
        'HDLibSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 463)
        Me.Controls.Add(Me.SearchSpliter)
        Me.Controls.Add(Me.SearchStatus)
        Me.Controls.Add(Me.SearchTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HDLibSearch"
        Me.Text = "HDLibSearch"
        Me.SearchTools.ResumeLayout(False)
        Me.SearchTools.PerformLayout()
        Me.SearchSpliter.Panel1.ResumeLayout(False)
        Me.SearchSpliter.Panel1.PerformLayout()
        Me.SearchSpliter.Panel2.ResumeLayout(False)
        Me.SearchSpliter.Panel2.PerformLayout()
        CType(Me.SearchSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchSpliter.ResumeLayout(False)
        Me.CmdPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTools As ToolStrip
    Friend WithEvents AllBooksButton As ToolStripButton
    Friend WithEvents AuthorBooksButton As ToolStripButton
    Friend WithEvents CategoryBooksButton As ToolStripButton
    Friend WithEvents SpecialBooksButton As ToolStripButton
    Friend WithEvents SeriesBooksButton As ToolStripButton
    Friend WithEvents SearchStatus As StatusStrip
    Friend WithEvents SearchSpliter As SplitContainer
    Friend WithEvents KeyListView As ListView
    Friend WithEvents ColKeys As ColumnHeader
    Friend WithEvents KeyLookupBox As TextBox
    Friend WithEvents BookListView As ListView
    Friend WithEvents ColBook As ColumnHeader
    Friend WithEvents CmdPanel As Panel
    Friend WithEvents CancelCmd As Button
    Friend WithEvents OKCmd As Button
    Friend WithEvents BookLookupBox As TextBox
End Class
