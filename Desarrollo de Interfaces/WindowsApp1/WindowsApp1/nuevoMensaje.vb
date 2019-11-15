Imports System.Data.SqlClient

Public Class nuevoMensaje
    Private Sub nuevoMensaje_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtFecha.Text = DateTime.Now.ToString("dd/mm/yy")
        txtId.Text = IdActual
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim consulta As New SqlCommand
        Dim conexion As New SqlConnection
        Dim siguienteID As Integer = CalcularSiguienteID()
        Dim it As ListViewItem

        Try
            consulta.CommandText = "INSERT INTO Foro.Mensajes(IdMensaje, IdUsuario, Mensaje, Fecha) VALUES (@idm, @idu, @msg, @date)"
            consulta.CommandType = CommandType.Text
            consulta.Connection = conexion

            consulta.Parameters.AddWithValue("@idm", siguienteID)
            consulta.Parameters.AddWithValue("@idu", txtId.Text)
            consulta.Parameters.AddWithValue("@msg", txtMensajes.Text.ToString)
            consulta.Parameters.AddWithValue("@date", CDate(txtFecha.Text))

            conexion.Open()
            consulta.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Mensaje enviado con éxito")
            it = Form1.ListView1.Items.Add(siguienteID.ToString)
            it.SubItems.Add(txtFecha.Text)
            it.SubItems.Add(txtMensajes.Text)

            Me.Dispose()
        Catch Ex As Exception
            MsgBox(Ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Function CalcularSiguienteID() As Integer

        Dim comando As New SqlCommand
        Dim conexion2 As New SqlConnection(Form1.cadena)
        Dim id As Integer

        comando.CommandText = "SELECT MAX(idmensaje) FROM Foro.Mensajes"
        comando.CommandType = CommandType.Text
        comando.Connection = conexion2
        conexion2.Open()
        id = comando.ExecuteScalar
        conexion2.Close()

        Return id + 1

    End Function
End Class