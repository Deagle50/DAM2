Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Object
        res = (From v In modelo.Viajes
               Let ocupadas = v.Reservas.Count
               Where v.PlazasMax > ocupadas And v.FechaSalida >= CDate(txtFechaInicio.Text) And v.FechaRegreso <= CDate(txtFechaFin.Text)
               Select v.CodViaje, v.Destino, Plazas = v.PlazasMax - ocupadas, v.FechaSalida, v.FechaRegreso).ToList
        LlenarListview(ListView1, res)
    End Sub

    Private Sub LlenarListview(listView1 As ListView, res As Object)
        listView1.Items.Clear()

        For Each elem In res
            Dim it As ListViewItem = listView1.Items.Add(elem.codviaje)
            it.SubItems.Add(elem.Destino.ToString)
            it.SubItems.Add(elem.Plazas.ToString)
            it.SubItems.Add(elem.fechaSalida.ToString)
            it.SubItems.Add(elem.fecharegreso.ToString)
        Next
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count <> 0 Then
            Form2.txtReserva.Text = modelo.Reservas.Select(Function(x) x.CodReserva).Max + 1
            Form2.txtViaje.Text = ListView1.SelectedItems(0).Text
            Form2.ShowDialog()
            Dim it As Integer = CInt(ListView1.SelectedItems(0).Text)
            Dim v As Linq2.Viajes = (From vj In modelo.Viajes
                                     Where vj.CodViaje = it
                                     Select vj).First
            If v.PlazasMax - v.Reservas.Count = 0 Then
                ListView1.Items.Remove(ListView1.SelectedItems(0))
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RealizarViaje()
    End Sub
End Class
