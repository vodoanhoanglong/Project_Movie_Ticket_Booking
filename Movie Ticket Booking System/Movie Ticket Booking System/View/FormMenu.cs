using Guna.UI2.WinForms;
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
    public partial class FormMenu : Form
    {
        private Guna2Button currBtn;
        private Panel leftBorderBtn;
        private int imgNumber = 1;

        private System.Drawing.Bitmap home = global::Movie_Ticket_Booking_System.Properties.Resources.home;
        private System.Drawing.Bitmap film = global::Movie_Ticket_Booking_System.Properties.Resources.film;
        private System.Drawing.Bitmap showtime = global::Movie_Ticket_Booking_System.Properties.Resources.showtime;
        private System.Drawing.Bitmap history = global::Movie_Ticket_Booking_System.Properties.Resources.history;

        private System.Drawing.Bitmap homeColor = global::Movie_Ticket_Booking_System.Properties.Resources.home_color;
        private System.Drawing.Bitmap filmColor = global::Movie_Ticket_Booking_System.Properties.Resources.film_color;
        private System.Drawing.Bitmap showtimeColor = global::Movie_Ticket_Booking_System.Properties.Resources.showtime_color;
        private System.Drawing.Bitmap historyColor = global::Movie_Ticket_Booking_System.Properties.Resources.history_color;

        public FormMenu()
        {
            InitializeComponent();
            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

      
        private void FormMenu_Load(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            panelMenu.Controls.Add(leftBorderBtn);
            loadThumb();
        }

        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (Guna2Button)senderBtn;

                setColorImage(currBtn.Name);
                currBtn.ForeColor = color;

                leftBorderBtn.BackColor = Color.Red;
                leftBorderBtn.Location = new Point(currBtn.Size.Width - 5, currBtn.Location.Y);
                leftBorderBtn.Size = new Size(5, 45);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if (currBtn != null)
            {
                setColorImage(currBtn.Name);
                currBtn.ForeColor = Color.FromArgb(113, 114, 124);
            }
        }

        private void setColorImage(string name)
        {
            bool checkColor = currBtn.ForeColor.ToArgb().Equals(Color.FromArgb(113, 114, 124).ToArgb());
            switch (name)
            {
                case "btnHome":
                    currBtn.Image = checkColor ? homeColor : home;
                    break;
                case "btnFilm":
                    currBtn.Image = checkColor ? filmColor : film;
                    break;
                case "btnShowTime":
                    currBtn.Image = checkColor ? showtimeColor : showtime;
                    break;
                default:
                    currBtn.Image = checkColor ? historyColor : history;
                    break;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
        }

        private void btnShowTime_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            loadImgs();
        }

        private void resetThumb()
        {
            thumb1.FillColor = Color.FromArgb(25, 26, 31);
            thumb2.FillColor = Color.FromArgb(25, 26, 31);
            thumb3.FillColor = Color.FromArgb(25, 26, 31);
        }
        private void loadThumb()
        {
            resetThumb();
            if (imgNumber == 1)
                thumb1.FillColor = Color.White;
            else if (imgNumber == 2)
                thumb2.FillColor = Color.White;
            else
                thumb3.FillColor = Color.White;
        }

        private void loadImgs()
        {
            timerSlider.Start();
            if (imgNumber > 3)
                imgNumber = 1;
            loadThumb();
            pcbCarousel.ImageLocation = string.Format(@"D:\SQL Project\Movie Ticket Booking System\Movie Ticket Booking System\ImgSlider\" + imgNumber + ".jpg");
            imgNumber++;
        }
    }
}
