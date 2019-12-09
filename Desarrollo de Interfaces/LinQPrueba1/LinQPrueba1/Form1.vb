Public Class Form1
    Dim res As Object
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim x() As Integer = {1, 2, 3, 4}
        res = (
                From empleado In modelDatos.Employees.ToList
                Order By empleado.City
                Group By EmpleadosCiudad = empleado.City
                Into GrupoEmpleados = Group, Count()
                Select EmpleadosCiudad, GrupoEmpleados, GrupoEmpleados.Count
              ).ToList

        cbxData.DataSource = res
        cbxData.DisplayMember = "EmpleadosCiudad"
        cbxData.ValueMember = "GrupoEmpleados"

        res = From i In x
              Where i Mod 2 = 0
              Order By i
              Select i
    End Sub


    Private Sub cbxData_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxData.SelectedValueChanged
        dgvEmpleados.DataSource = cbxData.SelectedValue
    End Sub
End Class
