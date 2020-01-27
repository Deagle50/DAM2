Imports System.IO

Module Module1
    Public modelo As New Linq2.DaniDBEntities
    Public Sub RealizarViaje()
        Dim res As Object
        res = (From v In modelo.Viajes
               Select v.CodViaje, v.PlazasMin, v.FechaRegreso, v.FechaSalida, piloto = v.Pilotos.Nombre, v.Destino, Total = v.Reservas.Count, v.Reservas).ToList
        Dim salidaViajes, salidaBorrados As StreamWriter
        salidaViajes = New StreamWriter("viajes.txt")
        salidaBorrados = New StreamWriter("Borrados.log")
        For Each v In res
            'Imprime los viajes que tienen plazas suficientes
            If (v.total > v.plazasMin) Then
                salidaViajes.WriteLine("Fecha Ida= {0}  Fecha Vuelta={1}", v.FechaSalida, v.FechaRegreso)
                salidaViajes.WriteLine("Destino: {0}  Piloto: {1}", v.Destino, v.Piloto)
                salidaViajes.WriteLine("{0,11}  {1,11}  {2,15}", "COD VIAJERO", "COD RESERVA", "NOMBRE")
                For Each r In v.Reservas
                    salidaViajes.WriteLine("{0,11}  {1,11}  {2,15}", r.codviajero, r.codReserva, r.Viajeros.Nombre)
                Next
                salidaViajes.WriteLine("Total: {0}", v.total)
            Else
                'Borra los viajes que no tienen suficientes viajeros
                salidaBorrados.WriteLine("Se borró el viaje {0}", v.Codviaje)
                Dim codigo As Integer = v.codviaje
                Dim borrado As Linq2.Viajes = modelo.Viajes.Where(Function(x) x.CodViaje = codigo).First
                For Each reserva In v.reservas
                    v.reservas.remove(reserva)
                Next
                modelo.Viajes.Remove(borrado)
                modelo.SaveChanges()
            End If
        Next
        salidaBorrados.Close()
        salidaViajes.Close()
    End Sub
End Module
