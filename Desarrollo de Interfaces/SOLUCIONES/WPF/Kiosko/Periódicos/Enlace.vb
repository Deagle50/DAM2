<Serializable()> Public Class Enlace
    Dim src As String
    Dim des As String
    Public Property Source() As String
        Get
            Return src
        End Get
        Set(ByVal value As String)
            src = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return des
        End Get
        Set(ByVal value As String)
            des = value
        End Set
    End Property
    Public Sub New(ByVal sr As String, ByVal ds As String)
        src = sr
        des = ds
    End Sub
    Public Sub New()

    End Sub
End Class
