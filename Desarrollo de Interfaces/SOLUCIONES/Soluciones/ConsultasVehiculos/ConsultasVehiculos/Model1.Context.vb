﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace ConsultasVehiculos

    Partial Public Class DaniDBEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=DaniDBEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property CLIENTES() As DbSet(Of CLIENTES)
        Public Overridable Property DETALLES_NOTAS() As DbSet(Of DETALLES_NOTAS)
        Public Overridable Property NOTAS_REPARACIONES() As DbSet(Of NOTAS_REPARACIONES)
        Public Overridable Property VEHICULOS() As DbSet(Of VEHICULOS)
    
    End Class

End Namespace
