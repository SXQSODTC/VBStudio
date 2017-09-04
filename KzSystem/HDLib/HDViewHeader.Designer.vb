<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HDViewHeader
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
        Me.HDViewSpliter = New System.Windows.Forms.SplitContainer()
        Me.CoverBox = New System.Windows.Forms.PictureBox()
        Me.ViewBookInfoPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.R3 = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.R2 = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.R4 = New System.Windows.Forms.Label()
        Me.PilotLabel = New System.Windows.Forms.Label()
        CType(Me.HDViewSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HDViewSpliter.Panel1.SuspendLayout()
        Me.HDViewSpliter.Panel2.SuspendLayout()
        Me.HDViewSpliter.SuspendLayout()
        CType(Me.CoverBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewBookInfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HDViewSpliter
        '
        Me.HDViewSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HDViewSpliter.Location = New System.Drawing.Point(0, 0)
        Me.HDViewSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HDViewSpliter.Name = "HDViewSpliter"
        '
        'HDViewSpliter.Panel1
        '
        Me.HDViewSpliter.Panel1.Controls.Add(Me.CoverBox)
        '
        'HDViewSpliter.Panel2
        '
        Me.HDViewSpliter.Panel2.Controls.Add(Me.ViewBookInfoPanel)
        Me.HDViewSpliter.Size = New System.Drawing.Size(376, 183)
        Me.HDViewSpliter.SplitterDistance = 125
        Me.HDViewSpliter.SplitterWidth = 5
        Me.HDViewSpliter.TabIndex = 0
        '
        'CoverBox
        '
        Me.CoverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CoverBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoverBox.Location = New System.Drawing.Point(0, 0)
        Me.CoverBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CoverBox.Name = "CoverBox"
        Me.CoverBox.Size = New System.Drawing.Size(125, 183)
        Me.CoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CoverBox.TabIndex = 0
        Me.CoverBox.TabStop = False
        '
        'ViewBookInfoPanel
        '
        Me.ViewBookInfoPanel.ColumnCount = 3
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.ViewBookInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ViewBookInfoPanel.Controls.Add(Me.PilotLabel, 1, 3)
        Me.ViewBookInfoPanel.Controls.Add(Me.R4, 0, 3)
        Me.ViewBookInfoPanel.Controls.Add(Me.AuthorLabel, 1, 2)
        Me.ViewBookInfoPanel.Controls.Add(Me.R3, 0, 2)
        Me.ViewBookInfoPanel.Controls.Add(Me.TitleLabel, 1, 1)
        Me.ViewBookInfoPanel.Controls.Add(Me.R2, 0, 1)
        Me.ViewBookInfoPanel.Controls.Add(Me.R1, 0, 0)
        Me.ViewBookInfoPanel.Controls.Add(Me.IDLabel, 1, 0)
        Me.ViewBookInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewBookInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.ViewBookInfoPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ViewBookInfoPanel.Name = "ViewBookInfoPanel"
        Me.ViewBookInfoPanel.RowCount = 4
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.ViewBookInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ViewBookInfoPanel.Size = New System.Drawing.Size(246, 183)
        Me.ViewBookInfoPanel.TabIndex = 0
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoEllipsis = True
        Me.AuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(43, 70)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(190, 35)
        Me.AuthorLabel.TabIndex = 5
        Me.AuthorLabel.Text = "作者"
        Me.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.R3.Location = New System.Drawing.Point(3, 70)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(34, 35)
        Me.R3.TabIndex = 4
        Me.R3.Text = "作者"
        Me.R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoEllipsis = True
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(43, 25)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(190, 45)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "書籍標題"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.R2.Location = New System.Drawing.Point(3, 25)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(34, 45)
        Me.R2.TabIndex = 2
        Me.R2.Text = "書名"
        Me.R2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.R1.Location = New System.Drawing.Point(3, 0)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(34, 25)
        Me.R1.TabIndex = 0
        Me.R1.Text = "編號"
        Me.R1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IDLabel
        '
        Me.IDLabel.AutoEllipsis = True
        Me.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDLabel.Location = New System.Drawing.Point(43, 0)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(190, 25)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID"
        Me.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.R4.Location = New System.Drawing.Point(3, 105)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(34, 78)
        Me.R4.TabIndex = 6
        Me.R4.Text = "簡介"
        Me.R4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PilotLabel
        '
        Me.PilotLabel.AutoEllipsis = True
        Me.PilotLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PilotLabel.Location = New System.Drawing.Point(43, 105)
        Me.PilotLabel.Name = "PilotLabel"
        Me.PilotLabel.Size = New System.Drawing.Size(190, 78)
        Me.PilotLabel.TabIndex = 7
        Me.PilotLabel.Text = "Pilot"
        '
        'HDViewHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HDViewSpliter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HDViewHeader"
        Me.Size = New System.Drawing.Size(376, 183)
        Me.HDViewSpliter.Panel1.ResumeLayout(False)
        Me.HDViewSpliter.Panel2.ResumeLayout(False)
        CType(Me.HDViewSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HDViewSpliter.ResumeLayout(False)
        CType(Me.CoverBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewBookInfoPanel.ResumeLayout(False)
        Me.ViewBookInfoPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HDViewSpliter As SplitContainer
    Friend WithEvents CoverBox As PictureBox
    Friend WithEvents ViewBookInfoPanel As TableLayoutPanel
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents R3 As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents R2 As Label
    Friend WithEvents R1 As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents PilotLabel As Label
    Friend WithEvents R4 As Label
End Class
