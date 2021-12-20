namespace Movie_Ticket_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SHOWTIME")]
    public partial class SHOWTIME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHOWTIME()
        {
            TICKETs = new HashSet<TICKET>();
        }

        [StringLength(14)]
        public string ShowTimeID { get; set; }

        public DateTime MovieShowTime { get; set; }

        public DateTime MovieEndTime { get; set; }

        public int RoomID { get; set; }

        public int MovieID { get; set; }

        public virtual MOVIE MOVIE { get; set; }

        public virtual ROOM ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET> TICKETs { get; set; }
    }
}
