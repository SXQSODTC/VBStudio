Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Text

Public Class KzTabControl
    Inherits TabControl

    Private iA As KzTabsAppearance = New KzTabsAppearance
    Private iNew As Boolean = False

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
        'TabsAppearance = New KzTabsAppearance
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
    ''' 具備點擊新增功能的特殊 TabPage
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AddNewTab As TabPage = New TabPage("+")
    ''' <summary>
    ''' 指示是否使用新增 Tab
    ''' </summary>
    ''' <returns></returns>
    Public Property ShowAddNewTab As Boolean
        Get
            Return iNew
        End Get
        Set(value As Boolean)
            iNew = value

            If iNew Then
                TabPages.Add(AddNewTab)
            Else
                TabPages.Remove(AddNewTab)
            End If
            'Invalidate()
        End Set
    End Property
    ''' <summary>
    ''' 指示新增後是否選中新 Tab
    ''' </summary>
    ''' <returns></returns>
    Public Property SelectAfterAdd As Boolean = True
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
    Private HoveringTab As TabPage
    Private HoveringBTRect As Rectangle

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics

        KzPainting.SetHighQuality(g)

        '<測試繪製>
        'Dim PageRect As Rectangle = DisplayRectangle
        'Dim TabRect As Rectangle 'Bounds of TabHeader
        'Try
        '    For Each tp As TabPage In TabPages
        '        TabRect = GetTabRect(TabPages.IndexOf(tp))
        '        If iA.SetOfNormalTab.ShowBorder Then g.DrawRectangle(iA.SetOfNormalTab.BorderPen, TabRect)
        '    Next
        '    PageRect.Inflate(1, 1)
        '    If iA.SetOfNormalTab.ShowBorder Then g.DrawRectangle(iA.SetOfNormalTab.BorderPen, PageRect)

        'Catch ex As Exception
        '    Console.WriteLine("<Paint exception!>")
        'End Try
        '</測試結束>

        'Select Case Alignment
        '    Case TabAlignment.Top
        '    Case TabAlignment.Bottom
        '    Case TabAlignment.Left
        '    Case TabAlignment.Right
        'End Select

        For Each tp As TabPage In TabPages
            DrawTab(g, tp)
        Next

    End Sub

    Public Property HoveringSignLabel As ToolStripLabel

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        Dim tp As TabPage = GetTabAtPoint(e.Location)
        Dim r As Rectangle '= 

        If tp IsNot Nothing Then
            HoveringTab = tp
            r = GetButtonRect(tp)

            If r.Contains(e.Location) Then
                HoveringBTRect = r
            Else
                HoveringBTRect = New Rectangle
            End If

        Else
            HoveringTab = Nothing
            HoveringBTRect = New Rectangle
        End If

        Try
            If HoveringSignLabel IsNot Nothing Then
                Dim ht As String = If(HoveringTab Is Nothing, "#", TabPages.IndexOf(HoveringTab))
                Dim hr As String = If(HoveringBTRect.Equals(New Rectangle), "#", "R")
                HoveringSignLabel.Text = "HTab: " & ht & " , HRect: " & hr & " , STab: " & TabPages.IndexOf(SelectedTab)
            End If
        Catch ex As Exception

        End Try

        Invalidate()
    End Sub

    Protected Overrides Sub OnSelecting(e As TabControlCancelEventArgs)
        MyBase.OnSelecting(e)

        If e.TabPage.Equals(AddNewTab) Then
            e.Cancel = True
        End If
    End Sub
#End Region 'ProtectedMethods

#Region "PrivateGet"
    Private Function GetTabAtPoint(pt As Point) As TabPage
        Dim TabRect As Rectangle

        If TabPages.Count > 0 Then
            For Each tp As TabPage In TabPages
                TabRect = GetTabRect(TabPages.IndexOf(tp))
                If TabRect.Contains(pt) Then
                    Return tp
                    Exit For
                End If
            Next
        End If

        Return Nothing
    End Function

    Private Function GetButtonRect(tp As TabPage) As Rectangle
        If tp.Equals(AddNewTab) Then
            If Not ShowAddNewTab Then
                Return New Rectangle
            End If
        ElseIf tp.Equals(SelectedTab) Then
            If Not iA.SelectedTabCanClose Then
                Return New Rectangle
            End If
        Else
            If Not iA.NormalTabCanClose Then
                Return New Rectangle
            End If
        End If

        Dim TabRect As Rectangle = GetTabRect(TabPages.IndexOf(tp))
        Dim ButtonSideLength As Integer

        Select Case Alignment
            Case TabAlignment.Top, TabAlignment.Bottom
                ButtonSideLength = TabRect.Height - iA.ButtonMargin.Vertical

                If tp.Equals(AddNewTab) Then
                    Return New Rectangle(
                        x:=TabRect.X + iA.ButtonMargin.Left,
                        y:=TabRect.Y + iA.ButtonMargin.Top,
                        width:=ButtonSideLength,
                        height:=ButtonSideLength)
                Else
                    Return New Rectangle(
                        x:=TabRect.X + (TabRect.Width - ButtonSideLength - iA.ButtonMargin.Right),
                        y:=TabRect.Y + iA.ButtonMargin.Top,
                        width:=ButtonSideLength,
                        height:=ButtonSideLength)
                End If

            Case TabAlignment.Left, TabAlignment.Right
                ButtonSideLength = TabRect.Width - iA.ButtonMargin.Horizontal

                If tp.Equals(AddNewTab) Then
                    Return New Rectangle(
                        x:=TabRect.X + iA.ButtonMargin.Left,
                        y:=TabRect.Y + iA.ButtonMargin.Top,
                        width:=ButtonSideLength,
                        height:=ButtonSideLength)
                Else
                    Return New Rectangle(
                        x:=TabRect.X + iA.ButtonMargin.Left,',
                        y:=TabRect.Y + (TabRect.Height - ButtonSideLength - iA.ButtonMargin.Bottom),
                        width:=ButtonSideLength,
                        height:=ButtonSideLength)
                End If
        End Select
    End Function

    Private Function GetTextRect(tp As TabPage) As Rectangle
        If tp.Equals(AddNewTab) Then
            Return New Rectangle
        End If

        Dim TabRect As Rectangle = GetTabRect(TabPages.IndexOf(tp))
        Dim BtnRect As Rectangle = GetButtonRect(tp)
        Dim ImgRect As Rectangle = GetIconRect(tp)
        Dim Gap As Integer = 2 'of Img and Txt

        If BtnRect.Equals(New Rectangle) And ImgRect.Equals(New Rectangle) Then
            '無圖標，無按鈕
            Return New Rectangle(
                x:=TabRect.X + iA.TextMargin.Left,
                y:=TabRect.Y + iA.TextMargin.Top,
                width:=TabRect.Width - iA.TextMargin.Horizontal,
                height:=TabRect.Height - iA.TextMargin.Vertical)
        ElseIf BtnRect.Equals(New Rectangle) And Not ImgRect.Equals(New Rectangle) Then
            '有圖標，無按鈕
            Select Case Alignment
                Case TabAlignment.Top, TabAlignment.Bottom
                    Return New Rectangle(
                        x:=TabRect.X + iA.TextMargin.Left + ImgRect.Width + Gap,
                        y:=TabRect.Y + iA.TextMargin.Top,
                        width:=TabRect.Width - iA.TextMargin.Left - ImgRect.Width - Gap - iA.TextMargin.Right,
                        height:=TabRect.Height - iA.TextMargin.Vertical)
                Case TabAlignment.Left, TabAlignment.Right
                    Return New Rectangle(
                       x:=TabRect.X + iA.TextMargin.Left,
                       y:=TabRect.Y + iA.TextMargin.Top + ImgRect.Height + Gap,
                       width:=TabRect.Width - iA.TextMargin.Horizontal,
                       height:=TabRect.Height - iA.TextMargin.Top - ImgRect.Height - Gap - iA.TextMargin.Bottom)
            End Select
        ElseIf Not BtnRect.Equals(New Rectangle) And ImgRect.Equals(New Rectangle) Then
            '無圖標，有按鈕
            Select Case Alignment
                Case TabAlignment.Top, TabAlignment.Bottom
                    Return New Rectangle(
                        x:=TabRect.X + iA.TextMargin.Left,
                        y:=TabRect.Y + iA.TextMargin.Top,
                        width:=TabRect.Width - iA.TextMargin.Left - BtnRect.Width - iA.ButtonMargin.Horizontal,
                        height:=TabRect.Height - iA.TextMargin.Vertical)
                Case TabAlignment.Left, TabAlignment.Right
                    Return New Rectangle(
                        x:=TabRect.X + iA.TextMargin.Left,
                        y:=TabRect.Y + iA.TextMargin.Top,
                        width:=TabRect.Width - iA.TextMargin.Horizontal,
                        height:=TabRect.Height - iA.TextMargin.Top - BtnRect.Height - iA.ButtonMargin.Vertical)
            End Select
        ElseIf Not BtnRect.Equals(New Rectangle) And Not ImgRect.Equals(New Rectangle) Then
            '有圖標，有按鈕
            Select Case Alignment
                Case TabAlignment.Top, TabAlignment.Bottom
                    Return New Rectangle(
                        x:=TabRect.X + iA.TextMargin.Left + ImgRect.Width + Gap,
                        y:=TabRect.Y + iA.TextMargin.Top,
                        width:=TabRect.Width - iA.TextMargin.Left - ImgRect.Width - Gap - iA.TextMargin.Right - BtnRect.Width - iA.ButtonMargin.Right,
                        height:=TabRect.Height - iA.TextMargin.Vertical)
                Case TabAlignment.Left, TabAlignment.Right
                    Return New Rectangle(
                       x:=TabRect.X + iA.TextMargin.Left,
                       y:=TabRect.Y + iA.TextMargin.Top + ImgRect.Height + Gap,
                       width:=TabRect.Width - iA.TextMargin.Horizontal,
                       height:=TabRect.Height - iA.TextMargin.Top - ImgRect.Height - Gap - iA.TextMargin.Bottom - BtnRect.Height - iA.ButtonMargin.Bottom)
            End Select
        End If
    End Function

    Private Function GetIconRect(tp As TabPage) As Rectangle
        If tp.Equals(AddNewTab) Then
            Return New Rectangle
        Else
            If Not iA.ShowIcon Then
                Return New Rectangle
            End If
        End If

        Dim TabRect As Rectangle = GetTabRect(TabPages.IndexOf(tp))
        Dim ImgSideLength As Integer

        Select Case Alignment
            Case TabAlignment.Top, TabAlignment.Bottom
                ImgSideLength = TabRect.Height - iA.TextMargin.Vertical
            Case TabAlignment.Left, TabAlignment.Right
                ImgSideLength = TabRect.Width - iA.TextMargin.Horizontal
        End Select

        Return New Rectangle(
                    x:=TabRect.X + iA.TextMargin.Left,
                    y:=TabRect.Y + iA.TextMargin.Top,
                    width:=ImgSideLength,
                    height:=ImgSideLength)
    End Function
#End Region 'PrivateGet

#Region "PrivatePaint"
    Private Sub DrawTab(g As Graphics, tp As TabPage)
        Dim tabSApr, btnSApr As KzTabStatusAppearance
        Dim tabRect As Rectangle = GetTabRect(TabPages.IndexOf(tp))
        Dim btnRect As Rectangle = GetButtonRect(tp)
        Dim txtRect As Rectangle = GetTextRect(tp)
        Dim icoRect As Rectangle = GetIconRect(tp)

        '取得當前需要用以描畫的 StatusAppearance
        If tp.Equals(AddNewTab) Then
            If tp.Equals(HoveringTab) Then
                tabSApr = iA.SetOfAddNewTabHover '1

                If btnRect.Equals(HoveringBTRect) Then
                    btnSApr = iA.SetOfNormalButtonHover '2
                Else
                    btnSApr = iA.SetOfNormalButton '3
                End If
            Else
                tabSApr = iA.SetOfAddNewTab '4
                btnSApr = iA.SetOfNormalButton
            End If

        ElseIf tp.Equals(SelectedTab) Then
            If tp.Equals(HoveringTab) Then
                tabSApr = iA.SetOfSelectedTabHover '5

                If btnRect.Equals(HoveringBTRect) Then
                    btnSApr = iA.SetOfSelectedButtonHover '6
                Else
                    btnSApr = iA.SetOfSelectedButton '7
                End If
            Else
                tabSApr = iA.SetOfSelectedTab '8
                btnSApr = iA.SetOfSelectedButton
            End If

        Else
            If tp.Equals(HoveringTab) Then
                tabSApr = iA.SetOfNormalTabHover '9

                If btnRect.Equals(HoveringBTRect) Then
                    btnSApr = iA.SetOfNormalButtonHover
                Else
                    btnSApr = iA.SetOfNormalButton
                End If
            Else
                tabSApr = iA.SetOfNormalTab '10
                btnSApr = iA.SetOfNormalButton
            End If
        End If

        If tp.Equals(AddNewTab) Then
            If Not btnRect.Equals(New Rectangle) And btnSApr.ShowBorder Then
                g.DrawRectangle(btnSApr.BorderPen, btnRect)
            End If
        Else
            '描畫邊框（如有）
            If tabSApr.ShowBorder Then
                g.DrawRectangle(tabSApr.BorderPen, tabRect)
            End If
        End If


    End Sub

    Private Sub DrawButton(g As Graphics, tp As TabPage)
        Dim BtnRect As Rectangle = GetButtonRect(tp)

        g.DrawRectangle(iA.SetOfNormalTab.BorderPen, BtnRect)
        g.FillRectangle(iA.SetOfNormalTab.BackBrush, BtnRect)

        If tp.Equals(AddNewTab) Then

        Else

        End If
    End Sub

#End Region 'PrivatePaint

#Region "PublicMethods"
    ''' <summary>
    ''' 自動設定 Tab 的寬度
    ''' </summary>
    Public Sub SetTabWidth()
        If Not iA.TabsAutoWidth Then Exit Sub

        If Me.TabCount > 0 Then
            Try
                Dim ItemWidth As Integer = Me.ItemSize.Width
                Dim ValidFullWidth As Integer = Me.ClientRectangle.Width - 20

                Dim ExpectedItemNumbers As Integer
                Select Case ValidFullWidth
                    Case Is < 400 : ExpectedItemNumbers = 3
                    Case 400 To 600 : ExpectedItemNumbers = 4
                    Case 600 To 800 : ExpectedItemNumbers = 5
                    Case 800 To 1000 : ExpectedItemNumbers = 6
                    Case 1000 To 1200 : ExpectedItemNumbers = 7
                    Case 1200 To 1800 : ExpectedItemNumbers = 8
                    Case Is > 1800 : ExpectedItemNumbers = 10
                End Select

                Dim SuitableWidth As Integer = CInt(ValidFullWidth / ExpectedItemNumbers)

                If ItemWidth * Me.TabCount <= ValidFullWidth And
                    SuitableWidth * Me.TabCount <= ValidFullWidth Then

                    ItemWidth = Math.Max(ItemWidth, SuitableWidth)

                ElseIf ItemWidth * Me.TabCount > ValidFullWidth And
                    SuitableWidth * Me.TabCount <= ValidFullWidth Then

                    ItemWidth = SuitableWidth

                ElseIf ItemWidth * Me.TabCount > ValidFullWidth And
                    SuitableWidth * Me.TabCount > ValidFullWidth Then

                    ItemWidth = Math.Max(CInt(ValidFullWidth / TabCount), 64) 'Tab's mini width set to 64
                End If

                Me.ItemSize = New Size(ItemWidth, 24)
            Catch ex As Exception
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="moveTo"></param>
    ''' <param name="tp"></param>
    Public Sub RemoveTab(moveTo As KzItemPosition, Optional tp As TabPage = Nothing)
        'With Me
        If tp Is Nothing Then ' Or tp.Equals(Me.SelectedTab) Then
            If TabCount > 1 Then
                Dim iOldSelected As Integer = SelectedIndex

                TabPages.Remove(SelectedTab)

                Select Case moveTo
                    Case KzItemPosition.None
                        SelectedIndex = -1
                    Case KzItemPosition.PreviousItem
                        If iOldSelected = 0 Then
                            SelectedIndex = 0
                        Else
                            SelectedIndex = iOldSelected - 1
                        End If
                    Case KzItemPosition.NextItem
                        If iOldSelected > TabPages.Count - 1 Then
                            SelectedIndex = TabPages.Count - 1
                        Else
                            SelectedIndex = iOldSelected
                        End If
                    Case KzItemPosition.LastItem
                        SelectedIndex = TabPages.Count - 1
                End Select
            ElseIf TabCount = 1 Then
                TabPages.Clear()
            End If
        Else
            If Not tp.Equals(SelectedTab) Then
                TabPages.Remove(tp)
            Else
                RemoveTab(moveTo)
            End If
        End If
        'End With
        SetTabWidth()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="addTo"></param>
    ''' <param name="tp"></param>
    ''' <param name="idx"></param>
    Public Sub AddTab(addTo As KzItemPosition, Optional tp As TabPage = Nothing, Optional idx As Integer = -1)
        'With Me
        Dim newTab As TabPage
        If tp Is Nothing Then
            newTab = New TabPage
        Else
            newTab = tp
        End If

        If newTab.Text Is Nothing Or newTab.Text = "" Then
            newTab.Text = NewTitlePrefix & Strings.Format(NewSerialNumber(), "00")
            newTab.ToolTipText = newTab.Text
        Else
            newTab.ToolTipText = newTab.Text
        End If

        If idx = -1 Then
            Dim toIndex As Integer
            If TabPages.Count > 0 Then
                Select Case addTo
                    Case KzItemPosition.FirstItem
                        toIndex = 0
                    Case KzItemPosition.PreviousItem, KzItemPosition.Current
                        toIndex = SelectedIndex
                    Case KzItemPosition.NextItem
                        If SelectedIndex = TabPages.Count - 1 Then
                            toIndex = -1
                        Else
                            toIndex = SelectedIndex + 1
                        End If
                    Case Else
                        toIndex = -1
                End Select
            Else
                toIndex = -1
            End If

            If toIndex = -1 Then
                TabPages.Add(newTab)
            Else
                TabPages.Insert(toIndex, newTab)
            End If

        Else
            Try
                TabPages.Insert(idx, newTab)
            Catch ex As Exception
                AddTab(addTo, tp)
            End Try

        End If

        If SelectAfterAdd Then
            SelectedTab = newTab
        End If
        'End With

        SetTabWidth()
    End Sub

#End Region 'PublicMethods
End Class


''' <summary>
''' 用於描述 TabControl 的描畫呈現
''' </summary>
Public Class KzTabsAppearance
    Public Sub New()

    End Sub

    Public Property TabPageStyle As KzTabPageStyle = KzTabPageStyle.None
    Public Property TabsAutoWidth As Boolean = False

    Public Property ShowIcon As Boolean = False
    Public Property SelectedTabCanClose As Boolean = False
    Public Property NormalTabCanClose As Boolean = False
    Public Property ShowRadius As Boolean = False
    Public Property RadiusSide As KzFlatCorners = KzFlatCorners.None

    Public Property ButtonMargin As Padding = New Padding(2)
    Public Property TextMargin As Padding = New Padding(1)
    Public Property NormalLine As Integer = 1
    Public Property BlodLine As Integer = 2
    Public Property Radius As Integer = 5

    Public Property SetOfNormalTab As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfNormalTabHover As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfSelectedTab As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfSelectedTabHover As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfNormalButton As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfNormalButtonHover As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfSelectedButton As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfSelectedButtonHover As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfAddNewTab As KzTabStatusAppearance = New KzTabStatusAppearance(Me)
    Public Property SetOfAddNewTabHover As KzTabStatusAppearance = New KzTabStatusAppearance(Me)

    Public Function GetCode(name As String, Optional tabWidth As Integer = 4) As String
        Dim sb As New StringBuilder
        Dim tab As String = Strings.StrDup(tabWidth, " ")

        sb.AppendLine("' " & name)
        sb.AppendLine("Dim " & name & " As New KzTabsAppearance")
        sb.AppendLine("With " & name)
        sb.AppendLine(tab & ".TabPageStyle = KzTabPageStyle." & TabPageStyle.ToString)
        sb.AppendLine(tab & ".TabsAutoWidth = " & TabsAutoWidth.ToString)
        sb.AppendLine(tab & ".ButtonMargin = New Padding(" & ButtonMargin.Left & ", " & ButtonMargin.Top & ", " & ButtonMargin.Right & ", " & ButtonMargin.Bottom & ")")
        sb.AppendLine(tab & ".TextMargin = New Padding(" & TextMargin.Left & ", " & TextMargin.Top & ", " & TextMargin.Right & ", " & TextMargin.Bottom & ")")
        sb.AppendLine(tab & ".ShowRadius = " & ShowRadius.ToString)
        sb.AppendLine(tab & ".RadiusSide = KzFlatCorners." & RadiusSide.ToString)
        sb.AppendLine(tab & ".ShowIcon = " & ShowIcon.ToString)
        sb.AppendLine(tab & ".SelectedTabCanClose = " & SelectedTabCanClose.ToString)
        sb.AppendLine(tab & ".NormalTabCanClose = " & NormalTabCanClose.ToString)
        sb.AppendLine(tab & ".NormalLine = " & NormalLine.ToString)
        sb.AppendLine(tab & ".BlodLine = " & BlodLine.ToString)
        sb.AppendLine(tab & ".Radius = " & Radius.ToString)

        sb.AppendLine(tab & ".SetOfNormalTab = " & name & "Tab")
        sb.AppendLine(tab & ".SetOfNormalTabHover = " & name & "TabHover")
        sb.AppendLine(tab & ".SetOfSelectedTab = " & name & "SelectedTab")
        sb.AppendLine(tab & ".SetOfSelectedTabHover = " & name & "SelectedTabHover")
        sb.AppendLine(tab & ".SetOfNormalButton = " & name & "Button")
        sb.AppendLine(tab & ".SetOfNormalButtonHover = " & name & "ButtonHover")
        sb.AppendLine(tab & ".SetOfSelectedButton = " & name & "SelectedButton")
        sb.AppendLine(tab & ".SetOfSelectedButtonHover = " & name & "SelectedButtonHover")
        sb.AppendLine(tab & ".SetOfAddNewTab = " & name & "AddNewTab")
        sb.AppendLine(tab & ".SetOfAddNewTabHover = " & name & "AddNewTabHover")
        sb.AppendLine("End With")
        Return sb.ToString
    End Function
