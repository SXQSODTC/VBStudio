
Public Class KzFileTypeDictionary
    Inherits Dictionary(Of String, KzFileTypeDictionaryItem)

    Public Sub New()

    End Sub

    Public Sub Import(FilePath As String)
        Dim f As String = "TextList\FileTypes.kzdic"

    End Sub
End Class

Public Structure KzFileTypeDictionaryItem
    Public Property Extension As String
    Public Property ShortDesc As String
    Public Property LongDesc As String
    Public Property Classify As String
End Structure