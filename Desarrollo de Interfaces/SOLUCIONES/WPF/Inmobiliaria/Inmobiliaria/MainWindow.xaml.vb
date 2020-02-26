Class MainWindow
    Dim viewmodel As New MainViewModel(modelo)
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        viewmodel.Validar()
        If (viewmodel.Usuario Is Nothing) Then
            MsgBox("Usuario o contraseña incorrecta")
        Else
            Dim Siguiente As New InmueblesUsuarioActual
            usuarioActual = viewmodel.Usuario
            Siguiente.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        grid1.DataContext = viewmodel
    End Sub
End Class
