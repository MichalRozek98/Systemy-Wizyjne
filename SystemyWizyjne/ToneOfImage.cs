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
using System.Net.Http;
using System.IO;
using System.Net;

namespace SystemyWizyjne
{
    public partial class ToneOfImage : UserControl
    {

        private ToneOfImage _instance;

        public ToneOfImage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ToneOfImage();
                return _instance;
            }
        }

        private string path = @"..\..\..\Images\picture.png";

        public ToneOfImage()
        {
            InitializeComponent();
            color_background();
            trackBar_red.Cursor = Cursors.Hand;
            trackBar_green.Cursor = Cursors.Hand;
            trackBar_blue.Cursor = Cursors.Hand;
            button_restore.Cursor = Cursors.Hand;
            trackBar_image_red.Cursor = Cursors.Hand;
            trackBar_image_green.Cursor = Cursors.Hand;
            trackBar_image_blue.Cursor = Cursors.Hand;
            button_change_from_path.Cursor = Cursors.Hand;
        }

        private void color_background()
        {
            pictureBox_image.BackColor = Color.FromArgb(255,trackBar_red.Value,trackBar_green.Value,trackBar_blue.Value);
        }

        private void trackBar_red_Scroll(object sender, EventArgs e)
        {
            color_background();
        }

        private void trackBar_green_Scroll(object sender, EventArgs e)
        {
            color_background();
        }

        private void trackBar_blue_Scroll(object sender, EventArgs e)
        {
            color_background();
        }

        private void color_image()
        {
            Bitmap bitmap = new Bitmap(pictureBox_image.Image);
            //Bitmap bitmap_help = new Bitmap(Image.FromFile("picture.png"));
            Bitmap bitmap_help = new Bitmap(Image.FromFile(path));

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color p = bitmap_help.GetPixel(i,j);
                    int a = p.A;
                    double red = ((double)trackBar_image_red.Value / 255);
                    int r = (int)(p.R * red);
                    double green = ((double)trackBar_image_green.Value / 255);
                    int g = (int)(p.G * green);
                    double blue = ((double)trackBar_image_blue.Value / 255);
                    int b = (int)(p.B * blue);

                    bitmap.SetPixel(i,j, Color.FromArgb(a, r, g, b));
                }
            }

            pictureBox_image.Image = bitmap;
        }

        private void trackBar_image_red_MouseCaptureChanged(object sender, EventArgs e)
        {
            color_image();
        }

        private void trackBar_image_green_MouseCaptureChanged(object sender, EventArgs e)
        {
            color_image();
        }

        private void trackBar_image_blue_MouseCaptureChanged(object sender, EventArgs e)
        {
            color_image();
        }

        private void button_restore_Click(object sender, EventArgs e)
        {
            //pictureBox_image.Image = Image.FromFile("picture.png");
            pictureBox_image.Image = Image.FromFile(path);
            trackBar_image_red.Value = 255;
            trackBar_image_green.Value = 255;
            trackBar_image_blue.Value = 255;
        }

        private void button_change_from_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png|Bitmaps|*.bmp|jpages|*.jpg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                pictureBox_image.Image = Image.FromFile(path);
            }
        }

        
    }
}
