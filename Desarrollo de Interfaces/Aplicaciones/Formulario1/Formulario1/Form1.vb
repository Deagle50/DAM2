Public Class Form1
    Private Sub BtnNombre_Click(sender As Object, e As EventArgs) Handles btnNombre.Click
        lstNombres.Items.Add(txtNombre.Text)
        txtNombre.Focus()                   'Nos ponemos en la caja del texto
        txtNombre.SelectAll()               'Seleccionamos el texto
    End Sub

End Class
