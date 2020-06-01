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
    public partial class Sepia : UserControl
    {
        private Sepia _instance;

        public Sepia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Sepia();
                return _instance;
            }
        }

        public Sepia()
        {
            InitializeComponent();
        }
    }
}
