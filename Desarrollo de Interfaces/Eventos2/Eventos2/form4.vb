Public Class form4
    Dim unidades As Integer = txtUnidades.Text
    Dim precioUnidad As Double = txtPrecioUnidad.Text
    Dim descuento As Double = txtDescuento.Text
    Private Sub BtnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click

        Console.WriteLine("PRODUCTO  UNIDADES PRECIO %DTO IMPORTE")
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim udsXpre As Double = unidades * precioUnidad
        Dim udsCDesc As Double = unidades * precioUnidad * descuento / 100
        Dim importe As Double = unidades * precioUnidad * (1 - descuento / 100)
        txtImporte.Text = importe
        Console.WriteLine(txtProducto.Text + unidades + precioUnidad + descuento + importe)
        txtTotal.Text += importe
    End Sub
End Class