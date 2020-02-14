Public Class Window1ViewModel
    Dim Modelo As DaniDBEntities
    Public Sub New(model As DaniDBEntities)
        Modelo = model
    End Sub

    Public ReadOnly Property Articulos() As List(Of Articulos)
        Get
            Return Modelo.Articulos.ToList
        End Get

    End Property
End Class
