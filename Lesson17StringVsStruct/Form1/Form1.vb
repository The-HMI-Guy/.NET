Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim s1 As String = "hello 1"
        Dim s2 = s1
        s1 = "hello 2"
        s1 = "hello 3"
    End Sub
End Class
