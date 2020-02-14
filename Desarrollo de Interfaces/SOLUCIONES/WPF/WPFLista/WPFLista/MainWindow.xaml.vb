Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim c As New List(Of Alumno)
        c.Add(New Alumno("Mikel", "Aierdi", 1))
        c.Add(New Alumno("Joseba", "Etxeberria", 2))
        c.Add(New Alumno("Daniel", "Miguel", 3))
        Lista.ItemsSource = c
    End Sub
End Class
