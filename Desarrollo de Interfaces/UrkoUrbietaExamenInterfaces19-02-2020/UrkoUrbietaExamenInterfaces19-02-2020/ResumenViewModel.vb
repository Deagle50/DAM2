Public Class ResumenViewModel
    Dim Rmodelo As New UrkoUrbietaExamenInterfaces19_02_2020.DAM_urkourbieta_DEVEntities


    Public ReadOnly Property totalVentas As Integer
        Get
            Return Rmodelo.Ventas.Count
        End Get
    End Property

    Public ReadOnly Property resumen As UrkoUrbietaExamenInterfaces19_02_2020.DAM_urkourbieta_DEVEntities
        Get
            Dim res As UrkoUrbietaExamenInterfaces19_02_2020.DAM_urkourbieta_DEVEntities = (From prod In modelo.Productos
                                                                                            Group By desc = prod.descripcion, cuenta = prod.descripcion.Count, importe = prod.precio'Suma
                                                                                             Select desc, cuenta, importe
                                                                                             )
            Return res
        End Get
    End Property
End Class
