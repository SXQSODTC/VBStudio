Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class TestSlideBar
    Inherits Form
    Private macLabel8 As Label
    Private WithEvents btnClose As Button
    Private WithEvents btnStop As Button
    Private WithEvents btnStart As Button
    Private macLabel7 As Label
    Private WithEvents numMinimum As NumericUpDown
    Private WithEvents numMaximum As NumericUpDown
    Private macLabel6 As Label
    Private macLabel5 As Label
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private macPanel2 As Panel
    Private WithEvents cboBorderStyle As ComboBox
    Private macLabel4 As Label
    Private macLabel2 As Label
    Private macLabel1 As Label
    Private colorDialog1 As System.Windows.Forms.ColorDialog
    Private macPanel1 As Panel
    Private WithEvents macTrackBar1 As KzTrackBar
    Private WithEvents macTrackBar2 As KzTrackBar
    Private macLabel9 As Label
    Private WithEvents numTrackLineHeight As NumericUpDown
    Private WithEvents numTickFrequency As NumericUpDown
    Private macLabel10 As Label
    Private WithEvents numTickHeight As NumericUpDown
    Private macLabel11 As Label
    Private macLabel12 As Label
    Private macLabel13 As Label
    Private WithEvents numTrackerWidth As NumericUpDown
    Private WithEvents numTrackerHeight As NumericUpDown
    Private macLabel14 As Label
    Private macLabel15 As Label
    Private WithEvents numLargeChange As NumericUpDown
    Private macLabel16 As Label
    Private WithEvents numSmallChange As NumericUpDown
    Private macLabel17 As Label
    Private WithEvents numValue As NumericUpDown
    Private WithEvents btnForeColor As Button
    Private WithEvents btnTrackerColor As Button
    Private WithEvents btnTrackLineColor As Button
    Private WithEvents btnTickColor As Button
    Private WithEvents cboTextTickStyle As ComboBox
    Private WithEvents cboTickStyle As ComboBox
    Private macLabel3 As Label
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' TODO: Add any initialization after the InitializeComponent call
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.macLabel8 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.numTrackLineHeight = New System.Windows.Forms.NumericUpDown()
        Me.macLabel7 = New System.Windows.Forms.Label()
        Me.numMinimum = New System.Windows.Forms.NumericUpDown()
        Me.numMaximum = New System.Windows.Forms.NumericUpDown()
        Me.macLabel6 = New System.Windows.Forms.Label()
        Me.numTickFrequency = New System.Windows.Forms.NumericUpDown()
        Me.macLabel5 = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.macPanel2 = New System.Windows.Forms.Panel()
        Me.macTrackBar2 = New KzSystem.KzTrackBar()
        Me.cboBorderStyle = New System.Windows.Forms.ComboBox()
        Me.macLabel4 = New System.Windows.Forms.Label()
        Me.macLabel2 = New System.Windows.Forms.Label()
        Me.macLabel1 = New System.Windows.Forms.Label()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.macPanel1 = New System.Windows.Forms.Panel()
        Me.macTrackBar1 = New KzSystem.KzTrackBar()
        Me.macLabel9 = New System.Windows.Forms.Label()
        Me.macLabel10 = New System.Windows.Forms.Label()
        Me.numTickHeight = New System.Windows.Forms.NumericUpDown()
        Me.macLabel11 = New System.Windows.Forms.Label()
        Me.macLabel12 = New System.Windows.Forms.Label()
        Me.macLabel13 = New System.Windows.Forms.Label()
        Me.numTrackerWidth = New System.Windows.Forms.NumericUpDown()
        Me.numTrackerHeight = New System.Windows.Forms.NumericUpDown()
        Me.macLabel14 = New System.Windows.Forms.Label()
        Me.macLabel15 = New System.Windows.Forms.Label()
        Me.numLargeChange = New System.Windows.Forms.NumericUpDown()
        Me.macLabel16 = New System.Windows.Forms.Label()
        Me.numSmallChange = New System.Windows.Forms.NumericUpDown()
        Me.macLabel17 = New System.Windows.Forms.Label()
        Me.numValue = New System.Windows.Forms.NumericUpDown()
        Me.btnForeColor = New System.Windows.Forms.Button()
        Me.btnTrackerColor = New System.Windows.Forms.Button()
        Me.btnTrackLineColor = New System.Windows.Forms.Button()
        Me.btnTickColor = New System.Windows.Forms.Button()
        Me.cboTextTickStyle = New System.Windows.Forms.ComboBox()
        Me.cboTickStyle = New System.Windows.Forms.ComboBox()
        Me.macLabel3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.numTrackLineHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTickFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.macPanel2.SuspendLayout()
        Me.macPanel1.SuspendLayout()
        CType(Me.numTickHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTrackerWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTrackerHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLargeChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSmallChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'macLabel8
        '
        Me.macLabel8.BackColor = System.Drawing.Color.Transparent
        Me.macLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel8.Location = New System.Drawing.Point(29, 211)
        Me.macLabel8.Name = "macLabel8"
        Me.macLabel8.Size = New System.Drawing.Size(115, 17)
        Me.macLabel8.TabIndex = 45
        Me.macLabel8.Text = "Tracker Color"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(466, 500)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 26)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnStop.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(331, 500)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(115, 26)
        Me.btnStop.TabIndex = 20
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(197, 500)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(115, 26)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'numTrackLineHeight
        '
        Me.numTrackLineHeight.BackColor = System.Drawing.SystemColors.Window
        Me.numTrackLineHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numTrackLineHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numTrackLineHeight.Location = New System.Drawing.Point(163, 389)
        Me.numTrackLineHeight.Name = "numTrackLineHeight"
        Me.numTrackLineHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTrackLineHeight.Size = New System.Drawing.Size(135, 21)
        Me.numTrackLineHeight.TabIndex = 8
        '
        'macLabel7
        '
        Me.macLabel7.BackColor = System.Drawing.Color.Transparent
        Me.macLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel7.Location = New System.Drawing.Point(29, 387)
        Me.macLabel7.Name = "macLabel7"
        Me.macLabel7.Size = New System.Drawing.Size(115, 17)
        Me.macLabel7.TabIndex = 41
        Me.macLabel7.Text = "Line Height"
        '
        'numMinimum
        '
        Me.numMinimum.BackColor = System.Drawing.SystemColors.Window
        Me.numMinimum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numMinimum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numMinimum.Location = New System.Drawing.Point(480, 244)
        Me.numMinimum.Name = "numMinimum"
        Me.numMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMinimum.Size = New System.Drawing.Size(134, 21)
        Me.numMinimum.TabIndex = 16
        '
        'numMaximum
        '
        Me.numMaximum.BackColor = System.Drawing.SystemColors.Window
        Me.numMaximum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numMaximum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numMaximum.Location = New System.Drawing.Point(480, 209)
        Me.numMaximum.Name = "numMaximum"
        Me.numMaximum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numMaximum.Size = New System.Drawing.Size(134, 21)
        Me.numMaximum.TabIndex = 15
        '
        'macLabel6
        '
        Me.macLabel6.BackColor = System.Drawing.Color.Transparent
        Me.macLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel6.Location = New System.Drawing.Point(346, 244)
        Me.macLabel6.Name = "macLabel6"
        Me.macLabel6.Size = New System.Drawing.Size(105, 18)
        Me.macLabel6.TabIndex = 40
        Me.macLabel6.Text = "Minimum"
        '
        'numTickFrequency
        '
        Me.numTickFrequency.BackColor = System.Drawing.SystemColors.Window
        Me.numTickFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numTickFrequency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numTickFrequency.Location = New System.Drawing.Point(480, 351)
        Me.numTickFrequency.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numTickFrequency.Name = "numTickFrequency"
        Me.numTickFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTickFrequency.Size = New System.Drawing.Size(134, 21)
        Me.numTickFrequency.TabIndex = 10
        '
        'macLabel5
        '
        Me.macLabel5.BackColor = System.Drawing.Color.Transparent
        Me.macLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel5.Location = New System.Drawing.Point(346, 209)
        Me.macLabel5.Name = "macLabel5"
        Me.macLabel5.Size = New System.Drawing.Size(105, 17)
        Me.macLabel5.TabIndex = 37
        Me.macLabel5.Text = "Maximum"
        '
        'timer1
        '
        '
        'macPanel2
        '
        Me.macPanel2.BackColor = System.Drawing.Color.Transparent
        Me.macPanel2.Controls.Add(Me.macTrackBar2)
        Me.macPanel2.Location = New System.Drawing.Point(643, 111)
        Me.macPanel2.Name = "macPanel2"
        Me.macPanel2.Size = New System.Drawing.Size(125, 345)
        Me.macPanel2.TabIndex = 22
        '
        'macTrackBar2
        '
        Me.macTrackBar2.BackColor = System.Drawing.Color.Transparent
        Me.macTrackBar2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.macTrackBar2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.macTrackBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.macTrackBar2.IndentHeight = 6
        Me.macTrackBar2.Location = New System.Drawing.Point(12, 34)
        Me.macTrackBar2.Maximum = 10
        Me.macTrackBar2.Minimum = 0
        Me.macTrackBar2.Name = "macTrackBar2"
        Me.macTrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.macTrackBar2.Size = New System.Drawing.Size(77, 276)
        Me.macTrackBar2.TabIndex = 0
        Me.macTrackBar2.TextTickStyle = System.Windows.Forms.TickStyle.Both
        Me.macTrackBar2.TickColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.macTrackBar2.TickHeight = 4
        Me.macTrackBar2.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.macTrackBar2.TrackerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.macTrackBar2.TrackerSize = New System.Drawing.Size(16, 16)
        Me.macTrackBar2.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macTrackBar2.TrackLineHeight = 3
        Me.macTrackBar2.Value = 0
        '
        'cboBorderStyle
        '
        Me.cboBorderStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cboBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorderStyle.DropDownWidth = 128
        Me.cboBorderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold)
        Me.cboBorderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cboBorderStyle.ItemHeight = 13
        Me.cboBorderStyle.Items.AddRange(New Object() {"None", "Dashed", "Dotted", "Inset", "Outset", "Solid", "Adjust", "Bump", "Etched", "Flat", "Raised", "RaisedInner", "RaisedOuter", "Sunken", "SunkenInner", "SunkenOuter"})
        Me.cboBorderStyle.Location = New System.Drawing.Point(163, 138)
        Me.cboBorderStyle.Name = "cboBorderStyle"
        Me.cboBorderStyle.Size = New System.Drawing.Size(135, 21)
        Me.cboBorderStyle.TabIndex = 1
        '
        'macLabel4
        '
        Me.macLabel4.BackColor = System.Drawing.Color.Transparent
        Me.macLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel4.Location = New System.Drawing.Point(346, 351)
        Me.macLabel4.Name = "macLabel4"
        Me.macLabel4.Size = New System.Drawing.Size(144, 17)
        Me.macLabel4.TabIndex = 32
        Me.macLabel4.Text = "Tick Frequency"
        '
        'macLabel2
        '
        Me.macLabel2.BackColor = System.Drawing.Color.Transparent
        Me.macLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel2.Location = New System.Drawing.Point(29, 209)
        Me.macLabel2.Name = "macLabel2"
        Me.macLabel2.Size = New System.Drawing.Size(125, 17)
        Me.macLabel2.TabIndex = 28
        Me.macLabel2.Text = "Text Tick Style"
        '
        'macLabel1
        '
        Me.macLabel1.BackColor = System.Drawing.Color.Transparent
        Me.macLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel1.Location = New System.Drawing.Point(29, 138)
        Me.macLabel1.Name = "macLabel1"
        Me.macLabel1.Size = New System.Drawing.Size(115, 17)
        Me.macLabel1.TabIndex = 26
        Me.macLabel1.Text = "Border Style"
        '
        'macPanel1
        '
        Me.macPanel1.BackColor = System.Drawing.Color.Transparent
        Me.macPanel1.Controls.Add(Me.macTrackBar1)
        Me.macPanel1.Location = New System.Drawing.Point(178, 17)
        Me.macPanel1.Name = "macPanel1"
        Me.macPanel1.Size = New System.Drawing.Size(412, 95)
        Me.macPanel1.TabIndex = 0
        '
        'macTrackBar1
        '
        Me.macTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.macTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.macTrackBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.macTrackBar1.IndentHeight = 6
        Me.macTrackBar1.Location = New System.Drawing.Point(34, 12)
        Me.macTrackBar1.Maximum = 10
        Me.macTrackBar1.Minimum = 0
        Me.macTrackBar1.Name = "macTrackBar1"
        Me.macTrackBar1.Size = New System.Drawing.Size(345, 67)
        Me.macTrackBar1.TabIndex = 0
        Me.macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.Both
        Me.macTrackBar1.TickColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.macTrackBar1.TickHeight = 4
        Me.macTrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.macTrackBar1.TrackerColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.macTrackBar1.TrackerSize = New System.Drawing.Size(16, 16)
        Me.macTrackBar1.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macTrackBar1.TrackLineHeight = 3
        Me.macTrackBar1.Value = 0
        '
        'macLabel9
        '
        Me.macLabel9.BackColor = System.Drawing.Color.Transparent
        Me.macLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel9.Location = New System.Drawing.Point(29, 173)
        Me.macLabel9.Name = "macLabel9"
        Me.macLabel9.Size = New System.Drawing.Size(96, 18)
        Me.macLabel9.TabIndex = 45
        Me.macLabel9.Text = "Text Color"
        '
        'macLabel10
        '
        Me.macLabel10.BackColor = System.Drawing.Color.Transparent
        Me.macLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel10.Location = New System.Drawing.Point(29, 422)
        Me.macLabel10.Name = "macLabel10"
        Me.macLabel10.Size = New System.Drawing.Size(96, 17)
        Me.macLabel10.TabIndex = 45
        Me.macLabel10.Text = "Tick Color"
        '
        'numTickHeight
        '
        Me.numTickHeight.BackColor = System.Drawing.SystemColors.Window
        Me.numTickHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numTickHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numTickHeight.Location = New System.Drawing.Point(480, 316)
        Me.numTickHeight.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numTickHeight.Name = "numTickHeight"
        Me.numTickHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTickHeight.Size = New System.Drawing.Size(134, 21)
        Me.numTickHeight.TabIndex = 18
        '
        'macLabel11
        '
        Me.macLabel11.BackColor = System.Drawing.Color.Transparent
        Me.macLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel11.Location = New System.Drawing.Point(346, 316)
        Me.macLabel11.Name = "macLabel11"
        Me.macLabel11.Size = New System.Drawing.Size(124, 17)
        Me.macLabel11.TabIndex = 32
        Me.macLabel11.Text = "Tick Height"
        '
        'macLabel12
        '
        Me.macLabel12.BackColor = System.Drawing.Color.Transparent
        Me.macLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel12.Location = New System.Drawing.Point(29, 280)
        Me.macLabel12.Name = "macLabel12"
        Me.macLabel12.Size = New System.Drawing.Size(115, 17)
        Me.macLabel12.TabIndex = 37
        Me.macLabel12.Text = "Tracker Width"
        '
        'macLabel13
        '
        Me.macLabel13.BackColor = System.Drawing.Color.Transparent
        Me.macLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel13.Location = New System.Drawing.Point(29, 316)
        Me.macLabel13.Name = "macLabel13"
        Me.macLabel13.Size = New System.Drawing.Size(134, 17)
        Me.macLabel13.TabIndex = 40
        Me.macLabel13.Text = "Tracker Height"
        '
        'numTrackerWidth
        '
        Me.numTrackerWidth.BackColor = System.Drawing.SystemColors.Window
        Me.numTrackerWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numTrackerWidth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numTrackerWidth.Location = New System.Drawing.Point(163, 280)
        Me.numTrackerWidth.Name = "numTrackerWidth"
        Me.numTrackerWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTrackerWidth.Size = New System.Drawing.Size(135, 21)
        Me.numTrackerWidth.TabIndex = 5
        '
        'numTrackerHeight
        '
        Me.numTrackerHeight.BackColor = System.Drawing.SystemColors.Window
        Me.numTrackerHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numTrackerHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numTrackerHeight.Location = New System.Drawing.Point(163, 317)
        Me.numTrackerHeight.Name = "numTrackerHeight"
        Me.numTrackerHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numTrackerHeight.Size = New System.Drawing.Size(135, 21)
        Me.numTrackerHeight.TabIndex = 6
        '
        'macLabel14
        '
        Me.macLabel14.BackColor = System.Drawing.Color.Transparent
        Me.macLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel14.Location = New System.Drawing.Point(29, 351)
        Me.macLabel14.Name = "macLabel14"
        Me.macLabel14.Size = New System.Drawing.Size(125, 17)
        Me.macLabel14.TabIndex = 45
        Me.macLabel14.Text = "TrackLine Color"
        '
        'macLabel15
        '
        Me.macLabel15.BackColor = System.Drawing.Color.Transparent
        Me.macLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel15.Location = New System.Drawing.Point(346, 138)
        Me.macLabel15.Name = "macLabel15"
        Me.macLabel15.Size = New System.Drawing.Size(115, 17)
        Me.macLabel15.TabIndex = 37
        Me.macLabel15.Text = "Large Change"
        '
        'numLargeChange
        '
        Me.numLargeChange.BackColor = System.Drawing.SystemColors.Window
        Me.numLargeChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numLargeChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numLargeChange.Location = New System.Drawing.Point(480, 138)
        Me.numLargeChange.Name = "numLargeChange"
        Me.numLargeChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numLargeChange.Size = New System.Drawing.Size(134, 21)
        Me.numLargeChange.TabIndex = 13
        '
        'macLabel16
        '
        Me.macLabel16.BackColor = System.Drawing.Color.Transparent
        Me.macLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel16.Location = New System.Drawing.Point(346, 173)
        Me.macLabel16.Name = "macLabel16"
        Me.macLabel16.Size = New System.Drawing.Size(115, 18)
        Me.macLabel16.TabIndex = 37
        Me.macLabel16.Text = "Small Change"
        '
        'numSmallChange
        '
        Me.numSmallChange.BackColor = System.Drawing.SystemColors.Window
        Me.numSmallChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numSmallChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numSmallChange.Location = New System.Drawing.Point(480, 173)
        Me.numSmallChange.Name = "numSmallChange"
        Me.numSmallChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numSmallChange.Size = New System.Drawing.Size(134, 21)
        Me.numSmallChange.TabIndex = 14
        '
        'macLabel17
        '
        Me.macLabel17.BackColor = System.Drawing.Color.Transparent
        Me.macLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel17.Location = New System.Drawing.Point(346, 280)
        Me.macLabel17.Name = "macLabel17"
        Me.macLabel17.Size = New System.Drawing.Size(105, 17)
        Me.macLabel17.TabIndex = 40
        Me.macLabel17.Text = "Value"
        '
        'numValue
        '
        Me.numValue.BackColor = System.Drawing.SystemColors.Window
        Me.numValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.numValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.numValue.Location = New System.Drawing.Point(480, 280)
        Me.numValue.Name = "numValue"
        Me.numValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numValue.Size = New System.Drawing.Size(134, 21)
        Me.numValue.TabIndex = 17
        '
        'btnForeColor
        '
        Me.btnForeColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnForeColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForeColor.ForeColor = System.Drawing.Color.White
        Me.btnForeColor.Location = New System.Drawing.Point(163, 173)
        Me.btnForeColor.Name = "btnForeColor"
        Me.btnForeColor.Size = New System.Drawing.Size(58, 23)
        Me.btnForeColor.TabIndex = 2
        Me.btnForeColor.Text = "..."
        Me.btnForeColor.UseVisualStyleBackColor = False
        '
        'btnTrackerColor
        '
        Me.btnTrackerColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnTrackerColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackerColor.ForeColor = System.Drawing.Color.White
        Me.btnTrackerColor.Location = New System.Drawing.Point(163, 244)
        Me.btnTrackerColor.Name = "btnTrackerColor"
        Me.btnTrackerColor.Size = New System.Drawing.Size(58, 23)
        Me.btnTrackerColor.TabIndex = 4
        Me.btnTrackerColor.Text = "..."
        Me.btnTrackerColor.UseVisualStyleBackColor = False
        '
        'btnTrackLineColor
        '
        Me.btnTrackLineColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnTrackLineColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackLineColor.ForeColor = System.Drawing.Color.White
        Me.btnTrackLineColor.Location = New System.Drawing.Point(163, 353)
        Me.btnTrackLineColor.Name = "btnTrackLineColor"
        Me.btnTrackLineColor.Size = New System.Drawing.Size(58, 23)
        Me.btnTrackLineColor.TabIndex = 7
        Me.btnTrackLineColor.Text = "..."
        Me.btnTrackLineColor.UseVisualStyleBackColor = False
        '
        'btnTickColor
        '
        Me.btnTickColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnTickColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTickColor.ForeColor = System.Drawing.Color.White
        Me.btnTickColor.Location = New System.Drawing.Point(163, 425)
        Me.btnTickColor.Name = "btnTickColor"
        Me.btnTickColor.Size = New System.Drawing.Size(58, 23)
        Me.btnTickColor.TabIndex = 9
        Me.btnTickColor.Text = "..."
        Me.btnTickColor.UseVisualStyleBackColor = False
        '
        'cboTextTickStyle
        '
        Me.cboTextTickStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cboTextTickStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTextTickStyle.DropDownWidth = 128
        Me.cboTextTickStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold)
        Me.cboTextTickStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cboTextTickStyle.ItemHeight = 13
        Me.cboTextTickStyle.Items.AddRange(New Object() {"None", "TopLeft", "BottomRight", "Both"})
        Me.cboTextTickStyle.Location = New System.Drawing.Point(163, 209)
        Me.cboTextTickStyle.Name = "cboTextTickStyle"
        Me.cboTextTickStyle.Size = New System.Drawing.Size(135, 21)
        Me.cboTextTickStyle.TabIndex = 3
        '
        'cboTickStyle
        '
        Me.cboTickStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cboTickStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTickStyle.DropDownWidth = 128
        Me.cboTickStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold)
        Me.cboTickStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cboTickStyle.ItemHeight = 13
        Me.cboTickStyle.Items.AddRange(New Object() {"None", "TopLeft", "BottomRight", "Both"})
        Me.cboTickStyle.Location = New System.Drawing.Point(480, 387)
        Me.cboTickStyle.Name = "cboTickStyle"
        Me.cboTickStyle.Size = New System.Drawing.Size(134, 21)
        Me.cboTickStyle.TabIndex = 11
        '
        'macLabel3
        '
        Me.macLabel3.BackColor = System.Drawing.Color.Transparent
        Me.macLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.macLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.macLabel3.Location = New System.Drawing.Point(346, 387)
        Me.macLabel3.Name = "macLabel3"
        Me.macLabel3.Size = New System.Drawing.Size(144, 17)
        Me.macLabel3.TabIndex = 32
        Me.macLabel3.Text = "Tick Style"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(29, 244)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(115, 18)
        Me.label1.TabIndex = 37
        Me.label1.Text = "Tracker Color"
        '
        'macSlider_Demo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(799, 549)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cboBorderStyle)
        Me.Controls.Add(Me.btnForeColor)
        Me.Controls.Add(Me.btnTrackerColor)
        Me.Controls.Add(Me.btnTrackLineColor)
        Me.Controls.Add(Me.btnTickColor)
        Me.Controls.Add(Me.cboTextTickStyle)
        Me.Controls.Add(Me.cboTickStyle)
        Me.Controls.Add(Me.numTrackLineHeight)
        Me.Controls.Add(Me.macLabel7)
        Me.Controls.Add(Me.numMinimum)
        Me.Controls.Add(Me.numMaximum)
        Me.Controls.Add(Me.macLabel6)
        Me.Controls.Add(Me.numTickFrequency)
        Me.Controls.Add(Me.macLabel5)
        Me.Controls.Add(Me.macPanel2)
        Me.Controls.Add(Me.macLabel4)
        Me.Controls.Add(Me.macLabel2)
        Me.Controls.Add(Me.macLabel1)
        Me.Controls.Add(Me.macLabel8)
        Me.Controls.Add(Me.macLabel9)
        Me.Controls.Add(Me.macLabel10)
        Me.Controls.Add(Me.numTickHeight)
        Me.Controls.Add(Me.macLabel11)
        Me.Controls.Add(Me.macLabel12)
        Me.Controls.Add(Me.macLabel13)
        Me.Controls.Add(Me.numTrackerWidth)
        Me.Controls.Add(Me.numTrackerHeight)
        Me.Controls.Add(Me.macLabel14)
        Me.Controls.Add(Me.macLabel15)
        Me.Controls.Add(Me.numLargeChange)
        Me.Controls.Add(Me.macLabel16)
        Me.Controls.Add(Me.numSmallChange)
        Me.Controls.Add(Me.macLabel17)
        Me.Controls.Add(Me.numValue)
        Me.Controls.Add(Me.macLabel3)
        Me.Controls.Add(Me.macPanel1)
        Me.Controls.Add(Me.label1)
        Me.Name = "macSlider_Demo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slider (TrackBar) - Demo"
        CType(Me.numTrackLineHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaximum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTickFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.macPanel2.ResumeLayout(False)
        Me.macPanel1.ResumeLayout(False)
        CType(Me.numTickHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTrackerWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTrackerHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLargeChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSmallChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub macSlider_Demo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitControls()
    End Sub

    Private Sub InitControls()

        Me.cboBorderStyle.SelectedIndex = CInt(Fix(Me.macTrackBar1.BorderStyle))
        Me.btnForeColor.BackColor = Me.macTrackBar1.ForeColor
        Me.cboTextTickStyle.SelectedIndex = CInt(Fix(Me.macTrackBar1.TextTickStyle))

        Me.btnTickColor.BackColor = Me.macTrackBar1.TickColor
        Me.numTickFrequency.Value = Me.macTrackBar1.TickFrequency
        Me.numTickHeight.Value = Me.macTrackBar1.TickHeight
        Me.cboTickStyle.SelectedIndex = CInt(Fix(Me.macTrackBar1.TickStyle))

        Me.btnTrackerColor.BackColor = Me.macTrackBar1.TrackerColor
        Me.numTrackerWidth.Value = Me.macTrackBar1.TrackerSize.Width
        Me.numTrackerHeight.Value = Me.macTrackBar1.TrackerSize.Height
        Me.btnTrackLineColor.BackColor = Me.macTrackBar1.TrackLineColor
        Me.numTrackLineHeight.Value = Me.macTrackBar1.TrackLineHeight

        Me.numLargeChange.Value = Me.macTrackBar1.LargeChange
        Me.numSmallChange.Value = Me.macTrackBar1.SmallChange
        Me.numMaximum.Value = Me.macTrackBar1.Maximum
        Me.numMinimum.Value = Me.macTrackBar1.Minimum
        Me.numValue.Value = Me.macTrackBar1.Value

    End Sub

    Private Sub cboBorderStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBorderStyle.SelectedIndexChanged
        Me.macTrackBar1.BorderStyle = CType(cboBorderStyle.SelectedIndex, KzBorderStyle)
        Me.macTrackBar2.BorderStyle = CType(cboBorderStyle.SelectedIndex, KzBorderStyle)

    End Sub

    Private Sub cboTextTickStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTextTickStyle.SelectedIndexChanged
        Me.macTrackBar1.TextTickStyle = CType(cboTextTickStyle.SelectedIndex, TickStyle)
        Me.macTrackBar2.TextTickStyle = CType(cboTextTickStyle.SelectedIndex, TickStyle)

    End Sub

    Private Sub cboTickStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTickStyle.SelectedIndexChanged
        Me.macTrackBar1.TickStyle = CType(cboTickStyle.SelectedIndex, TickStyle)
        Me.macTrackBar2.TickStyle = CType(cboTickStyle.SelectedIndex, TickStyle)

    End Sub

    Private Sub btnForeColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnForeColor.Click
        Me.colorDialog1.Color = Me.btnForeColor.BackColor
        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.btnForeColor.BackColor = colorDialog1.Color
            Me.macTrackBar1.ForeColor = colorDialog1.Color
            Me.macTrackBar2.ForeColor = colorDialog1.Color
        End If

    End Sub

    Private Sub btnTrackerColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTrackerColor.Click
        Me.colorDialog1.Color = Me.btnTrackerColor.BackColor
        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.btnTrackerColor.BackColor = colorDialog1.Color
            Me.macTrackBar1.TrackerColor = colorDialog1.Color
            Me.macTrackBar2.TrackerColor = colorDialog1.Color
        End If

    End Sub

    Private Sub btnTrackLineColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTrackLineColor.Click
        Me.colorDialog1.Color = Me.btnTrackLineColor.BackColor
        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.btnTrackLineColor.BackColor = colorDialog1.Color
            Me.macTrackBar1.TrackLineColor = colorDialog1.Color
            Me.macTrackBar2.TrackLineColor = colorDialog1.Color
        End If

    End Sub

    Private Sub btnTickColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTickColor.Click
        Me.colorDialog1.Color = Me.btnTickColor.BackColor
        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.btnTickColor.BackColor = colorDialog1.Color
            Me.macTrackBar1.TickColor = colorDialog1.Color
            Me.macTrackBar2.TickColor = colorDialog1.Color
        End If

    End Sub

    Private Sub numTrackerWidth_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTrackerWidth.ValueChanged
        Me.macTrackBar1.TrackerSize = New Size(CInt(Fix(numTrackerWidth.Value)), macTrackBar1.TrackerSize.Height)
        Me.macTrackBar2.TrackerSize = New Size(CInt(Fix(numTrackerWidth.Value)), macTrackBar2.TrackerSize.Height)

    End Sub

    Private Sub numTrackerHeight_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTrackerHeight.ValueChanged
        Me.macTrackBar1.TrackerSize = New Size(macTrackBar1.TrackerSize.Width, CInt(Fix(numTrackerHeight.Value)))
        Me.macTrackBar2.TrackerSize = New Size(macTrackBar2.TrackerSize.Width, CInt(Fix(numTrackerHeight.Value)))
    End Sub

    Private Sub numTrackLineHeight_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTrackLineHeight.ValueChanged
        Me.macTrackBar1.TrackLineHeight = CInt(Fix(numTrackLineHeight.Value))
        Me.macTrackBar2.TrackLineHeight = CInt(Fix(numTrackLineHeight.Value))

    End Sub

    Private Sub numTickFrequency_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTickFrequency.ValueChanged
        Me.macTrackBar1.TickFrequency = CInt(Fix(numTickFrequency.Value))
        Me.macTrackBar2.TickFrequency = CInt(Fix(numTickFrequency.Value))

    End Sub

    Private Sub numLargeChange_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numLargeChange.ValueChanged
        Me.macTrackBar1.LargeChange = CInt(Fix(numLargeChange.Value))
        Me.macTrackBar2.LargeChange = CInt(Fix(numLargeChange.Value))

    End Sub

    Private Sub numSmallChange_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numSmallChange.ValueChanged
        Me.macTrackBar1.SmallChange = CInt(Fix(numSmallChange.Value))
        Me.macTrackBar2.SmallChange = CInt(Fix(numSmallChange.Value))

    End Sub

    Private Sub numMaximum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numMaximum.ValueChanged
        Me.macTrackBar1.Maximum = CInt(Fix(numMaximum.Value))
        Me.macTrackBar2.Maximum = CInt(Fix(numMaximum.Value))

    End Sub

    Private Sub numMinimum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numMinimum.ValueChanged
        Me.macTrackBar1.Minimum = CInt(Fix(numMinimum.Value))
        Me.macTrackBar2.Minimum = CInt(Fix(numMinimum.Value))

    End Sub

    Private Sub numValue_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numValue.ValueChanged
        Me.macTrackBar1.Value = CInt(Fix(numValue.Value))
        Me.macTrackBar2.Value = CInt(Fix(numValue.Value))

    End Sub

    Private Sub numTickHeight_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numTickHeight.ValueChanged
        Me.macTrackBar1.TickHeight = CInt(Fix(numTickHeight.Value))
        Me.macTrackBar2.TickHeight = CInt(Fix(numTickHeight.Value))

    End Sub

    Private Sub macTrackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles macTrackBar1.Scroll
        numValue.Value = macTrackBar1.Value
        macTrackBar2.Value = macTrackBar1.Value

    End Sub

    Private Sub macTrackBar2_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles macTrackBar2.Scroll
        numValue.Value = macTrackBar2.Value
        macTrackBar1.Value = macTrackBar2.Value

    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        Me.macTrackBar1.Increment(macTrackBar1.SmallChange)
        If Me.macTrackBar1.Value = Me.macTrackBar1.Maximum Then
            Me.macTrackBar1.Value = Me.macTrackBar1.Minimum
        End If

        Me.macTrackBar2.Increment(macTrackBar1.SmallChange)
        If Me.macTrackBar2.Value = Me.macTrackBar2.Maximum Then
            Me.macTrackBar2.Value = Me.macTrackBar2.Minimum
        End If

    End Sub

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click
        timer1.Start()

    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        timer1.Stop()

    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub macSlider_Demo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        timer1.Stop()

    End Sub

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Shared Sub Main()
        Application.Run(New TestSlideBar())
    End Sub


End Class