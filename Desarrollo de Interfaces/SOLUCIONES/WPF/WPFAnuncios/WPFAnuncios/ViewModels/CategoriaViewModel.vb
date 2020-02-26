Imports System.ComponentModel
Imports WPFAnuncios.WPFAnuncios
Public Class CategoriaViewModel
    Implements INotifyPropertyChanged
    Dim modelo As DaniDBEntities
    Dim nuevaCat As New Categorias
    Public Sub New(model As DaniDBEntities)
        ''inicializa el modelo.
        modelo = model
        nuevaCat.IdCategoria = model.Categorias.Max(Function(x) x.IdCategoria) + 1
        nuevaCat.Nombre = ""
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("NuevaCategoria"))
    End Sub

    Public ReadOnly Property NuevaCategoria As Categorias
        Get
            ''Devuelve la nueva categoría a insertar            
            Return nuevaCat
        End Get

    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Agregar()

        ''Inserta la categoría en el modelo.
        modelo.Categorias.Add(nuevaCat)
        modelo.SaveChanges()

    End Sub

End Class
