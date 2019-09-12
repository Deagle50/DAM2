Public Class FormularioMDI
    Private Sub FormularioMDi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub ColoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoresToolStripMenuItem.Click
        FormularioArchivo.Show()
    End Sub
End Class