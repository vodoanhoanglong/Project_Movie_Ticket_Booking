using Movie_Ticket_Booking_System.Models;
using Movie_Ticket_Booking_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.Views
{
    public partial class FormLoadingOverlay : Form
    {
        private ACCOUNT query;
        public FormLoadingOverlay(ACCOUNT query)
        {
            InitializeComponent();
            this.query = query;
        }

        private void FormLoadingOverlay_Load(object sender, EventArgs e)
        {
            progressIndicator.Location =
                new Point(this.ClientSize.Width / 2 - this.progressIndicator.Size.Width / 2,
                this.ClientSize.Height / 2 - this.progressIndicator.Size.Height / 2);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            new FormMenu(query).Show();
            this.Visible = false;
        }
    }
}
