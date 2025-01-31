namespace Klijent
{
    partial class FRMMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iznajmljivanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem,
            this.stanToolStripMenuItem,
            this.iznajmljivanjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.klijentToolStripMenuItem.Text = "Klijent";
            // 
            // stanToolStripMenuItem
            // 
            this.stanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajSToolStripMenuItem,
            this.stanoviToolStripMenuItem});
            this.stanToolStripMenuItem.Name = "stanToolStripMenuItem";
            this.stanToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.stanToolStripMenuItem.Text = "Stan";
            // 
            // kreirajSToolStripMenuItem
            // 
            this.kreirajSToolStripMenuItem.Name = "kreirajSToolStripMenuItem";
            this.kreirajSToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.kreirajSToolStripMenuItem.Text = "KreirajStan";
            // 
            // stanoviToolStripMenuItem
            // 
            this.stanoviToolStripMenuItem.Name = "stanoviToolStripMenuItem";
            this.stanoviToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.stanoviToolStripMenuItem.Text = "Stanovi";
            // 
            // iznajmljivanjeToolStripMenuItem
            // 
            this.iznajmljivanjeToolStripMenuItem.Name = "iznajmljivanjeToolStripMenuItem";
            this.iznajmljivanjeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.iznajmljivanjeToolStripMenuItem.Text = "Iznajmljivanje";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1348, 635);
            this.panelMain.TabIndex = 1;
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 663);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMMain";
            this.Text = "FRMMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMMain_FormClosing);
            this.Load += new System.EventHandler(this.FRMMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iznajmljivanjeToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem stanoviToolStripMenuItem;
    }
}