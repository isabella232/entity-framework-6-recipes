﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apress.EF6Recipes.ModelingFundamentals.Recipe2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Recipe2Context : DbContext
    {
        public Recipe2Context()
            : base("name=Recipe2Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Meter> Meters { get; set; }
        public DbSet<Poem> Poems { get; set; }
        public DbSet<Poet> Poets { get; set; }
        public DbSet<vwLibrary> vwLibraries { get; set; }
    }
}