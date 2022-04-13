Imports System.IO
Public Class Read

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Dim stream As StreamReader = File.OpenText(OpenFileDialog1.FileName)
        While stream.Peek() > -1
            Label1.Text += vbCr + stream.ReadLine()
        End While
    End Sub
End Class
