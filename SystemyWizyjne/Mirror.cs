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

        public Mirror()
        {
            InitializeComponent();
        }
    }
}
