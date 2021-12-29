
using Movie_Ticket_Booking_System;
using Movie_Ticket_Booking_System.Models;
using Movie_Ticket_Booking_System.Properties;
using Movie_Ticket_Booking_System.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormLogin : Form
    {
        private const int percentDiscount = 10;
        private Bitmap background = Resources.background_login;
        ContextDB context = Program.context;
        public static FormLogin instance;
        public FormLogin()
        {
            InitializeComponent();
            instance = this;

            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            // center panel
            panel.Location = new Point(
                this.ClientSize.Width / 2 - panel.Size.Width / 2,
                this.ClientSize.Height / 2 - panel.Size.Height / 2);

            this.BackgroundImage = background;

            setPanelSignIn();
        }

        private void gtsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            string show = "Hiện mật khẩu";
            string hide = "Ẩn mật khẩu";
            if (gtsShowPassword.Checked)
            {
                lblShowPass.Text = hide;
                txtPassword.UseSystemPasswordChar = false;
                txtPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                lblShowPass.Text = show;
                txtPassword.UseSystemPasswordChar = true;
                txtPasswordConfirm.UseSystemPasswordChar = true;
            }

        }

        private void setPanelSignIn()
        {
            txtPassword.Location = txtPhoneNumber.Location;
            txtPhoneNumber.Location = txtFullName.Location;
            gtsShowPassword.Location = new Point(txtPassword.Location.X, txtPassword.Location.Y + 70);
            btnConfirm.Location = new Point(111, gtsShowPassword.Location.Y + 70);
            lblShowPass.Location = new Point(gtsShowPassword.Location.X + 55, gtsShowPassword.Location.Y);
            btnConfirm.Text = "Đăng nhập";
            lblSwitchPanel.Text = "Đăng ký";
            lblSwitchPanel.Location = new Point(160, btnConfirm.Location.Y + 60);
            txtFullName.Visible = false;
            txtPasswordConfirm.Visible = false;
        }

        private void setPanelSignUp()
        {
            btnConfirm.Text = "Đăng ký";
            lblSwitchPanel.Text = "Trở về";
            txtFullName.Visible = true;
            txtPasswordConfirm.Visible = true;
            txtPhoneNumber.Location = new Point(txtFullName.Location.X, txtFullName.Location.Y + 70);
            txtPassword.Location = new Point(txtPhoneNumber.Location.X, txtPhoneNumber.Location.Y + 70);
            gtsShowPassword.Location = new Point(txtPasswordConfirm.Location.X, txtPasswordConfirm.Location.Y + 70);
            btnConfirm.Location = new Point(111, gtsShowPassword.Location.Y + 40);
            lblShowPass.Location = new Point(gtsShowPassword.Location.X + 55, gtsShowPassword.Location.Y);
            lblSwitchPanel.Location = new Point(168, btnConfirm.Location.Y + 60);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool currPnl = btnConfirm.Text.Equals("Đăng ký") ? true : false;
            if (txtPhoneNumber.Text == ""
                || txtPassword.Text == "")
            { 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (currPnl && (txtFullName.Text == "" || txtPasswordConfirm.Text == ""))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else if (currPnl && txtPasswordConfirm.Text != txtPassword.Text)
                MessageBox.Show("Mật khẩu xác nhận không giống nhau");
            else if(currPnl && existAccount())
                MessageBox.Show("Số điện thoại đã tồn tại");
            else
            {
                if (currPnl)
                    saveAccount();
                else
                    checkLogin();
            }                
        }

        private void checkLogin()
        {           
            var query = context.ACCOUNTS
                .Where(x => x.AccountID == txtPhoneNumber.Text &&
                x.Password == txtPassword.Text).FirstOrDefault();
            if (query != null)
            {
                new FormLoadingOverlay(query).ShowDialog();
                this.Visible = false;
            }
            else
                MessageBox.Show("Số điện thoại hoặc mật khẩu sai");
        }

        private bool existAccount()
        {
            var result = context.ACCOUNTS.Find(txtPhoneNumber.Text);
            return result != null ? true : false;
        }

        private void saveAccount()
        {
            DISCOUNT newDiscount = new DISCOUNT();
            var accountID = new SqlParameter("@AccountID", txtPhoneNumber.Text);
            var password = new SqlParameter("@Password", txtPassword.Text);
            var fullname = new SqlParameter("@FullName", txtFullName.Text);
            context.Database.ExecuteSqlCommand("EXEC sp_SetAccountRole @AccountID , @Password , @FullName",
                accountID, password, fullname);

            newDiscount.AccountID = txtPhoneNumber.Text;
            newDiscount.Code = txtPhoneNumber.Text;
            newDiscount.Percent = percentDiscount;
            context.DISCOUNTS.Add(newDiscount);
            context.SaveChanges();
            resetInput();
            MessageBox.Show("Đăng ký thành công");
            setPanelSignIn();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void lblSwitchPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetInput();
            if (lblSwitchPanel.Text == "Trở về")
                setPanelSignIn();
            else
                setPanelSignUp();
        }

        private void resetInput()
        {
            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
            txtPassword.Text = "";
            txtPasswordConfirm.Text = "";
            gtsShowPassword.Checked = false;
        }
    }
}
