Imports System.Collections.Specialized

Public Class KzListEditor

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Property ListSource As StringCollection
        Get
            Dim sc As New StringCollection
            If TheListBox.Items.Count > 0 Then
                For Each item As String In TheListBox.Items
                    sc.Add(item)
                Next
            End If
            Return sc
        End Get
        Set(value As StringCollection)
            TheListBox.Items.Clear()
            SearchTextBox.AutoCompleteCustomSource.Clear()

            For Each s As String In value
                TheListBox.Items.Add(s)
                SearchTextBox.AutoCompleteCustomSource.Add(s)
            Next
        End Set
    End Property

    Private Sub TheListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TheListBox.SelectedIndexChanged
        If TheListBox.SelectedIndex > -1 Then
            EditTextBox.Text = TheListBox.SelectedItem
            AddButton.Enabled = False
            UpdateButton.Enabled = False
            DeleteButton.Enabled = True
            MoveDownButton.Enabled = True
            MoveUpButton.Enabled = True
        Else
            EditTextBox.Text = Nothing
            AddButton.Enabled = False
            UpdateButton.Enabled = False
            DeleteButton.Enabled = False
            MoveDownButton.Enabled = False
            MoveUpButton.Enabled = False
        End If
    End Sub

    Private Sub EditTextBox_TextChanged(sender As Object, e As EventArgs) Handles EditTextBox.TextChanged
        AddButton.Enabled = True
        UpdateButton.Enabled = True
    End Sub

    Private Sub SearchTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TheListBox.SelectedItem = SearchTextBox.Text
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub UpdateAutoSource()
        With SearchTextBox.AutoCompleteCustomSource
            .Clear()
            For Each item As String In TheListBox.Items
                .Add(item)
            Next
        End With
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim go As Boolean = True
        If TheListBox.Items.Contains(EditTextBox.Text) Then
            If MsgBox("Input string already exists. Do you want to continue?",
                      MsgBoxStyle.YesNo, "Add") = MsgBoxResult.No Then
                go = False
            End If
        End If

        If go Then
            TheListBox.Items.Add(EditTextBox.Text)
            UpdateAutoSource()
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If TheListBox.SelectedIndex > -1 Then
            If TheListBox.SelectedItem <> EditTextBox.Text Then
                Dim i As Integer = TheListBox.SelectedIndex
                TheListBox.Items.RemoveAt(i)

                If i > TheListBox.Items.Count - 1 Then
                    TheListBox.Items.Add(EditTextBox.Text)
                Else
                    TheListBox.Items.Insert(i, EditTextBox.Text)
                End If

                TheListBox.SelectedItem = EditTextBox.Text
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If TheListBox.SelectedIndex > -1 Then
            TheListBox.Items.RemoveAt(TheListBox.SelectedIndex)
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If TheListBox.Items.Count > 0 Then
            If MsgBox("All list item will be deleted. Do you want to continue?",
                      MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                TheListBox.Items.Clear()
            End If
        End If
    End Sub
End Class