Public Class MainViewModel
    '•	Tendrá una variable privada que será el modelo
    Private modelo As WpfMateriales.DaniDBEntities
    Public Sub New(model As WpfMateriales.DaniDBEntities)
        '•	Tendrá un constructor público que recibe el 
        'modelo para inicializar la variable modelo.
        modelo = model
    End Sub

    Public ReadOnly Property ListaMateriales As List(Of WpfMateriales.Materiales)
        '•	Tendrá una propiedad de solo lectura ListaMateriales, que devolverá 
        'la lista de todos los materiales del modelo.
        Get
            Return modelo.Materiales.ToList
        End Get
    End Property
End Class
