Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class HDLibDB

    Private DBFolder As String

    Private Sub HDLibDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogsWrite("HDLibDB", "Loaded.")
        CatCmdMenu.BackColor = SourcesPanel.BackColor

        RootTextBox.Text = My.Settings.HDLibPath

        SetCategoriesToView()

        StrPageEntries.SelectedItem = "10"
    End Sub

#Region "GetSetFunctions"
    Private Sub LogsWrite(ObjectName As String, LogText As String)
        With LogsTextBox
            .AppendText(Now().ToString & " [" & ObjectName & "] " & LogText & vbCrLf)
            .ScrollToCaret()
        End With
    End Sub 'LogsWrite

    Private Sub LogsCount(Optional subject As String = "Stop", Optional c As Integer = 0,
                          Optional a As Integer = 0, Optional b As Integer = 0)
        RunningLabel.Text = subject
        RCategoryLabel.Text = "Category: " & c
        RAuthorLabel.Text = "Author: " & a
        RBookLabel.Text = "Book: " & b

        RCategoryLabel.Invalidate()
        RAuthorLabel.Invalidate()
        RBookLabel.Invalidate()
    End Sub 'LogsCount

    Private Function DBFileExists(NameOfFile As String) As Boolean
        Return File.Exists(Path.Combine(DBFolder, NameOfFile))
    End Function

    Private Sub SetTextToUI(NameOfFile As String)
        Try
            TextDataViewer.FilePath = Path.Combine(DBFolder, NameOfFile)
            TextDataViewer.Contents = File.ReadAllText(TextDataViewer.FilePath, Encoding.UTF8)
            LogsWrite(NameOfFile, "Read and showed to viewer.")
        Catch ex As Exception
            TextDataViewer.Contents = Nothing
            LogsWrite(NameOfFile, "File reading failed." & vbCrLf & ex.Message)
        End Try
    End Sub 'SetTextToUI

    Private Function GetTextFromFile(NameOfFile As String) As String
        Dim result As String
        Dim fn As String = Path.Combine(DBFolder, NameOfFile)

        If Not File.Exists(fn) Then
            LogsWrite(NameOfFile, "File NOT exist.")
            Return Nothing
        End If

        Try
            result = File.ReadAllText(fn, Encoding.UTF8)
            If result IsNot Nothing Then
                LogsWrite(NameOfFile, "Reading successed.")
            Else
                LogsWrite(NameOfFile, "Reading successed. File is nothing.")
            End If
            Return result
        Catch ex As Exception
            LogsWrite(NameOfFile, "File reading failed." & vbCrLf & ex.Message)
            Return Nothing
        End Try

        Return result
    End Function 'GetTextFromFile

    Private Sub SetTextToFile(NameOfFile As String, Contents As String, Optional IsAppend As Boolean = False)
        Dim fn As String = Path.Combine(DBFolder, NameOfFile)
        If IsAppend Then
            Try
                File.AppendAllText(fn, Contents, Encoding.UTF8)
                LogsWrite(NameOfFile, "Appending successed.")
            Catch ex As Exception
                LogsWrite(NameOfFile, "Appending failed: " & ex.Message)
            End Try
        Else
            Try
                File.WriteAllText(fn, Contents, Encoding.UTF8)
                LogsWrite(NameOfFile, "Writing successed.")
            Catch ex As Exception
                LogsWrite(NameOfFile, "Writing failed: " & ex.Message)
            End Try
        End If
    End Sub 'SetTextToFile

    Private Function GetMaxIndexFromWeb(MainLinkUrl As String) As Integer
        Try
            Dim src As String = KzWeb.GetWebCode(MainLinkUrl)
            Dim part As String = Regex.Match(src, "<span class=a92>(.+?)</span>", RegexOptions.Singleline).Groups(1).Value

            Dim rgx As New Regex("<a href=""\?M=hd&P=(\w{3,12})-([0-9]{1,2})"">(.{1,8})</a>")

            Return rgx.Matches(part).Count
        Catch ex As Exception
            Return -1
        End Try
    End Function 'GetMaxIndexFromWeb

    Private Sub SetCategoriesToView(Optional SelectedIndex As Integer = -1)
        Dim fn As String = Path.Combine(DBFolder, HDSrc.NameOfCategories)
        If Not File.Exists(fn) Then
            LogsWrite("CategoriesView", "Category list file NOT found.")
            Exit Sub
        End If

        CategoriesListView.Items.Clear()
        Try
            Using fs As New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As New StreamReader(fs, Encoding.UTF8)
                    Dim inf As HDLibInf
                    Dim line As String
                    Dim item As ListViewItem
                    Dim fsrc, fbk As String
                    Do
                        line = sr.ReadLine
                        If Not line.StartsWith("?") Then
                            inf = New HDLibInf
                            inf.FromCategoryLine(line)

                            item = New ListViewItem(inf.Name)
                            fsrc = HDSrc.NameOfCatDetailSource.Replace("{mark}", inf.ID)
                            fbk = HDSrc.NameOfCatBooks.Replace("{mark}", inf.ID)
                            With item.SubItems
                                .Add(inf.ID)
                                .Add(inf.Series)
                                .Add(inf.SID)
                                .Add(inf.ExternalRef)
                                .Add(If(DBFileExists(fsrc), "", "x"))
                                .Add(fsrc)
                                .Add(If(DBFileExists(fbk), "", "x"))
                                .Add(fbk)
                            End With
                            CategoriesListView.Items.Add(item)
                        End If
                    Loop Until sr.EndOfStream
                End Using
            End Using
            LogsWrite("CategoriesView", "View setting finished.")
            CategoriesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

            If SelectedIndex > -1 AndAlso SelectedIndex <= CategoriesListView.Items.Count - 1 Then
                CategoriesListView.Items(SelectedIndex).Selected = True
            End If
        Catch ex As Exception
            LogsWrite("CategoriesView", "View setting error." & vbCrLf & ex.Message)
        End Try
        LogsCount()
    End Sub 'SetCategoriesToView

    Private Function GetHDCategoryFromFile(Key As String) As HDCategory
        Dim hdc As New HDCategory
        Dim fn As String = Path.Combine(DBFolder, HDSrc.NameOfCategories)
        Dim fs As FileStream

        Try
            fs = New FileStream(fn, FileMode.Open, FileAccess.Read)
            LogsWrite(HDSrc.NameOfCategories, "File read successed.")
        Catch ex As Exception
            fs = Nothing
            LogsWrite(HDSrc.NameOfCategories, "File read failed: " & ex.Message)
            Return hdc
        End Try

        Try
            Using fs
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line As String
                    Dim keys As String()
                    Dim go As Boolean = True
                    Dim count As Integer = 0

                    Do
                        count += 1
                        line = sr.ReadLine
                        If Not line.StartsWith("?") Then
                            keys = line.Split("|")
                            If keys(1).Trim = Key OrElse keys(2).Trim = Key Then
                                With hdc
                                    .Prefix = keys(0).Trim
                                    .Name = keys(1).Trim
                                    .Mark = keys(2).Trim
                                    .MaxIndex = CInt(keys(3).Trim)
                                End With
                                go = False
                            End If
                        End If

                        If go Then
                            LogsWrite("Line " & count, Key & " Unmatched.")
                        Else
                            LogsWrite("Line " & count, Key & " Matched.")
                        End If
                    Loop Until Not go
                End Using
            End Using
            LogsWrite("Category " & hdc.Name, "Item captrued.")
        Catch ex As Exception
            LogsWrite("Category " & hdc.Name, "Captrue failed: " & ex.Message)
        End Try

        Return hdc
    End Function 'GetHDCategoryFromFile

    Private Sub GetSourceFile(url As String, NameOfFile As String, Optional IsAppend As Boolean = False)
        Try
            Dim temp As String = KzWeb.GetWebCode(url)
            Dim fn As String = Path.Combine(DBFolder, NameOfFile)
            Dim fs As FileStream
            If IsAppend Then
                fs = New FileStream(fn, FileMode.Append, FileAccess.Write)
            Else
                fs = New FileStream(fn, FileMode.Create, FileAccess.Write)
            End If

            Using fs
                Using sw As New StreamWriter(fs, Encoding.UTF8)
                    sw.Write(vbCrLf & temp)
                End Using
            End Using

            LogsWrite(NameOfFile, "Getting source successed.")
        Catch ex As Exception
            LogsWrite(NameOfFile, "Getting source failed." & vbCrLf & ex.Message)
        End Try
    End Sub ' GetSourceFile

    Private Sub GetAllMainSources()
        If Not File.Exists(Path.Combine(DBFolder, HDSrc.NameOfCategories)) Then
            LogsWrite("HDSrc.NameOfCategories", "File NOT found.")
            Exit Sub
        End If

        If CategoriesListView.Items.Count <= 0 Then
            SetCategoriesToView()
        End If

        LogsWrite("Sources", "Start - Get all category sources.")
        If CategoriesListView.Items.Count > 0 Then
            Dim mark, fn As String
            For Each item As ListViewItem In CategoriesListView.Items
                mark = item.SubItems(1).Text
                fn = HDSrc.NameOfCatMainSource.Replace("{mark}", mark)
                GetSourceFile(HDSrc.HDHomePage & HDSrc.CategoryMainPage.Replace("{mark}", mark), fn)
            Next
            LogsWrite("Sources", "Finished - Get all category sources.")
        Else
            LogsWrite("Sources", "Finished - Categories NOT found.")
        End If
    End Sub 'GetAllMainSources

    Private Sub GetCategoriesFromSource(Optional Renew As Boolean = False)
        LogsWrite("HDLibHome", "Start - Get categories.")
        If Renew Then
            GetSourceFile(HDSrc.HDHomePage, HDSrc.NameOfHomeSource)
        End If

        Dim fullsrc As String = GetTextFromFile(HDSrc.NameOfHomeSource)

        Try
            Dim src As String = Regex.Match(fullsrc, "<td class=""a03"">(.+?)</td>", RegexOptions.Singleline).Groups(1).Value
            Dim mts As MatchCollection = Regex.Matches(src, "<a href=""\?M=hd&P=(\w+)"">(\w+)</a>")
            Dim mt As Match
            Dim gps As GroupCollection
            Dim Cat As HDLibInf ' HDCategory
            Dim sb As New StringBuilder
            Dim count As Integer

            count = 0
            For Each mt In mts
                gps = mt.Groups
                Cat = New HDLibInf
                With Cat
                    .Type = HDLibInfType.CategoryInfo
                    .Name = gps(2).Value
                    .ID = gps(1).Value
                    .Series = HDCategory.GetCatChar(.Name)
                    .ExternalRef = HDSrc.CategoryMainPage.Replace("{mark}", .ID)
                    .SID = GetMaxIndexFromWeb(HDSrc.HDHomePage & .ExternalRef)
                End With

                sb.AppendLine(Cat.ToCategoryLine)
                count += 1
                LogsWrite(Cat.Name, "Category " & "#" & count & " captured.")
            Next

            SetTextToFile(HDSrc.NameOfCategories, sb.ToString)
            LogsWrite("HDLibHome", "Finished - Get categories.")
        Catch ex As Exception
            LogsWrite("HDLibHome", "Error - Get categories." & vbCrLf & ex.Message)
            Exit Sub
        End Try

    End Sub 'GetCategoriesFromSource

    Private Sub GetDetailSourceFromWeb(CategoryMark As String, MaxIndex As Integer)
        Try
            LogsWrite(CategoryMark, "Start - Get detail source.")
            Using fsw As New FileStream(Path.Combine(DBFolder, HDSrc.NameOfCatDetailSource.Replace("{mark}", CategoryMark)), FileMode.Create, FileAccess.Write)
                Using sw As StreamWriter = New StreamWriter(fsw, Encoding.UTF8)
                    Dim urltemp As String = HDSrc.HDHomePage & HDSrc.CategorySplitPage.Replace("{mark}", CategoryMark)
                    Dim url, fullsrc, pagesrc As String

                    For i As Integer = 1 To MaxIndex
                        url = urltemp.Replace("{idx}", i)
                        fullsrc = KzWeb.GetWebCode(url)
                        pagesrc = Regex.Match(fullsrc, "<div class=""a03"">(.+)</div>", RegexOptions.Singleline).Groups(1).Value
                        sw.WriteLine("#" & CategoryMark & ": Page " & i)
                        sw.Write(pagesrc & vbCrLf)
                        LogsWrite(CategoryMark, "Page " & i & " captrued.")
                    Next

                End Using
            End Using
            LogsWrite(CategoryMark, "Finish - Get detail source.")
        Catch ex As Exception
            LogsWrite(CategoryMark, "Error - Get detail source." & vbCrLf & ex.Message)
        End Try
    End Sub 'GetDetailSourceFromWeb

    Private Sub GetOriginBooksFromSource(CategoryMark As String, CategoryName As String)
        Dim fn As String = HDSrc.NameOfCatDetailSource.Replace("{mark}", CategoryMark)
        If Not DBFileExists(fn) Then
            LogsWrite(fn, "File NOT exists.")
            Exit Sub
        End If

        Try
            Dim src As String = GetTextFromFile(HDSrc.NameOfCatDetailSource.Replace("{mark}", CategoryMark))
            If src Is Nothing Then
                LogsWrite(fn, "File is empty.")
                Exit Sub
            End If

            LogsWrite(CategoryName, "Start - Get origin book list.")
            Dim sb As New StringBuilder
            Dim AMts, BMts As MatchCollection
            Dim AMt, BMt As Match
            Dim thisI, nextI As Integer
            Dim au, aublock As String
            Dim inf As HDLibInf
            Dim ac As Integer = 0
            Dim bc As Integer = 0

            'Dim TheLogs As String = LogsTextBox.Text

            AMts = Regex.Matches(src, "<font color=""CC0000"">(.{2,}?)</font>")
            For Each AMt In AMts
                thisI = AMt.Index
                If AMt.NextMatch IsNot Nothing Then
                    nextI = AMt.NextMatch.Index
                    If nextI < thisI Then
                        nextI = src.Length
                    End If
                Else
                    nextI = src.Length
                End If

                au = AMt.Groups(1).Value
                If au.Contains(". ") Then au = au.Substring(au.IndexOf(" ") + 1)
                ac += 1
                LogsCount("Listed", 1, ac, bc)

                aublock = src.Substring(thisI, nextI - thisI)
                BMts = Regex.Matches(aublock, "href=""(\?M=.{3,8}?&P=)(.{2,8}?)"">[《|【|〈]{0,1}(.+?)[》|】|〉]{0,1}</a>(.+?)<br>")
                For Each BMt In BMts
                    inf = New HDLibInf
                    With inf
                        .Type = HDLibInfType.BookInfo
                        .Category = CategoryName
                        .Author = au
                        .ID = BMt.Groups(2).Value
                        .Name = BMt.Groups(3).Value '.Replace("《", "").Replace("》", "").Replace("【", "").Replace("】", "")
                        .Version = BMt.Groups(4).Value
                        .ExternalRef = BMt.Groups(1).Value & BMt.Groups(2).Value
                    End With

                    sb.AppendLine(inf.ToBooksLine)
                    bc += 1
                    LogsCount("Listed", 1, ac, bc)
                Next
            Next
            LogsWrite(CategoryName, "Total 1 category " & ac & " Authors " & bc & " Books.")

            SetTextToFile(HDSrc.NameOfCatBooks.Replace("{mark}", CategoryMark), sb.ToString)
            LogsWrite(CategoryName, "Finished - Get origin book list.")
        Catch ex As Exception
            LogsWrite(CategoryName, "Error - Get origin book list." & vbCrLf & ex.Message)
        End Try
    End Sub 'GetOriginBooksFromSource

    Private Sub CombineOriginBooks()
        LogsWrite("OriginBooks", "Start - Combine all books.")
        Try
            Dim di As New DirectoryInfo(DBFolder)
            Dim fis As FileInfo() = di.GetFiles("Cat_*_books.kzdb")

            If fis.Length = 0 Then
                LogsWrite("OriginBooks", "Category detail source file NOT found.")
                Exit Sub
            End If

            Dim fi As FileInfo
            Dim cf As String
            Using fsw As New FileStream(Path.Combine(DBFolder, HDSrc.NameOfOriginBooks), FileMode.Create, FileAccess.Write)
                Using sw As New StreamWriter(fsw, Encoding.UTF8)
                    For Each fi In fis
                        cf = GetTextFromFile(fi.FullName)
                        sw.Write(cf & vbCrLf)
                        LogsWrite(fi.Name, "File contents captrued.")
                    Next
                End Using
            End Using

            LogsWrite("OriginBooks", "Finished - Combine all books to " & HDSrc.NameOfOriginBooks & ".")
        Catch ex As Exception
            LogsWrite("OriginBooks", "Error - Combine all books." & vbCrLf & ex.Message)
        End Try
    End Sub 'CombineOriginBooks

    Private Sub GetUpdatedFromSource(Optional IsAppend As Boolean = False)
        Dim source As String = GetTextFromFile(HDSrc.NameOfHomeSource)

        Dim srcmt As Match = Regex.Match(source, "好書更新 (.{4}年.{1,2}月)<br>(.+)更多好書更新", RegexOptions.Singleline)
        Dim src As String = srcmt.Groups(2).Value
        Dim mtime As String = srcmt.Groups(1).Value
        Dim sb As New StringBuilder

        Dim MTs As MatchCollection = Regex.Matches(src, "<font color=""CC0000"">(.{2,20})</font><a(.{1,10})href=""(\?M=.{3,6}&P=)(.{2,8})"">(.{1,25})</a>(.{5,50})\((.{2,4})\)<br>")
        'TextDataViewer.Contents = MTs(0).Value
        Dim ca, ti, id, au, ve, lk As String
        Dim count As Integer = 0
        For Each MT As Match In MTs
            au = MT.Groups(1).Value
            id = MT.Groups(4).Value
            ti = MT.Groups(5).Value.Replace("《", "").Replace("》", "").Replace("【", "").Replace("】", "")
            ve = MT.Groups(6).Value
            ca = MT.Groups(7).Value
            lk = MT.Groups(3).Value & MT.Groups(4).Value

            count += 1
            RBookLabel.Text = "Books: " & count
            sb.AppendLine(mtime & "|" & au & "|" & id & "|" & ti & "|" & ve & "|" & ca & "|" & lk)
        Next

        Dim fn As String = Path.Combine(DBFolder, HDSrc.NameOfUpdatedList)

        Try
            File.WriteAllText(fn, sb.ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub 'GetNewUpdatedFromWeb

    Private Function CheckEntryByLine(line As String) As String
        Return Nothing
    End Function 'CheckEntryByLine

    Private Function GetCategoryInfoByKey(key As String) As HDLibInf
        Dim inf As New HDLibInf
        Dim fn As String = Path.Combine(DBFolder, HDSrc.NameOfCategories)

        Try
            Using fs As New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As New StreamReader(fs, Encoding.UTF8)
                    Dim line As String
                    Dim go As Boolean = True

                    Do
                        line = sr.ReadLine
                        inf = New HDLibInf
                        If Not line.StartsWith("?") AndAlso line.Contains("|") AndAlso line.Length > 0 Then
                            inf.FromCategoryLine(line)
                            If key = inf.Name OrElse key = inf.ID Then go = False
                        End If
                    Loop Until Not go
                End Using
            End Using
        Catch ex As Exception

        End Try

        Return inf
    End Function 'GetCategoryInfoByKey

    Private Sub CreateEntriesFromFile(NameOfFile As String, Optional StartIndex As Integer = 1, Optional RangeCount As Integer = Integer.MaxValue - 1)
        If StartIndex < 1 OrElse RangeCount < 1 Then Exit Sub

        Dim fn As String = Path.Combine(DBFolder, NameOfFile)
        If Not File.Exists(fn) Then Exit Sub

        Dim root As String
        If OtherPathCheck.Checked Then
            root = OtherPathLabel.Text
        Else
            root = RootTextBox.Text
        End If

        Try
            Using fs As New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As New StreamReader(fs, Encoding.UTF8)
                    Dim count As Integer = StartIndex - 1
                    Dim line As String
                    Dim total As New EntryCreationResult
                    Dim r As EntryCreationResult

                    Do
                        count += 1
                        line = sr.ReadLine
                        If (count >= StartIndex) AndAlso (line.Trim.Length > 25) AndAlso
                            (line.Contains("|")) AndAlso (Not line.StartsWith("#")) Then

                            r = CreateEntryByLine(line, root, True)

                            total.Add(r)
                            LogsCount("Create", total.Categories, total.Authors, total.Books)
                        End If
                    Loop Until sr.EndOfStream OrElse count = StartIndex + RangeCount - 1
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub 'CreateEntriesFromFile

    Private Class EntryCreationResult
        Public Property Categories As Integer = 0
        Public Property Authors As Integer = 0
        Public Property Books As Integer = 0
        Public Property ErrMsg As String = Nothing

        Public Sub Add(AnotherResult As EntryCreationResult)
            Categories += AnotherResult.Categories
            Authors += AnotherResult.Authors
            Books += AnotherResult.Books
        End Sub
    End Class

    Private Function CreateEntryByLine(Line As String, Root As String, Optional GetSource As Boolean = False) As EntryCreationResult
        Dim rslt As New EntryCreationResult

        If (Line.Trim.Length < 25) OrElse (Not Line.Contains("|")) OrElse (Line.StartsWith("#")) Then Return rslt ' Exit Sub

        Dim di As DirectoryInfo
        Dim BInf, ACInf As HDLibInf
        Dim EqualsName As String

        Try
            BInf = New HDLibInf
            BInf.FromBooksLine(Line)

            di = New DirectoryInfo(Path.Combine(Root, BInf.Category))
            If Not di.Exists Then
                di.Create()
                ACInf = GetCategoryInfoByKey(BInf.Category)
                If ACInf.IsEmpty Then
                    ACInf.Type = HDLibInfType.CategoryInfo
                    ACInf.Name = BInf.Category
                End If
                ACInf.Address = "HDLib"
                ACInf.Export(di.FullName)
                rslt.Categories += 1
            End If

            EqualsName = BInf.Author.Replace("．", "").Replace("·", "").Trim
            If EqualsName.Contains("(") Then EqualsName = EqualsName.Substring(0, EqualsName.IndexOf("(")).Trim

            di = New DirectoryInfo(Path.Combine(Root, BInf.Category, EqualsName))
            If Not di.Exists Then
                di.Create()
                ACInf = New HDLibInf
                ACInf.Type = HDLibInfType.AuthorInfo
                ACInf.Name = BInf.Author
                ACInf.Address = BInf.Category
                ACInf.Export(di.FullName)
                rslt.Authors += 1
            End If

            di = New DirectoryInfo(Path.Combine(Root, BInf.Category, EqualsName, BInf.Name))
            If Not di.Exists Then
                di.Create()
                BInf.Address = BInf.Category & "\" & BInf.Author

                If GetSource Then
                    Dim src As String = KzWeb.GetWebCode(HDSrc.HDHomePage & BInf.ExternalRef)

                    Try
                        If src Is Nothing OrElse src.Length < 512 Then
                            Throw New ArgumentNullException("Source contents is NOT match.")
                        End If

                        File.WriteAllText(Path.Combine(di.FullName, "Page.kzsrc"), src)
                    Catch ex As Exception
                        MsgBox("Error in getting page source." & vbCrLf & ex.Message)
                    End Try

                    UpdateInfFromSource(BInf, src)
                End If

                BInf.Export(di.FullName)
                rslt.Books += 1
                LogsWrite(BInf.Name, "Entry created.")
            End If
        Catch ex As Exception
            rslt.ErrMsg = ex.Message
        End Try

        Return rslt
    End Function 'CreateEntryByLine

    Private Sub UpdateInfFromSource(Inf As HDLibInf, Src As String) 'As HDLibInf
        If Src Is Nothing OrElse Src.Length < 1024 Then Exit Sub
        'Dim src As String = Nothing
        'Dim fn As String = Path.Combine(RootTextBox.Text, Inf.Address, "Page.kzsrc")
        'If FromSourceFile Then
        '    Try
        '        src = File.ReadAllText(fn, Encoding.UTF8)
        '    Catch ex As Exception
        '        src = Nothing
        '    End Try
        'End If

        'If src Is Nothing Or src.Length < 512 Then
        '    Dim BookLink As String = HDSrc.HDHomePage & Inf.ExternalRef
        '    src = KzWeb.GetWebCode(BookLink)
        '    If src Is Nothing OrElse src.Length < 1024 Then Return Inf
        '    If FromSourceFile Then
        '        Try
        '            File.WriteAllText(fn, src)
        '        Catch ex As Exception

        '        End Try
        '    End If
        'End If

        'Get links(lst) and manifest(lst2) from web source
        Dim lst, lst2 As New HDList
        Dim Mts As MatchCollection
        Dim Mt As Match

        Mts = Regex.Matches(Src, "<font color=""CC0000"">(.{2,15})</font>[《|【|〈]{0,1}(.{1,25}?)[》|】|〉]{0,1}<input type=.+?DownloadUpdb\('([A-H])(.{1,8}?)'\)"";>")
        If Mts.Count > 0 Then
            For Each Mt In Mts
                lst.Add(Mt.Groups(2).Value, HDSrc.HDHomePage & HDSrc.DownloadLink.Replace("{fix}", Mt.Groups(3).Value).Replace("{id}", Mt.Groups(4).Value))
                lst2.Add(Mt.Groups(4).Value & ".updb", Mt.Groups(2).Value)
            Next
        End If

        Mts = Regex.Matches(Src, "img src=""covers/(.{2,8})(\..{3,4})""")
        If Mts.Count > 0 Then
            Dim ifn As String
            For Each Mt In Mts
                ifn = Mt.Groups(1).Value & Mt.Groups(2).Value
                lst.Add(Mt.Groups(1).Value, HDSrc.HDHomePage & HDSrc.CoverLink.Replace("{file}", ifn))
                If Mt.Groups(1).Value = Inf.ID Then
                    lst2.Add(ifn, "封面")
                    Inf.Logo = ifn
                End If
            Next
        End If

        If lst.Count > 0 Then Inf.Links = lst
        If lst2.Count > 0 Then Inf.Manifest = lst2

        'Get description from web source
        Dim desc As String = Regex.Match(Src, "(好讀書櫃《\w{2,5}》.+)勘誤表", RegexOptions.Singleline).Groups(1).Value
        desc = Regex.Replace(desc, "<.+?>", "")
        Inf.Description = desc.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf).Replace(vbCrLf & vbCrLf, vbCrLf)

        'Return Inf
    End Sub 'UpdateInfFromWeb

