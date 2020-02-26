Imports System.IO

Public Class NuevoAnuncio

    Dim nuevo As AltaViewModel
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim dialogo As New Microsoft.Win32.OpenFileDialog
        If dialogo.ShowDialog Then
            nuevo.Foto = File.ReadAllBytes(dialogo.FileName)
        End If
    End Sub

    Private Sub NuevoAnuncio_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        nuevo = New AltaViewModel(modelo)
        Grid1.DataContext = nuevo
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        nuevo.Insertar()
    End Sub
End Class
