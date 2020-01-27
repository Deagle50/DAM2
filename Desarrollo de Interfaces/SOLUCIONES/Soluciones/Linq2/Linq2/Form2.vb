Imports System.IO

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v As Linq2.Viajeros
        v = (From vj In modelo.Viajeros
             Where vj.CodViajero = txtViajero.Text
             Select vj).FirstOrDefault
        If v Is Nothing Then
            Form3.Show()
        End If
        Dim r As New Linq2.Reservas
        r.CodReserva = CInt(txtReserva.Text)
        r.CodViaje = CInt(txtViaje.Text)
        r.CodViajero = CInt(txtViajero.Text)
        r.Precio = txtPrecio.Text
        modelo.Reservas.Add(r)
        modelo.SaveChanges()
        Dim sw As New StreamWriter("Reserva " + txtReserva.Text)
        Dim nombre As String = (From vj In modelo.Viajeros
                                Where vj.CodViajero = txtViajero.Text
                                Select nom = vj.Nombre).First
        sw.WriteLine("Reserva:{0}", txtReserva.Text)
        sw.WriteLine("Fecha Ida:{0} Fecha Regreso:{1}", Form1.ListView1.SelectedItems(0).SubItems(3).Text, Form1.ListView1.SelectedItems(0).SubItems(4).Text)
        sw.WriteLine("Viajero: {0}", nombre)
        sw.WriteLine("Destino: {0}", Form1.ListView1.SelectedItems(0).SubItems(1).Text)
        sw.Close()
        Dispose()
    End Sub
End Class