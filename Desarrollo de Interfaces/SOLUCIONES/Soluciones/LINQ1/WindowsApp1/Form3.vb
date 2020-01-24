Public Class Form3
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim anuncio As WindowsApp1.Anuncios
        If modelo.Categorias.Where(Function(x) x.IdCategoria = CInt(txtCategoria.Text)).Count > 0 Then
            anuncio = (From x In modelo.Anuncios
                       Where x.IdAnuncio = CInt(txtIdAnuncio.Text)
                       Select x).First
            anuncio.IdCategoria = CInt(txtCategoria.Text)
            anuncio.FechaContrato = CDate(txtFecha.Text)
            anuncio.Precio = CDbl(txtPrecio.Text)
            anuncio.TipoAnuncio = txtTipo.Text
            modelo.SaveChanges()
            Me.Dispose()
        End If
    End Sub
End Class