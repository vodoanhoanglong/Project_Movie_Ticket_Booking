namespace Movie_Ticket_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TICKET")]
    public partial class TICKET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TICKET()
        {
            CHAIRS = new HashSet<CHAIR>();
        }

        [StringLength(50)]
        public string TicketID { get; set; }

        public DateTime BookingDate { get; set; }

        public int? DiscountPercent { get; set; }

        public decimal? SubTotalPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        [StringLength(10)]
        public string AccountID { get; set; }

        [StringLength(14)]
        public string ShowTimeID { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHAIR> CHAIRS { get; set; }

        public virtual SHOWTIME SHOWTIME { get; set; }
    }
}
