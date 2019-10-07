Module Module1
    Public Structure Cliente
        Public nCliente As String
        Public nombre As String
        Public Saldo As Single
    End Structure

    Public Clientes() As Cliente
    Public cont As Integer

    Public Function Buscar(num As String) As Integer
        Dim i As Integer
        For i = 0 To cont - 1
            If Clientes(i).nCliente.CompareTo(num) = 0 Then
                Return i

            End If
        Next
        Return -1

    End Function
End Module
