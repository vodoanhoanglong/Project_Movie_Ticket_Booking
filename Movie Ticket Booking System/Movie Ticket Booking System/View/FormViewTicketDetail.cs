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
        private string bookingDate;
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

        private void loadData()
        {          
            var query = context.TICKETS
                .AsEnumerable()
                .FirstOrDefault(x => x.AccountID == "0932341148" 
                && convertDateToString(x.BookingDate) == bookingDate);
            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + query.MovieID + ".jpg"));
        }
    }
}
