namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAP_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAP_HANG()
        {
            CHI_TIET_NHAP_HANG = new HashSet<CHI_TIET_NHAP_HANG>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PHIEU_NHAP { get; set; }

        public DateTime? NGAY_NHAP { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_NHAP_HANG> CHI_TIET_NHAP_HANG { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
