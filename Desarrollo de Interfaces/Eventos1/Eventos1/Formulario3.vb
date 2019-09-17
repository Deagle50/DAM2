Public Class Formulario3
    Dim max As Integer = 0
    Dim min As Integer = 999999
    Dim media As Double = 0
    Dim total As Integer = 0
    Dim cont As Integer = 0
    Dim num As Integer = 0

    Private Sub BtnIntro_Click(sender As Object, e As EventArgs) Handles btnIntro.Click
        num = txtN.Text
        If num > max Then
            max = num
        End If
        If num < min Then
            min = num
        End If
        cont += 1
        total += num
        media = total / cont
        txtMaximo.Text = max
        txtMinimo.Text = min
        txtMedia.Text = media
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        max = 0
        min = 999999
        media = 0
        total = 0
        cont = 0
        num = 0
        txtMaximo.Text = ""
        txtMinimo.Text = ""
        txtMedia.Text = ""
        txtN.Text = ""
    End Sub
End Class