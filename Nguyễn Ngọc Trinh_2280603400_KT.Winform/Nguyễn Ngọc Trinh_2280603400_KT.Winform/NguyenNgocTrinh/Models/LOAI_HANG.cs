namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_HANG()
        {
            HANG_HOA = new HashSet<HANG_HOA>();
        }

        [Key]
        [StringLength(10)]
        public string MA_LOAI_HANG { get; set; }

        [StringLength(30)]
        public string TEN_LOAI_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANG_HOA> HANG_HOA { get; set; }
    }
}
