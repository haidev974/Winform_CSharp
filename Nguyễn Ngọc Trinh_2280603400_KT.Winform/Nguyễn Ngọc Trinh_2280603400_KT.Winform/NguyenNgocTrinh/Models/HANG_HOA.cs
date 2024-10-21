namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HANG_HOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANG_HOA()
        {
            CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
            CHI_TIET_NHAP_HANG = new HashSet<CHI_TIET_NHAP_HANG>();
            PHIEU_TON_KHO = new HashSet<PHIEU_TON_KHO>();
        }

        [Key]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        [StringLength(20)]
        public string TEN_HANG { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA { get; set; }

        public int? DON_VI_TINH { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_LOAI_HANG { get; set; }

        public DateTime? HSD { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_KM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_NHAP_HANG> CHI_TIET_NHAP_HANG { get; set; }

        public virtual KHUYEN_MAI KHUYEN_MAI { get; set; }

        public virtual LOAI_HANG LOAI_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_TON_KHO> PHIEU_TON_KHO { get; set; }
    }
}
