Public Class FrmModificar
    Dim cn As New SqlConnection(cadena)
    Dim consulta As New SqlCommand()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            consulta.CommandText = "UPDATE Foro.Usuarios SET Nombre=@nom,Apellidos=@ape,DNI=@dn,email=@eml,palabrapaso=@pwd WHERE IdUsuario=@id"
            consulta.Parameters.AddWithValue("@nom", txtNombre.Text)
            consulta.Parameters.AddWithValue("@ape", txtApellido.Text)
            consulta.Parameters.AddWithValue("@pwd", txtPassword.Text)
            consulta.Parameters.AddWithValue("@dn", txtDNI.Text)
            consulta.Parameters.AddWithValue("@eml", txtEmail.Text)
            cn.Open()
            consulta.ExecuteNonQuery()
            MsgBox("Registro actualizado con éxito")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub FrmModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta.CommandText = "SELECT idUsuario,palabrapaso,nombre,apellidos,dni,email FROM Foro.Usuarios WHERE idUsuario=@id"
        consulta.CommandType = CommandType.Text
        consulta.Connection = cn
        consulta.Parameters.AddWithValue("@id", IdActual)
        cn.Open()
        Dim dr As SqlDataReader = consulta.ExecuteReader
        dr.Read()
        txtUsuario.Text = dr("idUsuario")
        txtNombre.Text = dr("Nombre")
        txtApellido.Text = dr("Apellidos")
        txtDNI.Text = dr("DNI")
        txtEmail.Text = dr("email")
        txtPassword.Text = dr("palabrapaso")
        dr.Close()
        cn.Close()
    End Sub
End Class