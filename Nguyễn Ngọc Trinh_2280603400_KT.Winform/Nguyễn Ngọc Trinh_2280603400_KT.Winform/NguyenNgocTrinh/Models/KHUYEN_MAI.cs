namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHUYEN_MAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYEN_MAI()
        {
            HANG_HOA = new HashSet<HANG_HOA>();
        }

        [Key]
        [StringLength(10)]
        public string MA_KM { get; set; }

        [StringLength(50)]
        public string TEN_KM { get; set; }

        public DateTime? BAT_DAU { get; set; }

        public DateTime? KET_THUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANG_HOA> HANG_HOA { get; set; }
    }
}
