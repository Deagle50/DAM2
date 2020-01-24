
Public Class Form2

    Dim u As ConsultasMantenimiento.Usuarios
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = modelo.Equipos.ToArray
        ComboBox1.DisplayMember = "Procesador"
        ComboBox1.ValueMember = "CodEquipo"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        u = (From u In modelo.Usuarios
             Where u.CodUsuario = CInt(txtCodigo.Text)
             Select u).FirstOrDefault
        If u Is Nothing Then
            ''no encontrado
            MsgBox("Elemento no encontrado")
            Button2.Enabled = True
            Button3.Enabled = False
            Button4.Enabled = False
            BorrarCajas()
        Else
            txtApellido.Text = u.Apellido
            txtNombre.Text = u.Nombre
            txtDireccion.Text = u.Direccion
            txtTelefono.Text = u.Telefono
            ComboBox1.SelectedValue = u.CodEquipo
            Button2.Enabled = False
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub BorrarCajas()
        For Each x In Me.Controls
            If TypeOf x Is TextBox And Not x Is txtCodigo Then
                x.Text = ""
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        u = New ConsultasMantenimiento.Usuarios With {.CodUsuario = CInt(txtCodigo.Text),
                                                      .Nombre = txtNombre.Text,
                                                      .CodEquipo = ComboBox1.SelectedValue,
                                                      .Apellido = txtApellido.Text,
                                                      .Direccion = txtDireccion.Text,
                                                      .Telefono = txtTelefono.Text}
        modelo.Usuarios.Add(u)
        modelo.SaveChanges()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("Estás seguro", vbYesNo)
        If (resp = vbYes) Then
            modelo.Usuarios.Remove(u)
        End If
        modelo.SaveChanges()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With u
            .Nombre = txtNombre.Text
            .CodEquipo = ComboBox1.SelectedValue
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
        End With
        modelo.SaveChanges()
    End Sub
End Class