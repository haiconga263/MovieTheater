﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLRapPhimEntities : DbContext
    {
        public QLRapPhimEntities()
            : base("name=QLRapPhimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BinhChonPhim> BinhChonPhims { get; set; }
        public virtual DbSet<CaChieuPhim> CaChieuPhims { get; set; }
        public virtual DbSet<GiaVe> GiaVes { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public virtual DbSet<LoaiThoiGian> LoaiThoiGians { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<PhongChieuPhim> PhongChieuPhims { get; set; }
        public virtual DbSet<RapChieuPhim> RapChieuPhims { get; set; }
        public virtual DbSet<SuatChieu> SuatChieux { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheLoaiPhim> TheLoaiPhims { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
    }
}
