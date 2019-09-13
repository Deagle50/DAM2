Imports System.IO

Public Class GestorFichero
    Private File As String
    Private Texto As String

    Public Property FileName As String
        Get
            Return File
        End Get
        Set(value As String)
            File = value
        End Set
    End Property

    Public Property Text As String
        Get
            Return Texto
        End Get
        Set(value As String)
            Texto = value
        End Set
    End Property

    Public Sub Store()
        Dim sw As New StreamWriter(File)
        sw.Write(Texto)
        sw.Close()
    End Sub

    Public Sub Load()
        Dim sr As New StreamReader(File)
        Texto = sr.ReadToEnd
        sr.Close()
    End Sub

End Class
