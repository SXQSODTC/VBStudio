
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
    Public Property ShadowDirection As KzSidePosition = KzSidePosition.RightBottom
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