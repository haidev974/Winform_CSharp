namespace LeDuyHai_2280600799_KT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mon_Hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon_Hoc()
        {
            Chuongs = new HashSet<Chuong>();
            Giang_Vien = new HashSet<Giang_Vien>();
            Ky_Thi = new HashSet<Ky_Thi>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        [Required]
        [StringLength(255)]
        public string Ten_Mon_Hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chuong> Chuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giang_Vien> Giang_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ky_Thi> Ky_Thi { get; set; }
    }
}
