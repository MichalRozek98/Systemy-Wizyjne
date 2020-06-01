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
    public partial class BlackWhite : UserControl
    {
        private BlackWhite _instance;

        public BlackWhite Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BlackWhite();
                return _instance;
            }
        }

        private string path = @"..\..\..\Images\picture.png";

        public BlackWhite()
        {
            InitializeComponent();
            Grayscale();
            button_change_from_path.Cursor = Cursors.Hand;
        }

        private void Grayscale()
        {
            Bitmap bitmap = new Bitmap(path);
            pictureBox_original.Image = Image.FromFile(path);

            int width = bitmap.Width;
            int height = bitmap.Height;

            Color p;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    p = bitmap.GetPixel(i, j);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int average = (r + g + b) / 3;
                    bitmap.SetPixel(i,j,Color.FromArgb(a,average,average,average));
                }
            }

            pictureBox_grayscale.Image = bitmap;
        }

        private void button_change_from_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png|Bitmaps|*.bmp|jpages|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                pictureBox_original.Image = Image.FromFile(path);
            }

            Grayscale();
        }
    }
}
