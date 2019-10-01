Public Class Form2
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num As Integer = txtNumero.Text
        Dim primo As Boolean = False
        Dim i As Integer = 1
        Dim j As Integer = 1
        While i < num
            primo = True
            For j = 1 To i - 1
                If i Mod j = 0 Then
                    primo = False
                End If
            Next
            If primo = True Then
                Console.WriteLine(i)
            End If
            i = i + 1
        End While
    End Sub
End Class