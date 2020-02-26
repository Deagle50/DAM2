Public Class MainViewModel
    Private ModeloDatos As WPFAnuncios.DaniDBEntities
    Public Sub New(modelo As WPFAnuncios.DaniDBEntities)
        ModeloDatos = modelo
    End Sub
    Public ReadOnly Property ListaCategorias As List(Of WPFAnuncios.Categorias)
        Get
            Return ModeloDatos.Categorias.ToList
        End Get
    End Property

End Class
