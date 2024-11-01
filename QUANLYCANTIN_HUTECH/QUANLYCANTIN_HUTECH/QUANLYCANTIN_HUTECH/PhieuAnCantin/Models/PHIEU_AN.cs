namespace PhieuAnCantin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_AN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_AN()
        {
            CHI_TIET_PHIEU_AN = new HashSet<CHI_TIET_PHIEU_AN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PHIEU_AN { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_THONG_KE { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_KH { get; set; }

        public DateTime? NGAY_LAP { get; set; }

        public decimal? TONG_TIEN { get; set; }

        public bool? PHUONG_THUC_THANH_TOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_AN> CHI_TIET_PHIEU_AN { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        public virtual PHIEU_THONG_KE PHIEU_THONG_KE { get; set; }
    }
}
