﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LandscapeDesignEntities : DbContext
    {
        public LandscapeDesignEntities()
            : base("name=LandscapeDesignEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Plants> Plants { get; set; }
        public virtual DbSet<PlantSpecies> PlantSpecies { get; set; }
        public virtual DbSet<ProjectPlants> ProjectPlants { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<ProjectStructure> ProjectStructure { get; set; }
        public virtual DbSet<Structures> Structures { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
