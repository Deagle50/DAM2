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

Partial Public Class Facturas
    Public Property FacturaId As Integer
    Public Property ClienteId As Nullable(Of Integer)
    Public Property Fecha As Nullable(Of Date)
    Public Property pagado As Nullable(Of Boolean)

    Public Overridable Property Lineas As ICollection(Of Lineas) = New HashSet(Of Lineas)

End Class