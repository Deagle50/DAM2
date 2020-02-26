Imports TrabajadoresWPF.TrabajadoresWPF

Public Class Window1

    Dim viewModel As window1ViewModel
    Public Sub New(Trabajador As Trabajadores)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        viewModel = New window1ViewModel(Modelo, Trabajador)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub BtnEntrar_Click(sender As Object, e As RoutedEventArgs) Handles btnEntrar.Click
        viewModel.Entrar()
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        viewModel.Salir()
        Me.Close()

    End Sub
End Class
