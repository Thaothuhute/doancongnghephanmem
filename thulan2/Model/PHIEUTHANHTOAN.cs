namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHANHTOAN")]
    public partial class PHIEUTHANHTOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHANHTOAN()
        {
            CTDICHVUs = new HashSet<CTDICHVU>();
        }

        [Key]
        [StringLength(10)]
        public string Maptt { get; set; }

        public DateTime? Ngaylapphieu { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tongtiendichvu { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tienphong { get; set; }

        public int? Trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDICHVU> CTDICHVUs { get; set; }
    }
}
