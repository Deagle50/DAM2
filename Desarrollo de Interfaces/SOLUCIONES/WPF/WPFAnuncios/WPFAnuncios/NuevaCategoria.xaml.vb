Public Class NuevaCategoria
    Dim nueva As New CategoriaViewModel(modelo)
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        nueva.Agregar()
        Me.Close()
    End Sub

    Private Sub NuevaCategoria_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Grid1.DataContext = nueva
    End Sub
End Class
