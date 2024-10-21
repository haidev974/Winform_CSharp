using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenNgocTrinh.Models
{
    public partial class HoaDonDBContext : DbContext
    {
        public HoaDonDBContext()
            : base("name=HoaDonDBContext1")
        {
        }

        public virtual DbSet<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }
        public virtual DbSet<CHI_TIET_NHAP_HANG> CHI_TIET_NHAP_HANG { get; set; }
        public virtual DbSet<HANG_HOA> HANG_HOA { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<KHUYEN_MAI> KHUYEN_MAI { get; set; }
        public virtual DbSet<LOAI_HANG> LOAI_HANG { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<NHAP_HANG> NHAP_HANG { get; set; }
        public virtual DbSet<PHIEU_AN> PHIEU_AN { get; set; }
        public virtual DbSet<PHIEU_TON_KHO> PHIEU_TON_KHO { get; set; }
        public virtual DbSet<THONG_KE> THONG_KE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.MA_HOA_DON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.DON_GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .HasMany(e => e.THONG_KE)
                .WithRequired(e => e.CHI_TIET_HOA_DON)
                .HasForeignKey(e => new { e.MA_HOA_DON, e.MA_HANG })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHI_TIET_NHAP_HANG>()
                .Property(e => e.MA_PHIEU_NHAP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_NHAP_HANG>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_NHAP_HANG>()
                .Property(e => e.DON_GIA_NHAP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HANG_HOA>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HANG_HOA>()
                .Property(e => e.GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HANG_HOA>()
                .Property(e => e.MA_LOAI_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HANG_HOA>()
                .Property(e => e.MA_KM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HANG_HOA>()
                .HasMany(e => e.CHI_TIET_HOA_DON)
                .WithRequired(e => e.HANG_HOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANG_HOA>()
                .HasMany(e => e.CHI_TIET_NHAP_HANG)
                .WithRequired(e => e.HANG_HOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANG_HOA>()
                .HasMany(e => e.PHIEU_TON_KHO)
                .WithMany(e => e.HANG_HOA)
                .Map(m => m.ToTable("CHI_TIET_KHO_HÀNG").MapLeftKey("MA_HANG").MapRightKey("SO_PHIEU_TON"));

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_HOA_DON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_PHIEU_AN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.TONG_TIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOA_DON>()
                .HasMany(e => e.CHI_TIET_HOA_DON)
                .WithRequired(e => e.HOA_DON)
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
                .Property(e => e.EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.PHIEU_AN)
                .WithRequired(e => e.KHACH_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHUYEN_MAI>()
                .Property(e => e.MA_KM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHUYEN_MAI>()
                .HasMany(e => e.HANG_HOA)
                .WithRequired(e => e.KHUYEN_MAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAI_HANG>()
                .Property(e => e.MA_LOAI_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_HANG>()
                .HasMany(e => e.HANG_HOA)
                .WithRequired(e => e.LOAI_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.NHAP_HANG)
                .WithRequired(e => e.NHAN_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHAP_HANG>()
                .Property(e => e.MA_PHIEU_NHAP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAP_HANG>()
                .Property(e => e.MA_NV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAP_HANG>()
                .HasMany(e => e.CHI_TIET_NHAP_HANG)
                .WithRequired(e => e.NHAP_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_AN>()
                .Property(e => e.MA_PHIEU_AN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_AN>()
                .Property(e => e.MA_KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_AN>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.PHIEU_AN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEU_TON_KHO>()
                .Property(e => e.SO_PHIEU_TON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_TON_KHO>()
                .HasMany(e => e.THONG_KE)
                .WithRequired(e => e.PHIEU_TON_KHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONG_KE>()
                .Property(e => e.MA_THONG_KE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONG_KE>()
                .Property(e => e.SO_PHIEU_TON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONG_KE>()
                .Property(e => e.MA_HOA_DON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONG_KE>()
                .Property(e => e.MA_HANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONG_KE>()
                .Property(e => e.TONG_DOANH_THU)
                .HasPrecision(19, 4);
        }
    }
}
