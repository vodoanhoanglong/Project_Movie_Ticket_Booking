
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
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.ptbCarousel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.thumb3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.thumb2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.thumb1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarousel)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Interval = 1;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // ptbCarousel
            // 
            this.ptbCarousel.BorderRadius = 20;
            this.ptbCarousel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ptbCarousel.ImageRotate = 0F;
            this.ptbCarousel.Location = new System.Drawing.Point(141, 35);
            this.ptbCarousel.Name = "ptbCarousel";
            this.ptbCarousel.ShadowDecoration.Parent = this.ptbCarousel;
            this.ptbCarousel.Size = new System.Drawing.Size(974, 380);
            this.ptbCarousel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCarousel.TabIndex = 0;
            this.ptbCarousel.TabStop = false;
            // 
            // thumb3
            // 
            this.thumb3.BackColor = System.Drawing.Color.Transparent;
            this.thumb3.FillColor = System.Drawing.Color.Transparent;
            this.thumb3.Location = new System.Drawing.Point(658, 401);
            this.thumb3.Name = "thumb3";
            this.thumb3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.thumb3.Size = new System.Drawing.Size(50, 8);
            this.thumb3.TabIndex = 4;
            // 
            // thumb2
            // 
            this.thumb2.BackColor = System.Drawing.Color.Transparent;
            this.thumb2.FillColor = System.Drawing.Color.Transparent;
            this.thumb2.Location = new System.Drawing.Point(602, 401);
            this.thumb2.Name = "thumb2";
            this.thumb2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.thumb2.Size = new System.Drawing.Size(50, 8);
            this.thumb2.TabIndex = 3;
            // 
            // thumb1
            // 
            this.thumb1.BackColor = System.Drawing.Color.Transparent;
            this.thumb1.FillColor = System.Drawing.Color.Transparent;
            this.thumb1.Location = new System.Drawing.Point(546, 401);
            this.thumb1.Name = "thumb1";
            this.thumb1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.thumb1.Size = new System.Drawing.Size(50, 8);
            this.thumb1.TabIndex = 2;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1233, 756);
            this.Controls.Add(this.thumb3);
            this.Controls.Add(this.thumb2);
            this.Controls.Add(this.thumb1);
            this.Controls.Add(this.ptbCarousel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarousel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSlider;
        private Guna.UI2.WinForms.Guna2PictureBox ptbCarousel;
        private Guna.UI2.WinForms.Guna2ShadowPanel thumb3;
        private Guna.UI2.WinForms.Guna2ShadowPanel thumb2;
        private Guna.UI2.WinForms.Guna2ShadowPanel thumb1;
    }
}