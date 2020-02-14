Class MainWindow
    Private Sub CommandBinding_CanExecute(sender As Object, e As CanExecuteRoutedEventArgs)
        e.CanExecute = txtCantidad.Text.Length <> 0
    End Sub

    Private Sub CommandBinding_Executed(sender As Object, e As ExecutedRoutedEventArgs)
        txtDolares.Text = CDbl(txtCantidad.Text) * 1.25
    End Sub
End Class
