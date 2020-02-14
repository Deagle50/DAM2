Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        grid1.DataContext = New ConversorViewModel
    End Sub
End Class
