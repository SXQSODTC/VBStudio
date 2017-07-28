'Imports System
'Imports System.Collections.Generic
'Imports System.Linq
'Imports System.Xml.Linq

Public Class PList
    Inherits Dictionary(Of String, Object)

    Public Sub New()
    End Sub

    Public Sub New(file As String)
        Load(file)
    End Sub

    Public Sub Load(file As String)
        Clear()
        Dim doc As XDocument = XDocument.Load(file)
        Dim plist As XElement = doc.Element("plist")
        Dim dict As XElement = plist.Element("dict")

        Dim dictElements = dict.Elements()
        Parse(Me, dictElements)
    End Sub

    Private Sub Parse(dict As PList, elements As IEnumerable(Of XElement))
        For i As Integer = 0 To elements.Count() - 1 Step 2
            Dim key As XElement = elements.ElementAt(i)
            Dim val As XElement = elements.ElementAt(i + 1)
            dict(key.Value) = ParseValue(val)
        Next
    End Sub

    Private Function ParseArray(elements As IEnumerable(Of XElement)) As List(Of Object)
        Dim list As List(Of Object) = New List(Of Object)
        For Each e As XElement In elements
            Dim one As Object = ParseValue(e)
            list.Add(one)
        Next
        Return list
    End Function

    Private Function ParseValue(val As XElement) As Object
        Select Case val.Name.ToString
            Case "string" : Return val.Value
            Case "integer" : Return Int32.Parse(val.Value)
            Case "real" : Return Double.Parse(val.Value)
            Case "true" : Return True
            Case "false" : Return False
            Case "dict"
                Dim plist As PList = New PList
                Parse(plist, val.Elements())
                Return plist
            Case "array"
                Dim list As List(Of Object) = ParseArray(val.Elements())
                Return list
            Case Else
                Throw New ArgumentException("Unsupported")
        End Select
    End Function

    'Using the code:
    '================================
    'Dim plist As PList = New PList()
    'plist.Load("file_path.plist")
    '================================
    'or:
    '=================================================
    'Dim plist As PList = New PList("file_path.plist")
    '=================================================
    'To retrieve the parsed data it's all the same as using a generic Dictionary, 
    'considering the PList Is derived from Dictionary<String, dynamic>. 
    'The code might looks crude, because I'd like to only show the main idea here 
    'without disturbing noise. I think you could And should polish it before Using it, 
    'For example adding some Error/exception handling, Or adding a serialization method, 
    'etc. Those could be very simple tasks.
End Class

