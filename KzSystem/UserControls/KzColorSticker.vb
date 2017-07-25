Public Class KzColorSticker
    Implements IComparable

    Private iSelected As Boolean
    Private iShown As KzColorProperties

    Public Sub New(ByVal TheColor As Color)

        InitializeComponent()

        Me.Name = TheColor.Name
        Me.ColorLabel.BackColor = TheColor
        Me.NameLabel.Text = TheColor.Name
        Me.PropertyLabel.Text = " &H" & Hex(TheColor.ToArgb)
        Me.ClassifyLabel.Text = GetColorClassify(TheColor)

        Me.ShownProperty = KzColorProperties.HexARGB
        SetAppearance(KzActionStatus.Normal)

        iSelected = False

    End Sub

    Private Function GetColorClassify(ByVal TheColor As Color) As String
        If TheColor.IsSystemColor And TheColor.IsNamedColor Then
            Return "Ks"
        ElseIf TheColor.IsKnownColor And TheColor.IsNamedColor Then
            Return "Kw"
        ElseIf TheColor.IsSystemColor Then
            Return "Cs"
        ElseIf TheColor.IsKnownColor Then
            Return "Cw"
        Else
            Return "X"
        End If
    End Function

    Public Property ShownProperty As KzColorProperties
        Get
            Return iShown
        End Get
        Set(value As KzColorProperties)
            iShown = value
            Dim c As Color = Me.ColorLabel.BackColor
            Select Case iShown
                Case KzColorProperties.HexARGB
                    Me.PropertyLabel.Text = " &H" & Hex(c.ToArgb)
                Case KzColorProperties.IntARGB
                    Me.PropertyLabel.Text = " " & c.ToArgb
                Case KzColorProperties.ARGB
                    Me.PropertyLabel.Text = "ARGB(" & c.A & ", " & c.R & ", " & c.G & ", " & c.B & ")"
                Case KzColorProperties.HSB
                    Me.PropertyLabel.Text = "HSB(" &
                        Strings.Format(c.GetHue, "Scientific") & ", " &
                        Strings.Format(c.GetSaturation, "Scientific") & ", " &
                        Strings.Format(c.GetBrightness, "Scientific") & ")"
                Case Else
                    Me.PropertyLabel.Text = Nothing
            End Select
        End Set
    End Property

    Public Property Checked As Boolean = False

    Public Property Selected As Boolean
        Get
            Return iSelected
        End Get
        Set(value As Boolean)
            iSelected = value
            If iSelected Then
                SetAppearance(KzActionStatus.Pressed)
            Else
                If Me.Checked Then
                    SetAppearance(KzActionStatus.Checked)
                Else
                    SetAppearance(KzActionStatus.Normal)
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)

        Me.NameLabel.Width = Me.NameLabel.Parent.Width * 2
        Me.PropertyLabel.Width = Me.PropertyLabel.Parent.Width * 5
    End Sub

    Private Sub Checker_CheckedChanged(sender As Object, e As EventArgs) Handles Checker.CheckedChanged
        Me.Checked = Me.Checker.Checked
        SetAppearance(KzActionStatus.Checked)
        RaiseEvent CheckedStatusChanged(Me, e)
    End Sub

    Private Sub PanelMouseMoving(sender As Object, e As MouseEventArgs) Handles _
        RootPanel.MouseMove, NameLabel.MouseMove, PropertyLabel.MouseMove,
        ColorLabel.MouseMove, Checker.MouseMove, ClassifyLabel.MouseMove

        If iSelected Then
            SetAppearance(KzActionStatus.Pressed)
        Else
            SetAppearance(KzActionStatus.Hover)
        End If

    End Sub

    Private Sub PanelMouseLeave(sender As Object, e As EventArgs) Handles _
        RootPanel.MouseLeave, NameLabel.MouseLeave, PropertyLabel.MouseLeave, ColorLabel.MouseLeave

        If iSelected Then
            SetAppearance(KzActionStatus.Pressed)
        Else
            If Me.Checked Then
                SetAppearance(KzActionStatus.Checked)
            Else
                SetAppearance(KzActionStatus.Normal)
            End If
        End If
    End Sub

    Private Sub PanelMouseDown(sender As Object, e As MouseEventArgs) Handles _
        RootPanel.MouseDown, NameLabel.MouseDown, PropertyLabel.MouseDown, ColorLabel.MouseDown

        If Not iSelected Then
            iSelected = True
            SetAppearance(KzActionStatus.Pressed)
            RaiseEvent SelectedStatusChanged(Me, e)
        End If
    End Sub

    Private Sub PanelMouseDoubleClick(sender As Object, e As MouseEventArgs) Handles _
        RootPanel.MouseDoubleClick, NameLabel.DoubleClick, PropertyLabel.DoubleClick, ColorLabel.DoubleClick

        If iSelected Then
            iSelected = False
            SetAppearance(KzActionStatus.Hover)
            RaiseEvent SelectedStatusChanged(Me, e)
        End If
    End Sub

    Public Event CheckedStatusChanged(sender As Object, e As EventArgs)
    Public Event SelectedStatusChanged(sender As Object, e As EventArgs)

    Private Sub SetAppearance(ByVal theStatus As KzActionStatus)
        Select Case theStatus
            Case KzActionStatus.Normal
                Me.RootPanel.BackColor = Color.WhiteSmoke
                Me.ColorLabel.Margin = New Padding(0)
                Me.NameLabel.ForeColor = Color.Black
                Me.NameLabel.Font = New Font("Consolas", 9, FontStyle.Regular)
                Me.PropertyLabel.ForeColor = Color.DimGray
                Me.PropertyLabel.Font = New Font("Consolas", 9, FontStyle.Regular)
                Me.ClassifyLabel.ForeColor = Color.DimGray
                Me.ClassifyLabel.Font = New Font("Consolas", 7.5, FontStyle.Regular)
                Me.BorderStyle = BorderStyle.None
            Case KzActionStatus.Hover
                Me.RootPanel.BackColor = Color.LightGray
                Me.ColorLabel.Margin = New Padding(1)
                Me.NameLabel.ForeColor = Color.Black
                Me.NameLabel.Font = New Font("Consolas", 9, FontStyle.Bold)
                Me.PropertyLabel.ForeColor = Color.DimGray
                Me.PropertyLabel.Font = New Font("Consolas", 9, FontStyle.Regular)
                Me.ClassifyLabel.ForeColor = Color.DimGray
                Me.ClassifyLabel.Font = New Font("Consolas", 7.5, FontStyle.Regular)
                Me.BorderStyle = BorderStyle.None
            Case KzActionStatus.Pressed
                Me.RootPanel.BackColor = Color.DarkGray
                Me.ColorLabel.Margin = New Padding(0)
                Me.NameLabel.ForeColor = Color.Black
                Me.NameLabel.Font = New Font("Consolas", 9, FontStyle.Bold)
                Me.PropertyLabel.ForeColor = Color.WhiteSmoke
                Me.PropertyLabel.Font = New Font("Consolas", 9, FontStyle.Bold)
                Me.ClassifyLabel.ForeColor = Color.WhiteSmoke
                Me.ClassifyLabel.Font = New Font("Consolas", 7.5, FontStyle.Bold)
                Me.BorderStyle = BorderStyle.Fixed3D
            Case KzActionStatus.Checked
                Me.RootPanel.BackColor = Color.LightGray
                Me.ColorLabel.Margin = New Padding(1)
                Me.NameLabel.ForeColor = Color.Black
                Me.NameLabel.Font = New Font("Consolas", 9, FontStyle.Bold)
                Me.PropertyLabel.ForeColor = Color.DimGray
                Me.PropertyLabel.Font = New Font("Consolas", 9, FontStyle.Regular)
                Me.ClassifyLabel.ForeColor = Color.DimGray
                Me.ClassifyLabel.Font = New Font("Consolas", 7.5, FontStyle.Regular)
                Me.BorderStyle = BorderStyle.FixedSingle
        End Select
    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If obj Is Nothing Then Return 1

        Try
            Dim otherColor As KzColorSticker = CType(obj, KzColorSticker)
            Return Me.Name.CompareTo(otherColor.Name)
        Catch ex As Exception
            Throw New NotImplementedException("Error!")
        End Try
    End Function

    Private Sub RootPanel_SizeChanged(sender As Object, e As EventArgs) Handles RootPanel.SizeChanged
        With RootPanel
            .ColumnStyles(0).Width = Math.Min(Math.Max(.Height, .Width / 3), .Height * 2)
        End With
    End Sub
