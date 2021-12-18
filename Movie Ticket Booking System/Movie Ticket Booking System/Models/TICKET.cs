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
        [StringLength(50)]
        public string TicketID { get; set; }

        public DateTime BookingDate { get; set; }

        public int? DiscountPercent { get; set; }

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

        [Required]
        [StringLength(50)]
        public string ChairID { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual CHAIR CHAIR { get; set; }

        public virtual SHOWTIME SHOWTIME { get; set; }
    }
}
