namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KY_THI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KY_THI()
        {
            BAI_THI_CUA_SINH_VIEN = new HashSet<BAI_THI_CUA_SINH_VIEN>();
            CAU_HOI_TRONG_KY_THI = new HashSet<CAU_HOI_TRONG_KY_THI>();
            Mon_Hoc = new HashSet<Mon_Hoc>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_ky_thi { get; set; }

        [StringLength(20)]
        public string Ten_ky_thi { get; set; }

        public DateTime? Thoi_gian_bat_dau { get; set; }

        public DateTime? Thoi_gian_ket_thuc { get; set; }

        public DateTime? Thoi_gian_lam_bai { get; set; }

        [StringLength(20)]
        public string Trang_thai_thi { get; set; }

        public DateTime? Thoi_gian_tao { get; set; }

        public DateTime? Thoi_gian_cap_nhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAI_THI_CUA_SINH_VIEN> BAI_THI_CUA_SINH_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAU_HOI_TRONG_KY_THI> CAU_HOI_TRONG_KY_THI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mon_Hoc> Mon_Hoc { get; set; }
    }
}
