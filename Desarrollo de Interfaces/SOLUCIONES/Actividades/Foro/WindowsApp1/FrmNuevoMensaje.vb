Public Class FrmNuevoMensaje

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim consulta As New SqlCommand("INSERT INTO Foro.Mensajes(IdMensaje,IdUsuario,Mensaje,Fecha) VALUES (@idm,@idu,@msg,@dat)")
        Try
            consulta.CommandType = CommandType.Text
            consulta.Connection = New SqlConnection(cadena)
            Dim sigId As Integer = CalcularSiguienteId()
            consulta.Parameters.AddWithValue("@idm", sigId)
            consulta.Parameters.AddWithValue("@idu", txtUsuario.Text)
            consulta.Parameters.AddWithValue("@dat", CDate(txtFecha.Text))
            consulta.Parameters.AddWithValue("@msg", txtMensaje.Text)
            consulta.Connection.Open()
            consulta.ExecuteNonQuery()
            consulta.Connection.Close()
            MsgBox("Mensaje enviado con éxito")
            Dim it As ListViewItem = Form1.ListView1.Items.Add(sigId.ToString)
            it.SubItems.Add(txtFecha.Text)
            it.SubItems.Add(txtMensaje.Text)

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
            consulta.Connection.Close()
        End Try
    End Sub

    Private Function CalcularSiguienteId() As Integer
        Dim con As New SqlConnection(cadena)
        con.Open()
        Dim id = New SqlCommand("SELECT MAX(idmensaje) from Foro.MENSAJES", con).ExecuteScalar
        con.Close()
        Return id + 1
    End Function

    Private Sub FrmNuevoMensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yy")
        txtUsuario.Text = IdActual
    End Sub

End Class