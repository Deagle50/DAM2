Module modulo
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_UrkoUrbieta_DEV;Integrated Security=true"
    Public con As SqlConnection = New SqlConnection(cadena)
    Public idVehiculoActual As Integer
    Public datast As New DataSet                                                                                                        '¿PARAMETRO?
    Public daInspecciones As New SqlDataAdapter("SELECT IdRevision, IdVehiculo, Fecha, Realizada FROM GUI1.Inspecciones WHERE IdVehiculo = @par1", con)

    Public Sub InicializarDataSet()
        Dim pk(0) As DataColumn
        inicializarDA(daInspecciones)

        daInspecciones.Fill(datast, "Inspecciones")

        pk(0) = datast.Tables("GUI1.Inspecciones").Columns("IdRevision")
        datast.Tables("GUI1.Inspecciones").PrimaryKey = pk
    End Sub

    Private Sub inicializarDA(da As SqlDataAdapter)
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand
        da.DeleteCommand = cb.GetDeleteCommand
        da.UpdateCommand = cb.GetUpdateCommand
    End Sub
End Module
