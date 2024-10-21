using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LeDuyHai_QLThuVien_EF.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<BANGCAP> BANGCAPs { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUMUONSACH> PHIEUMUONSACHes { get; set; }
        public virtual DbSet<PHIEUTHUTIEN> PHIEUTHUTIENs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGCAP>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.BANGCAP)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DOCGIA>()
                .HasMany(e => e.PHIEUMUONSACHes)
                .WithOptional(e => e.DOCGIA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHUTIENs)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHIEUMUONSACH>()
                .HasMany(e => e.SACHes)
                .WithMany(e => e.PHIEUMUONSACHes)
                .Map(m => m.ToTable("CHITIETPHIEUMUON").MapLeftKey("MaPhieuMuon").MapRightKey("MaSach"));
        }
    }
}
