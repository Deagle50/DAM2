Class MainWindow
    Dim vm As New MainViewModel
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        vm.ModeloDatos = ModeloDatos
        Grid1.DataContext = vm
        vm.NuevaFactura()
        vm.NuevaLinea()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        vm.FinLinea()
        vm.NuevaLinea()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As RoutedEventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click
        vm.AgregarArticulo(sender.DataContext)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim v As New Window1
        v.ShowDialog()
    End Sub
End Class
