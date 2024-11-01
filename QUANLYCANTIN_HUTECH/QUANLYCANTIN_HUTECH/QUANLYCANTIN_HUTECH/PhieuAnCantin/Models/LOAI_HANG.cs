namespace PhieuAnCantin.Models
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
            MAT_HANG = new HashSet<MAT_HANG>();
        }

        [Key]
        [StringLength(10)]
        public string MA_LOAI_HANG { get; set; }

        [StringLength(50)]
        public string TEN_LOAI_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAT_HANG> MAT_HANG { get; set; }
    }
}
