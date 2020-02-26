
Imports System.ComponentModel
Imports WPFAnuncios.WPFAnuncios
Public Class AnunciosViewModel
    Implements INotifyPropertyChanged
    Private _anunciante As Anunciantes
    Private actualIndex As Integer
    Private modelo As WPFAnuncios.DaniDBEntities
    Public Sub New(model As DaniDBEntities)
        ''Crea un nuevo View model inicializando el modelo de datos
        modelo = model
    End Sub
    Public Property Anunciante As Anunciantes
        ''Devuelve la variable anunciante. Que es el que estoy visualizando.
        Get
            Return _anunciante
        End Get
        Set(value As Anunciantes)
            _anunciante = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Anunciante"))
        End Set
    End Property
    Public ReadOnly Property AnuncioActual As WPFAnuncios.Anuncios
        ''Devuelve el anuncio que se visualiza actualmente
        Get
            Return _anunciante.Anuncios(actualIndex)
        End Get
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Anterior()
        ''Retrocede al anuncio anterior del anunciante actual
        If actualIndex > 0 Then
            actualIndex -= 1
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("AnuncioActual"))
        End If
    End Sub
    Public Sub Siguiente()
        ''Avanza al  siguiente anuncio del anunciante actual.
        If actualIndex < _anunciante.Anuncios.Count - 1 Then
            actualIndex += 1
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("AnuncioActual"))
        End If
    End Sub
    Public Sub Eliminar()
        ''Elimina el anuncio actual
        modelo.Anuncios.Remove(AnuncioActual)
        modelo.SaveChanges()
        actualIndex = 0
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("AnuncioActual"))
    End Sub

End Class
