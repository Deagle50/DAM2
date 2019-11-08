Imports System.Data.SqlClient

Public Class Altas
    Private Sub Altas_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim conexion As SqlConnection = New SqlConnection(Form1.cadena)
        Dim consulta As New SqlCommand
        Dim idusuario, pass, nombre, apellido, dni, email As SqlParameter

        idusuario = New SqlParameter()
        idusuario.ParameterName = "@user"
        idusuario.Value = txtUsuario.Text
        idusuario.Direction = ParameterDirection.Input

        nombre = New SqlParameter
        nombre.ParameterName = "@name"
        nombre.Value = txtNombre.Text
        nombre.Direction = ParameterDirection.Input

        pass = New SqlParameter
        pass.ParameterName = "@pass"
        pass.Value = txtPass.Text
        pass.Direction = ParameterDirection.Input

        apellido = New SqlParameter
        apellido.ParameterName = "@lastname"
        apellido.Value = txtApellido.Text
        apellido.Direction = ParameterDirection.Input

        dni = New SqlParameter
        dni.ParameterName = "@dni"
        dni.Value = txtDNI.Text
        dni.Direction = ParameterDirection.Input

        email = New SqlParameter
        email.ParameterName = "@email"
        email.Value = txtEmail.Text
        email.Direction = ParameterDirection.Input

        consulta.Parameters.Add(idusuario)
        consulta.Parameters.Add(pass)
        consulta.Parameters.Add(nombre)
        consulta.Parameters.Add(apellido)
        consulta.Parameters.Add(dni)
        consulta.Parameters.Add(email)

        consulta.CommandType = CommandType.Text
        consulta.CommandText = "INSERT into Foro.Usuarios 
                                (idusuario, palabrapaso, Nombre, Apellidos, dni, email)@user, @pass, @name, @lastname, @dni, @email"
        conexion.Open()
        consulta.Connection = conexion
        conexion.Close()
        MsgBox("Usuario registrado")
    End Sub
End Class