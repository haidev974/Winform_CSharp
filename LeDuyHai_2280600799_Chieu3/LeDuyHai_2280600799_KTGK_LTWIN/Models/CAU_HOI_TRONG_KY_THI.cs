namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAU_HOI_TRONG_KY_THI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Ma_ky_thi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Ma_cau_hoi { get; set; }

        public int? Thu_tu_cau_hoi { get; set; }

        public virtual CAU_HOI CAU_HOI { get; set; }

        public virtual KY_THI KY_THI { get; set; }
    }
}
