namespace NguyenNgocTrinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THONG_KE
    {
        [Key]
        [StringLength(10)]
        public string MA_THONG_KE { get; set; }

        [Required]
        [StringLength(10)]
        public string SO_PHIEU_TON { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_HOA_DON { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_HANG { get; set; }

        public DateTime? NGAY_THONG_KE { get; set; }

        public int? TONG_SL_BAN { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONG_DOANH_THU { get; set; }

        public virtual CHI_TIET_HOA_DON CHI_TIET_HOA_DON { get; set; }

        public virtual PHIEU_TON_KHO PHIEU_TON_KHO { get; set; }
    }
}
