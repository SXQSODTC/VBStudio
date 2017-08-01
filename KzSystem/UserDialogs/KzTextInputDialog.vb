Public Class KzTextInputDialog

    Private iLong As Boolean

    Public Property Subject As String
        Get
            Return SubjectLabel.Text
        End Get
        Set(value As String)
            SubjectLabel.Text = value
        End Set
    End Property

    Public Property LongText As Boolean
        Get
            Return iLong
        End Get
        Set(value As Boolean)
            iLong = value
            SetBox()
        End Set
    End Property

    Private Sub SetBox()
        If iLong Then
            Height = 175
            With InputBox
                .Multiline = True
                .ScrollBars = ScrollBars.Vertical
                .Height = 23 * 3
            End With
        Else
            Height = 125
            With InputBox
                .Multiline = False
                .ScrollBars = ScrollBars.None
                .Height = 23
            End With
        End If
    End Sub

    Public ReadOnly Property Contents As String
        Get
            Return InputBox.Text
        End Get
    End Property
End Class