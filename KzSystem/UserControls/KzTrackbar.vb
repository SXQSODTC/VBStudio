﻿Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms.Design

#Region "Declaration"

''' <summary>
''' Represents the method that will handle a change in value.
''' </summary>
Public Delegate Sub ValueChangedHandler(ByVal sender As Object, ByVal value As Decimal)

Public Enum KzBorderStyle
    ''' <summary>
    ''' No border.
    ''' </summary>
    None
    ''' <summary>
    ''' A dashed border.
    ''' </summary>
    Dashed 'from ButtonBorderStyle Enumeration
    ''' <summary>
    ''' A dotted-line border.
    ''' </summary>
    Dotted 'from ButtonBorderStyle Enumeration
    ''' <summary>
    ''' A sunken border.
    ''' </summary>
    Inset 'from ButtonBorderStyle Enumeration
    ''' <summary>
    ''' A raised border.
    ''' </summary>
    Outset 'from ButtonBorderStyle Enumeration
    ''' <summary>
    ''' A solid border.
    ''' </summary>
    Solid 'from ButtonBorderStyle Enumeration

    ''' <summary>
    ''' The border is drawn outside the specified rectangle, preserving the dimensions of the rectangle for drawing.
    ''' </summary>
    Adjust 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The inner and outer edges of the border have a raised appearance.
    ''' </summary>
    Bump 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The inner and outer edges of the border have an etched appearance.
    ''' </summary>
    Etched 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has no three-dimensional effects.
    ''' </summary>
    Flat 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has raised inner and outer edges.
    ''' </summary>
    Raised 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has a raised inner edge and no outer edge.
    ''' </summary>
    RaisedInner 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has a raised outer edge and no inner edge.
    ''' </summary>
    RaisedOuter 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has sunken inner and outer edges.
    ''' </summary>
    Sunken 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has a sunken inner edge and no outer edge.
    ''' </summary>
    SunkenInner 'from Border3DStyle Enumeration
    ''' <summary>
    ''' The border has a sunken outer edge and no inner edge.
    ''' </summary>
    SunkenOuter 'from Border3DStyle Enumeration
End Enum

#End Region



''' <summary>
''' The Designer for the <see cref="KzTrackBar"/>.
''' </summary>
Public Class KzTrackBarDesigner
    Inherits System.Windows.Forms.Design.ControlDesigner

    Public Sub New()
    End Sub

    ''' <summary>
    ''' Returns the allowable design time selection rules.
    ''' </summary>
    Public Overrides ReadOnly Property SelectionRules() As SelectionRules

        Get
            Dim control As KzTrackBar =
                CType(IIf(TypeOf Me.Control Is KzTrackBar, Me.Control, Nothing), KzTrackBar)

            ' Disallow vertical or horizontal sizing when AutoSize = True
            If Not control Is Nothing AndAlso control.AutoSize = True Then
                If control.Orientation = Orientation.Horizontal Then
                    Return (MyBase.SelectionRules And
                        (Not SelectionRules.TopSizeable)) And
                        Not SelectionRules.BottomSizeable
                Else 'control.Orientation == Orientation.Vertical
                    Return (MyBase.SelectionRules And
                        (Not SelectionRules.LeftSizeable)) And
                        Not SelectionRules.RightSizeable
                End If
            Else
                Return MyBase.SelectionRules
            End If

        End Get
    End Property



    'Overrides
    ''' <summary>
    ''' Remove Button and Control properties that are 
    ''' not supported by the <see cref="KzTrackBar"/>.
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





''' <summary>
'''	  <para>
'''		KzTrackBar represents an advanced track bar that is very better than the 
'''		standard trackbar.
'''   </para>
'''   <para>
'''   KzTrackBar supports the following features:
'''   <list type="bullet">
'''     <item><c>MAC style, Office2003 style, IDE2003 style and Plain style.</c></item>
'''     <item><c>Vertical and Horizontal trackbar.</c></item>
'''     <item><c>Supports many Text Tick styles: None, TopLeft, BottomRight, Both. You can change Text Font, ForeColor.</c></item> 
'''     <item><c>Supports many Tick styles: None, TopLeft, BottomRight, Both.</c></item> 
'''     <item><c>You can change <see cref="KzTrackBar.TickColor"/>, <see cref="KzTrackBar.TickFrequency"/>, <see cref="KzTrackBar.TickHeight"/>.</c></item> 
'''     <item><c>You can change <see cref="KzTrackBar.TrackerColor"/> and <see cref="KzTrackBar.TrackerSize"/>.</c></item> 
'''     <item><c>You can change <see cref="KzTrackBar.TrackLineColor"/> and <see cref="KzTrackBar.TrackLineHeight"/>.</c></item> 	
'''     <item><c>Easy to Use and Integrate in Visual Studio .NET.</c></item> 
'''     <item><c>100% compatible to the standard control in VS.NET.</c></item> 
'''     <item><c>100% managed code.</c></item> 
'''     <item><c>No coding RAD component.</c></item> 
'''   </list>
'''   </para>
''' </summary>
<Description("KzTrackBar represents an advanced track bar that is very better than the standard trackbar."),
    ToolboxBitmap(GetType(KzTrackBar), "Editors.KzTrackBar.KzTrackBar.bmp"), Designer(GetType(KzTrackBarDesigner)),
    DefaultProperty("Maximum"), DefaultEvent("ValueChanged")>
Public Class KzTrackBar
    Inherits System.Windows.Forms.Control

#Region "Private Members"

    ' Instance fields
    Private _value As Integer = 0
    Private _minimum As Integer = 0
    Private _maximum As Integer = 10

    Private _largeChange As Integer = 2
    Private _smallChange As Integer = 1

    Private _orientation As Orientation = Orientation.Horizontal

    Private _borderStyle As KzBorderStyle = KzBorderStyle.None
    Private _borderColor As Color = SystemColors.ActiveBorder

    Private _trackerSize As Size = New Size(10, 20)
    Private _indentWidth As Integer = 6
    Private _indentHeight As Integer = 6

    Private _tickHeight As Integer = 2
    Private _tickFrequency As Integer = 1
    Private _tickColor As Color = Color.Black
    Private _tickStyle As TickStyle = TickStyle.BottomRight
    Private _textTickStyle As TickStyle = TickStyle.BottomRight

    Private _trackLineHeight As Integer = 3
    Private _trackLineColor As Color = SystemColors.Control

    Private _trackerColor As Color = SystemColors.Control
    Public _trackerRect As RectangleF = RectangleF.Empty

    Private _autoSize As Boolean = True

    Private leftButtonDown As Boolean = False
    Private mouseStartPos As Single = -1

    ''' <summary>
    ''' Occurs when the property Value has been changed.
    ''' </summary>
    Public Event ValueChanged As ValueChangedHandler
    ''' <summary>
    ''' Occurs when either a mouse or keyboard action moves the slider.
    ''' </summary>
    Public Event Scroll As EventHandler

#End Region

