Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports KzSystem.KzData

'<Description("KzTrackBar represents an advanced track bar that is very better than the standard trackbar."),
'    ToolboxBitmap(GetType(KzTrackBar), "Editors.KzTrackBar.KzTrackBar.bmp"), Designer(GetType(KzTrackBarDesigner)),
'    DefaultProperty("Maximum"), DefaultEvent("ValueChanged")>
<Description("Provider a base control for data input."), Designer(GetType(DataInputItemDesigner)), DefaultProperty("Key")>
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
    'Private _ToolTip As ToolTip

    Public Sub New()
        InitializeComponent()

    End Sub

    Public MustOverride Property Value As Object

    Public Property HeightFixed As Boolean = True
    Public Property ValueType As Type = StringType

    Public ReadOnly Property TypeMatch As Boolean
        Get
            Return Value.GetType Is ValueType
        End Get
    End Property

    Public Overridable Property IsReadOnly As Boolean
        Get
            Return _IsReadOnly
        End Get
        Set(value As Boolean)
            _IsReadOnly = value
            If _IsReadOnly Then
                Checker.Enabled = False
                ClearButton.Enabled = False
                ExtendButton.Enabled = False
            Else
                Checker.Enabled = True
                ClearButton.Enabled = True
                ExtendButton.Enabled = True
            End If
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
            If _UseChecker Then
                Checker.Hide()
                ColumnStyles.Item(0).Width = 0
            Else
                ColumnStyles.Item(0).Width = 25
                Checker.Show()
            End If
        End Set
    End Property

    Public Overridable Property UseClearButton As Boolean
        Get
            Return _UseClearButton
        End Get
        Set(value As Boolean)
            _UseClearButton = value
            If _UseClearButton Then
                ClearButton.Hide()
                ColumnStyles.Item(4).Width = 0
            Else
                ColumnStyles.Item(4).Width = 25
                ClearButton.Show()
            End If
        End Set
    End Property

    Public Overridable Property CanExtend As Boolean
        Get
            Return _CanExtend
        End Get
        Set(value As Boolean)
            _CanExtend = value
            If _CanExtend Then
                ExtendButton.Hide()
                ColumnStyles.Item(5).Width = 0
            Else
                ColumnStyles.Item(5).Width = 25
                ExtendButton.Show()
            End If
        End Set
    End Property

    Public Overridable Property ToolTip As ToolTip
        Get
            Return Nothing
        End Get
        Set(value As ToolTip)
            '_ToolTip = value

            value.SetToolTip(Me.Checker, "")
            value.SetToolTip(Me.SubjectLabel, "")
            value.SetToolTip(Me.ClearButton, "")
            value.SetToolTip(Me.ExtendButton, "")
        End Set
    End Property

    Private Sub InitializeComponent()
        Me.Checker = New CheckBox()
        Me.SubjectLabel = New Label()
        'Me.InputBox = New TextBox()
        Me.ClearButton = New Button()
        Me.ExtendButton = New Button()
        'Me.Tips = New ToolTip(Me)
        'Me.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.ColumnCount = 6
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0!))
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 60.0!))
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0!))
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0!))
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0!))
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0!))
        Me.Controls.Add(Me.Checker, 0, 0)
        Me.Controls.Add(Me.SubjectLabel, 1, 0)
        'Me.Controls.Add(Me.InputBox, 2, 0)
        Me.Controls.Add(Me.ClearButton, 4, 0)
        Me.Controls.Add(Me.ExtendButton, 5, 0)
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(0, 0)
        Me.Margin = New Padding(0)
        Me.Name = "RootPanel"
        Me.RowCount = 3
        Me.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0!))
        Me.RowStyles.Add(New RowStyle(SizeType.Percent, 0!))
        Me.RowStyles.Add(New RowStyle(SizeType.Percent, 0!))
        Me.Size = New Size(300, 25)
        Me.TabIndex = 0
        Me.CanCheck = True
        Me.CanExtend = True
        Me.UseClearButton = True
        '
        'Checker
        '
        Me.Checker.Anchor = AnchorStyles.None
        Me.Checker.AutoSize = True
        Me.Checker.FlatAppearance.BorderSize = 0
        Me.Checker.FlatStyle = FlatStyle.Flat
        Me.Checker.Location = New Point(6, 7)
        Me.Checker.Name = "Checker"
        Me.Checker.Size = New Size(12, 11)
        Me.Checker.TabIndex = 0
        Me.Checker.UseVisualStyleBackColor = True
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Dock = DockStyle.Fill
        Me.SubjectLabel.Location = New Point(28, 0)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New Size(54, 25)
        Me.SubjectLabel.TabIndex = 1
        Me.SubjectLabel.Text = "Subject"
        Me.SubjectLabel.TextAlign = ContentAlignment.MiddleLeft
        '
        'InputBox
        '
        'Me.InputBox.Dock = DockStyle.Fill
        'Me.InputBox.Location = New Point(86, 1)
        'Me.InputBox.Margin = New Padding(1)
        'Me.InputBox.Name = "InputBox"
        'Me.InputBox.Size = New Size(80, 23)
        'Me.InputBox.TabIndex = 2
        '
        'ClearButton
        '
        Me.ClearButton.Location = New Point(250, 1)
        Me.ClearButton.Margin = New Padding(1)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New Size(23, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExtendButton
        '
        Me.ExtendButton.Location = New Point(275, 1)
        Me.ExtendButton.Margin = New Padding(1)
        Me.ExtendButton.Name = "ExtendButton"
        Me.ExtendButton.Size = New Size(23, 23)
        Me.ExtendButton.TabIndex = 4
        Me.ExtendButton.UseVisualStyleBackColor = True
        '
        'DataInputItemSample
        '
        'Me.AutoScaleDimensions = New SizeF(7.0!, 17.0!)
        'Me.AutoScaleMode = AutoScaleMode.Font
        'Me.Controls.Add(Me)
        Me.Font = New Font("Microsoft YaHei UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New Padding(3, 4, 3, 4)
        Me.Name = "DataInputItemSample"
        'Me.Size = New Size(300, 25)
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

    Friend WithEvents InputBox As TextBox

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub InitializeComponent()
        Me.InputBox = New TextBox
        Me.SuspendLayout()
        Me.Controls.Add(Me.InputBox, 2, 0)
        '
        'InputBox
        '
        Me.SetColumnSpan(Me.InputBox, 2)
        Me.InputBox.Dock = DockStyle.Fill
        Me.InputBox.HideSelection = False
        Me.InputBox.Location = New Point(86, 1)
        Me.InputBox.Margin = New Padding(1)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New Size(162, 23)
        Me.InputBox.TabIndex = 2

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Public Overrides Property Value As Object
        Get
            Return InputBox.Text
        End Get
        Set(value As Object)
            InputBox.Text = value
        End Set
    End Property

    Public Overrides Property IsReadOnly As Boolean
        Get
            Return MyBase.IsReadOnly
        End Get
        Set(value As Boolean)
            MyBase.IsReadOnly = value

            If MyBase.IsReadOnly Then
                InputBox.ReadOnly = True
            Else
                InputBox.ReadOnly = False
            End If
        End Set
    End Property

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged
        RaiseEvent ValueChanged(Me, e)
    End Sub

    Private Sub DataInputTextItem_ClearButtonClick(sender As Object, e As EventArgs) Handles Me.ClearButtonClick
        InputBox.Clear()
    End Sub

    Public Event ValueChanged(sender As Object, e As EventArgs)
End Class