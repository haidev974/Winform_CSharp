namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAP_AN_CUA_SINH_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAP_AN_CUA_SINH_VIEN()
        {
            KET_QUA = new HashSet<KET_QUA>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_dap_an_sv { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_dap_an { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_bai_thi { get; set; }

        public bool? Kiem_tra_dap_an_sv_D_S_ { get; set; }

        [StringLength(1)]
        public string Dap_an_sv_chon { get; set; }

        public virtual BAI_THI_CUA_SINH_VIEN BAI_THI_CUA_SINH_VIEN { get; set; }

        public virtual DAP_AN DAP_AN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KET_QUA> KET_QUA { get; set; }
    }
}