#Region "Public Contruction"

    ''' <summary>
    ''' Constructor method of <see cref="KzTrackBar"/> class
    ''' </summary>
    Public Sub New()
        AddHandler MouseDown, AddressOf OnMouseDownSlider
        AddHandler MouseUp, AddressOf OnMouseUpSlider
        AddHandler MouseMove, AddressOf OnMouseMoveSlider

        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.DoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)

        Font = New Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(123, 125, 123)
        BackColor = Color.Transparent

        _tickColor = Color.FromArgb(148, 146, 148)
        _tickHeight = 4

        _trackerColor = Color.FromArgb(24, 130, 198)
        _trackerSize = New Size(16, 16)
        _indentWidth = 6
        _indentHeight = 6

        _trackLineColor = Color.FromArgb(90, 93, 90)
        _trackLineHeight = 3

        _borderStyle = KzBorderStyle.None
        _borderColor = SystemColors.ActiveBorder

        _autoSize = True
        Me.Height = FitSize.Height
    End Sub

#End Region

#Region "Public Properties"


    ''' <summary>
    ''' Gets or sets a value indicating whether the height or width of the track bar is being automatically sized.
    ''' </summary>
    ''' <remarks>You can set the AutoSize property to true to cause the track bar to adjust either its height or width, depending on orientation, to ensure that the control uses only the required amount of space.</remarks>
    ''' <value>true if the track bar is being automatically sized; otherwise, false. The default is true.</value>
    <Category("Behavior"), Description("Gets or sets the height of track line."), DefaultValue(4)>
    Public Overloads Property AutoSize() As Boolean
        Get
            Return _autoSize
        End Get

        Set(ByVal Value As Boolean)
            If _autoSize <> Value Then
                _autoSize = Value
                If _autoSize = True Then
                    Me.Size = FitSize
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value to be added to or subtracted from the <see cref="Value"/> property when the slider is moved a large distance.
    ''' </summary>
    ''' <remarks>
    ''' When the user presses the PAGE UP or PAGE DOWN key or clicks the track bar on either side of the slider, the <see cref="Value"/> 
    ''' property changes according to the value set in the <see cref="LargeChange"/> property. 
    ''' You might consider setting the <see cref="LargeChange"/> value to a percentage of the <see cref="Control.Height"/> (for a vertically oriented track bar) or 
    ''' <see cref="Control.Width"/> (for a horizontally oriented track bar) values. This keeps the distance your track bar moves proportionate to its size.
    ''' </remarks>
    ''' <value>A numeric value. The default value is 2.</value>
    <Category("Behavior"), Description("Gets or sets a value to be added to or subtracted from the Value property when the slider is moved a large distance."), DefaultValue(2)>
    Public Property LargeChange() As Integer
        Get
            Return _largeChange
        End Get

        Set(ByVal Value As Integer)
            _largeChange = Value
            If _largeChange < 1 Then
                _largeChange = 1
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value to be added to or subtracted from the <see cref="Value"/> property when the slider is moved a small distance.
    ''' </summary>
    ''' <remarks>
    ''' When the user presses one of the arrow keys, the <see cref="Value"/> property changes according to the value set in the SmallChange property.
    ''' You might consider setting the <see cref="SmallChange"/> value to a percentage of the <see cref="Control.Height"/> (for a vertically oriented track bar) or 
    ''' <see cref="Control.Width"/> (for a horizontally oriented track bar) values. This keeps the distance your track bar moves proportionate to its size.
    ''' </remarks>
    ''' <value>A numeric value. The default value is 1.</value>
    <Category("Behavior"), Description("Gets or sets a value to be added to or subtracted from the Value property when the slider is moved a small distance."), DefaultValue(1)>
    Public Property SmallChange() As Integer
        Get
            Return _smallChange
        End Get

        Set(ByVal Value As Integer)
            _smallChange = Value
            If _smallChange < 1 Then
                _smallChange = 1
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the height of track line.
    ''' </summary>
    ''' <value>The default value is 4.</value>
    <Category("Appearance"), Description("Gets or sets the height of track line."), DefaultValue(4)>
    Public Property TrackLineHeight() As Integer
        Get
            Return _trackLineHeight
        End Get

        Set(ByVal Value As Integer)
            If _trackLineHeight <> Value Then
                _trackLineHeight = Value
                If _trackLineHeight < 1 Then
                    _trackLineHeight = 1
                End If

                If _trackLineHeight > _trackerSize.Height Then
                    _trackLineHeight = _trackerSize.Height
                End If

                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the tick's <see cref="Color"/> of the control.
    ''' </summary>
    <Category("Appearance"), Description("Gets or sets the tick's color of the control.")>
    Public Property TickColor() As Color
        Get
            Return _tickColor
        End Get

        Set(ByVal Value As Color)
            If Not _tickColor.Equals(Value) Then
                _tickColor = Value
                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value that specifies the delta between ticks drawn on the control.
    ''' </summary>
    ''' <remarks>
    ''' For a <see cref="KzTrackBar"/> with a large range of values between the <see cref="Minimum"/> and the 
    ''' <see cref="Maximum"/>, it might be impractical to draw all the ticks for values on the control. 
    ''' For example, if you have a control with a range of 100, passing in a value of 
    ''' five here causes the control to draw 20 ticks. In this case, each tick 
    ''' represents five units in the range of values.
    ''' </remarks>
    ''' <value>The numeric value representing the delta between ticks. The default is 1.</value>
    <Category("Appearance"), Description("Gets or sets a value that specifies the delta between ticks drawn on the control."), DefaultValue(1)>
    Public Property TickFrequency() As Integer
        Get
            Return _tickFrequency
        End Get

        Set(ByVal Value As Integer)
            If _tickFrequency <> Value Then
                _tickFrequency = Value
                If _tickFrequency < 1 Then
                    _tickFrequency = 1
                End If
                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the height of tick.
    ''' </summary>
    ''' <value>The height of tick in pixels. The default value is 2.</value>
    <Category("Appearance"), Description("Gets or sets the height of tick."), DefaultValue(6)>
    Public Property TickHeight() As Integer
        Get
            Return _tickHeight
        End Get

        Set(ByVal Value As Integer)
            If _tickHeight <> Value Then
                _tickHeight = Value

                If _tickHeight < 1 Then
                    _tickHeight = 1
                End If

                If _autoSize = True Then
                    Me.Size = FitSize
                End If

                Me.Invalidate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the height of indent (or Padding-Y).
    ''' </summary>
    ''' <value>The height of indent in pixels. The default value is 6.</value>
    <Category("Appearance"), Description("Gets or sets the height of indent."), DefaultValue(2)>
    Public Property IndentHeight() As Integer
        Get
            Return _indentHeight
        End Get

        Set(ByVal Value As Integer)
            If _indentHeight <> Value Then
                _indentHeight = Value
                If _indentHeight < 0 Then
                    _indentHeight = 0
                End If

                If _autoSize = True Then
                    Me.Size = FitSize
                End If

                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the width of indent (or Padding-Y).
    ''' </summary>
    ''' <value>The width of indent in pixels. The default value is 6.</value>
    <Category("Appearance"), Description("Gets or sets the width of indent."), DefaultValue(6)>
    Public Property IndentWidth() As Integer
        Get
            Return _indentWidth
        End Get

        Set(ByVal Value As Integer)
            If _indentWidth <> Value Then
                _indentWidth = Value
                If _indentWidth < 0 Then
                    _indentWidth = 0
                End If

                If _autoSize = True Then
                    Me.Size = FitSize
                End If

                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the tracker's size. 
    ''' The tracker's width must be greater or equal to tracker's height.
    ''' </summary>
    ''' <value>The <see cref="Size"/> object that represents the height and width of the tracker in pixels.</value>
    <Category("Appearance"), Description("Gets or sets the tracker's size.")>
    Public Property TrackerSize() As Size
        Get
            Return _trackerSize
        End Get

        Set(ByVal Value As Size)
            If Not _trackerSize.Equals(Value) Then
                _trackerSize = Value
                If _trackerSize.Width > _trackerSize.Height Then
                    _trackerSize.Height = _trackerSize.Width
                End If

                If _autoSize = True Then
                    Me.Size = FitSize
                End If

                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the text tick style of the trackbar.
    ''' There are 4 styles for selection: None, TopLeft, BottomRight, Both. 
    ''' </summary>
    ''' <remarks>You can use the <see cref="Control.Font"/>, <see cref="Control.ForeColor"/>
    ''' properties to customize the tick text.</remarks>
    ''' <value>One of the <see cref="TickStyle"/> values. The default is <b>BottomRight</b>.</value>
    <Category("Appearance"), Description("Gets or sets the text tick style."), DefaultValue(System.Windows.Forms.TickStyle.BottomRight)>
    Public Property TextTickStyle() As TickStyle
        Get
            Return _textTickStyle
        End Get

        Set(ByVal Value As TickStyle)
            If _textTickStyle <> Value Then
                _textTickStyle = Value

                If _autoSize = True Then
                    Me.Size = FitSize
                End If

                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the tick style of the trackbar.
    ''' There are 4 styles for selection: None, TopLeft, BottomRight, Both. 
    ''' </summary>
    ''' <remarks>You can use the <see cref="TickColor"/>, <see cref="TickFrequency"/>, 
    ''' <see cref="TickHeight"/> properties to customize the trackbar's ticks.</remarks>
    ''' <value>One of the <see cref="TickStyle"/> values. The default is <b>BottomRight</b>.</value>
    <Category("Appearance"), Description("Gets or sets the tick style."), DefaultValue(System.Windows.Forms.TickStyle.BottomRight)>
    Public Property TickStyle() As TickStyle
        Get
            Return _tickStyle
        End Get

        Set(ByVal Value As TickStyle)
            If _tickStyle <> Value Then
                _tickStyle = Value

                If _autoSize = True Then
                    Me.Size = FitSize
                End If

                Me.Invalidate()
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or set tracker's color.
    ''' </summary>
    ''' <value>
    ''' <remarks>You can change size of tracker by <see cref="TrackerSize"/> property.</remarks>
    ''' A <see cref="Color"/> that represents the color of the tracker. 
    ''' </value>
    <Description("Gets or set tracker's color."), Category("Appearance")>
    Public Property TrackerColor() As Color
        Get
            Return _trackerColor
        End Get
        Set(ByVal Value As Color)
            If Not _trackerColor.Equals(Value) Then
                _trackerColor = Value
                Me.Invalidate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a numeric value that represents the current position of the slider on the track bar.
    ''' </summary>
    ''' <remarks>The Value property contains the number that represents the current position of the slider on the track bar.</remarks>
    ''' <value>A numeric value that is within the <see cref="Minimum"/> and <see cref="Maximum"/> range. 
    ''' The default value is 0.</value>
    <Description("The current value for the KzTrackBar, in the range specified by the Minimum and Maximum properties."), Category("Behavior")>
    Public Property Value() As Integer
        Get
            Return _value
        End Get
        Set(ByVal Value As Integer)
            If _value <> Value Then
                If Value < _minimum Then
                    _value = _minimum
                Else
                    If Value > _maximum Then
                        _value = _maximum
                    Else
                        _value = Value
                    End If
                End If

                OnValueChanged(_value)

                Me.Invalidate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the lower limit of the range this <see cref="KzTrackBar"/> is working with.
    ''' </summary>
    ''' <remarks>You can use the <see cref="SetRange"/> method to set both the <see cref="Maximum"/> and <see cref="Minimum"/> properties at the same time.</remarks>
    ''' <value>The minimum value for the <see cref="KzTrackBar"/>. The default value is 0.</value>
    <Description("The lower bound of the range this KzTrackBar is working with."), Category("Behavior")>
    Public Property Minimum() As Integer
        Get
            Return _minimum
        End Get
        Set(ByVal Value As Integer)
            _minimum = Value

            If _minimum > _maximum Then
                _maximum = _minimum
            End If
            If _minimum > _value Then
                _value = _minimum
            End If
            If _autoSize = True Then
                Me.Size = FitSize
            End If
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the upper limit of the range this <see cref="KzTrackBar"/> is working with.
    ''' </summary>
    ''' <remarks>You can use the <see cref="SetRange"/> method to set both the <see cref="Maximum"/> and <see cref="Minimum"/> properties at the same time.</remarks>
    ''' <value>The maximum value for the <see cref="KzTrackBar"/>. The default value is 10.</value>
    <Description("The uppper bound of the range this KzTrackBar is working with."), Category("Behavior")>
    Public Property Maximum() As Integer
        Get
            Return _maximum
        End Get
        Set(ByVal Value As Integer)
            _maximum = Value

            If _maximum < _value Then
                _value = _maximum
            End If
            If _maximum < _minimum Then
                _minimum = _maximum
            End If
            If _autoSize = True Then
                Me.Size = FitSize
            End If
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating the horizontal or vertical orientation of the track bar.
    ''' </summary>
    ''' <remarks>
    ''' When the <b>Orientation</b> property is set to <b>Orientation.Horizontal</b>, 
    ''' the slider moves from left to right as the <see cref="Value"/> increases. 
    ''' When the <b>Orientation</b> property is set to <b>Orientation.Vertical</b>, the slider moves 
    ''' from bottom to top as the <see cref="Value"/> increases.
    ''' </remarks>
    ''' <value>One of the <see cref="Orientation"/> values. The default value is <b>Horizontal</b>.</value>
    <Description("Gets or sets a value indicating the horizontal or vertical orientation of the track bar."), Category("Behavior"), DefaultValue(System.Windows.Forms.Orientation.Horizontal)>
    Public Property Orientation() As Orientation
        Get
            Return _orientation
        End Get
        Set(ByVal Value As Orientation)
            If Value <> _orientation Then
                _orientation = Value
                If _orientation = Orientation.Horizontal Then
                    If Me.Width < Me.Height Then
                        Dim temp As Integer = Me.Width
                        Me.Width = Me.Height
                        Me.Height = temp
                    End If
                Else 'Vertical
                    If Me.Width > Me.Height Then
                        Dim temp As Integer = Me.Width
                        Me.Width = Me.Height
                        Me.Height = temp
                    End If
                End If
                Me.Invalidate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the border type of the trackbar control.
    ''' </summary>
    ''' <value>A <see cref="KzBorderStyle"/> that represents the border type of the trackbar control. 
    ''' The default is <b>KzBorderStyle.None</b>.</value>
    <Description("Gets or sets the border type of the trackbar control."), Category("Appearance"), DefaultValue(GetType(KzBorderStyle), "None"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderStyle() As KzBorderStyle
        Get
            Return _borderStyle
        End Get
        Set(ByVal Value As KzBorderStyle)
            If _borderStyle <> Value Then
                _borderStyle = Value
                Me.Invalidate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the border color of the control.
    ''' </summary>
    ''' <value>A <see cref="Color"/> object that represents the border color of the control.</value>
    <Category("Appearance"), Description("Gets or sets the border color of the control.")>
    Public Property BorderColor() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal Value As Color)
            If Not Value.Equals(_borderColor) Then
                _borderColor = Value
                Invalidate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the color of the track line.
    ''' </summary>
    ''' <value>A <see cref="Color"/> object that represents the color of the track line.</value>
    <Category("Appearance"), Description("Gets or sets the color of the track line.")>
    Public Property TrackLineColor() As Color
        Get
            Return _trackLineColor
        End Get
        Set(ByVal Value As Color)
            If Not Value.Equals(_trackLineColor) Then
                _trackLineColor = Value
                Invalidate()
            End If
        End Set
    End Property


