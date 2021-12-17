using Guna.UI2.WinForms;
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
    public partial class FormChairBooking : Form
    {
        private ContextDB context = Program.context;
        private Guna2Button currSeat;
        private string showtimeID;

        public FormChairBooking(string showtimeID)
        {
            InitializeComponent();
            this.showtimeID = showtimeID;
        }

        private void FormChairBooking_Load(object sender, EventArgs e)
        {
            setRowSeat();
            loadData();
        }

        private void loadData()
        {
            var query = context.SHOWTIMES
                .FirstOrDefault(x => x.ShowTimeID == showtimeID);

            lblTotalPrice.Text += "0";
            lblChairPrice.Text += "0";
            lblPrice.Text += query.MOVIE.Price.ToString();
            ptbMovie.ImageLocation = string.Format(@"..\..\Images\Movies\" + query.MovieID + ".jpg");
            lblShowtime.Text += query.MovieShowTime.TimeOfDay + " - " + query.MovieEndTime.TimeOfDay;
            lblRoom.Text += query.ROOM.RoomName;
        }

        private void setSeat(char row, string index, int x, int y, int width = 48)
        {
            Guna2Button btnSeat = new Guna2Button();
            btnSeat.Text = index;
            btnSeat.FillColor = Color.Black;
            btnSeat.HoverState.ForeColor = Color.Black;
            btnSeat.Cursor = Cursors.Hand;
            btnSeat.BorderThickness = 2;
            btnSeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSeat.ForeColor = System.Drawing.Color.White;
            btnSeat.Location = new Point(x, y);
            btnSeat.Name = "" + row + index;
            btnSeat.Size = new Size(width, 48);
            btnSeat.Click += this.btnSeat_Click;
            this.pnlRoom.Controls.Add(btnSeat);
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            currSeat = (Guna2Button)sender;
            MessageBox.Show(currSeat.Name);
        }

        private void setRowSeat()
        {
            int titleRow = 65, rowX = 20, rowY = 120, seatX = rowX + 80, count = 1;
            for (int index = 1; index <= 10; index++)
            {
                char rowName = (char)titleRow;
                for (int columnIndex = 0; columnIndex < 8; columnIndex++)
                {
                    if (rowName == 'J')
                        break;
                    seatX += 50;
                    if (columnIndex == 2 || columnIndex == 6)
                        setSeat(rowName, count.ToString(), seatX += 50, rowY - 3);
                    else
                        setSeat(rowName, count.ToString(), seatX, rowY - 3);
                    count++;
                }
                while(rowName == 'J' && count < 80)
                {
                    if(count == 75 || count == 79)
                        setSeat(rowName, count.ToString() + " " + (++count).ToString(), seatX += 100, rowY - 3, 98);
                    else
                        setSeat(rowName, count.ToString() + " " + (++count).ToString(), seatX += 50, rowY - 3, 98);
                    seatX += 50;
                    count++;
                }
                Guna2HtmlLabel row = new Guna2HtmlLabel();
                row.Name = rowName.ToString();
                row.Text = rowName.ToString();
                row.BackColor = System.Drawing.Color.Transparent;
                row.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
                row.ForeColor = System.Drawing.Color.White;
                row.Location = new Point(rowX, rowY);
                rowY += 50;
                seatX = rowX + 80;
                this.pnlRoom.Controls.Add(row);
                titleRow++;
            }
        }
    }
}
