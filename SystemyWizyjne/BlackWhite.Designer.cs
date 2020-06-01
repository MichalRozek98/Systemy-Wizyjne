namespace SystemyWizyjne
{
    partial class BlackWhite
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_original = new System.Windows.Forms.GroupBox();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_grayscale = new System.Windows.Forms.GroupBox();
            this.pictureBox_grayscale = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_original = new System.Windows.Forms.Label();
            this.label_grayscale = new System.Windows.Forms.Label();
            this.button_change_from_path = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox_original.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            this.groupBox_grayscale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grayscale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_original
            // 
            this.groupBox_original.Controls.Add(this.pictureBox_original);
            this.groupBox_original.Location = new System.Drawing.Point(12, 53);
            this.groupBox_original.Name = "groupBox_original";
            this.groupBox_original.Size = new System.Drawing.Size(440, 440);
            this.groupBox_original.TabIndex = 0;
            this.groupBox_original.TabStop = false;
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(19, 28);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_original.TabIndex = 0;
            this.pictureBox_original.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(570, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox_grayscale
            // 
            this.groupBox_grayscale.Controls.Add(this.pictureBox_grayscale);
            this.groupBox_grayscale.Location = new System.Drawing.Point(475, 53);
            this.groupBox_grayscale.Name = "groupBox_grayscale";
            this.groupBox_grayscale.Size = new System.Drawing.Size(440, 440);
            this.groupBox_grayscale.TabIndex = 2;
            this.groupBox_grayscale.TabStop = false;
            // 
            // pictureBox_grayscale
            // 
            this.pictureBox_grayscale.Location = new System.Drawing.Point(23, 28);
            this.pictureBox_grayscale.Name = "pictureBox_grayscale";
            this.pictureBox_grayscale.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_grayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_grayscale.TabIndex = 3;
            this.pictureBox_grayscale.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_original
            // 
            this.label_original.AutoSize = true;
            this.label_original.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_original.Location = new System.Drawing.Point(163, 511);
            this.label_original.Name = "label_original";
            this.label_original.Size = new System.Drawing.Size(134, 40);
            this.label_original.TabIndex = 5;
            this.label_original.Text = "Original";
            // 
            // label_grayscale
            // 
            this.label_grayscale.AutoSize = true;
            this.label_grayscale.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grayscale.Location = new System.Drawing.Point(629, 511);
            this.label_grayscale.Name = "label_grayscale";
            this.label_grayscale.Size = new System.Drawing.Size(157, 40);
            this.label_grayscale.TabIndex = 6;
            this.label_grayscale.Text = "Grayscale";
            // 
            // button_change_from_path
            // 
            this.button_change_from_path.BackColor = System.Drawing.Color.DarkGray;
            this.button_change_from_path.FlatAppearance.BorderSize = 0;
            this.button_change_from_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_from_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_change_from_path.Location = new System.Drawing.Point(377, 561);
            this.button_change_from_path.Name = "button_change_from_path";
            this.button_change_from_path.Size = new System.Drawing.Size(175, 69);
            this.button_change_from_path.TabIndex = 8;
            this.button_change_from_path.Text = "Change picture";
            this.button_change_from_path.UseVisualStyleBackColor = false;
            this.button_change_from_path.Click += new System.EventHandler(this.button_change_from_path_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(378, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(172, 27);
            this.label_title.TabIndex = 10;
            this.label_title.Text = "Making grayscale";
            // 
            // BlackWhite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_change_from_path);
            this.Controls.Add(this.label_grayscale);
            this.Controls.Add(this.label_original);
            this.Controls.Add(this.groupBox_grayscale);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox_original);
            this.Name = "BlackWhite";
            this.Size = new System.Drawing.Size(930, 642);
            this.groupBox_original.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            this.groupBox_grayscale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grayscale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_original;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox_grayscale;
        private System.Windows.Forms.PictureBox pictureBox_grayscale;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_original;
        private System.Windows.Forms.Label label_grayscale;
        private System.Windows.Forms.Button button_change_from_path;
        private System.Windows.Forms.Label label_title;
    }
}
