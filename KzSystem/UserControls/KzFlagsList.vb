Imports System.Text.RegularExpressions

Public Class KzFlagsList
    Inherits CheckedListBox

    Public Sub New(EnumType As Type)

        Items.AddRange([Enum].GetNames(EnumType))

    End Sub


End Class