Public Class Form1
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim tam As Integer = txtNumero.Text
        For i = tam To 0 Step -1
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub
End Class