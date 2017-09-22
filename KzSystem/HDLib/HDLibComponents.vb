Imports System.IO
Imports System.Text
Imports KzSystem

Public Module HDLibPublic
    Public Const LineSeparator As Char = "|"
    Public Const ItemSeparator As Char = ";"
    Public Const KeySeparator As Char = ":"

    Public Function GetFileType(extension As String) As String
        Select Case extension.ToLower
            Case ".updb", ".pdb", ".prc", ".mobi", ".epub"
                Return "書籍"' "Package"
            Case ".doc", ".docx", ".txt", ".rtf"
                Return "文檔" '"Editable"
            Case ".pdf", ".djvu"
                Return "發佈" '"Published"
            Case ".html", ".htm", ".lnk"
                Return "網頁" '"Webpage"
            Case ".jpg", ".jepg", ".png", ".bmp", ".tif", ".tiff", ".gif"
                Return "圖像" '"Image"
            Case ".kzinf", ".inf", ".info", ".ini", ".kzlst"
                Return "資訊" '"Libinfo"
            Case ".rar", ".zip", ".7z"
                Return "壓縮" '"Compressed"
            Case ".avi", ".mkv", ".mov", ".ts", ".rmvb", ".mp4"
                Return "視訊"
            Case ".mp3", ".flac", ".wav"
                Return "音訊"
            Case Else
                Return "-"
        End Select
    End Function

    'Public Function MIT(MITType As HDManifestLineType, Optional InChs As Boolean = False) As String
    '    Select Case MITType
    '        Case HDManifestLineType.Unknown : Return If(InChs, "未知”, "未知")
    '        Case HDManifestLineType.LibInfo : Return If(InChs, "庫資訊”, "库信息")
    '        Case HDManifestLineType.Package : Return If(InChs, "封裝檔”, "封装文件")
    '        Case HDManifestLineType.Editable : Return If(InChs, "編輯檔”, "编辑文件")
    '        Case HDManifestLineType.Printable : Return If(InChs, "印刷檔”, "印刷文件")
    '        Case HDManifestLineType.WebView : Return If(InChs, "瀏覽檔”, "浏览文件")
    '        Case HDManifestLineType.Image : Return If(InChs, "圖像”, "图像")
    '        Case HDManifestLineType.Video : Return If(InChs, "視訊”, "视频")
    '        Case HDManifestLineType.Audio : Return If(InChs, "音訊”, "音频")
    '        Case HDManifestLineType.Compressed : Return If(InChs, "壓縮檔”, "压缩文件")
    '        Case Else : Return If(InChs, "其他”, "其他")
    '    End Select
    'End Function

    'Public Function CMIT(extension As String) As HDManifestLineType
    '    Select Case extension.ToLower
    '        Case ".updb", ".prc", ".mobi", ".epub"
    '            Return HDManifestLineType.Package ' "書籍"' "Package"
    '        Case ".doc", ".docx", ".txt", ".rtf"
    '            Return HDManifestLineType.Editable ' "文檔" '"Editable"
    '        Case ".pdf", ".djvu"
    '            Return HDManifestLineType.Printable ' "發佈" '"Published"
    '        Case ".html", ".htm", ".lnk"
    '            Return HDManifestLineType.WebView ' "網頁" '"Webpage"
    '        Case ".jpg", ".jepg", ".png", ".bmp", ".tif", ".tiff", ".gif"
    '            Return HDManifestLineType.Image ' "圖像" '"Image"
    '        Case ".kzinf", ".kzlst", ".inf", ".info", ".ini"
    '            Return HDManifestLineType.LibInfo ' "資訊" '"Libinfo"
    '        Case ".rar", ".zip", ".7z"
    '            Return HDManifestLineType.Compressed ' "壓縮" '"Compressed"
    '        Case ".avi", ".mkv", ".mov", ".ts", ".rmvb", ".mp4"
    '            Return HDManifestLineType.Video ' "視訊"
    '        Case ".mp3", ".flac", ".wav"
    '            Return HDManifestLineType.Audio ' "音訊"
    '        Case ""
    '            Return HDManifestLineType.Unknown
    '        Case Else
    '            Return HDManifestLineType.Others
    '    End Select
    'End Function

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
    Implements IComparable, IEquatable(Of HDLibInf)

    Public Sub New()
        Created = Now()
        Updated = Now()
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

    Public Overloads Function Equals(other As HDLibInf) As Boolean Implements IEquatable(Of HDLibInf).Equals
        Try
            If Address = other.Address And Author = other.Author And
                Category = other.Category And Contributor = other.Contributor And
                Description = other.Description And ID = other.ID And
                Language = other.Language And Logo = other.Logo And
                Name = other.Name And Origin = other.Origin And
                RefAddress = other.RefAddress And Remarks = other.Remarks And
                Series = other.Series And Special = other.Special And
                Type = other.Type And Version = other.Version Then

                Return True
            Else
                Return False
            End If

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

    Public Property Remarks As String
    Public Property Origin As String
    Public Property Series As String
    Public Property SID As Integer
    Public Property Author As String
    Public Property RefAddress As String
    Public Property Contributor As String
    Public Property Language As String
    Public Property Version As String
    Public Property Category As String
    Public Property Special As String

    Public Property Manifest As HDList
    Public Property Links As HDList

    Public ReadOnly Property IsEmpty As Boolean
        Get
            Return Me.Equals(New HDLibInf)
        End Get
    End Property

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
        sb.AppendLine("Origin: " & Origin)
        sb.AppendLine("Series: " & Series)
        sb.AppendLine("SID: " & If(Series Is Nothing Or Series.Trim.Length <= 0 Or SID <= 0, "-1", SID.ToString))
        sb.AppendLine("Author: " & Author)
        sb.AppendLine("Refaddress: " & RefAddress)
        sb.AppendLine("Contributor: " & Contributor)
        sb.AppendLine("Language: " & Language)
        sb.AppendLine("Version: " & Version)
        sb.AppendLine("Category: " & Category)
        sb.AppendLine("Special: " & Special)
        sb.AppendLine(If(Me.Type = HDLibInfType.BookInfo, "Cover: ", "Logo: ") & Logo)
        sb.AppendLine("Address: " & Address)
        sb.AppendLine("Created: " & Created.ToString)
        sb.AppendLine("Updated: " & Updated.ToString)
        Try
            If Manifest.Count > 0 Then
                sb.AppendLine("Manifest: ")
                sb.Append(Manifest.ToString)
                sb.AppendLine("#Manifest")
            End If
        Catch ex As Exception

        End Try
        Try
            If Links.Count > 0 Then
                sb.AppendLine("Links: ")
                sb.Append(Links.ToString)
                sb.AppendLine("#Links")
            End If
        Catch ex As Exception

        End Try
        sb.AppendLine(If(Me.Type = HDLibInfType.BookInfo, "Remarks: ", "Subject: ") & Remarks)
        sb.AppendLine(If(Me.Type = HDLibInfType.BookInfo, "Intro: ", "Description: "))
        sb.AppendLine(Description)
        Return sb.ToString
    End Function

    Public Sub Export(Folder As String)
        Dim di As DirectoryInfo
        Dim fs As FileInfo()
        Try
            di = New DirectoryInfo(Folder)
            fs = di.GetFiles("*.kzinf", SearchOption.TopDirectoryOnly)

            If fs.Count > 1 Then
                For Each f As FileInfo In fs
                    If f.Name <> FileName Then
                        f.Delete()
                    End If
                Next
            ElseIf fs.Count = 1 Then
                If fs(0).Name <> FileName Then
                    fs(0).Delete()
                End If
            End If

            Updated = Now()
            File.WriteAllText(Path.Combine(Folder, FileName), ToString(), Encoding.UTF8)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Import(Folder As String)
        Dim di As DirectoryInfo
        Dim fn As String

        Try
            di = New DirectoryInfo(Folder)
            fn = di.GetFiles("*.kzinf", SearchOption.TopDirectoryOnly)(0).FullName
            'MsgBox(fn)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Using fs As FileStream = New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, key, value As String
                    Dim pos As Integer

                    Do
                        line = sr.ReadLine()

                        If line.Contains(":") Then
                            pos = line.IndexOf(":")
                            key = line.Substring(0, pos)
                            value = line.Substring(pos + 1).Trim

                            Select Case key
                                Case "Type" : Type = [Enum].Parse(GetType(HDLibInfType), value)
                                Case "ID" : ID = value
                                Case "Title", "Name" : Name = value
                                Case "Origin" : Origin = value
                                Case "Series" : Series = value
                                Case "SID"
                                    Try
                                        SID = value
                                    Catch ex As Exception
                                        SID = -1
                                    End Try
                                Case "Author" : Author = value
                                Case "Refaddress" : RefAddress = value
                                Case "Contributor" : Contributor = value
                                Case "Language" : Language = value
                                Case "Version" : Version = value
                                Case "Category" : Category = value
                                Case "Special" : Special = value
                                Case "Cover", "Logo" : Logo = value
                                Case "Address" : Address = value
                                Case "Created" : Created = CDate(value)
                                Case "Updated" : Updated = CDate(value)
                                Case "Manifest"
                                    Manifest = New HDList
                                    Do
                                        line = sr.ReadLine()
                                        Manifest.ImportLine(line)
                                    Loop Until line = "#Manifest"
                                Case "Links"
                                    Links = New HDList
                                    Do
                                        line = sr.ReadLine()
                                        Links.ImportLine(line)
                                    Loop Until line = "#Links"
                                Case "Subject", "Remarks" : Remarks = value
                                Case "Intro", "Description" : Description = sr.ReadToEnd
                            End Select
                        End If
                    Loop Until sr.EndOfStream
                End Using
            End Using
            'MsgBox("Import successed.")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

