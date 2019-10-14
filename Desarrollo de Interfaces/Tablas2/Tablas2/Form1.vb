Public Class Form1
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim DNI As String = txtDNI.Text.ToString()
        Dim nombre As String
        Dim apellido As String
        Dim num As Integer = registrar(DNI)
        If num = 1 Then
            Trabajadores(i).Horas = Trabajadores(i).Horas + CSng(txtHoras.Text)

            txtNombre.Text = Trabajadores(i).Nombre.ToString()
            txtApellido.Text = Trabajadores(i).Apellido.ToString()
            txtHoras.Text = Trabajadores(i).Horas.ToString()
        Else
            nombre = InputBox(txtNombre.Text, "Escribe el nombre")
            apellido = InputBox(txtApellido.Text, "Escribe el apellido")
            Trabajadores(tam).DNI = DNI
            Trabajadores(tam).Nombre = nombre
            Trabajadores(tam).Apellido = apellido
            Trabajadores(tam).Horas = CSng(txtHoras.Text)
            tam = tam + 1
        End If

    End Sub

    Private Sub BtnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click

    End Sub
End Class