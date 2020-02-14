Class MainWindow
    Dim azul As Boolean
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If azul Then
            sender.Background = Brushes.Red
            azul = False
        Else
            sender.Background = Brushes.Blue
            azul = True
        End If
    End Sub
End Class
