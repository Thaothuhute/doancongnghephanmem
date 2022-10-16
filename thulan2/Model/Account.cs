namespace thulan2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(40)]
        public string Username { get; set; }

        [Required]
        [StringLength(40)]
        public string Password { get; set; }

        public int? Typeaccount { get; set; }
    }
}
