Imports System.Collections.ObjectModel
Imports System.ComponentModel
Public Class Director
Implements INotifyPropertyChanged

Dim nom As String
Dim nac As String
    Dim pelis As New ObservableCollection(Of Pelicula)
    Public Property Nombre As String
Get
Return nom
End Get
        Set(value As String)
            nom = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Nombre"))
        End Set
    End Property
Public Property Nacionalidad As String
Get
Return nac
End Get
Set(value As String)
nac = value
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Nacionalidad"))
End Set
End Property
    Public ReadOnly Property Peliculas As ObservableCollection(Of Pelicula)
        Get
            Return pelis
        End Get
    End Property
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
End Class
