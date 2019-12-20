﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DAM_urkourbieta_DEVEntities1 : DbContext
    {
        public DAM_urkourbieta_DEVEntities1()
            : base("name=DAM_urkourbieta_DEVEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
    
        public virtual ObjectResult<getEmpleados_Result> getEmpleados()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpleados_Result>("getEmpleados");
        }
    
        public virtual int deleteDepartamento(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteDepartamento", employeeIDParameter);
        }
    
        public virtual int deleteEmpleado(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteEmpleado", employeeIDParameter);
        }
    
        public virtual int deleteGenero(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteGenero", employeeIDParameter);
        }
    
        public virtual ObjectResult<getDepartamentos_Result> getDepartamentos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDepartamentos_Result>("getDepartamentos");
        }
    
        public virtual ObjectResult<getGeneros_Result> getGeneros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getGeneros_Result>("getGeneros");
        }
    
        public virtual int insertDepartamento(Nullable<int> employeeID, string nombre)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertDepartamento", employeeIDParameter, nombreParameter);
        }
    
        public virtual int insertEmpleado(Nullable<int> employeeID, string nombre, string ap, string gen, string dept)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apParameter = ap != null ?
                new ObjectParameter("ap", ap) :
                new ObjectParameter("ap", typeof(string));
    
            var genParameter = gen != null ?
                new ObjectParameter("gen", gen) :
                new ObjectParameter("gen", typeof(string));
    
            var deptParameter = dept != null ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertEmpleado", employeeIDParameter, nombreParameter, apParameter, genParameter, deptParameter);
        }
    
        public virtual int insertGenero(Nullable<int> employeeID, string nombre)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertGenero", employeeIDParameter, nombreParameter);
        }
    
        public virtual int updateDepartamento(Nullable<int> employeeID, string nombre)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateDepartamento", employeeIDParameter, nombreParameter);
        }
    
        public virtual int updateEmpleado(Nullable<int> employeeID, string nombre, string apellido, string genero, string dep)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var depParameter = dep != null ?
                new ObjectParameter("dep", dep) :
                new ObjectParameter("dep", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateEmpleado", employeeIDParameter, nombreParameter, apellidoParameter, generoParameter, depParameter);
        }
    
        public virtual int updateGenero(Nullable<int> employeeID, string desc)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateGenero", employeeIDParameter, descParameter);
        }
    }
}