Public Class Form1
    Public p1, p2 As SqlParameter
    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        'LlenarColumnas(LVDatos)
        iniciarSesion()
    End Sub


    Private Sub LVDatos_DoubleClick(sender As Object, e As EventArgs) Handles LVDatos.DoubleClick
        Dim F As New datosCliente
        F.Show()
    End Sub

    Private Sub iniciarSesion()
        Dim cn As SqlConnection = New SqlConnection(cadena)
        Dim consulta As New SqlCommand
        Dim dr As SqlDataReader

        'Texto de consulta
        consulta.CommandText = "SELECT account_number, type, current_balance FROM users JOIN accounts on users.username = accounts.holder WHERE pass=@pw AND users.username=@us"
        p1 = New SqlParameter()
        p1.ParameterName = "@pw"
        p1.Value = txtPassword.Text
        p1.Direction = ParameterDirection.Input

        p2 = New SqlParameter()
        p2.ParameterName = "@us"
        p2.Value = txtUsername.Text
        p2.Direction = ParameterDirection.Input

        consulta.Parameters.Add(p1)
        consulta.Parameters.Add(p2)
        consulta.CommandType = CommandType.Text
        cn.Open()
        consulta.Connection = cn

        dr = consulta.ExecuteReader()
        If dr.Read Then
            usuarioActual = txtUsername.Text
            LLenarLista(dr)
        Else
            MsgBox("Nombre de usuario y contraseña incorrectos")
        End If
        dr.Close()
        cn.Close()
    End Sub


    Private Sub LLenarLista(dr As SqlDataReader)
        LVDatos.Items.Clear()

        Do
            Dim it As ListViewItem = LVDatos.Items.Add(dr("account_number").ToString)
            it.SubItems.Add(dr("type").ToString)
            it.SubItems.Add(dr("current_balance").ToString)
        Loop While dr.Read
    End Sub

End Class
