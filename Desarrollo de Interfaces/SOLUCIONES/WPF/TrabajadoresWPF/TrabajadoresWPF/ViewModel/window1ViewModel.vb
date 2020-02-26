Imports System.ComponentModel
Imports TrabajadoresWPF.TrabajadoresWPF

Public Class window1ViewModel
    Implements INotifyPropertyChanged

    Private _modelo As DB
    Private _empleadoActual As Trabajadores

    Public Sub New(modelo As DB, trabajadorActual As Trabajadores)
        _modelo = modelo
        _empleadoActual = trabajadorActual
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("nombre"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("apellido"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("descripcion"))
    End Sub

    Public ReadOnly Property nombre
        Get
            Return _empleadoActual.Nombre
        End Get
    End Property

    Public ReadOnly Property apellido
        Get
            Return _empleadoActual.Apellido
        End Get
    End Property
    Public ReadOnly Property descripcion
        Get
            Return _empleadoActual.Estados.Descripcion
        End Get
    End Property

    Public ReadOnly Property dentro
        Get
            If _empleadoActual.Estado = 1 Then
                Return True
            End If
            Return False
        End Get

    End Property

    Public ReadOnly Property fuera
        Get
            If _empleadoActual.Estado = 2 Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public Sub Entrar()
        _empleadoActual.Estado = 1
        Dim movimiento As New Movimientos
        movimiento.IdMovimiento = (From m In _modelo.Movimientos
                                   Select m.IdMovimiento).Count + 1
        movimiento.IdTrabajador = _empleadoActual.IdTrabajador
        movimiento.Accion = 1
        movimiento.fecha = DateTime.Now
        Modelo.Movimientos.Add(movimiento)
        Modelo.SaveChanges()
    End Sub

    Public Sub Salir()
        _empleadoActual.Estado = 2
        Dim movimiento As New Movimientos
        movimiento.IdMovimiento = (From m In _modelo.Movimientos
                                   Select m.IdMovimiento).Count + 1
        movimiento.IdTrabajador = _empleadoActual.IdTrabajador
        movimiento.Accion = 2
        movimiento.fecha = DateTime.Now
        Modelo.Movimientos.Add(movimiento)
        Modelo.SaveChanges()
    End Sub


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
