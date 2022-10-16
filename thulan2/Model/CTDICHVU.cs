namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDICHVU")]
    public partial class CTDICHVU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Sop { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Madv { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Maptt { get; set; }

        public int? Soluongdung { get; set; }

        [StringLength(40)]
        public string Noidung { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHIEUTHANHTOAN PHIEUTHANHTOAN { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
