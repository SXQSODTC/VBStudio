Public Class KzAppearancePanel
    Dim fSizes() As Single = {
        5, 5.5, 6.5, 7.5, 8, 9, 10, 10.5, 11, 12,
        14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72}

    Dim iApr As KzAppearance

    Public Sub New()

        InitializeComponent()

        Dim i, ub As Integer

        With ShadowDirectionCB
            ub = [Enum].GetNames(GetType(KzSidePosition)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzSidePosition))
            Next
        End With

        With FontStyleCB
            ub = [Enum].GetNames(GetType(FontStyle)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, FontStyle))
            Next
            .DropDownWidth = 160
            .SelectedIndex = 0
        End With

        With FontSizeCB
            For i = 0 To fSizes.GetUpperBound(0)
                .Items.Add(fSizes(i))
            Next
            .SelectedIndex = 7
        End With

        Me.Appearance = New KzAppearance
    End Sub

    Public Property Appearance As KzAppearance
        Get
            GetAppearanceFromUI()
            Return iApr
        End Get
        Set(value As KzAppearance)
            iApr = value
            SetAppearanceToUI()
        End Set
    End Property

    Private Sub SetAppearanceToUI()
        If iApr Is Nothing Then
            iApr = New KzAppearance
        End If

        With iApr
            NameTB.Text = .Name
            BorderSizeUD.Value = .BorderSize
            BorderColorTB.Text = GetColorName(.BorderColor)
            BorderRadiusUD.Value = .BorderRadius
            BackColorTB.Text = GetColorName(.BackColor)
            LineSizeUD.Value = .LineSize
            ForeColorTB.Text = GetColorName(.ForeColor)
            ShadowWidthUD.Value = .ShadowWidth
            ShadowDirectionCB.SelectedItem = .ShadowDirection
            ShadowColorTB.Text = GetColorName(.ShadowColor)
            FontSizeCB.SelectedItem = .FontSize
            FontStyleCB.SelectedItem = .FontStyle
        End With
    End Sub

    Private Sub GetAppearanceFromUI()
        If iApr Is Nothing Then
            iApr = New KzAppearance
        End If

        With iApr
            .Name = NameTB.Text
            .BorderSize = BorderSizeUD.Value
            .BorderColor = GetColor(BorderColorTB.Text)
            .BorderRadius = BorderRadiusUD.Value
            .BackColor = GetColor(BackColorTB.Text)
            .LineSize = LineSizeUD.Value
            .ForeColor = GetColor(ForeColorTB.Text)
            .ShadowWidth = ShadowWidthUD.Value
            .ShadowDirection = ShadowDirectionCB.SelectedItem
            .ShadowColor = GetColor(ShadowColorTB.Text)
            .FontSize = FontSizeCB.SelectedItem
            .FontStyle = FontSizeCB.SelectedItem
        End With
    End Sub

    Private Function GetColorName(color As Color) As String
        If color.IsEmpty Then
            Return "[Empty]"
        ElseIf color.IsNamedColor Then
            Return color.Name
        Else
            Return ("&H" & Hex(color.ToArgb)).ToUpper
        End If
    End Function

    Private Function GetColor(name As String) As Color
        Try
            If name.StartsWith("&H") Then
                Return Color.FromArgb(name)
            Else
                Return Color.FromName(name)
            End If
        Catch ex As Exception
            Return Color.FromArgb(0)
        End Try
    End Function

    Private Function GetCode _
        (Optional useWithSentance As Boolean = False,
         Optional tabWidth As Integer = 4) As String

        Dim sb As New System.Text.StringBuilder
        Dim tab As String = Strings.StrDup(tabWidth, " ")

        If useWithSentance Then
            sb.AppendLine("Dim " & NameTB.Text & " As New KzDrawingStyle")
            sb.AppendLine("With " & NameTB.Text)
        Else
            sb.AppendLine("Dim " & NameTB.Text & " As New KzDrawingStyle With {")
        End If
        sb.AppendLine(tab & ".BorderSize = " & BorderSizeUD.Value)
        sb.AppendLine(tab & ".BorderColor = Color." & BorderColorTB.Text)
        sb.AppendLine(tab & ".Radius = " & BorderRadiusUD.Value)
        sb.AppendLine(tab & ".LineWidth = " & LineSizeUD.Value)
        sb.AppendLine(tab & ".LineColor = Color." & ForeColorTB.Text)
        sb.AppendLine(tab & ".FillColor = Color." & BackColorTB.Text)
        sb.AppendLine(tab & ".ShadowWidth = " & ShadowWidthUD.Value)
        sb.AppendLine(tab & ".ShadowColor = Color." & ShadowColorTB.Text)
        sb.AppendLine(tab & ".FontSize = " & FontSizeCB.SelectedItem)

        Dim s As String = ""
        If FontStyleCB.Text.Contains(",") Then
            Dim ss As String() = FontStyleCB.Text.Split(",")
            For i = 0 To ss.GetUpperBound(0)
                If i = 0 Then
                    s = "FontStyle." & ss(i).Trim
                Else
                    s = s & " And " & "FontStyle." & ss(i).Trim
                End If
            Next
        Else
            s = "FontStyle." & FontStyleCB.Text
        End If

        sb.AppendLine(tab & ".FontStyle = " & s)

        If useWithSentance Then
            sb.AppendLine("End With")
        Else
            sb.AppendLine("}")
        End If

        Return sb.ToString
    End Function

    Private Sub ItemChanged(sender As Object, e As EventArgs) Handles _
      NameTB.TextChanged, BorderSizeUD.ValueChanged, BorderColorTB.TextChanged,
      BorderRadiusUD.ValueChanged, LineSizeUD.ValueChanged, BackColorTB.TextChanged,
      ShadowWidthUD.ValueChanged, ShadowColorTB.TextChanged, ForeColorTB.TextChanged,
      FontSizeCB.SelectedIndexChanged, FontStyleCB.SelectedIndexChanged

        'If NeedUpdateCode Then
        '    GetAppearanceFromUI()
        '    NeedUpdateCode = False
        'End If

        'CodeTextBox.Text = GetCode()
    End Sub

    Private Sub TBActivated(sender As Object, e As EventArgs) Handles _
        BorderColorTB.GotFocus, BorderColorTB.Click, ForeColorTB.GotFocus, ForeColorTB.Click,
        BackColorTB.GotFocus, BackColorTB.Click, ShadowColorTB.GotFocus, ShadowColorTB.Click

        CType(sender, TextBox).SelectAll()

        RaiseEvent ColorBoxActivated(sender, e)
    End Sub

    Public Event ColorBoxActivated(sender As Object, e As EventArgs)
End Class
