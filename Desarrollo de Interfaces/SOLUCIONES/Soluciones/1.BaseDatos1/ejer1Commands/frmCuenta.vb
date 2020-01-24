Imports System.Data.SqlClient
Public Class frmCuenta
    Dim cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_EnaitzEchaburua_DEV;Integrated Security=true"
    Dim p1, p2, p3 As SqlParameter
    Dim con As SqlConnection = New SqlConnection(cadena)
    Dim consulta As New SqlCommand

    Private Sub FrmCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta.CommandText = "Select mo.NMovimiento, mo.Importe, mo.Concepto, mo.fecha from interfaces.cuentas as cu join interfaces.Movimientos as mo On cu.NCuenta=mo.NCuenta  where mo.fecha between @Desde and @Hasta and mo.NCuenta=@cuenta"

        p1 = New SqlParameter()
        p1.ParameterName = "@desde"
        p1.Direction = ParameterDirection.Input
        p1.SqlDbType = SqlDbType.Date

        p2 = New SqlParameter()
        p2.ParameterName = "@hasta"
        p2.Direction = ParameterDirection.Input
        p2.SqlDbType = SqlDbType.Date

        p3 = New SqlParameter()
        p3.ParameterName = "@cuenta"
        p3.Direction = ParameterDirection.Input

        consulta.Parameters.Add(p1)
        consulta.Parameters.Add(p2)
        consulta.Parameters.Add(p3)

        consulta.CommandType = CommandType.Text
    End Sub

    Private Sub llenarLista(dr As SqlDataReader)
        ListView1.Items.Clear()
        Dim it As ListViewItem
        Do
            it = ListView1.Items.Add(dr("NMovimiento").ToString)
            If Not IsDBNull(dr("importe")) Then
                it.SubItems.Add(dr("Concepto"))
            Else
                it.SubItems.Add("null")
            End If
            it.SubItems.Add(dr("fecha").ToString)
        Loop While dr.Read
    End Sub

    Private Sub BtReintegro_Click(sender As Object, e As EventArgs) Handles btReintegro.Click
        con.Open()

        Dim id As Integer = calcularID()
        Dim tr As SqlTransaction = con.BeginTransaction

        Try
            Dim Consultaup As New SqlCommand("UPDATE cuentas set SaldoActual=SaldoActual - @reintegro WHERE NCuenta=@nc")
            Dim Consultain As New SqlCommand("INSERT INTO interfaces.movimientos (NMovimiento,Importe,Concepto,Fecha,NCuenta) values(@NMovimiento,@Importe,@Concepto,@fecha, @NCuenta)")
            ''Configurar la insert
            Consultain.Parameters.AddWithValue("@NMovimiento", id)
            Consultain.Parameters.AddWithValue("@Importe", -CDbl(txtReintegro.Text))
            Consultain.Parameters.AddWithValue("@Concepto", "ReintegroCajero")
            Consultain.Parameters.AddWithValue("@fecha", Date.Today)
            Consultain.Parameters.AddWithValue("@NCuenta", NCuenta)
            Consultain.Connection = con
            Consultain.Transaction = tr
            ''ejecutar la insert

            Consultain.ExecuteNonQuery()

            ''Configurar la update

            Consultaup.Parameters.AddWithValue("@reintegro", CDbl(txtReintegro.Text))
            Consultaup.Parameters.AddWithValue("@nc", NCuenta)
            Consultaup.Connection = con
            Consultaup.Transaction = tr
            ''ejecutar la update
            Consultaup.ExecuteNonQuery()

            tr.Commit()
        Catch ex As SqlException
            MsgBox("Ha ocurrido un error, se cancelarán los cambios")
            tr.Rollback()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtBorrar_Click(sender As Object, e As EventArgs) Handles BtBorrar.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("Está seguro", vbYesNo)
        If resp = MsgBoxResult.Yes Then
            consulta.CommandText = "DELETE FROM MOVIMIENTOS WHERE NCuenta=@cuenta AND fecha Between @desde and @hasta"
            consulta.Connection = con
            consulta.Parameters("@desde").Value = CDate(txtDesde.Text)
            consulta.Parameters("@hasta").Value = CDate(txtHasta.Text)
            consulta.Parameters("@cuenta").Value = NCuenta
            consulta.CommandType = CommandType.Text
            con.Open()
            consulta.ExecuteNonQuery()
            con.Close()
            ListView1.Items.Clear()
            ActualizarListView()
        End If
    End Sub

    Private Sub ActualizarListView()

        consulta.CommandText = "Select mo.NMovimiento, mo.Importe, mo.Concepto, mo.fecha from interfaces.cuentas as cu join interfaces.Movimientos as mo On cu.NCuenta=mo.NCuenta  where mo.fecha between @Desde and @Hasta and mo.NCuenta=@cuenta"
        p1.Value = CDate(txtDesde.Text)
        p2.Value = CDate(txtHasta.Text)
        p3.Value = NCuenta

        con.Open()
        consulta.Connection = con
        Dim dr As SqlDataReader
        dr = consulta.ExecuteReader()

        If dr.Read Then
            lblNcuenta.Text = NCuenta
            llenarLista(dr)


        End If
        dr.Close()
        con.Close()
    End Sub

    Private Function calcularID() As Integer
        Dim consulta As New SqlCommand("select max(NMovimiento) from interfaces.movimientos")
        consulta.Connection = con
        Return consulta.ExecuteScalar + 1
    End Function

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click


        p1.Value = CDate(txtDesde.Text)
        p2.Value = CDate(txtHasta.Text)
        p3.Value = NCuenta

        con.Open()
        consulta.Connection = con
        Dim dr As SqlDataReader
        dr = consulta.ExecuteReader()

        If dr.Read Then
            lblNcuenta.Text = NCuenta
            llenarLista(dr)


        End If
        dr.Close()
        con.Close()
    End Sub
End Class