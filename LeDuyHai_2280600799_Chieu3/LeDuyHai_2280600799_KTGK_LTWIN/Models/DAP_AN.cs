namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAP_AN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAP_AN()
        {
            DAP_AN_CUA_SINH_VIEN = new HashSet<DAP_AN_CUA_SINH_VIEN>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_dap_an { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_cau_hoi { get; set; }

        [StringLength(200)]
        public string Noi_dung_dap_an { get; set; }

        public DateTime? Thoi_gian_tao { get; set; }

        public DateTime? Thoi_gian_cap_nhat { get; set; }

        public bool? Dap_an_dung { get; set; }

        public virtual CAU_HOI CAU_HOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAP_AN_CUA_SINH_VIEN> DAP_AN_CUA_SINH_VIEN { get; set; }
    }
}