End Class



'Public Class KzColorListPanel1
'    Inherits FlowLayoutPanel

'    Private iType As KzColorListType
'    Public CheckedStickers As List(Of KzColorSticker)
'    Public SelectedSticker As KzColorSticker

'    Public Sub New()
'        Me.FlowDirection = FlowDirection.TopDown
'        Me.AutoScroll = True
'        Me.BackColor = Color.DarkGray
'        Me.WrapContents = False

'        Me.CheckedStickers = New List(Of KzColorSticker)
'        Me.SelectedSticker = Nothing

'        Me.DefaultListType = KzColorListType.WebColors
'    End Sub

'    Public Property DefaultListType As KzColorListType
'        Get
'            Return iType
'        End Get
'        Set(value As KzColorListType)
'            iType = value
'            Dim c As Color
'            Me.Clear()

'            Select Case iType
'                Case KzColorListType.KnownColors, KzColorListType.SystemColors, KzColorListType.WebColors
'                    Dim colorsArray As System.Array = [Enum].GetValues(GetType(KnownColor))

'                    Me.SuspendLayout()

'                    For i As Integer = 0 To colorsArray.GetUpperBound(0)
'                        c = Color.FromName(colorsArray(i).ToString())

'                        Select Case iType
'                            Case KzColorListType.SystemColors
'                                If c.IsSystemColor Then Me.AddSticker(New KzColorSticker(c))
'                            Case KzColorListType.WebColors
'                                If Not c.IsSystemColor Then Me.AddSticker(New KzColorSticker(c))
'                            Case Else
'                                Me.AddSticker(New KzColorSticker(c))
'                        End Select
'                    Next
'                    Me.ResumeLayout(True)

