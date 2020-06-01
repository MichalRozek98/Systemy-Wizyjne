namespace SystemyWizyjne
{
    partial class ToneOfImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToneOfImage));
            this.panel_allegro = new System.Windows.Forms.Panel();
            this.button_change_from_path = new System.Windows.Forms.Button();
            this.button_restore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar_image_red = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_image_blue = new System.Windows.Forms.TrackBar();
            this.trackBar_image_green = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.label_blue = new System.Windows.Forms.Label();
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.groupBox_picture = new System.Windows.Forms.GroupBox();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            this.panel_allegro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_image_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_image_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_image_green)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            this.groupBox_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_allegro
            // 
            this.panel_allegro.BackColor = System.Drawing.Color.Transparent;
            this.panel_allegro.Controls.Add(this.button_change_from_path);
            this.panel_allegro.Controls.Add(this.button_restore);
            this.panel_allegro.Controls.Add(this.groupBox2);
            this.panel_allegro.Controls.Add(this.groupBox1);
            this.panel_allegro.Controls.Add(this.groupBox_picture);
            this.panel_allegro.Location = new System.Drawing.Point(0, 0);
            this.panel_allegro.Name = "panel_allegro";
            this.panel_allegro.Size = new System.Drawing.Size(930, 642);
            this.panel_allegro.TabIndex = 0;
            // 
            // button_change_from_path
            // 
            this.button_change_from_path.BackColor = System.Drawing.Color.DarkGray;
            this.button_change_from_path.FlatAppearance.BorderSize = 0;
            this.button_change_from_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_from_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_change_from_path.Location = new System.Drawing.Point(366, 557);
            this.button_change_from_path.Name = "button_change_from_path";
            this.button_change_from_path.Size = new System.Drawing.Size(175, 69);
            this.button_change_from_path.TabIndex = 7;
            this.button_change_from_path.Text = "Change picture";
            this.button_change_from_path.UseVisualStyleBackColor = false;
            this.button_change_from_path.Click += new System.EventHandler(this.button_change_from_path_Click);
            // 
            // button_restore
            // 
            this.button_restore.BackColor = System.Drawing.Color.DarkGray;
            this.button_restore.FlatAppearance.BorderSize = 0;
            this.button_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_restore.Location = new System.Drawing.Point(29, 557);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(175, 69);
            this.button_restore.TabIndex = 6;
            this.button_restore.Text = "Restore original picture";
            this.button_restore.UseVisualStyleBackColor = false;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar_image_red);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trackBar_image_blue);
            this.groupBox2.Controls.Add(this.trackBar_image_green);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(564, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 268);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change the image";
            // 
            // trackBar_image_red
            // 
            this.trackBar_image_red.Location = new System.Drawing.Point(5, 49);
            this.trackBar_image_red.Maximum = 255;
            this.trackBar_image_red.Name = "trackBar_image_red";
            this.trackBar_image_red.Size = new System.Drawing.Size(347, 45);
            this.trackBar_image_red.TabIndex = 1;
            this.trackBar_image_red.Value = 255;
            this.trackBar_image_red.MouseCaptureChanged += new System.EventHandler(this.trackBar_image_red_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Green";
            // 
            // trackBar_image_blue
            // 
            this.trackBar_image_blue.Location = new System.Drawing.Point(8, 217);
            this.trackBar_image_blue.Maximum = 255;
            this.trackBar_image_blue.Name = "trackBar_image_blue";
            this.trackBar_image_blue.Size = new System.Drawing.Size(347, 45);
            this.trackBar_image_blue.TabIndex = 3;
            this.trackBar_image_blue.Value = 255;
            this.trackBar_image_blue.MouseCaptureChanged += new System.EventHandler(this.trackBar_image_blue_MouseCaptureChanged);
            // 
            // trackBar_image_green
            // 
            this.trackBar_image_green.Location = new System.Drawing.Point(5, 130);
            this.trackBar_image_green.Maximum = 255;
            this.trackBar_image_green.Name = "trackBar_image_green";
            this.trackBar_image_green.Size = new System.Drawing.Size(347, 45);
            this.trackBar_image_green.TabIndex = 2;
            this.trackBar_image_green.Value = 255;
            this.trackBar_image_green.MouseCaptureChanged += new System.EventHandler(this.trackBar_image_green_MouseCaptureChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar_red);
            this.groupBox1.Controls.Add(this.label_blue);
            this.groupBox1.Controls.Add(this.label_red);
            this.groupBox1.Controls.Add(this.label_green);
            this.groupBox1.Controls.Add(this.trackBar_blue);
            this.groupBox1.Controls.Add(this.trackBar_green);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(564, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change the background";
            // 
            // trackBar_red
            // 
            this.trackBar_red.Location = new System.Drawing.Point(5, 49);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(347, 45);
            this.trackBar_red.TabIndex = 1;
            this.trackBar_red.Value = 255;
            this.trackBar_red.Scroll += new System.EventHandler(this.trackBar_red_Scroll);
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Location = new System.Drawing.Point(9, 190);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(42, 18);
            this.label_blue.TabIndex = 7;
            this.label_blue.Text = "Blue";
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(6, 19);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(37, 18);
            this.label_red.TabIndex = 5;
            this.label_red.Text = "Red";
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Location = new System.Drawing.Point(6, 103);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(53, 18);
            this.label_green.TabIndex = 6;
            this.label_green.Text = "Green";
            // 
            // trackBar_blue
            // 
            this.trackBar_blue.Location = new System.Drawing.Point(8, 217);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(347, 45);
            this.trackBar_blue.TabIndex = 3;
            this.trackBar_blue.Value = 255;
            this.trackBar_blue.Scroll += new System.EventHandler(this.trackBar_blue_Scroll);
            // 
            // trackBar_green
            // 
            this.trackBar_green.Location = new System.Drawing.Point(5, 130);
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.Size = new System.Drawing.Size(347, 45);
            this.trackBar_green.TabIndex = 2;
            this.trackBar_green.Value = 255;
            this.trackBar_green.Scroll += new System.EventHandler(this.trackBar_green_Scroll);
            // 
            // groupBox_picture
            // 
            this.groupBox_picture.Controls.Add(this.pictureBox_help);
            this.groupBox_picture.Controls.Add(this.pictureBox_image);
            this.groupBox_picture.Location = new System.Drawing.Point(18, 11);
            this.groupBox_picture.Name = "groupBox_picture";
            this.groupBox_picture.Size = new System.Drawing.Size(540, 540);
            this.groupBox_picture.TabIndex = 4;
            this.groupBox_picture.TabStop = false;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_image.Image")));
            this.pictureBox_image.Location = new System.Drawing.Point(11, 17);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(11, 17);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_help.TabIndex = 1;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Visible = false;
            // 
            // ToneOfImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel_allegro);
            this.Name = "ToneOfImage";
            this.Size = new System.Drawing.Size(930, 642);
            this.panel_allegro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_image_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_image_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_image_green)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            this.groupBox_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_allegro;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.GroupBox groupBox_picture;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Label label_blue;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar_image_red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_image_blue;
        private System.Windows.Forms.TrackBar trackBar_image_green;
        private System.Windows.Forms.Button button_restore;
        private System.Windows.Forms.Button button_change_from_path;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
