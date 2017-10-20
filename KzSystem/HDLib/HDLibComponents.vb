Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
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
                Category = other.Category And InternalRef = other.InternalRef And
                Description = other.Description And ID = other.ID And
                Origin = other.Origin And Logo = other.Logo And
                Name = other.Name And Origin = other.Origin And
                ExternalRef = other.ExternalRef And Remarks = other.Remarks And
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
    Public Property ExternalRef As String
    Public Property InternalRef As String
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
        sb.AppendLine(If(Me.Type = HDLibInfType.CategoryInfo, "Prifix: ", "Series: ") & Series)
        sb.AppendLine(If(Me.Type = HDLibInfType.CategoryInfo, "Max: ", "SID: ") & SID.ToString) ' If(Series Is Nothing Or Series.Trim.Length <= 0 Or SID <= 0, "-1", SID.ToString))
        sb.AppendLine("Author: " & Author)
        sb.AppendLine("ExternalRef: " & ExternalRef)
        sb.AppendLine("InternalRef: " & InternalRef)
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

            If fs.Count > 0 Then
                For Each f As FileInfo In fs
                    If f.Name <> FileName Then
                        f.Delete()
                    End If
                Next
            End If

            Updated = Now()
            File.WriteAllText(Path.Combine(Folder, FileName), ToString(), Encoding.UTF8)
        Catch ex As Exception
            MsgBox("未能創建或寫入資訊檔。原因：" & vbCrLf & ex.Message)
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
                                Case "Series", "Prefix" : Series = value
                                Case "SID", "Max"
                                    Try
                                        SID = value
                                    Catch ex As Exception
                                        SID = -1
                                    End Try
                                Case "Author" : Author = value
                                Case "ExternalRef", "Refaddress" : ExternalRef = value
                                Case "InternalRef", "Contributor" : InternalRef = value
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

    Public Sub FromCategoryLine(line As String)
        Try
            Dim keys As String() = line.Split("|")
            ID = keys(2).Trim
            Name = keys(1).Trim
            Series = keys(0)
            SID = keys(3).Trim
            ExternalRef = HDSrc.CategoryMainPage.Replace("{mark}", ID)

            Try
                Links = New HDList
                For i As Integer = 1 To SID
                    Links.Add("P" & i.ToString, HDSrc.CategorySplitPage.Replace("{mark}", ID).Replace("{idx}", i))
                Next
            Catch ex As Exception

            End Try

            Type = HDLibInfType.CategoryInfo
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FromBooksLine(line As String)
        Try
            Dim keys As String() = line.Split("|")
            Category = keys(0)
            Author = keys(1)
            ID = keys(2)
            Name = keys(3)
            Version = keys(4)
            ExternalRef = keys(5)
            Type = HDLibInfType.BookInfo
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FromAuthorLine(line As String)

    End Sub

    Public Sub FromDBLine(line As String)

    End Sub

    Public Function ToCategoryLine() As String
        If Type = HDLibInfType.CategoryInfo Then
            Return Series & "|" & Name & "|" & ID & "|" & SID
        Else
            Return Nothing
        End If
    End Function

    Public Function ToBooksLine() As String
        If Type = HDLibInfType.BookInfo Then
            Return Category & "|" & Author & "|" & ID & "|" & Name & "|" & Version & "|" & ExternalRef
        Else
            Return Nothing
        End If
    End Function

    Public Function ToAuthorLine() As String
        If Type = HDLibInfType.AuthorInfo Then
            Return ""
        Else
            Return Nothing
        End If
    End Function

    Public Function ToDBLine() As String
        Return ""
    End Function

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

