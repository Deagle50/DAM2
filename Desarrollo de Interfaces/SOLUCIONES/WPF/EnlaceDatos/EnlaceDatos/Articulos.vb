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

Partial Public Class Articulos
    Public Property ArticuloId As Integer
    Public Property Denominacion As String
    Public Property Precio As Nullable(Of Decimal)
    Public Property Existencias As Nullable(Of Integer)
    Public Property Imagen As Byte()

    Public Overridable Property Lineas As ICollection(Of Lineas) = New HashSet(Of Lineas)

End Class