namespace SystemyWizyjne
{
    partial class Mirror
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
            this.panel_ebay = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_mirror = new System.Windows.Forms.Button();
            this.button_add_picture = new System.Windows.Forms.Button();
            this.groupBox_mirror = new System.Windows.Forms.GroupBox();
            this.pictureBox_mirror = new System.Windows.Forms.PictureBox();
            this.groupBox_original = new System.Windows.Forms.GroupBox();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.label_mirror = new System.Windows.Forms.Label();
            this.label_original = new System.Windows.Forms.Label();
            this.panel_ebay.SuspendLayout();
            this.groupBox_mirror.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mirror)).BeginInit();
            this.groupBox_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ebay
            // 
            this.panel_ebay.BackColor = System.Drawing.Color.Transparent;
            this.panel_ebay.Controls.Add(this.label_original);
            this.panel_ebay.Controls.Add(this.label_mirror);
            this.panel_ebay.Controls.Add(this.label_title);
            this.panel_ebay.Controls.Add(this.button_mirror);
            this.panel_ebay.Controls.Add(this.button_add_picture);
            this.panel_ebay.Controls.Add(this.groupBox_mirror);
            this.panel_ebay.Controls.Add(this.groupBox_original);
            this.panel_ebay.Location = new System.Drawing.Point(0, 0);
            this.panel_ebay.Name = "panel_ebay";
            this.panel_ebay.Size = new System.Drawing.Size(930, 642);
            this.panel_ebay.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(337, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(237, 27);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Making mirror reflection";
            // 
            // button_mirror
            // 
            this.button_mirror.BackColor = System.Drawing.Color.DarkGray;
            this.button_mirror.FlatAppearance.BorderSize = 0;
            this.button_mirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mirror.Location = new System.Drawing.Point(533, 538);
            this.button_mirror.Name = "button_mirror";
            this.button_mirror.Size = new System.Drawing.Size(175, 69);
            this.button_mirror.TabIndex = 8;
            this.button_mirror.Text = "Make mirror reflection";
            this.button_mirror.UseVisualStyleBackColor = false;
            this.button_mirror.Click += new System.EventHandler(this.button_mirror_Click);
            // 
            // button_add_picture
            // 
            this.button_add_picture.BackColor = System.Drawing.Color.DarkGray;
            this.button_add_picture.FlatAppearance.BorderSize = 0;
            this.button_add_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_picture.Location = new System.Drawing.Point(68, 538);
            this.button_add_picture.Name = "button_add_picture";
            this.button_add_picture.Size = new System.Drawing.Size(175, 69);
            this.button_add_picture.TabIndex = 7;
            this.button_add_picture.Text = "Change picture";
            this.button_add_picture.UseVisualStyleBackColor = false;
            this.button_add_picture.Click += new System.EventHandler(this.button_add_picture_Click);
            // 
            // groupBox_mirror
            // 
            this.groupBox_mirror.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_mirror.Controls.Add(this.pictureBox_mirror);
            this.groupBox_mirror.Location = new System.Drawing.Point(321, 171);
            this.groupBox_mirror.Name = "groupBox_mirror";
            this.groupBox_mirror.Size = new System.Drawing.Size(600, 300);
            this.groupBox_mirror.TabIndex = 3;
            this.groupBox_mirror.TabStop = false;
            // 
            // pictureBox_mirror
            // 
            this.pictureBox_mirror.Location = new System.Drawing.Point(45, 26);
            this.pictureBox_mirror.Name = "pictureBox_mirror";
            this.pictureBox_mirror.Size = new System.Drawing.Size(512, 256);
            this.pictureBox_mirror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_mirror.TabIndex = 0;
            this.pictureBox_mirror.TabStop = false;
            // 
            // groupBox_original
            // 
            this.groupBox_original.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_original.Controls.Add(this.pictureBox_original);
            this.groupBox_original.Location = new System.Drawing.Point(13, 171);
            this.groupBox_original.Name = "groupBox_original";
            this.groupBox_original.Size = new System.Drawing.Size(300, 300);
            this.groupBox_original.TabIndex = 2;
            this.groupBox_original.TabStop = false;
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(23, 26);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(256, 256);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_original.TabIndex = 0;
            this.pictureBox_original.TabStop = false;
            // 
            // label_mirror
            // 
            this.label_mirror.AutoSize = true;
            this.label_mirror.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mirror.Location = new System.Drawing.Point(558, 474);
            this.label_mirror.Name = "label_mirror";
            this.label_mirror.Size = new System.Drawing.Size(114, 40);
            this.label_mirror.TabIndex = 16;
            this.label_mirror.Text = "Mirror";
            // 
            // label_original
            // 
            this.label_original.AutoSize = true;
            this.label_original.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_original.Location = new System.Drawing.Point(93, 474);
            this.label_original.Name = "label_original";
            this.label_original.Size = new System.Drawing.Size(134, 40);
            this.label_original.TabIndex = 17;
            this.label_original.Text = "Original";
            // 
            // Mirror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel_ebay);
            this.Name = "Mirror";
            this.Size = new System.Drawing.Size(930, 642);
            this.panel_ebay.ResumeLayout(false);
            this.panel_ebay.PerformLayout();
            this.groupBox_mirror.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mirror)).EndInit();
            this.groupBox_original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ebay;
        private System.Windows.Forms.GroupBox groupBox_mirror;
        private System.Windows.Forms.PictureBox pictureBox_mirror;
        private System.Windows.Forms.GroupBox groupBox_original;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button button_mirror;
        private System.Windows.Forms.Button button_add_picture;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_original;
        private System.Windows.Forms.Label label_mirror;
    }
}
