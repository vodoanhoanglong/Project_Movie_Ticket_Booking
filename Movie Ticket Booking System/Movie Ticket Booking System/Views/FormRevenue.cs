using Movie_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.Views
{
    public partial class FormRevenue : Form
    {
        private ContextDB context = Program.context;
        public FormRevenue()
        {
            InitializeComponent();
        }

        private void FormRevenue_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            decimal total = 0;
            int day = 5;
            List<int> arr = new List<int>();
            DateTime endDate = DateTime.Now.Date;
            DateTime startDate = DateTime.Today.AddDays(-6).Date;

            var query = context.TICKETS;

            while (day >= 0)
            {
                total += Convert.ToDecimal(query.Where(x => DbFunctions.TruncateTime(x.BookingDate) == startDate)
                    .Sum(x => x.TotalPrice));
                /*      arr.Add(total);*/
                MessageBox.Show(startDate.DayOfWeek.ToString());
                startDate = DateTime.Today.AddDays(-day--).Date;
            };

            this.lblMoneyWeek.Text = total.ToString() + " VNĐ";
        }
    }
}
