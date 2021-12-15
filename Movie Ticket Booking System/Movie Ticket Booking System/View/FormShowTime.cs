using Movie_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormShowTime : Form
    {
        private ContextDB context = Program.context;
        private int movieID;
        private DateTime cleanTime = Convert.ToDateTime("00:30:00");
        public FormShowTime(int movieID)
        {
            InitializeComponent();
            this.movieID = movieID;
        }

        private void FormShowTime_Load(object sender, EventArgs e)
        {
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.DataSource = context.ROOMS.ToList();

            dtpShowDate.MinDate = DateTime.Now.AddDays(1);


            //gan date time cho 2 control
            /*datePortionDateTimePicker.Value = myDate.Date;
            timePortionDateTimePicker.Value = myDate.TimeOfDay;*/
        }

        private DateTime getTimeMovie()
        {
            return Convert.ToDateTime(context.MOVIES.Find(movieID).Time);
        }

        private DateTime getDtpDate()
        {          
            return dtpShowDate.Value.Date + dtpShowTime.Value.TimeOfDay;
        }

        private DateTime getDtpTotalTime()
        {
            DateTime movieTime = getTimeMovie();
            DateTime totalTime = dtpShowTime.Value.Add(movieTime.TimeOfDay);
            return dtpShowDate.Value.Date + totalTime.Add(cleanTime.TimeOfDay).TimeOfDay;
        }

        private DateTime getTimeEnd()
        {
            DateTime movieTime = getTimeMovie();
            DateTime totalTime = dtpShowTime.Value.Add(movieTime.TimeOfDay);
            return dtpShowDate.Value.Date + totalTime.TimeOfDay;
        }

        private int getRoomID()
        {
            return Convert.ToInt32(cmbRoom.SelectedValue);
        }

        private DateTime parseDate(DateTime date)
        {
            string currDate = date.ToString("yyyy-MM-dd HH:mm:ss:fff");
            DateTime currDateParse = DateTime.ParseExact(currDate, "yyyy-MM-dd HH:mm:ss:fff",
                CultureInfo.InvariantCulture);
            return currDateParse;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!checkShowTime())
                saveShowTime();
            else
                MessageBox.Show("Da bi trung");
        }

        private bool checkShowTime()
        {
            int roomID = Convert.ToInt32(cmbRoom.SelectedValue);
            DateTime date = getDtpDate().Date;
            TimeSpan time = getDtpTotalTime().TimeOfDay - getDtpDate().TimeOfDay;
            var query = context.SHOWTIMES
                .Where(x => x.RoomID == roomID
                && DbFunctions.TruncateTime(x.MovieShowTime) == date)
                .ToList();
            for (int index = 0; index < query.Count; index++)
            {
                if ((query[index].MovieShowTime.TimeOfDay <= getDtpDate().TimeOfDay && getDtpDate().TimeOfDay <= query[index].MovieEndTime.TimeOfDay)
                    || query[index].MovieShowTime.TimeOfDay <= getDtpTotalTime().TimeOfDay && getDtpTotalTime().TimeOfDay <= query[index].MovieEndTime.TimeOfDay)
                    return true;
                else
                    for (int minutes = 1; minutes <= time.TotalMinutes; minutes++)
                    {
                        DateTime currMinutes = getDtpDate().AddMinutes(minutes);
                        if (query[index].MovieShowTime.TimeOfDay <= currMinutes.TimeOfDay && currMinutes.TimeOfDay <= query[index].MovieEndTime.TimeOfDay)
                            return true;
                    }
            }
            return false;
        }

        private void saveShowTime()
        {
            SHOWTIME createST = new SHOWTIME();
            
            createST.ShowTimeID = parseDate(DateTime.Now);
            createST.MovieShowTime = parseDate(getDtpDate());
            createST.MovieEndTime = getTimeEnd();
            createST.MovieID = movieID;
            createST.RoomID = getRoomID();
            context.SHOWTIMES.Add(createST);
            context.SaveChanges();
            MessageBox.Show("Tạo thành công");
            this.Dispose();
        }
    }
}
