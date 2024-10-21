namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUONG")]
    public partial class CHUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUONG()
        {
            CAU_HOI = new HashSet<CAU_HOI>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_chuong { get; set; }

        [StringLength(20)]
        public string Ten_chuong { get; set; }

        [StringLength(20)]
        public string Mo_ta { get; set; }

        public DateTime? Thoi_gian_tao { get; set; }

        public DateTime? Thoi_gian_cap_nhat { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAU_HOI> CAU_HOI { get; set; }

        public virtual Mon_Hoc Mon_Hoc { get; set; }
    }
}
