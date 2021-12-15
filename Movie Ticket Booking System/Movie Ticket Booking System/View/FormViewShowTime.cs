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
            DateTime date = DateTime.Now.AddDays(1).Date;
            int height = 100, width = 50;
            var query = context.SHOWTIMES
                .Where(x => DbFunctions.TruncateTime(x.MovieShowTime) == date)
                .OrderBy(x => x.RoomID)
                .ToList();
            query.ForEach(x => 
            {
                setPicture(x.MovieID, width, height, x.MOVIE.Name);
                height += 500;
            });
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
/*            setLabel(id, title, picture);*/
        }
    }
}
