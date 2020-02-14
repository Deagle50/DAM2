Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Grid1.DataContext = New MainViewModel(1)


    End Sub
End Class
