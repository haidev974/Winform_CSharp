namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAI_THI_CUA_SINH_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAI_THI_CUA_SINH_VIEN()
        {
            DAP_AN_CUA_SINH_VIEN = new HashSet<DAP_AN_CUA_SINH_VIEN>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_bai_thi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_ky_thi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Nguoi_dung { get; set; }

        public DateTime? Thoi_gian_bat_dau { get; set; }

        public DateTime? Thoi_gian_ket_thuc { get; set; }

        [StringLength(20)]
        public string Trang_thai_bai_thi { get; set; }

        public DateTime? Thoi_gian_tao { get; set; }

        public DateTime? Thoi_gian_cap_nhat { get; set; }

        public virtual KY_THI KY_THI { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAP_AN_CUA_SINH_VIEN> DAP_AN_CUA_SINH_VIEN { get; set; }
    }
}
