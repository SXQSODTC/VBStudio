Imports System.ComponentModel
Imports System.Windows.Forms.Design

'<Description("KzTrackBar represents an advanced track bar that is very better than the standard trackbar."),
'    ToolboxBitmap(GetType(KzTrackBar), "Editors.KzTrackBar.KzTrackBar.bmp"), Designer(GetType(KzTrackBarDesigner)),
'    DefaultProperty("Maximum"), DefaultEvent("ValueChanged")>
<Description("Provider a base control for data input."), Designer(GetType(DataInputItemDesigner)),
    DefaultProperty("Key"), DefaultEvent("ValueChanged")>
Public MustInherit Class DataInputItem
    Inherits TableLayoutPanel

    Friend WithEvents Checker As CheckBox
    Friend WithEvents SubjectLabel As Label
    'Friend WithEvents InputBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExtendButton As Button
    'Friend WithEvents Tips As ToolTip

    Private _UseChecker As Boolean
    Private _UseClearButton As Boolean
    Private _CanExtend As Boolean
    Private _IsReadOnly As Boolean

    Public Sub New()
        InitializeComponent()

    End Sub

    Public Property HeightFixed As Boolean = True

    Public ReadOnly Property ValueType As ValueType
        Get
            Return Me.Value
        End Get
    End Property

    Public MustOverride Property Value As Object

    Public Overridable Property IsReadOnly As Boolean
        Get
            Return _IsReadOnly
        End Get
        Set(value As Boolean)
            _IsReadOnly = value

        End Set
    End Property

    Public Property SubjectWidth As Integer
        Get
            Return SubjectLabel.Width
        End Get
        Set(value As Integer)
            SubjectLabel.Width = value
        End Set
    End Property

    Public Property Key As String
        Get
            Return SubjectLabel.Text
        End Get
        Set(value As String)
            SubjectLabel.Text = value
        End Set
    End Property

    Public Property Checked As Boolean
        Get
            Return Checker.Checked
        End Get
        Set(value As Boolean)
            Checker.Checked = value
        End Set
    End Property

    Public Overridable Property CanCheck As Boolean
        Get
            Return _UseChecker
        End Get
        Set(value As Boolean)
            _UseChecker = value

        End Set
    End Property

    Public Overridable Property UseClearButton As Boolean
        Get
            Return _UseClearButton
        End Get
        Set(value As Boolean)
            _UseClearButton = value

        End Set
    End Property

    Public Overridable Property CanExtend As Boolean
        Get
            Return _CanExtend
        End Get
        Set(value As Boolean)
            _CanExtend = value

        End Set
    End Property

    Public Property ToolTip As ToolTip

    Private Sub InitializeComponent()
        Me.Checker = New System.Windows.Forms.CheckBox()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        'Me.InputBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExtendButton = New System.Windows.Forms.Button()
        'Me.Tips = New System.Windows.Forms.ToolTip(Me)
        'Me.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.ColumnCount = 6
        Me.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.Controls.Add(Me.Checker, 0, 0)
        Me.Controls.Add(Me.SubjectLabel, 1, 0)
        'Me.Controls.Add(Me.InputBox, 2, 0)
        Me.Controls.Add(Me.ClearButton, 4, 0)
        Me.Controls.Add(Me.ExtendButton, 5, 0)
        Me.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "RootPanel"
        Me.RowCount = 3
        Me.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0!))
        Me.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0!))
        Me.Size = New System.Drawing.Size(300, 25)
        Me.TabIndex = 0
        '
        'Checker
        '
        Me.Checker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Checker.AutoSize = True
        Me.Checker.FlatAppearance.BorderSize = 0
        Me.Checker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checker.Location = New System.Drawing.Point(6, 7)
        Me.Checker.Name = "Checker"
        Me.Checker.Size = New System.Drawing.Size(12, 11)
        Me.Checker.TabIndex = 0
        Me.Checker.UseVisualStyleBackColor = True
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectLabel.Location = New System.Drawing.Point(28, 0)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(54, 25)
        Me.SubjectLabel.TabIndex = 1
        Me.SubjectLabel.Text = "Subject"
        Me.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InputBox
        '
        'Me.InputBox.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.InputBox.Location = New System.Drawing.Point(86, 1)
        'Me.InputBox.Margin = New System.Windows.Forms.Padding(1)
        'Me.InputBox.Name = "InputBox"
        'Me.InputBox.Size = New System.Drawing.Size(80, 23)
        'Me.InputBox.TabIndex = 2
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(250, 1)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(23, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExtendButton
        '
        Me.ExtendButton.Location = New System.Drawing.Point(275, 1)
        Me.ExtendButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ExtendButton.Name = "ExtendButton"
        Me.ExtendButton.Size = New System.Drawing.Size(23, 23)
        Me.ExtendButton.TabIndex = 4
        Me.ExtendButton.UseVisualStyleBackColor = True
        '
        'DataInputItemSample
        '
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.Controls.Add(Me)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DataInputItemSample"
        'Me.Size = New System.Drawing.Size(300, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        'Me.ResumeLayout(False)
    End Sub

    Private Sub Checker_CheckedChanged(sender As Object, e As EventArgs) Handles Checker.CheckedChanged
        RaiseEvent CheckedChange(Me, e)
    End Sub

    Private Sub Checker_CheckStateChanged(sender As Object, e As EventArgs) Handles Checker.CheckStateChanged
        RaiseEvent CheckStateChanged(Me, e)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RaiseEvent ClearButtonClick(Me, e)
    End Sub

    Private Sub ExtendButton_Click(sender As Object, e As EventArgs) Handles ExtendButton.Click
        RaiseEvent ExtendButtonClick(Me, e)
    End Sub

    Public Event CheckedChange(sender As Object, e As EventArgs)
    Public Event CheckStateChanged(sender As Object, e As EventArgs)
    Public Event ClearButtonClick(sender As Object, e As EventArgs)
    Public Event ExtendButtonClick(sender As Object, e As EventArgs)
    Public Event ValueChanged(sender As Object, e As EventArgs)
End Class

Public Class DataInputItemDesigner
    Inherits ControlDesigner

    Public Sub New()

    End Sub

    Public Overrides ReadOnly Property SelectionRules() As SelectionRules
        Get
            Dim control As DataInputItem =
                CType(IIf(TypeOf Me.Control Is DataInputItem, Me.Control, Nothing), DataInputItem)

            ' Disallow vertical or horizontal sizing when AutoSize = True
            If Not control Is Nothing AndAlso control.AutoSize = True Then
                If control.HeightFixed Then
                    Return (MyBase.SelectionRules And (Not SelectionRules.TopSizeable)) And Not SelectionRules.BottomSizeable
                Else
                    Return MyBase.SelectionRules
                End If
            Else
                Return MyBase.SelectionRules
            End If
        End Get
    End Property

End Class

Public Class DataInputTextItem
    Inherits DataInputItem

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub InitializeComponent()

    End Sub

    Public Overrides Property Value As Object
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Object)
            Throw New NotImplementedException()
        End Set
    End Property


End Class