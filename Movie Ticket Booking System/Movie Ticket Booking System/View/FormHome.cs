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
    public partial class FormHome : Form
    {
        private int imgNumber = 1;
        private Color thumbColor = Color.FromArgb(229, 9, 20);
        private Color thumbColorDefault = Color.FromArgb(25, 26, 31);
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void resetThumb()
        {
            thumb1.ShadowColor = thumbColorDefault;
            thumb2.ShadowColor = thumbColorDefault;
            thumb3.ShadowColor = thumbColorDefault;
        }
        private void loadThumb()
        {
            resetThumb();
            if (imgNumber == 1)
            {
                thumb1.ShadowColor = thumbColor;
                thumb1.ShadowDepth = 200;
            }
            else if (imgNumber == 2)
            {
                thumb2.ShadowColor = thumbColor;
                thumb2.ShadowDepth = 200;
            }
            else
            {
                thumb3.ShadowColor = thumbColor;
                thumb3.ShadowDepth = 200;
            }
        }

        private void loadImgs()
        {
            timerSlider.Interval = 3000;
            timerSlider.Start();
            if (imgNumber > 3)
                imgNumber = 1;
            loadThumb();
            ptbCarousel.ImageLocation = string.Format(@"D:\SQL Project\Movie Ticket Booking System\Movie Ticket Booking System\Images\Sliders\" + imgNumber + ".jpg");
            imgNumber++;
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            loadImgs();
        }
    }
}
