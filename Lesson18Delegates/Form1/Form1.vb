Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler DataGridView1.CellContentClick, AddressOf CellClick
    End Sub
    Private Sub CellClick(s As Object, e As DataGridViewCellEventArgs)
        Dim message = $"Column Index: {e.ColumnIndex}" + vbCr + $"Column Index: {e.RowIndex}"
        MessageBox.Show(message)
    End Sub
End Class
