﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeThuoc.Thuoc_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KeThuocDB : DbContext
    {
        public KeThuocDB()
            : base("name=KeThuocDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BacSi> BacSi { get; set; }
        public virtual DbSet<BenhNhan> BenhNhan { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<DonThuoc> DonThuoc { get; set; }
        public virtual DbSet<DonVaThuoc> DonVaThuoc { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<LoaiThuoc> LoaiThuoc { get; set; }
        public virtual DbSet<THUOC> THUOC { get; set; }
    }
}