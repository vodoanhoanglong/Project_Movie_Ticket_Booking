
namespace Movie_Ticket_Booking_System.View
{
    partial class FormChairBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChairBooking));
            this.lblShowtime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlRoom = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptbScreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBooking = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDiscount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbMovie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowtime
            // 
            this.lblShowtime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowtime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblShowtime.ForeColor = System.Drawing.Color.White;
            this.lblShowtime.Location = new System.Drawing.Point(393, 10);
            this.lblShowtime.Name = "lblShowtime";
            this.lblShowtime.Size = new System.Drawing.Size(115, 32);
            this.lblShowtime.TabIndex = 0;
            this.lblShowtime.Text = "Suất Chiếu: ";
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(205, 10);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(74, 32);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "Phòng: ";
            // 
            // pnlRoom
            // 
            this.pnlRoom.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoom.Controls.Add(this.ptbScreen);
            this.pnlRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.pnlRoom.Location = new System.Drawing.Point(15, 64);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Radius = 15;
            this.pnlRoom.ShadowColor = System.Drawing.Color.Silver;
            this.pnlRoom.ShadowDepth = 200;
            this.pnlRoom.Size = new System.Drawing.Size(753, 662);
            this.pnlRoom.TabIndex = 2;
            // 
            // ptbScreen
            // 
            this.ptbScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ptbScreen.BorderRadius = 15;
            this.ptbScreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ptbScreen.Image = ((System.Drawing.Image)(resources.GetObject("ptbScreen.Image")));
            this.ptbScreen.ImageRotate = 0F;
            this.ptbScreen.Location = new System.Drawing.Point(91, 21);
            this.ptbScreen.Name = "ptbScreen";
            this.ptbScreen.ShadowDecoration.Parent = this.ptbScreen;
            this.ptbScreen.Size = new System.Drawing.Size(611, 172);
            this.ptbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbScreen.TabIndex = 1;
            this.ptbScreen.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.Animated = true;
            this.btnBooking.BorderRadius = 20;
            this.btnBooking.CheckedState.Parent = this.btnBooking;
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.CustomImages.Parent = this.btnBooking;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.DisabledState.Parent = this.btnBooking;
            this.btnBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.HoverState.Parent = this.btnBooking;
            this.btnBooking.Location = new System.Drawing.Point(1081, 681);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.ShadowDecoration.Parent = this.btnBooking;
            this.btnBooking.Size = new System.Drawing.Size(135, 45);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "Đặt ghế";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 20;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnBack.FillColor2 = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(12, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(131, 45);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCode
            // 
            this.txtCode.Animated = true;
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtCode.BorderRadius = 20;
            this.txtCode.BorderThickness = 2;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.Parent = this.txtCode;
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FillColor = System.Drawing.Color.Transparent;
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtCode.FocusedState.Parent = this.txtCode;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtCode.HoverState.Parent = this.txtCode;
            this.txtCode.Location = new System.Drawing.Point(787, 549);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "Mã giảm giá (nếu có)";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(251, 47);
            this.txtCode.TabIndex = 7;
            this.txtCode.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnVerify
            // 
            this.btnVerify.Animated = true;
            this.btnVerify.BorderRadius = 20;
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.btnVerify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerify.DisabledState.Parent = this.btnVerify;
            this.btnVerify.FillColor = System.Drawing.Color.Transparent;
            this.btnVerify.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(1081, 549);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(135, 45);
            this.btnVerify.TabIndex = 10;
            this.btnVerify.Text = "Xác thực";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(787, 653);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 30);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Giá phim: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(787, 693);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(99, 30);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Tổng tiền: ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(787, 614);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(123, 30);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "Giảm giá(%): ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::Movie_Ticket_Booking_System.Properties.Resources.film_color;
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Movie_Ticket_Booking_System.Properties.Resources.film_color;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(984, 475);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(64, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ptbMovie
            // 
            this.ptbMovie.BorderRadius = 15;
            this.ptbMovie.ImageRotate = 0F;
            this.ptbMovie.Location = new System.Drawing.Point(787, 68);
            this.ptbMovie.Name = "ptbMovie";
            this.ptbMovie.ShadowDecoration.Parent = this.ptbMovie;
            this.ptbMovie.Size = new System.Drawing.Size(429, 436);
            this.ptbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMovie.TabIndex = 8;
            this.ptbMovie.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Location = new System.Drawing.Point(15, 738);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(28, 22);
            this.guna2Panel1.TabIndex = 14;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(49, 738);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(77, 23);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Chưa chọn";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(192, 738);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 23);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Đã chọn";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Location = new System.Drawing.Point(158, 738);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(28, 22);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(315, 738);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(78, 23);
            this.guna2HtmlLabel3.TabIndex = 19;
            this.guna2HtmlLabel3.Text = "Đang chọn";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Location = new System.Drawing.Point(281, 738);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(28, 22);
            this.guna2Panel3.TabIndex = 18;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(428, 738);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(74, 23);
            this.guna2HtmlLabel4.TabIndex = 20;
            this.guna2HtmlLabel4.Text = "E, F, G: Vip";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(545, 738);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(65, 23);
            this.guna2HtmlLabel5.TabIndex = 21;
            this.guna2HtmlLabel5.Text = "J: Couple";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(644, 738);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(111, 23);
            this.guna2HtmlLabel6.TabIndex = 22;
            this.guna2HtmlLabel6.Text = "Còn lại: Normal";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(788, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 32);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Tên phim";
            // 
            // FormChairBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1239, 790);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ptbMovie);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblShowtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChairBooking";
            this.Text = "FormChairBooking";
            this.Load += new System.EventHandler(this.FormChairBooking_Load);
            this.pnlRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblShowtime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoom;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRoom;
        private Guna.UI2.WinForms.Guna2GradientButton btnBooking;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2PictureBox ptbMovie;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerify;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiscount;
        private Guna.UI2.WinForms.Guna2PictureBox ptbScreen;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
    }
}