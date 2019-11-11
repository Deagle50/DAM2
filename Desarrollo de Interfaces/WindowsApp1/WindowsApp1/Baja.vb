Imports System.Data.SqlClient

Public Class Baja
    Dim conexion As New SqlConnection(Form1.cadena)
    Dim consulta As New SqlCommand()

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cuantos As Integer
        Dim respuesta As MsgBoxResult
        consulta.CommandText = "SELECT count(idmensaje) 
                            FROM Foro.Mensajes
                            WHERE idusuario = @id"
        conexion.Open()
        cuantos = consulta.ExecuteScalar
        conexion.Close()

        If cuantos <> 0 Then
            'Pedir confirmación
            respuesta = MsgBox("¿Está seguro?", vbYesNo)
            If respuesta = vbYes Then
                conexion.Open()
                'Borrar mensajes
                consulta.CommandText = "DELETE 
                                    FROM Foro.Mensajes
                                    WHERE IdUsuario = @id"
                consulta.ExecuteNonQuery()
                'Borrarr usuario
                consulta.CommandText = "DELETE 
                                    FROM Foro.Usuarios
                                    WHERE IdUsuario = @id"
                consulta.ExecuteNonQuery()
                conexion.Close()
            Else
                MsgBox("Se canceló el borrado")
                Exit Sub
            End If
        Else
            'Borrar usuario
            consulta.CommandText = "DELETE 
                                FROM Foro.Usuarios
                                WHERE idusuario = @id"
            conexion.Close()
            consulta.ExecuteNonQuery()
        End If
        conexion.Close()
        MsgBox("Registro eliminado con éxito")
    End Sub

    Private Sub Baja_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dr As SqlDataReader
        consulta.CommandText = "SELECT Nombre, Apellidos, palabrapaso, email, DNI
                            FROM Foro.Usuarios
                            WHERE @id=IdUsuario"
        consulta.Parameters.AddWithValue("@id", IdActual)
        consulta.CommandType = CommandType.Text
        consulta.Connection = conexion
        '¿Dónde va?
        dr = consulta.ExecuteReader
        consulta.ExecuteNonQuery()
        conexion.Open()
        dr.Read()

        txtNombre.Text = dr("Nombre")
        txtApellido.Text = dr("Apellidos")
        txtPass.Text = dr("palabrapaso")
        txtEmail.Text = dr("email")
        txtDNI.Text = dr("DNI")
        txtUsuario.Text = IdActual

        dr.Close()
        conexion.Close()
    End Sub
End Class