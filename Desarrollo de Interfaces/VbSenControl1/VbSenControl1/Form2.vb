Public Class Form2
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim capital As Double = txtCapitalInicial.Text
        Dim interes As Double = txtInteres.Text
        Dim anos As Integer = txtAnos.Text
        For i = 1 To anos
            lbAno.Items.Add(i.ToString())
            capital = capital * (1.0 + interes / 100)
            lbCapital.Items.Add(capital.ToString)
        Next
    End Sub
End Class