namespace PHIEU_AN.Model
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
        public string MA_NHAP_HANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        public double? SO_LUONG_NHAP { get; set; }

        public decimal? GIA_MUA { get; set; }

        [StringLength(50)]
        public string DON_VI_TINH { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }

        public virtual PHIEU_NHAP_HANG PHIEU_NHAP_HANG { get; set; }
    }
}
