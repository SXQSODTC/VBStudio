<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzBorderTester
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
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.ConfigPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.B3DSideCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.B3DStyleCombo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BorderColorButton = New System.Windows.Forms.Button()
        Me.BorderColorBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Draw3DChecker = New System.Windows.Forms.CheckBox()
        Me.DrawChecker = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackColorBox = New System.Windows.Forms.TextBox()
        Me.BackColorButton = New System.Windows.Forms.Button()
        Me.BStyleCombo = New System.Windows.Forms.ComboBox()
        Me.DescTextBox = New System.Windows.Forms.TextBox()
        Me.ShowSpliter = New System.Windows.Forms.SplitContainer()
        Me.ShowBox = New System.Windows.Forms.PictureBox()
        Me.ColorViewer = New KzSystem.KzColorListView()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        Me.ConfigPanel.SuspendLayout()
        CType(Me.ShowSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShowSpliter.Panel1.SuspendLayout()
        Me.ShowSpliter.Panel2.SuspendLayout()
        Me.ShowSpliter.SuspendLayout()
        CType(Me.ShowBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RootSpliter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.ConfigPanel)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.ShowSpliter)
        Me.RootSpliter.Size = New System.Drawing.Size(962, 643)
        Me.RootSpliter.SplitterDistance = 269
        Me.RootSpliter.TabIndex = 0
        '
        'ConfigPanel
        '
        Me.ConfigPanel.ColumnCount = 3
        Me.ConfigPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.ConfigPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ConfigPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.ConfigPanel.Controls.Add(Me.B3DSideCombo, 1, 9)
        Me.ConfigPanel.Controls.Add(Me.Label5, 0, 9)
        Me.ConfigPanel.Controls.Add(Me.B3DStyleCombo, 1, 8)
        Me.ConfigPanel.Controls.Add(Me.Label4, 0, 8)
        Me.ConfigPanel.Controls.Add(Me.Label3, 0, 6)
        Me.ConfigPanel.Controls.Add(Me.BorderColorButton, 2, 5)
        Me.ConfigPanel.Controls.Add(Me.BorderColorBox, 1, 5)
        Me.ConfigPanel.Controls.Add(Me.Label2, 0, 5)
        Me.ConfigPanel.Controls.Add(Me.Draw3DChecker, 0, 2)
        Me.ConfigPanel.Controls.Add(Me.DrawChecker, 0, 1)
        Me.ConfigPanel.Controls.Add(Me.Label1, 0, 4)
        Me.ConfigPanel.Controls.Add(Me.BackColorBox, 1, 4)
        Me.ConfigPanel.Controls.Add(Me.BackColorButton, 2, 4)
        Me.ConfigPanel.Controls.Add(Me.BStyleCombo, 1, 6)
        Me.ConfigPanel.Controls.Add(Me.DescTextBox, 0, 11)
        Me.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConfigPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConfigPanel.Name = "ConfigPanel"
        Me.ConfigPanel.RowCount = 12
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ConfigPanel.Size = New System.Drawing.Size(269, 643)
        Me.ConfigPanel.TabIndex = 0
        '
        'B3DSideCombo
        '
        Me.B3DSideCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B3DSideCombo.FormattingEnabled = True
        Me.B3DSideCombo.Location = New System.Drawing.Point(106, 176)
        Me.B3DSideCombo.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.B3DSideCombo.Name = "B3DSideCombo"
        Me.B3DSideCombo.Size = New System.Drawing.Size(128, 22)
        Me.B3DSideCombo.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Border3DSide"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'B3DStyleCombo
        '
        Me.B3DStyleCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B3DStyleCombo.FormattingEnabled = True
        Me.B3DStyleCombo.Location = New System.Drawing.Point(106, 153)
        Me.B3DStyleCombo.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.B3DStyleCombo.Name = "B3DStyleCombo"
        Me.B3DStyleCombo.Size = New System.Drawing.Size(128, 22)
        Me.B3DStyleCombo.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Border3DStyle"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "BorderStyle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BorderColorButton
        '
        Me.BorderColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BorderColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorderColorButton.Location = New System.Drawing.Point(234, 96)
        Me.BorderColorButton.Margin = New System.Windows.Forms.Padding(0)
        Me.BorderColorButton.Name = "BorderColorButton"
        Me.BorderColorButton.Size = New System.Drawing.Size(35, 23)
        Me.BorderColorButton.TabIndex = 9
        Me.BorderColorButton.Text = "Button4"
        Me.BorderColorButton.UseVisualStyleBackColor = True
        '
        'BorderColorBox
        '
        Me.BorderColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorBox.Location = New System.Drawing.Point(106, 97)
        Me.BorderColorBox.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.BorderColorBox.Name = "BorderColorBox"
        Me.BorderColorBox.Size = New System.Drawing.Size(128, 22)
        Me.BorderColorBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BorderColor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Draw3DChecker
        '
        Me.Draw3DChecker.AutoSize = True
        Me.Draw3DChecker.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfigPanel.SetColumnSpan(Me.Draw3DChecker, 2)
        Me.Draw3DChecker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Draw3DChecker.Location = New System.Drawing.Point(3, 43)
        Me.Draw3DChecker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Draw3DChecker.Name = "Draw3DChecker"
        Me.Draw3DChecker.Size = New System.Drawing.Size(228, 18)
        Me.Draw3DChecker.TabIndex = 1
        Me.Draw3DChecker.Text = "DrawBorder3D"
        Me.Draw3DChecker.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Draw3DChecker.UseVisualStyleBackColor = True
        '
        'DrawChecker
        '
        Me.DrawChecker.AutoSize = True
        Me.DrawChecker.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfigPanel.SetColumnSpan(Me.DrawChecker, 2)
        Me.DrawChecker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DrawChecker.Location = New System.Drawing.Point(3, 21)
        Me.DrawChecker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DrawChecker.Name = "DrawChecker"
        Me.DrawChecker.Size = New System.Drawing.Size(228, 18)
        Me.DrawChecker.TabIndex = 0
        Me.DrawChecker.Text = "DrawBorder"
        Me.DrawChecker.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DrawChecker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BackColor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BackColorBox
        '
        Me.BackColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorBox.Location = New System.Drawing.Point(106, 74)
        Me.BackColorBox.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.BackColorBox.Name = "BackColorBox"
        Me.BackColorBox.Size = New System.Drawing.Size(128, 22)
        Me.BackColorBox.TabIndex = 3
        '
        'BackColorButton
        '
        Me.BackColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackColorButton.Location = New System.Drawing.Point(234, 73)
        Me.BackColorButton.Margin = New System.Windows.Forms.Padding(0)
        Me.BackColorButton.Name = "BackColorButton"
        Me.BackColorButton.Size = New System.Drawing.Size(35, 23)
        Me.BackColorButton.TabIndex = 4
        Me.BackColorButton.Text = "Button1"
        Me.BackColorButton.UseVisualStyleBackColor = True
        '
        'BStyleCombo
        '
        Me.BStyleCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BStyleCombo.FormattingEnabled = True
        Me.BStyleCombo.Location = New System.Drawing.Point(106, 120)
        Me.BStyleCombo.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.BStyleCombo.Name = "BStyleCombo"
        Me.BStyleCombo.Size = New System.Drawing.Size(128, 22)
        Me.BStyleCombo.TabIndex = 11
        '
        'DescTextBox
        '
        Me.ConfigPanel.SetColumnSpan(Me.DescTextBox, 3)
        Me.DescTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescTextBox.Location = New System.Drawing.Point(3, 221)
        Me.DescTextBox.Multiline = True
        Me.DescTextBox.Name = "DescTextBox"
        Me.DescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DescTextBox.Size = New System.Drawing.Size(263, 419)
        Me.DescTextBox.TabIndex = 19
        '
        'ShowSpliter
        '
        Me.ShowSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowSpliter.Location = New System.Drawing.Point(0, 0)
        Me.ShowSpliter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShowSpliter.Name = "ShowSpliter"
        Me.ShowSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ShowSpliter.Panel1
        '
        Me.ShowSpliter.Panel1.Controls.Add(Me.ShowBox)
        '
        'ShowSpliter.Panel2
        '
        Me.ShowSpliter.Panel2.Controls.Add(Me.ColorViewer)
        Me.ShowSpliter.Size = New System.Drawing.Size(689, 643)
        Me.ShowSpliter.SplitterDistance = 316
        Me.ShowSpliter.TabIndex = 0
        '
        'ShowBox
        '
        Me.ShowBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShowBox.Location = New System.Drawing.Point(291, 119)
        Me.ShowBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShowBox.Name = "ShowBox"
        Me.ShowBox.Size = New System.Drawing.Size(100, 72)
        Me.ShowBox.TabIndex = 0
        Me.ShowBox.TabStop = False
        '
        'ColorViewer
        '
        Me.ColorViewer.CheckBoxes = True
        Me.ColorViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorViewer.FullRowSelect = True
        Me.ColorViewer.Location = New System.Drawing.Point(0, 0)
        Me.ColorViewer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ColorViewer.Name = "ColorViewer"
        Me.ColorViewer.OwnerDraw = True
        Me.ColorViewer.Size = New System.Drawing.Size(689, 323)
        Me.ColorViewer.TabIndex = 0
        Me.ColorViewer.UseCompatibleStateImageBehavior = False
        Me.ColorViewer.View = System.Windows.Forms.View.Details
        '
        'KzBorderTester
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(962, 643)
        Me.Controls.Add(Me.RootSpliter)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzBorderTester"
        Me.Text = "KzBorderTester"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.ConfigPanel.ResumeLayout(False)
        Me.ConfigPanel.PerformLayout()
        Me.ShowSpliter.Panel1.ResumeLayout(False)
        Me.ShowSpliter.Panel2.ResumeLayout(False)
        CType(Me.ShowSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShowSpliter.ResumeLayout(False)
        CType(Me.ShowBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents ConfigPanel As TableLayoutPanel
    Friend WithEvents B3DSideCombo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents B3DStyleCombo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BorderColorButton As Button
    Friend WithEvents BorderColorBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Draw3DChecker As CheckBox
    Friend WithEvents DrawChecker As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackColorBox As TextBox
    Friend WithEvents BackColorButton As Button
    Friend WithEvents BStyleCombo As ComboBox
    Friend WithEvents ShowSpliter As SplitContainer
    Friend WithEvents ShowBox As PictureBox
    Friend WithEvents ColorViewer As KzColorListView
    Friend WithEvents DescTextBox As TextBox
End Class
