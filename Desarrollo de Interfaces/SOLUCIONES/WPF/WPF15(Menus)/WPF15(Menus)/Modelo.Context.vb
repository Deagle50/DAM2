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

Namespace WPF15_menus_

    Partial Public Class DaniDBEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=DaniDBEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Menus() As DbSet(Of Menus)
    
    End Class

End Namespace
