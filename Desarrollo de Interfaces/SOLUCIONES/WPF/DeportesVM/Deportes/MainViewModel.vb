Imports System.ComponentModel

Public Class MainViewModel
    Implements INotifyPropertyChanged
    Private opciones(2) As Integer
    Public ReadOnly Property ResultadoPelota() As Integer
        Get
            Return 10 * opciones(0)
        End Get
    End Property
    Public ReadOnly Property ResultadoEscalada() As Integer
        Get
            Return 10 * opciones(1)
        End Get
    End Property
    Public ReadOnly Property ResultadoCurling() As Integer
        Get
            Return 10 * opciones(2)
        End Get
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Votar(opc As Integer)
        opciones(opc) += 1
        Select Case opc
            Case 0
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("ResultadoPelota"))
            Case 1
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("ResultadoEscalada"))
            Case Else
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("ResultadoCurling"))
        End Select

    End Sub
End Class
