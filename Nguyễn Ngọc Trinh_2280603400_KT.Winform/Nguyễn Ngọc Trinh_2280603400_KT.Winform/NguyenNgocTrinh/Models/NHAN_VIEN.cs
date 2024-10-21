namespace NguyenNgocTrinh.Models
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
            HOA_DON = new HashSet<HOA_DON>();
            NHAP_HANG = new HashSet<NHAP_HANG>();
        }

        [Key]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [StringLength(30)]
        public string TEN_NV { get; set; }

        [StringLength(30)]
        public string CHUC_VU { get; set; }

        [StringLength(20)]
        public string TEN_DANG_NHAP { get; set; }

        [StringLength(20)]
        public string MAT_KHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAP_HANG> NHAP_HANG { get; set; }
    }
}
