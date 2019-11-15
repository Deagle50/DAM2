Imports System.Data.SqlClient
Public Class Form1
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True"
    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim cn As SqlConnection = New SqlConnection(cadena)
    '    Dim consulta As New SqlCommand
    '    consulta.CommandText = String.Format("SELECT IdMensaje, Fecha, Mensaje  FROM Foro.Usuarios LEFT JOIN Foro.Mensajes On Foro.Mensajes.idusuario=Foro.Usuarios.idUsuario WHERE palabrapaso='{0}' AND Foro.Usuarios.idUsuario='{1}'", txtPass.Text, txtUsuario.Text)
    '    consulta.CommandType = CommandType.Text
    '    cn.Open()
    '    consulta.Connection = cn
    '    Dim dr As SqlDataReader
    '    dr = consulta.ExecuteReader()
    '    If dr.Read Then
    '        If Not IsDBNull(dr("idMensaje")) Then
    '            LLenarLista(dr)
    '        End If
    '    Else
    '        MsgBox("Nombre de usuario y contraseña incorrectos")
    '    End If
    '    dr.Close()
    '    cn.Close()
    'End Sub
    Public p1, p2 As SqlParameter
    Private Sub LLenarLista(dr As SqlDataReader)
        ListView1.Items.Clear()
        Dim it As ListViewItem
        Do
            it = ListView1.Items.Add(dr("IdMensaje").ToString)
            If Not IsDBNull(dr("Fecha")) Then
                it.SubItems.Add(dr("Fecha"))
            Else
                it.SubItems.Add("null")
            End If
            it.SubItems.Add(dr("mensaje").ToString)
        Loop While dr.Read
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cn As SqlConnection = New SqlConnection(cadena)
        Dim consulta As New SqlCommand

        Dim dr As SqlDataReader
        'Texto de consulta
        consulta.CommandText = "SELECT IdMensaje, Fecha, Mensaje  FROM Foro.Usuarios LEFT JOIN Foro.Mensajes On Foro.Mensajes.idusuario=Foro.Usuarios.idUsuario WHERE palabrapaso=@pw AND Foro.Usuarios.idUsuario=@us"

        p1 = New SqlParameter()
        p1.ParameterName = "@pw"
        p1.Value = txtPass.Text
        p1.Direction = ParameterDirection.Input

        p2 = New SqlParameter()
        p2.ParameterName = "@us"
        p2.Value = txtUsuario.Text
        p2.Direction = ParameterDirection.Input

        consulta.Parameters.Add(p1)
        consulta.Parameters.Add(p2)
        consulta.CommandType = CommandType.Text
        cn.Open()
        consulta.Connection = cn

        dr = consulta.ExecuteReader()
        If dr.Read Then
            IdActual = txtUsuario.Text
            If Not IsDBNull(dr("idMensaje")) Then
                LLenarLista(dr)
            End If
        Else
            MsgBox("Nombre de usuario y contraseña incorrectos")
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        Dim F As New Altas
        F.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim F As New Modificar
        F.Show()
    End Sub

    Private Sub NuevoMensajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoMensajeToolStripMenuItem.Click
        Dim F As New nuevoMensaje
        F.Show()
    End Sub

    Private Sub BajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasToolStripMenuItem.Click
        Dim F As New Baja
        F.Show()
    End Sub
End Class
