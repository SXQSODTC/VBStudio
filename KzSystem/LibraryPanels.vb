﻿Public Class KzColorListPanel
    Inherits FlowLayoutPanel

    Public Sub New()
        Me.FlowDirection = FlowDirection.TopDown

    End Sub
End Class

Public Class KzColorSticker
    Inherits UserControl

    Private Sub InitializeComponent()
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.PropertyLabel = New System.Windows.Forms.Label()
        Me.Checker = New System.Windows.Forms.CheckBox()
        Me.ClassifyLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.RootPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.RootPanel.Controls.Add(Me.ColorButton, 0, 0)
        Me.RootPanel.Controls.Add(Me.NameLabel, 1, 0)
        Me.RootPanel.Controls.Add(Me.PropertyLabel, 1, 1)
        Me.RootPanel.Controls.Add(Me.Checker, 2, 0)
        Me.RootPanel.Controls.Add(Me.ClassifyLabel, 2, 1)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 2
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.Size = New System.Drawing.Size(168, 45)
        Me.RootPanel.TabIndex = 0
        '
        'ColorButton
        '
        Me.ColorButton.FlatAppearance.BorderSize = 0
        Me.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorButton.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorButton.Location = New System.Drawing.Point(0, 0)
        Me.ColorButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ColorButton.Name = "ColorButton"
        Me.RootPanel.SetRowSpan(Me.ColorButton, 2)
        Me.ColorButton.Size = New System.Drawing.Size(57, 45)
        Me.ColorButton.TabIndex = 0
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'PropertyLabel
        '
        Me.PropertyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PropertyLabel.AutoSize = False
        Me.PropertyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PropertyLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyLabel.ForeColor = System.Drawing.Color.DimGray
        Me.PropertyLabel.Location = New System.Drawing.Point(60, 26)
        Me.PropertyLabel.Name = "PropertyLabel"
        Me.PropertyLabel.Size = New System.Drawing.Size(63, 14)
        Me.PropertyLabel.TabIndex = 2
        Me.PropertyLabel.Text = "Property"
        Me.PropertyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PropertyLabel.UseMnemonic = False
        '
        'Checker
        '
        Me.Checker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Checker.AutoSize = True
        Me.Checker.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Checker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checker.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checker.Location = New System.Drawing.Point(153, 3)
        Me.Checker.Name = "Checker"
        Me.Checker.Size = New System.Drawing.Size(12, 11)
        Me.Checker.TabIndex = 3
        Me.Checker.UseVisualStyleBackColor = True
        '
        'ClassifyLabel
        '
        Me.ClassifyLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClassifyLabel.AutoSize = True
        Me.ClassifyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClassifyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClassifyLabel.Font = New System.Drawing.Font("Consolas", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassifyLabel.ForeColor = System.Drawing.Color.DimGray
        Me.ClassifyLabel.Location = New System.Drawing.Point(147, 25)
        Me.ClassifyLabel.Name = "ClassifyLabel"
        Me.ClassifyLabel.Size = New System.Drawing.Size(16, 16)
        Me.ClassifyLabel.TabIndex = 4
        Me.ClassifyLabel.Text = "A"
        Me.ClassifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NameLabel.AutoSize = False
        Me.NameLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(60, 4)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 14)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NameLabel.UseMnemonic = False
        '
        'TestSticker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Name = "TestSticker"
        Me.Size = New System.Drawing.Size(168, 38)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents ColorButton As Button
    Friend WithEvents PropertyLabel As Label
    Friend WithEvents Checker As CheckBox
    Friend WithEvents ClassifyLabel As Label
    Friend WithEvents NameLabel As Label

    Private iArgb As Boolean

    Public Sub New(ByVal TheColor As Color)
        InitializeComponent()
        'Me.Color = TheColor
        Me.ColorButton.BackColor = TheColor
        Me.NameLabel.Text = TheColor.Name
        Me.PropertyLabel.Text = "HEX: &H" & Hex(TheColor.ToArgb)
        If TheColor.IsSystemColor Then
            Me.ClassifyLabel.Text = "S"
        ElseIf TheColor.IsNamedColor Then
            Me.ClassifyLabel.Text = "N"
        Else
            Me.ClassifyLabel.Text = "C"
        End If
        iArgb = False
    End Sub

    Public Property ShowRagb As Boolean
        Get
            Return iArgb
        End Get
        Set(value As Boolean)
            If Not value = iArgb Then
                iArgb = value
                Me.Refresh()
            End If
        End Set
    End Property

    Public Property Checked As Boolean = False

    Public Overrides Sub Refresh()
        MyBase.Refresh()

        Dim c As Color = Me.ColorButton.BackColor
        If iArgb Then
            Me.PropertyLabel.Text = "ARGB(" & c.A & "," & c.R & "," & c.G & "," & c.B & ")"
        Else
            Me.PropertyLabel.Text = "HEX: &H" & Hex(c.ToArgb)
        End If

        If Me.Checker.Checked Then
            Me.BorderStyle = BorderStyle.FixedSingle
        Else
            Me.BorderStyle = BorderStyle.None
        End If
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)

        Me.NameLabel.Width = Me.NameLabel.Parent.Width * 2
        Me.PropertyLabel.Width = Me.PropertyLabel.Parent.Width * 2
    End Sub

    Private Sub Checker_CheckedChanged(sender As Object, e As EventArgs) Handles Checker.CheckedChanged
        Me.Checked = Me.Checker.Checked
        Me.Refresh()
        RaiseEvent CheckedChanged(Me, e)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Me.BackColor = Color.DarkGray
        Me.NameLabel.BackColor = Color.DarkGray
        Me.PropertyLabel.BackColor = Color.Gray
    End Sub

    Public Event CheckedChanged(sender As Object, e As EventArgs)


End Class