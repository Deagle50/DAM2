Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Where eq.Memoria <= 64
               Select New With {eq.CodEquipo, eq.Procesador, eq.Velocidad}).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Where eq.CodEquipo = txtCodigo.Text
               Select New With {eq.CodEquipo, eq.CDROM, eq.DiscoDuro, eq.Memoria, eq.Procesador, eq.TarjetaRed, eq.Uso, eq.Velocidad}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Where eq.Procesador = "PENTIUM III"
               Select New With {eq.CodEquipo, eq.CDROM, eq.DiscoDuro, eq.Memoria, eq.Procesador, eq.TarjetaRed, eq.Uso, eq.Velocidad}).ToArray
        DataGridView1.DataSource = Res
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Where eq.DiscoDuro >= CInt(txtdisco1.Text) And eq.DiscoDuro <= CInt(txtdisco2.Text)
               Select New With {eq.CodEquipo, eq.CDROM, eq.DiscoDuro, eq.Memoria, eq.Procesador, eq.TarjetaRed, eq.Uso, eq.Velocidad}).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Where eq.Procesador = "PENTIUM" Or eq.Procesador = "PENTIUM II"
               Select New With {eq.CodEquipo, eq.CDROM, eq.DiscoDuro, eq.Memoria, eq.Procesador, eq.TarjetaRed, eq.Uso, eq.Velocidad}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim RES As Object
        RES = (From eq In modelo.Equipos
               Where eq.CDROM > 30 Or eq.CDROM < 10
               Select New With {eq.CodEquipo, eq.CDROM, eq.DiscoDuro, eq.Memoria, eq.Procesador, eq.TarjetaRed, eq.Uso, eq.Velocidad}).ToArray
        DataGridView1.DataSource = Res
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim RES As Object
        RES = (From eq In modelo.Equipos
               Aggregate eqaux In modelo.Equipos
               Into Maximo = Max(eqaux.Velocidad)
               Where eq.Velocidad = Maximo
               Select New With {eq.Velocidad}).ToArray



        DataGridView1.DataSource = RES
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim RES As Integer
        RES = Aggregate eqaux In modelo.Equipos
               Into Minimo = Min(eqaux.Velocidad)
        Dim lista As New ArrayList()
        lista.Add(New With {.Minimo = RES})
        DataGridView1.DataSource = lista

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Where u.CodEquipo = txtCodEq.Text
               Select New With {.nombre = u.Nombre, .apellido = u.Apellido}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Where u.CodUsuario = txtCodUsuario.Text
               Select New With {u.Nombre, u.Apellido, u.Direccion, u.Telefono}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Where u.Nombre.StartsWith("U") And u.Apellido.StartsWith("A")
               Select New With {u.Nombre, u.Apellido, u.Direccion, u.Telefono}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Where u.CodEquipo = "0001" Or u.CodEquipo = "0002"
               Select New With {u.Nombre, u.Apellido, u.Direccion, u.Telefono}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Where u.CodUsuario = txtCodUsuario.Text
               Select New With {u.Nombre, u.Apellido, u.Direccion, u.Telefono}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Where i.FechaInstalacion >= CDate(txtFecha.Text) And i.FechaInstalacion <= CDate(txtFecha2.Text)
               Select New With {i.CodInstalacion, i.CodEquipo, i.CodSoftware, i.FechaInstalacion}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Where i.CodEquipo = txtCodEquipoI.Text
               Select New With {i.CodInstalacion, i.CodEquipo, i.CodSoftware, i.FechaInstalacion}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Where i.CodEquipo = "0001" And i.FechaInstalacion.Value.Year = 2007
               Select New With {i.CodInstalacion, i.CodEquipo, i.CodSoftware, i.FechaInstalacion}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Where i.CodSoftware = "0004" And i.FechaInstalacion.Value.Year = 2006
               Select New With {i.CodInstalacion, i.CodEquipo, i.CodSoftware, i.FechaInstalacion}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Group By Software = i.CodSoftware
                    Into Instalaciones = Group
               Select New With {Software, Instalaciones.Count}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Group By Equipo = i.CodEquipo
                    Into Instalaciones = Group
               Select New With {Equipo, Instalaciones.Count}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim res As Object

        res = (From i In modelo.Instalaciones
               Group By Software = i.CodSoftware
                    Into Instalaciones = Group
               Select New With {Software, .ultima = Instalaciones.Max(Function(x) x.FechaInstalacion)}).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim res As Object

        res = (From i In modelo.Instalaciones
               Where i.CodEquipo = TextBox1.Text
               Group By Equipo = i.CodEquipo
                    Into Instalaciones = Group
               Select New With {Equipo, .ultima = Instalaciones.Max(Function(x) x.FechaInstalacion)}).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim res As Object

        res = (From i In modelo.Instalaciones
               Where i.FechaInstalacion.Value.Year = DateTime.Now.Year
               Let nuevo = i.FechaInstalacion
               Select New With {i.CodInstalacion, i.CodEquipo, i.CodSoftware, i.FechaInstalacion, .fechasig = System.Data.Entity.DbFunctions.AddDays(i.FechaInstalacion, 90)}).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Select u.Nombre, u.Equipos.CodEquipo, u.Equipos.Procesador, u.Equipos.Velocidad).ToArray
        DataGridView1.DataSource = res

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Join u In modelo.Usuarios
                     On eq.CodEquipo Equals u.CodEquipo
               Select u.Nombre, eq.CodEquipo, eq.Procesador, eq.Velocidad).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Select eq.CodEquipo, eq.Procesador, eq.Velocidad, eq.Usuarios.Count()).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Group Join u In modelo.Usuarios
                     On eq.CodEquipo Equals u.CodEquipo
               Into Grupo = Group
               Select eq.Procesador, eq.Velocidad, eq.CodEquipo, Grupo.Count).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim res As Object
        res = (From u In modelo.Usuarios
               Where u.Equipos.CodEquipo = CInt(txtCodEq4.Text)
               Select u.Nombre, u.Apellido, u.Equipos.CodEquipo, u.Equipos.Procesador, u.Equipos.Velocidad).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Join u In modelo.Usuarios
                     On eq.CodEquipo Equals u.CodEquipo
               Where eq.CodEquipo = txtCodEq4.Text
               Select u.Nombre, eq.CodEquipo, eq.Procesador, eq.Velocidad).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Where i.Software.Distribuidor = "Microsoft"
               Select i.Software.CodSoftware, i.Software.Nombre, i.Equipos.CodEquipo).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim res As Object
        res = (From eq In modelo.Equipos
               Join i In modelo.Instalaciones
              On eq.CodEquipo Equals i.CodEquipo
               Join sw In modelo.Software
                   On sw.CodSoftware Equals i.CodSoftware
               Where sw.Distribuidor = "Microsoft"
               Select i.Software.CodSoftware, i.Software.Nombre, i.Equipos.CodEquipo).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Select i.Software.CodSoftware, i.Software.Nombre, i.Equipos.CodEquipo, i.Equipos.Memoria, calculada = i.Equipos.Memoria - i.Software.MemoriaRequerida).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Join eq In modelo.Equipos
                   On i.CodEquipo Equals eq.CodEquipo
               Join sw In modelo.Software
                   On sw.CodSoftware Equals i.CodSoftware
               Select i.Software.CodSoftware, i.Software.Nombre, i.Equipos.CodEquipo, i.Equipos.Memoria, calculada = i.Equipos.Memoria - i.Software.MemoriaRequerida).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim res As Object

        res = (From i In modelo.Instalaciones
               Group By Eq = i.Equipos
                    Into grupo = Group
               Select Eq.CodEquipo, Eq.Procesador, Eq.Velocidad, Total = grupo.Sum(Function(x) x.Software.MemoriaRequerida)).ToArray

        DataGridView1.DataSource = res
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim res As Object
        res = (From i In modelo.Instalaciones
               Join eq In modelo.Equipos
                   On i.CodEquipo Equals eq.CodEquipo
               Join sw In modelo.Software
                   On sw.CodSoftware Equals i.CodSoftware
               Group By equipo = eq
                       Into grupo = Group
               Select equipo.CodEquipo, equipo.Procesador, equipo.Velocidad, Total = grupo.Sum(Function(x) x.sw.MemoriaRequerida)).ToArray
        DataGridView1.DataSource = res
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim RES As Object
        RES = (From u In modelo.Usuarios
               Join i In modelo.Instalaciones
                       On u.CodEquipo Equals i.CodEquipo
               Select u.Nombre, u.Apellido, nombreSoftware = i.Software.Nombre).ToArray
        DataGridView1.DataSource = RES
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim Res As Object = (From u In modelo.Usuarios
                             Join eq In modelo.Equipos
                     On u.CodEquipo Equals eq.CodEquipo
                             Join i In modelo.Instalaciones
                     On eq.CodEquipo Equals i.CodEquipo
                             Join sw In modelo.Software
                     On i.CodSoftware Equals sw.CodSoftware
                             Select u.Nombre, u.Apellido, nombreSoftware = i.Software.Nombre).ToArray

        DataGridView1.DataSource = Res
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim RES As Object
        RES = (From u In modelo.Usuarios
               Join i In modelo.Instalaciones
                       On u.CodEquipo Equals i.CodEquipo
               Group By usuario = u
                       Into grupo = Group
               Select usuario.Nombre, usuario.Apellido, Total = grupo.Count).ToArray
        DataGridView1.DataSource = RES
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim Res As Object = (From u In modelo.Usuarios
                             Join eq In modelo.Equipos
                     On u.CodEquipo Equals eq.CodEquipo
                             Join i In modelo.Instalaciones
                     On eq.CodEquipo Equals i.CodEquipo
                             Join sw In modelo.Software
                     On i.CodSoftware Equals sw.CodSoftware
                             Group By usuario = u
                                     Into Grupo = Group
                             Select usuario.Nombre, usuario.Apellido, Total = Grupo.Count).ToArray

        DataGridView1.DataSource = Res
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim RES As Object
        RES = (From u In modelo.Usuarios
               Join i In modelo.Instalaciones
                       On u.CodEquipo Equals i.CodEquipo
               Where u.Nombre.StartsWith("A")
               Select u.Nombre, u.Apellido, Software = i.Software.Nombre).ToArray
        DataGridView1.DataSource = RES
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim Res As Object = (From u In modelo.Usuarios
                             Join eq In modelo.Equipos
                     On u.CodEquipo Equals eq.CodEquipo
                             Join i In modelo.Instalaciones
                     On eq.CodEquipo Equals i.CodEquipo
                             Join sw In modelo.Software
                     On i.CodSoftware Equals sw.CodSoftware
                             Where u.Nombre.StartsWith("A")
                             Select u.Nombre, u.Apellido, software = sw.Nombre).ToArray

        DataGridView1.DataSource = Res
    End Sub

    Private Sub MantenimientoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoClientesToolStripMenuItem.Click
        Form2.ShowDialog()

    End Sub
End Class
