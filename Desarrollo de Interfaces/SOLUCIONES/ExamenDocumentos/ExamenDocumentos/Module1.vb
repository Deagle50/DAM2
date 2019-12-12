Module Module1
    Public con As New SqlConnection("Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True")
    Public ds As New DataSet
    Public daRevisiones As New SqlDataAdapter("SELECT IdDocumento,NumRevision,FechaRevision,Aprobada FROM GUI1.Revisiones WHERE IdDocumento=@id", con)
    Public Sub InicializarAdaptador()
        Dim p As New SqlParameter()
        p.DbType = DbType.Int32
        p.ParameterName = "@id"
        p.Direction = ParameterDirection.Input
        daRevisiones.SelectCommand.Parameters.Add(p)
        Dim builder As New SqlCommandBuilder(daRevisiones)
        daRevisiones.InsertCommand = builder.GetInsertCommand
        daRevisiones.DeleteCommand = builder.GetDeleteCommand
        daRevisiones.UpdateCommand = builder.GetUpdateCommand
    End Sub

    Public Sub LLenarDataSet(id As Integer)
        If ds.Tables.Contains("Revisiones") Then
            ds.Tables("Revisiones").Rows.Clear()
        End If
        daRevisiones.SelectCommand.Parameters("@id").Value = id
        daRevisiones.Fill(ds, "Revisiones")
        If Not ds.Tables("Revisiones").PrimaryKey Is Nothing Then
            Dim pk(1) As DataColumn
            pk(0) = ds.Tables("Revisiones").Columns("IdDocumento")
            pk(1) = ds.Tables("Revisiones").Columns("NumRevision")
            ds.Tables("Revisiones").PrimaryKey = pk
        End If
    End Sub
End Module
