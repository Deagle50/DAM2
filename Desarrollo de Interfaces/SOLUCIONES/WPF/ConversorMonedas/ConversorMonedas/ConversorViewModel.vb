Imports System.ComponentModel

Public Class ConversorViewModel
    Implements INotifyPropertyChanged
    Dim _dolar As Single
    Dim _euro As Single
    Public Property Dolar
        Get
            Return _dolar
        End Get
        Set(value)
            _dolar = value
            _euro = value / 1.14
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Euro"))
        End Set
    End Property

    Public Property Euro
        Get
            Return _euro
        End Get
        Set(value)
            _euro = value
            _dolar = value * 1.14
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Dolar"))
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
