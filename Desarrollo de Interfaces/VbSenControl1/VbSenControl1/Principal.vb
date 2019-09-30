Public Class Principal

    Private Sub FormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormTool2StripMenuItem.Click
        Dim F As New Form1
        F.Show()
        ' MdiParent = Me
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormToolStripMenuItem.Click
        Dim F As New Form2
        F.Show()
        'MdiParent = Me
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Dim F As New Form3
        F.Show()
    End Sub
End Class