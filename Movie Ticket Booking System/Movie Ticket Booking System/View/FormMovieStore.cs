using Guna.UI2.WinForms;
using Movie_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormMovieStore : Form
    {
        private ContextDB context = Program.context;
        private Size sizePic = new Size(277, 354);
        private PictureBox overlay, currPicture;
        public FormMovieStore()
        {
            InitializeComponent();
        }
        private void FormMovieStore_Load(object sender, EventArgs e)
        {
            loadData();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void picture_MouseHover(object sender, EventArgs e)
        {
            currPicture = (PictureBox)sender;
            createOverlay();
        }
        private void createOverlay()
        {
            Image overlayImage = currPicture.Image;
            Bitmap transparentImage = new Bitmap(overlayImage.Width, overlayImage.Height);
            overlay = new PictureBox();
            overlay.Dock = DockStyle.Fill;
            overlay.BackColor = Color.Transparent;
            using (Graphics graphics = Graphics.FromImage(transparentImage))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = 0.5f;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                graphics.DrawImage(overlayImage, new Rectangle(0, 0, transparentImage.Width, transparentImage.Height)
                    , 0, 0, currPicture.Width, currPicture.Height, GraphicsUnit.Pixel, attributes);
            }
            overlay.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            overlay.Image = transparentImage;
            overlay.MouseLeave += this.overlay_MouseLeave;
            currPicture.Controls.Add(overlay);
        }
        private void overlay_MouseLeave(object sender, EventArgs e)
        {
            currPicture.Controls.Clear();
        }

        private void setPicture(int id, int width, int height, string title)
        {
            Guna2PictureBox picture = new Guna2PictureBox();
            picture.BorderRadius = 20;
            picture.ImageLocation = string.Format(@"D:\SQL Project\Movie Ticket Booking System\Movie Ticket Booking System\Images\Movies\" + id + ".jpg");
            picture.ImageRotate = 0F;
            picture.Location = new System.Drawing.Point(width, height);
            picture.Name = "picture" + id;
            picture.ShadowDecoration.Parent = picture;
            picture.Size = sizePic;
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picture.TabStop = false;
            picture.MouseHover += new System.EventHandler(this.picture_MouseHover);
            this.Controls.Add(picture);
            setLabel(id, title, picture);
        }

        private void setLabel(int id, string label, Guna2PictureBox picture)
        {
            Guna2HtmlLabel lblTitle = new Guna2HtmlLabel();
            lblTitle.Text = label;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            int locationName = picture.Location.X + (picture.ClientSize.Width / 2 - lblTitle.Size.Width / 2);
            lblTitle.Location = new Point(locationName, picture.Location.Y + 350);
            lblTitle.Name = "name" + id;
            lblTitle.MaximumSize = new Size(280, 0);
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblTitle);
        }

        private void loadData()
        {
            var query = context.MOVIES.OrderByDescending(x => x.MovieID).ToList();
            int height = 65, width = 65, count = 0;
            query.ForEach(x =>
            {
                if (count == 3)
                {
                    height += 455;
                    width = 65;
                    count = 0;
                }
                setPicture(x.MovieID, width, height, x.Name);
                width += 400;
                count++;
            });
        }
    }
}
