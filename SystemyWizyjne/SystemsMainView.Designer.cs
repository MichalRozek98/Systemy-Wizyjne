namespace SystemyWizyjne
{
    partial class SystemsMainView
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
            this.panel_auctions_main_view = new System.Windows.Forms.Panel();
            this.label_title_1 = new System.Windows.Forms.Label();
            this.label_title_2 = new System.Windows.Forms.Label();
            this.label_title_3 = new System.Windows.Forms.Label();
            this.panel_auctions_main_view.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_auctions_main_view
            // 
            this.panel_auctions_main_view.Controls.Add(this.label_title_3);
            this.panel_auctions_main_view.Controls.Add(this.label_title_2);
            this.panel_auctions_main_view.Controls.Add(this.label_title_1);
            this.panel_auctions_main_view.Location = new System.Drawing.Point(0, 0);
            this.panel_auctions_main_view.Name = "panel_auctions_main_view";
            this.panel_auctions_main_view.Size = new System.Drawing.Size(930, 642);
            this.panel_auctions_main_view.TabIndex = 0;
            this.panel_auctions_main_view.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_auctions_main_view_Paint);
            // 
            // label_title_1
            // 
            this.label_title_1.AutoSize = true;
            this.label_title_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title_1.Location = new System.Drawing.Point(52, 22);
            this.label_title_1.Name = "label_title_1";
            this.label_title_1.Size = new System.Drawing.Size(829, 28);
            this.label_title_1.TabIndex = 1;
            this.label_title_1.Text = "Aplikacja została zaprojektowana przez Michała Rożka oraz Macieja Fladzińskiego";
            // 
            // label_title_2
            // 
            this.label_title_2.AutoSize = true;
            this.label_title_2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_title_2.Location = new System.Drawing.Point(210, 63);
            this.label_title_2.Name = "label_title_2";
            this.label_title_2.Size = new System.Drawing.Size(488, 28);
            this.label_title_2.TabIndex = 2;
            this.label_title_2.Text = "Elektronika i Telekomunikacja semestr 6 MiEPU";
            // 
            // label_title_3
            // 
            this.label_title_3.AutoSize = true;
            this.label_title_3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_title_3.Location = new System.Drawing.Point(302, 104);
            this.label_title_3.Name = "label_title_3";
            this.label_title_3.Size = new System.Drawing.Size(293, 28);
            this.label_title_3.TabIndex = 3;
            this.label_title_3.Text = "Przedmiot: Systemy Wizyjne";
            // 
            // SystemsMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel_auctions_main_view);
            this.Name = "SystemsMainView";
            this.Size = new System.Drawing.Size(930, 642);
            this.panel_auctions_main_view.ResumeLayout(false);
            this.panel_auctions_main_view.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_auctions_main_view;
        private System.Windows.Forms.Label label_title_1;
        private System.Windows.Forms.Label label_title_2;
        private System.Windows.Forms.Label label_title_3;
    }
}
