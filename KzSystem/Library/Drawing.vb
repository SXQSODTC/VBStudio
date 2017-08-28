Imports System.Drawing.Drawing2D

Public Class KzPathes
    'Public Shared Function Triangle(pt1 As Point, pt2 As Point, pt3 As Point) As GraphicsPath

    'End Function
End Class

Public Class KzLine
    Public Sub New()
        StartPoint = New Point(0, 0)
        EndPoint = New Point(0, 0)
        LineWidth = 1
        StartColor = Color.Black
        EndColor = Color.Black
        SingleColor = True
    End Sub

    Public Sub New(pt1 As Point, pt2 As Point, Optional Width As Integer = 0, Optional UseSingleColor As Boolean = True)
        StartPoint = pt1
        EndPoint = pt2
        LineWidth = Width
        StartColor = Color.Black
        SingleColor = UseSingleColor
        If UseSingleColor Then
            EndColor = Color.White
        Else
            EndColor = Color.Black
        End If
    End Sub

    Public Property StartPoint As Point
    Public Property EndPoint As Point
    Public Property LineWidth As Integer
    Public Property StartColor As Color
    Public Property EndColor As Color
    Public Property SingleColor As Boolean

    Public ReadOnly Property LineLength As Double
        Get
            Return Math.Sqrt((EndPoint.X - StartPoint.X) ^ 2 + (EndPoint.Y - StartPoint.Y) ^ 2)
        End Get
    End Property

    Public ReadOnly Property Brush As Brush
        Get
            If SingleColor Then
                Return New SolidBrush(StartColor)
            Else
                Return New LinearGradientBrush(StartPoint, EndPoint, StartColor, EndColor)
            End If
        End Get
    End Property

    Public ReadOnly Property IsEmpty As Boolean
        Get
            Return StartPoint = EndPoint
        End Get
    End Property

    Public ReadOnly Property Pen As Pen
        Get
            Return New Pen(Brush, LineWidth)
        End Get
    End Property

    Public Sub Draw(g As Graphics)
        g.DrawLine(Pen, StartPoint, EndPoint)
    End Sub
End Class