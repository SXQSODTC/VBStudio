Public Class KzColorSticker
    Private iArgb As Boolean

    Public Sub New(ByVal TheColor As Color)
        InitializeComponent()
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

    Private Sub MouseMoving(sender As Object, e As MouseEventArgs) Handles RootPanel.MouseMove, ColorButton.MouseMove, NameLabel.MouseMove, PropertyLabel.MouseMove
        Dim c As Color = Color.LightGray
        Me.RootPanel.BackColor = c
        'Me.NameLabel.BackColor = c
        'Me.PropertyLabel.BackColor = c
        Me.ColorButton.FlatAppearance.BorderColor = c
        Me.ColorButton.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub PropertyLabel_MouseLeave(sender As Object, e As EventArgs) Handles RootPanel.MouseLeave, ColorButton.MouseLeave, NameLabel.MouseLeave, PropertyLabel.MouseLeave
        Dim c As Color = Color.WhiteSmoke
        Me.RootPanel.BackColor = c
        'Me.NameLabel.BackColor = c
        'Me.PropertyLabel.BackColor = c
        Me.ColorButton.FlatAppearance.BorderColor = c
        Me.ColorButton.FlatAppearance.BorderSize = 0
    End Sub

    Public Event CheckedChanged(sender As Object, e As EventArgs)

End Class