#End Region

#Region "Private Properties"

    ''' <summary>
    ''' Gets the Size of area need for drawing.
    ''' </summary>
    <Description("Gets the Size of area need for drawing."), Browsable(False)>
    Private ReadOnly Property FitSize() As Size
        Get
            'INSTANT VB NOTE: The local variable fitSize was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim fitSize_Renamed As Size
            Dim textAreaSize As Single

            ' Create a Graphics object for the Control.
            Dim g As Graphics = Me.CreateGraphics()

            Dim workingRect As Rectangle = Rectangle.Inflate(Me.ClientRectangle, -_indentWidth, -_indentHeight)
            Dim currentUsedPos As Single = 0

            If _orientation = Orientation.Horizontal Then
                currentUsedPos = _indentHeight
                '==========================================================================

                ' Get Height of Text Area
                textAreaSize = g.MeasureString(_maximum.ToString(), Me.Font).Height

                If _textTickStyle = TickStyle.TopLeft OrElse _textTickStyle = TickStyle.Both Then
                    currentUsedPos += textAreaSize
                End If

                If _tickStyle = TickStyle.TopLeft OrElse _tickStyle = TickStyle.Both Then
                    currentUsedPos += _tickHeight + 1
                End If

                currentUsedPos += _trackerSize.Height

                If _tickStyle = TickStyle.BottomRight OrElse _tickStyle = TickStyle.Both Then
                    currentUsedPos += 1
                    currentUsedPos += _tickHeight
                End If

                If _textTickStyle = TickStyle.BottomRight OrElse _textTickStyle = TickStyle.Both Then
                    currentUsedPos += textAreaSize
                End If

                currentUsedPos += _indentHeight

                fitSize_Renamed = New Size(Me.ClientRectangle.Width, CInt(Fix(currentUsedPos)))
            Else '_orientation == Orientation.Vertical
                currentUsedPos = _indentWidth
                '==========================================================================

                ' Get Width of Text Area
                textAreaSize = g.MeasureString(_maximum.ToString(), Me.Font).Width

                If _textTickStyle = TickStyle.TopLeft OrElse _textTickStyle = TickStyle.Both Then
                    currentUsedPos += textAreaSize
                End If

                If _tickStyle = TickStyle.TopLeft OrElse _tickStyle = TickStyle.Both Then
                    currentUsedPos += _tickHeight + 1
                End If

                currentUsedPos += _trackerSize.Height

                If _tickStyle = TickStyle.BottomRight OrElse _tickStyle = TickStyle.Both Then
                    currentUsedPos += 1
                    currentUsedPos += _tickHeight
                End If

                If _textTickStyle = TickStyle.BottomRight OrElse _textTickStyle = TickStyle.Both Then
                    currentUsedPos += textAreaSize
                End If

                currentUsedPos += _indentWidth

                fitSize_Renamed = New Size(CInt(Fix(currentUsedPos)), Me.ClientRectangle.Height)

            End If

            ' Clean up the Graphics object.
            g.Dispose()

            Return fitSize_Renamed
        End Get
    End Property


    ''' <summary>
    ''' Gets the rectangle containing the tracker.
    ''' </summary>
    <Description("Gets the rectangle containing the tracker.")>
    Private ReadOnly Property TrackerRect() As RectangleF
        Get
            'INSTANT VB NOTE: The local variable trackerRect was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim trackerRect_Renamed As RectangleF
            Dim textAreaSize As Single

            ' Create a Graphics object for the Control.
            Dim g As Graphics = Me.CreateGraphics()

            Dim workingRect As Rectangle = Rectangle.Inflate(Me.ClientRectangle, -_indentWidth, -_indentHeight)
            Dim currentUsedPos As Single = 0

            If _orientation = Orientation.Horizontal Then
                currentUsedPos = _indentHeight
                '==========================================================================

                ' Get Height of Text Area
                textAreaSize = g.MeasureString(_maximum.ToString(), Me.Font).Height

                If _textTickStyle = TickStyle.TopLeft OrElse _textTickStyle = TickStyle.Both Then
                    currentUsedPos += textAreaSize
                End If

                If _tickStyle = TickStyle.TopLeft OrElse _tickStyle = TickStyle.Both Then
                    currentUsedPos += _tickHeight + 1
                End If


                '==========================================================================
                ' Caculate the Tracker's rectangle
                '==========================================================================
                Dim currentTrackerPos As Single
                If _maximum = _minimum Then
                    currentTrackerPos = workingRect.Left
                Else
                    currentTrackerPos = (workingRect.Width - _trackerSize.Width) *
                        (_value - _minimum) / (_maximum - _minimum) + workingRect.Left
                End If

                trackerRect_Renamed = New RectangleF _
                    (currentTrackerPos, currentUsedPos,
                     _trackerSize.Width, _trackerSize.Height) ' Remember this for drawing the Tracker later

                trackerRect_Renamed.Inflate(0, -1)
            Else '_orientation == Orientation.Vertical
                currentUsedPos = _indentWidth
                '==========================================================================

                ' Get Width of Text Area
                textAreaSize = g.MeasureString(_maximum.ToString(), Me.Font).Width

                If _textTickStyle = TickStyle.TopLeft OrElse _textTickStyle = TickStyle.Both Then
                    currentUsedPos += textAreaSize
                End If

                If _tickStyle = TickStyle.TopLeft OrElse _tickStyle = TickStyle.Both Then
                    currentUsedPos += _tickHeight + 1
                End If

                '==========================================================================
                ' Caculate the Tracker's rectangle
                '==========================================================================
                Dim currentTrackerPos As Single
                If _maximum = _minimum Then
                    currentTrackerPos = workingRect.Top
                Else
                    currentTrackerPos = (workingRect.Height - _trackerSize.Width) *
                        (_value - _minimum) / (_maximum - _minimum)
                End If

                trackerRect_Renamed = New RectangleF _
                    (currentUsedPos, workingRect.Bottom - currentTrackerPos - _trackerSize.Width,
                     _trackerSize.Height, _trackerSize.Width) ' Remember this for drawing the Tracker later
                trackerRect_Renamed.Inflate(-1, 0)


            End If

            ' Clean up the Graphics object.
            g.Dispose()

            Return trackerRect_Renamed
        End Get
    End Property

