namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SINH_VIEN_DANH_GIA
    {
        [Key]
        [StringLength(10)]
        public string Ma_danh_gia { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_ket_qua { get; set; }

        [StringLength(30)]
        public string Noi_dung { get; set; }

        public DateTime? Thoi_gian_danh_gia { get; set; }

        public virtual KET_QUA KET_QUA { get; set; }
    }
}
