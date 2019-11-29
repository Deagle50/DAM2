Public Class principal

#Region "botones"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con As SqlConnection = New SqlConnection(cadena)
        Dim consulta As New SqlCommand
        Dim par1 As SqlParameter
        Dim datar As SqlDataReader
        Dim resp As MsgBoxResult
        Dim f As New crearVehiculo
        consulta.CommandText = "SELECT idVehiculo, Descripcion, Antelacion FROM GUI1.Vehiculos WHERE IdVehiculo = @par1"


        If Integer.TryParse(txtIdVehiculo.Text, idVehiculoActual) = True Then
            par1 = New SqlParameter
            par1.ParameterName = "@par1"
            par1.Value = idVehiculoActual
            par1.Direction = ParameterDirection.Input
            par1.SqlDbType = SqlDbType.Int

            consulta.Parameters.Add(par1)
            consulta.CommandType = CommandType.Text

            con.Open()
            consulta.Connection = con

            datar = consulta.ExecuteReader
            If datar.Read Then
                If Not IsDBNull(datar("idVehiculo")) Then
                    'llenarlista(datar)
                    txtDescripcion.Text = datar("Descripcion")
                    txtAntelacion.Text = datar("Antelacion")
                End If
            Else
                txtDescripcion.Text = ""
                txtAntelacion.Text = ""
                resp = MsgBox("No hay datos con ese id de vehículo, ¿desea crear uno?", vbYesNo)
                If resp = vbYes Then

                    f.Show()
                End If
            End If


            datar.Close()
            con.Close()
        Else
            MsgBox("Error, introduzca un número")
            Exit Sub
        End If
        'Intento de seleccionar no realizadas
        For Each r As DataRow In datast.Tables("Inspecciones").Select("IdInspeccion, Fecha, Realizada FROM GUI1.Inspecciones WHERE IdVehiculo = @id AND Realizada = 0")
            agregarLista(r)
        Next


    End Sub

    Private Sub BtnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click
        Dim r As DataRow
        r = datast.Tables("Inspecciones").NewRow

        r.BeginEdit()
        r("IdVehiculo") = idVehiculoActual
        r("Fecha") = Date.Now '+Días en antelación vehículo actual
        'r("IdRevision") = mayor Id inspección vehículo actual + 1
        r("Realizada") = 0
        r.EndEdit()

        agregarLista(r)

        datast.Tables("Inspecciones").Rows.Add(r)
        daInspecciones.Update(datast, "Inspecciones")

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim consultaBorrar As New SqlCommand("DELETE * FROM GUI1.Vehiculos WHERE IdVehiculo = @ID")
        Dim p As New SqlParameter
        Dim r As DataRow
        r = datast.Tables("Inspecciones").Rows.Find(idVehiculoActual)

        con.Open()
        consultaBorrar.CommandType = CommandType.Text
        consultaBorrar.Parameters.AddWithValue("@ID", idVehiculoActual)

        If r Is Nothing Then
            'Borrar si no hay inspecciones asociadas al vehículo
            consultaBorrar.ExecuteNonQuery()
        Else
            'Borrar inspecciones
            r.Delete()
            consultaBorrar.ExecuteNonQuery()
        End If
        con.Close()
    End Sub


#End Region

#Region "Otras funciones"
    Private Sub lvInspecciones_DoubleClick(sender As Object, e As EventArgs) Handles lvInspecciones.DoubleClick
        Dim resp As MsgBoxResult
        Dim r As DataRow = datast.Tables("Inspecciones").Rows.Find(CInt(lvInspecciones.SelectedItems(0).Text))
        resp = MsgBox("Va a cambiar el estado de realizado a verdadero, ¿continuar?", vbYesNo)
        If resp = vbYesNo Then
            r.BeginEdit()

            r("IdRevision") = CInt(lvInspecciones.SelectedItems(0).Text)
            r("IdVehiculo") = idVehiculoActual
            r("Fecha") = Date.Now '+Días en antelación vehículo actual
            r("Realizada") = 1

            r.EndEdit()

            'Borrar elemento anterior
            lvInspecciones.Items.RemoveAt(lvInspecciones.SelectedItems(0).Text)
            'Agregar elemento con datos actualizados
            agregarLista(r)
        Else
            MsgBox("No se han hecho cambios")
        End If
    End Sub
    Private Sub agregarLista(r As DataRow)
        Dim it As ListViewItem = lvInspecciones.Items.Add(r("IdRevision"))
        For i As Integer = 1 To datast.Tables("Inspecciones").Columns.Count - 1
            If i = datast.Tables("Inspecciones").Columns.Count - 1 Then
                If r("Realizada") = 0 Then
                    it.SubItems.Add("Pendiente")
                Else
                    it.SubItems.Add("Realizada")
                End If
            Else
                it.SubItems.Add(r(i))
            End If



        Next
    End Sub

#End Region
End Class
