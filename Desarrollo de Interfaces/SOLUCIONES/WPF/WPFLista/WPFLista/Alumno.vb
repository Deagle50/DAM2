Public Class Alumno
    Dim _Nombre As String
    Dim _Apellido As String
    Dim _Id As String

    Public Sub New(nombre As String, apellido As String, id As String)
        Me._Nombre = nombre
        Me._Apellido = apellido
        Me._Id = id
    End Sub

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property
End Class
