<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiteCloneForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiteCloneForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainTabs = New System.Windows.Forms.TabControl()
        Me.PageCreation = New System.Windows.Forms.TabPage()
        Me.CreationPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ActivityBar1 = New KzHelper.ActivityBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MainTabs.SuspendLayout()
        Me.PageCreation.SuspendLayout()
        Me.CreationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(499, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "Root:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "Test:"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 423)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(499, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'MainTabs
        '
        Me.MainTabs.Controls.Add(Me.PageCreation)
        Me.MainTabs.Controls.Add(Me.TabPage2)
        Me.MainTabs.Controls.Add(Me.TabPage3)
        Me.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabs.Location = New System.Drawing.Point(0, 25)
        Me.MainTabs.Name = "MainTabs"
        Me.MainTabs.SelectedIndex = 0
        Me.MainTabs.Size = New System.Drawing.Size(499, 398)
        Me.MainTabs.TabIndex = 2
        '
        'PageCreation
        '
        Me.PageCreation.Controls.Add(Me.CreationPanel)
        Me.PageCreation.Location = New System.Drawing.Point(4, 23)
        Me.PageCreation.Name = "PageCreation"
        Me.PageCreation.Padding = New System.Windows.Forms.Padding(3)
        Me.PageCreation.Size = New System.Drawing.Size(491, 371)
        Me.PageCreation.TabIndex = 0
        Me.PageCreation.Text = "Creation"
        Me.PageCreation.UseVisualStyleBackColor = True
        '
        'CreationPanel
        '
        Me.CreationPanel.ColumnCount = 4
        Me.CreationPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.CreationPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.CreationPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CreationPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.CreationPanel.Controls.Add(Me.Button1, 0, 0)
        Me.CreationPanel.Controls.Add(Me.ProgressBar1, 2, 1)
        Me.CreationPanel.Controls.Add(Me.Button2, 0, 2)
        Me.CreationPanel.Controls.Add(Me.ProgressBar2, 2, 3)
        Me.CreationPanel.Controls.Add(Me.ProgressBar3, 2, 5)
        Me.CreationPanel.Controls.Add(Me.ProgressBar4, 2, 9)
        Me.CreationPanel.Controls.Add(Me.ActivityBar1, 0, 8)
        Me.CreationPanel.Controls.Add(Me.TextBox1, 0, 10)
        Me.CreationPanel.Controls.Add(Me.ProgressBar5, 2, 7)
        Me.CreationPanel.Controls.Add(Me.CheckBox2, 1, 0)
        Me.CreationPanel.Controls.Add(Me.CheckBox3, 1, 2)
        Me.CreationPanel.Controls.Add(Me.CheckBox4, 1, 4)
        Me.CreationPanel.Controls.Add(Me.CheckBox1, 1, 6)
        Me.CreationPanel.Controls.Add(Me.CheckBox5, 1, 8)
        Me.CreationPanel.Controls.Add(Me.Label1, 3, 1)
        Me.CreationPanel.Controls.Add(Me.Label4, 3, 3)
        Me.CreationPanel.Controls.Add(Me.Label2, 3, 5)
        Me.CreationPanel.Controls.Add(Me.Label3, 3, 7)
        Me.CreationPanel.Controls.Add(Me.Label5, 3, 9)
        Me.CreationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreationPanel.Location = New System.Drawing.Point(3, 3)
        Me.CreationPanel.Name = "CreationPanel"
        Me.CreationPanel.RowCount = 11
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreationPanel.Size = New System.Drawing.Size(485, 365)
        Me.CreationPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(17, 6)
        Me.Button1.Name = "Button1"
        Me.CreationPanel.SetRowSpan(Me.Button1, 2)
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(129, 23)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(313, 14)
        Me.ProgressBar1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(17, 46)
        Me.Button2.Name = "Button2"
        Me.CreationPanel.SetRowSpan(Me.Button2, 2)
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar2.Location = New System.Drawing.Point(129, 63)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(313, 14)
        Me.ProgressBar2.TabIndex = 7
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar3.Location = New System.Drawing.Point(129, 103)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(313, 14)
        Me.ProgressBar3.TabIndex = 8
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar4.Location = New System.Drawing.Point(129, 183)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(313, 14)
        Me.ProgressBar4.TabIndex = 9
        '
        'ActivityBar1
        '
        Me.ActivityBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ActivityBar1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivityBar1.Location = New System.Drawing.Point(3, 177)
        Me.ActivityBar1.Name = "ActivityBar1"
        Me.CreationPanel.SetRowSpan(Me.ActivityBar1, 2)
        Me.ActivityBar1.Size = New System.Drawing.Size(104, 20)
        Me.ActivityBar1.TabIndex = 10
        '
        'TextBox1
        '
        Me.CreationPanel.SetColumnSpan(Me.TextBox1, 4)
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 203)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(479, 159)
        Me.TextBox1.TabIndex = 11
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar5.Location = New System.Drawing.Point(129, 143)
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.Size = New System.Drawing.Size(313, 14)
        Me.ProgressBar5.TabIndex = 13
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CreationPanel.SetColumnSpan(Me.CheckBox2, 2)
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox2.Location = New System.Drawing.Point(110, 0)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(335, 20)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "1. Get categries from site."
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CreationPanel.SetColumnSpan(Me.CheckBox3, 2)
        Me.CheckBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox3.Location = New System.Drawing.Point(110, 40)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(335, 20)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "2. Get book list sources from site."
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CreationPanel.SetColumnSpan(Me.CheckBox4, 2)
        Me.CheckBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox4.Location = New System.Drawing.Point(110, 80)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(335, 20)
        Me.CheckBox4.TabIndex = 16
        Me.CheckBox4.Text = "3. Get book list from surce files."
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CreationPanel.SetColumnSpan(Me.CheckBox1, 2)
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(110, 120)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(335, 20)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "4. Combine book lists."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CreationPanel.SetColumnSpan(Me.CheckBox5, 2)
        Me.CheckBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox5.Location = New System.Drawing.Point(110, 160)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(335, 20)
        Me.CheckBox5.TabIndex = 17
        Me.CheckBox5.Text = "5. Create entries from book list."
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(448, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "100%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(448, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "100%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(448, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "100%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(448, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "100%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(448, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "100%"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(491, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Download"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(491, 291)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SiteCloneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 445)
        Me.Controls.Add(Me.MainTabs)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SiteCloneForm"
        Me.Text = "SiteCloneForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MainTabs.ResumeLayout(False)
        Me.PageCreation.ResumeLayout(False)
        Me.CreationPanel.ResumeLayout(False)
        Me.CreationPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MainTabs As TabControl
    Friend WithEvents PageCreation As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents CreationPanel As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ActivityBar1 As KzHelper.ActivityBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar5 As ProgressBar
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
