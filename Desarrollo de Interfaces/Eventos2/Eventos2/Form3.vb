Public Class Form3
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtInteres.Text = txtImporte.Text * 0.07
        txtSuma.Text = txtImporte.Text * 1.07
    End Sub

    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        txtInteres.Text = txtImporte.Text * 0.12
        txtSuma.Text = txtImporte.Text * 1.12
    End Sub

    Private Sub Btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        txtInteres.Text = txtImporte.Text * 0.16
        txtSuma.Text = txtImporte.Text * 1.16
    End Sub
End Class