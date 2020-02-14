Class MainWindow 

Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
    Dim peli As Pelicula = Resources("filmInfiltrados")
    peli.Title = "Titanic"
    peli.award = True
    peli.rate = 8.0
    peli.Genre = Generos.Catastrofismo
MsgBox(peli.Title)
End Sub
End Class
