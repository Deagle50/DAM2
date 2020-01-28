Imports System.Data.Entity.DbFunctions
Public Class FormularioProgramar
    Dim codEm As Integer
    Dim cine As Examen_UrkoUrbieta28012020.Cines
    Dim peli As Examen_UrkoUrbieta28012020.Peliculas
    Private Sub BtnProgramar_Click(sender As Object, e As EventArgs) Handles btnProgramar.Click

        calcularID()

        comprobarCine()

        comprobarPelicula()

        comprobarDuracion()

    End Sub

    Private Sub comprobarDuracion()
        Dim peliAnterior As Examen_UrkoUrbieta28012020.Emisiones = (From ems In modelo.Emisiones
                                                                    Where AddMinutes(ems.hora, ems.Peliculas.duracion) > txtHora.Text And txtHora.Text + txtMinutos.Text < ems.hora
                                                                    Select ems).First 'Devuelve la primera película que encaje en el horario, pregunta si borrarla
        If peliAnterior Is Nothing Then


        Else
            txtMinutos.Text = peliAnterior.cod_emision
            Dim resp As MsgBoxResult = MsgBox("¿Desea sobreescribir la emisión?", vbYesNo)
            If resp = vbYes Then
                modelo.Emisiones.Remove(peliAnterior)
                modelo.SaveChanges()
                MsgBox("Borrada con éxito")
            End If
        End If
    End Sub

    Private Sub calcularID()
        'Calcular nuevo id emision
        codEm = (From ems In modelo.Emisiones
                 Order By ems.cod_emision Descending
                 Select ems.cod_emision).First + 1
    End Sub

    Private Sub comprobarCine()
        'Comprobar que el cine exista
        cine = (From cn In modelo.Cines
                Where cn.cod_cine = txtCodigoCine.Text
                Select cn).FirstOrDefault

        If cine Is Nothing Then
            MsgBox("Error, introduce in id de cine válido")
        End If
    End Sub

    Private Sub comprobarPelicula()
        'Comprobar que la pelicula exista
        peli = (From pel In modelo.Peliculas
                Where pel.cod_pelicula = txtCodigoPelicula.Text
                Select pel).FirstOrDefault

        If peli Is Nothing Then
            MsgBox("Error, introduce in id de película válido")
        Else
            txtMinutos.Text = peli.duracion
        End If
    End Sub
End Class