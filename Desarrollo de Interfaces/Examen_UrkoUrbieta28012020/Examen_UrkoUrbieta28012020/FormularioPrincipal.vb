Imports System.Data.Entity.DbFunctions
Public Class frmPrincipal

    Private Sub BtnProgramar_Click(sender As Object, e As EventArgs) Handles btnProgramar.Click
        FormularioProgramar.Show()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormularioCancelar.txtCodigoCine.Text = lvDatos.SelectedItems(0).Text
        FormularioCancelar.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cod As Integer = CInt(txtBuscar.Text)
        Dim res As Object
        res = (
            From ems In modelo.Emisiones
            Where ems.cod_cine = cod
            Select ems.cod_emision, titulo = ems.Peliculas.titulo, ems.hora, horaf = AddMinutes(ems.hora, ems.Peliculas.duracion)).ToList 'Añadir duración

        mostrar(res)
    End Sub

    Public Sub mostrar(res As Object)
        'Borrar datos si los hubiera
        lvDatos.Items.Clear()

        'Ir mostrando datos uno a uno
        For Each elem In res
            Dim it As ListViewItem = lvDatos.Items.Add(elem.cod_emision)
            it.SubItems.Add(elem.titulo.ToString)
            it.SubItems.Add(elem.hora.ToString)
            it.SubItems.Add(elem.horaF.ToString)
        Next
    End Sub
End Class
