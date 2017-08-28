<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzColorConverter
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
        Me.rgbGroup = New System.Windows.Forms.GroupBox()
        Me.blueUD = New System.Windows.Forms.NumericUpDown()
        Me.greenUD = New System.Windows.Forms.NumericUpDown()
        Me.redUD = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.preview = New System.Windows.Forms.Panel()
        Me.hslGroup = New System.Windows.Forms.GroupBox()
        Me.lumUD = New System.Windows.Forms.NumericUpDown()
        Me.satUD = New System.Windows.Forms.NumericUpDown()
        Me.hueUD = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hexBox = New System.Windows.Forms.MaskedTextBox()
        Me.hsbGroup = New System.Windows.Forms.GroupBox()
        Me.bUD = New System.Windows.Forms.NumericUpDown()
        Me.sUD = New System.Windows.Forms.NumericUpDown()
        Me.hUD = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.yuvGroup = New System.Windows.Forms.GroupBox()
        Me.vUD = New System.Windows.Forms.NumericUpDown()
        Me.uUD = New System.Windows.Forms.NumericUpDown()
        Me.yUD = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmykGroup = New System.Windows.Forms.GroupBox()
        Me.blackUD = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.yellowUD = New System.Windows.Forms.NumericUpDown()
        Me.magentaUD = New System.Windows.Forms.NumericUpDown()
        Me.cyanUD = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rgbGroup.SuspendLayout()
        CType(Me.blueUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.greenUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.redUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hslGroup.SuspendLayout()
        CType(Me.lumUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.satUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hueUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hsbGroup.SuspendLayout()
        CType(Me.bUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.yuvGroup.SuspendLayout()
        CType(Me.vUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmykGroup.SuspendLayout()
        CType(Me.blackUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yellowUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.magentaUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cyanUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgbGroup
        '
        Me.rgbGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.rgbGroup.Controls.Add(Me.blueUD)
        Me.rgbGroup.Controls.Add(Me.greenUD)
        Me.rgbGroup.Controls.Add(Me.redUD)
        Me.rgbGroup.Controls.Add(Me.Label3)
        Me.rgbGroup.Controls.Add(Me.Label2)
        Me.rgbGroup.Controls.Add(Me.Label1)
        Me.rgbGroup.Location = New System.Drawing.Point(19, 120)
        Me.rgbGroup.Name = "rgbGroup"
        Me.rgbGroup.Size = New System.Drawing.Size(149, 104)
        Me.rgbGroup.TabIndex = 0
        Me.rgbGroup.TabStop = False
        Me.rgbGroup.Text = "RGB"
        '
        'blueUD
        '
        Me.blueUD.Location = New System.Drawing.Point(68, 66)
        Me.blueUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.blueUD.Name = "blueUD"
        Me.blueUD.Size = New System.Drawing.Size(75, 22)
        Me.blueUD.TabIndex = 4
        '
        'greenUD
        '
        Me.greenUD.Location = New System.Drawing.Point(68, 41)
        Me.greenUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.greenUD.Name = "greenUD"
        Me.greenUD.Size = New System.Drawing.Size(75, 22)
        Me.greenUD.TabIndex = 4
        '
        'redUD
        '
        Me.redUD.Location = New System.Drawing.Point(68, 17)
        Me.redUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.redUD.Name = "redUD"
        Me.redUD.Size = New System.Drawing.Size(75, 22)
        Me.redUD.TabIndex = 3
        Me.redUD.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'preview
        '
        Me.preview.BackColor = System.Drawing.Color.Red
        Me.preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.preview.Location = New System.Drawing.Point(215, 147)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(102, 95)
        Me.preview.TabIndex = 1
        '
        'hslGroup
        '
        Me.hslGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.hslGroup.Controls.Add(Me.lumUD)
        Me.hslGroup.Controls.Add(Me.satUD)
        Me.hslGroup.Controls.Add(Me.hueUD)
        Me.hslGroup.Controls.Add(Me.Label4)
        Me.hslGroup.Controls.Add(Me.Label5)
        Me.hslGroup.Controls.Add(Me.Label6)
        Me.hslGroup.Location = New System.Drawing.Point(187, 8)
        Me.hslGroup.Name = "hslGroup"
        Me.hslGroup.Size = New System.Drawing.Size(168, 104)
        Me.hslGroup.TabIndex = 2
        Me.hslGroup.TabStop = False
        Me.hslGroup.Text = "HSL"
        '
        'lumUD
        '
        Me.lumUD.Location = New System.Drawing.Point(84, 69)
        Me.lumUD.Name = "lumUD"
        Me.lumUD.Size = New System.Drawing.Size(75, 22)
        Me.lumUD.TabIndex = 4
        '
        'satUD
        '
        Me.satUD.Location = New System.Drawing.Point(84, 43)
        Me.satUD.Name = "satUD"
        Me.satUD.Size = New System.Drawing.Size(75, 22)
        Me.satUD.TabIndex = 4
        '
        'hueUD
        '
        Me.hueUD.Location = New System.Drawing.Point(84, 17)
        Me.hueUD.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.hueUD.Name = "hueUD"
        Me.hueUD.Size = New System.Drawing.Size(75, 22)
        Me.hueUD.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Luminance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Saturation"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Hue"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(28, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Hex"
        '
        'hexBox
        '
        Me.hexBox.Location = New System.Drawing.Point(84, 232)
        Me.hexBox.Name = "hexBox"
        Me.hexBox.Size = New System.Drawing.Size(74, 22)
        Me.hexBox.TabIndex = 4
        Me.hexBox.Text = "#FF0000"
        '
        'hsbGroup
        '
        Me.hsbGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.hsbGroup.Controls.Add(Me.bUD)
        Me.hsbGroup.Controls.Add(Me.sUD)
        Me.hsbGroup.Controls.Add(Me.hUD)
        Me.hsbGroup.Controls.Add(Me.Label8)
        Me.hsbGroup.Controls.Add(Me.Label9)
        Me.hsbGroup.Controls.Add(Me.Label10)
        Me.hsbGroup.Location = New System.Drawing.Point(373, 69)
        Me.hsbGroup.Name = "hsbGroup"
        Me.hsbGroup.Size = New System.Drawing.Size(168, 104)
        Me.hsbGroup.TabIndex = 5
        Me.hsbGroup.TabStop = False
        Me.hsbGroup.Text = "HSB"
        '
        'bUD
        '
        Me.bUD.Location = New System.Drawing.Point(84, 69)
        Me.bUD.Name = "bUD"
        Me.bUD.Size = New System.Drawing.Size(75, 22)
        Me.bUD.TabIndex = 4
        '
        'sUD
        '
        Me.sUD.Location = New System.Drawing.Point(84, 43)
        Me.sUD.Name = "sUD"
        Me.sUD.Size = New System.Drawing.Size(75, 22)
        Me.sUD.TabIndex = 4
        '
        'hUD
        '
        Me.hUD.Location = New System.Drawing.Point(84, 17)
        Me.hUD.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.hUD.Name = "hUD"
        Me.hUD.Size = New System.Drawing.Size(75, 22)
        Me.hUD.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Brightness"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Saturation"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Hue"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'yuvGroup
        '
        Me.yuvGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.yuvGroup.Controls.Add(Me.vUD)
        Me.yuvGroup.Controls.Add(Me.uUD)
        Me.yuvGroup.Controls.Add(Me.yUD)
        Me.yuvGroup.Controls.Add(Me.Label11)
        Me.yuvGroup.Controls.Add(Me.Label12)
        Me.yuvGroup.Controls.Add(Me.Label13)
        Me.yuvGroup.Location = New System.Drawing.Point(196, 267)
        Me.yuvGroup.Name = "yuvGroup"
        Me.yuvGroup.Size = New System.Drawing.Size(149, 104)
        Me.yuvGroup.TabIndex = 6
        Me.yuvGroup.TabStop = False
        Me.yuvGroup.Text = "YUV"
        '
        'vUD
        '
        Me.vUD.Location = New System.Drawing.Point(65, 69)
        Me.vUD.Maximum = New Decimal(New Integer() {123, 0, 0, 0})
        Me.vUD.Name = "vUD"
        Me.vUD.Size = New System.Drawing.Size(75, 22)
        Me.vUD.TabIndex = 4
        '
        'uUD
        '
        Me.uUD.Location = New System.Drawing.Point(65, 43)
        Me.uUD.Maximum = New Decimal(New Integer() {87, 0, 0, 0})
        Me.uUD.Name = "uUD"
        Me.uUD.Size = New System.Drawing.Size(75, 22)
        Me.uUD.TabIndex = 4
        '
        'yUD
        '
        Me.yUD.Location = New System.Drawing.Point(65, 17)
        Me.yUD.Name = "yUD"
        Me.yUD.Size = New System.Drawing.Size(75, 22)
        Me.yUD.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "V"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "U"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Y"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmykGroup
        '
        Me.cmykGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmykGroup.Controls.Add(Me.blackUD)
        Me.cmykGroup.Controls.Add(Me.Label17)
        Me.cmykGroup.Controls.Add(Me.yellowUD)
        Me.cmykGroup.Controls.Add(Me.magentaUD)
        Me.cmykGroup.Controls.Add(Me.cyanUD)
        Me.cmykGroup.Controls.Add(Me.Label14)
        Me.cmykGroup.Controls.Add(Me.Label15)
        Me.cmykGroup.Controls.Add(Me.Label16)
        Me.cmykGroup.Location = New System.Drawing.Point(373, 189)
        Me.cmykGroup.Name = "cmykGroup"
        Me.cmykGroup.Size = New System.Drawing.Size(168, 129)
        Me.cmykGroup.TabIndex = 7
        Me.cmykGroup.TabStop = False
        Me.cmykGroup.Text = "CMYK"
        '
        'blackUD
        '
        Me.blackUD.Location = New System.Drawing.Point(84, 94)
        Me.blackUD.Name = "blackUD"
        Me.blackUD.Size = New System.Drawing.Size(75, 22)
        Me.blackUD.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Black"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'yellowUD
        '
        Me.yellowUD.Location = New System.Drawing.Point(84, 69)
        Me.yellowUD.Name = "yellowUD"
        Me.yellowUD.Size = New System.Drawing.Size(75, 22)
        Me.yellowUD.TabIndex = 4
        '
        'magentaUD
        '
        Me.magentaUD.Location = New System.Drawing.Point(84, 43)
        Me.magentaUD.Name = "magentaUD"
        Me.magentaUD.Size = New System.Drawing.Size(75, 22)
        Me.magentaUD.TabIndex = 4
        '
        'cyanUD
        '
        Me.cyanUD.Location = New System.Drawing.Point(84, 17)
        Me.cyanUD.Name = "cyanUD"
        Me.cyanUD.Size = New System.Drawing.Size(75, 22)
        Me.cyanUD.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Yellow"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Magenta"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Cyan"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KzColorConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 387)
        Me.Controls.Add(Me.cmykGroup)
        Me.Controls.Add(Me.yuvGroup)
        Me.Controls.Add(Me.hsbGroup)
        Me.Controls.Add(Me.hexBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hslGroup)
        Me.Controls.Add(Me.preview)
        Me.Controls.Add(Me.rgbGroup)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "KzColorConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color space sample (Conversion GraGra_33)"
        Me.rgbGroup.ResumeLayout(False)
        Me.rgbGroup.PerformLayout()
        CType(Me.blueUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.greenUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.redUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hslGroup.ResumeLayout(False)
        Me.hslGroup.PerformLayout()
        CType(Me.lumUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.satUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hueUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hsbGroup.ResumeLayout(False)
        Me.hsbGroup.PerformLayout()
        CType(Me.bUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.yuvGroup.ResumeLayout(False)
        Me.yuvGroup.PerformLayout()
        CType(Me.vUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmykGroup.ResumeLayout(False)
        Me.cmykGroup.PerformLayout()
        CType(Me.blackUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yellowUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.magentaUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cyanUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rgbGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents redUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents blueUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents greenUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents preview As System.Windows.Forms.Panel
    Friend WithEvents hslGroup As System.Windows.Forms.GroupBox
    Friend WithEvents lumUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents satUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents hueUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hexBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents hsbGroup As System.Windows.Forms.GroupBox
    Friend WithEvents bUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents sUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents hUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents yuvGroup As System.Windows.Forms.GroupBox
    Friend WithEvents vUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents uUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents yUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmykGroup As System.Windows.Forms.GroupBox
    Friend WithEvents yellowUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents magentaUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents cyanUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents blackUD As System.Windows.Forms.NumericUpDown

End Class
