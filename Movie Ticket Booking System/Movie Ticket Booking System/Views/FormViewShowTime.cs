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
            this.panelViewShowTime.Controls.Clear();
            int height = 100, width = 50, withLabel = 450, heightLabel = 100, temp = 0;
            var query = context.SHOWTIMES
                .Where(x => DbFunctions.TruncateTime(x.MovieShowTime) == date)
                .OrderBy(x => x.MovieShowTime)
                .ToList();

            foreach (SHOWTIME parent in query)
            {
                string found = "picture" + parent.MovieID;
                if (this.panelViewShowTime.Controls[found] != null)
                    continue;
                setPicture(parent.MovieID, width, height);
                query.ForEach(child => 
                {
                    if (parent.MovieID == child.MovieID)
                    {
                        btnShowtime(child.ShowTimeID.ToString(), withLabel,
                            heightLabel, child.MovieShowTime.ToString("HH:mm"),
                            child.ROOM.RoomName, child.MovieShowTime);
                        heightLabel += 95;
                        temp++;
                        if(temp == 5)
                        {
                            temp = 0;
                            heightLabel = height;
                            withLabel += 180;
                        }    
                    }    
                });

                temp = 0;
                height += 500;
                heightLabel = height;
            };
          
        }

        private void setPicture(int id, int width, int height)
        {
            Guna2PictureBox picture = new Guna2PictureBox();
            picture.BorderRadius = 5;
            picture.ImageLocation = string.Format(@"..\..\Images\Movies\" + id + ".jpg");
            picture.ImageRotate = 0F;
            picture.Location = new System.Drawing.Point(width, height);
            picture.Name = "picture" + id;
            picture.ShadowDecoration.Parent = picture;
            picture.Size = sizePic;
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picture.TabStop = false;
            picture.ShadowDecoration.BorderRadius = 10;
            picture.ShadowDecoration.Color = Color.FromArgb(229, 9, 20);
            picture.ShadowDecoration.Depth = 10;
            picture.ShadowDecoration.Enabled = true;
            this.panelViewShowTime.Controls.Add(picture);
        }

        private void btnShowtime(string id, int width, int height, 
            string timeStart, string roomName, DateTime dateStart)
        {
            Guna2Button btnShowtime = new Guna2Button();
            btnShowtime.Text = timeStart + "\nPhòng " + roomName;
            btnShowtime.FillColor = Color.Black;
            btnShowtime.HoverState.ForeColor = Color.FromArgb(229, 9, 20);
            btnShowtime.Cursor = Cursors.Hand;
            btnShowtime.BorderRadius = 5;
            btnShowtime.BorderThickness = 0;
            btnShowtime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            btnShowtime.ForeColor = System.Drawing.Color.White;
            btnShowtime.Location = new Point(width, height);
            btnShowtime.Name = id;
            btnShowtime.Size = new Size(130, 65);
            btnShowtime.ShadowDecoration.BorderRadius = 10;
            btnShowtime.ShadowDecoration.Color = Color.FromArgb(229, 9, 20);
            btnShowtime.ShadowDecoration.Depth = 10;
            btnShowtime.ShadowDecoration.Enabled = true;
            btnShowtime.Click += delegate (object sender, EventArgs e) 
            { this.btnShowtime_Click(sender, e, dateStart); };
            this.panelViewShowTime.Controls.Add(btnShowtime);
        }

        private void btnShowtime_Click(object sender, EventArgs e, DateTime date)
        {
            currBtnShowtime = (Guna2Button)sender;
            string showtimeID = currBtnShowtime.Name;

            if(date.AddMinutes(-5) < DateTime.Now)
            {
                MessageBox.Show("Phim đã chiếu");
                return;
            }    
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
