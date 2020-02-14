Class MainWindow

    Private Sub Image1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image1.PreviewMouseDown
        MsgBox("Imagen")
    End Sub


    Private Sub Button1_previewMouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Button1.PreviewMouseDown
        MsgBox("Botón")

    End Sub

    Private Sub Grid1_PreviewMouseDown(sender As Object, e As MouseButtonEventArgs) Handles Grid1.PreviewMouseDown
        MsgBox("Grid")
        e.Handled = True
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Button1.MouseDown
        MsgBox("Botón Directo")
    End Sub
    Private Sub Grid1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Grid1.MouseDown
        MsgBox("Grid Directo")
    End Sub
End Class