'                Case KzColorListType.CheckedColors
'                    'Me.Clear()
'                    Me.AddStickerRange(Me.CheckedStickers.ToArray)
'            End Select
'        End Set
'    End Property

'    Public Sub AddSticker(ByVal sticker As KzColorSticker)
'        Me.Controls.Add(sticker)
'    End Sub

'    Public Sub AddStickerRange(ByVal stickers As KzColorSticker())
'        Me.SuspendLayout()
'        Me.Controls.AddRange(stickers)
'        Me.ResumeLayout()
'    End Sub

'    Public Sub RemoveSticker(ByVal sticker As KzColorSticker)
'        Me.Controls.Remove(sticker)
'    End Sub

'    Public Sub RemoveStickerAt(ByVal index As Integer)
'        Me.Controls.RemoveAt(index)
'    End Sub

'    Public Sub RemoveStickerByKey(ByVal key As String)
'        Me.Controls.RemoveByKey(key)
'    End Sub

'    Public Sub Clear()
'        Me.SuspendLayout()
'        Me.Controls.Clear()
'        Me.SuspendLayout()
'    End Sub

'    Protected Overrides Sub OnSizeChanged(e As EventArgs)
'        MyBase.OnSizeChanged(e)

'        Me.SuspendLayout()
'        For Each c As Control In Me.Controls
'            c.Width = Me.ClientRectangle.Width - 5
'        Next
'        Me.ResumeLayout()
'    End Sub
'End Class


