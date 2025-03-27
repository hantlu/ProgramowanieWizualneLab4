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

        private void only_green_Click(object sender, EventArgs e)
        {
            if (image.Image != null)
            {
                Bitmap bitmap = new Bitmap(image.Image);

                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++) 
                    { 
                        Color pixelColor = bitmap.GetPixel(i, j);

                        if (pixelColor.G <= pixelColor.R || pixelColor.G <= pixelColor.R)
                        {
                            bitmap.SetPixel(i, j, Color.Black);
                        }
                    }
                }
                image.Image = bitmap;
            }
            else
            {
                MessageBox.Show("Nie zaladowales zdjecia!", "Blad!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
