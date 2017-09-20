Imports System.IO
Imports System.Text

Public Class KzSingleEditor

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        SetUI()
    End Sub

    Private Sub FileTools_SizeChanged(sender As Object, e As EventArgs) Handles FileTools.SizeChanged
        Dim w As Integer = 15

        For Each item As ToolStripItem In FileTools.Items
            If Not item.Equals(FilePathTextBox) Then
                w += item.Width
            End If
        Next

        FilePathTextBox.Width = FileTools.Width - w
    End Sub

    Public Property Contents As String
        Get
            Return ContentsBox.Text
        End Get
        Set(value As String)
            ContentsBox.Text = value
            ContentsBox.SelectionStart = 0
            ContentsBox.SelectionLength = 0
        End Set
    End Property

    Public Property DefaultEncoding As Encoding
        Get
            Return GetEncoding(EncodingComboBox.SelectedItem)
        End Get
        Set(value As Encoding)
            SetEncodingBox(value)
        End Set
    End Property

    Public Property FilePath As String
        Get
            Return FilePathTextBox.Text
        End Get
        Set(value As String)
            FilePathTextBox.Text = value
        End Set
    End Property

#Region "EncodingWorks"
    Private Sub SetEncodingBox(ByVal EncodingType As Encoding)
        With EncodingComboBox
            If EncodingType.Equals(Encoding.Default) Then .SelectedItem = "Default"
            If EncodingType.Equals(Encoding.ASCII) Then .SelectedItem = "ASCII"
            If EncodingType.Equals(Encoding.Unicode) Then .SelectedItem = "Unicode"
            If EncodingType.Equals(Encoding.UTF8) Then .SelectedItem = "UTF-8"
            If EncodingType.Equals(Encoding.UTF32) Then .SelectedItem = "UTF-32"
            If EncodingType.Equals(Encoding.UTF7) Then .SelectedItem = "UTF-7"
            If EncodingType.Equals(Encoding.BigEndianUnicode) Then .SelectedItem = "BEUnicode"
        End With
    End Sub

    Private Function GetEncoding(ByVal EncodingName As String) As Encoding
        Select Case EncodingComboBox.SelectedItem
            Case "ASCII" : Return Encoding.ASCII
            Case "Unicode" : Return Encoding.Unicode
            Case "UTF-8" : Return Encoding.UTF8
            Case "UTF-32" : Return Encoding.UTF32
            Case "UTF-7" : Return Encoding.UTF7
            Case "BEUnicode" : Return Encoding.BigEndianUnicode
            Case Else : Return Encoding.Default
        End Select
    End Function

    Private Sub EncodingComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EncodingComboBox.SelectedIndexChanged
        Dim ecea As New EncodingChangedEventArgs
        ecea.Name = EncodingComboBox.SelectedItem
        ecea.Encoding = GetEncoding(EncodingComboBox.SelectedItem)

        'If File.Exists(FilePathTextBox.Text) AndAlso ContentsBox.Text.Trim.Length > 0 Then
        '    Try
        '        File.ReadAllText(FilePathTextBox.Text, ecea.Encoding)
        '    Catch ex As Exception

        '    End Try
        'End If

        RaiseEvent EncodingChanged(Me, ecea)
    End Sub

    Public Event EncodingChanged(sender As Object, e As EncodingChangedEventArgs)
#End Region 'EncodingWorks

