namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Showtimes = new HashSet<Showtime>();
        }

        [Key]
        [StringLength(20)]
        public string IDRoom { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomName { get; set; }

        [StringLength(10)]
        public string IDMovieFormat { get; set; }

        public int TotalSeats { get; set; }

        public int Condition { get; set; }

        public int TotalRowsSeats { get; set; }

        public int TotalSeatsPerRow { get; set; }

        public virtual MovieFormat MovieFormat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