Public Class KzColorListPanel
    Inherits FlowLayoutPanel

    Private WithEvents iListForShow As KzColorStickerCollection
    Private iTypeOfDefault As KzColorListType

    Public Sub New()
        Me.FlowDirection = FlowDirection.TopDown
        Me.AutoScroll = True
        Me.BackColor = Color.DarkGray
        Me.WrapContents = False

        'Me.DefaultColorListType = KzColorListType.WebColors
        Me.Stickers = New KzColorStickerCollection
        Me.CheckedStickers = New KzColorStickerCollection 'List(Of KzColorSticker)

        AddHandler Me.Stickers.ItemAdded, AddressOf AddSticker
        AddHandler Me.Stickers.ItemsAdded, AddressOf AddStickers
        AddHandler Me.Stickers.ItemRemoved, AddressOf RemoveSticker
        AddHandler Me.Stickers.ItemsRemoved, AddressOf RemoveStickers

        RaiseEvent SelectedStickerChanged(Nothing, Nothing)
    End Sub

    Private Sub AddSticker(sticker As KzColorSticker)
        Me.Controls.Add(sticker)
    End Sub

    Private Sub AddStickers(stickers As KzColorSticker())
        Me.Controls.AddRange(stickers)
    End Sub

    Private Sub RemoveSticker(sticker As KzColorSticker)
        Me.Controls.Remove(sticker)
    End Sub

    Private Sub RemoveStickers(stickers As KzColorSticker())
        For Each cs As KzColorSticker In stickers
            Me.Controls.Remove(cs)
        Next
    End Sub

    Public Property Stickers As KzColorStickerCollection ' List(Of KzColorSticker)
        Get
            Return iListForShow
        End Get
        Set(value As KzColorStickerCollection)
            iListForShow = value

            If iListForShow.Count > 0 Then
                For Each cs As KzColorSticker In iListForShow
                    cs.Checker.Checked = False
                    AddHandler cs.CheckedStatusChanged, AddressOf SetCheckedStickers
                    AddHandler cs.SelectedStatusChanged, AddressOf SetSelectedSticker
                Next
            End If

            RaiseEvent StickersChanged(Me, Nothing)
            ShowListToPanel()
        End Set
    End Property

    Public Property DefaultColorListType As KzColorListType
        Get
            Return iTypeOfDefault
        End Get
        Set(value As KzColorListType)
            iTypeOfDefault = value
            Me.Stickers = GetIntenalList(iTypeOfDefault)
        End Set
    End Property

    Public CheckedStickers As KzColorStickerCollection ' List(Of KzColorSticker)
    Public SelectedSticker As KzColorSticker

    Private Sub ShowListToPanel()
        Me.SuspendLayout()
        Me.Controls.Clear()
        If iListForShow.Count > 0 Then
            Me.Controls.AddRange(iListForShow.ToArray)
        End If
        Me.ResumeLayout()
    End Sub

    Private Function GetIntenalList _
        (Optional ByVal listType As KzColorListType = KzColorListType.KnownColors) _
        As KzColorStickerCollection

        Dim kcsc As KzColorStickerCollection = New KzColorStickerCollection
        Dim c As Color

        Select Case listType
            Case KzColorListType.KnownColors, KzColorListType.SystemColors, KzColorListType.WebColors
                Dim colorsArray As System.Array = [Enum].GetValues(GetType(KnownColor))

                For i As Integer = 0 To colorsArray.GetUpperBound(0)
                    c = Color.FromName(colorsArray(i).ToString())

                    Select Case listType
                        Case KzColorListType.SystemColors
                            If c.IsSystemColor Then kcsc.Add(New KzColorSticker(c))
                        Case KzColorListType.WebColors
                            If Not c.IsSystemColor Then kcsc.Add(New KzColorSticker(c))
                        Case Else
                            kcsc.Add(New KzColorSticker(c))
                    End Select
                Next

            Case KzColorListType.CheckedColors
                kcsc = Me.CheckedStickers

        End Select

        'If kcsc.Count > 0 Then
        '    For Each cs As KzColorSticker In kcsc
        '        cs.Checker.Checked = False
        '        AddHandler cs.CheckedStatusChanged, AddressOf SetCheckedStickers
        '        AddHandler cs.SelectedStatusChanged, AddressOf SetSelectedSticker
        '    Next
        'End If

        Return kcsc
    End Function

    Private Sub SetCheckedStickers(sender As Object, e As EventArgs)
        Dim kcs As KzColorSticker = CType(sender, KzColorSticker)

        If kcs.Checked Then
            Me.CheckedStickers.Add(kcs)
            RaiseEvent CheckedStickersChanged(Me, e)
        Else
            If Me.CheckedStickers.Contains(kcs) Then
                Me.CheckedStickers.Remove(kcs)
                RaiseEvent CheckedStickersChanged(Me, e)
            End If
        End If
    End Sub

    Private Sub SetSelectedSticker(sender As Object, e As EventArgs)
        Dim kcs As KzColorSticker = CType(sender, KzColorSticker)

        If kcs.Selected Then
            If Me.SelectedSticker IsNot Nothing Then
                If Not Me.SelectedSticker.Equals(kcs) Then
                    Me.SelectedSticker.Selected = False
                    Me.SelectedSticker = kcs
                    RaiseEvent SelectedStickerChanged(Me, e)
                End If
            Else
                Me.SelectedSticker = kcs
                RaiseEvent SelectedStickerChanged(Me, e)
            End If
        End If
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)

        Me.SuspendLayout()
        For Each c As Control In Me.Controls
            c.Width = Me.ClientRectangle.Width - 5
        Next
        Me.ResumeLayout()
    End Sub

    Public Event CheckedStickersChanged(sender As Object, e As EventArgs)
    Public Event SelectedStickerChanged(sender As Object, e As EventArgs)
    Public Event StickersChanged(sender As Object, e As EventArgs)
