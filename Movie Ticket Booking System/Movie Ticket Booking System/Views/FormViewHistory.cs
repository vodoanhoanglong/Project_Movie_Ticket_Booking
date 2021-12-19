﻿using Guna.UI2.WinForms;
using Movie_Ticket_Booking_System.Models;
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
    public partial class FormViewHistory : Form
    {
        private ContextDB context = Program.context;
        private Guna2ShadowPanel pnlHistory, currPnl;
        private Guna2PictureBox ptbMovie;
        private Guna2HtmlLabel lblInfo;
        public static FormViewHistory instance;
        public FormViewHistory()
        {
            InitializeComponent();
            instance = this;
        }

        private void FormViewHistory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            pnlContainer.Controls.Clear();
            int containerX = 15, containerY = 15, labelX = 185, labelY = 25;
            string accountID = FormMenu.instance.info.AccountID;
            var query = context.TICKETS
                .Where(x => x.AccountID == accountID)
                .Join(context.MOVIES,
                    ticket => ticket.MovieID,
                    movie => movie.MovieID,
                    (ticket, movie) => new
                    {
                        movie.MovieID,
                        movie.Name,
                        movie.Time,
                        movie.Price,
                        ticket.BookingDate,
                        ticket.SHOWTIME.MovieShowTime,
                        ticket.TotalPrice,
                        ticket.RoomID,
                    })
                .GroupBy(x => x.BookingDate)
                .Select(x => new
                {                   
                    BookingDate = x.Key,
                    SeatQuantity = x.Count(),
                    Info  = x.ToList()
                })
                .ToList();

            query.ForEach(x =>
            {
                var info = x.Info[0];
                string id = x.BookingDate.ToString("yyyyMMddHHmmss");
                string roomName = context.ROOMS.Find(info.RoomID).RoomName;
                string timeStart = info.MovieShowTime.ToString("dd/MM/yyy HH:mm:ss");

                setPanelHistory(id, containerX, containerY);
                setPictureMovie(info.MovieID);

                setLabel("moiveName" + id, "Tên phim: " + info.Name, labelX, labelY);
                setLabel("movieTime" + id, "Thời lượng: " + info.Time, labelX, labelY += 50);
                setLabel("moviePrice" + id, "Giá phim: " + info.Price, labelX, labelY += 50);

                setLabel("roomName" + id, "Phòng: " + roomName, labelX += 300, labelY = 75);
                setLabel("timeStart" + id, "Lịch chiếu: " + timeStart, labelX, labelY += 50);

                setLabel("seatQuantity" + id, "Số chỗ đã đặt: " + x.SeatQuantity, labelX += 400, labelY = 75);
                setLabel("totalPrice" + id, "Tổng tiền: " + info.TotalPrice, labelX, labelY += 50);

                labelX = 185;
                labelY = 25;
                containerY += 200;
            });
        }

        private void setPanelHistory(string id, int x, int y)
        {
            pnlHistory = new Guna2ShadowPanel();
            pnlHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlHistory.FillColor = System.Drawing.Color
                .FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            pnlHistory.Location = new System.Drawing.Point(x, y);
            pnlHistory.Name = id;
            pnlHistory.Radius = 10;
            pnlHistory.ShadowColor = System.Drawing.Color.Silver;
            pnlHistory.Size = new System.Drawing.Size(1178, 173);
            pnlHistory.Click += this.pnlHistory_Click;
            this.pnlContainer.Controls.Add(pnlHistory);
        }

        private void pnlHistory_Click(object sender, EventArgs e)
        {
            currPnl = (Guna2ShadowPanel)sender;
            new FormViewTicketDetail(currPnl.Name).ShowDialog();
        }

        private void setPictureMovie(int movieID)
        {
            ptbMovie = new Guna2PictureBox();
            ptbMovie.ImageLocation = string.Format(@"..\..\Images\Movies\" + movieID + ".jpg");
            ptbMovie.BorderRadius = 10;
            ptbMovie.ImageRotate = 0F;
            ptbMovie.Location = new System.Drawing.Point(20, 20);
            ptbMovie.Name = "ptbMovie" + movieID;
            ptbMovie.ShadowDecoration.Parent = this.ptbMovie;
            ptbMovie.Size = new System.Drawing.Size(124, 137);
            ptbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlHistory.Controls.Add(ptbMovie);
        }

        private void setLabel(string id, string label, int x, int y)
        {
            lblInfo = new Guna2HtmlLabel();
            lblInfo.BackColor = System.Drawing.Color.Transparent;
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblInfo.ForeColor = System.Drawing.Color.White;
            lblInfo.Location = new System.Drawing.Point(x, y);
            lblInfo.Name = id;
            lblInfo.Size = new System.Drawing.Size(88, 30);
            lblInfo.Text = label;
            this.pnlHistory.Controls.Add(lblInfo);
        }
    }
}