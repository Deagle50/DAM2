Imports LibreriaFichero
Public Class Form1
    Dim gestor As New GestorFichero
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim dialog As New OpenFileDialog
        If dialog.ShowDialog = DialogResult.OK Then
            gestor.FileName = dialog.FileName
            gestor.Load()
            txtTexto.Text = gestor.Text
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim dialog As New SaveFileDialog
        If dialog.ShowDialog = DialogResult.OK Then
            gestor.FileName = dialog.FileName
            gestor.Text = txtTexto.Text
            gestor.Store()

        End If
    End Sub
End Class