namespace CGV.Models
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
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Pass { get; set; }

        public int AccounType { get; set; }

        [Required]
        [StringLength(20)]
        public string IDStaff { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
