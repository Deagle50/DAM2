
Public Class FrmAlta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection(cadena)
        Dim consulta As New SqlCommand("INSERT INTO Foro.usuarios(idUsuario,palabrapaso,Nombre,Apellidos,DNI,email) values(@id,@pw,@nom,@ape,@dni,@eml)")
        Try
            consulta.CommandType = CommandType.Text
            consulta.Connection = cn
            cn.Open()
            ''agregar parámetros
            consulta.Parameters.AddWithValue("@id", txtUsuario.Text)
            consulta.Parameters.AddWithValue("@pw", txtPassword.Text)
            consulta.Parameters.AddWithValue("@nom", txtNombre.Text)
            consulta.Parameters.AddWithValue("@ape", txtApellido.Text)
            consulta.Parameters.AddWithValue("@dni", txtDNI.Text)
            consulta.Parameters.AddWithValue("@eml", txtEmail.Text)
            ''Ejecutar consulta
            consulta.ExecuteNonQuery()

            MsgBox("Registro añadido con éxito")
        Catch Ex As SqlException
            MsgBox(Ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
End Class