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

    Private Sub BtnPulsar_Click(sender As Object, e As EventArgs) Handles btnPulsar6.Click, btnPulsar.Click
        Dim obj As Double
        obj = Aggregate od In modelo.Order_Details
                  Into Sum(od.Quantity * od.UnitPrice * (1 - od.Discount)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        res = (From orders In modelo.Orders
               Aggregate od In orders.Order_Details
            Into Sum(od.Quantity * od.UnitPrice * (1 - od.Discount))
               Where orders.CustomerID = txtEstado.Text
         [Select]       Select Total).Sum()

        MsgBox(res)
    End Sub
End Class
