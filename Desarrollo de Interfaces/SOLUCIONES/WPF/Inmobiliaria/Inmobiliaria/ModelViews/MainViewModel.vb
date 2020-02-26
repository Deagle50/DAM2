Imports System.ComponentModel
Imports Inmobiliaria
Public Class MainViewModel
    Implements INotifyPropertyChanged

    Private id, pwd As String
    Private modelo As BD_DaniEntities
    Private usuarioActual As Usuarios
    Public Sub New(model As BD_DaniEntities)
        ''asigna el parámetro a la variable privada
        modelo = model
    End Sub
    Public Property IdUsuario As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("IdUsuario"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("HayUsuario"))
        End Set
    End Property

    Public ReadOnly Property HayUsuario As Boolean
        Get
            Return IdUsuario <> ""
        End Get
    End Property
    Public Property Password As String
        ''Obtiene o establece el pwd
        Get
            Return pwd
        End Get
        Set(value As String)
            pwd = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Password"))
        End Set
    End Property
    Public ReadOnly Property Usuario As Usuarios
        Get
            ''Obtiene el usuario actual
            Return usuarioActual
        End Get
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Validar()
        ''Comprueba si existe usuario y password e inicializa usuario Actual
        usuarioActual = modelo.Usuarios.Where(Function(x) x.Usuario = id And x.Password = pwd).FirstOrDefault
    End Sub

End Class
