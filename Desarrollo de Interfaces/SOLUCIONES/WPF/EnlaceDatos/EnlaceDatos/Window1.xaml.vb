Public Class Window1
    Dim vm As New Window1ViewModel(ModeloDatos)
    Private Sub Window1_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Grid1.DataContext = vm

    End Sub
End Class
