'//Sample for SetDesktopLocation, Closed, Load, Activated, and Activate

Public Class Form1
    Shared x As Integer = 200
    Shared y As Integer = 200

    Private Sub Button1_Click(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles Button1.Click

        ' Create a new Form1 and set its Visible property to true.
        Dim form2 As New Form1
        form2.Visible = True

        ' Set the new form's desktop location so it appears below and 
        ' to the right of the current form.
        form2.SetDesktopLocation(x, y)
        x += 30
        y += 30

        ' Keep the current form active by calling the Activate method.
        Me.Activate()
        Me.Button1.Enabled = False
    End Sub



    ' Updates the label text to reflect the current values of x and y, 
    ' which was were incremented in the Button1 control's click event.
    Private Sub Form1_Activated(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles MyBase.Activated
        Label1.Text = "x: " & x & " y: " & y
        Label2.Text = "Number of forms currently open: " & count
    End Sub

    Shared count As Integer = 0

    Private Sub Form1_Closed(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles MyBase.Closed
        count -= 1
    End Sub

    Private Sub Form1_Load(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles MyBase.Load
        count += 1

        TextBox1.Text = strMyOriginalText
    End Sub

    Dim strMyOriginalText = "Test!"

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Determine if text has changed in the textbox by comparing to original text.
        If TextBox1.Text <> strMyOriginalText Then
            ' Display a MsgBox asking the user to save changes or abort.
            If MessageBox.Show("Do you want to save changes to your text?", "My Application", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Cancel the Closing event from closing the form.
                e.Cancel = True
            End If ' Call method to save file...
        End If
    End Sub 'Form1_Closing

End Class 'Form1
