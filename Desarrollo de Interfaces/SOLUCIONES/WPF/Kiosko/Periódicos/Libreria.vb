Public Class Libreria
    Inherits System.Collections.CollectionBase
    Default Public Property Item(ByVal id As Integer) As Enlace
        Get
            Return List(id)
        End Get
        Set(ByVal value As Enlace)
            List(id) = value
        End Set
    End Property

    Public Sub Add(ByVal it As Enlace)
        List.Add(it)
    End Sub
    Public Overloads Sub RemoveAt(ByVal id As Integer)
        List.RemoveAt(id)
    End Sub
    Public Sub Remove(ByVal en As Enlace)
        List.Remove(en)
    End Sub
    Public Sub IndexOf(ByVal en As Enlace)
        List.IndexOf(en)
    End Sub
    Public Sub Insert(ByVal id As Integer, ByVal en As Enlace)
        List.Insert(id, en)
    End Sub
    Public Sub New()

    End Sub
    Public Overloads Sub Clear()
        List.Clear()
    End Sub
    Public ReadOnly Property Lista() As IList
        Get
            Return List
        End Get
    End Property
End Class
