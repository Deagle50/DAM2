Public Class Anuncios
    Dim _anunciante As WPFAnuncios.Anunciantes
    Dim viewmodel As AnunciosViewModel
    Public Property MiAnunciante As WPFAnuncios.Anunciantes
        Get
            Return _anunciante
        End Get
        Set(value As WPFAnuncios.Anunciantes)
            _anunciante = value
        End Set
    End Property

    Private Sub Anuncios_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        viewmodel = New AnunciosViewModel(modelo)
        viewmodel.Anunciante = MiAnunciante
        Grid1.DataContext = viewmodel
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        viewmodel.Siguiente()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        viewmodel.Anterior()
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        viewmodel.Eliminar()
    End Sub
End Class
