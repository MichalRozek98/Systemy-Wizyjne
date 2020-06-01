namespace AukcjeApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_auctions_main_view.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_auctions_main_view
            // 
            this.panel_auctions_main_view.Controls.Add(this.label1);
            this.panel_auctions_main_view.Location = new System.Drawing.Point(0, 0);
            this.panel_auctions_main_view.Name = "panel_auctions_main_view";
            this.panel_auctions_main_view.Size = new System.Drawing.Size(930, 642);
            this.panel_auctions_main_view.TabIndex = 0;
            this.panel_auctions_main_view.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_auctions_main_view_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(280, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maciek i Michał zapraszają do krainy multimediów";
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
        private System.Windows.Forms.Label label1;
    }
}
