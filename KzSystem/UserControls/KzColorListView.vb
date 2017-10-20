Imports System.IO

Public Class KzColorListView
    Inherits ListView

    Public Sub New()
        View = View.Details
        FullRowSelect = True
        'OwnerDraw = True
        CheckBoxes = True

        With Columns
            .Add("Name", 100, HorizontalAlignment.Center)
            .Add("Red", 100, HorizontalAlignment.Center)
            .Add("Green", 100, HorizontalAlignment.Center)
            .Add("Blue", 100, HorizontalAlignment.Center)
            .Add("CName", 100, HorizontalAlignment.Center)
        End With

        'GetNamedColors()
    End Sub




    Private Sub GetNamedColors()
        Dim l As String

        Using fs As FileStream = New FileStream("TextList/ColorList.kzdic", FileMode.Open, FileAccess.Read)
            Using sr As StreamReader = New StreamReader(fs)

                Do
                    l = sr.ReadLine()
                    'MsgBox(l)
                    Items.Add(GetColorItem(l))
                Loop Until sr.EndOfStream
            End Using
        End Using

    End Sub

    Private Function GetColorItem(line As String) As ListViewItem
        Dim item As New ListViewItem
        Dim keys As String() = line.Split(",")
        With item
            .Name = keys(0)

            For i As Integer = 0 To 4
                .SubItems.Add(keys(i))
            Next
        End With

        Return item
    End Function
End Class