namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            PHIEUGIAHANs = new HashSet<PHIEUGIAHAN>();
        }

        [Key]
        [StringLength(10)]
        public string Mahd { get; set; }

        public DateTime? Ngaylapphieu { get; set; }

        public DateTime? Ngayhethan { get; set; }

        [Column(TypeName = "money")]
        public decimal Tiencoc { get; set; }

        public int? Trangthai { get; set; }

        [StringLength(6)]
        public string Makh { get; set; }

        [StringLength(5)]
        public string Sop { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUGIAHAN> PHIEUGIAHANs { get; set; }
    }
}
