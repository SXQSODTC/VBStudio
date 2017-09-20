<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzSingleEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzSingleEditor))
        Me.FileTools = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilePathTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EncodingComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton()
        Me.TStatus = New System.Windows.Forms.StatusStrip()
        Me.CmdButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SelectionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LinesLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PositionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PercentLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContentsBox = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FunctionTools = New System.Windows.Forms.ToolStrip()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.RedoButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyButton = New System.Windows.Forms.ToolStripButton()
        Me.CutButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearAllButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllButton = New System.Windows.Forms.ToolStripButton()
        Me.BeginSelectButton = New System.Windows.Forms.ToolStripButton()
        Me.WrapButton = New System.Windows.Forms.ToolStripButton()
        Me.FontButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindReplaceButton = New System.Windows.Forms.ToolStripButton()
        Me.InsertButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolsButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FileTools.SuspendLayout()
        Me.TStatus.SuspendLayout()
        Me.FunctionTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileTools
        '
        Me.FileTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FileTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.OpenButton, Me.ToolStripSeparator1, Me.FilePathTextBox, Me.ToolStripSeparator4, Me.SaveButton, Me.SaveAsButton, Me.ToolStripSeparator6, Me.EncodingComboBox, Me.RefreshButton})
        Me.FileTools.Location = New System.Drawing.Point(0, 0)
        Me.FileTools.Name = "FileTools"
        Me.FileTools.Size = New System.Drawing.Size(409, 25)
        Me.FileTools.TabIndex = 0
        Me.FileTools.Text = "ToolStrip1"
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = CType(resources.GetObject("NewButton.Image"), System.Drawing.Image)
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(23, 22)
        Me.NewButton.Text = "New"
        Me.NewButton.ToolTipText = "Create new document"
        '
        'OpenButton
        '
        Me.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenButton.Image = CType(resources.GetObject("OpenButton.Image"), System.Drawing.Image)
        Me.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenButton.Text = "Open"
        Me.OpenButton.ToolTipText = "Open file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'FilePathTextBox
        '
        Me.FilePathTextBox.AutoSize = False
        Me.FilePathTextBox.Name = "FilePathTextBox"
        Me.FilePathTextBox.Size = New System.Drawing.Size(99, 25)
        Me.FilePathTextBox.Text = "(New)"
        Me.FilePathTextBox.ToolTipText = "File path"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveButton.Text = "Save"
        Me.SaveButton.ToolTipText = "Save file"
        '
        'SaveAsButton
        '
        Me.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAsButton.Image = CType(resources.GetObject("SaveAsButton.Image"), System.Drawing.Image)
        Me.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveAsButton.Text = "SaveAs"
        Me.SaveAsButton.ToolTipText = "Save file as other name"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'EncodingComboBox
        '
        Me.EncodingComboBox.AutoSize = False
        Me.EncodingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EncodingComboBox.Items.AddRange(New Object() {"Default", "ASCII", "Unicode", "UTF-8", "UTF-32", "UTF-7", "BEUnicode"})
        Me.EncodingComboBox.Name = "EncodingComboBox"
        Me.EncodingComboBox.Size = New System.Drawing.Size(64, 25)
        Me.EncodingComboBox.ToolTipText = "Select encoding"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.ToolTipText = "Refresh contents if file exists"
        '
        'TStatus
        '
        Me.TStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdButton, Me.CountLabel, Me.SelectionLabel, Me.LinesLabel, Me.PositionLabel, Me.PercentLabel})
        Me.TStatus.Location = New System.Drawing.Point(0, 214)
        Me.TStatus.Name = "TStatus"
        Me.TStatus.Size = New System.Drawing.Size(409, 26)
        Me.TStatus.TabIndex = 1
        Me.TStatus.Text = "StatusStrip1"
        '
        'CmdButton
        '
        Me.CmdButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdButton.Name = "CmdButton"
        Me.CmdButton.ShowDropDownArrow = False
        Me.CmdButton.Size = New System.Drawing.Size(4, 24)
        Me.CmdButton.Text = "*"
        '
        'CountLabel
        '
        Me.CountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(46, 21)
        Me.CountLabel.Text = "Count"
        '
        'SelectionLabel
        '
        Me.SelectionLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.SelectionLabel.Name = "SelectionLabel"
        Me.SelectionLabel.Size = New System.Drawing.Size(64, 21)
        Me.SelectionLabel.Text = "Selection"
        '
        'LinesLabel
        '
        Me.LinesLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LinesLabel.Name = "LinesLabel"
        Me.LinesLabel.Size = New System.Drawing.Size(41, 21)
        Me.LinesLabel.Text = "Lines"
        '
        'PositionLabel
        '
        Me.PositionLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(33, 21)
        Me.PositionLabel.Text = "Pos"
        '
        'PercentLabel
        '
        Me.PercentLabel.Name = "PercentLabel"
        Me.PercentLabel.Size = New System.Drawing.Size(27, 21)
        Me.PercentLabel.Text = "Per"
        '
        'ContentsBox
        '
        Me.ContentsBox.AllowDrop = True
        Me.ContentsBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContentsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentsBox.HideSelection = False
        Me.ContentsBox.Location = New System.Drawing.Point(0, 50)
        Me.ContentsBox.Multiline = True
        Me.ContentsBox.Name = "ContentsBox"
        Me.ContentsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentsBox.Size = New System.Drawing.Size(409, 164)
        Me.ContentsBox.TabIndex = 2
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FunctionTools
        '
        Me.FunctionTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FunctionTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoButton, Me.RedoButton, Me.ToolStripSeparator7, Me.CopyButton, Me.CutButton, Me.PasteButton, Me.ToolStripSeparator8, Me.DeleteButton, Me.ClearAllButton, Me.ToolStripSeparator5, Me.SelectAllButton, Me.BeginSelectButton, Me.ToolStripSeparator2, Me.WrapButton, Me.FontButton, Me.ToolStripSeparator3, Me.FindReplaceButton, Me.InsertButton, Me.ToolsButton})
        Me.FunctionTools.Location = New System.Drawing.Point(0, 25)
        Me.FunctionTools.Name = "FunctionTools"
        Me.FunctionTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.FunctionTools.Size = New System.Drawing.Size(409, 25)
        Me.FunctionTools.TabIndex = 3
        Me.FunctionTools.Text = "ToolStrip1"
        '
        'UndoButton
        '
        Me.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoButton.Image = CType(resources.GetObject("UndoButton.Image"), System.Drawing.Image)
        Me.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoButton.Name = "UndoButton"
        Me.UndoButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoButton.Text = "Undo"
        '
        'RedoButton
        '
        Me.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoButton.Image = CType(resources.GetObject("RedoButton.Image"), System.Drawing.Image)
        Me.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoButton.Name = "RedoButton"
        Me.RedoButton.Size = New System.Drawing.Size(23, 22)
        Me.RedoButton.Text = "Redo"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'CopyButton
        '
        Me.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyButton.Image = CType(resources.GetObject("CopyButton.Image"), System.Drawing.Image)
        Me.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyButton.Text = "Copy"
        '
        'CutButton
        '
        Me.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutButton.Image = CType(resources.GetObject("CutButton.Image"), System.Drawing.Image)
        Me.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutButton.Name = "CutButton"
        Me.CutButton.Size = New System.Drawing.Size(23, 22)
        Me.CutButton.Text = "Cut"
        '
        'PasteButton
        '
        Me.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteButton.Image = CType(resources.GetObject("PasteButton.Image"), System.Drawing.Image)
        Me.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteButton.Text = "Paste"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteButton
        '
        Me.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteButton.Text = "Delete"
        '
        'ClearAllButton
        '
        Me.ClearAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearAllButton.Image = CType(resources.GetObject("ClearAllButton.Image"), System.Drawing.Image)
        Me.ClearAllButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(23, 22)
        Me.ClearAllButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'SelectAllButton
        '
        Me.SelectAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectAllButton.Image = CType(resources.GetObject("SelectAllButton.Image"), System.Drawing.Image)
        Me.SelectAllButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(23, 22)
        Me.SelectAllButton.Text = "SelectAll"
        Me.SelectAllButton.ToolTipText = "Select all"
        '
        'BeginSelectButton
        '
        Me.BeginSelectButton.CheckOnClick = True
        Me.BeginSelectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BeginSelectButton.Image = CType(resources.GetObject("BeginSelectButton.Image"), System.Drawing.Image)
        Me.BeginSelectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BeginSelectButton.Name = "BeginSelectButton"
        Me.BeginSelectButton.Size = New System.Drawing.Size(23, 22)
        Me.BeginSelectButton.Text = "BeginSelect"
        Me.BeginSelectButton.ToolTipText = "Begin a range select (click for stop)"
        '
        'WrapButton
        '
        Me.WrapButton.CheckOnClick = True
        Me.WrapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WrapButton.Image = CType(resources.GetObject("WrapButton.Image"), System.Drawing.Image)
        Me.WrapButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WrapButton.Name = "WrapButton"
        Me.WrapButton.Size = New System.Drawing.Size(23, 22)
        Me.WrapButton.Text = "Wrap"
        Me.WrapButton.ToolTipText = "Wrap on/off"
        '
        'FontButton
        '
        Me.FontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontButton.Image = CType(resources.GetObject("FontButton.Image"), System.Drawing.Image)
        Me.FontButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontButton.Name = "FontButton"
        Me.FontButton.ShowDropDownArrow = False
        Me.FontButton.Size = New System.Drawing.Size(20, 22)
        Me.FontButton.Text = "Font"
        Me.FontButton.ToolTipText = "Font settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'FindReplaceButton
        '
        Me.FindReplaceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindReplaceButton.Image = CType(resources.GetObject("FindReplaceButton.Image"), System.Drawing.Image)
        Me.FindReplaceButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindReplaceButton.Name = "FindReplaceButton"
        Me.FindReplaceButton.Size = New System.Drawing.Size(23, 22)
        Me.FindReplaceButton.Text = "FindReplace"
        Me.FindReplaceButton.ToolTipText = "Open Find and Replace window"
        '
        'InsertButton
        '
        Me.InsertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InsertButton.Image = CType(resources.GetObject("InsertButton.Image"), System.Drawing.Image)
        Me.InsertButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.ShowDropDownArrow = False
        Me.InsertButton.Size = New System.Drawing.Size(20, 22)
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.ToolTipText = "Insert special contents"
        '
        'ToolsButton
        '
        Me.ToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolsButton.Image = CType(resources.GetObject("ToolsButton.Image"), System.Drawing.Image)
        Me.ToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolsButton.Name = "ToolsButton"
        Me.ToolsButton.ShowDropDownArrow = False
        Me.ToolsButton.Size = New System.Drawing.Size(20, 22)
        Me.ToolsButton.Text = "Special"
        Me.ToolsButton.ToolTipText = "Special functions"
        '
        'KzSingleEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ContentsBox)
        Me.Controls.Add(Me.FunctionTools)
        Me.Controls.Add(Me.TStatus)
        Me.Controls.Add(Me.FileTools)
        Me.Name = "KzSingleEditor"
        Me.Size = New System.Drawing.Size(409, 240)
        Me.FileTools.ResumeLayout(False)
        Me.FileTools.PerformLayout()
        Me.TStatus.ResumeLayout(False)
        Me.TStatus.PerformLayout()
        Me.FunctionTools.ResumeLayout(False)
        Me.FunctionTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileTools As ToolStrip
    Friend WithEvents TStatus As StatusStrip
    Friend WithEvents ContentsBox As TextBox
    Friend WithEvents NewButton As ToolStripButton
    Friend WithEvents OpenButton As ToolStripButton
    Friend WithEvents SaveButton As ToolStripButton
    Friend WithEvents SaveAsButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CountLabel As ToolStripStatusLabel
    Friend WithEvents SelectionLabel As ToolStripStatusLabel
    Friend WithEvents LinesLabel As ToolStripStatusLabel
    Friend WithEvents PositionLabel As ToolStripStatusLabel
    Friend WithEvents PercentLabel As ToolStripStatusLabel
    Friend WithEvents FilePathTextBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents WrapButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SelectAllButton As ToolStripButton
    Friend WithEvents BeginSelectButton As ToolStripButton
    Friend WithEvents FunctionTools As ToolStrip
    Friend WithEvents CopyButton As ToolStripButton
    Friend WithEvents CutButton As ToolStripButton
    Friend WithEvents PasteButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FindReplaceButton As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents EncodingComboBox As ToolStripComboBox
    Friend WithEvents FontButton As ToolStripDropDownButton
    Friend WithEvents InsertButton As ToolStripDropDownButton
    Friend WithEvents ToolsButton As ToolStripDropDownButton
    Friend WithEvents RefreshButton As ToolStripButton
    Friend WithEvents UndoButton As ToolStripButton
    Friend WithEvents RedoButton As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ClearAllButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents DeleteButton As ToolStripButton
    Friend WithEvents CmdButton As ToolStripDropDownButton
End Class
