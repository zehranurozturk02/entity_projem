﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity_projem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntityFrameworkStajProjemEntities2 : DbContext
    {
        public EntityFrameworkStajProjemEntities2()
            : base("name=EntityFrameworkStajProjemEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kitaplar> kitaplar { get; set; }
        public virtual DbSet<ödünç_alma> ödünç_alma { get; set; }
        public virtual DbSet<üyeler> üyeler { get; set; }
    }
}
