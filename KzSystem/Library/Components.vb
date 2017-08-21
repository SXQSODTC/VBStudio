Public Class KzTimeShift
    Dim iStart, iEnd As DateTime

    Public Sub New(Optional ByVal StartTime As DateTime = #1/1/1 0:00:00#)
        SetDefault(StartTime)
    End Sub

    Private Sub SetDefault(Optional ByVal StartTime As DateTime = #1/1/1 0:00:00#)
        Try
            If StartTime <= #0:00:00# Then
                iStart = Now()
            Else
                iStart = StartTime
            End If
        Catch ex As Exception
            iStart = Now()
        End Try

        iEnd = iStart
    End Sub

    Public Property StartTime As DateTime
        Get
            Return iStart
        End Get
        Set(value As DateTime)
            SetDefault(value)
        End Set
    End Property

    Public Property EndTime As DateTime
        Get
            Return iEnd
        End Get
        Set(value As DateTime)
            If iEnd < iStart Then
                iEnd = iStart
            Else
                iEnd = value
            End If
        End Set
    End Property

    Public ReadOnly Property Span As TimeSpan
        Get
            Return iEnd.Subtract(iStart)
        End Get
    End Property

    Public ReadOnly Property SpanText As String
        Get
            Dim Unit As String()
            If InChinese Then
                Unit = {"日"， "時", "分", "秒", "微秒"}
            Else
                Unit = {"D"， "h", "m", "s", "ms"}
            End If

            Dim sb As New System.Text.StringBuilder

            With Me.Span
                If .Days > 0 Then
                    sb.Append(" " & .Days.ToString & " " & Unit(0))
                End If

                If .Hours > 0 Then
                    sb.Append(" " & .Hours.ToString & " " & Unit(1))
                End If

                If .Minutes > 0 Then
                    sb.Append(" " & .Minutes.ToString & " " & Unit(2))
                End If

                If .Seconds > 0 Then
                    sb.Append(" " & .Seconds.ToString & " " & Unit(3))
                End If

                sb.Append(" " & .Milliseconds.ToString & " " & Unit(4))
            End With

            If WithoutSpace Then
                sb.Replace(" ", "")
            End If

            Return sb.ToString
        End Get
    End Property

    Public Property InChinese As Boolean = False
    Public Property WithoutSpace As Boolean = False
End Class 'KzTimeShift

