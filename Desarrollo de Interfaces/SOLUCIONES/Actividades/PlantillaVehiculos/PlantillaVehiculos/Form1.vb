Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As New SqlCommand("SELECT IdVehiculo,Descripcion,Antelacion FROM GUI1.Vehiculos WHERE idVehiculo=@id")
        actual = CInt(txtVehiculo.Text)
        consulta.Connection = con
        consulta.Parameters.AddWithValue("@id", txtVehiculo.Text)
        con.Open()
        Dim dr As SqlDataReader
        dr = consulta.ExecuteReader()
        If dr.Read Then
            txtVehiculo.Text = dr("IdVehiculo").ToString
            txtDescripcion.Text = dr("Descripcion").ToString
            txtAntelacion.Text = dr("Antelacion")
            dr.Close()
            InicializarDataSet(CInt(txtVehiculo.Text).ToString)
            LlenarListView(ds)

        Else
            dr.Close()
            Dim resp As MsgBoxResult
            resp = MsgBox("Está seguro?", vbYesNo)
            If resp = vbYes Then
                Form2.ShowDialog()
                InicializarDataSet(CInt(txtVehiculo.Text))
            End If
        End If

        con.Close()

    End Sub

    Private Sub LlenarListView(ds As DataSet)
        For Each row As DataRow In ds.Tables("Inspecciones").Rows
            Dim it As ListViewItem = ListView1.Items.Add(row("IdRevision"))
            it.SubItems.Add(row("Fecha").ToString)
            If row("Realizada") Then
                it.SubItems.Add("Realizada")
            Else
                it.SubItems.Add("Pendiente")
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As DataRow = ds.Tables("Inspecciones").NewRow
        row.BeginEdit()
        row("IdVehiculo") = CInt(txtVehiculo.Text)
        row("IdRevision") = MaxId(CInt(txtVehiculo.Text))
        row("Fecha") = Date.Now.AddDays(CInt(txtAntelacion.Text))
        row("Realizada") = False
        row.EndEdit()
        ds.Tables("Inspecciones").Rows.Add(row)
        da.Update(ds, "Inspecciones")
        Dim it As ListViewItem = ListView1.Items.Add(row("IdRevision").ToString)
        it.SubItems.Add(row("Fecha").ToString)
        it.SubItems.Add("Pendiente")
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim res As MsgBoxResult
        res = MsgBox("Desea realizar", vbYesNo)
        If res = vbYes Then
            If ListView1.SelectedItems.Count <> 0 Then
                Dim id = ListView1.SelectedItems(0).Text
                Dim pk(1) As Object
                pk(0) = id
                pk(1) = CInt(txtVehiculo.Text)
                Dim r As DataRow = ds.Tables("Inspecciones").Rows.Find(pk)
                r("Realizada") = True
                ListView1.SelectedItems(0).SubItems(2).Text = "Realizada"
                da.Update(ds, "Inspecciones")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta As New SqlCommand("Delete from Gui1.Vehiculos WHERE IdVehiculo=@id")
        consulta.Connection = con
        consulta.Parameters.AddWithValue("@id", txtVehiculo.Text)

        If ds.Tables("Inspecciones").Rows.Count = 0 Then
            con.Open()
            consulta.ExecuteNonQuery()
            con.Close()
        Else
            For Each r As DataRow In ds.Tables("Inspecciones").Rows
                r.Delete()
            Next
            da.Update(ds, "Inspecciones")
            con.Open()
            consulta.ExecuteNonQuery()
            con.Close()
        End If
    End Sub
End Class
