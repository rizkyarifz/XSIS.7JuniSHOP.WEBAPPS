﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XSIS.SHOP.WEBAPPS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopDBEntities : DbContext
    {
        public ShopDBEntities()
            : base("name=ShopDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }

        public System.Data.Entity.DbSet<XSIS.Shop.Model.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<XSIS.Shop.Model.Customer> Customers { get; set; }
    }
}
