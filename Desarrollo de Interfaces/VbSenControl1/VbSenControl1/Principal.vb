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
        Dim j As Integer = InputBox("Introduce un número")
        Console.WriteLine("{0,10}{1,10}{2,10}", "Numero", "Cuadrado", "Cubo")
        For i = 0 To j
            Console.WriteLine("{0, 10}{1, 10}{2,10}", i, i ^ 2, i ^ 3)
        Next
    End Sub
End Class