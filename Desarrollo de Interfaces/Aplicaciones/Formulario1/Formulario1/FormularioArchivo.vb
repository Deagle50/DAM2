Public Class FormularioArchivo
    Private Sub CambiarColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarColorToolStripMenuItem.Click
        Dim c As New ColorDialog
        If c.ShowDialog() = DialogResult.OK Then
            TextBox1.ForeColor = c.Color
        End If
    End Sub
End Class