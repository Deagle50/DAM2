Module modulo
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_urkourbieta_dev;Integrated Security=True"
    Public con As SqlConnection = New SqlConnection(cadena)

    Public datast As New DataSet
    Public usuactual As DataRow

    Public daPedidos As New SqlDataAdapter("SELECT id_pedido, fecha, cerrado, total_neto, total_iva, total_pagar FROM pedidos", con)
    Public daProductos As New SqlDataAdapter("SELECT id_producto, descripcion, pvp FROM productos", con)
    Public daDetalle As New SqlDataAdapter("SELECT id_detalle, id_pedido, id_producto, unidades, total_linea FROM LineasDetalle", con)

    Public Sub inicializarDataSet()

        'Inicializar Data Adapters
        inicializarDA(daPedidos)
        inicializarDA(daProductos)
        inicializarDA(daDetalle)

        daPedidos.Fill(datast, "Pedidos")
        daProductos.Fill(datast, "Productos")
        daDetalle.Fill(datast, "LineasDetalle")

        'Iniciar datatables
        CrearPK("Pedidos", "id_pedido")
        CrearPK("Productos", "id_producto")
        CrearPK("LineasDetalle", "id_detalle")

        'Crear relaciones
        Dim rel1 As New DataRelation("Lineas-Pedido", datast.Tables("Pedidos").Columns("id_pedido"), datast.tables("LineasDetalle").Columns("id_pedido"))
        Dim rel2 As New DataRelation("Lineas-Productos", datast.Tables("Productos").Columns("id_producto"), datast.Tables("LineasDetalle").Columns("id_producto"))
    End Sub



    Public Sub inicializarDA(da As SqlDataAdapter)
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand
        da.DeleteCommand = cb.GetDeleteCommand
        da.UpdateCommand = cb.GetUpdateCommand

    End Sub

    Private Sub CrearPK(nomtabla As String, nomcol As String)
        Dim pk(0) As DataColumn
        pk(0) = datast.Tables(nomtabla).Columns(nomcol)
        datast.Tables(nomtabla).PrimaryKey = pk
    End Sub

End Module
