Imports TrabajadoresWPF.TrabajadoresWPF

Public Class mainViewModel
    Private _modelo As DB

    Public Sub New(modelo As DB)
        _modelo = modelo
    End Sub

    Public ReadOnly Property ListaEmpleados
        Get
            Return _modelo.Trabajadores.ToList()
        End Get
    End Property

End Class
