Module Module1
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True"
    Public con As New SqlConnection(cadena)
    Public ds As New DataSet()
    Public da As New SqlDataAdapter("SELECT IdVehiculo,IdRevision,fecha,Realizada FROM GUI1.Inspecciones WHERE IdVehiculo=@id", con)
    Public actual As Integer
    Public Sub InicializarDataSet(id As Integer)
        If da.SelectCommand.Parameters.Contains("@id") Then
            da.SelectCommand.Parameters("@id").Value = id
        Else
            da.SelectCommand.Parameters.AddWithValue("@id", id)
        End If
        Dim builder As New SqlCommandBuilder(da)
        da.InsertCommand = builder.GetInsertCommand
        da.DeleteCommand = builder.GetDeleteCommand
        da.UpdateCommand = builder.GetUpdateCommand

        da.Fill(ds, "Inspecciones")
        Dim dt As DataTable = ds.Tables("Inspecciones")
        Dim pk(1) As DataColumn
        pk(0) = dt.Columns("IdRevision")
        pk(1) = dt.Columns("IdVehiculo")
        ds.Tables("Inspecciones").PrimaryKey = pk
    End Sub

    Public Function MaxId(id As Integer) As Integer
        Dim consulta As New SqlCommand("SELECT MAX(IdRevision) FROM Gui1.Inspecciones WHere IdVehiculo=@vehi")
        consulta.Parameters.AddWithValue("@vehi", id)
        consulta.Connection = con
        con.Open()
        Dim res As Object = consulta.ExecuteScalar
        con.Close()
        If IsDBNull(res) Then
            Return 1
        Else
            Return res + 1
        End If
    End Function

End Module
