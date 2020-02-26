Public Class Window1
    Dim viewModel As Window1ViewModel
    Public Sub New(actual As WpfMateriales.Materiales)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        viewModel = New Window1ViewModel(modelo, actual)
    End Sub

    Private Sub Grid_Loaded(sender As Object, e As RoutedEventArgs)
        Grid1.DataContext = viewModel
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        viewModel.Devolver()
        Me.Close()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        viewModel.Retirar()
        Me.Close()
    End Sub
End Class
