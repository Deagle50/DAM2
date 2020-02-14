Class MainWindow
    Dim c As New List(Of Producto)()
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        c.Add(New Producto("Patata", "Comida", 1))
        c.Add(New Producto("Coliflor", "Comida", 2))
        c.Add(New Producto("Berza", "Comida", 3))
        Combo.ItemsSource = c
    End Sub
End Class
