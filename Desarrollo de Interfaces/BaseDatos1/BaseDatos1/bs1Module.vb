Module bs1Module
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_urkourbieta_DEV;Integrated Security=True"
    Public daUsuarios As New SqlDataAdapter("SELECT * FROM Foro.Usuarios", cadena)
    Public builderUsuarios As New SqlCommandBuilder(daUsuarios)
    Public ds As New DataSet()
    Public usuarioActual As String

    Public Sub InicializarDataAdapter()
        daUsuarios.UpdateCommand = builderUsuarios.GetUpdateCommand()
        daUsuarios.DeleteCommand = builderUsuarios.GetDeleteCommand()
        daUsuarios.InsertCommand = builderUsuarios.GetInsertCommand()
    End Sub

    Public Sub LlenarColumnas(lv As ListView)
        For Each c As DataColumn In ds.Tables("Usuarios").Columns
            lv.Columns.Add(c.ColumnName)
        Next
        lv.Columns.Add("RowState")
    End Sub

End Module
