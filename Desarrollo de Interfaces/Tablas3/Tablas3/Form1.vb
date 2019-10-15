Public Class Form1
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim i As Integer
        For i = 0 To cont - 1
            With tabla(i)
                If CInt(.NPedido = CInt(txtNPedido.Text)) Then
                    Dim res As MsgBoxResult = MsgBox("Ese producto ya está, acumular unidades?", vbYesNo)
                    If res = vbYes Then
                        .Unidades += CInt(txtUnidades.Text)
                    End If
                End If
            End With
            Exit Sub
        Next
        ReDim Preserve tabla(cont)
        With tabla(cont)
            .NPedido = CInt(txtNPedido.Text)
            .Producto = txtProducto.Text
            .Unidades = CInt(txtUnidades.Text)
            .Precio = CSng(txtPrecio.Text)
        End With
    End Sub
End Class
