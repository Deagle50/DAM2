Public Class InmueblesUsuarioActual

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Grid1.DataContext = usuarioActual
    End Sub



    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim frm As New FotoWindow(inmuebleActual)
        frm.ShowDialog()
    End Sub



    Private Sub CmbInmuebles_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles CmbInmuebles.SelectionChanged
        inmuebleActual = CmbInmuebles.SelectedItem
    End Sub
End Class
