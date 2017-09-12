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
        Me.WebStatus = New System.Windows.Forms.StatusStrip()
        Me.NowLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UrlLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HDBrowser = New System.Windows.Forms.WebBrowser()
        Me.WebTools.SuspendLayout()
        Me.WebStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebTools
        '
        Me.WebTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HDHistoryItem, Me.BackButton, Me.ForwardButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.HtmlTitleLabel, Me.ToolStripSeparator2, Me.SourceButton, Me.CloseWebButton})
        Me.WebTools.Location = New System.Drawing.Point(0, 0)
        Me.WebTools.Name = "WebTools"
        Me.WebTools.Size = New System.Drawing.Size(317, 25)
        Me.WebTools.TabIndex = 1
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
        'WebStatus
        '
        Me.WebStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NowLabel, Me.UrlLabel})
        Me.WebStatus.Location = New System.Drawing.Point(0, 124)
        Me.WebStatus.Name = "WebStatus"
        Me.WebStatus.Size = New System.Drawing.Size(317, 26)
        Me.WebStatus.TabIndex = 2
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
        'HDBrowser
        '
        Me.HDBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HDBrowser.Location = New System.Drawing.Point(0, 25)
        Me.HDBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HDBrowser.Name = "HDBrowser"
        Me.HDBrowser.ScriptErrorsSuppressed = True
        Me.HDBrowser.Size = New System.Drawing.Size(317, 99)
        Me.HDBrowser.TabIndex = 3
        Me.HDBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'KzOnePageWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HDBrowser)
        Me.Controls.Add(Me.WebStatus)
        Me.Controls.Add(Me.WebTools)
        Me.Name = "KzOnePageWeb"
        Me.Size = New System.Drawing.Size(317, 150)
        Me.WebTools.ResumeLayout(False)
        Me.WebTools.PerformLayout()
        Me.WebStatus.ResumeLayout(False)
        Me.WebStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebTools As ToolStrip
    Friend WithEvents HDHistoryItem As ToolStripSplitButton
    Friend WithEvents BackButton As ToolStripButton
    Friend WithEvents ForwardButton As ToolStripButton
    Friend WithEvents RefreshButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HtmlTitleLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SourceButton As ToolStripButton
    Friend WithEvents CloseWebButton As ToolStripButton
    Friend WithEvents WebStatus As StatusStrip
    Friend WithEvents NowLabel As ToolStripStatusLabel
    Friend WithEvents UrlLabel As ToolStripStatusLabel
    Friend WithEvents HDBrowser As WebBrowser
End Class
