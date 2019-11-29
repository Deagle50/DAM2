
Public Class frmPedido
    Private Sub frmPedido_Load(sender As Object, e As EventArgs) Handles Me.Load

        For Each r As DataRow In ds.Tables("Productos").Rows
            cmbProducto.Items.Add(r("Idproducto"))
        Next
        Dim idPedido As Integer = CalCularIdPedido()
        Dim fila As DataRow = ds.Tables("Pedidos").NewRow
        fila("Idpedido") = idPedido
        fila("fecha") = DateTime.Now

        txtIdPedido.Text = fila("IdPedido")
        txtFecha.Text = fila("Fecha")
        ds.Tables("Pedidos").Rows.Add(fila)
        daPedidos.Update(ds, "Pedidos")
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        Dim r As DataRow
        'Find busca por key, si fuera select se haría como un where
        r = ds.Tables("Productos").Rows.Find(CInt(cmbProducto.Text))
        txtPrecio.Text = r("Pvp")
    End Sub

    Private Sub txtUnidades_TextChanged(sender As Object, e As EventArgs) Handles txtUnidades.TextChanged
        Dim res As Double
        Dim uni As Integer

        If Double.TryParse(txtPrecio.Text, res) Then
            If Integer.TryParse(txtUnidades.Text, uni) Then
                txtTotalLinea.Text = res * uni
            Else
                MsgBox("Introduzca unidades")
            End If
        Else
            MsgBox("Seleccione un producto")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As DataRow
        'Nueva línea para añadir luego
        r = ds.Tables("LineasDetalle").NewRow

        'Añadir los datos a la línea
        r.BeginEdit()
        r("IdDetalle") = CalCularIdDetalle()
        r("IdPedido") = CInt(txtIdPedido.Text)
        r("idProducto") = CInt(cmbProducto.Text)
        r("unidades") = CInt(txtUnidades.Text)
        r("TotalLinea") = CDbl(txtTotalLinea.Text)
        r.EndEdit()
        'Añadir a la línea
        AgregarLista(r)

        'Actualizar LineasDetalle
        ds.Tables("LineasDetalle").Rows.Add(r)
        daLineas.Update(ds, "LineasDetalle")
    End Sub

    Private Sub AgregarLista(r As DataRow)
        Dim it As ListViewItem = ListView1.Items.Add(r("IdDetalle"))
        For i As Integer = 1 To ds.Tables("LineasDetalle").Columns.Count - 1
            it.SubItems.Add(r(i))
        Next
    End Sub

    Private Function CalCularIdDetalle()
        Dim consulta As New SqlCommand("SELECT max(IdDetalle) FROM compras.LineasDetalle", cn)
        cn.Open()
        Dim id As Object
        id = consulta.ExecuteScalar
        cn.Close()
        If IsDBNull(id) Then
            Return 1
        Else
            Return CInt(id) + 1
        End If

    End Function
    Private Function CalCularIdPedido()
        Dim consulta As New SqlCommand("SELECT max(IdPedido) FROM compras.Pedidos", cn)
        cn.Open()
        Dim id As Object
        id = consulta.ExecuteScalar
        cn.Close()
        If IsDBNull(id) Then
            Return 1
        Else
            Return CInt(id) + 1
        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As DataRow = ds.Tables("Pedidos").Rows.Find(CInt(txtIdPedido.Text))
        Dim total As Double = 0

        For Each fila As DataRow In r.GetChildRows("LineasPedido")
            total += fila("TotalLinea")
        Next

        txtTotalPVP.Text = total.ToString
        txtTotaliva.Text = (total * 0.21).ToString
        txtTotal.Text = (total * 1.21).ToString

        r.BeginEdit()
        r("TotalNeto") = CDbl(txtTotal.Text)
        r("totalIva") = CDbl(txtTotaliva.Text)
        r("TotalPagar") = CDbl(txtTotal.Text)
        r("Cerrado") = True
        r.EndEdit()

        daPedidos.Update(ds, "Pedidos")
    End Sub


End Class