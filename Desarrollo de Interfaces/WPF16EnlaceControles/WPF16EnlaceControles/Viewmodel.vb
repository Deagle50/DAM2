Public Class Viewmodel
    Dim Empleado As WPF16EnlaceControles.Employees
    Private modelo As New WPF16EnlaceControles.NorthwindEntities
    Public Property Name
        Get
            If Not Empleado Is Nothing Then
                Return Empleado.FirstName
            End If
            Return Empleado.FirstName
        End Get
        Set
    End Property
    Public Property Surname
        Get
            If
        End Get
        Set(value)

        End Set
    End Property
    Public Property ID
        Get

        End Get
        Set(value)

        End Set
    End Property
End Class
