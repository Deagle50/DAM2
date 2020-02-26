Imports System.ComponentModel

Public Class Window1ViewModel
    Implements INotifyPropertyChanged
    Dim modelo As WpfMateriales.DaniDBEntities
    Dim Actual As WpfMateriales.Materiales
    Public Sub New(modelo As WpfMateriales.DaniDBEntities, material As WpfMateriales.Materiales)
        Me.modelo = modelo
        Actual = material
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Descripcion"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Estado"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Marca"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Prestado"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Disponible"))
    End Sub
    Public ReadOnly Property Descripcion As String
        Get
            Return Actual.Descripcion
        End Get
    End Property
    Public ReadOnly Property Marca As String
        Get
            Return Actual.Marca
        End Get
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return Actual.Estados.Descripcion
        End Get
    End Property

    Public ReadOnly Property Disponible As Boolean
        Get
            Return Actual.Estado = 2
        End Get
    End Property

    Public ReadOnly Property Prestado As Boolean
        Get
            Return Actual.Estado = 1
        End Get
    End Property

    Public Sub Devolver()
        Dim movimiento As New WpfMateriales.Movimientos
        If modelo.Movimientos.Count = 0 Then
            movimiento.IdMovimiento = 1
        Else
            movimiento.IdMovimiento = modelo.Movimientos.Max(Function(x) x.IdMovimiento) + 1
        End If
        movimiento.fecha = DateTime.Now
        movimiento.IdMaterial = Actual.IdMaterial
        movimiento.Accion = 1
        Actual.Estado = 2
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Prestado"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Disponible"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Estado"))
        modelo.Movimientos.Add(movimiento)
        modelo.SaveChanges()
    End Sub
    Public Sub Retirar()
        Dim movimiento As New WpfMateriales.Movimientos
        movimiento.IdMovimiento = modelo.Movimientos.Max(Function(x) x.IdMovimiento) + 1
        movimiento.fecha = DateTime.Now
        movimiento.IdMaterial = Actual.IdMaterial
        movimiento.Accion = 2
        Actual.Estado = 1
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Prestado"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Disponible"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Estado"))
        modelo.Movimientos.Add(movimiento)
        modelo.SaveChanges()
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
