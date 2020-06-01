using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemyWizyjne
{
    public partial class VisionSystems : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        public static int User_control_flag = 0;


        public void Changing_window()
        {
            if (User_control_flag == 0)
            {
                var Systems_main = new SystemsMainView();

                if (!panel_main.Contains(Systems_main.Instance))
                {
                    panel_main.Controls.Add(Systems_main.Instance);
                    Systems_main.Instance.Dock = DockStyle.Fill;
                    Systems_main.Instance.BringToFront();
                }
                else
                {
                    Systems_main.Instance.BringToFront();
                }

                /*button_home.Visible = true;
                button_sign_up.Visible = false;
                button_sig_in.Visible = true;*/
            }
            else if (User_control_flag == 1)
            {
                var ToneOfImage_user = new ToneOfImage();
                if (!panel_main.Contains(ToneOfImage_user.Instance))
                {
                    panel_main.Controls.Add(ToneOfImage_user.Instance);
                    ToneOfImage_user.Instance.Dock = DockStyle.Fill;
                    ToneOfImage_user.Instance.BringToFront();
                }
                else
                {
                    ToneOfImage_user.Instance.BringToFront();
                }
                /*button_home.Visible = false;
                button_sign_up.Visible = false;
                button_sig_in.Visible = false;*/
            }
            else if (User_control_flag == 2)
            {
                var BlackWhite_user = new BlackWhite();
                if (!panel_main.Contains(BlackWhite_user.Instance))
                {
                    panel_main.Controls.Add(BlackWhite_user.Instance);
                    BlackWhite_user.Instance.Dock = DockStyle.Fill;
                    BlackWhite_user.Instance.BringToFront();
                }
                else
                {
                    BlackWhite_user.Instance.BringToFront();
                }
                /*button_home.Visible = false;
                button_sign_up.Visible = false;
                button_sig_in.Visible = false;*/
            }
            else if (User_control_flag == 3)
            {
                var Negativ_user = new Negative();
                if (!panel_main.Contains(Negativ_user.Instance))
                {
                    panel_main.Controls.Add(Negativ_user.Instance);
                    Negativ_user.Instance.Dock = DockStyle.Fill;
                    Negativ_user.Instance.BringToFront();
                }
                else
                {
                    Negativ_user.Instance.BringToFront();
                }
                /*button_home.Visible = true;
                button_sign_up.Visible = false;
                button_sig_in.Visible = true;*/
            }
            else if (User_control_flag == 4)
            {
                var Mirror_user = new Mirror();
                if (!panel_main.Contains(Mirror_user.Instance))
                {
                    panel_main.Controls.Add(Mirror_user.Instance);
                    Mirror_user.Instance.Dock = DockStyle.Fill;
                    Mirror_user.Instance.BringToFront();
                }
                else
                {
                    Mirror_user.Instance.BringToFront();
                }
                /*button_home.Visible = false;
                button_sign_up.Visible = false;
                button_sig_in.Visible = false;*/
            }
            else if (User_control_flag == 5)
            {
                var Sepia_user = new Sepia();
                if (!panel_main.Contains(Sepia_user.Instance))
                {
                    panel_main.Controls.Add(Sepia_user.Instance);
                    Sepia_user.Instance.Dock = DockStyle.Fill;
                    Sepia_user.Instance.BringToFront();
                }
                else
                {
                    Sepia_user.Instance.BringToFront();
                }
            }
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            User_control_flag = 0;
            Changing_window();
        }

        private void button_tone_Click(object sender, EventArgs e)
        {
            User_control_flag = 1;
            Changing_window();
        }

        private void button_black_white_Click(object sender, EventArgs e)
        {
            User_control_flag = 2;
            Changing_window();
        }

        private void button_negative_Click(object sender, EventArgs e)
        {
            User_control_flag = 3;
            Changing_window();
        }

        private void button_mirror_Click(object sender, EventArgs e)
        {
            User_control_flag = 4;
            Changing_window();
        }

        private void buttons_sepia_Click(object sender, EventArgs e)
        {
            User_control_flag = 5;
            Changing_window();
        }


        public VisionSystems()
        {
            InitializeComponent();
            panel_menu_up.Refresh();
            button_close_app.Cursor = Cursors.Hand;
            button_minimize.Cursor = Cursors.Hand;
            button_main.Cursor = Cursors.Hand;
            button_mirror.Cursor = Cursors.Hand;
            button_tone.Cursor = Cursors.Hand;
            button_black_white.Cursor = Cursors.Hand;
            button_negative.Cursor = Cursors.Hand;
            buttons_sepia.Cursor = Cursors.Hand;
            Changing_window();
        }

        private void panel_menu_up_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel_menu_up_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(panel_menu_up.ClientRectangle,
                                                                                   Color.Bisque,
                                                                                   Color.Aquamarine,
                                                                                   90F))
            {
                e.Graphics.FillRectangle(brush, panel_menu_up.ClientRectangle);
            }
        }

        private void panel_menu_left_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(panel_menu_left.ClientRectangle,
                                                                                   Color.Bisque,
                                                                                   Color.Aquamarine,
                                                                                   90F))
            {
                e.Graphics.FillRectangle(brush, panel_menu_left.ClientRectangle);
            }
        }


        private void button_close_app_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
