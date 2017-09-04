Imports System.IO
Imports System.Text

Public Module HDLibPublic
    Public Const LineSeparator As Char = "|"
    Public Const ItemSeparator As Char = ";"
    Public Const KeySeparator As Char = ":"

    Public Function MIT(MITType As HDManifestLineType, Optional InChs As Boolean = False) As String
        Select Case MITType
            Case HDManifestLineType.Unknown : Return If(InChs, "未知”, "未知")
            Case HDManifestLineType.LibInfo : Return If(InChs, "庫資訊”, "库信息")
            Case HDManifestLineType.Package : Return If(InChs, "封裝檔”, "封装文件")
            Case HDManifestLineType.Editable : Return If(InChs, "編輯檔”, "编辑文件")
            Case HDManifestLineType.Printable : Return If(InChs, "印刷檔”, "印刷文件")
            Case HDManifestLineType.WebView : Return If(InChs, "瀏覽檔”, "浏览文件")
            Case HDManifestLineType.Image : Return If(InChs, "圖像”, "图像")
            Case HDManifestLineType.Video : Return If(InChs, "視訊”, "视频")
            Case HDManifestLineType.Audio : Return If(InChs, "音訊”, "音频")
            Case HDManifestLineType.Compressed : Return If(InChs, "壓縮檔”, "压缩文件")
            Case Else : Return If(InChs, "其他”, "其他")
        End Select
    End Function

    Public Function CMIT(extension As String) As HDManifestLineType
        Select Case extension.ToLower
            Case ".updb", ".prc", ".mobi", ".epub"
                Return HDManifestLineType.Package ' "書籍"' "Package"
            Case ".doc", ".docx", ".txt", ".rtf"
                Return HDManifestLineType.Editable ' "文檔" '"Editable"
            Case ".pdf", ".djvu"
                Return HDManifestLineType.Printable ' "發佈" '"Published"
            Case ".html", ".htm", ".lnk"
                Return HDManifestLineType.WebView ' "網頁" '"Webpage"
            Case ".jpg", ".jepg", ".png", ".bmp", ".tif", ".tiff", ".gif"
                Return HDManifestLineType.Image ' "圖像" '"Image"
            Case ".kzinf", ".kzlst", ".inf", ".info", ".ini"
                Return HDManifestLineType.LibInfo ' "資訊" '"Libinfo"
            Case ".rar", ".zip", ".7z"
                Return HDManifestLineType.Compressed ' "壓縮" '"Compressed"
            Case ".avi", ".mkv", ".mov", ".ts", ".rmvb", ".mp4"
                Return HDManifestLineType.Video ' "視訊"
            Case ".mp3", ".flac", ".wav"
                Return HDManifestLineType.Audio ' "音訊"
            Case ""
                Return HDManifestLineType.Unknown
            Case Else
                Return HDManifestLineType.Others
        End Select
    End Function

    Public Function CFile(type As Type) As String
        'If type = GetType(HDBookInf) Then Return "Book.kzinf"
        If type = GetType(HDManifest) Then Return "Manifest.kzlst"
        If type = GetType(HDLinkList) Then Return "Links.kzlst"
        If type = GetType(HDBookList) Then Return "Books.kzlst"
        'If type = GetType(HDLibInf) Then Return "Lib.kzinf"
        Return Nothing
    End Function

    Public Function CMeta(type As Type) As String
        'If type = GetType(HDBookInf) Then Return "#HDLib_BookInfo"
        If type = GetType(HDManifest) Then Return "#HDLib_Manifest"
        If type = GetType(HDLinkList) Then Return "#HDLib_LinkList"
        If type = GetType(HDBookList) Then Return "#HDLib_BookList"
        'If type = GetType(HDLibInf) Then Return "#HDLib_Info"
        Return Nothing
    End Function
End Module

Public Enum HDLibInfType
    LibInfo
    BookInfo
    AuthorInfo
    CategoryInfo
    SpecialInfo
    SeriesInfo
    OtherInfo
End Enum

Public Class HDLibInf
    Implements IComparable

    Public Sub New()

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If obj Is Nothing Then Return 1

        Try
            Dim otherInf As HDLibInf = CType(obj, HDLibInf)
            Return Name.CompareTo(otherInf.Name)
        Catch ex As Exception
            Throw New NotImplementedException("Not implemented!")
        End Try
    End Function

    Public Property Type As HDLibInfType
    Public Property ID As String
    Public Property Name As String
    Public Property Address As String
    Public Property Logo As String
    Public Property Created As DateTime
    Public Property Updated As DateTime
    Public Property Description As String

    Public Property Subject As String
    Public Property Creator As String
    Public Property Series As String
    Public Property Author As String
    Public Property Contributor As String
    Public Property Language As String
    Public Property Version As String
    Public Property Category As String
    Public Property Special As String

    Public ReadOnly Property FileName As String
        Get
            Return CFile(Type)
        End Get
    End Property

    Public ReadOnly Property FileMeta As String
        Get
            Return CMeta(Type)
        End Get
    End Property

    Public ReadOnly Property ListLine As HDBookListLine
        Get
            Return New HDBookListLine With {
                .Name = Name,
                .Address = Address,
                .Series = Series,
                .Author = Author,
                .Category = Category,
                .Special = Special}
        End Get
    End Property

    Public Shared Function CFile(type As HDLibInfType) As String
        Select Case type
            Case HDLibInfType.AuthorInfo : Return "Author.kzinf"
            Case HDLibInfType.BookInfo : Return "Book.kzinf"
            Case HDLibInfType.CategoryInfo : Return "Category.kzinf"
            Case HDLibInfType.LibInfo : Return "Lib.kzinf"
            Case HDLibInfType.SeriesInfo : Return "Series.kzinf"
            Case HDLibInfType.SpecialInfo : Return "Special.kzinf"
            Case Else : Return Nothing
        End Select
    End Function

    Public Shared Function CMeta(type As HDLibInfType) As String
        Select Case type
            Case HDLibInfType.AuthorInfo : Return "#HDLib_AuthorInfo"
            Case HDLibInfType.BookInfo : Return "#HDLib_BookInfo"
            Case HDLibInfType.CategoryInfo : Return "#HDLib_CategoryInfo"
            Case HDLibInfType.LibInfo : Return "#HDLib_LibInfo"
            Case HDLibInfType.SeriesInfo : Return "#HDLib_SeriesInfo"
            Case HDLibInfType.SpecialInfo : Return "#HDLib_SpecialInfo"
            Case Else : Return Nothing
        End Select
    End Function

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.AppendLine(FileMeta)
        sb.AppendLine("Type: " & Type.ToString)
        sb.AppendLine("ID: " & ID)
        sb.AppendLine(If(Me.Type = HDLibInfType.BookInfo, "Title: ", "Name: ") & Name)
        sb.AppendLine("Subject: " & Subject)
        sb.AppendLine("Creator: " & Creator)
        sb.AppendLine("Series: " & Series)
        sb.AppendLine("Author: " & Author)
        sb.AppendLine("Contributor: " & Contributor)
        sb.AppendLine("Language: " & Language)
        sb.AppendLine("Version: " & Version)
        sb.AppendLine("Category: " & Category)
        sb.AppendLine("Special: " & Special)
        sb.AppendLine(If(Me.Type = HDLibInfType.BookInfo, "Cover: ", "Logo") & Logo)
        sb.AppendLine("Address: " & Address)
        sb.AppendLine("Created: " & Created.ToString)
        sb.AppendLine("Updated: " & Updated.ToString)
        sb.AppendLine(If(Me.Type = HDLibInfType.BookInfo, "Intro: ", "Description: "))
        sb.AppendLine(Description)
        Return sb.ToString
    End Function

    Public Sub Export(Folder As String)
        Try
            File.WriteAllText(Path.Combine(Folder, FileName), ToString(), Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(Folder As String)
        Dim fn As String = Path.Combine(Folder, FileName)
        Try
            Using fs As FileStream = New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, key, value As String
                    Dim pos As Integer

                    line = sr.ReadLine()
                    If line = FileMeta Then
                        Do
                            line = sr.ReadLine()

                            If line.Contains(":") Then
                                pos = line.IndexOf(":")
                                key = line.Substring(0, pos)
                                value = line.Substring(pos + 1).Trim

                                Select Case key
                                    Case "Type" : Type = [Enum].Parse(GetType(HDLibInfType), value)
                                    Case "ID" : ID = value
                                    Case "Title" Or "Name" : Name = value
                                    Case "Subject" : Subject = value
                                    Case "Creator" : Creator = value
                                    Case "Series" : Series = value
                                    Case "Author" : Author = value
                                    Case "Contributor" : Contributor = value
                                    Case "Language" : Language = value
                                    Case "Version" : Version = value
                                    Case "Category" : Category = value
                                    Case "Special" : Special = value
                                    Case "Cover" Or "Logo" : Logo = value
                                    Case "Address" : Address = value
                                    Case "Created" : Created = CDate(value)
                                    Case "Updated" : Updated = CDate(value)
                                    Case "Intro" Or "Description" : Description = sr.ReadToEnd
                                End Select
                            End If
                        Loop Until sr.EndOfStream
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub


End Class


Public Class HDManifest
    Inherits List(Of HDManifestLine)

    Public Sub New()

    End Sub

    Public Property Address As String

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        sb.AppendLine(CMeta(Me.GetType))
        sb.AppendLine("Address: " & Address)
        sb.AppendLine("List: ")
        For Each line As HDManifestLine In Me
            sb.AppendLine(line.ToString)
        Next

        Return sb.ToString
    End Function

    Public Sub Export(FolderPath As String)
        Try
            File.WriteAllText(Path.Combine(FolderPath, CFile(Me.GetType)), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(FolderPath As String)
        Dim fn As String = Path.Combine(FolderPath, CFile(Me.GetType))
        Dim ml As HDManifestLine
        Try
            Using fs As FileStream = New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, key, value As String
                    Dim keys As String()

                    line = sr.ReadLine()
                    If line = CMeta(Me.GetType) Then
                        Do
                            line = sr.ReadLine()
                            keys = line.Split(":")
                            key = keys(0)
                            value = keys(1).Trim

                            If key = "Address" Then
                                Address = value
                            ElseIf key = "List" Then
                                Do
                                    line = sr.ReadLine()
                                    keys = line.Split(ItemSeparator)

                                    ml = New HDManifestLine With {
                                        .FileName = keys(0).Trim,
                                        .Type = [Enum].Parse(GetType(HDManifestLineType), keys(1).Trim),
                                        .ReadingClass = keys(2).Trim,
                                        .ReadingIndex = keys(3).Trim,
                                        .Remarks = keys(4).Trim}
                                    Add(ml)
                                Loop Until sr.EndOfStream
                            End If
                        Loop Until sr.EndOfStream
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class HDManifestLine
    Implements IComparable

    Public Sub New()

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Throw New NotImplementedException()
    End Function

    Public Property FileName As String
    Public Property ReadingIndex As Integer = -1
    Public Property ReadingClass As String
    Public Property Type As HDManifestLineType = HDManifestLineType.Unknown
    Public Property Remarks As String

    Public Overrides Function ToString() As String
        Return FileName & ItemSeparator & " " &
            Type.ToString & ItemSeparator & " " &
            ReadingClass & ItemSeparator & " " &
            ReadingIndex.ToString & ItemSeparator & " " &
            Remarks
    End Function

    Public Sub Import(line As String)

    End Sub

End Class

Public Enum HDManifestLineType
    Unknown
    LibInfo
    Package
    Editable
    Printable
    WebView
    Image
    Video
    Audio
    Compressed
    Others
End Enum

Public Class HDLinkList
    Inherits Dictionary(Of String, String)

    Public Sub New()
        Add("Source", "")
        Add("Download", "")
        Add("Cover", "")
    End Sub

    Public Property Address As String

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        sb.AppendLine(CMeta(Me.GetType))
        sb.AppendLine("Address: " & Address)
        sb.Appendline("List: ")
        For Each kvp As KeyValuePair(Of String, String) In Me
            sb.AppendLine(kvp.Key.ToString & "<" & kvp.Value.ToString & ">")
        Next

        Return sb.ToString
    End Function

    Public Sub Export(Folder As String)
        Try
            File.WriteAllText(Path.Combine(Folder, CFile(Me.GetType)), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(Folder As String)
        Dim fns As String = Path.Combine(Folder, CFile(Me.GetType))

        Try
            Using fs As FileStream = New FileStream(fns, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, key, value As String
                    Dim keys As String()

                    line = sr.ReadLine()
                    If line = CMeta(Me.GetType) Then
                        Do
                            line = sr.ReadLine()
                            keys = line.Split(":")
                            key = keys(0)
                            value = keys(1).Trim

                            If key = "Address" Then
                                Address = value
                            ElseIf key = "List" Then
                                Do
                                    line = sr.ReadLine()

                                    keys = line.Split("<")
                                    key = keys(0)
                                    value = keys(1).Replace(">", "")

                                    Add(key, value)
                                Loop Until sr.EndOfStream
                            End If
                        Loop Until sr.EndOfStream
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class HDBookList
    Inherits List(Of HDBookListLine)
    Implements IComparer

    Private _KeyType As HDBookListKeyType

    Public Sub New()
        _KeyType = HDBookListKeyType.Name
    End Sub

    Public Property Address As String

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        sb.AppendLine(CMeta(Me.GetType))
        sb.AppendLine("Address: " & Address)
        sb.AppendLine("List: ")
        For Each line As HDBookListLine In Me
            sb.AppendLine(line.ToString)
        Next

        Return sb.ToString
    End Function

    Public Sub Export(Folder As String)
        Try
            File.WriteAllText(Path.Combine(Folder, CFile(Me.GetType)), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(folder As String)
        Dim fns As String = Path.Combine(folder, CFile(Me.GetType))
        Dim bl As HDBookListLine
        Try
            Using fs As FileStream = New FileStream(fns, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, key, value As String
                    Dim keys As String()

                    line = sr.ReadLine()
                    If line = CMeta(Me.GetType) Then
                        Do
                            line = sr.ReadLine()
                            keys = line.Split(":")
                            key = keys(0)
                            value = keys(1).Trim

                            If key = "Address" Then
                                Address = value
                            ElseIf key = "List" Then
                                Do
                                    line = sr.ReadLine()
                                    keys = line.Split(ItemSeparator)

                                    bl = New HDBookListLine With {
                                        .Name = keys(0).Trim,
                                        .Series = keys(1).Trim,
                                        .Author = keys(2).Trim,
                                        .Category = keys(3).Trim,
                                        .Special = keys(4).Trim,
                                        .Address = keys(5).Trim}
                                    Add(bl)
                                Loop Until sr.EndOfStream
                            End If
                        Loop Until sr.EndOfStream
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Public Function GetByKey(KeyType As HDBookListKeyType, Key As String,
                             Optional FullMatch As Boolean = True) As HDBookList

        Dim lst As New HDBookList
        For Each line As HDBookListLine In Me
            If FullMatch Then
                Select Case KeyType
                    Case HDBookListKeyType.Author
                        If line.Author = Key Then lst.Add(line)
                    Case HDBookListKeyType.Category
                        If line.Category = Key Then lst.Add(line)
                    Case HDBookListKeyType.Name
                        If line.Name = Key Then lst.Add(line)
                    Case HDBookListKeyType.Name
                        If line.Series = Key Then lst.Add(line)
                    Case HDBookListKeyType.Special
                        If line.Special = Key Then lst.Add(line)
                End Select
            Else
                Select Case KeyType
                    Case HDBookListKeyType.Author
                        If line.Author.Contains(Key) Then lst.Add(line)
                    Case HDBookListKeyType.Category
                        If line.Category.Contains(Key) Then lst.Add(line)
                    Case HDBookListKeyType.Name
                        If line.Name.Contains(Key) Then lst.Add(line)
                    Case HDBookListKeyType.Name
                        If line.Series.Contains(Key) Then lst.Add(line)
                    Case HDBookListKeyType.Special
                        If line.Special.Contains(Key) Then lst.Add(line)
                End Select
            End If
        Next
        Return lst
    End Function

    Public Function GetKeyList(KeyType As HDBookListKeyType) As List(Of String)
        Dim l As New List(Of String)

        For Each line As HDBookListLine In Me
            Select Case KeyType
                Case HDBookListKeyType.Author : l.Add(line.Author)
                Case HDBookListKeyType.Category : l.Add(line.Category)
                Case HDBookListKeyType.Series : l.Add(line.Series)
                Case HDBookListKeyType.Special : l.Add(line.Special)
                Case HDBookListKeyType.Name : l.Add(line.Name)
            End Select
        Next

        Return l.Distinct().ToList
    End Function

    Public Property KeyType As HDBookListKeyType
        Get
            Return _KeyType
        End Get
        Set(value As HDBookListKeyType)
            _KeyType = value
            Sort(AddressOf Compare)
        End Set
    End Property

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim lx As HDBookListLine = CType(x, HDBookListLine)
        Dim ly As HDBookListLine = CType(y, HDBookListLine)

        Select Case _KeyType
            Case HDBookListKeyType.Author
                Return Compare(lx.Author, ly.Author)
            Case HDBookListKeyType.Series
                Return Compare(lx.Series, ly.Series)
            Case HDBookListKeyType.Special
                Return Compare(lx.Special, ly.Special)
            Case Else
                Return Compare(lx.Name, ly.Name)
        End Select
    End Function
End Class

Public Class HDBookListLine
    Implements IComparable

    Private _KeyType As HDBookListKeyType

    Public Sub New(Optional SortingKey As HDBookListKeyType = HDBookListKeyType.Name)
        _KeyType = SortingKey
    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If obj Is Nothing Then Return 1

        Try
            Dim otherInf As HDBookListLine = CType(obj, HDBookListLine)

            Select Case _KeyType
                Case HDBookListKeyType.Author
                    Return Author.CompareTo(otherInf.Author)
                Case HDBookListKeyType.Series
                    Return Series.CompareTo(otherInf.Series)
                Case HDBookListKeyType.Special
                    Return Special.CompareTo(otherInf.Special)
                Case Else
                    Return Name.CompareTo(otherInf.Name)
            End Select
        Catch ex As Exception
            Throw New NotImplementedException("Not implemented!")
        End Try
    End Function

    Public Property Name As String
    Public Property Address As String
    Public Property Series As String
    Public Property Author As String
    Public Property Category As String
    Public Property Special As String

    Public Overrides Function ToString() As String
        Return Name & ItemSeparator & " " &
            Series & ItemSeparator & " " &
            Author & ItemSeparator & " " &
            Category & ItemSeparator & " " &
            Special & ItemSeparator & " " &
            Address
    End Function

End Class

Public Enum HDBookListKeyType
    All
    Name
    Series
    Author
    Category
    Special
End Enum

