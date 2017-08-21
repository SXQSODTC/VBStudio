Imports System.ComponentModel
Imports System.Windows.Forms.Design

<Description("Represents a setting bar for Padding."),
    ToolboxBitmap(GetType(KzPadingSetter), "KzPadingSetter.bmp"),
    Designer(GetType(KzTrackBarDesigner)),
    DefaultProperty("Maximum"),
    DefaultEvent("ValueChanged")>
Public Class KzPadingSetter

    Private _Pad As Padding = New Padding
    Private _Auto As Boolean = True
    Private _Header As Boolean = True

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Property Value As Padding
        Get
            Return _Pad
        End Get
        Set(value As Padding)
            _Pad = value
            _Auto = False
            Try
                AllUD.Value = _Pad.All
                LeftUD.Value = _Pad.Left
                TopUD.Value = _Pad.Top
                RightUD.Value = _Pad.Right
                BottomUD.Value = _Pad.Bottom
            Catch ex As Exception

            End Try
            _Auto = True
        End Set
    End Property

    Public Property ShowHeader As Boolean
        Get
            Return _Header
        End Get
        Set(value As Boolean)
            _Header = value
            If _Header Then
                RootPanel.RowStyles(0).Height = 14
                RootPanel.Height = 36
            Else
                RootPanel.RowStyles(0).Height = 0
                RootPanel.Height = 23
            End If
        End Set
    End Property

    Public ReadOnly Property Description As String
        Get
            With _Pad
                Return "Padding(" & .Left & ", " & .Top & ", " & .Right & ", " & .Bottom & ")"
            End With
        End Get
    End Property

    Public Event ValueChanged(sender As Object, e As EventArgs)

    Private Sub AllUD_ValueChanged(sender As Object, e As EventArgs) Handles _
        AllUD.ValueChanged, LeftUD.ValueChanged, TopUD.ValueChanged,
        RightUD.ValueChanged, BottomUD.ValueChanged

        Try
            If _Auto Then
                Dim ud As NumericUpDown = CType(sender, NumericUpDown)

                If ud.Equals(AllUD) Then
                    LeftUD.Value = ud.Value
                    TopUD.Value = ud.Value
                    RightUD.Value = ud.Value
                    BottomUD.Value = ud.Value
                Else
                    If ud.Value <> AllUD.Value Then
                        AllUD.Value = -1
                    End If
                End If

                _Pad = New Padding(LeftUD.Value, TopUD.Value, RightUD.Value, BottomUD.Value)
                RaiseEvent ValueChanged(Me, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RootPanel_SizeChanged(sender As Object, e As EventArgs) Handles RootPanel.SizeChanged
        With RootPanel
            If .Width < 200 Then
                Label1.Text = "A"
                Label2.Text = "L"
                Label3.Text = "T"
                Label4.Text = "R"
                Label5.Text = "B"
            Else
                Label1.Text = "All"
                Label2.Text = "Left"
                Label3.Text = "Top"
                Label4.Text = "Right"
                Label5.Text = "Bottom"
            End If
        End With
    End Sub
End Class

Public Class KzPadingSetterDesigner
    Inherits System.Windows.Forms.Design.ControlDesigner

    Public Sub New()

    End Sub

    Public Overrides ReadOnly Property SelectionRules() As SelectionRules
        Get
            Dim control As KzPadingSetter =
                CType(IIf(TypeOf Me.Control Is KzPadingSetter, Me.Control, Nothing), KzPadingSetter)

            ' Disallow vertical or horizontal sizing when AutoSize = True
            If Not control Is Nothing AndAlso control.AutoSize = True Then
                Return (MyBase.SelectionRules And (Not SelectionRules.TopSizeable)) And Not SelectionRules.BottomSizeable
            Else
                Return MyBase.SelectionRules
            End If
        End Get
    End Property

    'Overrides
    ''' <summary>
    ''' Remove Button and Control properties that are 
    ''' not supported by the <see cref="KzPadingSetter"/>.
    ''' </summary>
    Protected Overrides Sub PostFilterProperties(ByVal Properties As IDictionary)
        Properties.Remove("AllowDrop")
        Properties.Remove("BackgroundImage")
        Properties.Remove("ContextMenu")

        Properties.Remove("Text")
        Properties.Remove("TextAlign")
        Properties.Remove("RightToLeft")
    End Sub

    'Overrides
    ''' <summary>
    ''' Remove Button and Control events that are 
    ''' not supported by the <see cref="KzTrackBar"/>.
    ''' </summary>
    Protected Overrides Sub PostFilterEvents(ByVal events As IDictionary)
        'Actions
        events.Remove("Click")
        events.Remove("DoubleClick")

        'Appearence
        events.Remove("Paint")

        'Behavior
        events.Remove("ChangeUICues")
        events.Remove("ImeModeChanged")
        events.Remove("QueryAccessibilityHelp")
        events.Remove("StyleChanged")
        events.Remove("SystemColorsChanged")

        'Drag Drop
        events.Remove("DragDrop")
        events.Remove("DragEnter")
        events.Remove("DragLeave")
        events.Remove("DragOver")
        events.Remove("GiveFeedback")
        events.Remove("QueryContinueDrag")
        events.Remove("DragDrop")

        'Layout
        events.Remove("Layout")
        events.Remove("Move")
        events.Remove("Resize")

        'Property Changed
        events.Remove("BackColorChanged")
        events.Remove("BackgroundImageChanged")
        events.Remove("BindingContextChanged")
        events.Remove("CausesValidationChanged")
        events.Remove("CursorChanged")
        events.Remove("FontChanged")
        events.Remove("ForeColorChanged")
        events.Remove("RightToLeftChanged")
        events.Remove("SizeChanged")
        events.Remove("TextChanged")

        MyBase.PostFilterEvents(events)
    End Sub
End Class
