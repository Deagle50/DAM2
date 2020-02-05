Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        comboboxUsuarios.ItemsSource = modelo.Usuarios.ToArray
    End Sub
End Class
