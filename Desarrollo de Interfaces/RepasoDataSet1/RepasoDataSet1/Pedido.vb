Public Class Pedido
    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Añadir productos al combo box (solo id)
        For Each r2 As DataRow In datast.Tables("Productos").Rows
            cmbProducto.Items.Add(r2("id_producto"))
        Next
        Dim idPedido As Integer = calcularUltimoIDPedido()
        Dim r As DataRow = datast.Tables("Pedidos").NewRow
        r.BeginEdit()
        r("id_pedido") = idPedido
        r("fecha") = Date.Now
        r.EndEdit()

        txtPedido.Text = r("id_pedido")
        txtFecha.Text = r("fecha")

        datast.Tables("Pedidos").Rows.Add(r)
        daPedidos.Update(datast, "pedidos")

    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        Dim r As DataRow
        r = datast.Tables("productos").Rows.Find(CInt(cmbProducto.Text))
        txtPrecio.Text = r("pvp")
    End Sub

    Private Sub txtUnidades_TextChanged(sender As Object, e As EventArgs) Handles txtUnidades.TextChanged
        Dim res As Double
        Dim uni As Integer
        If Double.TryParse(txtPrecio.Text, res) Then
            If Integer.TryParse(txtUnidades.Text, uni) Then
                txtPrecioTotalLinea.Text = res * uni
            Else
                MsgBox("Introduzca unidades")
            End If
        Else
            MsgBox("Seleccione un producto")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim r As DataRow

        r = datast.Tables("LineasDetalle").NewRow
        r.BeginEdit()
        r("id_detalle") = calcularUltimoIDDetalle()
        r("id_pedido") = CInt(txtPedido.Text)
        r("id_producto") = CInt(cmbProducto.Text)
        r("unidades") = CInt(txtUnidades.Text)
        r("total_linea") = CDbl(txtPrecioTotalLinea.Text)
        r.EndEdit()

        agregarLista(r)

        datast.Tables("LineasDetalle").Rows.Add(r)
        daDetalle.Update(datast, "LineasDetalle")
    End Sub

    Private Function calcularUltimoIDDetalle() As Integer
        Dim consulta As New SqlCommand("SELECT MAX(id_detalle) FROM LineasDetalle", con)
        Dim id As Object
        consulta.Connection = con
        con.Open()
        id = consulta.ExecuteScalar
        con.Close()
        If IsDBNull(id) Then
            Return -1
        Else
            Return CInt(id + 1)
        End If


    End Function

    Private Function calcularUltimoIDPedido() As Integer
        Dim consulta As New SqlCommand("SELECT MAX(id_pedido) FROM pedidos", con)
        Dim id As Object
        consulta.Connection = con
        con.Open()
        id = consulta.ExecuteScalar
        con.Close()
        If IsDBNull(id) Then
            Return -1
        Else
            Return CInt(id + 1)
        End If


    End Function

    Private Sub agregarLista(r As DataRow)

        Dim it As ListViewItem = lvPedido.Items.Add(r("id_detalle"))
        For i = 1 To datast.Tables("LineasDetalle").Columns.Count - 1
            it.SubItems.Add(r(i))
        Next

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim r As DataRow = datast.Tables("pedidos").Rows.Find(CInt(txtPedido.Text))
        Dim uds As Integer = 0
        Dim total As Double
        Dim precio As Double
        For Each fila As DataRow In r.GetChildRows("Lineas-pedido")
            total += r("Total_linea")
        Next
        txtTotalNeto.Text = total.ToString
        txtTotalva.Text = (total * 0.21).ToString
        txtTotalPagar.Text = (total * 1.21).ToString
        r.BeginEdit()
        r("total_neto") = CDbl(txtTotalNeto.Text)
        r("total_iva") = CDbl(txtTotalva.Text)
        r("total_pagar") = CDbl(txtTotalPagar.Text)
        r("cerrado") = True
        r.EndEdit()
        daPedidos.Update(datast, "pedidos")
    End Sub
End Class