Imports ConsultasLINQ.ConsultasLINQ

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim res As Object
        res = (From cli In modelo.Customers
               Order By cli.CompanyName
               Where cli.Region = txtEstado.Text
               Select New With {.Id = cli.CustomerID, .nombre = cli.CompanyName}).ToList
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim res As Object
        'res = (From cli In modelo.Customers
        '       Join pedido In modelo.Orders
        '           On cli.CustomerID Equals pedido.CustomerID
        '       Select cli.CompanyName, pedido.OrderID, pedido.OrderDate).ToList

        res = (From pedido In modelo.Orders
               Select pedido.Customers.CompanyName, pedido.OrderID, pedido.OrderDate).ToList
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.DataSource = modelo.Customers.ToList
        ComboBox1.DisplayMember = "CompanyName"

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim obj As HashSet(Of Orders) = ComboBox1.SelectedItem.Orders
        DataGridView1.DataSource = obj.ToList
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim obj As Object

        obj = (From cust In modelo.Customers
               Join ord In modelo.Orders
                On cust.CustomerID Equals ord.CustomerID
               Group By Id = cust.CustomerID, Nombre = cust.ContactName
                Into Ordenes = Group, Npedidos = Count(), Total = Sum(ord.Order_Details.Sum(Function(o) o.Quantity * o.UnitPrice))
               Select Id, Nombre, Npedidos, Total).ToList


        DataGridView1.DataSource = obj

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj As Object
        obj = (From cust In modelo.Customers
               Group Join ord In modelo.Orders
                  On cust.CustomerID Equals ord.CustomerID
              Into CustomerOrders = Group, TotalFacturado = Sum(ord.Order_Details.Sum(Function(x) x.Quantity * x.UnitPrice * (1 - x.Discount)))
               Where cust.CustomerID = "ALFKI"
               Select cust.CustomerID, TotalFacturado, CustomerOrders.Count).ToList
        DataGridView1.DataSource = obj
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim res As Double
        res = Aggregate od In modelo.Order_Details
                  Into Sum(od.Quantity * od.UnitPrice * (1 - od.Discount))

        MsgBox(res)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim res As Double
        res = (From orders In modelo.Orders
               Aggregate od In orders.Order_Details
                   Into Total = Sum(od.Quantity * od.UnitPrice * (1 - od.Discount))
               Where orders.CustomerID = TextBox1.Text
               Select x = Total).Sum()
        MsgBox(res)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim res = (From orders In modelo.Orders
                   Let Total = orders.Order_Details.Sum(Function(o) o.Quantity * o.UnitPrice * o.Discount)
                   Where Total > 100
                   Select orders.OrderID, Total).ToList

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim res = (From od In modelo.Order_Details
                   Let Total = od.Quantity * od.UnitPrice * (1 - od.Discount)
                   Where od.OrderID = CInt(txtEstado.Text)
                   Select od.OrderID, od.Products.ProductName, Total).ToList

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim res As Object

        res = (From cust In modelo.Customers.ToList()
               Order By cust.City
               Take While cust.City.StartsWith("A")
               Select New With {.ciudad = cust.City} Distinct
               ).ToList


        DataGridView1.DataSource = res
    End Sub
End Class
