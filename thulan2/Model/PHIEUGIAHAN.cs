namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUGIAHAN")]
    public partial class PHIEUGIAHAN
    {
        [Key]
        [StringLength(10)]
        public string Maphieu { get; set; }

        public DateTime? Ngaylappheiu { get; set; }

        [StringLength(10)]
        public string Mahd { get; set; }

        public int? Trangthai { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }
    }
}
