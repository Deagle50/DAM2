Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim res As Object = (
                                      From empleado In modelDatos.Employees.ToList
                                      Order By empleado.City
                                      Group By EmpleadosCiudad = empleado.City
                                      Into GrupoEmpleados = Group, Count()
                                      Select EmpleadosCiudad, GrupoEmpleados, GrupoEmpleados.Count
                                  ).ToList

        dgvEmpleados.DataSource = res(0).GrupoEmpleados

    End Sub
End Class
