
namespace Movie_Ticket_Booking_System.View
{
    partial class FormMovieStore
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
            this.lblFilter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(12, 12);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(105, 39);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Thể loại";
            this.lblFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbmFilter
            // 
            this.cbmFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbmFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.cbmFilter.BorderRadius = 15;
            this.cbmFilter.BorderThickness = 2;
            this.cbmFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbmFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFilter.FillColor = System.Drawing.Color.Transparent;
            this.cbmFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmFilter.FocusedState.Parent = this.cbmFilter;
            this.cbmFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbmFilter.ForeColor = System.Drawing.Color.White;
            this.cbmFilter.HoverState.Parent = this.cbmFilter;
            this.cbmFilter.ItemHeight = 30;
            this.cbmFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Hành động",
            "Viễn tưởng",
            "Tình cảm",
            "Kinh dị",
            "Phiêu lưu",
            "Hoạt hình",
            "Khiêu dâm"});
            this.cbmFilter.ItemsAppearance.BackColor = System.Drawing.Color.Black;
            this.cbmFilter.ItemsAppearance.Parent = this.cbmFilter;
            this.cbmFilter.Location = new System.Drawing.Point(143, 15);
            this.cbmFilter.Name = "cbmFilter";
            this.cbmFilter.ShadowDecoration.Parent = this.cbmFilter;
            this.cbmFilter.Size = new System.Drawing.Size(250, 36);
            this.cbmFilter.TabIndex = 3;
            this.cbmFilter.TextOffset = new System.Drawing.Point(5, 0);
            this.cbmFilter.SelectionChangeCommitted += new System.EventHandler(this.cbmFilter_SelectionChangeCommitted);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(4, 57);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.ShadowDecoration.Parent = this.pnlContainer;
            this.pnlContainer.Size = new System.Drawing.Size(1211, 648);
            this.pnlContainer.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.Transparent;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(434, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm phim";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(362, 36);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // FormMovieStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1217, 717);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.cbmFilter);
            this.Controls.Add(this.lblFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovieStore";
            this.Text = "FormMovieStore";
            this.Load += new System.EventHandler(this.FormMovieStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbmFilter;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}