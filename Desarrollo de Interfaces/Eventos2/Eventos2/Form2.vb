Public Class Form2
    Dim num As Integer
    Dim cont As Integer
    Private Sub BtnIntro_Click(sender As Object, e As EventArgs) Handles btnIntro.Click

        num = txt1.Text
        txt1.Enabled = False
        txt2.Enabled = True
        cont = 0
    End Sub

    Private Sub BtnAdivinar_Click(sender As Object, e As EventArgs) Handles btnAdivinar.Click
        Dim num2 As Integer
        num2 = txt2.Text
        If num <> num2 Then
            MsgBox("")
        End If
    End Sub


End Class