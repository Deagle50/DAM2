Class MainWindow 




    Private Sub MainWindow_PreviewMouseMove(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs)
        TB.Text = "(" + e.GetPosition(Me).X.ToString + "," + e.GetPosition(Me).Y.ToString + ") : " + e.Source.GetType().Name
        e.Handled = True
    End Sub

    Private Sub Tb_PreviewMouseMove(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles TB.PreviewMouseMove
        TB.Text = "Fin de la cuestion"
        e.Handled = True
    End Sub



    Private Sub Window_MouseDown(sender As Object, e As MouseButtonEventArgs)
        MsgBox("Se pulsó ventana")

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        MsgBox("Aceptar")

    End Sub
End Class