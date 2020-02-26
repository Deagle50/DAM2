Imports System.ComponentModel
Public Class MainViewModel
    Implements INotifyPropertyChanged
    Private modelo As UrkoUrbietaExamenInterfaces19_02_2020.DAM_urkourbieta_DEVEntities

    Private interfaz As String

    Public Sub New(modelo As UrkoUrbietaExamenInterfaces19_02_2020.DAM_urkourbieta_DEVEntities)
        Me.modelo = modelo
        'RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("_interfaz"))
    End Sub
    Public ReadOnly Property Producto1 As UrkoUrbietaExamenInterfaces19_02_2020.Productos
        Get
            Return modelo.Productos.Where(Function(x) x.id_producto = 1)
        End Get
    End Property
    Public ReadOnly Property Producto2 As UrkoUrbietaExamenInterfaces19_02_2020.Productos
        Get
            Return modelo.Productos.Where(Function(x) x.id_producto = 2)
        End Get
    End Property
    Public ReadOnly Property Producto3 As UrkoUrbietaExamenInterfaces19_02_2020.Productos
        Get
            Return modelo.Productos.Where(Function(x) x.id_producto = 3)
        End Get
    End Property
    Public ReadOnly Property Producto4 As UrkoUrbietaExamenInterfaces19_02_2020.Productos
        Get
            Return modelo.Productos.Where(Function(x) x.id_producto = 4)
        End Get
    End Property

    Public ReadOnly Property _interfaz As String
        Get
            Return interfaz
        End Get
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Vender(id As Integer)
        'Falta preparar interfaz/display'
        Dim venta As New UrkoUrbietaExamenInterfaces19_02_2020.Ventas
        Dim producto As New UrkoUrbietaExamenInterfaces19_02_2020.Productos
        producto = modelo.Productos.Where(Function(x) x.id_producto = id)
        If producto.unidades > 1 Then
            venta.id_producto = id
            venta.importe = producto.precio
            producto.unidades -= 1
            modelo.Ventas.Add(venta)

            interfaz = producto.descripcion + producto.precio
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("_interfaz"))
            cambiarPropiedad(producto.id_producto)

            modelo.SaveChanges()
        Else
            interfaz = "Producto " + producto.descripcion + "agotado"
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("_interfaz"))
        End If
    End Sub

    Private Sub cambiarPropiedad(id_producto As Integer)
        If id_producto = 1 Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Producto1"))
        ElseIf id_producto = 2 Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Producto2"))
        ElseIf id_producto = 3 Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Producto3"))
        Else
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Producto4"))
        End If
    End Sub
End Class
