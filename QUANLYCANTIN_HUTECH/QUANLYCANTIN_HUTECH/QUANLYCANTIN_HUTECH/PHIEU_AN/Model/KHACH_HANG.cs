namespace PHIEU_AN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            PHIEU_AN = new HashSet<PHIEU_AN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_KH { get; set; }

        [StringLength(100)]
        public string HO_TEN_KH { get; set; }

        [StringLength(200)]
        public string DIA_CHI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_AN> PHIEU_AN { get; set; }
    }
}
