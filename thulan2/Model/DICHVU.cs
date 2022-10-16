namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CTDICHVUs = new HashSet<CTDICHVU>();
        }

        [Key]
        [StringLength(5)]
        public string Madv { get; set; }

        [Required]
        [StringLength(20)]
        public string Tendv { get; set; }

        [Required]
        [StringLength(10)]
        public string Donvitinh { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDICHVU> CTDICHVUs { get; set; }
    }
}
