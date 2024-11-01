namespace DO_AN_LT_WIN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Mon_Hoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Ma_Ky_Thi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        public DateTime? Ngay_Thi { get; set; }

        public virtual Ky_Thi Ky_Thi { get; set; }

        public virtual Mon_Hoc Mon_Hoc { get; set; }
    }
}
