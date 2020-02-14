Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim nuevo As New Boton("Acept", "Cancel", "Retry")
        Panel1.DataContext = nuevo
    End Sub
End Class
