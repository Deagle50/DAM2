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

Namespace ConsultasLinq

    Partial Public Class Customers
        Public Property CustomerID As String
        Public Property CompanyName As String
        Public Property ContactName As String
        Public Property ContactTitle As String
        Public Property Address As String
        Public Property City As String
        Public Property Region As String
        Public Property PostalCode As String
        Public Property Country As String
        Public Property Phone As String
        Public Property Fax As String
    
        Public Overridable Property Orders As ICollection(Of Orders) = New HashSet(Of Orders)
    
    End Class

End Namespace
