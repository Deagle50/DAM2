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

Namespace Examen_UrkoUrbieta28012020

    Partial Public Class DAM_urkourbieta_DEVEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=DAM_urkourbieta_DEVEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Cines() As DbSet(Of Cines)
        Public Overridable Property Emisiones() As DbSet(Of Emisiones)
        Public Overridable Property Peliculas() As DbSet(Of Peliculas)
    
    End Class

End Namespace
