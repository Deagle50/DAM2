Class MainWindow
    Dim objeto As New Conversor

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        objeto.ConvertirFarenheit()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        objeto.ConvertirCentigrados()
    End Sub

    Private Sub TxtFaren_TextChanged(sender As Object, e As TextChangedEventArgs)
        objeto.FarentoCenti = True

    End Sub

    Private Sub TxtCenti_TextChanged(sender As Object, e As TextChangedEventArgs)
        objeto.CentitoFaren = True
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Layout.DataContext = objeto
    End Sub
End Class
