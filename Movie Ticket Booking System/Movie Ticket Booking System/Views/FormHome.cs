using Guna.UI2.WinForms;
using Movie_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormHome : Form
    {
        private ContextDB context = Program.context;
        private Guna2PictureBox currPic;
        private int currIndex, currSlider = 1;
        private List<MOVIE> listMovie;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            listMovie = context.MOVIES.Take(3).ToList();
            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + listMovie[0].MovieID + ".jpg"));
            this.currIndex = listMovie[0].MovieID;
            this.lblMovieName.Text = listMovie[0].Name;
            this.lblTime.Text = listMovie[0].Time;
            this.lblDes.Text = listMovie[0].Des;
            setBtnLocation(this.lblDes);

            this.ptbMovie1.Name = listMovie[1].MovieID.ToString();
            this.ptbMovie1.ImageLocation = string.Format(@"..\..\Images\Movies\"
                + listMovie[1].MovieID + ".jpg");

            this.ptbMovie2.Name = listMovie[2].MovieID.ToString();
            this.ptbMovie2.ImageLocation = string.Format(@"..\..\Images\Movies\"
                 + listMovie[2].MovieID + ".jpg");

            timer.Start();
            timerProgressBar.Start();
        }


        private void loadImg()
        {
            this.BackgroundImage = Image.FromFile(currPic.ImageLocation);
            currPic.ImageLocation = string.Format(@"..\..\Images\Movies\"
                 + currIndex + ".jpg");
            currIndex = Convert.ToInt32(currPic.Name);
            currPic.Name = currPic.ImageLocation.Split('\\')[4].Split('.')[0];

            MOVIE info = this.listMovie[currIndex - 1];

            this.lblMovieName.Text = info.Name;
            this.lblTime.Text = info.Time;
            this.lblDes.Text = info.Des;

            setBtnLocation(this.lblDes);
        }

        private void setBtnLocation(Guna2HtmlLabel label)
        {
            this.btnConfirm.Location = new Point(label.Location.X,
                label.Location.Y + label.ClientSize.Height + 30);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FormMenu.instance.activateButton(FormMenu.instance.btnShowTime, Color.White);
            FormMenu.instance.openChildForm(new FormViewShowTime());
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar.Maximum = 220;
            progressBar.Value += 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            if (currSlider == 1)
                currPic = ptbMovie1;
            else currPic = ptbMovie2;
            loadImg();
            currSlider++;
            if (currSlider > 2) currSlider = 1;
        }

     
    }
}
