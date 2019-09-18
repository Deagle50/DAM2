Public Class CalculadoraMinions
    Dim CantidadAConseguir As Integer
    Dim CantidadXAccion As Double = 1
    Dim TiempoXAccion As Integer
    Dim MinionsCLava As Integer
    Dim MinionsSLava As Integer
    Dim Dias As Double




    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        txtMinionsCLava.Text = 0
        txtMinionsSLava.Text = 0
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        CantidadAConseguir = txtCantidad.Text
        CantidadXAccion = txtCantidadXAccion.Text
        TiempoXAccion = txtTiempoXAccion.Text
        If txtMinionsCLava.Text <> 0 Then
            MinionsCLava = txtMinionsCLava.Text
        End If
        If txtMinionsSLava.Text <> 0 Then
            MinionsSLava = txtMinionsSLava.Text
        End If

        If MinionsSLava <> 0 And MinionsCLava <> 0 Then
            Dias = CantidadAConseguir / ((1440 * 60 / TiempoXAccion * CantidadXAccion * MinionsCLava * 1.25) + (1440 * 60 / TiempoXAccion * CantidadXAccion * MinionsSLava * 1))
        ElseIf MinionsSLava = 0 And MinionsCLava <> 0 Then
            Dias = CantidadAConseguir / (1440 * 60 / TiempoXAccion * CantidadXAccion * MinionsCLava * 1.25)
        ElseIf MinionsSLava <> 0 And MinionsCLava = 0 Then
            Dias = CantidadAConseguir / (1440 * 60 / TiempoXAccion * CantidadXAccion * MinionsSLava * 1)
        End If

        txtResultado.Text = Dias
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CantidadAConseguir = 0
        CantidadXAccion = 1
        TiempoXAccion = 0
        MinionsCLava = 0
        MinionsSLava = 0
        Dias = 0
        txtCantidad.Text = CantidadAConseguir
        txtCantidadXAccion.Text = CantidadXAccion
        txtTiempoXAccion.Text = TiempoXAccion
        txtMinionsCLava.Text = MinionsCLava
        txtMinionsSLava.Text = MinionsSLava
        txtResultado.Text = Dias
    End Sub
End Class
