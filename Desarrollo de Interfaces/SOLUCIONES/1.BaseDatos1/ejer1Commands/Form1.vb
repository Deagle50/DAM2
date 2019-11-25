Imports System.Data.SqlClient
Public Class Form1
    Dim cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_EnaitzEchaburua_DEV;Integrated Security=true"

    Private Sub BtConectar_Click(sender As Object, e As EventArgs) Handles btConectar.Click
        Dim con As SqlConnection = New SqlConnection(cadena)
        Dim consulta As New SqlCommand
        consulta.CommandText = "Select cuenta.Ncuenta, cuenta.Tipo, cuenta.SaldoActual from interfaces.Usuarios as usu left join interfaces.Cuentas as cuenta ON usu.username=cuenta.titular where username=@username AND password = @password"
        Dim p1, p2 As SqlParameter


        p1 = New SqlParameter()
        p1.ParameterName = "@username"
        p1.Value = txtUsername.Text
        p1.Direction = ParameterDirection.Input

        p2 = New SqlParameter()
        p2.ParameterName = "@password"
        p2.Value = txtContrasena.Text
        p2.Direction = ParameterDirection.Input

        consulta.Parameters.Add(p1)
        consulta.Parameters.Add(p2)

        consulta.CommandType = CommandType.Text

        con.Open()
        consulta.Connection() = con
        Dim dr As SqlDataReader
        dr = consulta.ExecuteReader()
        If dr.Read Then
            If Not IsDBNull(dr("NCuenta")) Then
                llenarlista(dr)

            End If
        Else
            MsgBox("Usuario o contraseña Incorrectos.", vbCritical)
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub llenarlista(dr As SqlDataReader)
        Do
            Dim it As ListViewItem = ListView1.Items.Add(dr("NCuenta"))
            If Not IsDBNull(dr("tipo")) Then
                it.SubItems.Add(dr("tipo"))
            Else
                it.SubItems.Add(dr("NULL"))
            End If
            ''Añadir to String despues del dataReader.
            it.SubItems.Add(dr("SaldoActual").ToString)
        Loop While dr.Read()
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        NCuenta = ListView1.SelectedItems(0).Text
        frmCuenta.Show()
    End Sub
End Class