#End Region 'GetSetFunctions

#Region "MenuActions"
    Private Sub SourcesMenu_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles SourcesMenu.DropDownItemClicked
        Me.Cursor = Cursors.WaitCursor

        If e.ClickedItem.Equals(SrcGetHomeItem) Then GetSourceFile(HDSrc.HDHomePage, HDSrc.NameOfHomeSource)
        If e.ClickedItem.Equals(SrcCreateCatListItem) Then GetCategoriesFromSource()
        If e.ClickedItem.Equals(SrcGetMainItem) Then GetAllMainSources()
        If e.ClickedItem.Equals(SrcShowHomeItem) Then SetTextToUI(HDSrc.NameOfHomeSource)

        If CategoriesListView.Items.Count > 0 Then

            If e.ClickedItem.Equals(SrcGetAllItem) Then
                Dim cIndex As Integer
                Try
                    cIndex = CategoriesListView.SelectedIndices(0)
                Catch ex As Exception
                    cIndex = -1
                End Try

                For Each item In CategoriesListView.Items
                    GetDetailSourceFromWeb(item.SubItems(1).Text, item.SubItems(3).Text)
                Next
                SetCategoriesToView(cIndex)
            End If

            If CategoriesListView.SelectedItems.Count > 0 Then

                If e.ClickedItem.Equals(SrcShowMainItem) Then
                    Dim mark As String = CategoriesListView.SelectedItems(0).SubItems(1).Text
                    SetTextToUI(HDSrc.NameOfCatMainSource.Replace("{mark}", mark))
                End If

                If e.ClickedItem.Equals(SrcShowDetailItem) Then
                    Dim mark As String = CategoriesListView.SelectedItems(0).SubItems(1).Text
                    SetTextToUI(HDSrc.NameOfCatDetailSource.Replace("{mark}", mark))
                End If

                If e.ClickedItem.Equals(SrcGetDetailItem) Then
                    Dim cIndex As Integer
                    Try
                        cIndex = CategoriesListView.SelectedIndices(0)
                    Catch ex As Exception
                        cIndex = -1
                    End Try

                    With CategoriesListView.SelectedItems(0)
                        GetDetailSourceFromWeb(.SubItems(1).Text, .SubItems(3).Text)
                    End With
                    SetCategoriesToView(cIndex)
                End If
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CategoriesMenu_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CategoriesMenu.DropDownItemClicked
        Me.Cursor = Cursors.WaitCursor

        If e.ClickedItem.Equals(CatsGetListItem) Then GetCategoriesFromSource()
        If e.ClickedItem.Equals(CatsRefreshItem) Then SetCategoriesToView()
        If e.ClickedItem.Equals(CatsShowItem) Then SetTextToUI(HDSrc.NameOfCategories)

        If CategoriesListView.Items.Count > 0 Then
            If e.ClickedItem.Equals(CatsGetListFilesItem) Then
                Dim cIndex As Integer
                Try
                    cIndex = CategoriesListView.SelectedIndices(0)
                Catch ex As Exception
                    cIndex = -1
                End Try

                For Each item In CategoriesListView.Items
                    GetOriginBooksFromSource(item.SubItems(1).Text, item.SubItems(0).Text)
                Next
                SetCategoriesToView(cIndex)
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CategoryMenu_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CategoryMenu.DropDownItemClicked
        Me.Cursor = Cursors.WaitCursor

        If e.ClickedItem.Equals(CombineBooksItem) Then CombineOriginBooks()
        If e.ClickedItem.Equals(CatShowAllItem) Then SetTextToUI(HDSrc.NameOfOriginBooks)

        If CategoriesListView.Items.Count > 0 AndAlso CategoriesListView.SelectedItems.Count > 0 Then

            If e.ClickedItem.Equals(CatGetListItem) Then
                With CategoriesListView.SelectedItems(0)
                    GetOriginBooksFromSource(.SubItems(1).Text, .SubItems(0).Text)
                End With
                SetCategoriesToView()
            End If

            If e.ClickedItem.Equals(CatShowItem) Then
                Dim mark As String = CategoriesListView.SelectedItems(0).SubItems(1).Text
                SetTextToUI(HDSrc.NameOfCatBooks.Replace("{mark}", mark))
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UpdatedMenu_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles UpdatedMenu.DropDownItemClicked
        Me.Cursor = Cursors.WaitCursor

        If e.ClickedItem.Equals(UpGetListItem) Then GetUpdatedFromSource()
        If e.ClickedItem.Equals(UpShowItem) Then SetTextToUI(HDSrc.NameOfUpdatedList)
        If e.ClickedItem.Equals(UpCompareItem) Then

        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StructureMenu_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StructureMenu.DropDownItemClicked
        Me.Cursor = Cursors.WaitCursor

        If e.ClickedItem.Equals(StrCreateAllItem) Then
            CreateEntriesFromFile(HDSrc.NameOfOriginBooks, 1, 10)
        End If

        If CategoriesListView.Items.Count > 0 AndAlso CategoriesListView.SelectedItems.Count > 0 Then
            If e.ClickedItem.Equals(StrCreateItem) Then
                Dim mark As String = CategoriesListView.SelectedItems(0).SubItems(1).Text
                CreateEntriesFromFile(HDSrc.NameOfCatBooks.Replace("{mark}", mark), 1, 5)
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

