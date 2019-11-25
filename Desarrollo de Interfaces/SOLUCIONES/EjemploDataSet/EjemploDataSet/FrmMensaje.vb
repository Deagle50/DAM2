Public Class FrmMensaje
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub FrmMensaje_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim filas() As DataRow
        filas = usuactual.GetChildRows("UsariosMensajes")
        ListView1.Items.Clear()

        For Each r As DataRow In filas

            Dim it As ListViewItem
            it = ListView1.Items.Add(r("idMensaje").ToString)
            For i As Integer = 1 To ds.Tables("Mensajes").Columns.Count - 1
                If Not IsDBNull(r(i)) Then
                    it.SubItems.Add(r(i).ToString)
                End If
            Next


        Next
    End Sub
End Class