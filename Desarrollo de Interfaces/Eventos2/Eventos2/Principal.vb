Public Class Principal
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Dim F As New Form2
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Dim F As New Form3
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form4ToolStripMenuItem.Click
        Dim F As New form4
        F.MdiParent = Me
        F.Show()
    End Sub
End Class
