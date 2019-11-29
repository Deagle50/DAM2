Module Module1
    Public ds As New DataSet
    Public cn As New SqlConnection("Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True")

    Public daPedidos As New SqlDataAdapter("SELECT idpedido, fecha, Cerrado, TotalNeto,totalIva,totalPagar FROM compras.Pedidos", cn)
    Public daProductos As New SqlDataAdapter("SELECT IdProducto,Descripcion,PVP FROM compras.Productos", cn)
    Public daLineas As New SqlDataAdapter("SELECT IdDetalle, IdPedido,IdProducto,unidades,totalLinea FROM compras.LineasDetalle", cn)

    Public Sub InicializarDataSet()
        ''inicializar adaptadores
        InicializarDA(daPedidos)
        InicializarDA(daProductos)
        InicializarDA(daLineas)

        ''Inicializar Dataset
        daPedidos.Fill(ds, "Pedidos")
        daProductos.Fill(ds, "Productos")
        daLineas.Fill(ds, "LineasDetalle")

        ''inicializar DataTables
        CrearPk("Pedidos", "IdPedido")
        CrearPk("Productos", "IdProducto")
        CrearPk("LineasDetalle", "IdDetalle")

        ''crear relaciones
        Dim rel1 As New DataRelation("LineasPedido", ds.Tables("Pedidos").Columns("Idpedido"), ds.Tables("LineasDetalle").Columns("IdPedido"))
        Dim rel2 As New DataRelation("LineasProducto", ds.Tables("Productos").Columns("IdProducto"), ds.Tables("LineasDetalle").Columns("IdProducto"))
        ds.Relations.Add(rel1)
        ds.Relations.Add(rel2)
    End Sub

    Private Sub InicializarDA(da As SqlDataAdapter)
        'Inicializar data adapter
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand
        da.DeleteCommand = cb.GetDeleteCommand
        da.UpdateCommand = cb.GetUpdateCommand
    End Sub

    Private Sub CrearPk(nomtabla As String, nomcol As String)
        'Crea las pk de cada tabla
        Dim pk(0) As DataColumn
        pk(0) = ds.Tables(nomtabla).Columns(nomcol)
        ds.Tables(nomtabla).PrimaryKey = pk
    End Sub
End Module
