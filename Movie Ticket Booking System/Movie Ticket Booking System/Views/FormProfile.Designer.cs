
namespace Movie_Ticket_Booking_System.Views
{
    partial class FormProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDiscount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 361);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 39);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Họ tên: ";
            // 
            // lblAccount
            // 
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(12, 427);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(135, 39);
            this.lblAccount.TabIndex = 39;
            this.lblAccount.Text = "Tài khoản: ";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(12, 487);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(84, 39);
            this.lblBalance.TabIndex = 40;
            this.lblBalance.Text = "Số dư: ";
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiscount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiscount.ColumnHeadersHeight = 30;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Discount,
            this.Percent,
            this.isActive});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiscount.EnableHeadersVisualStyles = false;
            this.dgvDiscount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dgvDiscount.Location = new System.Drawing.Point(12, 547);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiscount.RowHeadersVisible = false;
            this.dgvDiscount.RowTemplate.Height = 30;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(410, 150);
            this.dgvDiscount.TabIndex = 41;
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dgvDiscount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.dgvDiscount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiscount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiscount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiscount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiscount.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDiscount.ThemeStyle.ReadOnly = false;
            this.dgvDiscount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiscount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiscount.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDiscount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.dgvDiscount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Code";
            this.Discount.HeaderText = "Mã giảm giá";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Percent";
            this.Percent.HeaderText = "Mức giảm giá";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "Trạng thái";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(587, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 39);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Hồ Sơ";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Animated = true;
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.BorderRadius = 5;
            this.btnChangePass.CheckedState.Parent = this.btnChangePass;
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.CustomImages.Parent = this.btnChangePass;
            this.btnChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePass.DisabledState.Parent = this.btnChangePass;
            this.btnChangePass.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.HoverState.Parent = this.btnChangePass;
            this.btnChangePass.Location = new System.Drawing.Point(1041, 649);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ShadowDecoration.BorderRadius = 10;
            this.btnChangePass.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnChangePass.ShadowDecoration.Depth = 10;
            this.btnChangePass.ShadowDecoration.Enabled = true;
            this.btnChangePass.ShadowDecoration.Parent = this.btnChangePass;
            this.btnChangePass.Size = new System.Drawing.Size(148, 48);
            this.btnChangePass.TabIndex = 43;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 724);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvDiscount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBalance;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangePass;
    }
}