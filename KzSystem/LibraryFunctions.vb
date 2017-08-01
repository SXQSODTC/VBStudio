Imports System.Net
Imports System.IO
Imports System.Text

Public Class KzStr
    ''' <summary>
    ''' Convert all half width char to full width in InputString
    ''' 半角轉全角
    ''' </summary>
    ''' <param name="InputString"></param>
    ''' <returns></returns>
    Public Shared Function CFullWidth(ByVal InputString As String) As String
        Dim c As Char() = InputString.ToCharArray
        Dim i As Integer = 0

        While InputString < c.Length
            If c(i) = ChrW(32) Then
                c(i) = ChrW(12288)
            ElseIf AscW(c(i)) < 127 Then
                c(i) = ChrW((AscW(c(i)) + 65248))
            End If

            Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While

        Return New String(c)
    End Function
    ''' <summary>
    ''' Convert full width char to half width in InputString if the char's half form exists.
    ''' 全角轉半角
    ''' </summary>
    ''' <param name="InputString"></param>
    ''' <returns></returns>
    Public Shared Function CHalfWidth(ByVal InputString As String) As String
        Dim c As Char() = InputString.ToCharArray
        Dim i As Integer = 0

        While InputString < c.Length
            If AscW(c(i)) = 12288 Then
                c(i) = ChrW(32)
            ElseIf AscW(c(i)) > 65280 AndAlso AscW(c(i)) < 65375 Then
                c(i) = ChrW(AscW(c(i)) - 65248)
            End If

            Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While

        Return New String(c)
    End Function


End Class 'KzStr

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
End Class 'KzFont

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
End Class 'KzColor

Public Class KzWeb
    ''' <summary>
    ''' Get source code from the html page indecated by URL string
    ''' </summary>
    ''' <param name="strURL"></param>
    ''' <returns></returns>
    Public Shared Function GetWebCode(ByVal strURL As String) As String
        Dim httpReq As System.Net.HttpWebRequest
        Dim httpResp As System.Net.HttpWebResponse
        Dim httpURL As New System.Uri(strURL)
        Dim ioS As System.IO.Stream, charSet As String, tCode As String
        Dim k() As Byte
        ReDim k(0)
        Dim dataQue As New Queue(Of Byte)
        httpReq = CType(WebRequest.Create(httpURL), HttpWebRequest)
        Dim sTime As Date = #1990-09-21 00:00:00# ' CDate("1990-09-21 00:00:00")
        httpReq.IfModifiedSince = sTime
        httpReq.Method = "GET"
        httpReq.Timeout = 7000

        Try
            httpResp = CType(httpReq.GetResponse(), HttpWebResponse)
        Catch
            Debug.Print("weberror")
            GetWebCode = "<title>no thing found</title>" : Exit Function
        End Try
        '以上为网络数据获取  
        ioS = CType(httpResp.GetResponseStream, Stream)
        Do While ioS.CanRead = True
            Try
                dataQue.Enqueue(ioS.ReadByte)
            Catch
                Debug.Print("read error")
                Exit Do
            End Try
        Loop
        ReDim k(dataQue.Count - 1)
        For j As Integer = 0 To dataQue.Count - 1
            k(j) = dataQue.Dequeue
        Next
        '以上，为获取流中的的二进制数据  
        tCode = Encoding.GetEncoding("UTF-8").GetString(k) '获取特定编码下的情况，毕竟UTF-8支持英文正常的显示  
        charSet = Replace(GetByDiv2(tCode, "charset=", """"), """", "") '进行编码类型识别  
        '以上，获取编码类型  
        If charSet = "" Then 'defalt  
            If httpResp.CharacterSet = "" Then
                tCode = Encoding.GetEncoding("UTF-8").GetString(k)
            Else
                tCode = Encoding.GetEncoding(httpResp.CharacterSet).GetString(k)
            End If
        Else
            tCode = Encoding.GetEncoding(charSet).GetString(k)
        End If
        Debug.Print(charSet)
        'Stop  
        '以上，按照获得的编码类型进行数据转换  
        '将得到的内容进行最后处理，比如判断是不是有出现字符串为空的情况  
        GetWebCode = tCode
        If tCode = "" Then GetWebCode = "<title>no thing found</title>"
    End Function

    Private Shared Function GetByDiv2(ByVal code As String, ByVal divBegin As String, ByVal divEnd As String)  '获取分隔符所夹的内容[完成，未测试]  
        '仅用于获取编码数据  
        Dim lgStart As Integer
        Dim lens As Integer
        Dim lgEnd As Integer
        lens = Len(divBegin)
        If InStr(1, code, divBegin) = 0 Then GetByDiv2 = "" : Exit Function
        lgStart = InStr(1, code, divBegin) + CInt(lens)

        lgEnd = InStr(lgStart + 1, code, divEnd)
        If lgEnd = 0 Then GetByDiv2 = "" : Exit Function
        GetByDiv2 = Mid(code, lgStart, lgEnd - lgStart)
    End Function
End Class 'KzWeb