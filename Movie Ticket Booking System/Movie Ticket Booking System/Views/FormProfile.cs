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
    public partial class FormProfile : Form
    {
        private ContextDB context = Program.context;
        private ACCOUNT info;
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Movie_Ticket_Booking_System.Properties.Resources.dark_super_man;
            loadData();
        }

        private void loadData()
        {
            info = FormMenu.instance.info;
            this.lblName.Text += info.FullName;
            this.lblAccount.Text += info.AccountID;
            this.lblBalance.Text += info.Balance + " VNĐ";
            var query = context.DISCOUNTS
                .Where(x => x.AccountID == info.AccountID)
                .Select(x => new
                {
                    x.Code,
                    x.Percent,
                    isActive = x.isActive ? "Đã sử dụng" : "Còn hạn"
                })
                .ToList();

            dgvDiscount.DataSource = query;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            new FormChangePassword(info).ShowDialog();
        }
    }
}
