Public Class frmMantenimiento
    Dim r As DataRow
    Dim tabla As DataTable = ds.Tables("Usuarios")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        r = tabla.NewRow
        r.BeginEdit()
        r("idUsuario") = txtUsuario.Text
        r("Nombre") = txtNombre.Text
        r("Apellidos") = txtApellido.Text
        r("DNI") = txtDNI.Text
        r("email") = txtEmail.Text
        r("palabrapaso") = txtPassword.Text
        r.EndEdit()
        tabla.Rows.Add(r)
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    Private Sub MostrarFila(r As DataRow)
        txtNombre.Text = r("Nombre")
        txtApellido.Text = r("Apellidos")
        txtDNI.Text = r("DNI")
        txtEmail.Text = r("email")
        txtPassword.Text = r("palabrapaso")
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        r.BeginEdit()
        r("Nombre") = txtNombre.Text
        r("Apellidos") = txtApellido.Text
        r("DNI") = txtDNI.Text
        r("email") = txtEmail.Text
        r("palabrapaso") = txtPassword.Text
        r.EndEdit()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("¿Está seguro?", vbYesNo)
        If resp = vbYes Then
            r.Delete()
            MsgBox("Registro eliminado")
        End If
    End Sub
End Class