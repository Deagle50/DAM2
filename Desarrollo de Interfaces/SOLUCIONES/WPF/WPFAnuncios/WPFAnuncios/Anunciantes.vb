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

Namespace WPFAnuncios

    Partial Public Class Anunciantes
        Public Property IdAnunciante As Integer
        Public Property IdCategoria As Nullable(Of Integer)
        Public Property Marca As String
        Public Property Direccion As String
        Public Property Telefono As String
    
        Public Overridable Property Anuncios As ICollection(Of Anuncios) = New HashSet(Of Anuncios)
        Public Overridable Property Categorias As Categorias
    
    End Class

End Namespace