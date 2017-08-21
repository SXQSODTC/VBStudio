Public Class KzSlideBar

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。


    End Sub

    Public Property Title As String
        Get
            Return TitleLabel.Text
        End Get
        Set(value As String)
            TitleLabel.Text = value
        End Set
    End Property

    Public Property TitleWidth As Integer
        Get
            Return RootPanel.ColumnStyles(0).Width
        End Get
        Set(value As Integer)
            RootPanel.ColumnStyles(0).Width = value
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return Bar.Maximum
        End Get
        Set(value As Integer)
            Bar.Maximum = value
            NumberUD.Maximum = value
        End Set
    End Property

    Public Property Minimum As Integer
        Get
            Return Bar.Minimum
        End Get
        Set(value As Integer)
            Bar.Minimum = value
            NumberUD.Minimum = value
        End Set
    End Property

    Public Property Value As Integer
        Get
            Return Bar.Value
        End Get
        Set(value As Integer)
            Bar.Value = value
            NumberUD.Value = value
        End Set
    End Property

    Public Property NumberWidth As Integer
        Get
            Return RootPanel.ColumnStyles(2).Width
        End Get
        Set(value As Integer)
            RootPanel.ColumnStyles(2).Width = value
        End Set
    End Property

    Public Property TickStyle As TickStyle
        Get
            Return Bar.TickStyle
        End Get
        Set(value As TickStyle)
            Bar.TickStyle = value
        End Set
    End Property

    Public Property TickFrequency As Integer
        Get
            Return Bar.TickFrequency
        End Get
        Set(value As Integer)
            Bar.TickFrequency = value
        End Set
    End Property

    Private Sub NumberUD_ValueChanged(sender As Object, e As EventArgs) Handles NumberUD.ValueChanged
        Bar.Value = NumberUD.Value
        'RaiseEvent ValueChanged(Me, e)
    End Sub

    Private Sub Bar_Scroll(sender As Object, e As EventArgs) Handles Bar.Scroll
        NumberUD.Value = Bar.Value
    End Sub

    Private Sub Bar_ValueChanged(sender As Object, e As EventArgs) Handles Bar.ValueChanged
        RaiseEvent ValueChanged(Me, e)
    End Sub

    Private Sub Bar_MouseEnter(sender As Object, e As EventArgs) _
        Handles RootPanel.MouseEnter, TitleLabel.MouseEnter, Bar.MouseEnter, NumberUD.MouseEnter

        RaiseEvent MouseEnter(Me, e)
    End Sub

    Private Sub Bar_MouseLeave(sender As Object, e As EventArgs) _
        Handles RootPanel.MouseLeave, TitleLabel.MouseLeave, Bar.MouseLeave, NumberUD.MouseLeave

        RaiseEvent MouseLeave(Me, e)
    End Sub

    Private Sub NumberUD_MouseDown(sender As Object, e As MouseEventArgs) Handles NumberUD.MouseDown
        If e.Button = MouseButtons.Left Then
            NumberUD.Select(0, 3)
        End If
        RaiseEvent MouseEnter(Me, New EventArgs)
    End Sub

    Private Sub NumberUD_MouseMove(sender As Object, e As MouseEventArgs) Handles NumberUD.MouseMove
        RaiseEvent MouseEnter(Me, New EventArgs)
    End Sub

    Private Sub NumberUD_TextChanged(sender As Object, e As EventArgs) Handles NumberUD.TextChanged
        RaiseEvent MouseEnter(Me, New EventArgs)
    End Sub

    Private Sub NumberUD_Enter(sender As Object, e As EventArgs) Handles NumberUD.Enter
        NumberUD.Select(0, 3)
    End Sub

    Public Event ValueChanged(sender As Object, e As EventArgs)
    Public Shadows Event MouseEnter(sender As Object, e As EventArgs)
    Public Shadows Event MouseLeave(sender As Object, e As EventArgs)

    'Protected Overrides Sub OnGotFocus(e As EventArgs)
    '    MyBase.OnGotFocus(e)

    '    NumberUD.Focus()
    'End Sub
End Class
