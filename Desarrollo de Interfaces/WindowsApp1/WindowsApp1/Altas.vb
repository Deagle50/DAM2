Imports System.Data.SqlClient

Public Class Altas
    Private Sub Altas_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim conexion As New SqlConnection(Form1.cadena) 'SqlConnection cn en el programa de Dani
        Dim consulta As New SqlCommand("INSERT into Foro.Usuarios
                                (idusuario, palabrapaso, Nombre, Apellidos, dni, email) 
                                values(@user, @pass, @name, @lastname, @dni, @email)")
        'Dim idusuario, pass, nombre, apellido, dni, email As SqlParameter
        Try
            consulta.CommandType = CommandType.Text
            conexion.Open()
            'Añadir parámetros
            consulta.Parameters.AddWithValue("@id", txtUsuario.Text)
            consulta.Parameters.AddWithValue("@pass", txtPass.Text)
            consulta.Parameters.AddWithValue("@name", txtNombre.Text)
            consulta.Parameters.AddWithValue("@lastname", txtApellido.Text)
            consulta.Parameters.AddWithValue("@dni", txtDNI.Text)
            consulta.Parameters.AddWithValue("@email", txtEmail.Text)

            'Ejecutar consulta
            consulta.ExecuteNonQuery()

            MsgBox("Usuario registrado")
        Catch Ex As SqlException
            MsgBox(Ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class