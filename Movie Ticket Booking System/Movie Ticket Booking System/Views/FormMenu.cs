﻿using Guna.UI2.WinForms;
using Movie_Ticket_Booking_System.Models;
using Movie_Ticket_Booking_System.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormMenu : Form
    {
        private Guna2Button currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm;
        public bool isAdmin;
        public ACCOUNT info;
        public static FormMenu instance;

        private System.Drawing.Bitmap home = global::Movie_Ticket_Booking_System.Properties.Resources.home;
        private System.Drawing.Bitmap film = global::Movie_Ticket_Booking_System.Properties.Resources.film;
        private System.Drawing.Bitmap showtime = global::Movie_Ticket_Booking_System.Properties.Resources.showtime;
        private System.Drawing.Bitmap history = global::Movie_Ticket_Booking_System.Properties.Resources.history;
        private System.Drawing.Bitmap addFilm = global::Movie_Ticket_Booking_System.Properties.Resources.add_film;
        private System.Drawing.Bitmap revenue = global::Movie_Ticket_Booking_System.Properties.Resources.revenue;

        private System.Drawing.Bitmap homeColor = global::Movie_Ticket_Booking_System.Properties.Resources.home_color;
        private System.Drawing.Bitmap filmColor = global::Movie_Ticket_Booking_System.Properties.Resources.film_color;
        private System.Drawing.Bitmap showtimeColor = global::Movie_Ticket_Booking_System.Properties.Resources.showtime_color;
        private System.Drawing.Bitmap historyColor = global::Movie_Ticket_Booking_System.Properties.Resources.history_color;
        private System.Drawing.Bitmap addFilmColor = global::Movie_Ticket_Booking_System.Properties.Resources.add_film_color;
        private System.Drawing.Bitmap revenueColor = global::Movie_Ticket_Booking_System.Properties.Resources.revenue_color;
        public FormMenu(ACCOUNT info = null)
        {
            InitializeComponent();
            // center screen
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            instance = this;
            this.info = info;
            //check admin account
            isAdmin = this.info.Role == "Manager" ? true : false;
            /*isAdmin = true;*/

            btnRevenue.Visible = false;
            btnAddFilm.Visible = false;
        }

      
        private void FormMenu_Load(object sender, EventArgs e)
        {
            if(isAdmin)
            {
                btnRevenue.Visible = true;
                btnAddFilm.Visible = true;
            }    

            leftBorderBtn = new Panel();
            panelMenu.Controls.Add(leftBorderBtn);
            activateButton(btnHome, Color.White);
            openChildForm(new FormHome());
        }

        public void openChildForm(Form childForm)
        {
            if (currChildForm != null)
                currChildForm.Dispose();
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (Guna2Button)senderBtn;

                setColorImage(currBtn.Name);
                currBtn.ForeColor = color;

                leftBorderBtn.BackColor = Color.Red;
                leftBorderBtn.Location = new Point(currBtn.Size.Width - 5, currBtn.Location.Y);
                leftBorderBtn.Size = new Size(5, 45);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if (currBtn != null)
            {
                setColorImage(currBtn.Name);
                currBtn.ForeColor = Color.FromArgb(113, 114, 124);
            }
        }

        private void setColorImage(string name)
        {
            bool checkColor = currBtn.ForeColor.ToArgb().Equals(Color.FromArgb(113, 114, 124).ToArgb());
            switch (name)
            {
                case "btnHome":
                    currBtn.Image = checkColor ? homeColor : home;
                    break;
                case "btnFilm":
                    currBtn.Image = checkColor ? filmColor : film;
                    break;
                case "btnShowTime":
                    currBtn.Image = checkColor ? showtimeColor : showtime;
                    break;
                case "btnAddFilm":
                    currBtn.Image = checkColor ? addFilmColor : addFilm;
                    break;
                case "btnHistory":
                    currBtn.Image = checkColor ? historyColor : history;
                    break;
                default:
                    currBtn.Image = checkColor ? revenueColor : revenue;
                    break;
            }
        }

        //user
        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
            openChildForm(new FormHome());
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
            openChildForm(new FormMovieStore());
        }

        private void btnShowTime_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
            openChildForm(new FormViewShowTime());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
            openChildForm(new FormViewHistory());
        }

        //admin
        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
            openChildForm(new FormAddFilm());
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.White);
            openChildForm(new FormRevenue());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin.instance.Visible = true;
            this.Dispose();
        }
    }
}
