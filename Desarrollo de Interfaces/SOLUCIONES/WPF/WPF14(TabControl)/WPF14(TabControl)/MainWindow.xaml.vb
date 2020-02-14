Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        tab.ItemsSource = modelo.Employees.ToArray
    End Sub
End Class
