using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System.Report
{
    public class TicketDetails
    {
        public string TicketID { get; set; }
        public string MovieName { get; set; }
        public string MovieShowTime { get; set; }
        public string RoomName { get; set; }
        public string ChairName { get; set; }
        public decimal? SubTotalPrice { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? TotalPrice { get; set; }

        public TicketDetails() { }
        public TicketDetails(string TicketID, string MovieName, string MovieShowTime,
            string RoomName, string ChairName, decimal? SubTotalPrice, int? DiscountPercent, decimal? TotalPrice)
        {
            this.TicketID = TicketID;
            this.MovieName = MovieName;
            this.MovieShowTime = MovieShowTime;
            this.RoomName = RoomName;
            this.ChairName = ChairName;
            this.SubTotalPrice = SubTotalPrice;
            this.DiscountPercent = DiscountPercent;
            this.TotalPrice = TotalPrice;
        }

    }
}
