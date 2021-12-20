
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelOverlay = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMovieName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptbMovie1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbMovie2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOverlay
            // 
            this.panelOverlay.BackColor = System.Drawing.Color.Transparent;
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
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(77, 223);
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
            this.lblDes.Location = new System.Drawing.Point(77, 269);
            this.lblDes.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(500, 138);
            this.lblDes.TabIndex = 10;
            this.lblDes.Text = resources.GetString("lblDes.Text");
            // 
            // lblMovieName
            // 
            this.lblMovieName.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(77, 172);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(123, 39);
            this.lblMovieName.TabIndex = 9;
            this.lblMovieName.Text = "Tên phim";
            // 
            // ptbMovie1
            // 
            this.ptbMovie1.BorderRadius = 10;
            this.ptbMovie1.ImageRotate = 0F;
            this.ptbMovie1.Location = new System.Drawing.Point(703, 51);
            this.ptbMovie1.Name = "ptbMovie1";
            this.ptbMovie1.ShadowDecoration.Parent = this.ptbMovie1;
            this.ptbMovie1.Size = new System.Drawing.Size(290, 309);
            this.ptbMovie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMovie1.TabIndex = 12;
            this.ptbMovie1.TabStop = false;
            // 
            // ptbMovie2
            // 
            this.ptbMovie2.BorderRadius = 10;
            this.ptbMovie2.ImageRotate = 0F;
            this.ptbMovie2.Location = new System.Drawing.Point(703, 390);
            this.ptbMovie2.Name = "ptbMovie2";
            this.ptbMovie2.ShadowDecoration.Parent = this.ptbMovie2;
            this.ptbMovie2.Size = new System.Drawing.Size(290, 309);
            this.ptbMovie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMovie2.TabIndex = 13;
            this.ptbMovie2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMovie2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panelOverlay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMovieName;
        private Guna.UI2.WinForms.Guna2PictureBox ptbMovie2;
        private Guna.UI2.WinForms.Guna2PictureBox ptbMovie1;
    }
}