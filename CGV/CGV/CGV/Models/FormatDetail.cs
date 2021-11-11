namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FormatDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormatDetail()
        {
            Showtimes = new HashSet<Showtime>();
        }

        [Key]
        [StringLength(20)]
        public string IDFormat { get; set; }

        [Required]
        [StringLength(20)]
        public string IDMovie { get; set; }

        [Required]
        [StringLength(10)]
        public string IDMovieFormat { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual MovieFormat MovieFormat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