#Region "PrivateMethods"
    Private Sub SetUI()
        NewButton.Image = My.Resources.edit_new
        OpenButton.Image = My.Resources.edit_open
        SaveButton.Image = My.Resources.edit_save
        SaveAsButton.Image = My.Resources.edit_saveas
        RefreshButton.Image = My.Resources.edit_refresh
        UndoButton.Image = My.Resources.edit_undo
        RedoButton.Image = My.Resources.edit_redo
        CopyButton.Image = My.Resources.edit_copy
        CutButton.Image = My.Resources.edit_cut
        PasteButton.Image = My.Resources.edit_paste
        SelectAllButton.Image = My.Resources.edit_selectall
        BeginSelectButton.Image = My.Resources.edit_beginselect
        ClearAllButton.Image = My.Resources.edit_clearall
        WrapButton.Image = My.Resources.edit_wrap
        FontButton.Image = My.Resources.edit_font
        InsertButton.Image = My.Resources.edit_insert
        ToolsButton.Image = My.Resources.edit_tools
        FindReplaceButton.Image = My.Resources.edit_findreplace
        DeleteButton.Image = My.Resources.edit_delete
        CmdButton.Image = My.Resources.edit_command
    End Sub

    Private Sub UpdateCounts(Optional ByVal WithoutFullCount As Boolean = False)
        Dim fmt As String = "#,0."

        With ContentsBox
            If Not WithoutFullCount Then
                Try
                    CountLabel.Text = "全長 " & Strings.Format(.Text.Length, fmt)
                Catch ex As Exception
                    CountLabel.Text = "全長 -"
                End Try
            End If

            Try
                SelectionLabel.Text = "始 " & Strings.Format(.SelectionStart, fmt) &
                    " 長 " & Strings.Format(.SelectionLength, fmt)
            Catch ex As Exception
                SelectionLabel.Text = "始 - 長 -"
            End Try

            Try
                LinesLabel.Text = "行數 " & Strings.Format(.Lines.Count, fmt)
            Catch ex As Exception
                LinesLabel.Text = "行數 -"
            End Try

            Try
                PositionLabel.Text = "行 " & Strings.Format(.GetLineFromCharIndex(.SelectionStart), fmt) &
                    " 列 " & Strings.Format(.SelectionStart - .GetFirstCharIndexFromLine(.GetLineFromCharIndex(.SelectionStart)), fmt)
            Catch ex As Exception
                PositionLabel.Text = "行 - 列 -"
            End Try

            Try
                PercentLabel.Text = "位 " & Math.Round((.SelectionStart / .Text.Length) * 100, 1).ToString & "%"
            Catch ex As Exception
                PercentLabel.Text = "位 -"
            End Try
        End With
    End Sub
#End Region 'PrivateMethods

#Region "ContentsActions"
    Private Sub ContentsBox_TextChanged(sender As Object, e As EventArgs) Handles ContentsBox.TextChanged
        UpdateCounts()
    End Sub

    Private Sub ContentsBox_MouseDown(sender As Object, e As MouseEventArgs) Handles ContentsBox.MouseDown
        With BeginSelectButton
            If .Checked Then
                Dim tempStart, tempLength As Integer
                If .Tag > ContentsBox.SelectionStart Then
                    tempStart = ContentsBox.SelectionStart
                    tempLength = .Tag - ContentsBox.SelectionStart
                ElseIf .Tag < ContentsBox.SelectionStart Then
                    tempStart = .Tag
                    tempLength = ContentsBox.SelectionStart - .Tag
                Else
                    tempStart = .Tag
                    tempLength = 0
                End If

                ContentsBox.SelectionStart = tempStart
                ContentsBox.SelectionLength = tempLength

                .Checked = False
                ContentsBox.BackColor = SystemColors.Window
            End If
        End With
    End Sub

    Private Sub ContentsBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ContentsBox.MouseUp
        If e.Button = MouseButtons.Left Then
            UpdateCounts()
        End If
    End Sub

    Private Sub ContentsBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ContentsBox.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Back Or
            e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Tab Or
            e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or
            e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or
            e.KeyCode = Keys.Home Or e.KeyCode = Keys.End Or
            e.KeyCode = Keys.PageDown Or e.KeyCode = Keys.PageUp Then

            UpdateCounts()
        End If
    End Sub
