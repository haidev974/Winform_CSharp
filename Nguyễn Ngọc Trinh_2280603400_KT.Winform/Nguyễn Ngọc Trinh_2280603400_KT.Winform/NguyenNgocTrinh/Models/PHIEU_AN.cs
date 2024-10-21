namespace NguyenNgocTrinh.Models
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
            HOA_DON = new HashSet<HOA_DON>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PHIEU_AN { get; set; }

        public DateTime? NGAY_MUA { get; set; }

        public int? SO_LUONG { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_KH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
