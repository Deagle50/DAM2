Public Class Formulario4
    Private Sub TxtCentigrados_TextChanged(sender As Object, e As EventArgs) Handles txtCentigrados.TextChanged
        'txtFahrenheit.Text = 0
        txtFahrenheit.Text = txtCentigrados.Text * 9 / 5 + 32
    End Sub

    Private Sub TxtFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged
        '        txtCentigrados.Text = 0
        txtCentigrados.Text = (txtFahrenheit.Text - 32) * 5 / 9
    End Sub
End Class