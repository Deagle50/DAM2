Class MainWindow
    Dim objetoViewModel As ViewModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        objetoViewModel = New ViewModel
        Grid.DataContext = objetoViewModel
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        objetoViewModel.Buscar()
    End Sub
End Class
