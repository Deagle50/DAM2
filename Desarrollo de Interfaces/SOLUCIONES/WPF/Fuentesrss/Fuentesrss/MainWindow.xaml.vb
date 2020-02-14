Class MainWindow 

 
    Private Sub Lista_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles Lista.SelectionChanged
        Contenido.DataContext = Lista.SelectedItem
    End Sub
End Class
