Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Text

Public Class KzTabControl
    Inherits TabControl

    Private iA As KzTabsAppearance '= New KzTabsAppearance

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
        'iA = New KzTabsAppearance
    End Sub

#Region "Properties"
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
            iA = value
            Invalidate()
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

#End Region 'Properties

#Region "ProtectedMethods"
    Private TabLocatedMouse As TabPage
    Private ButtonLocatedMouse As Rectangle

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics

        KzPainting.SetHighQuality(g)

        Dim PageRect As Rectangle = Me.DisplayRectangle
        Dim TabRect As Rectangle 'Bounds of TabHeader
        'Dim CloseRect As Rectangle 'Bounds of CloseButton
        'Dim PlusRect As Rectangle 'Bounds of PlusButton
        'Dim TitleRect As Rectangle 'Bounds of Title's text

        '測試繪製
        Try
            For Each tp As TabPage In TabPages
                TabRect = GetTabRect(TabPages.IndexOf(tp))
                If iA.Tab.ShowBorder Then g.DrawRectangle(iA.Tab.BorderPen, TabRect)
            Next
            PageRect.Inflate(1, 1)
            If iA.Tab.ShowBorder Then g.DrawRectangle(iA.Tab.BorderPen, PageRect)

        Catch ex As Exception
            Console.WriteLine("<Paint exception!>")
        End Try


        Select Case Alignment
            Case TabAlignment.Top
            Case TabAlignment.Bottom
            Case TabAlignment.Left
            Case TabAlignment.Right
        End Select

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        Dim TabRect As Rectangle

        If TabPages.Count > 0 Then
            For Each tp As TabPage In TabPages
                TabRect = GetTabRect(TabPages.IndexOf(tp))
                If TabRect.Contains(e.Location) Then
                    TabLocatedMouse = tp

                End If
            Next
        End If

    End Sub
#End Region 'ProtectedMethods

#Region "PrivatePainting"
    Private Sub DrawButton(g As Graphics, tp As TabPage)

    End Sub

    Private Function GetCloseRect(tp As TabPage) As Rectangle

    End Function

    Private Function GetPlusRect() As Rectangle

    End Function

    Private Function GetIconRect(tp As TabPage) As Rectangle

    End Function
#End Region 'PrivatePainting

#Region "PublicMethods"
    Public Sub AddTab(tb As TabPage)

    End Sub

    Public Sub RemoveTab()

    End Sub
#End Region 'PublicMethods
End Class


''' <summary>
''' 用於描述 TabControl 的描畫呈現
''' </summary>
Public Class KzTabsAppearance
    Public Sub New()

    End Sub
    'Public Property Name As String = "NewLook"

    Public Property Appearance As TabAppearance = TabAppearance.Normal
    Public Property Alignment As TabAlignment = TabAlignment.Top

    Public Property TabPageStyle As KzTabPageStyle = KzTabPageStyle.None

    Public Property ShowAddNewTab As Boolean = False
    Public Property SelectedTabCanClose As Boolean = False
    Public Property NormalTabCanClose As Boolean = False

    Public Property Tab As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property TabHover As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property SelectedTab As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property SelectedTabHover As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property Button As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property ButtonHover As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property SelectedButton As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property SelectedButtonHover As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property AddTab As KzTabStatusAppearance = New KzTabStatusAppearance
    Public Property AddTabHover As KzTabStatusAppearance = New KzTabStatusAppearance

    Public Function GetCode(name As String, Optional tabWidth As Integer = 4) As String
        Dim sb As New StringBuilder
        Dim tab As String = Strings.StrDup(tabWidth, " ")

        sb.AppendLine("' " & name)
        sb.AppendLine("Dim " & name & " As New KzTabsAppearance")
        sb.AppendLine("With " & name)
        sb.AppendLine(tab & ".Appearance = TabAppearance." & Appearance.ToString)
        sb.AppendLine(tab & ".Alignment = TabAlignment." & Alignment.ToString)
        sb.AppendLine(tab & ".TabPageStyle = KzTabPageStyle." & TabPageStyle.ToString)
        sb.AppendLine(tab & ".ShowAddNewTab = " & ShowAddNewTab.ToString)
        sb.AppendLine(tab & ".SelectedTabCanClose = " & SelectedTabCanClose.ToString)
        sb.AppendLine(tab & ".NormalTabCanClose = " & NormalTabCanClose.ToString)
        sb.AppendLine(tab & ".Tab = " & name & "Tab")
        sb.AppendLine(tab & ".TabHover = " & name & "TabHover")
        sb.AppendLine(tab & ".SelectedTab = " & name & "SelectedTab")
        sb.AppendLine(tab & ".SelectedTabHover = " & name & "SelectedTabHover")
        sb.AppendLine(tab & ".Button = " & name & "Button")
        sb.AppendLine(tab & ".ButtonHover = " & name & "ButtonHover")
        sb.AppendLine(tab & ".SelectedButton = " & name & "SelectedButton")
        sb.AppendLine(tab & ".SelectedButtonHover = " & name & "SelectedButtonHover")
        sb.AppendLine(tab & ".AddTab = " & name & "AddTab")
        sb.AppendLine(tab & ".AddTabHover = " & name & "AddTabHover")
        sb.AppendLine("End With")
        Return sb.ToString
    End Function
End Class
''' <summary>
''' 依據狀態描述單個 Tab 的呈現 
''' </summary>
Public Class KzTabStatusAppearance
    Public Sub New()

    End Sub

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
            If BlodBorder Then
                Return New Pen(BorderColor, 2)
            Else
                Return New Pen(BorderColor, 1)
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

    Public Function GetCode(name As String, Optional tabWidth As Integer = 4) As String
        Dim sb As New StringBuilder
        Dim tab As String = Strings.StrDup(tabWidth, " ")

        sb.AppendLine("' " & name)
        sb.AppendLine("Dim " & name & " As New KzTabStatusAppearance")
        sb.AppendLine("With " & name)
        sb.AppendLine(tab & ".ShowBorder = " & ShowBorder.ToString)
        sb.AppendLine(tab & ".BlodBorder = " & BlodBorder.ToString)
        sb.AppendLine(tab & ".ShowShadow = " & ShowShadow.ToString)
        sb.AppendLine(tab & ".ShadowSide = KzFlatSides." & ShadowSide.ToString)
        sb.AppendLine(tab & ".ShowRadius = " & ShowRadius.ToString)
        sb.AppendLine(tab & ".RadiusSide = KzFlatCorners." & RadiusSide.ToString)
        sb.AppendLine(tab & ".BorderColor = " & KzColorHelper.GetColorDescription(BorderColor))
        sb.AppendLine(tab & ".BackColor = " & KzColorHelper.GetColorDescription(BackColor))
        sb.AppendLine(tab & ".ForeColor = " & KzColorHelper.GetColorDescription(ForeColor))
        sb.AppendLine(tab & ".BlodFore = " & BlodFore.ToString)
        sb.AppendLine("End With")
        Return sb.ToString
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

Public Class KzTextTab
    Inherits TabPage

End Class

Public Class KzRichTab
    Inherits TabPage

End Class

Public Class KzWebTap
    Inherits TabPage

End Class
