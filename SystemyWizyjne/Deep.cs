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
    public partial class Deep : UserControl
    {
        private Deep _instance;

        public Deep Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Deep();
                return _instance;
            }
        }

        public Deep()
        {
            InitializeComponent();
        }

        private void panel_alibaba_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
