Public Class Principal

    Private Sub Formulario1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Formulario1ToolStripMenuItem1.Click
        Formulario1.MdiParent = Me
        Formulario1.Show()
    End Sub

    Private Sub Formulario2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario2ToolStripMenuItem.Click
        Formulario2.MdiParent = Me
        Formulario2.Show()
    End Sub

    Private Sub Formulario3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario3ToolStripMenuItem.Click
        Formulario3.MdiParent = Me
        Formulario3.Show()
    End Sub

    Private Sub Formulario4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulario4ToolStripMenuItem.Click
        Formulario4.MdiParent = Me
        Formulario4.Show()
    End Sub
End Class
