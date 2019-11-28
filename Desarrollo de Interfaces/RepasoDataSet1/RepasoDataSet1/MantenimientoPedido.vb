Public Class MantenimientoPedido
    Dim r As DataRow
    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("Estás seguro?", vbYesNo)
        If (resp = vbYes) Then
            r.Delete()
            daProductos.Update(datast, "productos")
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        r = datast.Tables("productos").Rows.Find(txtPedido.Text)
        If r Is Nothing Then
            MsgBox("El producto no existe")
        Else

        End If
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        r.BeginEdit()
        r("id_producto") = CInt(txtPedido.Text)
        r("descripcion") = txtDescripcion.Text
        r("pvp") = txtPrecioTotalLinea.Text
        r.EndEdit()

        datast.Tables("productos").Rows.Add(r)
        daProductos.Update(datast, "productos")
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        r.BeginEdit()
        r("descripcion") = txtDescripcion.Text
        r("pvp") = txtPrecioTotalLinea.Text
        r.EndEdit()
        daProductos.Update(datast, "productos")
    End Sub
End Class