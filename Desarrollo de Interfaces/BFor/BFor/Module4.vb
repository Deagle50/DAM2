Module Module4
    Sub main()
        Dim inicial As Double
        Dim interes As Double
        Dim anos As Integer
        Console.WriteLine("Escribe el capital inicial")
        inicial = Console.ReadLine()
        Console.WriteLine("Escribe los años")
        anos = Console.ReadLine()
        Console.WriteLine("Escribe el interés")
        interes = Console.ReadLine()
        Console.WriteLine("Año   Capital Acumulado")
        For i = 0 To anos
            If i = 0 Then
                Console.WriteLine("Capital inicial " & inicial)
            Else
                inicial = inicial * (1.0 + interes / 100)
                Console.WriteLine(i & "   " & inicial)
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
