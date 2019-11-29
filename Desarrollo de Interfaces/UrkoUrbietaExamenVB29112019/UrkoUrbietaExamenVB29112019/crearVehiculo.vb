Public Class crearVehiculo
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        con.Open()
        Dim descripcion As String
        Dim antelacion As Integer

        Dim tr As SqlTransaction = con.BeginTransaction
        Dim consulta As New SqlCommand

        If txtDescripcion.Text = "" Then
            descripcion = "Descripción por defecto"
        Else
            descripcion = txtDescripcion.Text
        End If
        If txtAntelacion.Text = "" Then
            antelacion = 1
        Else
            antelacion = CInt(txtAntelacion.Text)
        End If
        If txtIdVehiculo.Text = "" Then
            txtIdVehiculo.Text = idVehiculoActual

        Else
            idVehiculoActual = CInt(txtIdVehiculo.Text)
        End If

        '
        'VALIDAR IDVEHICULO EN USO
        '

        Try
            consulta.CommandText = "INSERT INTO GUI1.Vehiculos (IdVehiculo, Descripcion, Antelacion) values (@parID, @parDesc, @parAnt)"
            consulta.Parameters.AddWithValue("@parID", idVehiculoActual)
            consulta.Parameters.AddWithValue("@parDesc", descripcion)
            consulta.Parameters.AddWithValue("@parAnt", antelacion)
            consulta.Connection = con
            consulta.Transaction = tr
            consulta.ExecuteNonQuery()
            tr.Commit()
            MsgBox("Vehículo agregado con éxito")
        Catch
            MsgBox("Error inesperado, operación cancelada")
            tr.Rollback()
        Finally
            con.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Sub crearVehiculo_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtIdVehiculo.Text = idVehiculoActual
    End Sub
End Class