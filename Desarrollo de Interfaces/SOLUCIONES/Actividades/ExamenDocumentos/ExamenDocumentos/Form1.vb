Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As New SqlCommand("SELECT Titulo,FechaCreacion FROM GUI1.Documentos WHERE IdDocumento=@id")
        consulta.Connection = con
        consulta.Parameters.AddWithValue("@id", txtId.Text)
        consulta.CommandType = CommandType.Text
        con.Open()
        Dim dr As SqlDataReader
        dr = consulta.ExecuteReader
        If dr.Read Then
            txtTitulo.Text = dr("Titulo")
            dr.Close()
            con.Close()

            LLenarDataSet(CInt(txtId.Text))
            LlenarListview(ds)
        Else
            con.Close()
            dr.Close()
            Dim res As MsgBoxResult = MsgBox("Desea dar de alta", vbYesNo)
            If res = vbYes Then
                Form2.txtId.Text = txtId.Text
                Form2.ShowDialog()
            End If
        End If
    End Sub

    Private Sub LlenarListview(ds As DataSet)
        ListView1.Items.Clear()
        For Each r As DataRow In ds.Tables("Revisiones").Rows
            Dim it As ListViewItem = ListView1.Items.Add(r("NumRevision"))
            it.SubItems.Add(r("FechaRevision"))
            If (r("Aprobada")) Then
                it.SubItems.Add("Aprobada")
            Else
                it.SubItems.Add("Pendiente")
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nueva As DataRow
        nueva = ds.Tables("Revisiones").NewRow
        nueva.BeginEdit()
        nueva("IdDocumento") = txtId.Text
        nueva("NumRevision") = CalcularId(CInt(txtId.Text))
        nueva("FechaRevision") = Now
        nueva("Aprobada") = False
        nueva.EndEdit()
        ds.Tables("Revisiones").Rows.Add(nueva)
        daRevisiones.Update(ds, "Revisiones")
        AgregarFila(nueva)
    End Sub

    Private Sub AgregarFila(r As DataRow)
        Dim it As ListViewItem = ListView1.Items.Add(r("NumRevision").ToString)
        it.SubItems.Add(r("FechaRevision").ToString)
        it.SubItems.Add("Pendiente")

    End Sub

    Private Function CalcularId(id As Integer) As Object
        'Dim consulta As New SqlCommand("Select max(NumRevision) FROM GUI1.Revisiones WHERE IdDocumento=@id")
        'consulta.Parameters.AddWithValue("@id", id)
        'consulta.CommandType = CommandType.Text
        'consulta.Connection = con
        'con.Open()
        'Dim num As Object = consulta.ExecuteScalar
        'con.Close()
        'If IsDBNull(num) Then
        '    Return 1
        'Else
        '    Return num + 1
        'End If
        Dim x As Object
        x = (From r In ds.Tables("Revisiones")
             Where r("IdDocumento") = id
             Select r("NumRevision")).Max
        If x Is Nothing Then
            Return 1
        Else
            Return x + 1
        End If
    End Function

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim idDocumento As Integer = CInt(txtId.Text)
        Dim NumRevision As Integer = ListView1.SelectedItems(0).Text
        Dim pk(1) As Object
        pk(0) = idDocumento
        pk(1) = NumRevision
        Dim r As DataRow = ds.Tables("Revisiones").Rows.Find(pk)
        r("Aprobada") = True
        daRevisiones.Update(ds, "Revisiones")
        ListView1.SelectedItems(0).SubItems(2).Text = "Aprobada"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ds.Tables("Revisiones").Rows.Count <> 0 Then
            For Each r As DataRow In ds.Tables("Revisiones").Rows
                r.Delete()
            Next
            daRevisiones.Update(ds, "Revisiones")
        End If
        Dim consulta As New SqlCommand("DELETE FROM GUI1.Documentos WHERE idDocumento=@id")
        consulta.Parameters.AddWithValue("@id", CInt(txtId.Text))
        consulta.CommandType = CommandType.Text
        consulta.Connection = con
        con.Open()
        consulta.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarAdaptador()
    End Sub
End Class
