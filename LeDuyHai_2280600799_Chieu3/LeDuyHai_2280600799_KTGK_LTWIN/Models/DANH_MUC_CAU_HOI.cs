namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_CAU_HOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_CAU_HOI()
        {
            CAU_HOI = new HashSet<CAU_HOI>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_DM_cau_hoi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Nguoi_dung { get; set; }

        [StringLength(30)]
        public string Ten_DM_cau_hoi { get; set; }

        public DateTime? Thoi_gian_tao { get; set; }

        public DateTime? Thoi_gian_cap_nhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAU_HOI> CAU_HOI { get; set; }

        public virtual User User { get; set; }
    }
}
