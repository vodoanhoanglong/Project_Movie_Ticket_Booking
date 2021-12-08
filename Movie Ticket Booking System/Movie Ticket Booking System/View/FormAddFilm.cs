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
    public partial class FormAddFilm : Form
    {
        private Image img;
        private string filterImg = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
        private string newImg = @"D:\SQL Project\Movie Ticket Booking System\Movie Ticket Booking System\Images\Movies\";
        private string selectedFile;
        public FormAddFilm()
        {
            InitializeComponent();
            ptbAddImg.AllowDrop = true;
        }

        private void FormAddFilm_Load(object sender, EventArgs e)
        {
            /*if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                MessageBox.Show(selectedFile);
            }*/
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
        }

        private void ptbAddImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + "1" + fileExt;
            System.IO.File.Copy(selectedFile, resultFileCopy);
        }
    }
}
