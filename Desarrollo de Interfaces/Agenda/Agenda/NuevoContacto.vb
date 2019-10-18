Public Class NuevoContacto
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim max As Integer = agenda.Length
        Dim name As String = txtNombre.Text.ToString()
        Dim encontrado As Boolean = False
        Dim cont As Integer = 0
        For i = 0 To agenda.Length
            If name = agenda(i).Nombre Then
                encontrado = True
            End If
        Next
        If encontrado = False Then
            ReDim Preserve agenda(max)
            With agenda(max)
                agenda(max).Nombre = name
                agenda(max).Categoria = txtCategoria.Text.ToString()
                agenda(max).Direccion = txtDireccion.Text.ToString()
                agenda(max).Telefono = CInt(txtTelefono.Text)
            End With
            cont = cont + 1
        Else
            Dim res As MsgBoxResult = MsgBox("El contacto ya existe, ¿desea añadir un nuevo teléfono para ese contacto?",
                                           vbYesNo)
            If res = vbYes Then
                For i = 0 To agenda.Length
                    If name = agenda(i).Nombre Then
                        cont = cont + 1
                    End If
                Next
                ReDim Preserve agenda(max)
                With agenda(max)
                    agenda(max).Nombre = name + "-" + cont
                    agenda(max).Categoria = txtCategoria.Text.ToString()
                    agenda(max).Direccion = txtDireccion.Text.ToString()
                    agenda(max).Telefono = CInt(txtTelefono.Text)
                    agenda(max).Telefono = CInt(txtTelefono.Text)
                End With
            End If
        End If
    End Sub
End Class