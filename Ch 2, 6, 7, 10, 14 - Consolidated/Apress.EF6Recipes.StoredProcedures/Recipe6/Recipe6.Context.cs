﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apress.EF6Recipes.StoredProcedures.Recipe6
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Recipe6Context : DbContext
    {
        public Recipe6Context()
            : base("name=Recipe6Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Media> Media { get; set; }
    
        public virtual ObjectResult<Media> GetAllMedia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Media>("GetAllMedia");
        }
    
        public virtual ObjectResult<Media> GetAllMedia(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Media>("GetAllMedia", mergeOption);
        }
    }
}