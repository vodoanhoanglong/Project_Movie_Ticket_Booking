using Movie_Ticket_Booking_System.Models;
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
    public partial class FormViewFilm : Form
    {
        private ContextDB context = Program.context;
        public FormViewFilm(int movieID)
        {
            InitializeComponent();

            var movie = context.MOVIES.Find(movieID);
            lblMovieName.Text = movie.Name;
            lblDes.Text = movie.Des;
            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + movieID + ".jpg"));
            dtpShowDate.Location = new Point(lblDes.Location.X, lblDes.Location.Y + 50);
            dtpShowTime.Location = new Point(dtpShowDate.Location.X + dtpShowDate.Width + 25
                , dtpShowDate.Location.Y);
            btnConfirm.Location = new Point(dtpShowDate.Location.X, dtpShowDate.Location.Y + 80);
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //gan date time cho 2 control
            /*datePortionDateTimePicker.Value = myDate.Date;
            timePortionDateTimePicker.Value = myDate.TimeOfDay;*/

            DateTime myDate = dtpShowDate.Value.Date +
                    dtpShowTime.Value.TimeOfDay;
            MessageBox.Show(myDate.ToString("dd/MM/yyyy hh:mm:ss"));
        }
    }
}
