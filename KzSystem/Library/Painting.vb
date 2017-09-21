'Imports Microsoft.VisualBasic.PowerPacks

Public Class KzPainting

    Public Shared Sub SetHighQuality(g As Graphics)
        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality '合成图像的呈现质量
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic '插补模式
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias '平滑模式
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit '文本呈现的质量
    End Sub

    Public Shared Sub DrawBorder _
        (g As Graphics, rectangle As Rectangle, style As KzBorderStyle,
         Optional color As Color = Nothing, Optional width As Integer = 1,
         Optional sides As Border3DSide = Border3DSide.All)

        If color = Nothing Then
            color = SystemColors.ActiveBorder
        End If

        Select Case style
            Case KzBorderStyle.Dashed 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, rectangle, color, ButtonBorderStyle.Dashed)
            Case KzBorderStyle.Dotted 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, rectangle, color, ButtonBorderStyle.Dotted)
            Case KzBorderStyle.Inset 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, rectangle, color, ButtonBorderStyle.Inset)
            Case KzBorderStyle.Outset 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, rectangle, color, ButtonBorderStyle.Outset)
            Case KzBorderStyle.Solid 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, rectangle, color, ButtonBorderStyle.Solid)

            Case KzBorderStyle.Adjust 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.Adjust, sides)
            Case KzBorderStyle.Bump 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.Bump, sides)
            Case KzBorderStyle.Etched 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.Etched, sides)
            Case KzBorderStyle.Flat 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.Flat, sides)
            Case KzBorderStyle.Raised 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.Raised, sides)
            Case KzBorderStyle.RaisedInner 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.RaisedInner, sides)
            Case KzBorderStyle.RaisedOuter 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.RaisedOuter, sides)
            Case KzBorderStyle.Sunken 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.Sunken, sides)
            Case KzBorderStyle.SunkenInner 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.SunkenInner, sides)
            Case KzBorderStyle.SunkenOuter 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, rectangle, Border3DStyle.SunkenOuter, sides)
            Case Else

        End Select
    End Sub
End Class


Public Class KzAppearances
    Public Property Name As String = "NewApr"

    Public Property Normal As KzAppearance 'MouseLeave, from MouseUp
    Public Property Hover As KzAppearance 'MouseEnter, MouseMove, MouseHover, from MouseUp
    Public Property Press As KzAppearance 'MouseDown
    Public Property Check As KzAppearance 'Checked, Selected
End Class

Public Class KzAppearance
    Public Property Name As String = ""

    Public Property BorderRadius As Integer = 0
    Public Property BorderSize As Integer = 0
    Public Property BorderColor As Color = SystemColors.ActiveBorder
    Public Property LineSize As Integer = 1

    Public Property BackColor As Color = SystemColors.Control
    Public Property ForeColor As Color = SystemColors.ControlText

    Public Property ShadowWidth As Integer = 0
    Public Property ShadowDirection As KzFlatSides = KzFlatSides.RightBottom
    Public Property ShadowColor As Color = SystemColors.ButtonShadow

    Public Property FontStyle As FontStyle = SystemFonts.DefaultFont.Style
    Public Property FontSize As Single = SystemFonts.DefaultFont.Size

    Public ReadOnly Property BorderPen As Pen
        Get
            Return New Pen(BorderColor, BorderSize)
        End Get
    End Property

    Public ReadOnly Property BackBrush As Brush
        Get
            Return New SolidBrush(BackColor)
        End Get
    End Property

    Public ReadOnly Property ForePen As Pen
        Get
            Return New Pen(ForeColor, LineSize)
        End Get
    End Property

    Public ReadOnly Property ForeBrush As Brush
        Get
            Return New SolidBrush(ForeColor)
        End Get
    End Property

    Public ReadOnly Property ShadowBrush As Brush
        Get
            Return New SolidBrush(ShadowColor)
        End Get
    End Property

    Public Function Font(Optional ByVal theFont As Font = Nothing) As Font
        If theFont Is Nothing Then
            theFont = SystemFonts.DefaultFont
        End If

        If Not theFont.Size = Me.FontSize Or Not theFont.Style = Me.FontStyle Then
            Return New Font(theFont.FontFamily, Me.FontSize, Me.FontStyle)
        Else
            Return theFont
        End If
    End Function
End Class

Public Class KzLinePresentation
    Inherits Panel

    Private _Orient As Orientation = Orientation.Horizontal
    Private _SPad As Integer = 2
    Private _LWidth As Integer = 1
    Private _LColor As Color = Color.Black
    Private _Corner As Boolean = False
    Private _Rad As Integer = 5

    Public Sub New()

    End Sub

    Public Property Orientation As Orientation '
        Get
            Return _Orient
        End Get
        Set(value As Orientation)
            _Orient = value
            Invalidate()
        End Set
    End Property
    Public Property SidePadding As Integer '
        Get
            Return _SPad
        End Get
        Set(value As Integer)
            _SPad = value
            Invalidate()
        End Set
    End Property
    Public Property LineWidth As Integer '
        Get
            Return _LWidth
        End Get
        Set(value As Integer)
            _LWidth = value
            Invalidate()
        End Set
    End Property
    Public Property LineColor As Color
        Get
            Return _LColor
        End Get
        Set(value As Color)
            _LColor = value
            Invalidate()
        End Set
    End Property

    Public Property ShowCorner As Boolean
        Get
            Return _Corner
        End Get
        Set(value As Boolean)
            _Corner = value
            Invalidate()
        End Set
    End Property

    Public Property Radius As Integer
        Get
            Return _Rad
        End Get
        Set(value As Integer)
            _Rad = value
            If _Corner Then
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(_LColor, _LWidth)

        KzPainting.SetHighQuality(g)

        If _Corner Then
            Dim TopPad As Integer = 2
            Dim EndOf1stLine As Point = New Point(CInt(2 / 3 * Width - _Rad), TopPad)
            Dim StartOf2ndLine As Point = New Point(CInt(2 / 3 * Width), TopPad + _Rad)
            Dim RoundRect As Rectangle

            g.DrawLine(pen, New Point(_SPad, TopPad), EndOf1stLine)
            g.DrawLine(pen, StartOf2ndLine, New Point(StartOf2ndLine.X, Height - TopPad))

            RoundRect = New Rectangle(
                x:=EndOf1stLine.X - _Rad, y:=TopPad,
                width:=_Rad * 2, height:=_Rad * 2)

            g.DrawArc(pen, RoundRect, 270.0F, 90.0F)
        Else
            Select Case _Orient
                Case Orientation.Horizontal
                    g.DrawLine(pen, New Point(_SPad, Height / 2), New Point(Width - 2 * _SPad, Height / 2))
                Case Orientation.Vertical
                    g.DrawLine(pen, New Point(Width / 2, _SPad), New Point(Width / 2, Height - 2 * _SPad))
            End Select
        End If
    End Sub

End Class






