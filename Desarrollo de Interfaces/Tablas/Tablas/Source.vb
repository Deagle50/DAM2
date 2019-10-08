Public Class Source
    Private Sub Source_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub BtnTraducir_Click(sender As Object, e As EventArgs) Handles btnTraducir.Click
        Dim encontrado As Boolean = False
        Dim i As Integer = 0
        Dim palabra As String = txtPalabra.Text
        While encontrado = False And i < tabla.GetLength()
            If tabla(i, 0) = palabra Then
                encontrado = True
            End If
        End While
        If encontrado = True Then
            txtSignificado.Text = tabla(i, 1)
        Else

        End If
    End Sub
End Class
