Imports ConsultarVehiculos.ConsultarVehiculos
Public Class Form1
    Dim res As Object
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        '1.	Visualizar todos los datos de los clientes que posean un vehículo de la marca Opel blanco (Consulta de selección).
        res = (
               From coche In modelo.VEHICULOS
               Join cli In modelo.CLIENTES
                   On coche.DNI Equals cli.DNI
               Where coche.Color = "Blanco" And coche.Marca = "BMW"
               Select coche.Marca, coche.Modelo, cli.Nombre, cli.Domicilio, cli.Poblacion, cli.Codigo_postal
              ).ToList
        mostrar(res)
    End Sub



    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        '2.	Visualizar todos los datos de los clientes que posean un vehículo de la marca Opel o sea de color blanco o negro (Consulta de selección).
        res = (
            From coche In modelo.VEHICULOS
            Join cli In modelo.CLIENTES
                    On coche.DNI Equals cli.DNI
            Where (coche.Color = "Blanco" Or coche.Color = "Negro") And coche.Marca = "Opel"
            Select cli.Nombre, cli.Domicilio, cli.Poblacion, cli.Codigo_postal
            ).ToList
        mostrar(res)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        '3.	Visualizar todos los datos de los clientes que residan en DONOSTIA (Consulta de selección).
        res = (
            From cli In modelo.CLIENTES
            Where cli.Poblacion = "Donostia"
            Select cli.Nombre, cli.Domicilio, cli.Poblacion, cli.Codigo_postal
            ).ToList
        mostrar(res)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        '
        '4.	Generalizar la consulta para que pida intervención del usuario solicitando 
        'el nombre de la población y visualice todos los datos de los clientes que residan 
        'en dicha población (Consulta de parámetros).
        '
        Dim poblacion As String
        poblacion = InputBox("Escribe el nombre de la población a consultar").ToString
        res = (
            From cli In modelo.CLIENTES
            Where cli.Poblacion = poblacion
            Select cli.Nombre, cli.Domicilio, cli.Codigo_postal
            ).ToList
        mostrar(res)

    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        '5.	Mostrar por pantalla todos los datos de las notas de reparaciones que se han emitido durante el mes de Mayo (Consulta de selección).
        res = (
            From notas In modelo.NOTAS_REPARACIONES
            Join detalles_notas In modelo.DETALLES_NOTAS
                    On notas.Codigo_de_nota Equals detalles_notas.Codigo_de_nota
            Where Month(notas.Fecha_de_reparacion) = 3
            Select notas.Codigo_de_nota, notas.DNI, notas.Fecha_de_reparacion, notas.Descuento,
                    notas.Observaciones, detalles_notas.Importe, detalles_notas.Linea, detalles_notas.Tipo,
                    detalles_notas.Ampliacion
            ).ToList
        mostrar(res)
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        '6.	Visualizar por pantalla todos los datos de las notas de reparaciones 
        'que se han emitido durante el primer trimestre de año 2003 (Consulta de selección).
        res = (
            From notas In modelo.NOTAS_REPARACIONES
            Join detalles_notas In modelo.DETALLES_NOTAS
                    On notas.Codigo_de_nota Equals detalles_notas.Codigo_de_nota
            Where Month(notas.Fecha_de_reparacion) = 1 Or Month(notas.Fecha_de_reparacion) = 2 Or Month(notas.Fecha_de_reparacion) = 3
            Select notas.Codigo_de_nota, notas.Fecha_de_reparacion, notas.Descuento, notas.DNI, notas.Observaciones,
                detalles_notas.Ampliacion, detalles_notas.Tipo, detalles_notas.Importe
            ).ToList
        mostrar(res)

    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        '
        '7.	Generalizar la consulta para que pida tanto la fecha inicial como 
        'la fecha final y sirva para consultar los datos de las notas de reparaciones 
        'emitidas durante ese periodo de tiempo (Consulta de parámetros).
        '
        Dim fechIn As String = InputBox("Escribe la fecha inicial").ToString
        Dim fechFIn As String = InputBox("Escribe la fecha inicial").ToString
        res = (
            From notas In modelo.NOTAS_REPARACIONES
            Join detalles_notas In modelo.DETALLES_NOTAS
                    On notas.Codigo_de_nota Equals detalles_notas.Codigo_de_nota
            Where notas.Fecha_de_reparacion > fechIn And notas.Fecha_de_reparacion < fechFIn
            Select notas.Codigo_de_nota, notas.Fecha_de_reparacion, notas.Descuento, notas.DNI, notas.Observaciones,
                detalles_notas.Ampliacion, detalles_notas.Tipo, detalles_notas.Importe
            ).ToList

        mostrar(res)

    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        '8.	Preparar una consulta para que nos de el total a pagar por cada una 
        'de las notas de reparaciones que tenemos registradas (Agrupación de registros).
        res = (
            From notas In modelo.NOTAS_REPARACIONES
            Join detalles_notas In modelo.DETALLES_NOTAS
                    On notas.Codigo_de_nota Equals detalles_notas.Codigo_de_nota
            Select notas.
                
            ).ToList
        mostrar(res)

    End Sub

    Private Sub mostrar(res As Object)
        dgvDatos.DataSource = res
    End Sub
End Class
