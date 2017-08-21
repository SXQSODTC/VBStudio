'/// <summary>
'/// 对ListView点击列标题自动排序功能
'/// </summary>
Public Class ListViewHelper
    '/// 构造函数
    Public Sub New()

    End Sub

    Public Shared Sub ListView_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        Dim lv As ListView
        lv = DirectCast(sender, ListView)

        '// 检查点击的列是不是现在的排序列.
        If DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).SortColumn = e.Column Then
            '// 重新设置此列的排序方法.
            If System.Windows.Forms.SortOrder.Ascending = DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order Then '1
                DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending  '2
            Else
                DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending   '1
            End If
        Else
            '// 设置排序列，默认为正向排序
            DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).SortColumn = e.Column
            DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending   '1
        End If
        '// 用新的排序方法对ListView排序
        '((System.Windows.Forms.ListView)sender).Sort()
        DirectCast(sender, ListView).Sort()

        '// 設色，add by kk
        SetListColor(lv)
    End Sub

    Public Shared Sub SetListColor(ByVal TheList As ListView)
        If TheList.View = View.Details And TheList.Columns.Count > 0 And TheList.Items.Count > 0 Then
            For i As Integer = 0 To TheList.Items.Count - 1
                If i Mod 2 = 0 Then
                    TheList.Items(i).BackColor = Color.WhiteSmoke
                Else
                    TheList.Items(i).BackColor = Color.Snow
                End If
            Next
        End If
    End Sub


End Class

'/// <summary>
'/// 继承自IComparer
'/// </summary>
Public Class ListViewColumnSorter

    Implements System.Collections.IComparer

    '/// <summary>
    '/// 指定按照哪个列排序
    '/// </summary>
    Private ColumnToSort As Integer

    '/// <summary>
    '/// 指定排序的方式
    '/// </summary>
    Private OrderOfSort As System.Windows.Forms.SortOrder

    '/// <summary>
    '/// 声明CaseInsensitiveComparer类对象
    '/// </summary>
    Private ObjectCompare As System.Collections.CaseInsensitiveComparer

    '/// <summary>
    '/// 构造函数
    '/// </summary>
    Public Sub New()
        '// 默认按第一列排序
        ColumnToSort = 0

        '// 排序方式为不排序
        OrderOfSort = System.Windows.Forms.SortOrder.None

        '// 初始化CaseInsensitiveComparer类对象
        ObjectCompare = New System.Collections.CaseInsensitiveComparer
    End Sub

    '/// <summary>
    '/// 重写IComparer接口.
    '/// </summary>
    '/// <param name="x">要比较的第一个对象</param>
    '/// <param name="y">要比较的第二个对象</param>
    '/// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim compareResult As Integer

        '// 将比较对象转换为ListViewItem对象
        Dim listviewX As ListViewItem
        Dim listviewY As ListViewItem

        listviewX = DirectCast(x, ListViewItem)
        listviewY = DirectCast(y, ListViewItem)

        Dim xText As String = listviewX.SubItems(ColumnToSort).Text
        Dim yText As String = listviewY.SubItems(ColumnToSort).Text

        'Dim xInt, yInt As Integer

        '//比较对象
        compareResult = ObjectCompare.Compare(xText, yText)

        '// 根据上面的比较结果返回正确的比较结果
        If (OrderOfSort = System.Windows.Forms.SortOrder.Ascending) Then
            '// 因为是正序排序，所以直接返回结果
            Return compareResult
        ElseIf (OrderOfSort = System.Windows.Forms.SortOrder.Descending) Then
            '// 如果是反序排序，所以要取负值再返回
            Return (-compareResult)
        Else
            '// 如果相等返回0
            Return 0
        End If
    End Function

    '/// <summary>
    '/// 获取或设置按照哪一列排序.
    '/// </summary>
    Public Property SortColumn() As Integer
        Get
            Return ColumnToSort
        End Get

        Set(ByVal Value As Integer)
            ColumnToSort = Value
        End Set
    End Property

    '/// <summary>
    '/// 获取或设置排序方式.
    '/// </summary>
    Public Property Order() As System.Windows.Forms.SortOrder
        Get
            Return OrderOfSort
        End Get

        Set(ByVal Value As System.Windows.Forms.SortOrder)
            OrderOfSort = Value
        End Set
    End Property
End Class

'//调用方法，在窗体启动函数内加上以下两句
'// Me.ListView1.ListViewItemSorter = New ListViewColumnSorter
'// AddHandler Me.ListView1.ColumnClick, New ColumnClickEventHandler(AddressOf ListViewHelper.ListView_ColumnClick)
'//


Public Class ListBoxHelper
    Public Shared Sub MoveListItem(ByVal ThisListBox As ListBox, ByVal FromIndex As Integer, ByVal ToIndex As Integer)
        Dim TempListItem As String

        With ThisListBox
            If .SelectedItems.Count > 0 Then
                TempListItem = .Items(FromIndex).ToString
                .Items.RemoveAt(FromIndex)
                .Items.Insert(ToIndex, TempListItem)
            End If
        End With
    End Sub
End Class