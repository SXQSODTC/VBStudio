'Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Text
'Imports System.IO
'Imports System.Net

Public Class KzTabControl
    Inherits TabControl

    Private iA As KzTabsAppearance = New KzTabsAppearance
    Private iNew As Boolean = False
    Private iBtnPad As Integer = 2
    Private iSF As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center,
            .Trimming = StringTrimming.EllipsisCharacter,
            .HotkeyPrefix = HotkeyPrefix.Hide,
            .FormatFlags = StringFormatFlags.NoWrap}

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

        SetTabWidth()
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
    Public Property NewTabType As KzTabControlNewTabType = KzTabControlNewTabType.DefaultTab
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

            Invalidate()
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
            If Me.NewTitlePrefix Is Nothing Then
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

        For Each tp As TabPage In TabPages
            DrawTab(g, tp)
        Next

        If Not iA.TabPageStyle = KzTabPageStyle.None Then
            Dim FramePen As Pen
            Dim ULinePen As Pen

            If iA.SetOfSelectedTab.ShowBorder Then
                FramePen = New Pen(iA.SetOfSelectedTab.BorderColor, iA.BoldLine)
                ULinePen = New Pen(iA.SetOfSelectedTab.BackColor, iA.BoldLine)
            Else
                FramePen = New Pen(iA.SetOfSelectedTab.BackColor, iA.BoldLine)
                ULinePen = Nothing
            End If

            Select Case iA.TabPageStyle
                Case KzTabPageStyle.OpenSideLine, KzTabPageStyle.SideLine
                    e.Graphics.DrawLine(FramePen,
                                   DisplayRectangle.X - 1, DisplayRectangle.Y - 2,
                                   DisplayRectangle.Right + 1, DisplayRectangle.Y - 2)
                Case KzTabPageStyle.OpenPageFrame, KzTabPageStyle.PageFrame
                    Dim PageRect As Rectangle =
                    New Rectangle(DisplayRectangle.X - 2, DisplayRectangle.Y - 2,
                                  DisplayRectangle.Width + 2 * 2, DisplayRectangle.Height + 2 * 2)

                    e.Graphics.DrawRectangle(FramePen, PageRect)
            End Select

            If SelectedTab IsNot Nothing And iA.SetOfSelectedTab.ShowBorder And
                (iA.TabPageStyle = KzTabPageStyle.OpenSideLine Or
                iA.TabPageStyle = KzTabPageStyle.OpenPageFrame) Then

                Dim OpRect As Rectangle = GetTabRect(TabPages.IndexOf(SelectedTab))

                g.DrawLine(ULinePen,
                           New Point(OpRect.Left + 1, DisplayRectangle.Y - 2),
                           New Point(OpRect.Right - 1, DisplayRectangle.Y - 2))
            End If
        End If
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
        MyBase.OnSelectedIndexChanged(e)

        Invalidate()
    End Sub

    Public Property SignLabel As ToolStripLabel

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
            If SignLabel IsNot Nothing Then
                Dim ht As String = If(HoveringTab Is Nothing, "#", TabPages.IndexOf(HoveringTab))
                Dim hr As String = If(HoveringBTRect.Equals(New Rectangle), "#", "R")
                SignLabel.Text = "HTab: " & ht & " , HRect: " & hr & " , STab: " & TabPages.IndexOf(SelectedTab)
            End If
        Catch ex As Exception

        End Try

        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)

        HoveringTab = Nothing
        HoveringBTRect = New Rectangle

        Try
            If SignLabel IsNot Nothing Then
                Dim ht As String = If(HoveringTab Is Nothing, "#", TabPages.IndexOf(HoveringTab))
                Dim hr As String = If(HoveringBTRect.Equals(New Rectangle), "#", "R")
                SignLabel.Text = "HTab: " & ht & " , HRect: " & hr & " , STab: " & TabPages.IndexOf(SelectedTab)
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

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)

        If e.Button = MouseButtons.Left Then
            Dim tp As TabPage = GetTabAtPoint(e.Location)
            Dim btn As Rectangle = New Rectangle

            If tp IsNot Nothing Then
                btn = GetButtonRect(tp)

                If Not btn.IsEmpty Then

                    If btn.Contains(e.Location) Then
                        Dim ute As New KzTabControlUpdateTabsEventArgs With {
                            .TabPage = tp,
                            .ButtonRect = btn}

                        If tp.Equals(AddNewTab) Then
                            Dim newTab As TabPage

                            Select Case NewTabType
                                Case KzTabControlNewTabType.DefaultTab : newTab = New TabPage
                                Case KzTabControlNewTabType.RichTextTab : newTab = New KzTextTab
                                Case KzTabControlNewTabType.WebTab : newTab = New KzWebTap
                                Case Else : newTab = Nothing
                            End Select

                            If newTab IsNot Nothing Then
                                AddTab(KzItemPosition.LastItem, newTab)
                            End If

                            ute.Action = KzTabControlUpdateAction.Add
                        Else
                            If Not NewTabType = KzTabControlNewTabType.OwnerHandle Then
                                RemoveTab(KzItemPosition.PreviousItem, tp)
                            End If

                            ute.Action = KzTabControlUpdateAction.Remove
                        End If

                        RaiseEvent UpdatingTabs(Me, ute)
                    End If
                End If
            End If
        End If
    End Sub

    Public Event UpdatingTabs As EventHandler(Of KzTabControlUpdateTabsEventArgs)

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

    Private Overloads Function GetTabRect(tp As TabPage)
        Dim TabRect As New Rectangle
        Return TabRect
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
        Dim r As Rectangle

        Select Case Alignment
            Case TabAlignment.Top, TabAlignment.Bottom
                ImgSideLength = TabRect.Height - iA.TextMargin.Vertical
            Case TabAlignment.Left, TabAlignment.Right
                ImgSideLength = TabRect.Width - iA.TextMargin.Horizontal
        End Select

        r = New Rectangle(
                    x:=TabRect.X + iA.TextMargin.Left,
                    y:=TabRect.Y + iA.TextMargin.Top,
                    width:=ImgSideLength,
                    height:=ImgSideLength)
        r.Inflate(-2, -2)
        Return r
    End Function

    Private Function GetSideLine() As KzLine
        Dim l As New KzLine
        Dim w As Integer = 2

        l.LineWidth = w
        l.SingleColor = True
        With DisplayRectangle
            Select Case Alignment
                Case TabAlignment.Top
                    l.StartPoint = New Point(.Left - w, .Top - w)
                    l.EndPoint = New Point(.Right + w, .Top + w)
                Case TabAlignment.Bottom
                    l.StartPoint = New Point(.Left - w, .Bottom + w)
                    l.EndPoint = New Point(.Right + w, .Bottom + w)
                Case TabAlignment.Left
                    l.StartPoint = New Point(.Left - w, .Top - w)
                    l.EndPoint = New Point(.Left - w, .Bottom + w)
                Case TabAlignment.Right
                    l.StartPoint = New Point(.Right + w, .Top - w)
                    l.EndPoint = New Point(.Right + w, .Bottom + w)
            End Select
        End With

        If HoveringTab IsNot Nothing AndAlso HoveringTab.Equals(SelectedTab) Then
            If iA.SetOfSelectedTabHover.ShowBorder Then
                l.StartColor = iA.SetOfSelectedTabHover.BorderColor
            Else
                l.StartColor = iA.SetOfSelectedTabHover.BackColor
            End If
        Else
            If iA.SetOfSelectedTab.ShowBorder Then
                l.StartColor = iA.SetOfSelectedTab.BorderColor
            Else
                l.StartColor = iA.SetOfSelectedTab.BackColor
            End If
        End If

        Return l
    End Function

    Private Function GetFrameRect() As Rectangle
        Dim r As Rectangle = DisplayRectangle
        r.Inflate(2, 2)
        Return r
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
            '如果是新建Tab，則將Tab背景縮小
            tabRect = New Rectangle(tabRect.Location,
                                    New Size(tabRect.Height, tabRect.Height))

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

        '開始描畫
        '填充 Tab 背景色
        g.FillRectangle(tabSApr.BackBrush, tabRect)

        '描畫 Tab 邊框（如有）
        If tabSApr.ShowBorder Then
            If tabSApr.BoldBorder Then
                g.DrawRectangle(tabSApr.BorderPen(iA.BoldLine), tabRect)
            Else
                g.DrawRectangle(tabSApr.BorderPen(iA.NormalLine), tabRect)
            End If
        End If

        '描畫 Tab 上的按鈕（如有）
        If Not btnRect.IsEmpty Then
            '填充按鈕背景
            Dim BBrush As SolidBrush
            If (Not tp.Equals(SelectedTab)) And tp.Equals(HoveringTab) And (Not btnRect.Equals(HoveringBTRect)) Then
                BBrush = tabSApr.BackBrush
            Else
                BBrush = btnSApr.BackBrush
            End If
            g.FillRectangle(BBrush, btnRect)
            '描畫按鈕邊框（如有）
            Dim FPen As Pen
            If btnSApr.ShowBorder Then
                If btnSApr.BoldBorder Then
                    g.DrawRectangle(btnSApr.BorderPen(iA.BoldLine), btnRect)
                Else
                    g.DrawRectangle(btnSApr.BorderPen(iA.NormalLine), btnRect)
                End If
            End If
            '描畫按鈕表面（+ 或 -）
            If btnSApr.BoldFore Then
                FPen = btnSApr.ForePen(iA.BoldLine)
            Else
                FPen = btnSApr.ForePen(iA.NormalLine)
            End If

            If tp.Equals(AddNewTab) Then
                g.DrawLine(FPen,
                           New Point(btnRect.Left + iBtnPad, btnRect.Top + btnRect.Height / 2),
                           New Point(btnRect.Right - iBtnPad, btnRect.Top + btnRect.Height / 2))
                g.DrawLine(FPen,
                           New Point(btnRect.Left + btnRect.Width / 2, btnRect.Top + iBtnPad),
                           New Point(btnRect.Left + btnRect.Width / 2, btnRect.Bottom - iBtnPad))
            Else
                g.DrawLine(FPen,
                           New Point(btnRect.Left + iBtnPad, btnRect.Top + iBtnPad),
                           New Point(btnRect.Right - iBtnPad, btnRect.Bottom - iBtnPad))
                g.DrawLine(FPen,
                           New Point(btnRect.Right - iBtnPad, btnRect.Top + iBtnPad),
                           New Point(btnRect.Left + iBtnPad, btnRect.Bottom - iBtnPad))
            End If
        End If

        '描畫 Tab 上的文字（AddNewTab 除外）
        If Not txtRect.IsEmpty Then
            Dim font As Font
            If tabSApr.BoldFore Then
                font = New Font(tp.Font.FontFamily, tp.Font.Size, FontStyle.Bold)
            Else
                font = tp.Font
            End If
            g.DrawString(tp.Text, font, tabSApr.ForeBrush, txtRect, iSF)
        End If

        '描畫 Tab 上的 Icon（如有）
        If Not icoRect.IsEmpty Then
            Dim ic As Image
            If tp.ImageIndex = -1 Then
                ic = My.Resources.ODTCLogo
            Else
                ic = ImageList.Images(tp.ImageIndex)
            End If

            g.DrawImage(ic, icoRect)
        End If

    End Sub

