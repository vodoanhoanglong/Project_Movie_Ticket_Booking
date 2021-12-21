using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Movie_Ticket_Booking_System.Report
{
    public partial class Rp_DetailTicket : DevExpress.XtraReports.UI.XtraReport
    {
        public Rp_DetailTicket()
        {
            InitializeComponent();
        }
        public void loadTicketInfo(TicketDetails ticket)
        {         
            objectDataSource1.DataSource = ticket;
        }
    }
}
