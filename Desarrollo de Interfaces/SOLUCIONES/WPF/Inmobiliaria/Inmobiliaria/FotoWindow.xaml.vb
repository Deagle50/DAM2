Imports Microsoft.Win32
Imports System.IO
Public Class FotoWindow
    Dim viewmodel As FotoWindowViewModel
    Public Sub New(inm As Inmuebles)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim fo As New OpenFileDialog
        If fo.ShowDialog Then
            viewmodel.Foto = File.ReadAllBytes(fo.FileName)
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        viewmodel = New FotoWindowViewModel(inmuebleActual, modelo)
        grid1.DataContext = viewmodel
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        viewmodel.Agregar()
    End Sub
End Class
