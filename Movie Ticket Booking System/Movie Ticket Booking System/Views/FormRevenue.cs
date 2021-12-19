using Movie_Ticket_Booking_System.Chart;
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
            DateTime now = DateTime.Now;
            lblRevenueMonth.Text += now.Month;
            lblRevenueYear.Text += now.Year;
            loadData(now.Month, now.Year);
        }

        private void loadData(int month, int year)
        {
            decimal total = 0;
            int day = 6;
            List<double> arr = new List<double>();
            DateTime startDate;

            var query = context.TICKETS
                .GroupBy(x => new
                {
                    x.BookingDate,
                    x.AccountID,
                    x.TotalPrice
                });

            while (day >= 0)
            {
                decimal money;
                startDate = DateTime.Today.AddDays(-day--).Date;
                money = Convert.ToDecimal(query.Where(x => DbFunctions.TruncateTime(x.Key.BookingDate) == startDate)
                .Sum(x => x.Key.TotalPrice));
                total += money;
                arr.Add((double)money);
            };

            chart.Datasets.Clear();
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(25, 26, 31));
            SplineArea.data = arr;
            SplineArea.loadChart(chart);

            this.lblMoneyYear.Text = query.AsEnumerable().Where(x => getYear(x.Key.BookingDate) == year)
                .Sum(x => x.Key.TotalPrice).ToString() + " VNĐ";
            this.lblMoneyMonth.Text = query.AsEnumerable().Where(x => getMonth(x.Key.BookingDate) == month)
                .Sum(x => x.Key.TotalPrice).ToString() + " VNĐ";
            this.lblMoneyWeek.Text = total.ToString() + " VNĐ";

        }

        private int getYear(DateTime date)
        {
            return date.Year;
        }

        private int getMonth(DateTime date)
        {
            return date.Month;
        }
    }
}
