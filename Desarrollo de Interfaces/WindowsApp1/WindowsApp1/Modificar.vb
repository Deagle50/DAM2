Imports System.Data.SqlClient

Public Class Modificar
    Dim conexion As New SqlConnection(Form1.cadena)
    Dim consulta As New SqlCommand()
    Dim dr As SqlDataReader
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            consulta.CommandText = "UPDATE Foro.Usuarios SET Nombre=@nom, Apellidos=@ape, DNI=@dn, email=@eml, palabrapaso=@pwd WHERE IdUsuario=@id"
            consulta.Parameters.AddWithValue("@nom", txtNombre.Text)
            consulta.Parameters.AddWithValue("@ape", txtApellido.Text)
            consulta.Parameters.AddWithValue("@dn", txtDNI.Text)
            consulta.Parameters.AddWithValue("@eml", txtEmail.Text)
            consulta.Parameters.AddWithValue("@pwd", txtPass.Text)
            conexion.Open()
            consulta.ExecuteNonQuery()
            MsgBox("Cambio realizado con éxito")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles Me.Load
        consulta.CommandText = "SELECT idUsuario, palabrapaso, nombre, apellidos, dni, email
                            FROM Foro.Usuarios"
        consulta.CommandType = CommandType.Text
        consulta.Connection = conexion
        consulta.Parameters.AddWithValue("@id", IdActual)
        conexion.Open()

        dr = consulta.ExecuteReader
        dr.Read()
        txtUsuario.Text = dr("idusuario")
        txtNombre.Text = dr("Nombre")
        txtApellido.Text = dr("Apellidos")
        txtDNI.Text = dr("DNI")
        txtEmail.Text = dr("email")
        dr.Close()
        conexion.Close()
    End Sub
End Class