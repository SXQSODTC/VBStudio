<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzTextSourceView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzTextSourceView))
        Me.DataTools = New System.Windows.Forms.ToolStrip()
        Me.DataStatus = New System.Windows.Forms.StatusStrip()
        Me.BNTools = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BNSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BNCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BNSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BNDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BNMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BNMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BNMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BNMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.TableViewer = New System.Windows.Forms.DataGridView()
        CType(Me.BNTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BNTools.SuspendLayout()
        CType(Me.TableViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTools
        '
        Me.DataTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DataTools.Location = New System.Drawing.Point(0, 0)
        Me.DataTools.Name = "DataTools"
        Me.DataTools.Size = New System.Drawing.Size(411, 25)
        Me.DataTools.TabIndex = 0
        Me.DataTools.Text = "ToolStrip1"
        '
        'DataStatus
        '
        Me.DataStatus.Location = New System.Drawing.Point(0, 353)
        Me.DataStatus.Name = "DataStatus"
        Me.DataStatus.Size = New System.Drawing.Size(411, 22)
        Me.DataStatus.TabIndex = 1
        Me.DataStatus.Text = "StatusStrip1"
        '
        'BNTools
        '
        Me.BNTools.AddNewItem = Me.BNAddNewItem
        Me.BNTools.CountItem = Me.BNCountItem
        Me.BNTools.DeleteItem = Me.BNDeleteItem
        Me.BNTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BNTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BNMoveFirstItem, Me.BNMovePreviousItem, Me.BNSeparator0, Me.BNPositionItem, Me.BNCountItem, Me.BNSeparator1, Me.BNMoveNextItem, Me.BNMoveLastItem, Me.BNSeparator2, Me.BNAddNewItem, Me.BNDeleteItem})
        Me.BNTools.Location = New System.Drawing.Point(0, 25)
        Me.BNTools.MoveFirstItem = Me.BNMoveFirstItem
        Me.BNTools.MoveLastItem = Me.BNMoveLastItem
        Me.BNTools.MoveNextItem = Me.BNMoveNextItem
        Me.BNTools.MovePreviousItem = Me.BNMovePreviousItem
        Me.BNTools.Name = "BNTools"
        Me.BNTools.PositionItem = Me.BNPositionItem
        Me.BNTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BNTools.Size = New System.Drawing.Size(411, 25)
        Me.BNTools.TabIndex = 2
        Me.BNTools.Text = "BindingNavigator1"
        '
        'BNSeparator0
        '
        Me.BNSeparator0.Name = "BindingNavigatorSeparator"
        Me.BNSeparator0.Size = New System.Drawing.Size(6, 25)
        '
        'BNPositionItem
        '
        Me.BNPositionItem.AccessibleName = "位置"
        Me.BNPositionItem.AutoSize = False
        Me.BNPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BNPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BNPositionItem.Text = "0"
        Me.BNPositionItem.ToolTipText = "当前位置"
        '
        'BNCountItem
        '
        Me.BNCountItem.Name = "BindingNavigatorCountItem"
        Me.BNCountItem.Size = New System.Drawing.Size(32, 22)
        Me.BNCountItem.Text = "/ {0}"
        Me.BNCountItem.ToolTipText = "总项数"
        '
        'BNSeparator1
        '
        Me.BNSeparator1.Name = "BindingNavigatorSeparator"
        Me.BNSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BNSeparator2
        '
        Me.BNSeparator2.Name = "BindingNavigatorSeparator"
        Me.BNSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BNAddNewItem
        '
        Me.BNAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNAddNewItem.Image = CType(resources.GetObject("BNAddNewItem.Image"), System.Drawing.Image)
        Me.BNAddNewItem.Name = "BNAddNewItem"
        Me.BNAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BNAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BNAddNewItem.Text = "新添"
        '
        'BNDeleteItem
        '
        Me.BNDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNDeleteItem.Image = CType(resources.GetObject("BNDeleteItem.Image"), System.Drawing.Image)
        Me.BNDeleteItem.Name = "BNDeleteItem"
        Me.BNDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BNDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BNDeleteItem.Text = "删除"
        '
        'BNMoveFirstItem
        '
        Me.BNMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNMoveFirstItem.Image = CType(resources.GetObject("BNMoveFirstItem.Image"), System.Drawing.Image)
        Me.BNMoveFirstItem.Name = "BNMoveFirstItem"
        Me.BNMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BNMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BNMoveFirstItem.Text = "移到第一条记录"
        '
        'BNMovePreviousItem
        '
        Me.BNMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNMovePreviousItem.Image = CType(resources.GetObject("BNMovePreviousItem.Image"), System.Drawing.Image)
        Me.BNMovePreviousItem.Name = "BNMovePreviousItem"
        Me.BNMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BNMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BNMovePreviousItem.Text = "移到上一条记录"
        '
        'BNMoveNextItem
        '
        Me.BNMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNMoveNextItem.Image = CType(resources.GetObject("BNMoveNextItem.Image"), System.Drawing.Image)
        Me.BNMoveNextItem.Name = "BNMoveNextItem"
        Me.BNMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BNMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BNMoveNextItem.Text = "移到下一条记录"
        '
        'BNMoveLastItem
        '
        Me.BNMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNMoveLastItem.Image = CType(resources.GetObject("BNMoveLastItem.Image"), System.Drawing.Image)
        Me.BNMoveLastItem.Name = "BNMoveLastItem"
        Me.BNMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BNMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BNMoveLastItem.Text = "移到最后一条记录"
        '
        'TableViewer
        '
        Me.TableViewer.AllowUserToOrderColumns = True
        Me.TableViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableViewer.Location = New System.Drawing.Point(0, 50)
        Me.TableViewer.Name = "TableViewer"
        Me.TableViewer.RowTemplate.Height = 23
        Me.TableViewer.Size = New System.Drawing.Size(411, 303)
        Me.TableViewer.TabIndex = 3
        '
        'KzTextSourceView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableViewer)
        Me.Controls.Add(Me.BNTools)
        Me.Controls.Add(Me.DataStatus)
        Me.Controls.Add(Me.DataTools)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzTextSourceView"
        Me.Size = New System.Drawing.Size(411, 375)
        CType(Me.BNTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BNTools.ResumeLayout(False)
        Me.BNTools.PerformLayout()
        CType(Me.TableViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataTools As ToolStrip
    Friend WithEvents DataStatus As StatusStrip
    Friend WithEvents BNTools As BindingNavigator
    Friend WithEvents BNAddNewItem As ToolStripButton
    Friend WithEvents BNCountItem As ToolStripLabel
    Friend WithEvents BNDeleteItem As ToolStripButton
    Friend WithEvents BNMoveFirstItem As ToolStripButton
    Friend WithEvents BNMovePreviousItem As ToolStripButton
    Friend WithEvents BNSeparator0 As ToolStripSeparator
    Friend WithEvents BNPositionItem As ToolStripTextBox
    Friend WithEvents BNSeparator1 As ToolStripSeparator
    Friend WithEvents BNMoveNextItem As ToolStripButton
    Friend WithEvents BNMoveLastItem As ToolStripButton
    Friend WithEvents BNSeparator2 As ToolStripSeparator
    Friend WithEvents TableViewer As DataGridView
End Class
