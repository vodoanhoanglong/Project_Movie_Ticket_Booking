namespace Movie_Ticket_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHAIR")]
    public partial class CHAIR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHAIR()
        {
            TICKETs = new HashSet<TICKET>();
        }

        public int ChairID { get; set; }

        [StringLength(10)]
        public string ChairName { get; set; }

        public int? Type { get; set; }

        public decimal? Price { get; set; }

        public bool? haveBooked { get; set; }

        public int? RoomID { get; set; }

        public virtual ROOM ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET> TICKETs { get; set; }
    }
}
