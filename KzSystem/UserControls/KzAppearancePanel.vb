Public Class KzAppearancePanel
    Dim fSizes() As Single = {
        5, 5.5, 6.5, 7.5, 8, 9, 10, 10.5, 11, 12,
        14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72}

    Dim iApr As KzAppearance
    Dim iWith, iFull As Boolean

    Public Sub New()

        InitializeComponent()

        Dim i, ub As Integer

        With ShadowDirectionCB
            ub = [Enum].GetNames(GetType(KzFlatSides)).Count - 1
            For i = 0 To ub
                .Items.Add(CType(i, KzFlatSides))
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
        iWith = False
        iFull = False

        With RootPanel
            For Each c As Control In .Controls
                If c.GetType = GetType(Label) Then
                    c.Font = .Font
                End If
            Next
        End With
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
            If FontSizeCB.Items.Contains(.FontSize) Then
                FontSizeCB.SelectedItem = .FontSize
            Else
                FontSizeCB.Text = .FontSize
            End If
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
            .FontSize = FontSizeCB.Text
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

    Public Property TabWidth As Integer = 4

    Public ReadOnly Property Code() As String
        Get
            Dim sb As New System.Text.StringBuilder
            Dim leadWord As String

            If iFull Then
                sb.Append("Dim " & NameTB.Text & " As New KzDrawingStyle")
                leadWord = NameTB.Text
            Else
                If iWith Then
                    sb.AppendLine("Dim " & NameTB.Text & " As New KzDrawingStyle")
                    sb.AppendLine("With " & NameTB.Text)
                Else
                    sb.AppendLine("Dim " & NameTB.Text & " As New KzDrawingStyle With {")
                End If
                leadWord = Strings.StrDup(Me.TabWidth, " ")
            End If

            sb.AppendLine(leadWord & ".BorderSize = " & BorderSizeUD.Value)
            sb.AppendLine(leadWord & ".BorderColor = Color." & BorderColorTB.Text)
            sb.AppendLine(leadWord & ".Radius = " & BorderRadiusUD.Value)
            sb.AppendLine(leadWord & ".LineWidth = " & LineSizeUD.Value)
            sb.AppendLine(leadWord & ".LineColor = Color." & ForeColorTB.Text)
            sb.AppendLine(leadWord & ".FillColor = Color." & BackColorTB.Text)
            sb.AppendLine(leadWord & ".ShadowWidth = " & ShadowWidthUD.Value)
            sb.AppendLine(leadWord & ".ShadowColor = Color." & ShadowColorTB.Text)
            sb.AppendLine(leadWord & ".FontSize = " & FontSizeCB.Text)

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

            sb.AppendLine(leadWord & ".FontStyle = " & s)

            If Not iFull Then
                If iWith Then
                    sb.AppendLine("End With")
                Else
                    sb.AppendLine("}")
                End If
            End If

            Return sb.ToString
        End Get
    End Property

    Public Function GetCode _
        (Optional iWith As Boolean = False,
         Optional useFullSentance As Boolean = False,
         Optional tabWidth As Integer = 4) As String

        Dim sb As New System.Text.StringBuilder
        Dim leadWord As String

        If useFullSentance Then
            sb.Append("Dim " & NameTB.Text & " As New KzDrawingStyle")
            leadWord = NameTB.Text
        Else
            If iWith Then
                sb.AppendLine("Dim " & NameTB.Text & " As New KzDrawingStyle")
                sb.AppendLine("With " & NameTB.Text)
            Else
                sb.AppendLine("Dim " & NameTB.Text & " As New KzDrawingStyle With {")
            End If
            leadWord = Strings.StrDup(tabWidth, " ")
        End If

        sb.AppendLine(leadWord & ".BorderSize = " & BorderSizeUD.Value)
        sb.AppendLine(leadWord & ".BorderColor = Color." & BorderColorTB.Text)
        sb.AppendLine(leadWord & ".Radius = " & BorderRadiusUD.Value)
        sb.AppendLine(leadWord & ".LineWidth = " & LineSizeUD.Value)
        sb.AppendLine(leadWord & ".LineColor = Color." & ForeColorTB.Text)
        sb.AppendLine(leadWord & ".FillColor = Color." & BackColorTB.Text)
        sb.AppendLine(leadWord & ".ShadowWidth = " & ShadowWidthUD.Value)
        sb.AppendLine(leadWord & ".ShadowColor = Color." & ShadowColorTB.Text)
        sb.AppendLine(leadWord & ".FontSize = " & FontSizeCB.Text)

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

        sb.AppendLine(leadWord & ".FontStyle = " & s)

        If iWith Then
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
      FontSizeCB.SelectedIndexChanged, FontSizeCB.TextChanged, FontStyleCB.SelectedIndexChanged

        With RootPanel
            Dim cp As TableLayoutPanelCellPosition = .GetCellPosition(sender)
            Dim lb As Label = CType(.GetControlFromPosition(cp.Column - 1, cp.Row), Label)
            lb.Font = New Font(.Font.FontFamily, .Font.Size, FontStyle.Bold)
        End With
    End Sub

    Private Sub TBActivated(sender As Object, e As EventArgs) Handles _
        BorderColorTB.GotFocus, BorderColorTB.Click, ForeColorTB.GotFocus, ForeColorTB.Click,
        BackColorTB.GotFocus, BackColorTB.Click, ShadowColorTB.GotFocus, ShadowColorTB.Click

        CType(sender, TextBox).SelectAll()

        RaiseEvent ColorBoxActivated(sender, e)
    End Sub

    Public Event ColorBoxActivated(sender As Object, e As EventArgs)

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        iApr = New KzAppearance
        SetAppearanceToUI()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        GetAppearanceFromUI()
        With RootPanel
            For Each c As Control In .Controls
                If c.GetType = GetType(Label) Then
                    c.Font = .Font
                End If
            Next
        End With
    End Sub

    Private Sub FullButton_Click(sender As Object, e As EventArgs) Handles FullButton.CheckedChanged
        iFull = FullButton.Checked
    End Sub

    Private Sub WithButton_Click(sender As Object, e As EventArgs) Handles WithButton.CheckedChanged
        iWith = WithButton.Checked
    End Sub

    Private Sub CodeButton_Click(sender As Object, e As EventArgs) Handles CodeButton.Click
        MsgBox(NameTB.Text.Length)

        If Not NameTB.Text.Trim.Length = 0 Then
            Dim td As New KzTextViewDialog
            td.TextContents = Me.Code

            Dim s As String
            If FullButton.Checked Then
                s = "Full sentance."
            Else
                If WithButton.Checked Then
                    s = "'With' sentance."
                Else
                    s = "direct Dim."
                End If
            End If
            td.InfoText = "KzAppearance " & NameTB.Text & " code by " & s
            td.ShowDialog()
        Else
            MsgBox("Please fill the Name of KzAppearance.")
        End If
    End Sub

End Class
