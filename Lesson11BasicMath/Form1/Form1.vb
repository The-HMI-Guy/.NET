Public Class Form1
    Private Sub btnSummarize_Click(sender As Object, e As EventArgs) Handles btnSummarize.Click
        Dim firstValue = Double.Parse(txtFirstValue.Text)
        Dim secondValue = Double.Parse(txtSecondValue.Text)
        Dim sum = firstValue + secondValue
        lblSummary.Text = $"Sum: {sum}" + vbCr + $"Average: {sum / 2}"
    End Sub
End Class
