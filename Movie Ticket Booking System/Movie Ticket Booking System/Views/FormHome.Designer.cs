
namespace Movie_Ticket_Booking_System.View
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelOverlay = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ptbMovie2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbMovie1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMovieName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.panelOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOverlay
            // 
            this.panelOverlay.BackColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Controls.Add(this.progressBar);
            this.panelOverlay.Controls.Add(this.btnConfirm);
            this.panelOverlay.Controls.Add(this.ptbMovie2);
            this.panelOverlay.Controls.Add(this.ptbMovie1);
            this.panelOverlay.Controls.Add(this.lblTime);
            this.panelOverlay.Controls.Add(this.lblDes);
            this.panelOverlay.Controls.Add(this.lblMovieName);
            this.panelOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOverlay.FillColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Radius = 20;
            this.panelOverlay.ShadowColor = System.Drawing.Color.Black;
            this.panelOverlay.ShadowDepth = 150;
            this.panelOverlay.Size = new System.Drawing.Size(1233, 756);
            this.panelOverlay.TabIndex = 1;
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
            this.btnConfirm.Location = new System.Drawing.Point(40, 450);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(156, 45);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Xem ngay";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ptbMovie2
            // 
            this.ptbMovie2.BorderRadius = 10;
            this.ptbMovie2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMovie2.ImageRotate = 0F;
            this.ptbMovie2.Location = new System.Drawing.Point(943, 406);
            this.ptbMovie2.Name = "ptbMovie2";
            this.ptbMovie2.ShadowDecoration.Parent = this.ptbMovie2;
            this.ptbMovie2.Size = new System.Drawing.Size(266, 335);
            this.ptbMovie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMovie2.TabIndex = 13;
            this.ptbMovie2.TabStop = false;
            // 
            // ptbMovie1
            // 
            this.ptbMovie1.BorderRadius = 10;
            this.ptbMovie1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMovie1.ImageRotate = 0F;
            this.ptbMovie1.Location = new System.Drawing.Point(943, 25);
            this.ptbMovie1.Name = "ptbMovie1";
            this.ptbMovie1.ShadowDecoration.Parent = this.ptbMovie1;
            this.ptbMovie1.Size = new System.Drawing.Size(266, 335);
            this.ptbMovie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMovie1.TabIndex = 12;
            this.ptbMovie1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(40, 209);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 27);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Thời lượng";
            // 
            // lblDes
            // 
            this.lblDes.BackColor = System.Drawing.Color.Transparent;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDes.ForeColor = System.Drawing.Color.White;
            this.lblDes.Location = new System.Drawing.Point(40, 255);
            this.lblDes.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(400, 172);
            this.lblDes.TabIndex = 10;
            this.lblDes.Text = resources.GetString("lblDes.Text");
            // 
            // lblMovieName
            // 
            this.lblMovieName.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(40, 158);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(123, 39);
            this.lblMovieName.TabIndex = 9;
            this.lblMovieName.Text = "Tên phim";
            // 
            // timer
            // 
            this.timer.Interval = 4000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.BorderRadius = 5;
            this.progressBar.FillColor = System.Drawing.Color.Transparent;
            this.progressBar.Location = new System.Drawing.Point(943, 378);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.DarkGray;
            this.progressBar.ShadowDecoration.BorderRadius = 10;
            this.progressBar.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(266, 10);
            this.progressBar.TabIndex = 15;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 1;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 756);
            this.Controls.Add(this.panelOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelOverlay.ResumeLayout(false);
            this.panelOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panelOverlay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMovieName;
        private Guna.UI2.WinForms.Guna2PictureBox ptbMovie2;
        private Guna.UI2.WinForms.Guna2PictureBox ptbMovie1;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}