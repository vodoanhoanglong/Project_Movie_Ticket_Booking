namespace Movie_Ticket_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNT()
        {
            DISCOUNTs = new HashSet<DISCOUNT>();
            TICKETs = new HashSet<TICKET>();
        }

        [StringLength(10)]
        public string AccountID { get; set; }

        public string Password { get; set; }

        [StringLength(30)]
        [Column(TypeName = "NVARCHAR")]
        public string FullName { get; set; }

        public decimal? Balance { get; set; }

        [StringLength(10)]
        [Column(TypeName = "NVARCHAR")]
        public string Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCOUNT> DISCOUNTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET> TICKETs { get; set; }
    }
}
