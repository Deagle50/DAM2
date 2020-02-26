Imports System.ComponentModel

Public Class FotoWindowViewModel
    Implements INotifyPropertyChanged

    Dim inm As Inmuebles
    Dim modelo As BD_DaniEntities
    Dim imagen As Imagenes
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New(i As Inmuebles, m As BD_DaniEntities)
        ''Inicializa las variables Miebro
        inm = i
        modelo = m
        imagen = New Imagenes
        If modelo.Imagenes.Count <> 0 Then
            imagen.IdFoto = modelo.Imagenes.Max(Function(x) x.IdFoto) + 1
        Else
            imagen.IdFoto = 1
        End If
        imagen.Texto = ""
        imagen.IdInmueble = inm.Id
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Foto"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Descripcion"))
    End Sub

    Public Property Foto As Byte()

        ''Devuelve o establece la imagen del Inmueble inm. En la parte set 
        ''notifica cambio de propiedad
        Get
            Return imagen.Foto
        End Get
        Set(value As Byte())
            imagen.Foto = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Foto"))
        End Set
    End Property
    Property Descripcion As String

        ''Devuelve o establece la descripción del Inmueble inm. En la parte set 
        ''notifica cambio de propiedad
        Get
            Return imagen.Texto
        End Get
        Set(value As String)
            imagen.Texto = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Descripcion"))
        End Set
    End Property


    Public Sub Agregar()
        ''Agrega el nuevo inmueble y guarda los cambios.
        modelo.Imagenes.Add(imagen)
        modelo.SaveChanges()
    End Sub

End Class
