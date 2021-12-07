using Exam_Preparation_System;
using Movie_Ticket_Booking_System.Models;
using Movie_Ticket_Booking_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System
{
    static class Program
    {
        public static ContextDB context = new ContextDB();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }
}
