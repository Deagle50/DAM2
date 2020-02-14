Imports System.ComponentModel
Public Class ViewModel
    Implements INotifyPropertyChanged
    Dim Empleado As Wpf16_Enlace_Controles_.Employees
    Dim _Id As Integer
    Private modelo As New Wpf16_Enlace_Controles_.NorthwindEntities
    Public Property Nombre
        Get
            If Empleado Is Nothing Then
                Return ""
            End If
            Return Empleado.FirstName
        End Get
        Set(value)
            If Not Empleado Is Nothing Then
                Empleado.FirstName = value
            End If
        End Set
    End Property

    Public Property Apellido
        Get
            If Empleado Is Nothing Then
                Return ""
            End If
            Return Empleado.LastName
        End Get
        Set(value)
            If Not Empleado Is Nothing Then
                Empleado.LastName = value
            End If
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public ReadOnly Property Photo As Byte()
        Get
            If Not Empleado Is Nothing Then
                Return Empleado.Photo
            Else
                Return Nothing
            End If
        End Get

    End Property
    Public ReadOnly Property Ordenes As List(Of Wpf16_Enlace_Controles_.Orders)
        Get
            If Not Empleado Is Nothing Then
                Return Empleado.Orders.ToList
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public ReadOnly Property TotalFacturado As Single
        Get
            If Empleado Is Nothing Then
                Return 0
            Else
                Dim x As Object = (From od In Empleado.Orders
                                   Select od.Order_Details.Sum(Function(v) v.Quantity * v.UnitPrice * (1 - v.Discount))).First
                Return x
            End If

        End Get
    End Property

    Public Sub Buscar()
        Empleado = modelo.Employees.Where(Function(x) x.EmployeeID = Id).FirstOrDefault
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Nombre"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Apellido"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Photo"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Ordenes"))
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("TotalFacturado"))
    End Sub
End Class
