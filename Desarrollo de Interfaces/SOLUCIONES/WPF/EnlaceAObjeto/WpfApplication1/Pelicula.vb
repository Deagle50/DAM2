Imports System.ComponentModel
Imports System.Collections.ObjectModel
Public Enum Generos
Mafia
Drama
Catastrofismo
Aventuras
Comedia
Oeste
CienciaFiccion
End Enum

Public Class Pelicula
    Implements INotifyPropertyChanged

    Private titulo As String
    Private genero As Generos
Private oscar As Boolean
Private calificacion As Double
Private Actores As New ObservableCollection(Of String)
Public Sub New()

End Sub
Public Sub New(titulo As String, genero As Generos, oscar As Boolean, calificacion As Double)
     Me.titulo = titulo
     Me.genero = genero
     Me.oscar = oscar
     Me.calificacion = calificacion
End Sub
Public Property Title As String

Get
Return titulo
End Get

Set(value As String)
titulo = value
            'RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Title"))
        End Set
End Property
Public Property Genre As Generos
Get
 Return genero
End Get
Set(value As Generos)
genero = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Genre"))
End Set
End Property
Public Property award As Boolean
Set(value As Boolean)
oscar = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("award"))
End Set
Get
Return oscar
End Get
End Property
Public Property rate As Double
Set(value As Double)
calificacion = value
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("rate"))
End Set
Get
Return calificacion
End Get
End Property
Public ReadOnly Property Actors As ObservableCollection(Of String)
Get
Return Actores
End Get
End Property

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

End Class
