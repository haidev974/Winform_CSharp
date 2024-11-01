using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhieuAnCantin.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<CHI_TIET_NHAP_HANG> CHI_TIET_NHAP_HANG { get; set; }
        public virtual DbSet<CHI_TIET_PHIEU_AN> CHI_TIET_PHIEU_AN { get; set; }
        public virtual DbSet<CHUC_VU> CHUC_VU { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<KHUYEN_MAI> KHUYEN_MAI { get; set; }
        public virtual DbSet<LOAI_HANG> LOAI_HANG { get; set; }
        public virtual DbSet<MAT_HANG> MAT_HANG { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_AN> PHIEU_AN { get; set; }
        public virtual DbSet<PHIEU_NHAP_HANG> PHIEU_NHAP_HANG { get; set; }
        public virtual DbSet<PHIEU_THONG_KE> PHIEU_THONG_KE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_NHAP_HANG>()
                .Property(e => e.MA_NHAP_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_NHAP_HANG>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_AN>()
                .Property(e => e.MA_PHIEU_AN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_AN>()
                .Property(e => e.MA_KHUYEN_MAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_AN>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUC_VU>()
                .Property(e => e.MA_CV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUC_VU>()
                .HasMany(e => e.NHAN_VIEN)
                .WithRequired(e => e.CHUC_VU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.MA_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.PHIEU_AN)
                .WithRequired(e => e.KHACH_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHUYEN_MAI>()
                .Property(e => e.MA_KHUYEN_MAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_HANG>()
                .Property(e => e.MA_LOAI_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_HANG>()
                .HasMany(e => e.MAT_HANG)
                .WithRequired(e => e.LOAI_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.MA_LOAI_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MAT_HANG>()
                .Property(e => e.GIA_HANG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MAT_HANG>()
                .HasMany(e => e.CHI_TIET_NHAP_HANG)
                .WithRequired(e => e.MAT_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAT_HANG>()
                .HasMany(e => e.CHI_TIET_PHIEU_AN)
                .WithRequired(e => e.MAT_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_CV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MAT_KHAU)
                .IsFixedLength();

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.PHIEU_AN)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.PHIEU_NHAP_HANG)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.PHIEU_THONG_KE)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_AN>()
                .Property(e => e.MA_PHIEU_AN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_AN>()
                .Property(e => e.MA_THONG_KE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_AN>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_AN>()
                .Property(e => e.MA_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_AN>()
                .HasMany(e => e.CHI_TIET_PHIEU_AN)
                .WithRequired(e => e.PHIEU_AN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_NHAP_HANG>()
                .Property(e => e.MA_NHAP_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_NHAP_HANG>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_NHAP_HANG>()
                .HasMany(e => e.CHI_TIET_NHAP_HANG)
                .WithRequired(e => e.PHIEU_NHAP_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_THONG_KE>()
                .Property(e => e.MA_THONG_KE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THONG_KE>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THONG_KE>()
                .HasMany(e => e.PHIEU_AN)
                .WithRequired(e => e.PHIEU_THONG_KE)
                .WillCascadeOnDelete(false);
        }
    }
}
