Module Module1

    Sub Main()
        Dim num As Integer
        Dim res As Integer = 0
        Console.WriteLine("Escribe un número")
        num = Console.ReadLine()
        If num > 0 Then
            For i = 1 To num
                Console.WriteLine(num & "*" & i & "=" & i * num)
            Next
        ElseIf num < 0 Then
            For i = num To -1
                Console.WriteLine(num & "*" & i & "=" & i * num)
            Next
        End If
        Console.WriteLine("Fin del programa")
        Console.ReadLine()
    End Sub

End Module
