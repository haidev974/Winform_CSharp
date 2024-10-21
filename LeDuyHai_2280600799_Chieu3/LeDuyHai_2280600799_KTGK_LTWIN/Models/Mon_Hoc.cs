namespace LeDuyHai_2280600799_KTGK_LTWIN.Models
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
            CHUONGs = new HashSet<CHUONG>();
            KY_THI = new HashSet<KY_THI>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Mon_Hoc { get; set; }

        [StringLength(30)]
        public string Ten_Mon_Hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG> CHUONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KY_THI> KY_THI { get; set; }
    }
}
