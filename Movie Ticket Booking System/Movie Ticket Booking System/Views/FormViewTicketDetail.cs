using Movie_Ticket_Booking_System.Models;
using Movie_Ticket_Booking_System.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormViewTicketDetail : Form
    {
        private ContextDB context = Program.context;
        private string ticketID, accountID = FormMenu.instance.info.AccountID;
        private DialogResult dlr;
        private TicketDetails ticket = null;
        public FormViewTicketDetail(string ticketID)
        {
            InitializeComponent();
            this.ticketID = ticketID;
        }

        private void FormViewTicketDetail_Load(object sender, EventArgs e)
        {           
            loadData();
        }


        private string parseDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void loadData()
        {
            var query = context.TICKETS
                .Find(this.ticketID);

            var queryChair = query.CHAIRS
                .Where(x => x.TicketID == this.ticketID)
                .ToList();

            string movieName = query.SHOWTIME.MOVIE.Name,
                showTime = parseDate(query.SHOWTIME.MovieShowTime)
                + " - " + parseDate(query.SHOWTIME.MovieEndTime),
                room = query.SHOWTIME.ROOM.RoomName;
            decimal? subTotalPrice = query.SubTotalPrice,
                totalPrice = query.TotalPrice;
            int? discountPercent = query.DiscountPercent;



            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + query.SHOWTIME.MovieID + ".jpg"));
            this.lblName.Text += movieName;
            this.lblTime.Text += query.SHOWTIME.MOVIE.Time;
            this.lblPrice.Text += query.SHOWTIME.MOVIE.Price;
            this.lblSubTotalPrice.Text += subTotalPrice;
            this.lblRoom.Text += room;
            this.lblShowTime.Text += showTime;
            this.lblTotalPriceSeat.Text += queryChair
                .Sum(x => x.Price).ToString();
            this.lblBookingDate.Text += parseDate(query.BookingDate);
            this.lblDisountPercent.Text += discountPercent;
            this.lblTotalPrice.Text += totalPrice;
            int length = queryChair.Count;
            for (int index = 0; index < length; index++)
                this.lblSeat.Text += index != length - 1
                    ? queryChair[index].ChairName + ", "
                    : queryChair[index].ChairName;

            ticket = new TicketDetails(this.ticketID, movieName, showTime, room, lblSeat.Text.Substring(4),
                subTotalPrice, discountPercent, totalPrice);
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            dlr = MessageBox.Show("Bạn có chắc muốn hủy vé không", "", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
                removeTicket();
            else return;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Report.PrintRP printRP = new Report.PrintRP();
            printRP.printTicket(this.ticket);
            printRP.Show();
        }

        private void removeTicket()
        {
            var query = context.TICKETS
                .Find(this.ticketID);

            DateTime currDate = DateTime.Now;
            if(currDate > query.SHOWTIME.MovieShowTime.AddMinutes(-5))
            {
                MessageBox.Show("Phim đã chiếu không thể hủy");
                return;
            }

            context.ACCOUNTS.Find(this.accountID).Balance += query.TotalPrice;
            context.TICKETS.Remove(query);

            var queryChair = context.CHAIRS
                .Where(x => x.TicketID == this.ticketID)
                .ToList();
            queryChair.ForEach(x => context.CHAIRS.Remove(x));

            context.SaveChanges();
            MessageBox.Show("Hủy vé thành công");
            FormViewHistory.instance.loadData();
            this.Dispose();
        }
    }
}
