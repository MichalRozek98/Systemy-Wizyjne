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
    public partial class SystemsMainView : UserControl
    {
        private SystemsMainView _instance;

        public SystemsMainView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SystemsMainView();
                return _instance;
            }
        }

        public SystemsMainView()
        {
            InitializeComponent();
            panel_auctions_main_view.Refresh();
        }

        private void panel_auctions_main_view_Paint(object sender, PaintEventArgs e)
        {
            /*using (LinearGradientBrush brush = new LinearGradientBrush(panel_auctions_main_view.ClientRectangle,
                                                                           Color.Gray,
                                                                           Color.SlateGray,
                                                                           90F))
            {
                e.Graphics.FillRectangle(brush, panel_auctions_main_view.ClientRectangle);
            }*/
        }
    }
}
