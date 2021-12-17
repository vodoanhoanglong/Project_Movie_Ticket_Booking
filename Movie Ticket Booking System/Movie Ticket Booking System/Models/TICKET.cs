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
        [Key]
        [Column(Order = 0)]
        public int TicketID { get; set; }

        public DateTime? BookingDate { get; set; }

        public decimal? SubTotalPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string AccountID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(14)]
        public string ShowTimeID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieID { get; set; }

        public int? ChairID { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual CHAIR CHAIR { get; set; }

        public virtual SHOWTIME SHOWTIME { get; set; }
    }
}
