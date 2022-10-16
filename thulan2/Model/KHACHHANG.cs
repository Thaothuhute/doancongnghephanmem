namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOPDONGs = new HashSet<HOPDONG>();
        }

        [Key]
        [StringLength(6)]
        public string Makh { get; set; }

        [Required]
        [StringLength(35)]
        public string Tenkh { get; set; }

        [Required]
        [StringLength(12)]
        public string CMND { get; set; }

        [StringLength(11)]
        public string Sdt { get; set; }

        public bool? gioitinh { get; set; }

        [StringLength(50)]
        public string MinhchungCMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
    }
}
