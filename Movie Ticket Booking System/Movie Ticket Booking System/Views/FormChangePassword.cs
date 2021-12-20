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

namespace Movie_Ticket_Booking_System.Views
{
    public partial class FormChangePassword : Form
    {
        private ContextDB context = Program.context;
        private ACCOUNT info;
        public FormChangePassword(ACCOUNT info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "" || txtNewPassConfirm.Text == ""
                || txtOldPass.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else if (txtOldPass.Text != info.Password)
                MessageBox.Show("Mật khẩu cũ không đúng");
            else if (!txtNewPass.Text.Equals(txtNewPassConfirm.Text))
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng");
            else
            {
                context.ACCOUNTS.Find(info.AccountID).Password = txtNewPass.Text;
                context.SaveChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công");
                this.Dispose();
            }    
        }

        private void gtsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            string show = "Hiện mật khẩu";
            string hide = "Ẩn mật khẩu";
            if (gtsShowPassword.Checked)
            {
                lblShowPass.Text = hide;
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtNewPassConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                lblShowPass.Text = show;
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtNewPassConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