#End Region 'MenuActions

    Private Sub RootTextBox_TextChanged(sender As Object, e As EventArgs) Handles RootTextBox.TextChanged
        DBFolder = Path.Combine(RootTextBox.Text, "LibDB")
        OtherPathLabel.Text = RootTextBox.Text
    End Sub

    Private Sub CategoriesListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoriesListView.SelectedIndexChanged
        With CategoriesListView
            If .SelectedItems.Count > 0 Then
                NCategoriesLabel.Text = "Selected " & .SelectedIndices(0) + 1 & " / " & .Items.Count
            Else
                NCategoriesLabel.Text = "Selected " & "0" & " / " & .Items.Count
            End If
        End With
    End Sub

    Private Sub OtherPathButton_Click(sender As Object, e As EventArgs) Handles OtherPathButton.Click
        Dim ofd As New FolderBrowserDialog With {
            .Description = "Select new folder for create Lib.",
            .SelectedPath = RootTextBox.Text,
            .ShowNewFolderButton = True}

        If ofd.ShowDialog = DialogResult.OK Then
            OtherPathLabel.Text = ofd.SelectedPath
        End If
    End Sub
End Class

Public Structure HDSrc
    Public Shared ReadOnly Property HDHomePage As String = "http://www.haodoo.net/"
    Public Shared ReadOnly Property CategoryMainPage As String = "?M=hd&P={mark}"
    Public Shared ReadOnly Property CategorySplitPage As String = "?M=hd&P={mark}-{idx}"
    Public Shared ReadOnly Property DownloadLink As String = "?M=d&P={fix}{id}.updb"
    Public Shared ReadOnly Property CoverLink As String = "covers/{file}"
    Public Shared ReadOnly Property BookPage As String = "?M={case}&P={id}"

    Public Shared ReadOnly Property NameOfCategories As String = "Org_Categories.kzdb"
    Public Shared ReadOnly Property NameOfHomeSource As String = "Src_HomePage.kzdb"
    Public Shared ReadOnly Property NameOfUpdatedList As String = "Org_Updated.kzdb"
    Public Shared ReadOnly Property NameOfOldUpdatedList As String = "Org_OldUpdated.kzdb"
    Public Shared ReadOnly Property NameOfOriginBooks As String = "Org_Books.kzdb"
    Public Shared ReadOnly Property NameOfCatMainSource As String = "Src_{mark}_main.kzdb"
    Public Shared ReadOnly Property NameOfCatDetailSource As String = "Src_{mark}_detail.kzdb"
    Public Shared ReadOnly Property NameOfCatBooks As String = "Cat_{mark}_books.kzdb"
    Public Shared ReadOnly Property NameOfDbBooks As String = "Lib_Books.kzdb"
    Public Shared ReadOnly Property NameOfDbAuthors As String = "Lib_Authors.kzdb"
    Public Shared ReadOnly Property NameOfDbCategories As String = "Lib_Categories.kzdb"

    Public Shared Function FullLink(src As String) As String
        Return HDHomePage & src
    End Function
End Structure


