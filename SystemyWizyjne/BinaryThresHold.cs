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
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace SystemyWizyjne
{
    public partial class BinaryThresHold : UserControl
    {
        private BinaryThresHold _instance;

        public BinaryThresHold Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BinaryThresHold();
                return _instance;
            }
        }

        private string path;

        public BinaryThresHold()
        {
            InitializeComponent();
            button_add_picture.Cursor = Cursors.Hand;
            trackBar_binary.Cursor = Cursors.Hand;
            pictureBox_binary.Image = null;
            trackBar_binary.Value = 10;

            Bitmap bitmap = new Bitmap(pictureBox_original.Image);
            IFilter threshold = new Threshold(trackBar_binary.Value);
            bitmap = Grayscale.CommonAlgorithms.RMY.Apply(bitmap);
            bitmap = threshold.Apply(bitmap);
            pictureBox_binary.Image = bitmap;
        }

        private void button_add_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png|Bitmaps|*.bmp|jpages|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                pictureBox_original.Image = System.Drawing.Image.FromFile(path);
                pictureBox_binary.Image = null;
                trackBar_binary.Value = 10;

                Bitmap bitmap = new Bitmap(pictureBox_original.Image);
                IFilter threshold = new Threshold(trackBar_binary.Value);
                bitmap = Grayscale.CommonAlgorithms.RMY.Apply(bitmap);
                bitmap = threshold.Apply(bitmap);
                pictureBox_binary.Image = bitmap;
            }
        }

        private void trackBar_binary_Scroll(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox_original.Image);
                IFilter threshold = new Threshold(trackBar_binary.Value);
                bitmap = Grayscale.CommonAlgorithms.RMY.Apply(bitmap);
                bitmap = threshold.Apply(bitmap);
                pictureBox_binary.Image = bitmap;
            }
            catch
            {
               MessageBox.Show("Brak oryginalnego obrazu.", "Information");
            }
        }
    }
}
