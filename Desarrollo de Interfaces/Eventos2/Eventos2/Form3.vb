Public Class Form3
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtInteres.Text = txtImporte.Text * 0.07.ToString
        txtSuma.Text = txtImporte.Text * 1.07.ToString
    End Sub

    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        txtInteres.Text = txtImporte.Text * 0.12.ToString
        txtSuma.Text = txtImporte.Text * 1.12.ToString
    End Sub

    Private Sub Btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        txtInteres.Text = txtImporte.Text * 0.16.ToString
        txtSuma.Text = txtImporte.Text * 1.16.ToString
    End Sub
End Class