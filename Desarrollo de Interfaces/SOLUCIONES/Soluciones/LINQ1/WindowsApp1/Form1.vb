Imports System.IO
Imports WindowsApp1.WindowsApp1

Public Class Form1
    Dim actual As WindowsApp1.Anunciantes
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        actual = (From ante In modelo.Anunciantes
                  Where ante.IdAnunciante = CInt(txtIdAnunciante.Text)
                  Select ante).FirstOrDefault

        If Not actual Is Nothing Then
            txtContacto.Text = actual.Contacto
            txtDireccion.Text = actual.Direccion
            txtEmpresa.Text = actual.NombreEmpresa
            txtNif.Text = actual.NIF
            txtTelefono.Text = actual.Telefono
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            llenarLista(actual.Anuncios)
        Else
            MsgBox("elemento no encontrado")
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
        End If
    End Sub

    Private Sub llenarLista(anuncios As ICollection(Of Anuncios))
        ListView1.Items.Clear()

        For Each x As WindowsApp1.Anuncios In anuncios
            Dim it As ListViewItem = ListView1.Items.Add(x.IdAnuncio)
            it.SubItems.Add(x.IdCategoria)
            it.SubItems.Add(x.TipoAnuncio)
            it.SubItems.Add(x.FechaContrato.ToString)
            it.SubItems.Add(x.Precio.ToString)
        Next

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If ListView1.SelectedItems.Count <> 0 Then
            With ListView1.SelectedItems(0)
                Form3.txtIdAnuncio.Text = .Text
                Form3.txtCategoria.Text = .SubItems(1).Text
                Form3.txtTipo.Text = .SubItems(2).Text
                Form3.txtFecha.Text = .SubItems(3).Text
                Form3.txtPrecio.Text = .SubItems(4).Text
                Form3.txtIdAnunciante.Text = actual.IdAnunciante
            End With
            Form3.ShowDialog()

        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Form2.txtIdAnunciante.Text = actual.IdAnunciante
        Form2.ShowDialog()
    End Sub

    Private Sub BtnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
        Dim salida As New StreamWriter("salida.txt")
        salida.WriteLine("{0,9}  {1,11}  {2,12}  {3,12}  {4,13}  {5,6}", "IdAnuncio", "IdCategoria", "IdAnunciante", "Tipoanuncio", "FechaContrato", "Precio")
        Dim anterior As List(Of Anuncios)
        anterior = (From anuncio In modelo.Anuncios
                    Where anuncio.FechaContrato.Value.Year = Now.Year - 1
                    Select anuncio).ToList
        Dim t As Integer
        For Each a As Anuncios In anterior
            salida.WriteLine("{0,9}  {1,11}  {2,12}  {3,12}  {4,13}  {5,6}", a.IdAnuncio, a.IdCategoria, a.IdAnunciante, a.TipoAnuncio, a.FechaContrato, a.Precio)
            modelo.Anuncios.Remove(a)
            t += 1
        Next
        salida.WriteLine("Total borrados: {0}", t.ToString)
        salida.Close()
    End Sub
End Class
