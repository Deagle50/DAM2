Public Class FrmBaja
    Dim cn As New SqlConnection(cadena)
    Dim consulta As New SqlCommand()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consulta.CommandText = "Select count(idMensaje) FROM foro.mensajes where idUsuario=@id"
        cn.Open()
        Dim cuantos As Integer = consulta.ExecuteScalar()

        If cuantos <> 0 Then
            ''pedir confirmacion
            Dim resp As MsgBoxResult
            resp = MsgBox("Está seguro", vbYesNo)
            If resp = vbYes Then
                consulta.CommandText = "delete from FORO.Mensajes where IdUsuario=@id"
                consulta.ExecuteNonQuery()
                consulta.CommandText = "delete from FORO.Usuarios where IdUsuario=@id"
                consulta.ExecuteNonQuery()
                cn.Close()
            Else
                MsgBox("Se canceló el borrado")
                cn.Close()
                Exit Sub

            End If
        Else
            ''borrar usuario
            consulta.CommandText = "DELETE from Foro.Usuarios where idUsuario=@id"
            consulta.ExecuteNonQuery()
            cn.Close()
        End If
        MsgBox("Registro eliminado con éxito")
        Me.Dispose()
    End Sub

    Private Sub FrmBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        consulta.CommandText = "SELECT Nombre,Apellidos,palabrapaso,email,DNI FROM Foro.Usuarios WHERE idUsuario=@id"
        consulta.Parameters.AddWithValue("@id", IdActual)
        consulta.CommandType = CommandType.Text
        consulta.Connection = cn
        cn.Open()
        Dim dr As SqlDataReader = consulta.ExecuteReader
        dr.Read()
        txtNombre.Text = dr("Nombre")
        txtApellido.Text = dr("Apellidos")
        txtPassword.Text = dr("palabrapaso")
        txtEmail.Text = dr("email")
        txtDNI.Text = dr("DNI")
        txtUsuario.Text = IdActual
        dr.Close()
        cn.Close()
    End Sub
End Class