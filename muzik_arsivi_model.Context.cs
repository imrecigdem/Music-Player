﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Music_Player
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class muzik_arsiviEntities : DbContext
    {
        public muzik_arsiviEntities()
            : base("name=muzik_arsiviEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Sarki> Sarki { get; set; }
        public virtual DbSet<Sarki_Begenme> Sarki_Begenme { get; set; }
        public virtual DbSet<Takipci> Takipci { get; set; }
        public virtual DbSet<KullaniciHareket> KullaniciHareket { get; set; }
        public virtual DbSet<Oynatma_Listesi> Oynatma_Listesi { get; set; }
    }
}
