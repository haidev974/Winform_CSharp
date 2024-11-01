namespace LeDuyHai_KT_CTMH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phuong_An_Chon
    {
        [Key]
        [StringLength(5)]
        public string Ma_Phuong_An { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Cau_Hoi { get; set; }

        [Required]
        [StringLength(255)]
        public string Noi_Dung_Phuong_An { get; set; }

        public virtual Cau_Hoi Cau_Hoi { get; set; }
    }
}
