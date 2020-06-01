namespace AukcjeApp
{
    partial class SystemyWizyjne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemyWizyjne));
            this.panel_menu_up = new System.Windows.Forms.Panel();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close_app = new System.Windows.Forms.Button();
            this.pictureBox_logo_icon = new System.Windows.Forms.PictureBox();
            this.panel_menu_left = new System.Windows.Forms.Panel();
            this.button_negative = new System.Windows.Forms.Button();
            this.button_mirror = new System.Windows.Forms.Button();
            this.button_black_white = new System.Windows.Forms.Button();
            this.button_tone = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_menu_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_icon)).BeginInit();
            this.panel_menu_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu_up
            // 
            this.panel_menu_up.Controls.Add(this.button_minimize);
            this.panel_menu_up.Controls.Add(this.button_close_app);
            this.panel_menu_up.Controls.Add(this.pictureBox_logo_icon);
            this.panel_menu_up.Location = new System.Drawing.Point(-1, 1);
            this.panel_menu_up.Name = "panel_menu_up";
            this.panel_menu_up.Size = new System.Drawing.Size(1081, 78);
            this.panel_menu_up.TabIndex = 0;
            this.panel_menu_up.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_up_Paint);
            this.panel_menu_up.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_menu_up_MouseMove);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Location = new System.Drawing.Point(909, 4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(68, 68);
            this.button_minimize.TabIndex = 3;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close_app
            // 
            this.button_close_app.BackColor = System.Drawing.Color.Transparent;
            this.button_close_app.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close_app.BackgroundImage")));
            this.button_close_app.FlatAppearance.BorderSize = 0;
            this.button_close_app.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_close_app.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_app.Location = new System.Drawing.Point(1004, 4);
            this.button_close_app.Name = "button_close_app";
            this.button_close_app.Size = new System.Drawing.Size(68, 68);
            this.button_close_app.TabIndex = 2;
            this.button_close_app.UseVisualStyleBackColor = false;
            this.button_close_app.Click += new System.EventHandler(this.button_close_app_Click);
            // 
            // pictureBox_logo_icon
            // 
            this.pictureBox_logo_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo_icon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo_icon.ErrorImage")));
            this.pictureBox_logo_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo_icon.Image")));
            this.pictureBox_logo_icon.Location = new System.Drawing.Point(13, 8);
            this.pictureBox_logo_icon.Name = "pictureBox_logo_icon";
            this.pictureBox_logo_icon.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_logo_icon.TabIndex = 2;
            this.pictureBox_logo_icon.TabStop = false;
            // 
            // panel_menu_left
            // 
            this.panel_menu_left.Controls.Add(this.button_negative);
            this.panel_menu_left.Controls.Add(this.button_mirror);
            this.panel_menu_left.Controls.Add(this.button_black_white);
            this.panel_menu_left.Controls.Add(this.button_tone);
            this.panel_menu_left.Controls.Add(this.button_main);
            this.panel_menu_left.Location = new System.Drawing.Point(0, 78);
            this.panel_menu_left.Name = "panel_menu_left";
            this.panel_menu_left.Size = new System.Drawing.Size(150, 642);
            this.panel_menu_left.TabIndex = 1;
            this.panel_menu_left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_left_Paint);
            // 
            // button_negative
            // 
            this.button_negative.BackColor = System.Drawing.Color.Transparent;
            this.button_negative.FlatAppearance.BorderSize = 0;
            this.button_negative.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_negative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_negative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_negative.Image = ((System.Drawing.Image)(resources.GetObject("button_negative.Image")));
            this.button_negative.Location = new System.Drawing.Point(38, 469);
            this.button_negative.Name = "button_negative";
            this.button_negative.Size = new System.Drawing.Size(64, 64);
            this.button_negative.TabIndex = 8;
            this.button_negative.UseVisualStyleBackColor = false;
            this.button_negative.Click += new System.EventHandler(this.button_negative_Click);
            // 
            // button_mirror
            // 
            this.button_mirror.BackColor = System.Drawing.Color.Transparent;
            this.button_mirror.FlatAppearance.BorderSize = 0;
            this.button_mirror.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_mirror.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_mirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mirror.Image = ((System.Drawing.Image)(resources.GetObject("button_mirror.Image")));
            this.button_mirror.Location = new System.Drawing.Point(38, 355);
            this.button_mirror.Name = "button_mirror";
            this.button_mirror.Size = new System.Drawing.Size(64, 64);
            this.button_mirror.TabIndex = 7;
            this.button_mirror.UseVisualStyleBackColor = false;
            this.button_mirror.Click += new System.EventHandler(this.button_mirror_Click);
            // 
            // button_black_white
            // 
            this.button_black_white.BackColor = System.Drawing.Color.Transparent;
            this.button_black_white.FlatAppearance.BorderSize = 0;
            this.button_black_white.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_black_white.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_black_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_black_white.Image = ((System.Drawing.Image)(resources.GetObject("button_black_white.Image")));
            this.button_black_white.Location = new System.Drawing.Point(38, 234);
            this.button_black_white.Name = "button_black_white";
            this.button_black_white.Size = new System.Drawing.Size(64, 64);
            this.button_black_white.TabIndex = 6;
            this.button_black_white.UseVisualStyleBackColor = false;
            this.button_black_white.Click += new System.EventHandler(this.button_black_white_Click);
            // 
            // button_tone
            // 
            this.button_tone.BackColor = System.Drawing.Color.Transparent;
            this.button_tone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tone.BackgroundImage")));
            this.button_tone.FlatAppearance.BorderSize = 0;
            this.button_tone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_tone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_tone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tone.Location = new System.Drawing.Point(39, 126);
            this.button_tone.Name = "button_tone";
            this.button_tone.Size = new System.Drawing.Size(64, 64);
            this.button_tone.TabIndex = 5;
            this.button_tone.UseVisualStyleBackColor = false;
            this.button_tone.Click += new System.EventHandler(this.button_tone_Click);
            // 
            // button_main
            // 
            this.button_main.BackColor = System.Drawing.Color.Transparent;
            this.button_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_main.BackgroundImage")));
            this.button_main.FlatAppearance.BorderSize = 0;
            this.button_main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main.Location = new System.Drawing.Point(38, 25);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(68, 68);
            this.button_main.TabIndex = 4;
            this.button_main.UseVisualStyleBackColor = false;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_main.Location = new System.Drawing.Point(150, 78);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(930, 642);
            this.panel_main.TabIndex = 2;
            // 
            // SystemyWizyjne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu_left);
            this.Controls.Add(this.panel_menu_up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemyWizyjne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systemy Wizyjne";
            this.panel_menu_up.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_icon)).EndInit();
            this.panel_menu_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu_up;
        private System.Windows.Forms.Panel panel_menu_left;
        private System.Windows.Forms.PictureBox pictureBox_logo_icon;
        private System.Windows.Forms.Button button_close_app;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_negative;
        private System.Windows.Forms.Button button_mirror;
        private System.Windows.Forms.Button button_black_white;
        private System.Windows.Forms.Button button_tone;
        private System.Windows.Forms.Button button_main;
    }
}

