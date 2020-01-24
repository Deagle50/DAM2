Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Object
        res = (From cli In modelo.CLIENTES
               Join vh In modelo.VEHICULOS
                  On cli.DNI Equals vh.DNI
               Where vh.Color = "BLANCO" And vh.Marca = "Opel"
               Select cli.Nombre, cli.DNI, cli.FormadePago, cli.Poblacion, cli.Domicilio, cli.CodigoPostal, cli.Telefono).ToList

        DataGridView1.DataSource = res

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As Object
        res = (From vh In modelo.VEHICULOS
               Where vh.Color = "BLANCO" And vh.Marca = "Opel"
               Let cli = vh.CLIENTES
               Select cli.Nombre, cli.DNI, cli.FormadePago, cli.Poblacion, cli.Domicilio, cli.CodigoPostal, cli.Telefono).ToList

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim res As Object
        res = (From cli In modelo.CLIENTES
               Join vh In modelo.VEHICULOS
                  On cli.DNI Equals vh.DNI
               Where vh.Color = "BLANCO" Or vh.Color = "NEGRO" Or vh.Marca = "Opel"
               Select cli.Nombre, cli.DNI, cli.FormadePago, cli.Poblacion, cli.Domicilio, cli.CodigoPostal, cli.Telefono Distinct).ToList

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim res As Object
        res = (From vh In modelo.VEHICULOS
               Where vh.Color = "BLANCO" Or vh.Color = "NEGRO" Or vh.Marca = "Opel"
               Let cli = vh.CLIENTES
               Select cli.Nombre, cli.DNI, cli.FormadePago, cli.Poblacion, cli.Domicilio, cli.CodigoPostal, cli.Telefono Distinct).ToList

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim res As Object
        res = (From cli In modelo.CLIENTES
               Where cli.Poblacion = "DONOSTIA"
               Select cli.Nombre, cli.DNI, cli.FormadePago, cli.Poblacion, cli.Domicilio, cli.CodigoPostal, cli.Telefono).ToList
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Object
        res = (From cli In modelo.CLIENTES
               Where cli.Poblacion = txtCiudad.Text
               Select cli.Nombre, cli.DNI, cli.FormadePago, cli.Poblacion, cli.Domicilio, cli.CodigoPostal, cli.Telefono).ToList
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim res As Object
        res = (From nota In modelo.NOTAS_REPARACIONES
               Where nota.FechadeReparacion.Value.Month = 5
               Select nota.CodigodeNota, nota.Descuento, nota.DNI, nota.FechadeReparacion).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim res As Object
        res = (From nota In modelo.NOTAS_REPARACIONES
               Where nota.FechadeReparacion.Value.Month < 4
               Select nota.CodigodeNota, nota.Descuento, nota.DNI, nota.FechadeReparacion).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim res As Object
        Dim fecha1, fecha2 As Date
        fecha1 = Date.Parse(InputBox("Fecha Inicio"))
        fecha2 = Date.Parse(InputBox("Fecha Fin"))
        res = (From nota In modelo.NOTAS_REPARACIONES
               Where nota.FechadeReparacion.Value >= fecha1 And nota.FechadeReparacion.Value <= fecha2
               Select nota.CodigodeNota, nota.Descuento, nota.DNI, nota.FechadeReparacion).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim res As Object
        res = (From dn In modelo.DETALLES_NOTAS
               Join n In modelo.NOTAS_REPARACIONES
                       On dn.CodigodeNota Equals n.CodigodeNota
               Group By Nota = n
              Into detalles = Group
               Select New With {.Numero = Nota.CodigodeNota, .fecha = Nota.FechadeReparacion, .total = detalles.Sum(Function(x) x.dn.Importe)}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim res As Object
        res = (From c In modelo.CLIENTES
               Select c.Nombre, c.VEHICULOS.Count).ToArray
        DataGridView1.DataSource = res
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim res As Object
        res = (From c In modelo.CLIENTES Join v In modelo.VEHICULOS On
                       c.DNI Equals v.DNI
               Group By cliente = c
                        Into vehiculos = Group
               Select New With {.nombre = cliente.Nombre, .NVehiculos = vehiculos.Count}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim res As Object
        res = (From c In modelo.CLIENTES
               Where c.Nombre = txtCliente.Text
               Select New With {.Notas = c.NOTAS_REPARACIONES.Count}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim res As Object
        res = (From c In modelo.CLIENTES
               Group Join n In modelo.NOTAS_REPARACIONES
                   On c.DNI Equals n.DNI
                   Into grupo = Group
               Where c.Nombre = txtCliente.Text
               Select New With {.Notas = grupo.Count}).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim res As Object
        res = (From n In modelo.NOTAS_REPARACIONES
               Select New With {.nombre = n.CLIENTES.Nombre, .codigo = n.CodigodeNota, .fecha = n.FechadeReparacion, .total = n.DETALLES_NOTAS.Sum(Function(x) x.Importe)}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim res As Object
        res = (From c In modelo.CLIENTES
               Join n In modelo.NOTAS_REPARACIONES
                      On c.DNI Equals n.DNI
               Join dn In modelo.DETALLES_NOTAS
                                On dn.CodigodeNota Equals n.CodigodeNota
               Group By Cliente = c, Nota = n
                       Into Grupo = Group
               Select New With {.nombre = Cliente.Nombre, .codigo = Nota.CodigodeNota, .fecha = Nota.FechadeReparacion, .total = Grupo.Sum(Function(x) x.dn.Importe * (1 - x.n.Descuento))}).ToArray

        DataGridView1.DataSource = res
    End Sub
End Class
