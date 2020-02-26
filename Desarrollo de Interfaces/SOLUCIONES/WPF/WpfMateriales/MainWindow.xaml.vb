Class MainWindow
    Dim ViewModel As New MainViewModel(modelo)
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        '•	Al pulsar el botón ver resumen Creará un objeto de la clase MainViewModel 
        'creada en 1 y lo establecerá como datacontext del grid.

        Grid1.DataContext = ViewModel
    End Sub

    '•	El otro control de la pantalla será un listbox. Mediante enlace de datos deberá visualizar la descripción y la marca de todos los materiales,
    'mostrando además la descripción del estado correspondiente


    Private Sub ListBox_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        '•	Al hacer doble click en la lista mostrará el formulario Window1 que se explica en el ejercicio 4, 
        'pasando el elemento elegido a dicho formulario.
        Dim f As New Window1(lb.SelectedItem)
        f.ShowDialog()
        ViewModel = New MainViewModel(modelo)
        Grid1.DataContext = ViewModel
    End Sub
End Class
