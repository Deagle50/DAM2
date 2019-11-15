Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As DataTable
        Dim key(0) As DataColumn

        daUsuarios.Fill(ds, "Usuarios")
        t = ds.Tables("Usuarios")
        key(0) = t.Columns("IdUsuario")
        t.PrimaryKey = key
    End Sub

    Private Sub BtnVerUsuarios_Click(sender As Object, e As EventArgs) Handles btnVerUsuarios.Click
        LVPrincipal.Clear()
        LlenarColumnas(LVPrincipal)
        LlenarFilas(LVPrincipal)

    End Sub

    Private Sub MantenimientoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoUsuariosToolStripMenuItem.Click
        frmMantenimientoUsuarios.Show()
    End Sub

    Private Sub BtnLlenarFilasOriginal_Click(sender As Object, e As EventArgs) Handles btnLlenarFilasOriginal.Click
        LVPrincipal.Clear()
        LlenarColumnas(LVPrincipal)
        LlenarFilasOriginal(LVPrincipal)
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try
            daUsuarios.Update(ds.Tables("Usuarios"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarCambiosToolStripMenuItem.Click
        ds.RejectChanges()
    End Sub


End Class
