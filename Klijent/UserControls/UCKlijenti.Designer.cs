using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCKlijenti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textImeKlijenta = new System.Windows.Forms.TextBox();
            this.lblImeKl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPocetni = new System.Windows.Forms.Panel();
            this.btnSacuvajClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPocetni.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(898, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // textImeKlijenta
            // 
            this.textImeKlijenta.Location = new System.Drawing.Point(65, 15);
            this.textImeKlijenta.MinimumSize = new System.Drawing.Size(140, 22);
            this.textImeKlijenta.Name = "textImeKlijenta";
            this.textImeKlijenta.Size = new System.Drawing.Size(140, 22);
            this.textImeKlijenta.TabIndex = 1;
            // 
            // lblImeKl
            // 
            this.lblImeKl.AutoSize = true;
            this.lblImeKl.Location = new System.Drawing.Point(14, 18);
            this.lblImeKl.Name = "lblImeKl";
            this.lblImeKl.Size = new System.Drawing.Size(29, 16);
            this.lblImeKl.TabIndex = 2;
            this.lblImeKl.Text = "Ime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 19);
            this.textBox1.MinimumSize = new System.Drawing.Size(140, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 56);
            this.textBox2.MinimumSize = new System.Drawing.Size(140, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 96);
            this.textBox3.MinimumSize = new System.Drawing.Size(140, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 135);
            this.textBox4.MinimumSize = new System.Drawing.Size(140, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "BrojTelefona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imejl";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(90, 63);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(99, 23);
            this.btnDetalji.TabIndex = 11;
            this.btnDetalji.Text = "PrikaziDetalje";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(100, 188);
            this.btnSacuvaj.MinimumSize = new System.Drawing.Size(148, 23);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(148, 23);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj klijenta";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(254, 188);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(112, 23);
            this.btnIzmeni.TabIndex = 13;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(12, 188);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(82, 23);
            this.btnPovratak.TabIndex = 14;
            this.btnPovratak.Text = "Povratak ";
            this.btnPovratak.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIzmeni);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPovratak);
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(476, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 227);
            this.panel1.TabIndex = 15;
            // 
            // panelPocetni
            // 
            this.panelPocetni.Controls.Add(this.btnSacuvajClick);
            this.panelPocetni.Controls.Add(this.textImeKlijenta);
            this.panelPocetni.Controls.Add(this.lblImeKl);
            this.panelPocetni.Controls.Add(this.btnDetalji);
            this.panelPocetni.Controls.Add(this.button1);
            this.panelPocetni.Location = new System.Drawing.Point(38, 38);
            this.panelPocetni.Name = "panelPocetni";
            this.panelPocetni.Size = new System.Drawing.Size(311, 106);
            this.panelPocetni.TabIndex = 16;
            // 
            // btnSacuvajClick
            // 
            this.btnSacuvajClick.Location = new System.Drawing.Point(195, 63);
            this.btnSacuvajClick.Name = "btnSacuvajClick";
            this.btnSacuvajClick.Size = new System.Drawing.Size(98, 23);
            this.btnSacuvajClick.TabIndex = 12;
            this.btnSacuvajClick.Text = "Sacuvaj";
            this.btnSacuvajClick.UseVisualStyleBackColor = true;
            // 
            // UCKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.SlikaKlijenti;
            this.Controls.Add(this.panelPocetni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCKlijenti";
            this.Size = new System.Drawing.Size(898, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPocetni.ResumeLayout(false);
            this.panelPocetni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textImeKlijenta;
        private System.Windows.Forms.Label lblImeKl;
        private System.Windows.Forms.Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDetalji;
        private Button btnSacuvaj;
        private Button btnIzmeni;
        private Button btnPovratak;
        private Panel panel1;
        private Panel panelPocetni;
        private Button btnSacuvajClick;

        public DataGridView DataGridView { get => dataGridView1; set => dataGridView1 = value; }
        public TextBox PoljeIme { get => textImeKlijenta; }
        public Button DugmePretrazi { get => button1; }
        public TextBox DetaljiIme { get => textBox1; }
        public TextBox DetaljiPrezime { get => textBox2; }
        public TextBox DetaljiTelefon { get => textBox3; }
        public TextBox DetaljiImejl { get => textBox4; }
        public Button DugmeDetalji { get => btnDetalji; }
        public Button DugmePovratak { get => btnPovratak; }
        public Button DugmeSacuvaj { get => btnSacuvaj; }
        public Button DugmeIzmeni { get => btnIzmeni; }
        public Button DugmeSacuvajClick { get => btnSacuvajClick; }
        public Panel Panel { get=> panel1; set=>panel1=value; }
        public Panel PanelPocetni { get=> panelPocetni; set=> panelPocetni = value; }


    }
}
