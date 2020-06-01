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

        public Negative()
        {
            InitializeComponent();
        }

        private void panel_alibaba_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