#End Region


#Region "Public Methods"


    '' <summary>
    '' Raises the ValueChanged event.
    '' </summary>
    '' <param name="value">The new value</param>
    'INSTANT VB NOTE: The parameter value was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
    Public Overridable Sub OnValueChanged(ByVal value_Renamed As Integer)
        ' Any attached event handlers?
        If Not ValueChangedEvent Is Nothing Then
            RaiseEvent ValueChanged(Me, value_Renamed)
        End If

    End Sub

    ''' <summary>
    ''' Raises the Scroll event.
    ''' </summary>
    Public Overridable Sub OnScroll()
        Try
            ' Any attached event handlers?
            If Not ScrollEvent Is Nothing Then
                RaiseEvent Scroll(Me, New System.EventArgs)
            End If
        Catch Err As Exception
            MessageBox.Show("OnScroll Exception: " & Err.Message)
        End Try

    End Sub


    '' <summary>
    '' Call the Increment() method to increase the value displayed by an integer you specify 
    '' </summary>
    '' <param name="value"></param>
    'INSTANT VB NOTE: The parameter value was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
    Public Sub Increment(ByVal value_Renamed As Integer)
        If _value < _maximum Then
            _value += value_Renamed
            If _value > _maximum Then
                _value = _maximum
            End If
        Else
            _value = _maximum
        End If

        OnValueChanged(_value)
        Me.Invalidate()
    End Sub

    '' <summary>
    '' Call the Decrement() method to decrease the value displayed by an integer you specify 
    '' </summary>
    '' <param name="value"> The value to decrement</param>
    'INSTANT VB NOTE: The parameter value was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
    Public Sub Decrement(ByVal value_Renamed As Integer)
        If _value > _minimum Then
            _value -= value_Renamed
            If _value < _minimum Then
                _value = _minimum
            End If
        Else
            _value = _minimum
        End If

        OnValueChanged(_value)
        Me.Invalidate()
    End Sub

    ''' <summary>
    ''' Sets the minimum and maximum values for a TrackBar.
    ''' </summary>
    ''' <param name="minValue">The lower limit of the range of the track bar.</param>
    ''' <param name="maxValue">The upper limit of the range of the track bar.</param>
    Public Sub SetRange(ByVal minValue As Integer, ByVal maxValue As Integer)
        _minimum = minValue

        If _minimum > _value Then
            _value = _minimum
        End If

        _maximum = maxValue

        If _maximum < _value Then
            _value = _maximum
        End If
        If _maximum < _minimum Then
            _minimum = _maximum
        End If

        Me.Invalidate()
    End Sub

    ''' <summary>
    ''' Reset the appearance properties.
    ''' </summary>
    Public Sub ResetAppearance()
        Font = New Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(123, 125, 123)
        BackColor = Color.Transparent

        _tickColor = Color.FromArgb(148, 146, 148)
        _tickHeight = 4

        _trackerColor = Color.FromArgb(24, 130, 198)
        _trackerSize = New Size(16, 16)
        '_trackerRect.Size = _trackerSize;

        _indentWidth = 6
        _indentHeight = 6

        _trackLineColor = Color.FromArgb(90, 93, 90)
        _trackLineHeight = 3

        _borderStyle = KzBorderStyle.None
        _borderColor = SystemColors.ActiveBorder

        '==========================================================================

        If _autoSize = True Then
            Me.Size = FitSize
        End If
        Invalidate()
    End Sub

#End Region

#Region "Protected Methods"

    ''' <summary>
    ''' The OnCreateControl method is called when the control is first created.
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
    End Sub

    ''' <summary>
    ''' This member overrides <see cref="Control.OnLostFocus">Control.OnLostFocus</see>.
    ''' </summary>
    Protected Overrides Sub OnLostFocus(ByVal e As EventArgs)
        Me.Invalidate()
        MyBase.OnLostFocus(e)
    End Sub

    ''' <summary>
    ''' This member overrides <see cref="Control.OnGotFocus">Control.OnGotFocus</see>.
    ''' </summary>
    Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
        Me.Invalidate()
        MyBase.OnGotFocus(e)
    End Sub

    ''' <summary>
    ''' This member overrides <see cref="Control.OnClick">Control.OnClick</see>.
    ''' </summary>
    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        Me.Focus()
        Me.Invalidate()
        MyBase.OnClick(e)
    End Sub

    ''' <summary>
    ''' This member overrides <see cref="Control.ProcessCmdKey">Control.ProcessCmdKey</see>.
    ''' </summary>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim blResult As Boolean = True

        '' <summary>
        '' Specified WM_KEYDOWN enumeration value.
        '' </summary>
        Const WM_KEYDOWN As Integer = &H100

        '' <summary>
        '' Specified WM_SYSKEYDOWN enumeration value.
        '' </summary>
        Const WM_SYSKEYDOWN As Integer = &H104


        If (msg.Msg = WM_KEYDOWN) OrElse (msg.Msg = WM_SYSKEYDOWN) Then
            Select Case keyData
                Case Keys.Left, Keys.Down
                    Me.Decrement(_smallChange)
                Case Keys.Right, Keys.Up
                    Me.Increment(_smallChange)

                Case Keys.PageUp
                    Me.Increment(_largeChange)
                Case Keys.PageDown
                    Me.Decrement(_largeChange)

                Case Keys.Home
                    Value = _maximum
                Case Keys.End
                    Value = _minimum

                Case Else
                    blResult = MyBase.ProcessCmdKey(msg, keyData)
            End Select
        End If

        Return blResult
    End Function

    ''' <summary>
    ''' Dispose of instance resources.
    ''' </summary>
    ''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

