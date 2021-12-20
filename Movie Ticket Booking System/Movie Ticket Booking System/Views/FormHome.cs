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
    public partial class FormHome : Form
    {
        private ContextDB context = Program.context;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            /*var query = context.MOVIES.Find(5);
            this.BackgroundImage = Image.FromFile(
                string.Format(@"..\..\Images\Movies\"
                + query.MovieID + ".jpg"));
            this.lblMovieName.Text = query.Name;
            this.lblTime.Text = query.Time;
            this.lblDes.Text = query.Des;

            this.ptbMovie1.ImageLocation = string.Format(@"..\..\Images\Movies\"
                + 6 + ".jpg");
            this.ptbMovie2.ImageLocation = string.Format(@"..\..\Images\Movies\"
                + 7 + ".jpg");*/
        }
    }
}
