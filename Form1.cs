using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramowanieWizualneLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            image.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz obraz";
                openFileDialog.Filter = "Pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp|Wszystkie pliki|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            if(image.Image != null) 
            {
                Bitmap bitmap = new Bitmap(image.Image);

                if (dziewiec.Checked)
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    image.Image = bitmap;
                } else if (osiemnascie.Checked)
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    image.Image = bitmap;
                } else if (dwadziescia_siedem.Checked) 
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    image.Image = bitmap;
                } else
                {
                    MessageBox.Show("Wybierz ilosc stopni!", "Blad!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            } else
            {
                MessageBox.Show("Brak obrazka!", "Blad!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void invert_Click(object sender, EventArgs e)
        {

        }
    }
}
