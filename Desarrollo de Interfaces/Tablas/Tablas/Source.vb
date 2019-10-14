Public Class Source
    Private Sub Source_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub BtnTraducir_Click(sender As Object, e As EventArgs) Handles btnTraducir.Click

        Dim i As Integer = 0
        For i = 0 To cont - 1
            If Diccionario(i).palabra = txtPalabra.Text Then
        Next
        ReDim Preserve diccionario(cont)
        diccionario(cont).palabra = txtPalabra.Text
        diccionario(cont).traduccion = InputBox("Trac")
    End Sub
End Class
