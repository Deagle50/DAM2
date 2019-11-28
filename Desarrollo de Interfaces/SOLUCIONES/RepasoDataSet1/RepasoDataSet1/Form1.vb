Public Class Form1
    Private Sub NuevoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem.Click
        frmPedido.MdiParent = Me
        frmPedido.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        InicializarDataSet()
    End Sub

    Private Sub MantenimientoProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoProductosToolStripMenuItem.Click
        frmMantenimiento.MdiParent = Me
        frmMantenimiento.Show()
    End Sub
End Class
