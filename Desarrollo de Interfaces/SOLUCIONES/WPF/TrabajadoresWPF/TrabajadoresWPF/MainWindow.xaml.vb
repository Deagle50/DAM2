Class MainWindow

    Dim viewModel As mainViewModel

    Private Sub BtnResumen_Click(sender As Object, e As RoutedEventArgs) Handles btnResumen.Click
        viewModel = New mainViewModel(Modelo)
        gridMain.DataContext = viewModel
    End Sub

    Private Sub Listbox_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles listbox.MouseDoubleClick
        Dim ventana As New Window1(listbox.SelectedItem)
        ventana.ShowDialog()
        viewModel = New mainViewModel(Modelo)
        gridMain.DataContext = viewModel
    End Sub
End Class
