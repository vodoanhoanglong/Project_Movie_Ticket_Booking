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
        [StringLength(50)]
        public string ChairID { get; set; }

        [StringLength(10)]
        public string ChairName { get; set; }

        public int? Type { get; set; }

        public decimal? Price { get; set; }

        public bool? haveBooked { get; set; }

        public int? RoomID { get; set; }

        [StringLength(50)]
        public string TicketID { get; set; }

        public virtual ROOM ROOM { get; set; }

        public virtual TICKET TICKET { get; set; }
    }
}
