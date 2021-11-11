namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Showtime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Showtime()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        [StringLength(20)]
        public string IDShowtimes { get; set; }

        [Column("ShowTime")]
        public DateTime ShowTime1 { get; set; }

        [Required]
        [StringLength(20)]
        public string IDRoom { get; set; }

        [Required]
        [StringLength(20)]
        public string IDFormat { get; set; }

        [Column(TypeName = "money")]
        public decimal Fare { get; set; }

        public int Statues { get; set; }

        public virtual FormatDetail FormatDetail { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
