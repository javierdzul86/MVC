﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLData.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVCCrudEntities : DbContext
    {
        public MVCCrudEntities()
            : base("name=MVCCrudEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }

        public System.Data.Entity.DbSet<BLData.Modelos.AlumnoViewModel> AlumnoViewModels { get; set; }
    }
}
