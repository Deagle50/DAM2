Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v As New Linq2.Viajeros
        v.CodViajero = CInt(txtCodigo.Text)
        v.Ciudad = txtCiudad.Text
        v.Direccion = txtDireccion.Text
        v.DNI = txtDni.Text
        v.Nombre = txtNombre.Text
        v.Telefono = txtTelefono.Text
        modelo.Viajeros.Add(v)
        modelo.SaveChanges()
    End Sub
End Class