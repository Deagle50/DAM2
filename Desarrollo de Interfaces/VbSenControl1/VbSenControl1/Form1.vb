Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim A As Integer
        Dim B As Integer
        Dim cant As Integer = 0
        A = txtA.Text
        B = txtB.Text

        If B > A Then
            For I = A To B
                If I Mod 2 = 1 Then
                    Console.WriteLine(I)
                End If
            Next
        ElseIf A > B Then
            For I = B To A Step 1
                If I Mod 2 = 1 Then
                    Console.WriteLine(I)
                End If
            Next
        Else
            Console.WriteLine("Son iguales")
        End If
    End Sub
End Class
