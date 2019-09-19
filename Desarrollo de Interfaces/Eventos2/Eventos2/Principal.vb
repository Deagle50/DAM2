Public Class Principal
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub
End Class
