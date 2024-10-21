namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_NHAP_HANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MA_PHIEU_NHAP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        public int? SO_LUONG_NHAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? DON_GIA_NHAP { get; set; }

        public virtual HANG_HOA HANG_HOA { get; set; }

        public virtual NHAP_HANG NHAP_HANG { get; set; }
    }
}
