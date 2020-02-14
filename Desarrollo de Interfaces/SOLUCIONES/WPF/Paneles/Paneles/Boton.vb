Public Class Boton
    Dim a, b, c As String
    Public Property Boton1 As String
        Get
            Return a
        End Get
        Set(value As String)
            a = value
        End Set
    End Property
    Public Property Boton2 As String
        Get
            Return b
        End Get
        Set(value As String)
            b = value
        End Set
    End Property
    Public Property Boton3 As String
        Get
            Return c
        End Get
        Set(value As String)
            c = value
        End Set
    End Property


    Public Sub New(b1 As String, b2 As String, b3 As String)
        a = b1
        b = b2
        c = b3

    End Sub
End Class
