Module Module1

    Sub Main()
        Dim suma As Integer = 0
        Dim num As Integer
        Console.WriteLine("Numero:")
        num = CInt(Console.ReadLine)
        While num <> 0
            suma += num
            Console.WriteLine("Numero:")
            num = CInt(Console.ReadLine)
        End While
        Console.WriteLine("La suma es {0}", suma)
        Console.ReadLine()
    End Sub

End Module
