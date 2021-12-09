using Movie_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_System.View
{
    public partial class FormAddFilm : Form
    {
        private ContextDB context = Program.context;
        private Image img;
        private string filterImg = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
        private string newImg = @"D:\SQL Project\Movie Ticket Booking System\Movie Ticket Booking System\Images\Movies\";
        private string selectedFile;

        public FormAddFilm()
        {
            InitializeComponent();
            ptbAddImg.AllowDrop = true;
            btnChangeImg.Visible = false;
        }

        private void FormAddFilm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = filterImg;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ptbAddImg.Image = new Bitmap(dlg.FileName);
                    selectedFile = dlg.FileName;
                    btnAddFilm.Visible = false;
                    btnChangeImg.Visible = true;
                }
            }
        }

        private void ptbAddImg_DragDrop(object sender, DragEventArgs e)
        {
            foreach(string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                selectedFile = pic;
                img = Image.FromFile(pic);
                ptbAddImg.Image = img;
            }
            btnAddFilm.Visible = false;
            btnChangeImg.Visible = true;
        }

        private void ptbAddImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMovieName.Text == "" || txtDes.Text == "" || 
                txtPrice.Text == "" || txtTime.Text == "00:00:00")
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            else if(ptbAddImg.Image == null)
                MessageBox.Show("Vui lòng chọn ảnh cho phim");
            else
                addMovie();
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            ptbAddImg.Image = null;
            btnAddFilm.Visible = true;
            btnChangeImg.Visible = false;
        }

        private void addMovie()
        {
            MOVIE newMovie = new MOVIE();
            newMovie.Name = txtMovieName.Text;
            newMovie.Des = txtDes.Text;
            newMovie.Price = Convert.ToDecimal(txtPrice.Text);
            newMovie.Time = txtTime.Text;
            context.MOVIES.Add(newMovie);
            context.SaveChanges();
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + newMovie.MovieID + fileExt;
            System.IO.File.Copy(selectedFile, resultFileCopy);
            resetInput();
            MessageBox.Show("Thêm phim thành công");
        }

        private void resetInput()
        {
            txtMovieName.Text = "";
            txtDes.Text = "";
            txtPrice.Text = "";
            txtTime.Text = "00:00:00";
            btnAddFilm.Visible = true;
            btnChangeImg.Visible = false;
            ptbAddImg.Image = null;
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
