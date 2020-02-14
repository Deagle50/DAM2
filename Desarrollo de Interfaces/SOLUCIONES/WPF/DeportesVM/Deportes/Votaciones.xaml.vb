Public Class Votaciones
    Public Elegido As Integer

    Private Sub RadioButton_Click(sender As Object, e As RoutedEventArgs)
        Elegido = 1
    End Sub

    Private Sub RadioButton_Click_1(sender As Object, e As RoutedEventArgs)
        Elegido = 0
    End Sub

    Private Sub RadioButton_Click_2(sender As Object, e As RoutedEventArgs)
        Elegido = 2
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
