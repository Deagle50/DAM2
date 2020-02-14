Class MainWindow
    Dim palabras As New List(Of String)

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        palabras.Add("Uno")
        palabras.Add("Dos")
        palabras.Add("Tres")
        Lista.ItemsSource = palabras

    End Sub
End Class
