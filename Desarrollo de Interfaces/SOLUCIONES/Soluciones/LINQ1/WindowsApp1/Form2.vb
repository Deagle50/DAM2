Public Class Form2
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim NuevoAnuncio As New WindowsApp1.Anuncios

        If modelo.Anuncios.Where(Function(x) x.IdAnuncio = CInt(txtIdAnuncio.Text)).Count = 0 Then
            If modelo.Categorias.Where(Function(x) x.IdCategoria = CInt(txtCategoria.Text)).Count <> 0 Then
                NuevoAnuncio.IdAnuncio = CInt(txtIdAnuncio.Text)
                NuevoAnuncio.IdCategoria = CInt(txtCategoria.Text)
                NuevoAnuncio.FechaContrato = CDate(txtFecha.Text)
                NuevoAnuncio.Precio = CDbl(txtPrecio.Text)
                NuevoAnuncio.TipoAnuncio = txtTipo.Text
                NuevoAnuncio.IdAnunciante = CInt(txtIdAnunciante.Text)
                modelo.Anuncios.Add(NuevoAnuncio)
                modelo.SaveChanges()
                Me.Dispose()
            Else
                MsgBox("La categoría no existe")
            End If
        Else
                MsgBox("Ya hay un anuncio con ese código")
        End If
    End Sub
End Class