End Class



Public Class KzColorStickerCollection
    Inherits List(Of KzColorSticker)

    Public Sub New()

    End Sub

    Public Shadows Sub Add(sticker As KzColorSticker)
        MyBase.Add(sticker)
        RaiseEvent ItemAdded(sticker)
    End Sub

    Public Shadows Sub AddRange(stickers As KzColorSticker())
        MyBase.AddRange(stickers)
        RaiseEvent ItemsAdded(stickers)
    End Sub

    Public Shadows Sub Remove(sticker As KzColorSticker)
        Dim cs As KzColorSticker = sticker
        MyBase.Remove(sticker)
        RaiseEvent ItemRemoved(cs)
    End Sub

    Public Shadows Sub RemoveAt(index As Integer)
        Dim cs As KzColorSticker = Me.Item(index)
        MyBase.RemoveAt(index)
        RaiseEvent ItemRemoved(cs)
    End Sub

    Public Shadows Sub RemoveRange(index As Integer, count As Integer)
        Dim css(count - 1) As KzColorSticker
        Me.CopyTo(index, css, 0, count)
        MyBase.RemoveRange(index, count)
        RaiseEvent ItemsRemoved(css)
    End Sub

    Public Event ItemAdded(sticker As KzColorSticker)
    Public Event ItemsAdded(stickers As KzColorSticker())
    Public Event ItemRemoved(sticker As KzColorSticker)
    Public Event ItemsRemoved(stickers As KzColorSticker())
End Class

Public Enum KzColorProperties
    None
    ARGB
    IntARGB
    HexARGB
    HSB
End Enum

Public Enum KzColorListType
    None
    KnownColors
    SystemColors
    WebColors
    CustomColors
    CheckedColors
    KzColors
End Enum
