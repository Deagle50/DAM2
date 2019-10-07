Public Class FrmAlta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim pos As Integer = Buscar(txtNCliente.Text)
        If pos = -1 Then
            MsgBox("Elemento no encontrado")
            btnAlta.Enabled = True
        Else
            txtNombreCliente.Text = Clientes(pos).nombre
            txtSaldo.Text = Clientes(pos).Saldo
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        ReDim Preserve Clientes(cont)
        Clientes(cont).nCliente = txtNCliente.Text
        Clientes(cont).nombre = txtNombreCliente.Text
        Clientes(cont).Saldo = txtSaldo.Text = "0"
        cont += 1
    End Sub
End Class