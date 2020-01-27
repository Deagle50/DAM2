Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reservas As Object
        reservas = (From rv In modelo.Reservas
                    Where rv.CodViajero = CInt(txtCodviajero.Text)
                    Select rv.CodReserva, rv.CodViaje, rv.Viajes.Destino, rv.Precio).ToList

        LlenarListview(ListView1, reservas)
    End Sub
    Private Sub LlenarListview(listView1 As ListView, res As Object)
        listView1.Items.Clear()

        For Each elem In res
            Dim it As ListViewItem = listView1.Items.Add(elem.codviaje)
            it.SubItems.Add(elem.CodReserva.ToString)
            it.SubItems.Add(elem.Codviaje.ToString)
            it.SubItems.Add(elem.destino)
            it.SubItems.Add(elem.Precio.ToString)
        Next
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.SelectedItems.Count <> 0 Then
            Dim codreserva As Integer = ListView1.SelectedItems(0).Text
            Dim rv As Linq2.Reservas = (From r In modelo.Reservas
                                        Where r.CodReserva = codreserva
                                        Select r).FirstOrDefault
            modelo.Reservas.Remove(rv)
            modelo.SaveChanges()
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class