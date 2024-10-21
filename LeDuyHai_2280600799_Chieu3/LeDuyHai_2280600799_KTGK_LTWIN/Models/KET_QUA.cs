namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KET_QUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KET_QUA()
        {
            SINH_VIEN_DANH_GIA = new HashSet<SINH_VIEN_DANH_GIA>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_ket_qua { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_dap_an_sv { get; set; }

        public int? Diem { get; set; }

        public virtual DAP_AN_CUA_SINH_VIEN DAP_AN_CUA_SINH_VIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINH_VIEN_DANH_GIA> SINH_VIEN_DANH_GIA { get; set; }
    }
}
