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
    public partial class FormCreateShowTime : Form
    {
        private ContextDB context = Program.context;
        private int movieID;
        private DateTime cleanTime = Convert.ToDateTime("00:30:00");
        public FormCreateShowTime(int movieID)
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
        }

        private DateTime getTimeMovie()
        {
            return Convert.ToDateTime(context.MOVIES.Find(movieID).Time);
        }

        private DateTime getTimeStart()
        {          
            return dtpShowDate.Value.Date + dtpShowTime.Value.TimeOfDay;
        }

        private DateTime getTimeEndWithTimeClean()
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
                MessageBox.Show("Đã bị trùng lịch");
        }

        private bool checkShowTime()
        {
            int roomID = Convert.ToInt32(cmbRoom.SelectedValue);
            DateTime currMinutes, setTimeStart = getTimeStart(), 
                setTimeEnd = getTimeEndWithTimeClean(), dtpDate = setTimeStart.Date;
            TimeSpan timeRemaining = setTimeEnd.TimeOfDay - setTimeStart.TimeOfDay,
                dtpTimeStart = setTimeStart.TimeOfDay,
                dtpTimeEnd = setTimeEnd.TimeOfDay,
                timeStart, timeEnd;

            var query = context.SHOWTIMES
                .Where(x => x.RoomID == roomID
                && DbFunctions.TruncateTime(x.MovieShowTime) == dtpDate)
                .ToList();

            for (int index = 0; index < query.Count; index++)
            {
                timeStart = query[index].MovieShowTime.TimeOfDay;
                timeEnd = query[index].MovieEndTime.TimeOfDay;
                if ((timeStart <= dtpTimeStart && dtpTimeStart <= timeEnd)
                    || timeStart <= dtpTimeEnd && dtpTimeEnd <= timeEnd)
                    return true;
                else
                    for (int minutes = 1; minutes <= timeRemaining.TotalMinutes; minutes++)
                    {
                        currMinutes = setTimeStart.AddMinutes(minutes);
                        if (timeStart <= currMinutes.TimeOfDay && currMinutes.TimeOfDay <= timeEnd)
                            return true;
                    }
            }
            return false;
        }

        private void saveShowTime()
        {
            SHOWTIME createST = new SHOWTIME();
            
            createST.ShowTimeID = DateTime.Now.ToString("yyyyMMddHHmmss");
            createST.MovieShowTime = parseDate(getTimeStart());
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
