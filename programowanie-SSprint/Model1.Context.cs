﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace programowanie_SSprint
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SSprintEntities : DbContext
    {
        public SSprintEntities()
            : base("name=SSprintEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<color> colors { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<picture> pictures { get; set; }
        public virtual DbSet<singleItemOrder> singleItemOrders { get; set; }
        public virtual DbSet<style> styles { get; set; }
        public virtual DbSet<tshirt> tshirts { get; set; }
    }
}