#End Region 'ContentsActions


    Private Sub BeginSelectButton_Click(sender As Object, e As EventArgs) Handles BeginSelectButton.Click
        With BeginSelectButton
            If .Checked Then
                .Tag = ContentsBox.SelectionStart
                ContentsBox.BackColor = SystemColors.Info
            Else
                .Tag = Nothing
                ContentsBox.BackColor = SystemColors.Window
            End If
        End With
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim go As Boolean = True
        If Not (ContentsBox.Text Is Nothing And ContentsBox.Text.Trim.Length > 0) And SaveButton.Enabled Then
            If MsgBox("當前檔尚未保存，繼續創建新檔將丟失變更內容。" & vbCrLf & "是否繼續？", MsgBoxStyle.YesNo, "保存") = MsgBoxResult.No Then
                go = False
            End If
        End If

        If go Then
            ContentsBox.Clear()
            FilePathTextBox.Text = "(New)"
        End If
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim go As Boolean = True
        If Not (ContentsBox.Text Is Nothing And ContentsBox.Text.Trim.Length > 0) And SaveButton.Enabled Then
            If MsgBox("當前檔尚未保存，繼續創建新檔將丟失變更內容。" & vbCrLf & "是否繼續？", MsgBoxStyle.YesNo, "保存") = MsgBoxResult.No Then
                go = False
            End If
        End If

        If go Then
            ContentsBox.Clear()

            Dim ofd As New OpenFileDialog
            If ofd.ShowDialog = DialogResult.OK Then
                Try
                    ContentsBox.Text = File.ReadAllText(FilePathTextBox.Text, GetEncoding(EncodingComboBox.SelectedItem))
                Catch ex As Exception
                    MsgBox("未能讀入文檔，原因：" & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        If File.Exists(FilePathTextBox.Text) Then
            Try
                ContentsBox.Text = File.ReadAllText(FilePathTextBox.Text, GetEncoding(EncodingComboBox.SelectedItem))
            Catch ex As Exception
                MsgBox("未能讀入文檔，原因：" & vbCrLf & ex.Message)
            End Try
        Else
            MsgBox("當前文檔所指定位置不存在或文檔名稱非法。")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If File.Exists(FilePathTextBox.Text) Then
            Try
                File.WriteAllText(FilePathTextBox.Text, ContentsBox.Text, GetEncoding(EncodingComboBox.SelectedItem))
            Catch ex As Exception
                MsgBox("未能保存文檔，原因：" & vbCrLf & ex.Message)
            End Try
        Else
            Dim sfd As New SaveFileDialog
            If sfd.ShowDialog = DialogResult.OK Then
                Try
                    File.WriteAllText(FilePathTextBox.Text, ContentsBox.Text, GetEncoding(EncodingComboBox.SelectedItem))
                Catch ex As Exception
                    MsgBox("未能保存文檔，原因：" & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        Dim sfd As New SaveFileDialog
        If sfd.ShowDialog = DialogResult.OK Then
            Try
                File.WriteAllText(FilePathTextBox.Text, ContentsBox.Text, GetEncoding(EncodingComboBox.SelectedItem))
            Catch ex As Exception
                MsgBox("未能保存文檔，原因：" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles UndoButton.Click
        ContentsBox.Undo()
    End Sub

    Private Sub RedoButton_Click(sender As Object, e As EventArgs) Handles RedoButton.Click

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If ContentsBox.SelectionLength > 0 Then
            Dim go As Boolean = True
            If ContentsBox.SelectionLength = ContentsBox.TextLength Then
                If MsgBox("即將清空所有內容，是否繼續？", MsgBoxStyle.YesNo, "刪除") = MsgBoxResult.No Then
                    go = False
                End If
            End If

            If go Then ContentsBox.SelectedText = ""
        End If
    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        If ContentsBox.Text.Trim.Length > 0 Then
            If MsgBox("即將清空所有內容，是否繼續？", MsgBoxStyle.YesNo, "刪除") = MsgBoxResult.Yes Then
                ContentsBox.Clear()
            End If
        End If
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        If ContentsBox.SelectionLength > 0 Then
            Clipboard.SetText(ContentsBox.SelectedText)
        End If
    End Sub

    Private Sub CutButton_Click(sender As Object, e As EventArgs) Handles CutButton.Click
        If ContentsBox.SelectionLength > 0 Then
            Clipboard.SetText(ContentsBox.SelectedText)
            ContentsBox.SelectedText = ""
        End If
    End Sub

    Private Sub PasteButton_Click(sender As Object, e As EventArgs) Handles PasteButton.Click
        Try
            ContentsBox.Paste(Clipboard.GetText)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WrapButton_Click(sender As Object, e As EventArgs) Handles WrapButton.Click
        ContentsBox.WordWrap = WrapButton.Checked
    End Sub
End Class

Public Class EncodingChangedEventArgs
    Inherits EventArgs

    Public Property Name As String
    Public Property Encoding As Encoding
End Class

'Public Class KzEncoding
'    Private _Name As String
'    Private _Encoding As Encoding

'    Public Sub New(ByVal EncodingName As String, ByVal EncodingValue As Encoding)
'        _Name = EncodingName
'        _Encoding = EncodingValue
'    End Sub

'    Public ReadOnly Property Name As String
'        Get
'            Return _Name
'        End Get
'    End Property

'    Public ReadOnly Property Encoding As Encoding
'        Get
'            Return _Encoding
'        End Get
'    End Property
'End Class
