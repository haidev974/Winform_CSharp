namespace PHIEU_AN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_THONG_KE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_THONG_KE()
        {
            PHIEU_AN = new HashSet<PHIEU_AN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_THONG_KE { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_NV { get; set; }

        public DateTime? NGAY_BAT_DAU_THONG_KE { get; set; }

        public DateTime? NGAY_KET_THUC_THONG_KE { get; set; }

        public DateTime? NGAY_THONG_KE { get; set; }

        public int? TONG_SL_BAN { get; set; }

        public decimal? TONG_DOANH_THU { get; set; }

        public decimal? THUE_HANG_NAM { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_AN> PHIEU_AN { get; set; }
    }
}
