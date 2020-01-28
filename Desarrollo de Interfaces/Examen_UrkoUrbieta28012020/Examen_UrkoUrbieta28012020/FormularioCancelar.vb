Imports System.Data.Entity.DbFunctions
Public Class FormularioCancelar
    Dim codEm As Integer
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resp As MsgBoxResult = MsgBox("¿Desea borrar la emisión?", vbYesNo)
        If resp = vbYes Then
            Dim emision As Examen_UrkoUrbieta28012020.Emisiones = modelo.Emisiones.Where(Function(x) x.cod_emision = codEm).First

            modelo.Emisiones.Remove(emision)
            modelo.SaveChanges()

            MsgBox("Borrada con éxito")
            vaciarTXT()
        End If

    End Sub

    Private Sub FormularioCancelar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Recibir cod Em del formulario principal
        codEm = txtCodigoCine.Text
        txtCodigoCine.Text = ""

        Dim res As Examen_UrkoUrbieta28012020.Emisiones = (From ems In modelo.Emisiones
                                                           Where ems.cod_emision = codEm
                                                           Select ems).First

        txtCodigoCine.Text = res.cod_cine.ToString
        txtCodigoPelicula.Text = res.cod_pelicula.ToString
        txtHora.Text = res.hora.ToString
        txtMinutos.Text = res.Peliculas.duracion
    End Sub
    Private Sub vaciarTXT()
        txtCodigoCine.Text = ""
        txtCodigoPelicula.Text = ""
        txtHora.Text = ""
        txtMinutos.Text = ""
    End Sub
End Class