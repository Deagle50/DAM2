Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As New SqlCommand("Insert INTO GUI1.Vehiculos (IdVehiculo,Descripcion,Antelacion) Values(@id,@Des,@ant)")
        consulta.Connection = con
        consulta.Parameters.AddWithValue("@id", txtVehiculo.Text)
        consulta.Parameters.AddWithValue("@Des", txtDescripcion.Text)
        consulta.Parameters.AddWithValue("@ant", txtAntelacion.Text)
        consulta.ExecuteNonQuery()
        Form1.txtAntelacion.Text = txtAntelacion.Text
        Form1.txtDescripcion.Text = txtDescripcion.Text
        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtVehiculo.Text = actual.ToString
    End Sub
End Class