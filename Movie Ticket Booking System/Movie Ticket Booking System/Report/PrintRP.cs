using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.Report
{
    public partial class PrintRP : XtraForm
    {
        public PrintRP()
        {
            InitializeComponent();
        }

        public void printTicket(TicketDetails ticket)
        {
            Rp_DetailTicket report = new Rp_DetailTicket();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.loadTicketInfo(ticket);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

    }

}
