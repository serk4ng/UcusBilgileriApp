﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UcusBilgileriApp.BLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DtbUcusEntities : DbContext
    {
        public DtbUcusEntities()
            : base("name=DtbUcusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public  DbSet<sysdiagram> sysdiagrams { get; set; }
        public  DbSet<tblHavayollari> tblHavayollaris { get; set; }
        public  DbSet<tblKalkisVari> tblKalkisVaris { get; set; }
        public  DbSet<tblUcak> tblUcaks { get; set; }
        public  DbSet<tblUcusBilgileri> tblUcusBilgileris { get; set; }
        public  DbSet<tblYolcular> tblYolculars { get; set; }
    }
}
