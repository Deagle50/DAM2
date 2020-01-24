Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Clear()
        LlenarColumnas(ListView1)
        LLenarFilas(ListView1)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''LLenamos el dataset con las dos tablas
        daUsuarios.Fill(ds, "Usuarios")
        daMensajes.Fill(ds, "Mensajes")

        ''Establecemos la PK de usuarios
        Dim t As DataTable = ds.Tables("Usuarios")
        Dim key(0) As DataColumn
        key(0) = t.Columns("IdUsuario")
        t.PrimaryKey = key

        ''Establecemos la Pk de Mensajes
        t = ds.Tables("Mensajes")
        key(0) = t.Columns("IdMensaje")
        t.PrimaryKey = key

        ''Habilitamos la relación entre mensajes y usuarios
        ''Mediante la columna idUsuario de ambas tablas
        Dim colusu, colmen As DataColumn
        colusu = ds.Tables("Usuarios").Columns("IdUsuario")
        colmen = ds.Tables("Mensajes").Columns("IdUsuario")
        Dim RelUsuMen As DataRelation = New DataRelation("UsariosMensajes", colusu, colmen)
        ds.Relations.Add(RelUsuMen)

        '''Habilitamos la restricción FK para la relación anterior.
        'Dim ConstUsuMen As New ForeignKeyConstraint(colusu, colmen)
        'ds.Tables("Mensajes").Constraints.Add(ConstUsuMen)
        Dim constusumen As ForeignKeyConstraint = ds.Tables("Mensajes").Constraints("UsariosMensajes")
        constusumen.DeleteRule = Rule.None
        ConstUsuMen.UpdateRule = Rule.None
        ds.EnforceConstraints = True
    End Sub

    Private Sub MantenimientoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoUsuariosToolStripMenuItem.Click
        frmMantenimiento.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Clear()
        LlenarColumnas(ListView1)
        LLenarFilasOriginal(ListView1)
    End Sub

    Private Sub CancelarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarCambiosToolStripMenuItem.Click
        ds.RejectChanges()
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try
            daUsuarios.Update(ds.Tables("Usuarios"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count <> 0 Then
            usuactual = ds.Tables("Usuarios").Rows.Find(ListView1.SelectedItems(0).Text)
            FrmMensaje.ShowDialog()
        End If
    End Sub
End Class
