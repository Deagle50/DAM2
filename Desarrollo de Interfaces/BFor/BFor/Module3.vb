Module Module3
    Dim tope As Integer = 5
    Dim suma As Integer = 0
    Dim num As Integer
    Dim media As Double

    Sub main()
        For i = 1 To tope
            Console.WriteLine("Escribe el número " & i)
            num = Console.ReadLine()
            suma = suma + num
        Next
        media = suma / tope
        Console.WriteLine("La media es " & media)
        Console.ReadLine()
    End Sub
End Module
