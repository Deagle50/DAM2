Public Class Producto
    Dim _nombre As String
    Dim _categoria As String
    Dim _id As Integer

    Public Sub New(nombre As String, categoria As String, id As Integer)
        _nombre = nombre
        _categoria = categoria
        _id = id
    End Sub

    Public Property Nombre
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
End Class
