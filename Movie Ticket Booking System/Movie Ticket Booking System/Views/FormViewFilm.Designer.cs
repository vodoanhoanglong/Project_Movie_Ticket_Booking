
namespace Movie_Ticket_Booking_System.View
{
    partial class FormViewFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewFilm));
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelOverlay = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblDes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblMovieName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 20;
            this.elipse.TargetControl = this;
            // 
            // panelOverlay
            // 
            this.panelOverlay.BackColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Controls.Add(this.lblTime);
            this.panelOverlay.Controls.Add(this.guna2ControlBox1);
            this.panelOverlay.Controls.Add(this.lblDes);
            this.panelOverlay.Controls.Add(this.btnConfirm);
            this.panelOverlay.Controls.Add(this.lblMovieName);
            this.panelOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOverlay.FillColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.ShadowColor = System.Drawing.Color.Black;
            this.panelOverlay.Size = new System.Drawing.Size(1076, 697);
            this.panelOverlay.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(664, 239);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 27);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Thời lượng";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1044, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 25);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // lblDes
            // 
            this.lblDes.BackColor = System.Drawing.Color.Transparent;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDes.ForeColor = System.Drawing.Color.White;
            this.lblDes.Location = new System.Drawing.Point(664, 285);
            this.lblDes.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(400, 172);
            this.lblDes.TabIndex = 5;
            this.lblDes.Text = resources.GetString("lblDes.Text");
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
            this.btnConfirm.Location = new System.Drawing.Point(664, 501);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(180, 45);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Thêm lịch chiếu";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(664, 188);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(123, 39);
            this.lblMovieName.TabIndex = 2;
            this.lblMovieName.Text = "Tên phim";
            // 
            // FormViewFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 697);
            this.Controls.Add(this.panelOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormViewFilm";
            this.Load += new System.EventHandler(this.FormViewFilm_Load);
            this.panelOverlay.ResumeLayout(false);
            this.panelOverlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelOverlay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMovieName;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDes;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
    }
}