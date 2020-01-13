Imports ConsultasMantenimiento.ConsultasMantenimiento
Public Class Form1
    Dim res As Object

    Private Sub mostrar(res As Object)
        dgvDatos.DataSource = res
    End Sub

    'EQUIPOS

    Private Sub BtnConsulta1_Click(sender As Object, e As EventArgs) Handles btnConsulta1.Click
        '
        'o	Seleccionar codigo de equipo, procesador y velocidad de todos los Equipos con 64 Mb 
        'de memoria o menos.
        '

        res = (
            From pc In modelo.Equipos
            Where pc.Memoria <= 64
            Select pc.cod_equipo, pc.Procesador, pc.Velocidad, pc.Memoria
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta2_Click(sender As Object, e As EventArgs) Handles btnConsulta2.Click
        'o	Seleccionar todos los datos del equipo cuyo código se pida por teclado.

        Dim cod As Integer = Integer.Parse(InputBox("Introduce un número: "))

        res = (
            From pc In modelo.Equipos
            Where pc.cod_equipo = cod
            Select pc.cod_equipo, pc.disco_duro, pc.Procesador, pc.Velocidad, pc.CD_ROM, pc.Memoria, pc.tarjeta_red, pc.Uso
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta3_Click(sender As Object, e As EventArgs) Handles btnConsulta3.Click
        'o	Pedir dos valores y mostrar todos los datos de los equipos que tengan 
        'capacidad de disco duro entre esos valores.

        Dim valor1 As Double = Double.Parse(InputBox("Introduce el primer valor:"))
        Dim valor2 As Double = Double.Parse(InputBox("Introduce el segundo valor:"))

        res = (
            From pc In modelo.Equipos
            Where pc.disco_duro > valor1 And pc.disco_duro < valor2
            Select pc.cod_equipo, pc.disco_duro, pc.Procesador, pc.Velocidad, pc.CD_ROM, pc.Memoria, pc.tarjeta_red, pc.Uso
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta4_Click(sender As Object, e As EventArgs) Handles btnConsulta4.Click
        'o	Visualizar todos los datos de los equipos PENTIUM III.
        res = (
          From pc In modelo.Equipos
          Where pc.Procesador = "Pentium III"
          Select pc.cod_equipo, pc.disco_duro, pc.Procesador, pc.Velocidad, pc.CD_ROM, pc.Memoria, pc.tarjeta_red, pc.Uso
          ).ToList

        mostrar(res)

    End Sub

    Private Sub BtnConsulta5_Click(sender As Object, e As EventArgs) Handles btnConsulta5.Click
        'o	Visualizar todos los datos de los equipos PENTIUM III o Pentium II
        res = (
          From pc In modelo.Equipos
          Where pc.Procesador = "Pentium III" Or pc.Procesador = "Pentium II"
          Select pc.cod_equipo, pc.disco_duro, pc.Procesador, pc.Velocidad, pc.CD_ROM, pc.Memoria, pc.tarjeta_red, pc.Uso
          ).ToList

        mostrar(res)

    End Sub

    Private Sub BtnConsulta6_Click(sender As Object, e As EventArgs) Handles btnConsulta6.Click
        'o   Visualizar todos los datos de los equipos que tengan CD-ROM mayor que 30 ó menor de 10.
        res = (
            From pc In modelo.Equipos
            Where pc.CD_ROM < 30 And pc.CD_ROM > 10
            Select pc.cod_equipo, pc.disco_duro, pc.Procesador, pc.Velocidad, pc.CD_ROM, pc.Memoria, pc.tarjeta_red, pc.Uso
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta7_Click(sender As Object, e As EventArgs) Handles btnConsulta7.Click
        'o	Visualizar la velocidad del equipo más rápido.
        'res = (
        '    From pc In modelo.Equipos
        '    Order By pc.Velocidad Descending
        '    Select pc.Velocidad
        ').Take(1).ToList

        res = (
            From eq In modelo.Equipos
            Aggregate eqaux In modelo.Equipos
            Into maximo = Max(eqaux.Velocidad)
            Where eq.Velocidad = maximo
            Select New With {eq.Velocidad}
            ).ToArray

        mostrar(res)
    End Sub

    Private Sub BtnConsulta8_Click(sender As Object, e As EventArgs) Handles btnConsulta8.Click
        'o	Visualizar la memoria del equipo con menos memoria
        res = (
            From pc In modelo.Equipos
            Order By pc.Memoria Ascending
            Select pc.Memoria
        ).Take(1).ToList

        mostrar(res)
    End Sub

    'USUARIOS
    Private Sub BtnConsulta9_Click(sender As Object, e As EventArgs) Handles btnConsulta9.Click
        'o	Pedir un código de equipo y visualizar Nombre y apellido de todos los usuarios 
        'que tengan asociado ese equipo.
        Dim cod As Integer = Integer.Parse(InputBox("Introduce un numero"))

        res = (
            From user In modelo.Usuarios
            Where user.cod_equipo = cod
            Select user.Nombre, user.Apellido
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta10_Click(sender As Object, e As EventArgs) Handles btnConsulta10.Click
        'o	Pedir un código de usuario y mostrar todos sus datos.

        Dim cod As Integer = Integer.Parse(InputBox("Introduce un numero"))

        res = (
            From user In modelo.Usuarios
            Where user.Cod_Usuario = cod
            Select user.Nombre, user.Apellido, user.Direccion, user.Teléfono
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta11_Click(sender As Object, e As EventArgs) Handles btnConsulta11.Click
        'o	Mostrar todos los datos de los usuarios cuyo apellido empieza por “A” y su nombre por “U”.

        res = (
            From user In modelo.Usuarios
            Where user.Apellido.StartsWith("A") And user.Nombre.StartsWith("U")
            Select user.Nombre, user.Apellido, user.Direccion, user.Teléfono
            ).ToList

        mostrar(res)
    End Sub


    Private Sub BtnConsulta12_Click(sender As Object, e As EventArgs) Handles btnConsulta12.Click
        'o	Mostrar todos los datos de los usuarios asignados al equipo EQ-0001 o al EQ-0002

        res = (
            From user In modelo.Usuarios
            Where user.cod_equipo = 1 Or user.cod_equipo = 2
            Select user.Nombre, user.Apellido, user.Direccion, user.Teléfono
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta13_Click(sender As Object, e As EventArgs) Handles btnConsulta13.Click
        'o	Pedir un código de usuario y mostrar su nombre, apellidos, dirección y teléfono.

        Dim cod As Integer = Integer.Parse(InputBox("Introduce un número de usuario"))

        res = (
            From user In modelo.Usuarios
            Where user.Cod_Usuario = cod
            Select user.Nombre, user.Apellido, user.Direccion, user.Teléfono
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta14_Click(sender As Object, e As EventArgs) Handles btnConsulta14.Click
        'o	Pedir dos fechas y mostrar todos los datos de las instalaciones realizadas 
        'entre ellas(ambas inclusive).

        Dim fecha1 As Date = Date.Parse(InputBox("Introduce la primera fecha"))
        Dim fecha2 As Date = Date.Parse(InputBox("Introduce la segunda fecha"))

        res = (
            From inst In modelo.Instalaciones
            Where inst.fecha_instalacion > fecha1 And inst.fecha_instalacion < fecha2
            Select inst.cod_equipo, inst.cod_instalacion, inst.cod_software, inst.fecha_instalacion
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta15_Click(sender As Object, e As EventArgs) Handles btnConsulta15.Click
        'o	Pedir un código de equipo y mostrar todos los datos de todas sus instalaciones.

        Dim cod As Integer = Integer.Parse(InputBox("Introduce un código de equipo"))

        res = (
            From inst In modelo.Instalaciones
            Where inst.cod_equipo = cod
            Select inst.cod_equipo, inst.cod_instalacion, inst.cod_software, inst.fecha_instalacion
            ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta16_Click(sender As Object, e As EventArgs) Handles btnConsulta16.Click
        'o	Mostar las instalaciones hechas en el equipo EQ-0001 en 2007.

        res = (
            From inst In modelo.Instalaciones
            Where inst.cod_equipo = 1 And (Year(inst.fecha_instalacion)) = 2007
            Select inst.cod_equipo, inst.cod_instalacion, inst.cod_software, inst.fecha_instalacion
        ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta17_Click(sender As Object, e As EventArgs) Handles btnConsulta17.Click
        'o	Mostrar las instalaciones hechas en 2006 del software SW-0004.

        res = (
            From inst In modelo.Instalaciones
            Where inst.cod_software = 4 And Year(inst.fecha_instalacion) = 2006
            Select inst.cod_equipo, inst.cod_instalacion, inst.cod_software, inst.fecha_instalacion
        ).ToList

        mostrar(res)
    End Sub

    Private Sub BtnConsulta18_Click(sender As Object, e As EventArgs) Handles btnConsulta18.Click
        'o	Mostrar los códigos de software junto con el total de instalaciones hechas de dicho software.

        'res = (
        '    From inst In modelo.Instalaciones
        '    Group By inst.cod_software Into instalaciones = Group
        '    Select instalaciones.cod_software, inst.cod_software.Count
        '         ).ToList
    End Sub
End Class