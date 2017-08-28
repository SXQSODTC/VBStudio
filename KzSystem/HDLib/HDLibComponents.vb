Imports System.IO
Imports System.Text

Public Module HDLib
    Public Const CSeparator As Char = "|"
    Public Const ISeparator As Char = ";"
End Module

Public Class HDManifest
    Inherits Dictionary(Of String, HDManifestItem)

    Public Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder

        sb.AppendLine("#HDLib_Manifest")
        For Each kvp As KeyValuePair(Of String, HDManifestItem) In Me
            sb.AppendLine(kvp.Value.ToString)
        Next

        Return sb.ToString
    End Function

    Public Sub Export(FolderPath As String)
        Try
            File.WriteAllText(Path.Combine(FolderPath, "Manifest.kzlst"), ToString, Encoding.UTF8)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Import(FolderPath As String)
        Dim fn As String = Path.Combine(FolderPath, "Manifest.kzlst")
        Try
            Using fs As FileStream = New FileStream(fn, FileMode.Open, FileAccess.Read)
                Using sr As StreamReader = New StreamReader(fs, Encoding.UTF8)
                    Dim line, head, value As String
                    Dim pos As Integer

                    line = sr.ReadLine()
                    If line = "#HDLib_Manifest" Then
                        Do
                            line = sr.ReadLine()

                            If line.Contains(":") Then
                                pos = line.IndexOf(":")
                                head = line.Substring(0, pos)
                                value = line.Substring(pos + 1).Trim

                                'Dim item As New HDManifestItem

                            End If
                        Loop Until sr.EndOfStream
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class HDManifestItem
    Public Sub New(FileName As String)
        Me.FileName = FileName
    End Sub

    Public Property FileName As String
    Public Property ReadingIndex As Integer = -1
    Public Property ReadingClass As String
    Public Property Type As HDManifestItemType = HDManifestItemType.Unknown
    Public Property Remarks As String

    Public Overrides Function ToString() As String
        Return FileName & ISeparator & " " &
            Type.ToString & ISeparator & " " &
            ReadingClass & ISeparator & " " &
            ReadingIndex.ToString & ISeparator & " " &
            Remarks
    End Function
End Class

Public Enum HDManifestItemType
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

Public Class HDFunctions
    Public Shared Function MIT(MITType As HDManifestItemType, Optional InChs As Boolean = False) As String
        Select Case MITType
            Case HDManifestItemType.Unknown : Return If(InChs, "未知”, "未知")
            Case HDManifestItemType.LibInfo : Return If(InChs, "庫資訊”, "库信息")
            Case HDManifestItemType.Package : Return If(InChs, "封裝檔”, "封装文件")
            Case HDManifestItemType.Editable : Return If(InChs, "編輯檔”, "编辑文件")
            Case HDManifestItemType.Printable : Return If(InChs, "印刷檔”, "印刷文件")
            Case HDManifestItemType.WebView : Return If(InChs, "瀏覽檔”, "浏览文件")
            Case HDManifestItemType.Image : Return If(InChs, "圖像”, "图像")
            Case HDManifestItemType.Video : Return If(InChs, "視訊”, "视频")
            Case HDManifestItemType.Audio : Return If(InChs, "音訊”, "音频")
            Case HDManifestItemType.Compressed : Return If(InChs, "壓縮檔”, "压缩文件")
            Case Else : Return If(InChs, "其他”, "其他")
        End Select
    End Function

    Public Shared Function CMIT(extension As String) As HDManifestItemType
        Select Case extension.ToLower
            Case ".updb", ".prc", ".mobi", ".epub"
                Return HDManifestItemType.Package ' "書籍"' "Package"
            Case ".doc", ".docx", ".txt", ".rtf"
                Return HDManifestItemType.Editable ' "文檔" '"Editable"
            Case ".pdf", ".djvu"
                Return HDManifestItemType.Printable ' "發佈" '"Published"
            Case ".html", ".htm", ".lnk"
                Return HDManifestItemType.WebView ' "網頁" '"Webpage"
            Case ".jpg", ".jepg", ".png", ".bmp", ".tif", ".tiff", ".gif"
                Return HDManifestItemType.Image ' "圖像" '"Image"
            Case ".kzinf", ".kzlst", ".inf", ".info", ".ini"
                Return HDManifestItemType.LibInfo ' "資訊" '"Libinfo"
            Case ".rar", ".zip", ".7z"
                Return HDManifestItemType.Compressed ' "壓縮" '"Compressed"
            Case ".avi", ".mkv", ".mov", ".ts", ".rmvb", ".mp4"
                Return HDManifestItemType.Video ' "視訊"
            Case ".mp3", ".flac", ".wav"
                Return HDManifestItemType.Audio ' "音訊"
            Case ""
                Return HDManifestItemType.Unknown
            Case Else
                Return HDManifestItemType.Others
        End Select
    End Function
End Class


