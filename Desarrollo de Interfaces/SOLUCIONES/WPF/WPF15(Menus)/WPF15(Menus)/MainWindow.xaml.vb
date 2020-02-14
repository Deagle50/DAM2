Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        MainMenu.ItemsSource = modelo.Menus.Where(Function(x) x.Parent Is Nothing).ToArray
    End Sub
End Class