End Class

Public Class HDList
    Inherits Dictionary(Of String, String)

    Public Sub New()

    End Sub

    Public Property KeyHolder As KzBracketsPair = KzBrackets.AngleBrackets

    Public Sub ImportLine(line As String)
        If line.Contains(KeyHolder.OpenChar) AndAlso line.Contains(KeyHolder.CloseChar) Then
            Dim key, value As String
            key = line.Substring(1, line.IndexOf(KeyHolder.CloseChar) - 1)
            value = line.Substring(line.IndexOf(KeyHolder.CloseChar) + 1)
            Add(key, value)
        End If
    End Sub

    Public Sub ImportLines(lines As String())
        For Each l As String In lines
            ImportLine(l)
        Next
    End Sub

    Public Function ToLine(pair As KeyValuePair(Of String, String)) As String
        Return KeyHolder.OpenChar & pair.Key & KeyHolder.CloseChar & pair.Value
    End Function

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        For Each kvp As KeyValuePair(Of String, String) In Me
            sb.AppendLine(ToLine(kvp))
        Next

        Return sb.ToString
    End Function
End Class

Public Structure KzBrackets
    Public Shared ReadOnly Property Parentheses As KzBracketsPair
        Get
            Return New KzBracketsPair("(", ")")
        End Get
    End Property
    Public Shared ReadOnly Property Brackets As KzBracketsPair
        Get
            Return New KzBracketsPair("[", "]")
        End Get
    End Property
    Public Shared ReadOnly Property Braces As KzBracketsPair
        Get
            Return New KzBracketsPair("{", "}")
        End Get
    End Property
    Public Shared ReadOnly Property AngleBrackets As KzBracketsPair
        Get
            Return New KzBracketsPair("<", ">")
        End Get
    End Property
    Public Shared ReadOnly Property SingleQuote As KzBracketsPair
        Get
            Return New KzBracketsPair("'", "'")
        End Get
    End Property
    Public Shared ReadOnly Property DoubleQuote As KzBracketsPair
        Get
            Return New KzBracketsPair("""", """")
        End Get
    End Property
End Structure

Public Structure KzBracketsPair
    Public Sub New(OpenChar As Char, CloseChar As Char)
        Me.OpenChar = OpenChar
        Me.CloseChar = CloseChar
    End Sub

    Public Property OpenChar As Char
    Public Property CloseChar As Char
End Structure




'Public Enum HDManifestLineType
'    Unknown
'    LibInfo
'    Package
'    Editable
'    Printable
'    WebView
'    Image
'    Video
'    Audio
'    Compressed
'    Others
'End Enum


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

        sb.AppendLine("#HDLib_BookList")
        sb.AppendLine("Address: " & Address)
        sb.AppendLine("List: ")
        For Each line As HDBookListLine In Me
            sb.AppendLine(line.ToString)
        Next

        Return sb.ToString
    End Function

    Public Sub Export(Folder As String)
        Try
            File.WriteAllText(Path.Combine(Folder, "Books.kzlst"), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(folder As String)
        Dim fns As String = Path.Combine(folder, "Books.kzlst")
        Dim bl As HDBookListLine
        Try
            Using fs As FileStream = New FileStream(fns, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, key, value As String
                    Dim keys As String()

                    line = sr.ReadLine()
                    If line = "#HDLib_BookList" Then
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


Public Class HDBooksTable
    Inherits DataTable

    Public Sub New()

        Dim column As DataColumn

        column = New DataColumn With {.ColumnName = "Title", .DataType = Type.GetType("System.String")}
        Columns.Add(column)
        column = New DataColumn With {.ColumnName = "Series", .DataType = Type.GetType("System.String")}
        Columns.Add(column)
        column = New DataColumn With {.ColumnName = "Author", .DataType = Type.GetType("System.String")}
        Columns.Add(column)
        column = New DataColumn With {.ColumnName = "Category", .DataType = Type.GetType("System.String")}
        Columns.Add(column)
        column = New DataColumn With {.ColumnName = "Special", .DataType = Type.GetType("System.String")}
        Columns.Add(column)
        column = New DataColumn With {.ColumnName = "Address", .DataType = Type.GetType("System.String")}
        Columns.Add(column)
    End Sub

    'Public Property KeyType As HDBookListKeyType

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        For Each row As DataRow In Rows
            sb.AppendLine(row("Title") & "; " &
                          row("Series") & "; " &
                          row("Author") & "; " &
                          row("Category") & "; " &
                          row("Special") & "; " &
                          row("Address"))
        Next

        Return sb.ToString
    End Function

    Public Sub Export(Folder As String)
        Try
            File.WriteAllText(Path.Combine(Folder, "Books.kzlst"), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(Folder As String, Optional IsAppend As Boolean = False)
        Dim fns As String = Path.Combine(Folder, "Books.kzlst")

        If Not IsAppend Then Rows.Clear()

        Try
            Using fs As FileStream = New FileStream(fns, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line As String
                    Dim keys As String()
                    Dim row As DataRow

                    Do
                        line = sr.ReadLine()
                        keys = line.Split(";")

                        row = NewRow()
                        row("Title") = keys(0).Trim
                        row("Series") = keys(1).Trim
                        row("Author") = keys(2).Trim
                        row("Category") = keys(3).Trim
                        row("Special") = keys(4).Trim
                        row("Address") = keys(5).Trim

                        Rows.Add(row)
                    Loop Until sr.EndOfStream
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Sort(KeyType As HDBookListKeyType, Optional IsAsc As Boolean = True)
        Dim key, sorting As String

        Select Case KeyType
            Case HDBookListKeyType.Name : key = "Title"
            Case HDBookListKeyType.Series : key = "Series"
            Case HDBookListKeyType.Author : key = "Author"
            Case HDBookListKeyType.Category : key = "Category"
            Case HDBookListKeyType.Special : key = "Special"
            Case Else : key = ""
        End Select

        Dim dv As DataView = DefaultView
        If IsAsc Then
            sorting = key & " Asc"
        Else
            sorting = key & " Desc"
        End If

        If Not KeyType = HDBookListKeyType.Name Then
            If IsAsc Then
                sorting &= ",Title Asc"
            Else
                sorting &= ",Title Desc"
            End If
        End If

        dv.Sort = sorting

        Dim tb As DataTable = dv.ToTable()
        Rows.Clear()
        For Each row As DataRow In tb.Rows
            ImportRow(row)
        Next

        tb.Dispose()
    End Sub
End Class



