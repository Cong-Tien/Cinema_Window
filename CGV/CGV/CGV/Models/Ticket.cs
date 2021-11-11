namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [Key]
        public int IDTicket { get; set; }

        public int? LoaiVe { get; set; }

        [StringLength(20)]
        public string IDShowTimes { get; set; }

        [StringLength(20)]
        public string MaGheNgoi { get; set; }

        [StringLength(20)]
        public string IDClient { get; set; }

        public int TrangThai { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienBanVe { get; set; }

        public virtual Client Client { get; set; }

        public virtual Showtime Showtime { get; set; }
    }
}
