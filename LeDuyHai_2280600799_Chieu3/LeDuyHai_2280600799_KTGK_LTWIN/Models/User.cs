namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            BAI_THI_CUA_SINH_VIEN = new HashSet<BAI_THI_CUA_SINH_VIEN>();
            DANH_MUC_CAU_HOI = new HashSet<DANH_MUC_CAU_HOI>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Nguoi_dung { get; set; }

        [StringLength(10)]
        public string Ho { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string TenDangNhap { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(20)]
        public string VaiTro { get; set; }

        public DateTime? ThoiGianTao { get; set; }

        public DateTime? ThoiGianCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAI_THI_CUA_SINH_VIEN> BAI_THI_CUA_SINH_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC_CAU_HOI> DANH_MUC_CAU_HOI { get; set; }
    }
}
