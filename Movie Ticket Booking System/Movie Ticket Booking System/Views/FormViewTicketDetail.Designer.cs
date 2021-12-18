
namespace Movie_Ticket_Booking_System.View
{
    partial class FormViewTicketDetail
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
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelOverlay = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalPriceSeat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancelTicket = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblBookingDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDisountPercent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSeat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblShowTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 15;
            this.Elipse.TargetControl = this;
            // 
            // panelOverlay
            // 
            this.panelOverlay.BackColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Controls.Add(this.lblTotalPriceSeat);
            this.panelOverlay.Controls.Add(this.lblTitle);
            this.panelOverlay.Controls.Add(this.btnCancelTicket);
            this.panelOverlay.Controls.Add(this.btnExport);
            this.panelOverlay.Controls.Add(this.lblBookingDate);
            this.panelOverlay.Controls.Add(this.lblTotalPrice);
            this.panelOverlay.Controls.Add(this.lblDisountPercent);
            this.panelOverlay.Controls.Add(this.lblSeat);
            this.panelOverlay.Controls.Add(this.lblRoom);
            this.panelOverlay.Controls.Add(this.lblShowTime);
            this.panelOverlay.Controls.Add(this.lblTime);
            this.panelOverlay.Controls.Add(this.lblPrice);
            this.panelOverlay.Controls.Add(this.lblName);
            this.panelOverlay.Controls.Add(this.guna2ControlBox1);
            this.panelOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOverlay.FillColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Radius = 20;
            this.panelOverlay.ShadowColor = System.Drawing.Color.Black;
            this.panelOverlay.ShadowDepth = 150;
            this.panelOverlay.Size = new System.Drawing.Size(600, 700);
            this.panelOverlay.TabIndex = 1;
            // 
            // lblTotalPriceSeat
            // 
            this.lblTotalPriceSeat.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPriceSeat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceSeat.ForeColor = System.Drawing.Color.White;
            this.lblTotalPriceSeat.Location = new System.Drawing.Point(13, 385);
            this.lblTotalPriceSeat.Name = "lblTotalPriceSeat";
            this.lblTotalPriceSeat.Size = new System.Drawing.Size(139, 32);
            this.lblTotalPriceSeat.TabIndex = 37;
            this.lblTotalPriceSeat.Text = "Tổng giá ghế: ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(224, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 32);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Chi tiết vé";
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Animated = true;
            this.btnCancelTicket.BorderRadius = 20;
            this.btnCancelTicket.CheckedState.Parent = this.btnCancelTicket;
            this.btnCancelTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTicket.CustomImages.Parent = this.btnCancelTicket;
            this.btnCancelTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelTicket.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelTicket.DisabledState.Parent = this.btnCancelTicket;
            this.btnCancelTicket.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelTicket.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnCancelTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.ForeColor = System.Drawing.Color.White;
            this.btnCancelTicket.HoverState.Parent = this.btnCancelTicket;
            this.btnCancelTicket.Location = new System.Drawing.Point(280, 621);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.ShadowDecoration.Parent = this.btnCancelTicket;
            this.btnCancelTicket.Size = new System.Drawing.Size(135, 45);
            this.btnCancelTicket.TabIndex = 35;
            this.btnCancelTicket.Text = "Hủy vé";
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.BorderRadius = 20;
            this.btnExport.CheckedState.Parent = this.btnExport;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.CustomImages.Parent = this.btnExport;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.DisabledState.Parent = this.btnExport;
            this.btnExport.FillColor = System.Drawing.Color.Transparent;
            this.btnExport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.HoverState.Parent = this.btnExport;
            this.btnExport.Location = new System.Drawing.Point(444, 621);
            this.btnExport.Name = "btnExport";
            this.btnExport.ShadowDecoration.Parent = this.btnExport;
            this.btnExport.Size = new System.Drawing.Size(135, 45);
            this.btnExport.TabIndex = 34;
            this.btnExport.Text = "Xuất hóa đơn";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBookingDate.ForeColor = System.Drawing.Color.White;
            this.lblBookingDate.Location = new System.Drawing.Point(12, 437);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(99, 32);
            this.lblBookingDate.TabIndex = 33;
            this.lblBookingDate.Text = "Ngày đặt: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 543);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(115, 32);
            this.lblTotalPrice.TabIndex = 32;
            this.lblTotalPrice.Text = "Thành tiền: ";
            // 
            // lblDisountPercent
            // 
            this.lblDisountPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblDisountPercent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDisountPercent.ForeColor = System.Drawing.Color.White;
            this.lblDisountPercent.Location = new System.Drawing.Point(12, 489);
            this.lblDisountPercent.Name = "lblDisountPercent";
            this.lblDisountPercent.Size = new System.Drawing.Size(130, 32);
            this.lblDisountPercent.TabIndex = 31;
            this.lblDisountPercent.Text = "Giảm giá(%): ";
            // 
            // lblSeat
            // 
            this.lblSeat.BackColor = System.Drawing.Color.Transparent;
            this.lblSeat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSeat.ForeColor = System.Drawing.Color.White;
            this.lblSeat.Location = new System.Drawing.Point(12, 333);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(48, 32);
            this.lblSeat.TabIndex = 30;
            this.lblSeat.Text = "Ghế: ";
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(12, 222);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(74, 32);
            this.lblRoom.TabIndex = 29;
            this.lblRoom.Text = "Phòng: ";
            // 
            // lblShowTime
            // 
            this.lblShowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblShowTime.ForeColor = System.Drawing.Color.White;
            this.lblShowTime.Location = new System.Drawing.Point(12, 278);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(112, 32);
            this.lblShowTime.TabIndex = 28;
            this.lblShowTime.Text = "Suất chiếu: ";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 158);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 32);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Thời lượng: ";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(304, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 32);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Giá phim: ";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 32);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Tên phim: ";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(568, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 25);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // FormViewTicketDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.panelOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewTicketDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormViewTicketDetail";
            this.Load += new System.EventHandler(this.FormViewTicketDetail_Load);
            this.panelOverlay.ResumeLayout(false);
            this.panelOverlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelOverlay;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBookingDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDisountPercent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSeat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShowTime;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelTicket;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalPriceSeat;
    }
}