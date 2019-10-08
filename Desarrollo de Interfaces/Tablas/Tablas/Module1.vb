Module Module1
    Dim tabla(,) As String

    Public Function Buscar() As Integer
        Dim i As Integer
        For i = 0 To tabla.Length
            If tabla(i, 0).CompareTo(palabra) = 0 Then
        Next
    End Function
End Module
