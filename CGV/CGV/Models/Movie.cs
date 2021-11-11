namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            FormatDetails = new HashSet<FormatDetail>();
            FilmGenres = new HashSet<FilmGenre>();
        }

        [Key]
        [StringLength(20)]
        public string IDMovie { get; set; }

        [Required]
        [StringLength(100)]
        public string MovieName { get; set; }

        [StringLength(1000)]
        public string DescriptionFilm { get; set; }

        public double TotalTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime PremiereDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Productor { get; set; }

        [StringLength(50)]
        public string Director { get; set; }

        public int ProductionYear { get; set; }

        [Column(TypeName = "image")]
        public byte[] Posters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormatDetail> FormatDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmGenre> FilmGenres { get; set; }

		//public virtual ICollection<MovieDetails> MovieDetails { get; set; }
    }
}
