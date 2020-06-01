using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AukcjeApp
{
    public partial class Mirror : UserControl
    {
        private Mirror _instance;

        public Mirror Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Mirror();
                return _instance;
            }
        }

        public string path;

        public Mirror()
        {
            InitializeComponent();
            button_add_picture.Cursor = Cursors.Hand;
            button_mirror.Cursor = Cursors.Hand;
        }

        private void button_add_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png|Bitmaps|*.bmp|jpages|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                pictureBox_original.Image = Image.FromFile(path);
                pictureBox_mirror.Image = null;
            }
        }

        private void button_mirror_Click(object sender, EventArgs e)
        {
            try
            {
                int width = pictureBox_original.Image.Width;
                int height = pictureBox_original.Image.Height;
                Bitmap bitmap_original = new Bitmap(pictureBox_original.Image);

                Bitmap bitmap = new Bitmap(width * 2, height);

                for (int y = 0; y < height; y++)
                {
                    for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                    {
                        Color p = bitmap_original.GetPixel(lx, y);

                        bitmap.SetPixel(lx, y, p);
                        bitmap.SetPixel(rx, y, p);
                    }
                }

                pictureBox_mirror.Image = bitmap;
            }
            catch
            {
                MessageBox.Show("Brak oryginalnego obrazu.", "Information");
            }
        }
    }
}
