Imports System
Imports LibreriaFichero

Module Program
    Sub Main(args As String())
        Dim Texto As String
        Dim Fichero As String
        Console.WriteLine("Texto: ")
        Texto = Console.ReadLine()
        Console.WriteLine("Fichero: ")
        Fichero = Console.ReadLine()
        Dim Gestor As New GestorFichero
        Gestor.FileName = Fichero
        Gestor.Text = Texto
        Gestor.Store()
    End Sub
End Module
