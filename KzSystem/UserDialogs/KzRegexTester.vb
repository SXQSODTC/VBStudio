Imports System.Text
Imports System.Text.RegularExpressions

Public Class KzRegexTester
    Private Sub KzRegexTester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OptNone.Checked = True
        CountLabel.Text = "Found "
    End Sub

    Private Sub MatchesButton_Click(sender As Object, e As EventArgs) Handles MatchesButton.Click
        Try
            Dim rgx As New Regex(RegexBox.Text, GetOption)
            Dim mts As MatchCollection = rgx.Matches(SourceBox.Text)
            Dim sb As New StringBuilder

            For Each mt As Match In mts
                sb.AppendLine("===== [" & mt.Index & "] =====")
                sb.AppendLine(mt.ToString)
                sb.AppendLine()
            Next
            CountLabel.Text = "Found " & mts.Count
            ResultBox.Text = sb.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupsButton_Click(sender As Object, e As EventArgs) Handles GroupsButton.Click
        Try
            Dim rgx As New Regex(RegexBox.Text, GetOption)
            Dim mts As MatchCollection = rgx.Matches(SourceBox.Text)
            Dim sb As New StringBuilder

            For Each mt As Match In mts
                sb.AppendLine("===== [" & mt.Index & "] =====")
                If mt.Groups.Count > 0 Then
                    For Each gp As Group In mt.Groups
                        sb.AppendLine("[" & gp.Index.ToString & "]. " & gp.Value)
                    Next
                Else
                    sb.AppendLine("[NG]. " & mt.ToString)
                End If
                sb.AppendLine()
            Next
            CountLabel.Text = "Found " & mts.Count
            ResultBox.Text = sb.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetOption() As RegexOptions
        If OptNone.Checked Then Return RegexOptions.None

        Dim opt As New RegexOptions
        If OptIgnoreCase.Checked Then opt = opt Or RegexOptions.IgnoreCase
        If OptMultiLine.Checked Then opt = opt Or RegexOptions.Multiline
        If OptSingleLine.Checked Then opt = opt Or RegexOptions.Singleline
        If OptIgnoreSpace.Checked Then opt = opt Or RegexOptions.IgnorePatternWhitespace
        Return opt
    End Function

    Private Sub OptNone_CheckedChanged(sender As Object, e As EventArgs) Handles OptNone.CheckedChanged
        If OptNone.Checked Then
            OptIgnoreCase.Checked = False
            OptIgnoreSpace.Checked = False
            OptMultiLine.Checked = False
            OptSingleLine.Checked = False
        End If
        OptIgnoreCase.Enabled = Not OptNone.Checked
        OptIgnoreSpace.Enabled = Not OptNone.Checked
        OptMultiLine.Enabled = Not OptNone.Checked
        OptSingleLine.Enabled = Not OptNone.Checked
    End Sub

    Private Sub RegexBox_TextChanged(sender As Object, e As EventArgs) Handles RegexBox.TextChanged
        LengthLabel.Text = "Length " & RegexBox.TextLength
    End Sub


End Class