Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As SqlConnection = New SqlConnection(cadena)
        Dim consulta As New SqlCommand
        consulta.CommandText = String.Format("SELECT IdMensaje, Fecha, Mensaje  FROM Foro.Usuarios LEFT JOIN Foro.Mensajes On Foro.Mensajes.idusuario=Foro.Usuarios.idUsuario WHERE palabrapaso='{0}' AND Foro.Usuarios.idUsuario='{1}'", txtPass.Text, txtUsuario.Text)
        consulta.CommandType = CommandType.Text
        cn.Open()
        consulta.Connection = cn
        Dim dr As SqlDataReader
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
        ''Crear la conexión
        Dim cn As SqlConnection = New SqlConnection(cadena)
        ''Declarar el objeto command
        Dim consulta As New SqlCommand
        ''Establecer el texto de la consulta
        consulta.CommandText = "SELECT IdMensaje, Fecha, Mensaje  FROM Foro.Usuarios LEFT JOIN Foro.Mensajes On Foro.Mensajes.idusuario=Foro.Usuarios.idUsuario WHERE palabrapaso=@pw AND Foro.Usuarios.idUsuario=@us"
        Dim p1, p2 As SqlParameter

        p1 = New SqlParameter()
        p1.ParameterName = "@pw"
        p1.Value = txtPass.Text
        p1.Direction = ParameterDirection.Input

        p2 = New SqlParameter()
        p2.ParameterName = "@us"
        p2.Value = txtUsuario.Text
        p2.Direction = ParameterDirection.Input
        ''configurar el objeto command

        ''añadir los parámetros
        consulta.Parameters.Add(p1)
        consulta.Parameters.Add(p2)
        ''Establecer el tipo de la consulta
        consulta.CommandType = CommandType.Text
        ''abrir conexión
        cn.Open()
        ''Establecer la  conexión
        consulta.Connection = cn
        ''Ejecutar la consulta
        Dim dr As SqlDataReader
        dr = consulta.ExecuteReader()
        'Si hay resultados
        If dr.Read Then
            IdActual = txtUsuario.Text
            If Not IsDBNull(dr("idMensaje")) Then
                ''Recorrer el datareader
                LLenarLista(dr)
            End If
        Else
            MsgBox("Nombre de usuario y contraseña incorrectos")
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cn As SqlConnection = New SqlConnection(cadena)
        Dim consulta As New SqlCommand
        consulta.CommandText = "Foro.ValidarUsuario"
        Dim p1, p2 As SqlParameter

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
        consulta.CommandType = CommandType.StoredProcedure
        cn.Open()
        consulta.Connection = cn
        Dim dr As SqlDataReader
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

    Private Sub AltaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaUsuarioToolStripMenuItem.Click
        FrmAlta.Show()
    End Sub

    Private Sub BajaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaUsuarioToolStripMenuItem.Click
        FrmBaja.Show()
    End Sub

    Private Sub ModificaciónUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónUsuarioToolStripMenuItem.Click
        FrmModificar.Show()
    End Sub

    Private Sub NuevoMensajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoMensajeToolStripMenuItem.Click
        FrmNuevoMensaje.Show()
    End Sub
End Class
