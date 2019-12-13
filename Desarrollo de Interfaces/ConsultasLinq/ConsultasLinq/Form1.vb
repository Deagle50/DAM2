Imports ConsultasLinq.ConsultasLinq

Public Class Form1
    Dim res As Object
    Private Sub BtnPulsar_Click(sender As Object, e As EventArgs) Handles btnPulsar.Click
        res = (From cli In modelo.Customers
               Where cli.Region = txtEstado.Text.ToString()
               Order By cli.CompanyName Descending
               Select New With {.CustomerID = cli.CustomerID, .CompanyName = cli.CompanyName}).ToList

        dgvDatos.DataSource = res
    End Sub

    Private Sub BtnPulsar2_Click(sender As Object, e As EventArgs) Handles btnPulsar2.Click
        'res = (From cli In modelo.Customers
        '       Join pedido In modelo.Orders
        '       On cli.CustomerID Equals pedido.CustomerID
        '       Select cli.CustomerID, pedido.OrderID, pedido.OrderDate).ToList

        res = (From Pedido In modelo.Orders
               Select Pedido.Customers.CustomerID, Pedido.OrderID, Pedido.OrderDate).ToList
        dgvDatos.DataSource = res
    End Sub

    Private Sub BtnPulsar3_Click(sender As Object, e As EventArgs) Handles btnPulsar3.Click
        cbxDatos.DataSource = modelo.Customers.ToList
        cbxDatos.DisplayMember = "CompanyName"
    End Sub

    Private Sub cbxDatos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxDatos.SelectedValueChanged
        Dim obj As HashSet(Of Orders) = cbxDatos.SelectedItem.Orders
        dgvDatos.DataSource = obj.ToList
    End Sub

    Private Sub BtnPulsar4_Click(sender As Object, e As EventArgs) Handles btnPulsar4.Click
        Dim obj As Object
        obj = (From cust In modelo.Customers
               Join ord In modelo.Orders
                   On cust.CustomerID Equals ord.CustomerID
               Group By ID = cust.CustomerID, Nombre = cust.ContactName
                   Into Ordenes = Group, Total = Count()
               Select ID, Nombre, Ordenes, Total).ToList
        dgvDatos.DataSource = obj
    End Sub

    Private Sub BtnPulsar5_Click(sender As Object, e As EventArgs) Handles btnPulsar5.Click
        Dim obj As Object
        obj = (From cust In modelo.Customers
               Group Join ord In modelo.Orders
                       On cust.CustomerID Equals ord.CustomerID
                       Into CustomerOrders = Group, TotalFacturado = Sum(ord.Order_Details.Sum(Function(x) x.Quantity * x.UnitPrice + (1 - x.Discount)))
               Select cust.CustomerID, TotalFacturado, CustomerOrders.Count
        ).ToList

        dgvDatos.DataSource = obj
    End Sub

    Private Sub BtnPulsar6_Click(sender As Object, e As EventArgs) Handles btnPulsar6.Click, btnPulsar.Click
        Dim obj As Double
        obj = Aggregate od In modelo.Order_Details
                  Into Sum(od.Quantity * od.UnitPrice * (1 - od.Discount))


    End Sub

    Private Sub BtnPulsar7_Click(sender As Object, e As EventArgs) Handles btnPulsar7.Click
        res = (From orders In modelo.Orders
               Aggregate od In orders.Order_Details
            Into Total = Sum(od.Quantity * od.UnitPrice * (1 - od.Discount))
               Where orders.CustomerID = txtEstado.Text
               Select x = Total).Sum()

        MsgBox(res)
    End Sub

    Private Sub BtnPulsar8_Click(sender As Object, e As EventArgs) Handles btnPulsar8.Click
        Dim res = (From orders In modelo.Orders
                   Let Total = orders.Order_Details.Sum(Function(o) o.Quantity * o.UnitPrice * o.Discount)
                   Where Total > 100
                   Select orders.OrderID, Total).ToList
        dgvDatos.DataSource = res
    End Sub

    Private Sub BtnPulsar9_Click(sender As Object, e As EventArgs) Handles btnPulsar9.Click
        Dim res = (From od In modelo.Order_Details
                   Let Total = od.Quantity * od.UnitPrice * (1 - od.Discount)
                   Where od.OrderID = CInt(txtEstado.Text)
                   Select od.OrderID, od.Products.ProductName, Total).ToList
        dgvDatos.DataSource = res
    End Sub

    Private Sub BtnPulsar10_Click(sender As Object, e As EventArgs) Handles btnPulsar10.Click
        Dim res = (From cust In modelo.Customers
                   Select New With {.ciudad = cust.City}
                   Distinct).ToList
        mostrar(res)
    End Sub



    Private Sub BtnPulsar11_Click(sender As Object, e As EventArgs) Handles btnPulsar11.Click
        Dim res As Object
        res = (From cust In modelo.Customers.ToList
               Order By cust.City
               Skip While cust.City.StartsWith("A")
               Select New With {.ciudad = cust.City}
               Distinct).ToArray
        'res = (From x In res.ToList
        '       Skip While x.ciudad.StartsWith("A")
        '       Select x.ciudad).ToArray
        mostrar(res)
    End Sub

    Private Sub mostrar(res As Object)
        dgvDatos.DataSource = res
    End Sub
End Class
