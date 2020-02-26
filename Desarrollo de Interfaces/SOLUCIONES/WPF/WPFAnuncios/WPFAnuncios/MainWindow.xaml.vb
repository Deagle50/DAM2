Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Grid1.DataContext = New MainViewModel(modelo)
    End Sub

    Private Sub ListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If sender.SelectedItem IsNot Nothing Then
            Dim ventana As New Anuncios
            ventana.MiAnunciante = sender.SelectedItem
            ventana.Show()
        End If
    End Sub
End Class
