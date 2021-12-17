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
    public partial class FormChairBooking : Form
    {
        private ContextDB context = Program.context;
        private string showtimeID;

        public FormChairBooking(string showtimeID)
        {
            InitializeComponent();
            this.showtimeID = showtimeID;
        }

        private void FormChairBooking_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var query = context.SHOWTIMES
                .FirstOrDefault(x => x.ShowTimeID == showtimeID);

            lblTotalPrice.Text += "0";
            lblChairPrice.Text += "0";
            lblPrice.Text += query.MOVIE.Price.ToString();
            ptbMovie.ImageLocation = string.Format(@"..\..\Images\Movies\" + query.MovieID + ".jpg");
            lblShowtime.Text += query.MovieShowTime.TimeOfDay + " - " + query.MovieEndTime.TimeOfDay;
            lblRoom.Text += query.ROOM.RoomName;
        }
    }
}
