Imports System.ComponentModel

Public Class MainViewModel
    Implements INotifyPropertyChanged
    Dim _modelo As DaniDBEntities
    Dim _mensaje As String
    Dim Factura As Facturas
    Dim Linea As Lineas
    Dim contArt As Integer
    Dim Art As Articulos
    Dim total As Integer
    Dim _pag As Integer = 1
    Public Property Pagina
        Get
            Return _pag
        End Get
        Set(value)
            _pag = value
        End Set
    End Property
    Public Property ModeloDatos As DaniDBEntities
        Get
            Return _modelo
        End Get
        Set(value As DaniDBEntities)
            _modelo = value
        End Set
    End Property

    Public ReadOnly Property Articulo(i As Integer)
        Get
            Dim pos As Integer = ((_pag - 1) * 8) + i
            Return ModeloDatos.Articulos.ToList(pos)
        End Get
    End Property

    Public ReadOnly Property Mensaje
        Get
            Return _mensaje
        End Get
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub NuevaFactura()
        Factura = New Facturas()
    End Sub
    Public Sub NuevaLinea()
        Linea = New Lineas()
    End Sub

    Public Sub AgregarArticulo(art As Articulos)
        If Me.Art Is Nothing Then
            Me.Art = art
        End If
        contArt += 1

        _mensaje = String.Format("{0} x {1} {2}", art.Denominacion, contArt.ToString, (art.Precio * contArt).ToString)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Mensaje"))
    End Sub

    Public Sub FinLinea()
        Linea = New Lineas
        Linea.ArticuloId = Art.ArticuloId
        Linea.Unidades = contArt

        Factura.Lineas.Add(Linea)
        total += Art.Precio * contArt
        _mensaje = total
        contArt = 0
        Art = Nothing
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Mensaje"))
    End Sub


End Class
