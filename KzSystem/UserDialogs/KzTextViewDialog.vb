﻿Imports System.IO

Public Class KzTextViewDialog

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub KzTextViewDialog_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        InfoLabel.Width = RootSplitContainer.Panel2.Width - 198
    End Sub

    Public Property TextContents As String
        Get
            Return Me.ContentsTextBox.Text
        End Get
        Set(value As String)
            Me.ContentsTextBox.Text = value
        End Set
    End Property

    Public Property InfoText As String
        Get
            Return Me.InfoLabel.Text
        End Get
        Set(value As String)
            Me.InfoLabel.Text = value
        End Set
    End Property

    Public Property SaveFilePath As String = Nothing

    Private Sub UpdateStatusLabels(Optional all As Boolean = True)
        With ContentsTextBox
            If all Then
                CountLabel.Text = "Lenth: " & .TextLength
            End If
            SelectionLabel.Text = "Start: " & .SelectionStart & ", Length: " & .SelectionLength
            PositionLabel.Text = "Line: " & .GetLineFromCharIndex(.SelectionStart) & ", Index: " & .SelectionStart - .GetFirstCharIndexOfCurrentLine
        End With
    End Sub

    Private Sub ContentsTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContentsTextBox.TextChanged
        UpdateStatusLabels()
    End Sub

    Private Sub ContentsTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ContentsTextBox.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or
            e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or
            e.KeyCode = Keys.PageUp Or e.KeyCode = Keys.PageDown Or
            e.KeyCode = Keys.Home Or e.KeyCode = Keys.End Then

            UpdateStatusLabels(False)
        End If
    End Sub

    Private Sub ContentsTextBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ContentsTextBox.MouseUp
        If e.Button = MouseButtons.Left Then
            UpdateStatusLabels(False)
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        ContentsTextBox.SelectAll()
        ContentsTextBox.Copy()
    End Sub

    Private Sub WrapToolStripButton_Click(sender As Object, e As EventArgs) Handles WrapToolStripButton.Click
        ContentsTextBox.WordWrap = Not ContentsTextBox.WordWrap
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If Not System.IO.File.Exists(SaveFilePath) Then
            Dim ofd As New OpenFileDialog
            ofd.Multiselect = False
            SaveFilePath = ofd.FileName
        End If

        Try
            System.IO.File.WriteAllText(SaveFilePath, TextContents, System.Text.Encoding.UTF8)
        Catch ex As Exception
            MsgBox("文檔文能保存。原因：" & vbCrLf & ex.Message, MsgBoxStyle.OkOnly, "存檔")
        End Try
    End Sub
End Class