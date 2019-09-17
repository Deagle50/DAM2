Public Class Formulario2
    Dim cant1 As Integer = 0
    Dim cant2 As Integer = 0


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtNumero.Text = "uno"
        cant1 += 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtNumero.Text = "dos"
        cant2 += 1
    End Sub

    Private Sub BtnGanador_Click(sender As Object, e As EventArgs) Handles btnGanador.Click
        If cant1 > cant2 Then
            txtNumero.Text = "El 1 es el ganador"
        ElseIf cant2 > cant1 Then
            txtNumero.Text = "El 2 es el ganador"
        Else
            txtNumero.Text = "Empate"
        End If
        cant1 = 0
        cant2 = 0
    End Sub
End Class