#End Region

#Region "Painting Methods"

    ''' <summary>
    ''' This member overrides <see cref="Control.OnPaint">Control.OnPaint</see>.
    ''' </summary>
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim brush As Brush
        Dim rectTemp, drawRect As RectangleF
        Dim textAreaSize As Single

        Dim workingRect As Rectangle = Rectangle.Inflate(Me.ClientRectangle, -_indentWidth, -_indentHeight)
        Dim currentUsedPos As Single = 0

        '==========================================================================
        ' Draw the background of the ProgressBar control.
        '==========================================================================
        brush = New SolidBrush(Me.BackColor)
        rectTemp = New RectangleF(Me.ClientRectangle.X, Me.ClientRectangle.Y,
                                  Me.ClientRectangle.Width, Me.ClientRectangle.Height)

        e.Graphics.FillRectangle(brush, rectTemp)
        brush.Dispose()
        '==========================================================================

        '==========================================================================
        If _orientation = Orientation.Horizontal Then
            currentUsedPos = _indentHeight
            '==========================================================================

            ' Get Height of Text Area
            textAreaSize = e.Graphics.MeasureString(_maximum.ToString(), Me.Font).Height

            If _textTickStyle = TickStyle.TopLeft OrElse _textTickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 1st Text Line.
                '==========================================================================
                drawRect = New RectangleF(workingRect.Left, currentUsedPos, workingRect.Width, textAreaSize)
                drawRect.Inflate(-_trackerSize.Width / 2, 0)
                currentUsedPos += textAreaSize

                DrawTickTextLine(e.Graphics, drawRect, _tickFrequency,
                                 _minimum, _maximum, Me.ForeColor, Me.Font, _orientation)
                '==========================================================================
            End If

            If _tickStyle = TickStyle.TopLeft OrElse _tickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 1st Tick Line.
                '==========================================================================
                drawRect = New RectangleF(workingRect.Left, currentUsedPos, workingRect.Width, _tickHeight)
                drawRect.Inflate(-_trackerSize.Width / 2, 0)
                currentUsedPos += _tickHeight + 1

                DrawTickLine(e.Graphics, drawRect, _tickFrequency, _minimum, _maximum, _tickColor, _orientation)
                '==========================================================================
            End If

            '==========================================================================
            ' Caculate the Tracker's rectangle
            '==========================================================================
            Dim currentTrackerPos As Single
            If _maximum = _minimum Then
                currentTrackerPos = workingRect.Left
            Else
                currentTrackerPos = (workingRect.Width - _trackerSize.Width) *
                    (_value - _minimum) / (_maximum - _minimum) + workingRect.Left
            End If
            _trackerRect = New RectangleF(currentTrackerPos, currentUsedPos,
                                          _trackerSize.Width, _trackerSize.Height) ' Remember this for drawing the Tracker later
            '_trackerRect.Inflate(0,-1);

            '==========================================================================
            ' Draw the Track Line
            '==========================================================================
            drawRect = New RectangleF(workingRect.Left,
                                      currentUsedPos + _trackerSize.Height / 2 - _trackLineHeight / 2,
                                      workingRect.Width, _trackLineHeight)
            DrawTrackLine(e.Graphics, drawRect)
            currentUsedPos += _trackerSize.Height


            '==========================================================================

            If _tickStyle = TickStyle.BottomRight OrElse _tickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 2st Tick Line.
                '==========================================================================
                currentUsedPos += 1
                drawRect = New RectangleF(workingRect.Left, currentUsedPos,
                                          workingRect.Width, _tickHeight)
                drawRect.Inflate(-_trackerSize.Width / 2, 0)
                currentUsedPos += _tickHeight

                DrawTickLine(e.Graphics, drawRect, _tickFrequency, _minimum,
                             _maximum, _tickColor, _orientation)
                '==========================================================================
            End If

            If _textTickStyle = TickStyle.BottomRight OrElse _textTickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 2st Text Line.
                '==========================================================================
                ' Get Height of Text Area
                drawRect = New RectangleF(workingRect.Left, currentUsedPos,
                                          workingRect.Width, textAreaSize)
                drawRect.Inflate(-_trackerSize.Width / 2, 0)
                currentUsedPos += textAreaSize

                DrawTickTextLine(e.Graphics, drawRect, _tickFrequency,
                                 _minimum, _maximum, Me.ForeColor, Me.Font, _orientation)
                '==========================================================================
            End If
        Else '_orientation == Orientation.Vertical
            currentUsedPos = _indentWidth
            '==========================================================================

            ' Get Width of Text Area
            textAreaSize = e.Graphics.MeasureString(_maximum.ToString(), Me.Font).Width

            If _textTickStyle = TickStyle.TopLeft OrElse _textTickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 1st Text Line.
                '==========================================================================
                ' Get Height of Text Area
                drawRect = New RectangleF(currentUsedPos, workingRect.Top,
                                          textAreaSize, workingRect.Height)
                drawRect.Inflate(0, -_trackerSize.Width / 2)
                currentUsedPos += textAreaSize

                DrawTickTextLine(e.Graphics, drawRect, _tickFrequency,
                                 _minimum, _maximum, Me.ForeColor, Me.Font, _orientation)
                '==========================================================================
            End If

            If _tickStyle = TickStyle.TopLeft OrElse _tickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 1st Tick Line.
                '==========================================================================
                drawRect = New RectangleF(currentUsedPos, workingRect.Top,
                                          _tickHeight, workingRect.Height)
                drawRect.Inflate(0, -_trackerSize.Width / 2)
                currentUsedPos += _tickHeight + 1

                DrawTickLine(e.Graphics, drawRect, _tickFrequency,
                             _minimum, _maximum, _tickColor, _orientation)
                '==========================================================================
            End If

            '==========================================================================
            ' Caculate the Tracker's rectangle
            '==========================================================================
            Dim currentTrackerPos As Single
            If _maximum = _minimum Then
                currentTrackerPos = workingRect.Top
            Else
                currentTrackerPos = (workingRect.Height - _trackerSize.Width) *
                    (_value - _minimum) / (_maximum - _minimum)
            End If

            _trackerRect = New RectangleF(currentUsedPos,
                                          workingRect.Bottom - currentTrackerPos - _trackerSize.Width,
                                          _trackerSize.Height, _trackerSize.Width) ' Remember this for drawing the Tracker later
            '_trackerRect.Inflate(-1,0);

            rectTemp = _trackerRect 'Testing

            '==========================================================================
            ' Draw the Track Line
            '==========================================================================
            drawRect = New RectangleF(currentUsedPos + _trackerSize.Height / 2 - _trackLineHeight / 2,
                                      workingRect.Top, _trackLineHeight, workingRect.Height)
            DrawTrackLine(e.Graphics, drawRect)
            currentUsedPos += _trackerSize.Height
            '==========================================================================

            If _tickStyle = TickStyle.BottomRight OrElse _tickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 2st Tick Line.
                '==========================================================================
                currentUsedPos += 1
                drawRect = New RectangleF(currentUsedPos, workingRect.Top,
                                          _tickHeight, workingRect.Height)
                drawRect.Inflate(0, -_trackerSize.Width / 2)
                currentUsedPos += _tickHeight

                DrawTickLine(e.Graphics, drawRect, _tickFrequency,
                             _minimum, _maximum, _tickColor, _orientation)
                '==========================================================================
            End If

            If _textTickStyle = TickStyle.BottomRight OrElse _textTickStyle = TickStyle.Both Then
                '==========================================================================
                ' Draw the 2st Text Line.
                '==========================================================================
                ' Get Height of Text Area
                drawRect = New RectangleF(currentUsedPos, workingRect.Top,
                                          textAreaSize, workingRect.Height)
                drawRect.Inflate(0, -_trackerSize.Width / 2)
                currentUsedPos += textAreaSize

                DrawTickTextLine(e.Graphics, drawRect, _tickFrequency,
                                 _minimum, _maximum, Me.ForeColor, Me.Font, _orientation)
                '==========================================================================
            End If
        End If

        '==========================================================================
        ' Check for special values of Max, Min & Value
        If _maximum = _minimum Then
            ' Draw border only and exit;
            DrawBorder(e.Graphics)
            Return
        End If
        '==========================================================================

        '==========================================================================
        ' Draw the Tracker
        '==========================================================================
        DrawTracker(e.Graphics, _trackerRect)
        '==========================================================================

        ' Draw border
        DrawBorder(e.Graphics)
        '==========================================================================

        ' Draws a focus rectangle
        'if(this.Focused && this.BackColor != Color.Transparent)
        If Me.Focused Then
            ControlPaint.DrawFocusRectangle(e.Graphics, Rectangle.Inflate(Me.ClientRectangle, -2, -2))
        End If
        '==========================================================================
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="drawRect"></param>
    Private Sub DrawTrackLine(ByVal g As Graphics, ByVal drawRect As RectangleF)
        KzDrawStyleHelper.DrawAquaPillSingleLayer(g, drawRect, _trackLineColor, _orientation)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="trackerRect_Renamed"></param>
    Private Sub DrawTracker(ByVal g As Graphics, ByVal trackerRect_Renamed As RectangleF)
        'INSTANT VB NOTE: The parameter trackerRect was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        KzDrawStyleHelper.DrawAquaPill(g, trackerRect_Renamed, _trackerColor, _orientation)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="drawRect"></param>
    ''' <param name="tickFrequency_Renamed"></param>
    ''' <param name="minimum_Renamed"></param>
    ''' <param name="maximum_Renamed"></param>
    ''' <param name="foreColor"></param>
    ''' <param name="font"></param>
    ''' <param name="orientation_Renamed"></param>
    Private Sub DrawTickTextLine _
        (ByVal g As Graphics, ByVal drawRect As RectangleF,
         ByVal tickFrequency_Renamed As Integer, ByVal minimum_Renamed As Integer,
         ByVal maximum_Renamed As Integer, ByVal foreColor As Color,
         ByVal font As Font, ByVal orientation_Renamed As Orientation)
        'INSTANT VB NOTE: The parameter tickFrequency was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter minimum was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter maximum was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter orientation was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:

        'Check input value
        If maximum_Renamed = minimum_Renamed Then
            Return
        End If

        'Caculate tick number
        Dim tickCount As Integer = CInt(Fix((maximum_Renamed - minimum_Renamed) / tickFrequency_Renamed))
        If (maximum_Renamed - minimum_Renamed) Mod tickFrequency_Renamed = 0 Then
            tickCount -= 1
        End If

        'Prepare for drawing Text
        '===============================================================
        Dim stringFormat As StringFormat
        stringFormat = New StringFormat
        stringFormat.FormatFlags = StringFormatFlags.NoWrap
        stringFormat.LineAlignment = StringAlignment.Center
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.Trimming = StringTrimming.EllipsisCharacter
        stringFormat.HotkeyPrefix = HotkeyPrefix.Show

        Dim brush As Brush = New SolidBrush(foreColor)
        Dim text As String
        Dim tickFrequencySize As Single
        '===============================================================

        If _orientation = Orientation.Horizontal Then
            ' Calculate tick's setting
            tickFrequencySize = drawRect.Width * tickFrequency_Renamed / (maximum_Renamed - minimum_Renamed)

            '===============================================================

            ' Draw each tick text
            Dim i As Integer = 0
            Do While i <= tickCount
                text = Convert.ToString(_minimum + tickFrequency_Renamed * i, 10)
                g.DrawString(text, font, brush, drawRect.Left + tickFrequencySize * i,
                             drawRect.Top + drawRect.Height / 2, stringFormat)

                i += 1
            Loop
            ' Draw last tick text at Maximum
            text = Convert.ToString(_maximum, 10)
            g.DrawString(text, font, brush, drawRect.Right,
                         drawRect.Top + drawRect.Height / 2, stringFormat)

            '===============================================================
        Else 'Orientation.Vertical
            ' Calculate tick's setting
            tickFrequencySize = drawRect.Height * tickFrequency_Renamed / (maximum_Renamed - minimum_Renamed)
            '===============================================================

            ' Draw each tick text
            Dim i As Integer = 0
            Do While i <= tickCount
                text = Convert.ToString(_minimum + tickFrequency_Renamed * i, 10)
                g.DrawString(text, font, brush, drawRect.Left + drawRect.Width / 2,
                             drawRect.Bottom - tickFrequencySize * i, stringFormat)
                i += 1
            Loop
            ' Draw last tick text at Maximum
            text = Convert.ToString(_maximum, 10)
            g.DrawString(text, font, brush, drawRect.Left + drawRect.Width / 2,
                         drawRect.Top, stringFormat)
            '===============================================================

        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="drawRect"></param>
    ''' <param name="tickFrequency_Renamed"></param>
    ''' <param name="minimum_Renamed"></param>
    ''' <param name="maximum_Renamed"></param>
    ''' <param name="tickColor_Renamed"></param>
    ''' <param name="orientation_Renamed"></param>
    Private Sub DrawTickLine _
        (ByVal g As Graphics, ByVal drawRect As RectangleF, ByVal tickFrequency_Renamed As Integer,
         ByVal minimum_Renamed As Integer, ByVal maximum_Renamed As Integer,
         ByVal tickColor_Renamed As Color, ByVal orientation_Renamed As Orientation)
        'INSTANT VB NOTE: The parameter tickFrequency was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter minimum was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter maximum was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter tickColor was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        'INSTANT VB NOTE: The parameter orientation was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:

        'Check input value
        If maximum_Renamed = minimum_Renamed Then
            Return
        End If

        'Create the Pen for drawing Ticks
        Dim pen As Pen = New Pen(tickColor_Renamed, 1)
        Dim tickFrequencySize As Single

        'Caculate tick number
        Dim tickCount As Integer = CInt(Fix((maximum_Renamed - minimum_Renamed) / tickFrequency_Renamed))
        If (maximum_Renamed - minimum_Renamed) Mod tickFrequency_Renamed = 0 Then
            tickCount -= 1
        End If

        If _orientation = Orientation.Horizontal Then
            ' Calculate tick's setting
            tickFrequencySize = drawRect.Width * tickFrequency_Renamed / (maximum_Renamed - minimum_Renamed)

            '===============================================================

            ' Draw each tick
            Dim i As Integer = 0
            Do While i <= tickCount
                g.DrawLine(pen, drawRect.Left + tickFrequencySize * i, drawRect.Top,
                           drawRect.Left + tickFrequencySize * i, drawRect.Bottom)
                i += 1
            Loop
            ' Draw last tick at Maximum
            g.DrawLine(pen, drawRect.Right, drawRect.Top, drawRect.Right, drawRect.Bottom)
            '===============================================================
        Else 'Orientation.Vertical
            ' Calculate tick's setting
            tickFrequencySize = drawRect.Height * tickFrequency_Renamed / (maximum_Renamed - minimum_Renamed)
            '===============================================================

            ' Draw each tick
            Dim i As Integer = 0
            Do While i <= tickCount
                g.DrawLine(pen, drawRect.Left, drawRect.Bottom - tickFrequencySize * i,
                           drawRect.Right, drawRect.Bottom - tickFrequencySize * i)
                i += 1
            Loop
            ' Draw last tick at Maximum
            g.DrawLine(pen, drawRect.Left, drawRect.Top, drawRect.Right, drawRect.Top)
            '===============================================================
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    Private Sub DrawBorder(ByVal g As Graphics)

        Select Case _borderStyle
            Case KzBorderStyle.Dashed 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, Me.ClientRectangle, _borderColor, ButtonBorderStyle.Dashed)
            Case KzBorderStyle.Dotted 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, Me.ClientRectangle, _borderColor, ButtonBorderStyle.Dotted)
            Case KzBorderStyle.Inset 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, Me.ClientRectangle, _borderColor, ButtonBorderStyle.Inset)
            Case KzBorderStyle.Outset 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, Me.ClientRectangle, _borderColor, ButtonBorderStyle.Outset)
            Case KzBorderStyle.Solid 'from ButtonBorderStyle Enumeration
                ControlPaint.DrawBorder(g, Me.ClientRectangle, _borderColor, ButtonBorderStyle.Solid)

            Case KzBorderStyle.Adjust 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.Adjust)
            Case KzBorderStyle.Bump 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.Bump)
            Case KzBorderStyle.Etched 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.Etched)
            Case KzBorderStyle.Flat 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.Flat)
            Case KzBorderStyle.Raised 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.Raised)
            Case KzBorderStyle.RaisedInner 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.RaisedInner)
            Case KzBorderStyle.RaisedOuter 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.RaisedOuter)
            Case KzBorderStyle.Sunken 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.Sunken)
            Case KzBorderStyle.SunkenInner 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.SunkenInner)
            Case KzBorderStyle.SunkenOuter 'from Border3DStyle Enumeration
                ControlPaint.DrawBorder3D(g, Me.ClientRectangle, Border3DStyle.SunkenOuter)
            Case Else
        End Select
    End Sub


