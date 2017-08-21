''' <summary>
''' 
''' </summary>
Public Enum KzItemPosition
    None
    FirstItem
    PreviousItem
    NextItem
    LastItem
    Current
End Enum 'KzItemPosition
''' <summary>
''' 
''' </summary>
Public Enum KzActionStatus
    Normal
    Hover
    Pressed
    Checked
End Enum 'KzActionStatus
''' <summary>
''' KzSystem 定制針對方形對象之「邊」的描述
''' </summary>
Public Enum KzFlatSides
    ''' <summary>
    ''' 未指定
    ''' </summary>
    None
    ''' <summary>
    ''' 四邊皆有
    ''' </summary>
    All
    ''' <summary>
    ''' 上邊
    ''' </summary>
    Top
    ''' <summary>
    ''' 下邊
    ''' </summary>
    Bottom
    ''' <summary>
    ''' 左邊
    ''' </summary>
    Left
    ''' <summary>
    ''' 右邊
    ''' </summary>
    Right
    ''' <summary>
    ''' 水平兩邊，即 Left and Right
    ''' </summary>
    Horizontal
    ''' <summary>
    ''' 垂直兩邊，即 Top and Bottom
    ''' </summary>
    Vertical
    ''' <summary>
    ''' 左邊及上邊，等同於 TopLeft，可用於描畫順序之區別
    ''' </summary>
    LeftTop
    ''' <summary>
    ''' 上邊及左邊，等同於 LeftTop，可用於描畫順序之區別
    ''' </summary>
    TopLeft
    ''' <summary>
    ''' 右邊及上邊，等同於 TopRight，可用於描畫順序之區別
    ''' </summary>
    RightTop
    ''' <summary>
    ''' 上邊及右邊，等同於 RightTop，可用於描畫順序之區別
    ''' </summary>
    TopRight
    ''' <summary>
    ''' 左邊及下邊，等同於 BottomLeft，可用於描畫順序之區別
    ''' </summary>
    LeftBottom
    ''' <summary>
    ''' 下邊及左邊，等同於 BottomLeft，可用於描畫順序之區別
    ''' </summary>
    BottomLeft
    ''' <summary>
    ''' 右邊及下邊，等同於 BottomRight，可用於描畫順序之區別
    ''' </summary>
    RightBottom
    ''' <summary>
    ''' 下邊及右邊，等同於 RightBottom，可用於描畫順序之區別
    ''' </summary>
    BottomRight
End Enum 'KzFlatSides
''' <summary>
''' KzSystem 定制針對方形對象之「角」的描述
''' </summary>
Public Enum KzFlatCorners
    ''' <summary>
    ''' 未設定
    ''' </summary>
    None
    ''' <summary>
    ''' 四角皆有
    ''' </summary>
    All
    ''' <summary>
    ''' 左上角，等同於 TopLeft
    ''' </summary>
    LeftTop
    ''' <summary>
    ''' 左上角，等同於 LeftTop
    ''' </summary>
    TopLeft
    ''' <summary>
    ''' 右上角，等同於 TopRight
    ''' </summary>
    RightTop
    ''' <summary>
    ''' 右上角，等同於 RightTop
    ''' </summary>
    TopRight
    ''' <summary>
    ''' 左下角，等同於 BottomLeft
    ''' </summary>
    LeftBottom
    ''' <summary>
    ''' 左下角，等同於 LeftBottom
    ''' </summary>
    BottomLeft
    ''' <summary>
    ''' 右上角，等同於 BottomRight
    ''' </summary>
    RightBottom
    ''' <summary>
    ''' 右上角，等同於 RightBottom
    ''' </summary>
    BottomRight
    ''' <summary>
    ''' 上方兩角，即 TopLeft + TopRight
    ''' </summary>
    Top
    ''' <summary>
    ''' 左方兩角，即 TopLeft + LeftBottom
    ''' </summary>
    Left
    ''' <summary>
    ''' 右方兩角，即 TopRight + RightBottom
    ''' </summary>
    Right
    ''' <summary>
    ''' 下方兩角，即 LeftBottom + RightBottom
    ''' </summary>
    Bottom
End Enum 'KzFlatCorners