Module Module1

    Public tam As Integer = 0



    Public Structure trabajador
        Public DNI As String
        Public Nombre As String
        Public Apellido As String
        Public Horas As Single
    End Structure

    Public Trabajadores() As trabajador
    Public i As Integer

    Public Function registrar(dni As String) As Integer
        For i = 0 To tam - 1
            If Trabajadores(i).DNI.CompareTo(dni) = 0 Then
                Return 1
            End If
        Next
        Return -1
    End Function

End Module
