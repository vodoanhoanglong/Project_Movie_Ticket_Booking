using Guna.UI2.WinForms;
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

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormViewShowTime : Form
    {
        private ContextDB context = Program.context;
        private Size sizePic = new Size(350, 450);
        private Guna2Button currBtnShowtime;
        private Guna2GradientButton currBtnDate;
        private DateTime date = DateTime.Now.Date;
        private string today, tomorrow, afterTomorrow;
        public FormViewShowTime()
        {
            InitializeComponent();
            today = date.ToString("dd/MM/yyyy");
            tomorrow = date.AddDays(1).ToString("dd/MM/yyyy");
            afterTomorrow = date.AddDays(2).ToString("dd/MM/yyyy");
        }

        private void FormViewShowTime_Load(object sender, EventArgs e)
        {          
            btnToday.Text = today;
            btnTomorrow.Text = tomorrow;
            btnAfterTomorrow.Text = afterTomorrow;

            btnToday.Checked = true;
            this.changeDate_Click(btnToday, e);
        }

        private void loadData(DateTime date)
        {
            int height = 100, width = 50, withLabel = 300;
            var query = context.SHOWTIMES
                .Where(x => DbFunctions.TruncateTime(x.MovieShowTime) == date)
                .ToList();

            foreach (SHOWTIME parent in query)
            {
                string found = "picture" + parent.MovieID;
                if (this.Controls[found] != null)
                    continue;
                setPicture(parent.MovieID, width, height, parent.MOVIE.Name);
                query.ForEach(child => 
                {
                    if (parent.MovieID == child.MovieID)
                        btnShowtime(child.ShowTimeID.ToString(), withLabel += 180,
                            height, child.MovieShowTime.ToString("HH:mm"),
                            child.ROOM.RoomName);
                });

                withLabel = 300;
                height += 500;
            };
          
        }

        private void setPicture(int id, int width, int height, string title)
        {
            Guna2PictureBox picture = new Guna2PictureBox();
            picture.BorderRadius = 10;
            picture.ImageLocation = string.Format(@"..\..\Images\Movies\" + id + ".jpg");
            picture.ImageRotate = 0F;
            picture.Location = new System.Drawing.Point(width, height);
            picture.Name = "picture" + id;
            picture.ShadowDecoration.Parent = picture;
            picture.Size = sizePic;
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picture.TabStop = false;
            this.Controls.Add(picture);
        }

        private void btnShowtime(string id, int width, int height, string timeStart, string roomName)
        {
            Guna2Button btnShowtime = new Guna2Button();
            btnShowtime.Text = timeStart + "\nPhòng " + roomName;
            btnShowtime.FillColor = Color.Black;
            btnShowtime.HoverState.ForeColor = Color.FromArgb(229, 9, 20);
            btnShowtime.Cursor = Cursors.Hand;
            btnShowtime.BorderRadius = 20;
            btnShowtime.BorderThickness = 2;
            btnShowtime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            btnShowtime.ForeColor = System.Drawing.Color.White;
            btnShowtime.Location = new Point(width, height);
            btnShowtime.Name = id;
            btnShowtime.Size = new Size(130, 65);
            btnShowtime.Click += this.btnShowtime_Click;
            this.Controls.Add(btnShowtime);
        }

        private void btnShowtime_Click(object sender, EventArgs e)
        {
            currBtnShowtime = (Guna2Button)sender;
            string showtimeID = currBtnShowtime.Name;
            FormMenu.instance.openChildForm(new FormChairBooking(showtimeID));       
        }

        private void disabledChecked()
        {
            if (currBtnDate != null)
                currBtnDate.Checked = false;
        }

        private void changeDate_Click(object sender, EventArgs e)
        {
            disabledChecked();
            currBtnDate = (Guna2GradientButton)sender;
            currBtnDate.Checked = true;
            if (currBtnDate.Text == today)
                loadData(date);
            else if (currBtnDate.Text == tomorrow)
                loadData(date.AddDays(1));
            else loadData(date.AddDays(2));
        }
    }
}
