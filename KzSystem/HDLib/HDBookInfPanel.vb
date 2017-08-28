Imports System.IO
Imports System.Text
Imports System.Collections.Specialized


Public Class HDBookInfPanel

    Private _BookInfo As HDBookInf

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Property BookInfo As HDBookInf
        Get
            Return _BookInfo
        End Get
        Set(value As HDBookInf)
            _BookInfo = value

        End Set
    End Property
End Class

Public Class HDBookInf
    Implements IComparable

    Public Sub New()

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If obj Is Nothing Then Return 1

        Try
            Dim otherColor As HDBookInf = CType(obj, HDBookInf)
            Return Title.CompareTo(otherColor.Title)
        Catch ex As Exception
            Throw New NotImplementedException("Error!")
        End Try
    End Function

    Public Property ID As String
    Public Property Title As String
    Public Property Subject As String
    Public Property Creator As String
    Public Property Series As String
    Public Property Author As String
    Public Property Contributor As String
    Public Property Language As String
    Public Property Version As String
    Public Property Category As String
    Public Property Special As String
    Public Property Cover As String
    Public Property Created As String
    Public Property Updated As String
    Public Property ViewLink As String
    Public Property FileLink As String
    Public Property CoverLink As String
    Public Property Intro As String

    Public Shadows ReadOnly Property ToString As String
        Get
            Dim sb As New StringBuilder
            sb.AppendLine("#HDLib_BookInfo")
            sb.AppendLine("ID: " & ID)
            sb.AppendLine("Title: " & Title)
            sb.AppendLine("Subject: " & Subject)
            sb.AppendLine("Creator: " & Creator)
            sb.AppendLine("Series: " & Series)
            sb.AppendLine("Author: " & Author)
            sb.AppendLine("Contributor: " & Contributor)
            sb.AppendLine("Language: " & Language)
            sb.AppendLine("Version: " & Version)
            sb.AppendLine("Category: " & Category)
            sb.AppendLine("Special: " & Special)
            sb.AppendLine("Cover: " & Cover)
            sb.AppendLine("Created: " & Created)
            sb.AppendLine("Updated: " & Updated)
            sb.AppendLine("ViewLink: " & ViewLink)
            sb.AppendLine("FileLink: " & FileLink)
            sb.AppendLine("CoverLink: " & CoverLink)
            sb.AppendLine("Intro: ")
            sb.AppendLine(Intro)
            Return sb.ToString
        End Get
    End Property

    Public Sub Export(FolderPath As String)
        Try
            File.WriteAllText(Path.Combine(FolderPath, "Book.kzinf"), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(FolderPath As String)
        Dim fn As String = Path.Combine(FolderPath, "Book.kzinf")
        Try
            Using fs As FileStream = New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, head, value As String
                    Dim pos As Integer

                    line = sr.ReadLine()
                    If line = "#HDLib_BookInfo" Then
                        Do
                            line = sr.ReadLine()

                            If line.Contains(":") Then
                                pos = line.IndexOf(":")
                                head = line.Substring(0, pos)
                                value = line.Substring(pos + 1).Trim

                                Select Case head
                                    Case "ID" : ID = value
                                    Case "Title" : Title = value
                                    Case "Subject" : Subject = value
                                    Case "Creator" : Creator = value
                                    Case "Series" : Series = value
                                    Case "Author" : Author = value
                                    Case "Contributor" : Contributor = value
                                    Case "Language" : Language = value
                                    Case "Version" : Version = value
                                    Case "Category" : Category = value
                                    Case "Special" : Special = value
                                    Case "Cover" : Cover = value
                                    Case "Created" : Created = value
                                    Case "Updated" : Updated = value
                                    Case "ViewLink" : ViewLink = value
                                    Case "FileLink" : FileLink = value
                                    Case "CoverLink" : CoverLink = value
                                    Case "Intro" : Intro = sr.ReadToEnd
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
