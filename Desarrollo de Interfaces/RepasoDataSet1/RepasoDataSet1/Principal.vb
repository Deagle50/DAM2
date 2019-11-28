Public Class Principal

    Dim r As DataRow
    Dim tabla As DataTable = datast.Tables("pedidos")
    Private Sub NuevoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem.Click
        Pedido.Show()

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        inicializarDataSet()
    End Sub

    Private Function calcularUltimoIDProducto() As Integer
        Dim consulta As New SqlCommand("SELECT MAX(id_producto) FROM productos")


        Dim id As Object
        consulta.Connection = con
        id = consulta.ExecuteScalar
        If IsDBNull(id) Then
            Return -1
        Else
            Return CInt(id + 1)
        End If
    End Function

    Private Sub MantenimientoProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoProductosToolStripMenuItem.Click
        MantenimientoPedido.Show()
    End Sub
End Class
