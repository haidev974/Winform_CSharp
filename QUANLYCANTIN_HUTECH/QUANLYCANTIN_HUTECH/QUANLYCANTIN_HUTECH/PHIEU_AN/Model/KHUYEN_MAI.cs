namespace PHIEU_AN.Model
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
            CHI_TIET_PHIEU_AN = new HashSet<CHI_TIET_PHIEU_AN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_KHUYEN_MAI { get; set; }

        [StringLength(50)]
        public string TEN_KHUYEN_MAI { get; set; }

        public DateTime? NGAY_BAT_DAU { get; set; }

        public DateTime? NGAY_KET_THUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_AN> CHI_TIET_PHIEU_AN { get; set; }
    }
}
