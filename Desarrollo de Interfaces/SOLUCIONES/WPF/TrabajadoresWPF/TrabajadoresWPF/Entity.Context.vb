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

Namespace TrabajadoresWPF

    Partial Public Class DB
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=DB")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Acciones() As DbSet(Of Acciones)
        Public Overridable Property Estados() As DbSet(Of Estados)
        Public Overridable Property Movimientos() As DbSet(Of Movimientos)
        Public Overridable Property Trabajadores() As DbSet(Of Trabajadores)
    
    End Class

End Namespace
