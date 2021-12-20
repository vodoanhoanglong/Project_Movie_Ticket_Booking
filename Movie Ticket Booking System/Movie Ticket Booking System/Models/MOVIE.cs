namespace Movie_Ticket_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MOVIE")]
    public partial class MOVIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOVIE()
        {
            SHOWTIMEs = new HashSet<SHOWTIME>();
        }

        public int MovieID { get; set; }

        public string Name { get; set; }

        [StringLength(8)]
        public string Time { get; set; }

        public string Des { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOWTIME> SHOWTIMEs { get; set; }
    }
}
