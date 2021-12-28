using Movie_Ticket_Booking_System.Models;
using Movie_Ticket_Booking_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.Views
{
    public partial class FormEditFilm : Form
    {
        private ContextDB context = Program.context;
        private int id;

        private string filterImg = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
        private string newImg = @"..\..\Images\Movies\";
        private string selectedFile;
        private Image img;

        public FormEditFilm(int id)
        {
            InitializeComponent();
            ptbAddImg.AllowDrop = true;
            this.id = id;
        }

        private void FormEditFilm_Load(object sender, EventArgs e)
        {
            MOVIE movie = context.MOVIES.Find(id);
            txtMovieName.Text = movie.Name;
            txtDes.Text = movie.Des;
            txtPrice.Text = movie.Price.ToString();
            txtTime.Text = movie.Time;
            cbmFilter.SelectedItem = movie.Type;
            ptbAddImg.ImageLocation = string.Format(newImg + id + ".jpg");
            selectedFile = ptbAddImg.ImageLocation;
        }

        private MOVIE findData()
        {
            return context.MOVIES.Find(id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtDes.Text.Equals("") || txtMovieName.Text.Equals("") || txtPrice.Text.Equals("")
               || txtTime.Text.Equals("00:00:00"))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else updateData();
        }

        private bool checkTrigger()
        {
            DateTime date = DateTime.Now;
            int count = context.TICKETS.Where(x => x.SHOWTIME.MovieShowTime > date
            && x.SHOWTIME.MovieID == id).Count();
            return count == 0 ? true : false;
        }

        private void updateData()
        {
            if(!checkTrigger())
            {
                MessageBox.Show("Phim đã có người đặt");
                return;
            }
            MOVIE movieUpdate = findData();
            movieUpdate.Name = txtMovieName.Text;
            movieUpdate.Des = txtDes.Text;
            movieUpdate.Price = Convert.ToDecimal(txtPrice.Text);
            movieUpdate.Time = txtTime.Text;
            movieUpdate.Type = cbmFilter.SelectedItem.ToString();

            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + id + fileExt;
            if (!resultFileCopy.Equals(selectedFile))
                System.IO.File.Copy(selectedFile, resultFileCopy, true);  

            context.SaveChanges();
            MessageBox.Show("Cập nhật thành công");
            this.Dispose();
            FormMenu.instance.openChildForm(new FormMovieStore());
        }

        private void ptbAddImg_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                selectedFile = pic;
                img = Image.FromFile(pic);
                ptbAddImg.Image = img;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMenu.instance.openChildForm(new FormMovieStore());
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = filterImg;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ptbAddImg.Image = new Bitmap(dlg.FileName);
                    selectedFile = dlg.FileName;
                }
            }
        }

        private void ptbAddImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
