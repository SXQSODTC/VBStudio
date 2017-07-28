Imports System.Drawing.Drawing2D

Public Class KzTabControl
    Inherits TabControl

    Private iA As KzTabsAppearance

    Public Sub New()
        DrawMode = TabDrawMode.OwnerDrawFixed
        SizeMode = TabSizeMode.Fixed

        MyBase.SetStyle(ControlStyles.UserPaint Or              '// 控件将自行绘制，而不是通过操作系统来绘制
                ControlStyles.OptimizedDoubleBuffer Or          '// 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁
                ControlStyles.AllPaintingInWmPaint Or           '// 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁
                ControlStyles.ResizeRedraw Or                   '// 在调整控件大小时重绘控件
                ControlStyles.SupportsTransparentBackColor,     '// 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明
                True)                                           '// 设置以上值为 true

        MyBase.UpdateStyles()
        iA = New KzTabsAppearance
    End Sub
    ''' <summary>
    ''' 用於命名新 TabPage 的前綴，與 NewSerialNumber 同時使用。格式為 NewTitlePrefix + NewSerialNumber 的字符串
    ''' </summary>
    ''' <returns></returns>
    Public Property NewTitlePrefix As String = "NewTab"
    ''' <summary>
    ''' 指示新增 TabPage 時是否即使應用選擇
    ''' </summary>
    ''' <returns></returns>
    Public Property NewAddedAutoSelect As Boolean = True
    ''' <summary>
    ''' 讀取或設置用於繪製 Tabs 的呈現
    ''' </summary>
    ''' <returns></returns>
    Public Property TabsAppearance As KzTabsAppearance
        Get
            Return iA
        End Get
        Set(value As KzTabsAppearance)
            If Not iA.Equals(value) Then
                iA = value

            End If
        End Set
    End Property
    ''' <summary>
    ''' 在當前狀態下取得用於命名新 TabPage 的索引號，從 0 開始按 1 遞增
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property NewSerialNumber As Integer
        Get
            Dim newStr As String
            If Me.NewTitlePrefix Is Nothing Then ' Or Me.NewTitlePrefix = "" Then
                newStr = ""
            Else
                newStr = Me.NewTitlePrefix
            End If

            Dim i As Integer = 0

            For Each tp As TabPage In Me.TabPages
                If tp.Text.StartsWith(newStr) Then
                    Dim x As Integer
                    Try
                        x = CInt(tp.Text.Substring(Me.NewTitlePrefix.Length))
                    Catch ex As Exception
                        x = 0
                    End Try

                    i = Math.Max(i, x)
                End If
            Next

            Return i + 1
        End Get
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
    End Sub
    ''' <summary>
    ''' 繪製 Tabs，以最高質量繪製
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        KzPainting.SetHighQuality(g)

        Dim rTab As Rectangle
        Dim rDisp As Rectangle = Me.DisplayRectangle

        For Each tp As TabPage In TabPages
            rTab = GetTabRect(TabPages.IndexOf(tp))
            g.DrawRectangle(New Pen(Color.Blue), rTab)
        Next
        rDisp.Inflate(1, 1)
        g.DrawRectangle(New Pen(Color.Red), rDisp)
    End Sub
End Class


''' <summary>
''' 用於描述 TabControl 的描畫呈現
''' </summary>
Public Class KzTabsAppearance

#Region "InternalDeclaration"
    Private _theAppearance As TabAppearance
    Private _theAlignment As TabAlignment

#End Region 'InternalDeclaration

    Public Property Appearance As TabAppearance = TabAppearance.Normal
    Public Property Alignment As TabAlignment = TabAlignment.Top

    Public Property TabPageStyle As KzTabPageStyle = KzTabPageStyle.None

    Public Property ShowAddNewTab As Boolean = False
    Public Property SelectedTabCanClose As Boolean = False
    Public Property NormalTabCanClose As Boolean = False

    Public Property Tab As KzTabStatusAppearance
    Public Property TabHover As KzTabStatusAppearance
    Public Property SelectedTab As KzTabStatusAppearance
    Public Property SelectedTabHover As KzTabStatusAppearance
    Public Property Button As KzTabStatusAppearance
    Public Property ButtonHover As KzTabStatusAppearance
    Public Property SelectedButton As KzTabStatusAppearance
    Public Property SelectedButtonHover As KzTabStatusAppearance
    Public Property AddTab As KzTabStatusAppearance
    Public Property AddTabHover As KzTabStatusAppearance

    Public ReadOnly Property Elements As KzTabStatusAppearance()
        Get
            Return {Tab, TabHover, SelectedTab, SelectedTabHover,
                Button, ButtonHover, SelectedButton, SelectedButtonHover,
                AddTab, AddTabHover}
        End Get
    End Property
End Class
''' <summary>
''' 依據狀態描述單個 Tab 的呈現 
''' </summary>
Public Class KzTabStatusAppearance

    Public Property ShowBorder As Boolean = False
    Public Property BlodBorder As Boolean = False
    Public Property ShowShadow As Boolean = False
    Public Property ShadowSide As KzFlatSides = KzFlatSides.None
    Public Property ShowRadius As Boolean = False
    Public Property RadiusSide As KzFlatCorners = KzFlatCorners.None

    Public Property BorderColor As Color = SystemColors.ActiveBorder
    Public Property BackColor As Color = SystemColors.Control
    Public Property ForeColor As Color = SystemColors.ControlText
    Public Property BlodFore As Boolean = False

    Public ReadOnly Property BorderPen As Pen
        Get
            If ShowBorder Then
                If BlodBorder Then
                    Return New Pen(BorderColor, 2)
                Else
                    Return New Pen(BorderColor, 1)
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property BackBrush As Brush
        Get
            Return New SolidBrush(BackColor)
        End Get
    End Property

    Public ReadOnly Property ForePen As Pen
        Get
            If BlodFore Then
                Return New Pen(ForeColor, 2)
            Else
                Return New Pen(ForeColor, 1)
            End If
        End Get
    End Property

    Public Function Font(baseFont As Font) As Font
        If BlodFore Then
            Return New Font(baseFont.FontFamily, FontStyle.Bold)
        Else
            Return baseFont
        End If
    End Function
End Class
''' <summary>
''' KzSystem 定制 TabPage 形式
''' </summary>
Public Enum KzTabPageStyle
    ''' <summary>
    ''' 未指定，對 Page 不作修飾
    ''' </summary>
    None
    ''' <summary>
    ''' Page 呈現範圍周邊描畫 Frame，可應用 Tab 的 BorderColor 或 BackColor
    ''' </summary>
    PageFrame
    ''' <summary>
    ''' 在 Tab 和 Page 之間描畫分割線，可應用 Tab 的 BorderColor 或 BackColor
    ''' </summary>
    SideLine
    ''' <summary>
    ''' Page 呈現範圍周邊描畫 Frame，但 Tab 接壤處不描畫
    ''' </summary>
    OpenPageFrame
    ''' <summary>
    ''' 在 Tab 和 Page 之間描畫分割線，但 Tab 接壤處不描畫
    ''' </summary>
    OpenSideLine
End Enum
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
End Enum
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
End Enum

