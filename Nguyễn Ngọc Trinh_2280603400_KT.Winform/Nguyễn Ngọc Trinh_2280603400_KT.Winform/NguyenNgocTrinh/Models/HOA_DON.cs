namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string MA_HOA_DON { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_PHIEU_AN { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_NV { get; set; }

        public DateTime? NGAY_LAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONG_TIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        public virtual PHIEU_AN PHIEU_AN { get; set; }
    }
}