End Class
''' <summary>
''' 依據狀態描述單個 Tab 的呈現 
''' </summary>
Public Class KzTabStatusAppearance
    Public Sub New(ParentAppearance As KzTabsAppearance)
        Parent = ParentAppearance
    End Sub

    Public Property Parent As KzTabsAppearance

    Public Property ShowBorder As Boolean = False
    Public Property BlodBorder As Boolean = False
    Public Property ShowShadow As Boolean = False
    Public Property ShadowSide As KzFlatSides = KzFlatSides.None
    Public Property ShadowColor As Color = SystemColors.ButtonShadow

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

    Public ReadOnly Property ForeBrush As SolidBrush
        Get
            Return New SolidBrush(ForeColor)
        End Get
    End Property

    Public ReadOnly Property ShadowBrush As SolidBrush
        Get
            Return New SolidBrush(ShadowColor)
        End Get
    End Property

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
        sb.AppendLine(tab & ".BorderColor = " & KzColorHelper.GetColorDescription(BorderColor))
        sb.AppendLine(tab & ".BackColor = " & KzColorHelper.GetColorDescription(BackColor))
        sb.AppendLine(tab & ".ForeColor = " & KzColorHelper.GetColorDescription(ForeColor))
        sb.AppendLine(tab & ".ShadowColor = " & KzColorHelper.GetColorDescription(ShadowColor))
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

Public Structure KzLook
    Public Shared ReadOnly Property TabsRoyalBlue As KzTabsAppearance
    '    Get
    '        ' NewLookTab
    '        Dim NewLookTab As New KzTabStatusAppearance
    '        With NewLookTab
    '            .ShowBorder = True
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = Color.Chocolate
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookTabHover
    '        Dim NewLookTabHover As New KzTabStatusAppearance
    '        With NewLookTabHover
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookSelectedTab
    '        Dim NewLookSelectedTab As New KzTabStatusAppearance
    '        With NewLookSelectedTab
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookSelectedTabHover
    '        Dim NewLookSelectedTabHover As New KzTabStatusAppearance
    '        With NewLookSelectedTabHover
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookButton
    '        Dim NewLookButton As New KzTabStatusAppearance
    '        With NewLookButton
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookButtonHover
    '        Dim NewLookButtonHover As New KzTabStatusAppearance
    '        With NewLookButtonHover
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookSelectedButton
    '        Dim NewLookSelectedButton As New KzTabStatusAppearance
    '        With NewLookSelectedButton
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookSelectedButtonHover
    '        Dim NewLookSelectedButtonHover As New KzTabStatusAppearance
    '        With NewLookSelectedButtonHover
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookAddTab
    '        Dim NewLookAddTab As New KzTabStatusAppearance
    '        With NewLookAddTab
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLookAddTabHover
    '        Dim NewLookAddTabHover As New KzTabStatusAppearance
    '        With NewLookAddTabHover
    '            .ShowBorder = False
    '            .BlodBorder = False
    '            .ShowShadow = False
    '            .ShadowSide = KzFlatSides.None
    '            .ShowRadius = False
    '            .RadiusSide = KzFlatCorners.None
    '            .BorderColor = SystemColors.ActiveBorder
    '            .BackColor = SystemColors.Control
    '            .ForeColor = SystemColors.ControlText
    '            .BlodFore = False
    '        End With

    '        ' NewLook
    '        Dim NewLook As New KzTabsAppearance
    '        With NewLook
    '            .TabPageStyle = KzTabPageStyle.None
    '            .ButtonMargin = New Padding(2, 2, 2, 2)
    '            .TextMargin = New Padding(1, 1, 1, 1)
    '            .ShowIcon = False
    '            '.ShowAddNewTab = False
    '            .SelectedTabCanClose = False
    '            .NormalTabCanClose = False
    '            .Tab = NewLookTab
    '            .TabHover = NewLookTabHover
    '            .SelectedTab = NewLookSelectedTab
    '            .SelectedTabHover = NewLookSelectedTabHover
    '            .Button = NewLookButton
    '            .ButtonHover = NewLookButtonHover
    '            .SelectedButton = NewLookSelectedButton
    '            .SelectedButtonHover = NewLookSelectedButtonHover
    '            .AddTab = NewLookAddTab
    '            .AddTabHover = NewLookAddTabHover
    '        End With

    '        Return NewLook
    '    End Get
    'End Property

    Public ReadOnly Property AllPresetedLooks As List(Of KzTabsAppearance)
        Get
            Dim list As New List(Of KzTabsAppearance)
            list.Add(TabsRoyalBlue)
            Return list
        End Get
    End Property
End Structure