#End Region

#Region "Private Methods"

    Private Sub OnMouseDownSlider(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim offsetValue As Integer = 0
        Dim oldValue As Integer = 0
        Dim currentPoint As PointF

        currentPoint = New PointF(e.X, e.Y)
        If _trackerRect.Contains(currentPoint) Then
            If (Not leftButtonDown) Then
                leftButtonDown = True
                Me.Capture = True
                Select Case Me._orientation
                    Case Orientation.Horizontal
                        mouseStartPos = currentPoint.X - _trackerRect.X

                    Case Orientation.Vertical
                        mouseStartPos = currentPoint.Y - _trackerRect.Y
                End Select
            End If
        Else
            Select Case Me._orientation
                Case Orientation.Horizontal
                    If currentPoint.X + _trackerSize.Width / 2 >= Me.Width - _indentWidth Then
                        offsetValue = _maximum - _minimum
                    ElseIf currentPoint.X - _trackerSize.Width / 2 <= _indentWidth Then
                        offsetValue = 0
                    Else
                        offsetValue = CInt(Fix(((currentPoint.X - _indentWidth - _trackerSize.Width / 2) *
                                        (_maximum - _minimum)) / (Me.Width - 2 * _indentWidth - _trackerSize.Width) + 0.5))
                    End If


                Case Orientation.Vertical
                    If currentPoint.Y + _trackerSize.Width / 2 >= Me.Height - _indentHeight Then
                        offsetValue = 0
                    ElseIf currentPoint.Y - _trackerSize.Width / 2 <= _indentHeight Then
                        offsetValue = _maximum - _minimum
                    Else
                        offsetValue = CInt(Fix(((Me.Height - currentPoint.Y - _indentHeight - _trackerSize.Width / 2) *
                                        (_maximum - _minimum)) / (Me.Height - 2 * _indentHeight - _trackerSize.Width) + 0.5))
                    End If


                Case Else
            End Select

            oldValue = _value
            _value = _minimum + offsetValue
            Me.Invalidate()

            If oldValue <> _value Then
                OnScroll()
                OnValueChanged(_value)
            End If
        End If

    End Sub

    Private Sub OnMouseUpSlider(ByVal sender As Object, ByVal e As MouseEventArgs)
        leftButtonDown = False
        Me.Capture = False

    End Sub


    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        If Me._autoSize Then
            ' Calculate the Position for children controls
            If _orientation = Orientation.Horizontal Then
                Me.Height = FitSize.Height
            Else
                Me.Width = FitSize.Width
            End If
            '=================================================
        End If
    End Sub

    Private Sub OnMouseMoveSlider(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim offsetValue As Integer = 0
        Dim oldValue As Integer = 0
        Dim currentPoint As PointF

        currentPoint = New PointF(e.X, e.Y)

        If leftButtonDown Then
            Try
                Select Case Me._orientation
                    Case Orientation.Horizontal
                        If (currentPoint.X + _trackerSize.Width - mouseStartPos) >= Me.Width - _indentWidth Then
                            offsetValue = _maximum - _minimum
                        ElseIf currentPoint.X - mouseStartPos <= _indentWidth Then
                            offsetValue = 0
                        Else
                            offsetValue = CInt(Fix(((currentPoint.X - mouseStartPos - _indentWidth) *
                                            (_maximum - _minimum)) / (Me.Width - 2 * _indentWidth - _trackerSize.Width) + 0.5))
                        End If


                    Case Orientation.Vertical
                        If currentPoint.Y + _trackerSize.Width / 2 >= Me.Height - _indentHeight Then
                            offsetValue = 0
                        ElseIf currentPoint.Y + _trackerSize.Width / 2 <= _indentHeight Then
                            offsetValue = _maximum - _minimum
                        Else
                            offsetValue = CInt(Fix(((Me.Height - currentPoint.Y + _trackerSize.Width / 2 - mouseStartPos - _indentHeight) *
                                                (_maximum - _minimum)) / (Me.Height - 2 * _indentHeight) + 0.5))
                        End If

                End Select

            Catch e1 As Exception
            Finally
                oldValue = _value
                Value = _minimum + offsetValue
                Me.Invalidate()

                If oldValue <> _value Then
                    OnScroll()
                    OnValueChanged(_value)
                End If
            End Try
        End If

    End Sub


#End Region

End Class




''' <summary>
''' Summary description for KzDrawStyleHelper.
''' </summary>
Public NotInheritable Class KzDrawStyleHelper
    ''' <summary>
    ''' The contructor 
    ''' </summary>
    Private Sub New()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="drawRectF"></param>
    ''' <param name="drawColor"></param>
    ''' <param name="orientation"></param>
    Public Shared Sub DrawAquaPill _
        (ByVal g As Graphics, ByVal drawRectF As RectangleF,
         ByVal drawColor As Color, ByVal orientation As Orientation)

        Dim color1 As Color
        Dim color2 As Color
        Dim color3 As Color
        Dim color4 As Color
        Dim color5 As Color
        Dim gradientBrush As System.Drawing.Drawing2D.LinearGradientBrush
        Dim colorBlend As System.Drawing.Drawing2D.ColorBlend = New System.Drawing.Drawing2D.ColorBlend()

        color1 = KzColorHelper.OpacityMix _
            (Color.White, KzColorHelper.SoftLightMix(drawColor, Color.Black, 100), 40)
        color2 = KzColorHelper.OpacityMix _
            (Color.White, KzColorHelper.SoftLightMix(drawColor, KzColorHelper.CreateColorFromRGB(64, 64, 64), 100), 20)
        color3 = KzColorHelper.SoftLightMix _
            (drawColor, KzColorHelper.CreateColorFromRGB(128, 128, 128), 100)
        color4 = KzColorHelper.SoftLightMix _
            (drawColor, KzColorHelper.CreateColorFromRGB(192, 192, 192), 100)
        color5 = KzColorHelper.OverlayMix _
            (KzColorHelper.SoftLightMix(drawColor, Color.White, 100), Color.White, 75)

        '			
        colorBlend.Colors = New Color() {color1, color2, color3, color4, color5}
        colorBlend.Positions = New Single() {0, 0.25F, 0.5F, 0.75F, 1}
        If orientation = Orientation.Horizontal Then
            gradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush _
                (New Point(CInt(Fix(drawRectF.Left)), CInt(Fix(drawRectF.Top - 1))),
                 New Point(CInt(Fix(drawRectF.Left)), CInt(Fix(drawRectF.Top)) + CInt(Fix(drawRectF.Height)) + 1),
                 color1, color5)
        Else
            gradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush _
                (New Point(CInt(Fix(drawRectF.Left - 1)), CInt(Fix(drawRectF.Top))),
                 New Point(CInt(Fix(drawRectF.Left)) + CInt(Fix(drawRectF.Width)) + 1, CInt(Fix(drawRectF.Top))),
                 color1, color5)
        End If
        gradientBrush.InterpolationColors = colorBlend
        FillPill(gradientBrush, drawRectF, g)

        '
        color2 = Color.White
        colorBlend.Colors = New Color() {color2, color3, color4, color5}
        colorBlend.Positions = New Single() {0, 0.5F, 0.75F, 1}
        If orientation = Orientation.Horizontal Then
            gradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush _
                (New Point(CInt(Fix(drawRectF.Left)) + 1, CInt(Fix(drawRectF.Top))),
                 New Point(CInt(Fix(drawRectF.Left)) + 1, CInt(Fix(drawRectF.Top)) + CInt(Fix(drawRectF.Height - 1))),
                 color2, color5)
        Else
            gradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush _
                (New Point(CInt(Fix(drawRectF.Left)), CInt(Fix(drawRectF.Top)) + 1),
                 New Point(CInt(Fix(drawRectF.Left)) + CInt(Fix(drawRectF.Width - 1)), CInt(Fix(drawRectF.Top)) + 1),
                 color2, color5)
        End If
        gradientBrush.InterpolationColors = colorBlend
        FillPill(gradientBrush, RectangleF.Inflate(drawRectF, -3, -3), g)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="drawRectF"></param>
    ''' <param name="drawColor"></param>
    ''' <param name="orientation"></param>
    Public Shared Sub DrawAquaPillSingleLayer _
        (ByVal g As Graphics, ByVal drawRectF As RectangleF,
         ByVal drawColor As Color, ByVal orientation As Orientation)

        Dim color1 As Color
        Dim color2 As Color
        Dim color3 As Color
        Dim color4 As Color
        Dim gradientBrush As System.Drawing.Drawing2D.LinearGradientBrush
        Dim colorBlend As System.Drawing.Drawing2D.ColorBlend = New System.Drawing.Drawing2D.ColorBlend()

        color1 = drawColor
        color2 = ControlPaint.Light(color1)
        color3 = ControlPaint.Light(color2)
        color4 = ControlPaint.Light(color3)

        colorBlend.Colors = New Color() {color1, color2, color3, color4}
        colorBlend.Positions = New Single() {0, 0.25F, 0.65F, 1}

        If orientation = Orientation.Horizontal Then
            gradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush _
                (New Point(CInt(Fix(drawRectF.Left)), CInt(Fix(drawRectF.Top))),
                 New Point(CInt(Fix(drawRectF.Left)), CInt(Fix(drawRectF.Top)) + CInt(Fix(drawRectF.Height))),
                 color1, color4)
        Else
            gradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush _
                (New Point(CInt(Fix(drawRectF.Left)), CInt(Fix(drawRectF.Top))),
                 New Point(CInt(Fix(drawRectF.Left)) + CInt(Fix(drawRectF.Width)), CInt(Fix(drawRectF.Top))),
                 color1, color4)
        End If
        gradientBrush.InterpolationColors = colorBlend

        FillPill(gradientBrush, drawRectF, g)

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="b"></param>
    ''' <param name="rect"></param>
    ''' <param name="g"></param>
    Public Shared Sub FillPill _
        (ByVal b As Brush, ByVal rect As RectangleF, ByVal g As Graphics)

        If rect.Width > rect.Height Then
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillEllipse(b, New RectangleF _
                          (rect.Left, rect.Top, rect.Height, rect.Height))
            g.FillEllipse(b, New RectangleF _
                          (rect.Left + rect.Width - rect.Height, rect.Top, rect.Height, rect.Height))

            Dim w As Single = rect.Width - rect.Height
            Dim l As Single = rect.Left + ((rect.Height) / 2)
            g.FillRectangle(b, New RectangleF(l, rect.Top, w, rect.Height))
            g.SmoothingMode = SmoothingMode.Default
        ElseIf rect.Width < rect.Height Then
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillEllipse(b, New RectangleF _
                          (rect.Left, rect.Top, rect.Width, rect.Width))
            g.FillEllipse(b, New RectangleF _
                          (rect.Left, rect.Top + rect.Height - rect.Width, rect.Width, rect.Width))

            Dim t As Single = rect.Top + (rect.Width / 2)
            Dim h As Single = rect.Height - rect.Width
            g.FillRectangle(b, New RectangleF(rect.Left, t, rect.Width, h))
            g.SmoothingMode = SmoothingMode.Default
        ElseIf rect.Width = rect.Height Then
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillEllipse(b, rect)
            g.SmoothingMode = SmoothingMode.Default
        End If
    End Sub

End Class

