namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAU_HOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAU_HOI()
        {
            CAU_HOI_TRONG_KY_THI = new HashSet<CAU_HOI_TRONG_KY_THI>();
            DAP_AN = new HashSet<DAP_AN>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_cau_hoi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_DM_cau_hoi { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_chuong { get; set; }

        [StringLength(200)]
        public string Noi_dung_cau_hoi { get; set; }

        [StringLength(20)]
        public string Loai_cau_hoi { get; set; }

        [StringLength(20)]
        public string Muc_do { get; set; }

        public DateTime? Thoi_gian_tao { get; set; }

        public DateTime? Thoi_gian_cap_nhat { get; set; }

        public virtual CHUONG CHUONG { get; set; }

        public virtual DANH_MUC_CAU_HOI DANH_MUC_CAU_HOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAU_HOI_TRONG_KY_THI> CAU_HOI_TRONG_KY_THI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAP_AN> DAP_AN { get; set; }
    }
}
