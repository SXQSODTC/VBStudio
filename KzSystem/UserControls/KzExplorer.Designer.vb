<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzExplorer
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
        Me.ExplorerTools = New System.Windows.Forms.ToolStrip()
        Me.ExplorerStatus = New System.Windows.Forms.StatusStrip()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.DirViewer = New KzSystem.KzDirectoryTreeView()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExplorerTools
        '
        Me.ExplorerTools.Location = New System.Drawing.Point(0, 0)
        Me.ExplorerTools.Name = "ExplorerTools"
        Me.ExplorerTools.Size = New System.Drawing.Size(510, 25)
        Me.ExplorerTools.TabIndex = 0
        Me.ExplorerTools.Text = "ToolStrip1"
        '
        'ExplorerStatus
        '
        Me.ExplorerStatus.Location = New System.Drawing.Point(0, 448)
        Me.ExplorerStatus.Name = "ExplorerStatus"
        Me.ExplorerStatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.ExplorerStatus.Size = New System.Drawing.Size(510, 22)
        Me.ExplorerStatus.TabIndex = 1
        Me.ExplorerStatus.Text = "StatusStrip1"
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 25)
        Me.RootSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.DirViewer)
        Me.RootSpliter.Size = New System.Drawing.Size(510, 423)
        Me.RootSpliter.SplitterDistance = 170
        Me.RootSpliter.SplitterWidth = 5
        Me.RootSpliter.TabIndex = 2
        '
        'DirViewer
        '
        Me.DirViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirViewer.Location = New System.Drawing.Point(0, 0)
        Me.DirViewer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DirViewer.Name = "DirViewer"
        Me.DirViewer.ShowAllDirectories = False
        Me.DirViewer.Size = New System.Drawing.Size(170, 423)
        Me.DirViewer.StartDirectory = "C:\"
        Me.DirViewer.TabIndex = 0
        '
        'KzExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.ExplorerStatus)
        Me.Controls.Add(Me.ExplorerTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzExplorer"
        Me.Size = New System.Drawing.Size(510, 470)
        Me.RootSpliter.Panel1.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExplorerTools As ToolStrip
    Friend WithEvents ExplorerStatus As StatusStrip
    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents DirViewer As KzDirectoryTreeView
End Class
