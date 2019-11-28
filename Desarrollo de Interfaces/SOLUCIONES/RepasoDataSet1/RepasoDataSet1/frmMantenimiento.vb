Public Class frmMantenimiento
    Dim r As DataRow
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        r = ds.Tables("Productos").Rows.Find(txtId.Text)
        If r Is Nothing Then
            MsgBox("El producto no existe")
            btnAlta.Enabled = True
            btnBaja.Enabled = False
            btnModificacion.Enabled = False
        Else
            btnAlta.Enabled = False
            btnBaja.Enabled = True
            btnModificacion.Enabled = True
            mostrar(r)
        End If
    End Sub

    Private Sub mostrar(r As DataRow)
        txtDescripcion.Text = r("Descripcion")
        txtPrecio.Text = r("PVP")
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        r = ds.Tables("Productos").NewRow
        r.BeginEdit()
        r("Idproducto") = CInt(txtId.Text)
        r("Descripcion") = txtDescripcion.Text
        r("PVP") = txtPrecio.Text
        r.EndEdit()
        ds.Tables("Productos").Rows.Add(r)
        daProductos.Update(ds, "Productos")
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("Está seguro", vbYesNo)

        If resp = vbYes Then
            r.Delete()
            daProductos.Update(ds, "Productos")
        End If

    End Sub

    Private Sub BtnModificacion_Click(sender As Object, e As EventArgs) Handles btnModificacion.Click
        r.BeginEdit()
        r("Descripcion") = txtDescripcion.Text
        r("PVP") = txtPrecio.Text
        r.EndEdit()
        daProductos.Update(ds, "Productos")
    End Sub
End Class