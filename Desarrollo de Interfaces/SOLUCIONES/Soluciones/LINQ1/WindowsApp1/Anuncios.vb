'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace WindowsApp1

    Partial Public Class Anuncios
        Public Property IdAnuncio As Integer
        Public Property IdAnunciante As Nullable(Of Integer)
        Public Property IdCategoria As Nullable(Of Integer)
        Public Property TipoAnuncio As String
        Public Property FechaContrato As Nullable(Of Date)
        Public Property Precio As Nullable(Of Double)
    
        Public Overridable Property Anunciantes As Anunciantes
        Public Overridable Property Categorias As Categorias
    
    End Class

End Namespace
