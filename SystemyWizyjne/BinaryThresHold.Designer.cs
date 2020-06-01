namespace SystemyWizyjne
{
    partial class BinaryThresHold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryThresHold));
            this.button_add_picture = new System.Windows.Forms.Button();
            this.groupBox_original = new System.Windows.Forms.GroupBox();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.groupBox_binary = new System.Windows.Forms.GroupBox();
            this.pictureBox_binary = new System.Windows.Forms.PictureBox();
            this.trackBar_binary = new System.Windows.Forms.TrackBar();
            this.label_title = new System.Windows.Forms.Label();
            this.label_binary = new System.Windows.Forms.Label();
            this.label_original = new System.Windows.Forms.Label();
            this.groupBox_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            this.groupBox_binary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_binary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_binary)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_picture
            // 
            this.button_add_picture.BackColor = System.Drawing.Color.DarkGray;
            this.button_add_picture.FlatAppearance.BorderSize = 0;
            this.button_add_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_picture.Location = new System.Drawing.Point(119, 514);
            this.button_add_picture.Name = "button_add_picture";
            this.button_add_picture.Size = new System.Drawing.Size(175, 69);
            this.button_add_picture.TabIndex = 11;
            this.button_add_picture.Text = "Change Picture";
            this.button_add_picture.UseVisualStyleBackColor = false;
            this.button_add_picture.Click += new System.EventHandler(this.button_add_picture_Click);
            // 
            // groupBox_original
            // 
            this.groupBox_original.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_original.Controls.Add(this.pictureBox_original);
            this.groupBox_original.Location = new System.Drawing.Point(66, 120);
            this.groupBox_original.Name = "groupBox_original";
            this.groupBox_original.Size = new System.Drawing.Size(300, 300);
            this.groupBox_original.TabIndex = 9;
            this.groupBox_original.TabStop = false;
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_original.Image")));
            this.pictureBox_original.Location = new System.Drawing.Point(23, 26);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(256, 256);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_original.TabIndex = 0;
            this.pictureBox_original.TabStop = false;
            // 
            // groupBox_binary
            // 
            this.groupBox_binary.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_binary.Controls.Add(this.pictureBox_binary);
            this.groupBox_binary.Location = new System.Drawing.Point(560, 120);
            this.groupBox_binary.Name = "groupBox_binary";
            this.groupBox_binary.Size = new System.Drawing.Size(300, 300);
            this.groupBox_binary.TabIndex = 10;
            this.groupBox_binary.TabStop = false;
            // 
            // pictureBox_binary
            // 
            this.pictureBox_binary.Location = new System.Drawing.Point(23, 26);
            this.pictureBox_binary.Name = "pictureBox_binary";
            this.pictureBox_binary.Size = new System.Drawing.Size(256, 256);
            this.pictureBox_binary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_binary.TabIndex = 0;
            this.pictureBox_binary.TabStop = false;
            // 
            // trackBar_binary
            // 
            this.trackBar_binary.Location = new System.Drawing.Point(560, 527);
            this.trackBar_binary.Maximum = 255;
            this.trackBar_binary.Minimum = 10;
            this.trackBar_binary.Name = "trackBar_binary";
            this.trackBar_binary.Size = new System.Drawing.Size(300, 45);
            this.trackBar_binary.TabIndex = 12;
            this.trackBar_binary.Value = 10;
            this.trackBar_binary.Scroll += new System.EventHandler(this.trackBar_binary_Scroll);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(340, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(239, 27);
            this.label_title.TabIndex = 14;
            this.label_title.Text = "Making binary threshold";
            // 
            // label_binary
            // 
            this.label_binary.AutoSize = true;
            this.label_binary.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_binary.Location = new System.Drawing.Point(576, 432);
            this.label_binary.Name = "label_binary";
            this.label_binary.Size = new System.Drawing.Size(277, 40);
            this.label_binary.TabIndex = 15;
            this.label_binary.Text = "Binary ThresHold ";
            // 
            // label_original
            // 
            this.label_original.AutoSize = true;
            this.label_original.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_original.Location = new System.Drawing.Point(135, 432);
            this.label_original.Name = "label_original";
            this.label_original.Size = new System.Drawing.Size(134, 40);
            this.label_original.TabIndex = 16;
            this.label_original.Text = "Original";
            // 
            // BinaryThresHold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_original);
            this.Controls.Add(this.label_binary);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.trackBar_binary);
            this.Controls.Add(this.groupBox_binary);
            this.Controls.Add(this.button_add_picture);
            this.Controls.Add(this.groupBox_original);
            this.Name = "BinaryThresHold";
            this.Size = new System.Drawing.Size(930, 642);
            this.groupBox_original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            this.groupBox_binary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_binary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_binary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_picture;
        private System.Windows.Forms.GroupBox groupBox_original;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.GroupBox groupBox_binary;
        private System.Windows.Forms.PictureBox pictureBox_binary;
        private System.Windows.Forms.TrackBar trackBar_binary;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_binary;
        private System.Windows.Forms.Label label_original;
    }
}
