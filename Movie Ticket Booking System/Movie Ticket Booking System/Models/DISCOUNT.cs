namespace Movie_Ticket_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DISCOUNT")]
    public partial class DISCOUNT
    {
        public int DiscountID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public int? Percent { get; set; }

        public bool isActive { get; set; }

        [StringLength(10)]
        public string AccountID { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}
