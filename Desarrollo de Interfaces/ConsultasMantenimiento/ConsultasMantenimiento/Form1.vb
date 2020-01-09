Imports ConsultasMantenimiento.ConsultasMantenimiento
Public Class Form1
    Dim res As Object

    Private Sub mostrar(res As Object)
        dgvDatos.DataSource = res
    End Sub
End Class
