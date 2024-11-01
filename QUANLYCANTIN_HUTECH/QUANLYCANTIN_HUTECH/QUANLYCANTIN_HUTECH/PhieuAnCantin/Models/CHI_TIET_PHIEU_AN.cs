namespace PhieuAnCantin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHIEU_AN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MA_PHIEU_AN { get; set; }

        [StringLength(10)]
        public string MA_KHUYEN_MAI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        public decimal? GIA_BAN { get; set; }

        [StringLength(10)]
        public string DON_VI_TINH { get; set; }

        public double? SO_LUONG_MUA { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }

        public virtual KHUYEN_MAI KHUYEN_MAI { get; set; }

        public virtual PHIEU_AN PHIEU_AN { get; set; }
    }
}
