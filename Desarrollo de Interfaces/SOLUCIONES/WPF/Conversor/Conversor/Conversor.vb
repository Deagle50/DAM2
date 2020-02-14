Imports System.ComponentModel
Public Class Conversor
    Implements INotifyPropertyChanged
    Private sw As Boolean
    Private centi, faren As Double
    Public Property Centigrados As Double
        Get
            Return centi
        End Get
        Set(value As Double)
            centi = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Centigrados"))
        End Set
    End Property

    Public Property Fahrenheit As Double
        Get
            Return faren
        End Get
        Set(value As Double)
            faren = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Fahrenheit"))
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub ConvertirCentigrados()
        faren = centi * 9 / 5 + 32
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Fahrenheit"))
    End Sub

    Public Sub ConvertirFarenheit()
        centi = (faren - 32) * 5 / 9
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Centigrados"))
    End Sub

    Public Property FarentoCenti As Boolean
        Get
            Return sw
        End Get
        Set(value As Boolean)
            sw = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("FarentoCenti"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("CentitoFaren"))
        End Set
    End Property

    Public Property CentitoFaren As Boolean
        Get
            Return Not sw
        End Get
        Set(value As Boolean)
            sw = Not value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("CentitoFaren"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("FarentoCenti"))
        End Set
    End Property

End Class
