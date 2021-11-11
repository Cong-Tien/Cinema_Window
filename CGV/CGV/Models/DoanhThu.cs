namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        [Key]
        public int DDDoanhThu { get; set; }

        [Required]
        [StringLength(20)]
        public string IDShowtimes { get; set; }

        public int? SoVeBan { get; set; }

        [Column("DoanhThu", TypeName = "money")]
        public decimal? DoanhThu1 { get; set; }

        public virtual Showtime Showtime { get; set; }
    }
}
