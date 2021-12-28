
namespace Movie_Ticket_Booking_System.Views
{
    partial class FormLoadingOverlay
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.progressIndicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // progressIndicator
            // 
            this.progressIndicator.AutoStart = true;
            this.progressIndicator.BackColor = System.Drawing.Color.Transparent;
            this.progressIndicator.Location = new System.Drawing.Point(461, 192);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressIndicator.ShadowDecoration.BorderRadius = 15;
            this.progressIndicator.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.progressIndicator.ShadowDecoration.Depth = 10;
            this.progressIndicator.ShadowDecoration.Parent = this.progressIndicator;
            this.progressIndicator.Size = new System.Drawing.Size(266, 244);
            this.progressIndicator.TabIndex = 3;
            this.progressIndicator.UseTransparentBackground = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormLoadingOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.progressIndicator);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoadingOverlay";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoadingOverlay";
            this.Load += new System.EventHandler(this.FormLoadingOverlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progressIndicator;
        private System.Windows.Forms.Timer timer;
    }
}