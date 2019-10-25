Public Class nuevoDato
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nota As Integer = Integer.Parse(txtNota.Text)
        Dim alumno As String = txtNombre.Text
        If nota < 0 Or nota > 10 Then
            MsgBox("Error, escribe una nota entre 0 y 10")
        ElseIf colleccion.Contains(txtNombre.Text) Then
            MsgBox("Error, el alumno ya existe")
        End If
    End Sub
End Class