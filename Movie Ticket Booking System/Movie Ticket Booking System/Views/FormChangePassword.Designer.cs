
namespace Movie_Ticket_Booking_System.Views
{
    partial class FormChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNewPassConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShowPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gtsShowPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(161, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 39);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Thay đổi mật khẩu";
            // 
            // txtNewPassConfirm
            // 
            this.txtNewPassConfirm.Animated = true;
            this.txtNewPassConfirm.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPassConfirm.BorderRadius = 5;
            this.txtNewPassConfirm.BorderThickness = 2;
            this.txtNewPassConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassConfirm.DefaultText = "";
            this.txtNewPassConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassConfirm.DisabledState.Parent = this.txtNewPassConfirm;
            this.txtNewPassConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassConfirm.FillColor = System.Drawing.Color.Transparent;
            this.txtNewPassConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPassConfirm.FocusedState.Parent = this.txtNewPassConfirm;
            this.txtNewPassConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtNewPassConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPassConfirm.HoverState.Parent = this.txtNewPassConfirm;
            this.txtNewPassConfirm.Location = new System.Drawing.Point(121, 218);
            this.txtNewPassConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPassConfirm.Name = "txtNewPassConfirm";
            this.txtNewPassConfirm.PasswordChar = '\0';
            this.txtNewPassConfirm.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtNewPassConfirm.SelectedText = "";
            this.txtNewPassConfirm.ShadowDecoration.BorderRadius = 10;
            this.txtNewPassConfirm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPassConfirm.ShadowDecoration.Enabled = true;
            this.txtNewPassConfirm.ShadowDecoration.Parent = this.txtNewPassConfirm;
            this.txtNewPassConfirm.Size = new System.Drawing.Size(316, 47);
            this.txtNewPassConfirm.TabIndex = 17;
            this.txtNewPassConfirm.TextOffset = new System.Drawing.Point(5, 0);
            this.txtNewPassConfirm.UseSystemPasswordChar = true;
            // 
            // lblShowPass
            // 
            this.lblShowPass.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPass.ForeColor = System.Drawing.Color.Silver;
            this.lblShowPass.Location = new System.Drawing.Point(176, 298);
            this.lblShowPass.Name = "lblShowPass";
            this.lblShowPass.Size = new System.Drawing.Size(115, 23);
            this.lblShowPass.TabIndex = 16;
            this.lblShowPass.Text = "Hiện mật khẩu";
            // 
            // gtsShowPassword
            // 
            this.gtsShowPassword.Animated = true;
            this.gtsShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.gtsShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.gtsShowPassword.CheckedState.BorderRadius = 5;
            this.gtsShowPassword.CheckedState.BorderThickness = 2;
            this.gtsShowPassword.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.gtsShowPassword.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(1)))), ((int)(((byte)(68)))));
            this.gtsShowPassword.CheckedState.InnerBorderRadius = 1;
            this.gtsShowPassword.CheckedState.InnerColor = System.Drawing.Color.Black;
            this.gtsShowPassword.CheckedState.Parent = this.gtsShowPassword;
            this.gtsShowPassword.Location = new System.Drawing.Point(121, 298);
            this.gtsShowPassword.Name = "gtsShowPassword";
            this.gtsShowPassword.ShadowDecoration.BorderRadius = 10;
            this.gtsShowPassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.gtsShowPassword.ShadowDecoration.Enabled = true;
            this.gtsShowPassword.ShadowDecoration.Parent = this.gtsShowPassword;
            this.gtsShowPassword.Size = new System.Drawing.Size(49, 22);
            this.gtsShowPassword.TabIndex = 15;
            this.gtsShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.gtsShowPassword.UncheckedState.BorderRadius = 5;
            this.gtsShowPassword.UncheckedState.BorderThickness = 2;
            this.gtsShowPassword.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.gtsShowPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.gtsShowPassword.UncheckedState.InnerBorderRadius = 1;
            this.gtsShowPassword.UncheckedState.InnerColor = System.Drawing.Color.Silver;
            this.gtsShowPassword.UncheckedState.Parent = this.gtsShowPassword;
            this.gtsShowPassword.CheckedChanged += new System.EventHandler(this.gtsShowPassword_CheckedChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Animated = true;
            this.txtNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPass.BorderRadius = 5;
            this.txtNewPass.BorderThickness = 2;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FillColor = System.Drawing.Color.Transparent;
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.Location = new System.Drawing.Point(121, 151);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "Mật khẩu mới";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.BorderRadius = 10;
            this.txtNewPass.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtNewPass.ShadowDecoration.Enabled = true;
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(316, 47);
            this.txtNewPass.TabIndex = 14;
            this.txtNewPass.TextOffset = new System.Drawing.Point(5, 0);
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Animated = true;
            this.txtOldPass.BackColor = System.Drawing.Color.Transparent;
            this.txtOldPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtOldPass.BorderRadius = 5;
            this.txtOldPass.BorderThickness = 2;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.Parent = this.txtOldPass;
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.FillColor = System.Drawing.Color.Transparent;
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtOldPass.FocusedState.Parent = this.txtOldPass;
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtOldPass.HoverState.Parent = this.txtOldPass;
            this.txtOldPass.Location = new System.Drawing.Point(121, 84);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '\0';
            this.txtOldPass.PlaceholderText = "Mật khẩu cũ";
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.ShadowDecoration.BorderRadius = 10;
            this.txtOldPass.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtOldPass.ShadowDecoration.Enabled = true;
            this.txtOldPass.ShadowDecoration.Parent = this.txtOldPass;
            this.txtOldPass.Size = new System.Drawing.Size(316, 47);
            this.txtOldPass.TabIndex = 18;
            this.txtOldPass.TextOffset = new System.Drawing.Point(5, 0);
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(555, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 25);
            this.guna2ControlBox1.TabIndex = 19;
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 20;
            this.elipse.TargetControl = this;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderRadius = 5;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.DisabledState.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(194, 353);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.BorderRadius = 10;
            this.btnConfirm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnConfirm.ShadowDecoration.Depth = 10;
            this.btnConfirm.ShadowDecoration.Enabled = true;
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(146, 45);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Hoàn tất";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(588, 420);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtNewPassConfirm);
            this.Controls.Add(this.lblShowPass);
            this.Controls.Add(this.gtsShowPassword);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChangePassword";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShowPass;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gtsShowPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
    }
}