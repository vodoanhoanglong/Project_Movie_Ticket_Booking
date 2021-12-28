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
        private List<double> arr = new List<double>();
        private List<int> quantity = new List<int>();
        private string revenueWeek, revenueMonth, revenueYear,
            quantityWeek, quantityMonth, quantityYear;
        private int month = 0, year = 0;
        public FormRevenue()
        {
            InitializeComponent();
        }

        private void FormRevenue_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            loadData(month, year);
            toogleSwitch.Checked = false;
        }

        private void toogleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            chart.Datasets.Clear();
            chart.ApplyConfig(ConfigChart.Config(), System.Drawing.Color.FromArgb(25, 26, 31));
            MixedBarAndLine.revenue = arr;
            MixedBarAndLine.quantity = quantity;
            if (!toogleSwitch.Checked)
            {
                lblTitle.Text = "Doanh thu cụm rạp";
                MixedBarAndLine.loadChart(chart, "bar");
                lblMoneyYear.Text = revenueYear + "VNĐ";
                lblMoneyMonth.Text = revenueMonth + "VNĐ";
                lblMoneyWeek.Text = revenueWeek + "VNĐ";
                lblRevenueWeek.Text = "Doanh thu trong tuần";
                lblRevenueMonth.Text = "Doanh thu tháng " + month;
                lblRevenueYear.Text = "Doanh thu năm " + year;
            }
            else
            {
                lblTitle.Text = "Số vé bán cụm rạp";
                MixedBarAndLine.loadChart(chart, "line");
                lblMoneyYear.Text = quantityYear + "Vé";
                lblMoneyMonth.Text = quantityMonth + "Vé";
                lblMoneyWeek.Text = quantityWeek + "Vé";
                lblRevenueWeek.Text = "Vé bán trong tuần";
                lblRevenueMonth.Text = "Vé bán tháng " + month;
                lblRevenueYear.Text = "Vé bán năm " + year;
            }
        }

        private void loadData(int month, int year)
        {
            decimal total = 0, money = 0;
            int day = 6, number = 0, totalNumber = 0;
            DateTime startDate;

            var query = context.TICKETS;

            while (day >= 0)
            {
                startDate = DateTime.Today.AddDays(-day--).Date;
                var result = query.Where(x => DbFunctions.TruncateTime(x.BookingDate) == startDate);
                money = Convert.ToDecimal(result.Sum(x => x.TotalPrice));
                number = result.Count();
                total += money;
                totalNumber += number;
                arr.Add((double)money);
                quantity.Add(number);
            };

            revenueYear = query.AsEnumerable().Where(x => getYear(x.BookingDate) == year)
                .Sum(x => x.TotalPrice).ToString() + " VNĐ";
            revenueMonth = query.AsEnumerable().Where(x => getMonth(x.BookingDate) == month)
                .Sum(x => x.TotalPrice).ToString() + " VNĐ";
            revenueWeek = total.ToString() + " VNĐ";

            quantityYear = query.AsEnumerable().Where(x => getYear(x.BookingDate) == year).Count().ToString();
            quantityMonth = query.AsEnumerable().Where(x => getMonth(x.BookingDate) == month).Count().ToString();
            quantityWeek = totalNumber.ToString();

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
