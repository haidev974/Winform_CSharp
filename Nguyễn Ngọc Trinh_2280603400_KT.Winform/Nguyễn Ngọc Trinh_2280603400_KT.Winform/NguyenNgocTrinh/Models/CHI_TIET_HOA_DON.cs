namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHI_TIET_HOA_DON()
        {
            THONG_KE = new HashSet<THONG_KE>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MA_HOA_DON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        public int? SO_LUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? DON_GIA { get; set; }

        public virtual HANG_HOA HANG_HOA { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONG_KE> THONG_KE { get; set; }
    }
}
