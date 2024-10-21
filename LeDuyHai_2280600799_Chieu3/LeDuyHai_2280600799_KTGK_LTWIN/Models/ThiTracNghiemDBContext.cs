using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    public partial class ThiTracNghiemDBContext : DbContext
    {
        public ThiTracNghiemDBContext()
            : base("name=ThiTracNghiemDBContext")
        {
        }

        public virtual DbSet<BAI_THI_CUA_SINH_VIEN> BAI_THI_CUA_SINH_VIEN { get; set; }
        public virtual DbSet<CAU_HOI> CAU_HOI { get; set; }
        public virtual DbSet<CAU_HOI_TRONG_KY_THI> CAU_HOI_TRONG_KY_THI { get; set; }
        public virtual DbSet<CHUONG> CHUONGs { get; set; }
        public virtual DbSet<DANH_MUC_CAU_HOI> DANH_MUC_CAU_HOI { get; set; }
        public virtual DbSet<DAP_AN> DAP_AN { get; set; }
        public virtual DbSet<DAP_AN_CUA_SINH_VIEN> DAP_AN_CUA_SINH_VIEN { get; set; }
        public virtual DbSet<KET_QUA> KET_QUA { get; set; }
        public virtual DbSet<KY_THI> KY_THI { get; set; }
        public virtual DbSet<Mon_Hoc> Mon_Hoc { get; set; }
        public virtual DbSet<SINH_VIEN_DANH_GIA> SINH_VIEN_DANH_GIA { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAI_THI_CUA_SINH_VIEN>()
                .Property(e => e.Ma_bai_thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAI_THI_CUA_SINH_VIEN>()
                .Property(e => e.Ma_ky_thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAI_THI_CUA_SINH_VIEN>()
                .Property(e => e.Ma_Nguoi_dung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAI_THI_CUA_SINH_VIEN>()
                .HasMany(e => e.DAP_AN_CUA_SINH_VIEN)
                .WithRequired(e => e.BAI_THI_CUA_SINH_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAU_HOI>()
                .Property(e => e.Ma_cau_hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAU_HOI>()
                .Property(e => e.Ma_DM_cau_hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAU_HOI>()
                .Property(e => e.Ma_chuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAU_HOI>()
                .HasMany(e => e.CAU_HOI_TRONG_KY_THI)
                .WithRequired(e => e.CAU_HOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAU_HOI>()
                .HasMany(e => e.DAP_AN)
                .WithRequired(e => e.CAU_HOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAU_HOI_TRONG_KY_THI>()
                .Property(e => e.Ma_ky_thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAU_HOI_TRONG_KY_THI>()
                .Property(e => e.Ma_cau_hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUONG>()
                .Property(e => e.Ma_chuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUONG>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUONG>()
                .HasMany(e => e.CAU_HOI)
                .WithRequired(e => e.CHUONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANH_MUC_CAU_HOI>()
                .Property(e => e.Ma_DM_cau_hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC_CAU_HOI>()
                .Property(e => e.Ma_Nguoi_dung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANH_MUC_CAU_HOI>()
                .HasMany(e => e.CAU_HOI)
                .WithRequired(e => e.DANH_MUC_CAU_HOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAP_AN>()
                .Property(e => e.Ma_dap_an)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAP_AN>()
                .Property(e => e.Ma_cau_hoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAP_AN>()
                .HasMany(e => e.DAP_AN_CUA_SINH_VIEN)
                .WithRequired(e => e.DAP_AN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAP_AN_CUA_SINH_VIEN>()
                .Property(e => e.Ma_dap_an_sv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAP_AN_CUA_SINH_VIEN>()
                .Property(e => e.Ma_dap_an)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAP_AN_CUA_SINH_VIEN>()
                .Property(e => e.Ma_bai_thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAP_AN_CUA_SINH_VIEN>()
                .Property(e => e.Dap_an_sv_chon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAP_AN_CUA_SINH_VIEN>()
                .HasMany(e => e.KET_QUA)
                .WithRequired(e => e.DAP_AN_CUA_SINH_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KET_QUA>()
                .Property(e => e.Ma_ket_qua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KET_QUA>()
                .Property(e => e.Ma_dap_an_sv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KET_QUA>()
                .HasMany(e => e.SINH_VIEN_DANH_GIA)
                .WithRequired(e => e.KET_QUA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KY_THI>()
                .Property(e => e.Ma_ky_thi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KY_THI>()
                .HasMany(e => e.BAI_THI_CUA_SINH_VIEN)
                .WithRequired(e => e.KY_THI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KY_THI>()
                .HasMany(e => e.CAU_HOI_TRONG_KY_THI)
                .WithRequired(e => e.KY_THI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KY_THI>()
                .HasMany(e => e.Mon_Hoc)
                .WithMany(e => e.KY_THI)
                .Map(m => m.ToTable("CT_Mon_Hoc").MapLeftKey("Ma_ky_thi").MapRightKey("Ma_Mon_Hoc"));

            modelBuilder.Entity<Mon_Hoc>()
                .Property(e => e.Ma_Mon_Hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mon_Hoc>()
                .HasMany(e => e.CHUONGs)
                .WithRequired(e => e.Mon_Hoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINH_VIEN_DANH_GIA>()
                .Property(e => e.Ma_danh_gia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINH_VIEN_DANH_GIA>()
                .Property(e => e.Ma_ket_qua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Ma_Nguoi_dung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.TenDangNhap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BAI_THI_CUA_SINH_VIEN)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DANH_MUC_CAU_HOI)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
