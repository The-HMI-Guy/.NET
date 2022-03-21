Public Class Form1
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        'function chaining
        lblMessage.Text = txtInput.Text.Trim().ToUpper()
    End Sub
End Class
