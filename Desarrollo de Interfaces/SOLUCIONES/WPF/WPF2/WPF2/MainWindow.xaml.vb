Class MainWindow
    Dim azul As Boolean = True
    Private Sub miBoton_Click(sender As Object, e As RoutedEventArgs)
        If azul Then
            miBoton.Background = Brushes.Red
        Else
            miBoton.Background = Brushes.Blue
        End If
        azul = Not azul
    End Sub


End Class
