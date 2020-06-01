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

        public BlackWhite()
        {
            InitializeComponent();
        }
    }
}
