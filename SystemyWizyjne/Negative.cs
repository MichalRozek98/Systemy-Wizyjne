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

namespace SystemyWizyjne
{
    public partial class Negative : UserControl
    {
        private Negative _instance;

        public Negative Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Negative();
                return _instance;
            }
        }

        private string path;

        public Negative()
        {
            InitializeComponent();
            SetNegative();
            button_change_from_path.Cursor = Cursors.Hand;
        }

        private void SetNegative()
        {
            Bitmap bitmap = new Bitmap(pictureBox_original.Image);

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

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bitmap.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_negative.Image = bitmap;
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
            SetNegative();
        }
    }
}
