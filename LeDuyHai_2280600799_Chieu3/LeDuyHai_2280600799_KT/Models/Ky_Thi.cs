namespace LeDuyHai_2280600799_KT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ky_Thi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ky_Thi()
        {
            Bai_Thi = new HashSet<Bai_Thi>();
            Mon_Hoc = new HashSet<Mon_Hoc>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Ky_Thi { get; set; }

        [StringLength(50)]
        public string Ten_Ky_Thi { get; set; }

        public DateTime? Thoi_Gian_Bat_Dau { get; set; }

        public DateTime? Thoi_Gian_Ket_Thuc { get; set; }

        public int? Thoi_Gian_Lam_Bai { get; set; }

        public int? So_Luong_Cau_Hoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bai_Thi> Bai_Thi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mon_Hoc> Mon_Hoc { get; set; }
    }
}
