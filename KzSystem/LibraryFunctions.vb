Public Class KzStr

    Public Shared Function ExCharWidth _
        (ByVal inputString As String,
         ByVal Optional isHalfToFull As Boolean = True)

        Dim c As Char() = inputString.ToCharArray
        Dim i As Integer = 0

        While inputString < c.Length
            If isHalfToFull Then
                '半角转全角
                If c(i) = ChrW(32) Then
                    c(i) = ChrW(12288)
                ElseIf AscW(c(i)) < 127 Then
                    c(i) = ChrW((AscW(c(i)) + 65248))
                End If

            Else
                '全角转半角
                If AscW(c(i)) = 12288 Then
                    c(i) = ChrW(32)
                ElseIf AscW(c(i)) > 65280 AndAlso AscW(c(i)) < 65375 Then
                    c(i) = ChrW(AscW(c(i)) - 65248)
                End If

            End If

            Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While

        Return New String(c)
    End Function

End Class

Public Class KzFont
    Public Shared Function Resize _
        (ByVal theFont As Font, ByVal value As Single,
         ByVal Optional isUpDown As Boolean = False) As Font

        If isUpDown Then
            Return New Font(theFont.FontFamily, theFont.Size + value, theFont.Style)
        Else
            Return New Font(theFont.FontFamily, value, theFont.Style)
        End If
    End Function

    Public Shared Function Restyle _
        (ByVal theFont As Font, ByVal value As FontStyle,
         ByVal Optional isAddMode As Boolean = False) As Font

        If isAddMode Then
            Return New Font(theFont.FontFamily, theFont.Size, theFont.Style Or value)
        Else
            Return New Font(theFont.FontFamily, theFont.Size, value)
        End If
    End Function
End Class

Public Class KzColor
    Public Shared Function Add _
        (ByVal color1 As Color, ByVal color2 As Color,
         ByVal Optional plus As Boolean = True) As Color

        Dim a, r, g, b As Byte

        If plus Then
            a = Math.Min(255, color1.A + color2.A)
            r = Math.Min(255, color1.R + color2.R)
            g = Math.Min(255, color1.G + color2.G)
            b = Math.Min(255, color1.B + color2.B)
        Else
            a = Math.Max(0, CType(color1.A, Short) - CType(color2.A, Short))
            r = Math.Max(0, CType(color1.R, Short) - CType(color2.R, Short))
            g = Math.Max(0, CType(color1.G, Short) - CType(color2.G, Short))
            b = Math.Max(0, CType(color1.B, Short) - CType(color2.B, Short))
        End If

        Return Color.FromArgb(a, r, g, b)
    End Function

    Public Shared Function ReChannel _
        (ByVal color As Color, ByVal argb As Char, ByVal value As Byte,
         ByVal Optional updown As Boolean = False) As Color

        Dim a, r, g, b As Byte
        a = color.A
        r = color.R
        g = color.G
        b = color.B

        Select Case argb
            Case "a" : a = If(updown, Math.Max(0, Math.Min(255, color.A + value)), value)
            Case "r" : r = If(updown, Math.Max(0, Math.Min(255, color.R + value)), value)
            Case "g" : g = If(updown, Math.Max(0, Math.Min(255, color.G + value)), value)
            Case "b" : b = If(updown, Math.Max(0, Math.Min(255, color.B + value)), value)
            Case Else
        End Select

        Return Color.FromArgb(a, r, g, b)
    End Function
End Class