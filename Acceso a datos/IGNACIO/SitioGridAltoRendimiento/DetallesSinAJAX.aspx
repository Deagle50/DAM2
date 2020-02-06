<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetallesSinAJAX.aspx.cs" Inherits="DetallesSinAJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        h3 {
            width:50%;
        }
        span.rojo {
            color:red; font-size:large;
        }
        span.verde {
            color:green; font-size:large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <img alt="aaa" src="nAjax.jpg" />

    <br />
    <asp:Button ID="Button1" runat="server" 
        Text="Cambiar: con Ajax" OnClick="Button1_Click" />
    <h3>Este primer GridView <span class="rojo">NO utiliza AJAX</span> y 
            está <span class="verde">vinculado a un ObjectDataSource</span> 
            que permite recuperar del servidor de datos
            las filas de la página correspondiente
    </h3>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" 
                ForeColor="#333333" GridLines="None" PageSize="8">
                <Columns>
                    <asp:BoundField DataField="SalesOrderID" HeaderText="SalesOrderID" 
                        SortExpression="SalesOrderID" />
                    <asp:BoundField DataField="OrderQty" HeaderText="OrderQty" 
                        SortExpression="OrderQty" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
                        SortExpression="UnitPrice" />
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                        SortExpression="ProductID" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            
        <!-- 
            Segundo GridView vinvulado a un sqlDatasource normal
        -->
        <h3>Este segundo GridView <span class="rojo">NO utiliza AJAX</span> y 
            está <span class="verde">vinculado a un SQLDataSource NORMAL</span>
            que recupera todas las filas del servidor de datos devolviendo
            solo las del botón seleccionado
        </h3>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataSourceID="SqlDataSource2"  PageSize="8"
                ForeColor="#333333" GridLines="None" AllowPaging="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="SalesOrderID" HeaderText="SalesOrderID" SortExpression="SalesOrderID" />
                    <asp:BoundField DataField="OrderQty" HeaderText="OrderQty" 
                        SortExpression="OrderQty" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
                        SortExpression="UnitPrice" />
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                        SortExpression="ProductID" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>

        <!-- Componentes de acceso a datos -->
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>" 
                SelectCommand="select [SalesOrderID], [OrderQty], [UnitPrice], [ProductID] from sales.SalesOrderDetail">
            </asp:SqlDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
                SelectCountMethod="selectNumFilas" SelectMethod="select"
                EnablePaging="true" TypeName="AJAX2.detalleDataSource"  >
            </asp:ObjectDataSource>
        <!-- Fin de declaración de componentes de acceso a datos -->
        
        <div>
            <img src="google2.png" alt="ImagenGoogle2" height="250" width="500" />
    </div>
    </div>
    </form>
</body>
</html>
