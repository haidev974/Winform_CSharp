namespace PHIEU_AN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            PHIEU_AN = new HashSet<PHIEU_AN>();
            PHIEU_NHAP_HANG = new HashSet<PHIEU_NHAP_HANG>();
            PHIEU_THONG_KE = new HashSet<PHIEU_THONG_KE>();
        }

        [Key]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_CV { get; set; }

        [StringLength(100)]
        public string HO_VA_TEN_NV { get; set; }

        public DateTime? NTNS { get; set; }

        public bool? PHAI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public bool? TRANG_THAI_LAM_VIEC { get; set; }

        [StringLength(20)]
        public string CA_LV { get; set; }

        public DateTime? NGAY_BAT_DAU_LAM_VIEC { get; set; }

        public DateTime? NGAY_KET_THUC_LAM_VIEC { get; set; }

        [StringLength(50)]
        public string MAT_KHAU { get; set; }

        public virtual CHUC_VU CHUC_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_AN> PHIEU_AN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_NHAP_HANG> PHIEU_NHAP_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THONG_KE> PHIEU_THONG_KE { get; set; }
    }
}
