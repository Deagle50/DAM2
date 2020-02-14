Imports System.ComponentModel

Public Class MainViewModel
    Implements INotifyPropertyChanged
    Private modelo As New NorthwindEntities
    Private currentEmployee As Employees
    Public ReadOnly Property Empleado As Employees
        Get
            Return currentEmployee
        End Get
    End Property
    Public Sub New(id As Integer)
        EmployeeId = id
    End Sub
    Public Property EmployeeId As Integer
        Get
            Return currentEmployee.EmployeeID
        End Get
        Set(value As Integer)
            currentEmployee = (From e In modelo.Employees
                               Where e.EmployeeID = value
                               Select e).FirstOrDefault
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("EmployeeId"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("FirstName"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("LastName"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Photo"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Empleado"))
        End Set
    End Property
    Public ReadOnly Property FirstName As String
        Get
            Return currentEmployee.FirstName
        End Get
    End Property
    Public ReadOnly Property LastName As String
        Get
            Return currentEmployee.LastName
        End Get
    End Property
    Public ReadOnly Property Photo As Byte()
        Get
            Return currentEmployee.Photo
        End Get
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
