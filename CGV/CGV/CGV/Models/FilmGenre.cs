namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmGenre")]
    public partial class FilmGenre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FilmGenre()
        {
            Movies = new HashSet<Movie>();
        }

        [Key]
        [StringLength(20)]
        public string IDCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(100)]
        public string Descriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
