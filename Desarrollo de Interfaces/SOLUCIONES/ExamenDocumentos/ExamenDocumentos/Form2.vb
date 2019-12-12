Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As New SqlCommand("INSERT INTO GUI1.Documentos(idDocumento,Titulo,FechaCreacion) VALUES(@id,@titulo,@fecha)")
        consulta.CommandType = CommandType.Text
        consulta.Connection = con
        consulta.Parameters.AddWithValue("@id", txtId.Text)
        consulta.Parameters.AddWithValue("@titulo", txtTitulo.Text)
        consulta.Parameters.AddWithValue("@fecha", DateTime.Now)
        con.Open()
        consulta.ExecuteNonQuery()
        con.Close()
        Me.Dispose()
    End Sub
End Class