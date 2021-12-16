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
        public FormViewShowTime()
        {
            InitializeComponent();
        }

        private void FormViewShowTime_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            btnToday.Text = date.ToString("dd/MM/yyyy");
            btnTomorrow.Text = date.AddDays(1).ToString("dd/MM/yyyy");
            btnAfterTomorrow.Text = date.AddDays(2).ToString("dd/MM/yyyy");
            loadData();
        }

        private void loadData()
        {
       
            DateTime date = DateTime.Now.Date;
            int height = 100, width = 50, withLabel = 300;
            var query = context.SHOWTIMES
                .Where(x => DbFunctions.TruncateTime(x.MovieShowTime) == date)
                .ToList();

            foreach(SHOWTIME parent in query)
            {
                string found = "picture" + parent.MovieID;
                if (this.Controls[found] != null)
                    continue;
                setPicture(parent.MovieID, width, height, parent.MOVIE.Name);
                query.ForEach(child => 
                {
                    if (parent.MovieID == child.MovieID)
                        setLabel(child.ShowTimeID.ToString(), withLabel += 150,
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
            picture.Cursor = Cursors.Hand;
            picture.BorderRadius = 20;
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

        private void setLabel(string id, int width, int height, string timeStart, string roomName)
        {
            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = timeStart + "\nPhòng " + roomName;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new Point(width, height);
            lblTitle.Name = id;
            lblTitle.AutoSize = true;
            lblTitle.MaximumSize = new Size(150, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleLeft;
            this.Controls.Add(lblTitle);
        }
    }
}
