namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        [StringLength(20)]
        public string IDClient { get; set; }

        [Required]
        [StringLength(50)]
        public string NameClient { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthdayClient { get; set; }

        [StringLength(100)]
        public string AddressClient { get; set; }

        [StringLength(20)]
        public string NumberPhoneClient { get; set; }

        public int IDCardClient { get; set; }

        public int? PlushPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
