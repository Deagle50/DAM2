Public Class Formulario4
    Dim status As Boolean = False
    Private Sub TxtCentigrados_TextChanged(sender As Object, e As EventArgs) Handles txtCentigrados.TextChanged
        'txtFahrenheit.Text = 0
        status = True
        btnConvertir.Enabled = True
    End Sub

    Private Sub TxtFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged
        '        txtCentigrados.Text = 0
        status = False
        btnConvertir.Enabled = True
    End Sub

    Private Sub BtnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim vble As Single
        If Not status Then
            vble = CSng(txtFahrenheit.Text)
            vble = (vble + 32) * 5 / 9
            txtCentigrados.Text = vble.ToString
        Else
            vble = CSng(txtCentigrados.Text)
            vble = 9 / 5 * vble + 32
            txtFahrenheit.Text = vble.ToString
        End If
        btnConvertir.Enabled = False
    End Sub

    Private Sub txtFahrenheit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFahrenheit.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCentigrados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentigrados.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> "." And Asc(e.KeyChar <> "8") Then
            e.Handled = True
        End If
    End Sub
End Class