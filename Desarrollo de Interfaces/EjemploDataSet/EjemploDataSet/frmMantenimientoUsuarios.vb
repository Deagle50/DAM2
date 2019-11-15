Public Class frmMantenimientoUsuarios
    Dim r As DataRow
    Dim tabla As DataTable = ds.Tables("Usuarios")
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        r = tabla.NewRow()

        r.BeginEdit()
        r("idUsuario") = txtUsuario.Text
        r("palabrapaso") = txtPass.Text
        r("nombre") = txtNombre.Text
        r("apellidos") = txtApellido.Text
        r("email") = txtEmail.Text
        r("DNI") = txtDNI.Text
        r.EndEdit()


        tabla.Rows.Add(r)

        Me.Dispose()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        r = tabla.Rows.Find(txtUsuario.Text)
        If r Is Nothing Then
            btnAgregar.Enabled = True
            btnModificar.Enabled = False
            btnBorrar.Enabled = False
        Else
            MostrarFila(r)
            btnAgregar.Enabled = False
            btnModificar.Enabled = True
            btnBorrar.Enabled = True

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        r.BeginEdit()

        r("palabrapaso") = txtPass.Text
        r("nombre") = txtNombre.Text
        r("apellidos") = txtApellido.Text
        r("email") = txtEmail.Text
        r("DNI") = txtDNI.Text
        r.EndEdit()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("¿Estás seguro?", vbYesNo)
        If resp = vbYes Then
            r.Delete()
            MsgBox("Registro eliminado")
        End If

    End Sub

    Private Sub MostrarFila(r As DataRow)
        txtNombre.Text = r("nombre")
        txtApellido.Text = r("apellidos")
        txtDNI.Text = r("DNI")
        txtEmail.Text = r("email")
        txtPass.Text = r("palabrapaso")
        txtUsuario.Text = r("idusuario")

    End Sub
End Class