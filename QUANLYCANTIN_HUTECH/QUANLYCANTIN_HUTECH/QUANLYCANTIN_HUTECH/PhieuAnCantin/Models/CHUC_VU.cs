namespace PhieuAnCantin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUC_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUC_VU()
        {
            NHAN_VIEN = new HashSet<NHAN_VIEN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_CV { get; set; }

        [StringLength(50)]
        public string TEN_CV { get; set; }

        public decimal? LUONG_CB { get; set; }

        public double? HE_SO_LUONG { get; set; }

        public decimal? TRO_CAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAN_VIEN> NHAN_VIEN { get; set; }
    }
}
