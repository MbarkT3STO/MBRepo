﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBRepo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GVentesEntities : DbContext
    {
        public GVentesEntities()
            : base("name=GVentesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Archive_Client> Archive_Client { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Det_Fact> Det_Fact { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<Reglement> Reglement { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
