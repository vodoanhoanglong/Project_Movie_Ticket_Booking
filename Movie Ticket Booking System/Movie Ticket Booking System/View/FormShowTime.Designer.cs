
namespace Movie_Ticket_Booking_System.View
{
    partial class FormShowTime
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
            this.dtpShowDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpShowTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // dtpShowDate
            // 
            this.dtpShowDate.Animated = true;
            this.dtpShowDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpShowDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dtpShowDate.BorderRadius = 20;
            this.dtpShowDate.BorderThickness = 2;
            this.dtpShowDate.Checked = true;
            this.dtpShowDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dtpShowDate.CheckedState.FillColor = System.Drawing.Color.Black;
            this.dtpShowDate.CheckedState.Parent = this.dtpShowDate;
            this.dtpShowDate.CustomFormat = "dd/MM/yyyy";
            this.dtpShowDate.FillColor = System.Drawing.Color.Black;
            this.dtpShowDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpShowDate.ForeColor = System.Drawing.Color.White;
            this.dtpShowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShowDate.HoverState.Parent = this.dtpShowDate;
            this.dtpShowDate.Location = new System.Drawing.Point(154, 87);
            this.dtpShowDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpShowDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpShowDate.Name = "dtpShowDate";
            this.dtpShowDate.ShadowDecoration.Parent = this.dtpShowDate;
            this.dtpShowDate.Size = new System.Drawing.Size(132, 44);
            this.dtpShowDate.TabIndex = 11;
            this.dtpShowDate.Value = new System.DateTime(2021, 12, 14, 18, 25, 37, 37);
            // 
            // dtpShowTime
            // 
            this.dtpShowTime.Animated = true;
            this.dtpShowTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpShowTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dtpShowTime.BorderRadius = 20;
            this.dtpShowTime.BorderThickness = 2;
            this.dtpShowTime.Checked = true;
            this.dtpShowTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dtpShowTime.CheckedState.FillColor = System.Drawing.Color.Black;
            this.dtpShowTime.CheckedState.Parent = this.dtpShowTime;
            this.dtpShowTime.FillColor = System.Drawing.Color.Black;
            this.dtpShowTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpShowTime.ForeColor = System.Drawing.Color.White;
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShowTime.HoverState.Parent = this.dtpShowTime;
            this.dtpShowTime.Location = new System.Drawing.Point(307, 87);
            this.dtpShowTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpShowTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpShowTime.Name = "dtpShowTime";
            this.dtpShowTime.ShadowDecoration.Parent = this.dtpShowTime;
            this.dtpShowTime.ShowUpDown = true;
            this.dtpShowTime.Size = new System.Drawing.Size(132, 44);
            this.dtpShowTime.TabIndex = 10;
            this.dtpShowTime.Value = new System.DateTime(2021, 12, 15, 18, 0, 0, 0);
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 20;
            this.elipse.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(194, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 38);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Tạo lịch chiếu";
            // 
            // cmbRoom
            // 
            this.cmbRoom.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.cmbRoom.BorderRadius = 15;
            this.cmbRoom.BorderThickness = 2;
            this.cmbRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FillColor = System.Drawing.Color.Transparent;
            this.cmbRoom.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRoom.FocusedState.Parent = this.cmbRoom;
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.cmbRoom.ForeColor = System.Drawing.Color.White;
            this.cmbRoom.HoverState.Parent = this.cmbRoom;
            this.cmbRoom.ItemHeight = 30;
            this.cmbRoom.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.cmbRoom.ItemsAppearance.Parent = this.cmbRoom;
            this.cmbRoom.Location = new System.Drawing.Point(154, 178);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.ShadowDecoration.Parent = this.cmbRoom;
            this.cmbRoom.Size = new System.Drawing.Size(285, 36);
            this.cmbRoom.TabIndex = 14;
            this.cmbRoom.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(37, 175);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(86, 39);
            this.lblRoom.TabIndex = 13;
            this.lblRoom.Text = "Phòng";
            this.lblRoom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.BorderRadius = 20;
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
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(436, 236);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(146, 45);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Hoàn tất";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(556, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 25);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // FormShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtpShowDate);
            this.Controls.Add(this.dtpShowTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowTime";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormShowTime";
            this.Load += new System.EventHandler(this.FormShowTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpShowDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpShowTime;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoom;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}