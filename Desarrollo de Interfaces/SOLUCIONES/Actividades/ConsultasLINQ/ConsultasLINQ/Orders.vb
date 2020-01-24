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

Namespace ConsultasLINQ

    Partial Public Class Orders
        Public Property OrderID As Integer
        Public Property CustomerID As String
        Public Property EmployeeID As Nullable(Of Integer)
        Public Property OrderDate As Nullable(Of Date)
        Public Property RequiredDate As Nullable(Of Date)
        Public Property ShippedDate As Nullable(Of Date)
        Public Property ShipVia As Nullable(Of Integer)
        Public Property Freight As Nullable(Of Decimal)
        Public Property ShipName As String
        Public Property ShipAddress As String
        Public Property ShipCity As String
        Public Property ShipRegion As String
        Public Property ShipPostalCode As String
        Public Property ShipCountry As String
    
        Public Overridable Property Customers As Customers
        Public Overridable Property Order_Details As ICollection(Of Order_Details) = New HashSet(Of Order_Details)
    
    End Class

End Namespace
