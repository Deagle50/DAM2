Public Class Principal
    Private Sub NuevoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem.Click
        Dim resp As New MsgBoxResult
        Dim num As Integer
        resp = MsgBox("¿Quieres añadir un nuevo pedido?", vbYesNo)
        If resp = vbTrue Then
            con.Open()
            num = calcularUltimoID()
            con.Close()
        End If
        MsgBox(num)
    End Sub

    Private Function calcularUltimoID() As Integer
        Dim consulta As New SqlCommand("SELECT MAX(id_producto) FROM productos")

        consulta.Connection = con

        Return consulta.ExecuteScalar
    End Function
End Class