Public Class HDLibHelper
    Public Shared Function GetHDList(source As String) As String
        Dim sb As New StringBuilder

        Dim ARgx As New Regex("<font color=""CC0000"">.{2,15}?</font>.{0,25}?<br>|<font color=""CC0000"">.{2,15}?</font><a")
        Dim AMts As MatchCollection = ARgx.Matches(source)
        Dim BRgx As New Regex("=.{2,8}?"">《.+?》|=.{2,8}?"">【.+?】")
        Dim BMts As MatchCollection
        Dim AMt, BMt As Match
        Dim thisI, nextI As Integer
        Dim at, author, title, id As String

        Dim category As String = Regex.Match(source, "SetTitle\("".{3,6}""\)").ToString.Replace("SetTitle(""", "").Replace(""")", "")

        For Each AMt In AMts
            thisI = AMt.Index
            If AMt.NextMatch IsNot Nothing Then
                nextI = AMt.NextMatch.Index
                If nextI < thisI Then
                    nextI = source.Length
                End If
            Else
                nextI = source.Length
            End If
            author = Regex.Replace(AMt.ToString.Replace("<a", ""), "<.+?>", "")
            at = source.Substring(thisI, nextI - thisI)
            BMts = BRgx.Matches(at)
            For Each BMt In BMts
                title = BMt.ToString.Replace("=", "").Replace(""">【", "|").Replace(""">《", "|").Replace("】", "").Replace("》", "")
                id = title.Substring(0, title.IndexOf("|"))
                title = title.Substring(title.IndexOf("|") + 1)
                sb.AppendLine(category & "|" & author & "|" & id & "|" & title) ' & "http://www.haodoo.net/?M=book&P=" & id)
            Next
        Next

        Return sb.ToString
    End Function

    Public Shared Function GetHDVersionList(source As String, Optional HDCat As HDCategory = Nothing) As String
        Dim sb As New StringBuilder

        Dim ARgx As New Regex("<font color=""CC0000"">(\w{2,16})</font>")
        Dim AMts As MatchCollection = ARgx.Matches(source)
        Dim BRgx As New Regex("href=""(\?M=.{3,8}&P=)(.{3,8})"">(.{1,32})</a>(.{1,64})<br>")
        Dim BMts As MatchCollection
        Dim AMt, BMt As Match
        Dim thisI, nextI As Integer
        Dim at, author, link, title, id, desc As String
        Dim category, catchar As String

        If HDCat Is Nothing Then
            Dim CMt As Match = Regex.Match(source, "SetTitle\(""(\w{2,6})-\w{1,2}""\)")
            category = CMt.Groups(1).Value
            catchar = HDCategory.GetCatChar(category)
        Else
            category = HDCat.Name
            catchar = HDCat.Prefix
        End If

        For Each AMt In AMts
            thisI = AMt.Index
            If AMt.NextMatch IsNot Nothing Then
                nextI = AMt.NextMatch.Index
                If nextI < thisI Then
                    nextI = source.Length
                End If
            Else
                nextI = source.Length
            End If

            author = AMt.Groups(1).Value

            at = source.Substring(thisI, nextI - thisI)
            BMts = BRgx.Matches(at)

            For Each BMt In BMts
                id = BMt.Groups(2).Value
                link = BMt.Groups(1).Value & BMt.Groups(2).Value
                title = BMt.Groups(3).Value
                desc = BMt.Groups(4).Value

                sb.AppendLine(catchar & "|" & category & "|" & author & "|" & id & "|" & title & "|" & link & "|" & desc)
            Next
        Next

        Return sb.ToString
    End Function

    Public Shared Function GetCombinedSource(HDCat As HDCategory) As String
        Dim sb As New StringBuilder
        Dim src As String
        Dim urls As Specialized.StringCollection = HDCat.GetPageLinks
        Dim starI, endI As Integer

        For i As Integer = 0 To urls.Count - 1
            src = KzWeb.GetWebCode(urls.Item(i))
            starI = src.IndexOf("START INCLUDE FILES")
            If starI <= 0 Then starI = src.IndexOf("<div class=""a03"">")
            endI = src.IndexOf("SetTitle(")
            src = src.Substring(starI, endI - starI)

            sb.Append(src & vbCrLf)
            Console.WriteLine("{0} Page {1} read.", HDCat.Mark, i)
            'sb.AppendLine(urls.Item(i))
        Next

        Return sb.ToString
    End Function

    Public Shared Sub CreateCompletList(HDCat As HDCategory, Folder As String)
        Dim fnsrc As String = Path.Combine(Folder, "src_" & HDCat.Mark & ".kzsrc")
        Dim fndic As String = Path.Combine(Folder, "dic_" & HDCat.Mark & ".kzdic")
        Dim src As String = GetCombinedSource(HDCat)
        File.WriteAllText(fnsrc, src, Encoding.UTF8)
        Console.WriteLine("Source file writed to {0}", fnsrc)
        File.WriteAllText(fndic, GetHDVersionList(src, HDCat))
        Console.WriteLine("List file writed to {0}", fndic)
    End Sub

    Public Shared Sub CombineCompletList(Folder As String)
        Dim di As New DirectoryInfo(Folder)
        Dim fis As FileInfo() = di.GetFiles("dic_*.kzdic")
        Dim temps As String

        Using fs As FileStream = New FileStream("lst_complet.kzlst", FileMode.Create, FileAccess.Write)
            Using fw As StreamWriter = New StreamWriter(fs, Encoding.UTF8)
                For Each fi As FileInfo In fis
                    temps = File.ReadAllText(fi.FullName, Encoding.UTF8)
                    fw.WriteLine()
                    fw.Write(temps)
                Next
            End Using
        End Using
    End Sub

    Public Shared Function GetBookLink(BookID As String) As String
        Return "http://www.haodoo.net/?M=book&P=" & BookID
    End Function

    Public Shared Function GetCoverLink(BookID As String, Optional ImageExtension As String = ".jpg") As String
        Return "http://www.haodoo.net/covers/" & BookID & ImageExtension
    End Function

    Public Shared ReadOnly Property HomePage As String
        Get
            Return "http://www.haodoo.net/"
        End Get
    End Property
End Class

Public Structure HDCategories
    Public Shared ReadOnly Property The100 As HDCategory
        Get
            Return New HDCategory With {
                .Name = "世紀百強",
                .Mark = "100",
                .Prefix = "A",
                .MaxIndex = 5}
        End Get
    End Property

    Public Shared ReadOnly Property Wisdom As HDCategory
        Get
            Return New HDCategory With {
                .Name = "隨身智囊",
                .Mark = "wisdom",
                .Prefix = "B",
                .MaxIndex = 6}
        End Get
    End Property

    Public Shared ReadOnly Property History As HDCategory
        Get
            Return New HDCategory With {
                .Name = "歷史煙雲",
                .Mark = "history",
                .Prefix = "C",
                .MaxIndex = 3}
        End Get
    End Property

    Public Shared ReadOnly Property Martial As HDCategory
        Get
            Return New HDCategory With {
                .Name = "武俠小說",
                .Mark = "martial",
                .Prefix = "D",
                .MaxIndex = 10}
        End Get
    End Property

    Public Shared ReadOnly Property Mystery As HDCategory
        Get
            Return New HDCategory With {
                .Name = "懸疑小說",
                .Mark = "mystery",
                .Prefix = "E",
                .MaxIndex = 5}
        End Get
    End Property

    Public Shared ReadOnly Property Romance As HDCategory
        Get
            Return New HDCategory With {
                .Name = "言情小說",
                .Mark = "romance",
                .Prefix = "F",
                .MaxIndex = 6}
        End Get
    End Property

    Public Shared ReadOnly Property SciFi As HDCategory
        Get
            Return New HDCategory With {
                .Name = "奇幻小說",
                .Mark = "scifi",
                .Prefix = "G",
                .MaxIndex = 10}
        End Get
    End Property

    Public Shared ReadOnly Property Fiction As HDCategory
        Get
            Return New HDCategory With {
                .Name = "小說園地",
                .Mark = "fiction",
                .Prefix = "H",
                .MaxIndex = 5}
        End Get
    End Property
End Structure

Public Class HDCategory

    Public Sub New()

    End Sub

    Public Property Name As String
    Public Property Mark As String
    Public Property Prefix As Char
    Public Property MaxIndex As Integer

    Public ReadOnly Property MainLink As String
        Get
            Return "?M=hd&P=" & Mark
        End Get
    End Property

    Public ReadOnly Property PageLinkTemplate As String
        Get
            Return MainLink & "-"
        End Get
    End Property

    Public ReadOnly Property DownloadLinkTemplate As String
        Get
            Return "http://www.haodoo.net/?M=d&P=" & Prefix & "{}" & ".updb"
        End Get
    End Property

    Public Function GetPageLink(index As Integer) As String
        Return PageLinkTemplate & index.ToString
    End Function

    Public Function GetPageLinks() As Specialized.StringCollection
        Dim sc As New Specialized.StringCollection

        For i As Integer = 1 To MaxIndex
            sc.Add(GetPageLink(i))
        Next

        Return sc
    End Function

    Public Function GetDownloadLink(FileID As String) As String
        Return DownloadLinkTemplate.Replace("{}", FileID)
    End Function

    Public Shared Function GetCatChar(CatStr As String) As Char
        Select Case CatStr
            Case "世紀百強" : Return "A"
            Case "隨身智囊" : Return "B"
            Case "歷史煙雲" : Return "C"
            Case "武俠小說" : Return "D"
            Case "懸疑小說" : Return "E"
            Case "言情小說" : Return "F"
            Case "奇幻小說" : Return "G"
            Case "小說園地" : Return "H"
            Case Else : Return "?"
        End Select
    End Function

    Public Shared Function GetFullCat(CatStr As String) As Char
        With CatStr
            If .Contains("百強") Then
                Return "世紀百強"
            ElseIf .Contains("智囊") Then
                Return "隨身智囊"
            ElseIf .Contains("歷史") Then
                Return "歷史煙雲"
            ElseIf .Contains("武俠") Then
                Return "武俠小說"
            ElseIf .Contains("懸疑") Then
                Return "懸疑小說"
            ElseIf .Contains("言情") Then
                Return "言情小說"
            ElseIf .Contains("奇幻") Then
                Return "奇幻小說"
            ElseIf .Contains("小說") Then
                Return "小說園地"
            Else
                Return "(不明)"
            End If
        End With
    End Function

    Public Overrides Function ToString() As String
        Return Prefix & "|" & Name & "|" & Mark & "|" & MaxIndex & "|" & MainLink
    End Function

    Public Sub FromLine(line As String)
        Dim keys As String() = line.Split("|")
        Prefix = keys(0).Trim
        Name = keys(1).Trim
        Mark = keys(2).Trim
        MaxIndex = keys(3).Trim
    End Sub
End Class


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

Public Class HDOriginList
    Inherits List(Of HDOriginListLine)

    Public Sub New()

    End Sub

    Public Sub FromFile(Optional FileName As String = Nothing)
        If FileName Is Nothing Then FileName = Path.Combine(My.Settings.HDLibPath, "LibDB", "Lib_NewUpdated.kzdb")
        Try
            Using fs As New FileStream(FileName, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line As String
                    Dim oll As HDOriginListLine
                    Do
                        line = sr.ReadLine
                        oll = New HDOriginListLine
                        oll.FromLine(line)
                        Add(oll)
                    Loop Until sr.EndOfStream
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        For Each oll As HDOriginListLine In Me
            sb.AppendLine(oll.ToString())
        Next

        Return sb.ToString
    End Function

    Public Sub ToFile(FileName As String)
        If Count <= 0 Then Exit Sub

        Try
            File.WriteAllText(FileName, Me.ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class HDOriginListLine
    Implements IComparable, IEquatable(Of HDOriginListLine)

    Public Sub New()

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If obj Is Nothing Then Return 1

        Try
            Dim otherLine As HDOriginListLine = CType(obj, HDOriginListLine)

            If Title = otherLine.Title Then
                Return Author.CompareTo(otherLine.Author)
            Else
                Return Title.CompareTo(otherLine.Title)
            End If
        Catch ex As Exception
            Throw New NotImplementedException("Not implemented!")
        End Try
    End Function

    Public Overloads Function Equals(other As HDOriginListLine) As Boolean Implements IEquatable(Of HDOriginListLine).Equals
        Try
            If Category = other.Category And Title = other.Title And ID = other.ID And
                Author = other.Author And Version = other.Version Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Property Category As String
    Public Property Author As String
    Public Property ID As String
    Public Property Title As String
    Public Property Version As String
    Public Property ExternalRef As String

    Public Function SetHDLibInf() As HDLibInf
        Return New HDLibInf With {
            .Type = HDLibInfType.BookInfo,
            .ID = ID,
            .Name = Title,
            .Author = Author,
            .Category = Category,
            .Version = Version,
            .ExternalRef = ExternalRef,
            .Address = Category & "\" & Author & "\" & Title,
            .Logo = ID & ".jpg"}
    End Function

    Public Function GetHDCategory(Optional FileName As String = Nothing) As HDCategory
        Dim hdc As New HDCategory

        If FileName Is Nothing Then FileName = Path.Combine(My.Settings.HDLibPath, "LibDB", "Lib_Categories.kzdb")

        Try
            Using fs As New FileStream(FileName, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line As String
                    Dim keys As String()
                    Dim go As Boolean = True

                    Do
                        line = sr.ReadLine
                        If Not line.StartsWith("?") Then
                            keys = line.Split("|")
                            If keys(1).Trim = Category OrElse keys(2).Trim = Category Then
                                With hdc
                                    .Prefix = keys(0).Trim
                                    .Name = keys(1).Trim
                                    .Mark = keys(2).Trim
                                    .MaxIndex = CInt(keys(3).Trim)
                                End With
                                go = False
                            End If
                        End If
                    Loop Until Not go
                End Using
            End Using
        Catch ex As Exception
        End Try

        Return hdc
    End Function

    Public Overrides Function ToString() As String
        Return Category & "|" & Author & "|" & ID & "|" & Title & "|" & Version & "|" & ExternalRef
    End Function

    Public Sub FromLine(line As String)
        Dim keys As String() = line.Split("|")
        Category = keys(0).Trim
        Author = keys(1).Trim
        ID = keys(2).Trim
        Title = keys(3).Trim
        Version = keys(4).Trim
        ExternalRef = keys(5).Trim
    End Sub
End Class

