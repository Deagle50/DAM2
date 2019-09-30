Public Class Form3

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim tope As Integer = txtNumero.Text
        Console.Write("Numero Cuadrado Cubo")
        For i = 0 To tope
            Console.WriteLine(i & " " & i * i & " " & i * i * i)
        Next
    End Sub

End Class