#End Region 'PrivatePaint

#Region "PublicMethods"
    ''' <summary>
    ''' 自動設定 Tab 的寬度
    ''' </summary>
    Public Sub SetTabWidth()
        If Not iA.TabsAutoWidth Then Exit Sub

        If TabCount > 0 Then
            Try
                Dim ItemWidth As Integer = ItemSize.Width
                Dim ValidFullWidth As Integer = ClientRectangle.Width - 20

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

                If ItemWidth * TabCount <= ValidFullWidth And
                    SuitableWidth * TabCount <= ValidFullWidth Then

                    ItemWidth = Math.Max(ItemWidth, SuitableWidth)

                ElseIf ItemWidth * TabCount > ValidFullWidth And
                    SuitableWidth * TabCount <= ValidFullWidth Then

                    ItemWidth = SuitableWidth

                ElseIf ItemWidth * TabCount > ValidFullWidth And
                    SuitableWidth * TabCount > ValidFullWidth Then

                    ItemWidth = Math.Max(CInt(ValidFullWidth / TabCount), 64) 'Tab's mini width set to 64
                End If

                Me.ItemSize = New Size(ItemWidth, 24)
            Catch ex As Exception
            End Try
        End If
    End Sub
    ''' <summary>
    ''' 移除 Tab
    ''' </summary>
    ''' <param name="SelectionAfterRemove">移除指定 Tab 之後的選定位置</param>
    ''' <param name="TheTabPage">指定需要移除的 TabPage，如為 Nothing 則默認為 SelectedTab</param>
    Public Sub RemoveTab(SelectionAfterRemove As KzItemPosition,
                         Optional TheTabPage As TabPage = Nothing)

        If SelectedIndex = -1 And TheTabPage Is Nothing Then
            Exit Sub
        End If

        If TheTabPage Is Nothing Then
            If TabCount > 1 Then
                Dim iOldSelected As Integer = SelectedIndex

                TabPages.Remove(SelectedTab)

                Select Case SelectionAfterRemove
                    Case KzItemPosition.None
                        SelectedIndex = -1
                    Case KzItemPosition.PreviousItem
                        If iOldSelected = 0 Then
                            SelectedIndex = 0
                            'If ShowAddNewTab Then
                            '    If TabPages.IndexOf(AddNewTab) = 0 Then
                            '        SelectedIndex = -1
                            '    Else
                            '        SelectedIndex = 0
                            '    End If
                            'Else
                            '    SelectedIndex = 0
                            'End If
                        Else
                            SelectedIndex = iOldSelected - 1
                        End If
                    Case KzItemPosition.NextItem
                        If ShowAddNewTab Then
                            If TabPages.IndexOf(AddNewTab) = iOldSelected Then
                                SelectedIndex = iOldSelected - 1
                            Else
                                SelectedIndex = iOldSelected
                            End If
                        Else
                            If iOldSelected > TabPages.Count - 1 Then
                                SelectedIndex = TabPages.Count - 1
                            Else
                                SelectedIndex = iOldSelected
                            End If
                        End If
                    Case KzItemPosition.LastItem
                        If ShowAddNewTab Then
                            SelectedIndex = TabPages.Count - 2
                        Else
                            SelectedIndex = TabPages.Count - 1
                        End If
                    Case KzItemPosition.FirstItem
                        SelectedIndex = 0
                        'If ShowAddNewTab Then
                        '    If TabPages.IndexOf(AddNewTab) = 0 Then
                        '        SelectedIndex = -1
                        '    Else
                        '        SelectedIndex = 0
                        '    End If
                        'End If
                End Select
            ElseIf TabCount = 1 Then
                If ShowAddNewTab Then
                    If TabPages.IndexOf(AddNewTab) = 0 Then
                        SelectedIndex = -1
                    Else
                        SelectedIndex = 0
                    End If
                Else
                    SelectedIndex = 0
                End If
            End If
        Else
            If Not TheTabPage.Equals(SelectedTab) Then
                If Not TheTabPage.Equals(AddNewTab) Then
                    TabPages.Remove(TheTabPage)
                End If
            Else
                RemoveTab(SelectionAfterRemove)
            End If
        End If

        SetTabWidth()
    End Sub
    ''' <summary>
    ''' 添加 Tab，含插入功能
    ''' </summary>
    ''' <param name="AddToPosition">添加指定 TabPage 的位置（根據現有 Tabs 的位置）</param>
    ''' <param name="TheTabPage">指定需要添加的 TabPage，如為 Nothing 則默認為 NewTab</param>
    ''' <param name="InsertToIndex">指定位置添加，如其值大於 -1，則 AddToPosition 將失效</param>
    Public Sub AddTab(AddToPosition As KzItemPosition,
                      Optional TheTabPage As TabPage = Nothing,
                      Optional InsertToIndex As Integer = -1)

        Dim newTab As TabPage
        If TheTabPage Is Nothing Then
            newTab = New TabPage
        Else
            newTab = TheTabPage
        End If

        If newTab.Text Is Nothing Or newTab.Text = "" Then
            newTab.Text = NewTitlePrefix & Strings.Format(NewSerialNumber(), "00")
            newTab.ToolTipText = newTab.Text
        Else
            newTab.ToolTipText = newTab.Text
        End If

        If SelectedIndex = -1 Then
            If ShowAddNewTab Then
                TabPages.Insert(TabPages.IndexOf(AddNewTab), newTab)
            Else
                TabPages.Add(newTab)
            End If

        Else

            If InsertToIndex = -1 Then
                Dim toIndex As Integer
                If TabPages.Count > 0 Then
                    Select Case AddToPosition
                        Case KzItemPosition.FirstItem
                            toIndex = 0

                        Case KzItemPosition.PreviousItem, KzItemPosition.Current
                            toIndex = SelectedIndex

                        Case KzItemPosition.NextItem
                            If ShowAddNewTab Then
                                If SelectedIndex = TabPages.Count - 2 Then
                                    toIndex = TabPages.Count - 1
                                Else
                                    toIndex = SelectedIndex + 1
                                End If
                            Else
                                If SelectedIndex = TabPages.Count - 1 Then
                                    toIndex = -1
                                Else
                                    toIndex = SelectedIndex + 1
                                End If
                            End If

                        Case Else
                            toIndex = -1
                    End Select
                Else
                    toIndex = -1
                End If

                If toIndex = -1 Then
                    If ShowAddNewTab Then
                        TabPages.Insert(TabPages.IndexOf(AddNewTab), newTab)
                    Else
                        TabPages.Add(newTab)
                    End If
                Else
                    TabPages.Insert(toIndex, newTab)
                End If

            Else

                Try
                    TabPages.Insert(InsertToIndex, newTab)
                Catch ex As Exception
                    AddTab(AddToPosition, TheTabPage)
                End Try

            End If
        End If

        If SelectAfterAdd Then
            SelectedTab = newTab
        End If

        SetTabWidth()
    End Sub
    ''' <summary>
    ''' 清除所有 Tab
    ''' </summary>
    Public Overloads Sub RemoveAll()
        If ShowAddNewTab Then
            For Each tp As TabPage In TabPages
                If Not tp.Equals(AddNewTab) Then
                    TabPages.Remove(tp)
                End If
            Next
        Else
            TabPages.Clear()
        End If
    End Sub
    ''' <summary>
    ''' 移動 Tab
    ''' </summary>
    ''' <param name="MoveToPosition"></param>
    ''' <param name="TheTabPage"></param>
    ''' <param name="MoveToIndex"></param>
    Public Sub MoveTab(MoveToPosition As KzItemPosition,
                       Optional TheTabPage As TabPage = Nothing,
                       Optional MoveToIndex As Integer = -1)

        If TheTabPage Is Nothing And SelectedIndex = -1 Then
            Exit Sub
        ElseIf TheTabPage Is Nothing Then
            TheTabPage = SelectedTab
        End If

        Dim i As Integer = TabPages.IndexOf(TheTabPage)
    End Sub
#End Region 'PublicMethods
End Class

Public Enum KzTabControlUpdateAction
    None
    Add
    Remove
    Cancel
End Enum

Public Class KzTabControlUpdateTabsEventArgs
    Inherits EventArgs

    Public Property TabPage As TabPage
    Public Property ButtonRect As Rectangle
    Public Property Action As KzTabControlUpdateAction
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
    Public Property BoldLine As Integer = 2
    Public Property Radius As Integer = 5

    Public Property SetOfNormalTab As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfNormalTabHover As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfSelectedTab As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfSelectedTabHover As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfNormalButton As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfNormalButtonHover As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfSelectedButton As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfSelectedButtonHover As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfAddNewTab As KzTabStatusAppearance = New KzTabStatusAppearance()
    Public Property SetOfAddNewTabHover As KzTabStatusAppearance = New KzTabStatusAppearance()

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
        sb.AppendLine(tab & ".BoldLine = " & BoldLine.ToString)
        sb.AppendLine(tab & ".Radius = " & Radius.ToString)

        sb.AppendLine(tab & ".SetOfNormalTab = " & name & "NormalTab")
        sb.AppendLine(tab & ".SetOfNormalTabHover = " & name & "NormalTabHover")
        sb.AppendLine(tab & ".SetOfSelectedTab = " & name & "SelectedTab")
        sb.AppendLine(tab & ".SetOfSelectedTabHover = " & name & "SelectedTabHover")
        sb.AppendLine(tab & ".SetOfNormalButton = " & name & "NormalButton")
        sb.AppendLine(tab & ".SetOfNormalButtonHover = " & name & "NormalButtonHover")
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

    Public Sub New()

    End Sub

    Public Property ShowBorder As Boolean = False
    Public Property BoldBorder As Boolean = False
    Public Property ShowShadow As Boolean = False
    Public Property ShadowSide As KzFlatSides = KzFlatSides.None
    Public Property ShadowColor As Color = SystemColors.ButtonShadow

    Public Property BorderColor As Color = SystemColors.ActiveBorder
    Public Property BackColor As Color = SystemColors.Control
    Public Property ForeColor As Color = SystemColors.ControlText
    Public Property BoldFore As Boolean = False

    Public ReadOnly Property BackBrush As Brush
        Get
            Return New SolidBrush(BackColor)
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

    Public Function BorderPen(Optional LineWidth As Integer = 1) As Pen
        Return New Pen(BorderColor, LineWidth)
    End Function

    Public Function ForePen(Optional LineWidth As Integer = 1) As Pen
        Return New Pen(ForeColor, LineWidth)
    End Function

    Public Function GetCode(name As String,
                            Optional tabWidth As Integer = 4) As String

        Dim sb As New StringBuilder
        Dim tab As String = Strings.StrDup(tabWidth, " ")

        sb.AppendLine("' " & name)
        sb.AppendLine("Dim " & name & " As New KzTabStatusAppearance()")
        sb.AppendLine("With " & name)
        sb.AppendLine(tab & ".ShowBorder = " & ShowBorder.ToString)
        sb.AppendLine(tab & ".BoldBorder = " & BoldBorder.ToString)
        sb.AppendLine(tab & ".ShowShadow = " & ShowShadow.ToString)
        sb.AppendLine(tab & ".ShadowSide = KzFlatSides." & ShadowSide.ToString)
        sb.AppendLine(tab & ".BorderColor = " & KzColorHelper.GetColorDescription(BorderColor))
        sb.AppendLine(tab & ".BackColor = " & KzColorHelper.GetColorDescription(BackColor))
        sb.AppendLine(tab & ".ForeColor = " & KzColorHelper.GetColorDescription(ForeColor))
        sb.AppendLine(tab & ".ShadowColor = " & KzColorHelper.GetColorDescription(ShadowColor))
        sb.AppendLine(tab & ".BoldFore = " & BoldFore.ToString)
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

Public Enum KzTabControlNewTabType
    DefaultTab
    TextTab
    RichTextTab
    WebTab
    OwnerHandle
End Enum

Public Class KzTextTab
    Inherits TabPage

    Private _TBox As TextBox

    Public ReadOnly Type As KzTabControlNewTabType = KzTabControlNewTabType.TextTab

    Public Sub New()

        _TBox = New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Both,
            .HideSelection = False,
            .Dock = DockStyle.Fill}

        Controls.Add(_TBox)
    End Sub

    Public ReadOnly Property TextBox As TextBox

    Public Property FilePath As String = Nothing
End Class

Public Class KzRichTab
    Inherits TabPage

    Private _RTBox As RichTextBox

    Public ReadOnly Type As KzTabControlNewTabType = KzTabControlNewTabType.TextTab

    Public Sub New()

        _RTBox = New RichTextBox With {
            .Multiline = True,
            .ScrollBars = RichTextBoxScrollBars.Both,
            .HideSelection = False,
            .Dock = DockStyle.Fill}

        Controls.Add(_RTBox)
    End Sub

    Public ReadOnly Property TextBox As TextBox

    Public Property FilePath As String = Nothing
End Class

Public Class KzWebTap
    Inherits TabPage

    Private _Browser As WebBrowser

    Public ReadOnly Type As KzTabControlNewTabType = KzTabControlNewTabType.WebTab

    Public Sub New()

        _Browser = New WebBrowser() With {
            .Dock = DockStyle.Fill,
            .ScriptErrorsSuppressed = True}

        Controls.Add(_Browser)

    End Sub

    Public ReadOnly Property Browser As WebBrowser
        Get
            Return _Browser
        End Get
    End Property

    'Private Sub _Browser_DocumentCompleted _
    '    (sender As Object, e As WebBrowserDocumentCompletedEventArgs) _
    '    Handles _Browser.DocumentCompleted

    '    Text = _Browser.Document.Title

    '    Try
    '        Dim wc As New WebClient
    '        Dim mStream As New MemoryStream _
    '            (wc.DownloadData("http://" & New Uri(_Browser.Url.ToString).Host & "/favicon.ico"))
    '        IconImage = New Icon(mStream).ToBitmap
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub _Browser_DocumentTitleChanged _
    '    (sender As Object, e As EventArgs) Handles _Browser.DocumentTitleChanged

    '    Try
    '        Text = _Browser.Document.Title
    '        ToolTipText = Text
    '    Catch ex As Exception
    '        Text = "未知..."
    '        ToolTipText = Nothing
    '    End Try
    'End Sub

    'Private Sub _browser_Navigating _
    '    (ByVal sender As Object, ByVal e As WebBrowserNavigatingEventArgs) _
    '    Handles _Browser.Navigating


    'End Sub
End Class

Public Structure KzLook
    Public Shared ReadOnly Property TabsRoyalBlue As KzTabsAppearance
        Get
            ' NewLookNormalTab
            Dim NewLookNormalTab As New KzTabStatusAppearance()
            With NewLookNormalTab
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = SystemColors.Control
                .ForeColor = Color.DarkCyan
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = False
            End With

            ' NewLookNormalTabHover
            Dim NewLookNormalTabHover As New KzTabStatusAppearance()
            With NewLookNormalTabHover
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.SkyBlue
                .ForeColor = Color.DarkCyan
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = True
            End With

            ' NewLookSelectedTab
            Dim NewLookSelectedTab As New KzTabStatusAppearance()
            With NewLookSelectedTab
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.RoyalBlue
                .ForeColor = Color.WhiteSmoke
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = False
            End With

            ' NewLookSelectedTabHover
            Dim NewLookSelectedTabHover As New KzTabStatusAppearance()
            With NewLookSelectedTabHover
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.RoyalBlue
                .ForeColor = Color.WhiteSmoke
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = True
            End With

            ' NewLookNormalButton
            Dim NewLookNormalButton As New KzTabStatusAppearance()
            With NewLookNormalButton
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = SystemColors.Control
                .ForeColor = Color.DarkCyan
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = False
            End With

            ' NewLookNormalButtonHover
            Dim NewLookNormalButtonHover As New KzTabStatusAppearance()
            With NewLookNormalButtonHover
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.SkyBlue
                .ForeColor = Color.DarkCyan
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = True
            End With

            ' NewLookSelectedButton
            Dim NewLookSelectedButton As New KzTabStatusAppearance()
            With NewLookSelectedButton
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.RoyalBlue
                .ForeColor = Color.WhiteSmoke
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = False
            End With

            ' NewLookSelectedButtonHover
            Dim NewLookSelectedButtonHover As New KzTabStatusAppearance()
            With NewLookSelectedButtonHover
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.RoyalBlue
                .ForeColor = Color.WhiteSmoke
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = True
            End With

            ' NewLookAddNewTab
            Dim NewLookAddNewTab As New KzTabStatusAppearance()
            With NewLookAddNewTab
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = SystemColors.Control
                .ForeColor = Color.DarkCyan
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = False
            End With

            ' NewLookAddNewTabHover
            Dim NewLookAddNewTabHover As New KzTabStatusAppearance()
            With NewLookAddNewTabHover
                .ShowBorder = False
                .BoldBorder = False
                .ShowShadow = False
                .ShadowSide = KzFlatSides.None
                .BorderColor = SystemColors.ActiveBorder
                .BackColor = Color.SkyBlue
                .ForeColor = Color.DarkGray
                .ShadowColor = SystemColors.ButtonShadow
                .BoldFore = False
            End With

            ' NewLook
            Dim NewLook As New KzTabsAppearance
            With NewLook
                .TabPageStyle = KzTabPageStyle.SideLine
                .TabsAutoWidth = True
                .ButtonMargin = New Padding(4)
                .TextMargin = New Padding(1)
                .ShowRadius = False
                .RadiusSide = KzFlatCorners.None
                .ShowIcon = True
                .SelectedTabCanClose = True
                .NormalTabCanClose = True
                .NormalLine = 1
                .BoldLine = 2
                .Radius = 5
                .SetOfNormalTab = NewLookNormalTab
                .SetOfNormalTabHover = NewLookNormalTabHover
                .SetOfSelectedTab = NewLookSelectedTab
                .SetOfSelectedTabHover = NewLookSelectedTabHover
                .SetOfNormalButton = NewLookNormalButton
                .SetOfNormalButtonHover = NewLookNormalButtonHover
                .SetOfSelectedButton = NewLookSelectedButton
                .SetOfSelectedButtonHover = NewLookSelectedButtonHover
                .SetOfAddNewTab = NewLookAddNewTab
                .SetOfAddNewTabHover = NewLookAddNewTabHover
            End With

            Return NewLook
        End Get
    End Property

    Public ReadOnly Property AllPresetedLooks As List(Of KzTabsAppearance)
        Get
            Dim list As New List(Of KzTabsAppearance)
            list.Add(TabsRoyalBlue)
            Return list
        End Get
    End Property
End Structure


