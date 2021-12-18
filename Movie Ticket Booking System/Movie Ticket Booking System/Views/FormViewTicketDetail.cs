using Movie_Ticket_Booking_System.Models;
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
        private string bookingDate, accountID = FormMenu.instance.info.AccountID;
        private DialogResult dlr;
        public FormViewTicketDetail(string bookingDate)
        {
            InitializeComponent();
            this.bookingDate = bookingDate;
        }

        private void FormViewTicketDetail_Load(object sender, EventArgs e)
        {           
            loadData();
        }

        private string convertDateToString(DateTime date)
        {
            return date.ToString("yyyyMMddHHmmss");
        }

        private string parseDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void loadData()
        {
            var queryChair = context.TICKETS
                .AsEnumerable()
                .Where(x => x.AccountID == this.accountID
                && convertDateToString(x.BookingDate) == bookingDate)
                .ToList();

            var query = queryChair
                .FirstOrDefault();

            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + query.MovieID + ".jpg"));
            this.lblName.Text += query.SHOWTIME.MOVIE.Name;
            this.lblTime.Text += query.SHOWTIME.MOVIE.Time;
            this.lblPrice.Text += query.SubTotalPrice;
            this.lblRoom.Text += query.SHOWTIME.ROOM.RoomName;
            this.lblShowTime.Text += parseDate(query.SHOWTIME.MovieShowTime)
                + " - " + parseDate(query.SHOWTIME.MovieEndTime);
            this.lblTotalPriceSeat.Text += queryChair.Sum(x => x.CHAIR.Price).ToString();
            this.lblBookingDate.Text += parseDate(query.BookingDate);
            this.lblDisountPercent.Text += query.DiscountPercent == null ? 0 : query.DiscountPercent;
            this.lblTotalPrice.Text += query.TotalPrice;
            int length = queryChair.Count;
            for (int index = 0; index < length; index++)
                this.lblSeat.Text += index != length - 1
                    ? queryChair[index].CHAIR.ChairName + ", "
                    : queryChair[index].CHAIR.ChairName;
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            dlr = MessageBox.Show("Bạn có chắc muốn hủy vé không", "", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
                removeTicket();
            else return;
        }

        private void removeTicket()
        {
            var query = context.TICKETS
                .AsEnumerable()
                .Where(x => x.AccountID == this.accountID
                && convertDateToString(x.BookingDate) == bookingDate)
                .ToList();

            query.ForEach(item =>
            {
                context.TICKETS.Remove(item);
                context.CHAIRS.ToList().RemoveAll(x => x.ChairID == item.ChairID);
            });
            context.SaveChanges();
            MessageBox.Show("Hủy vé thành công");
            FormViewHistory.instance.loadData();
            this.Dispose();
        }
    }
}
