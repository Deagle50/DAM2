Module modulo
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True"
    Public daUsuarios As New SqlDataAdapter("SELECT * FROM Foro.Usuarios", cadena)
    Public builder As New SqlCommandBuilder(daUsuarios)
    Public ds As New DataSet

    Public Sub InicializarDataAdapter()
        daUsuarios.UpdateCommand = builder.GetUpdateCommand()
        daUsuarios.DeleteCommand = builder.GetDeleteCommand()
        daUsuarios.InsertCommand = builder.GetInsertCommand()

    End Sub

    Public Sub LlenarColumnas(lv As ListView)
        For Each c As DataColumn In ds.Tables("Usuarios").Columns
            lv.Columns.Add(c.ColumnName)

        Next
        lv.Columns.Add("RowState")
    End Sub

    Public Sub LlenarFilas(lv As ListView)
        For Each r As DataRow In ds.Tables("Usuarios").Rows

            Dim it As ListViewItem
            If r.RowState = DataRowState.Deleted Then
                it = lv.Items.Add("----")
            Else
                it = lv.Items.Add(r("idUsuario").ToString)
            End If
            For i As Integer = 1 To ds.Tables("Usuarios").Columns.Count - 1
                If r.RowState = DataRowState.Deleted Then
                    it.SubItems.Add("----")
                Else
                    it.SubItems.Add(r(i).ToString)
                End If
            Next
            it.SubItems.Add(r.RowState.ToString)
        Next
    End Sub

    Public Sub LlenarFilasOriginal(lv As ListView)
        For Each r As DataRow In ds.Tables("Usuarios").Rows

            Dim it As ListViewItem
            it = lv.Items.Add(r("idUsuario", DataRowVersion.Original).ToString)
            For i As Integer = 1 To ds.Tables("Usuarios").Columns.Count - 1
                If r.RowState = DataRowState.Deleted Then
                    it.SubItems.Add(r(i, DataRowVersion.Original).ToString)
                End If
            Next
            it.SubItems.Add(r.RowState.ToString)
        Next
    End Sub


End Module
