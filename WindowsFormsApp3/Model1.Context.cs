﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbOgrenciEntities : DbContext
    {
        public dbOgrenciEntities()
            : base("name=dbOgrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblDersler> tblDersler { get; set; }
        public virtual DbSet<tblNotlar> tblNotlar { get; set; }
        public virtual DbSet<tblOgrenci> tblOgrenci { get; set; }
        public virtual DbSet<Kulup> Kulup { get; set; }
    
        public virtual ObjectResult<notlistesi_Result> notlistesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<notlistesi_Result>("notlistesi");
        }
    }
}