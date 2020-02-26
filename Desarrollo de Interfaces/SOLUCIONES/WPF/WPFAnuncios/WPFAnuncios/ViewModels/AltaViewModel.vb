Imports System.ComponentModel

Public Class AltaViewModel
    Implements INotifyPropertyChanged
    Dim nuevoAnuncio As WPFAnuncios.Anuncios
    Dim modelo As WPFAnuncios.DaniDBEntities
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New(modelo As WPFAnuncios.DaniDBEntities)
        Me.modelo = modelo
        nuevoAnuncio = New WPFAnuncios.Anuncios
        nuevoAnuncio.IdAnuncio = modelo.Anuncios.Max(Function(x) x.IdAnuncio) + 1

    End Sub
    Public Sub Insertar()
        modelo.Anuncios.Add(nuevoAnuncio)
        modelo.SaveChanges()
    End Sub
    Public Property IdAnuncio As Integer
        Get
            Return nuevoAnuncio.IdAnuncio
        End Get
        Set(value As Integer)
            nuevoAnuncio.IdAnunciante = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("IdAnuncio"))
        End Set
    End Property

    Public Property IdAnunciante As Integer
        Get

            Return IIf(nuevoAnuncio.IdAnunciante Is Nothing, 0, nuevoAnuncio.IdAnunciante)
        End Get
        Set(value As Integer)
            nuevoAnuncio.IdAnunciante = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("IdAnunciante"))
        End Set
    End Property

    Public Property Foto As Byte()
        Get
            Return nuevoAnuncio.Foto
        End Get
        Set(value As Byte())
            nuevoAnuncio.Foto = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Foto"))
        End Set
    End Property

    Public Property Slogan As String
        Get
            Return IIf(nuevoAnuncio.Slogan Is Nothing, "", nuevoAnuncio.Slogan)
        End Get
        Set(value As String)
            nuevoAnuncio.Slogan = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Slogan"))
        End Set
    End Property
End Class
