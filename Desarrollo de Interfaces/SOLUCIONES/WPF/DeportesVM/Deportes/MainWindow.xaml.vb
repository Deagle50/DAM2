Class MainWindow
    Dim objeto As New MainViewModel
    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As New Votaciones
        ventana.ShowDialog()
        objeto.Votar(ventana.Elegido)
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Grid1.DataContext = objeto
    End Sub
End Class
