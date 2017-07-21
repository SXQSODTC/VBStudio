<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KzColorListView
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"T1", "Test", "name"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"T2", "test2", "name2"}, -1)
        Me.RootMenu = New System.Windows.Forms.ToolStrip()
        Me.PropertiesList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootMenu
        '
        Me.RootMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RootMenu.Location = New System.Drawing.Point(0, 0)
        Me.RootMenu.Name = "RootMenu"
        Me.RootMenu.Size = New System.Drawing.Size(435, 25)
        Me.RootMenu.TabIndex = 0
        Me.RootMenu.Text = "ToolStrip1"
        '
        'PropertiesList
        '
        Me.PropertiesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.PropertiesList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.PropertiesList.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesList.Name = "PropertiesList"
        Me.PropertiesList.Size = New System.Drawing.Size(198, 286)
        Me.PropertiesList.TabIndex = 1
        Me.PropertiesList.UseCompatibleStateImageBehavior = False
        Me.PropertiesList.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 119
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 94
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 25)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.PropertiesList)
        Me.RootSpliter.Size = New System.Drawing.Size(435, 286)
        Me.RootSpliter.SplitterDistance = 198
        Me.RootSpliter.TabIndex = 2
        '
        'KzColorListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootMenu)
        Me.Name = "KzColorListView"
        Me.Size = New System.Drawing.Size(435, 311)
        Me.RootSpliter.Panel1.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootMenu As ToolStrip
    Friend WithEvents PropertiesList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents RootSpliter As SplitContainer
End Class
