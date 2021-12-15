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
        private int movieID;
        public FormViewFilm(int movieID)
        {
            InitializeComponent();
            this.movieID = movieID;
        }

        private void FormViewFilm_Load(object sender, EventArgs e)
        {
            var movie = context.MOVIES.Find(movieID);
            lblMovieName.Text = movie.Name;
            lblDes.Text = movie.Des;
            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + movieID + ".jpg"));
            btnConfirm.Location = new Point(lblDes.Location.X, lblDes.Location.Y + 50);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            new FormShowTime(movieID).ShowDialog();
        }
    }
}
