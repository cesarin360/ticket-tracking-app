﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bdl_Grupo2_ProyectoFinal_A
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DevSolutionsEntities : DbContext
    {
        public DevSolutionsEntities()
            : base("name=DevSolutionsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<Estado_Ticket> Estado_Ticket { get; set; }
        public virtual DbSet<Fabricante> Fabricante { get; set; }
        public virtual DbSet<Hardware> Hardware { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<Problemas_Tecnicos> Problemas_Tecnicos { get; set; }
        public virtual DbSet<Recordatorios> Recordatorios { get; set; }
        public virtual DbSet<Software> Software { get; set; }
        public virtual DbSet<Tecnicos> Tecnicos { get; set; }
        public virtual DbSet<Ticket_Prioridad> Ticket_Prioridad { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Tipo_Software> Tipo_Software { get; set; }
        public virtual DbSet<Ubicacion_Usuarios> Ubicacion_Usuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
