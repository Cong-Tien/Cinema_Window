namespace CGV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Accounts = new HashSet<Account>();
        }

        [Key]
        [StringLength(20)]
        public string IDStaff { get; set; }

        [Required]
        [StringLength(50)]
        public string NameStaff { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthdayStaff { get; set; }

        [StringLength(100)]
        public string AddressStaff { get; set; }

        [StringLength(20)]
        public string NumberPhoneStaff { get; set; }

        public int IDCard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
