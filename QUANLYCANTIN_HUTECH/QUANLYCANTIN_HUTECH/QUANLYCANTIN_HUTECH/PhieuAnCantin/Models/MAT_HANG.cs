namespace PhieuAnCantin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAT_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAT_HANG()
        {
            CHI_TIET_NHAP_HANG = new HashSet<CHI_TIET_NHAP_HANG>();
            CHI_TIET_PHIEU_AN = new HashSet<CHI_TIET_PHIEU_AN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_LOAI_HANG { get; set; }

        [StringLength(50)]
        public string TEN_HANG { get; set; }

        [StringLength(50)]
        public string HAN_SU_DUNG { get; set; }

        public double? SO_LUONG_TON { get; set; }

        [StringLength(50)]
        public string DON_VI_TINH { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_NHAP_HANG> CHI_TIET_NHAP_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_AN> CHI_TIET_PHIEU_AN { get; set; }

        public virtual LOAI_HANG LOAI_HANG { get; set; }
    }
}
