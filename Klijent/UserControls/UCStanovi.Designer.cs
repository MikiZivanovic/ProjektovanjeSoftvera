using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCStanovi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKvadratura = new System.Windows.Forms.TextBox();
            this.txtBrojSoba = new System.Windows.Forms.TextBox();
            this.txtCenaPoDanu = new System.Windows.Forms.TextBox();
            this.lblKvadratura = new System.Windows.Forms.Label();
            this.lblBrojSoba = new System.Windows.Forms.Label();
            this.lblCenaPoDanu = new System.Windows.Forms.Label();
            this.cmbNaselje = new System.Windows.Forms.ComboBox();
            this.lblNaselje = new System.Windows.Forms.Label();
            this.chkIznajmljen = new System.Windows.Forms.CheckBox();
            this.chkKlima = new System.Windows.Forms.CheckBox();
            this.btbIzvrsiIzmenu = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.panelPocetni = new System.Windows.Forms.Panel();
            this.btnSacuvajClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPocetni.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do koliko kvadrata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "BrojSoba";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(949, 179);
            this.dataGridView1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "PrikaziDetalje";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtKvadratura
            // 
            this.txtKvadratura.Location = new System.Drawing.Point(137, 18);
            this.txtKvadratura.MinimumSize = new System.Drawing.Size(211, 22);
            this.txtKvadratura.Name = "txtKvadratura";
            this.txtKvadratura.Size = new System.Drawing.Size(211, 22);
            this.txtKvadratura.TabIndex = 10;
            // 
            // txtBrojSoba
            // 
            this.txtBrojSoba.Location = new System.Drawing.Point(137, 58);
            this.txtBrojSoba.MinimumSize = new System.Drawing.Size(211, 22);
            this.txtBrojSoba.Name = "txtBrojSoba";
            this.txtBrojSoba.Size = new System.Drawing.Size(211, 22);
            this.txtBrojSoba.TabIndex = 11;
            // 
            // txtCenaPoDanu
            // 
            this.txtCenaPoDanu.Location = new System.Drawing.Point(137, 108);
            this.txtCenaPoDanu.MinimumSize = new System.Drawing.Size(211, 22);
            this.txtCenaPoDanu.Name = "txtCenaPoDanu";
            this.txtCenaPoDanu.Size = new System.Drawing.Size(211, 22);
            this.txtCenaPoDanu.TabIndex = 12;
            // 
            // lblKvadratura
            // 
            this.lblKvadratura.AutoSize = true;
            this.lblKvadratura.Location = new System.Drawing.Point(3, 21);
            this.lblKvadratura.Name = "lblKvadratura";
            this.lblKvadratura.Size = new System.Drawing.Size(61, 16);
            this.lblKvadratura.TabIndex = 14;
            this.lblKvadratura.Text = "Kvadrata";
            // 
            // lblBrojSoba
            // 
            this.lblBrojSoba.AutoSize = true;
            this.lblBrojSoba.Location = new System.Drawing.Point(3, 58);
            this.lblBrojSoba.Name = "lblBrojSoba";
            this.lblBrojSoba.Size = new System.Drawing.Size(65, 16);
            this.lblBrojSoba.TabIndex = 15;
            this.lblBrojSoba.Text = "Broj soba";
            // 
            // lblCenaPoDanu
            // 
            this.lblCenaPoDanu.AutoSize = true;
            this.lblCenaPoDanu.Location = new System.Drawing.Point(-3, 111);
            this.lblCenaPoDanu.Name = "lblCenaPoDanu";
            this.lblCenaPoDanu.Size = new System.Drawing.Size(91, 16);
            this.lblCenaPoDanu.TabIndex = 16;
            this.lblCenaPoDanu.Text = "Cena po danu";
            // 
            // cmbNaselje
            // 
            this.cmbNaselje.FormattingEnabled = true;
            this.cmbNaselje.Location = new System.Drawing.Point(137, 217);
            this.cmbNaselje.MinimumSize = new System.Drawing.Size(211, 0);
            this.cmbNaselje.Name = "cmbNaselje";
            this.cmbNaselje.Size = new System.Drawing.Size(211, 24);
            this.cmbNaselje.TabIndex = 17;
            // 
            // lblNaselje
            // 
            this.lblNaselje.AutoSize = true;
            this.lblNaselje.Location = new System.Drawing.Point(14, 225);
            this.lblNaselje.Name = "lblNaselje";
            this.lblNaselje.Size = new System.Drawing.Size(54, 16);
            this.lblNaselje.TabIndex = 18;
            this.lblNaselje.Text = "Naselje";
            // 
            // chkIznajmljen
            // 
            this.chkIznajmljen.AutoSize = true;
            this.chkIznajmljen.Location = new System.Drawing.Point(131, 155);
            this.chkIznajmljen.Name = "chkIznajmljen";
            this.chkIznajmljen.Size = new System.Drawing.Size(88, 20);
            this.chkIznajmljen.TabIndex = 21;
            this.chkIznajmljen.Text = "Iznajmljen";
            this.chkIznajmljen.UseVisualStyleBackColor = true;
            // 
            // chkKlima
            // 
            this.chkKlima.AutoSize = true;
            this.chkKlima.Location = new System.Drawing.Point(131, 191);
            this.chkKlima.Name = "chkKlima";
            this.chkKlima.Size = new System.Drawing.Size(62, 20);
            this.chkKlima.TabIndex = 22;
            this.chkKlima.Text = "Klima";
            this.chkKlima.UseVisualStyleBackColor = true;
            // 
            // btbIzvrsiIzmenu
            // 
            this.btbIzvrsiIzmenu.Location = new System.Drawing.Point(137, 271);
            this.btbIzvrsiIzmenu.Name = "btbIzvrsiIzmenu";
            this.btbIzvrsiIzmenu.Size = new System.Drawing.Size(106, 23);
            this.btbIzvrsiIzmenu.TabIndex = 24;
            this.btbIzvrsiIzmenu.Text = "IzvrsiIzmenu";
            this.btbIzvrsiIzmenu.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(249, 271);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(106, 23);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "ObrisiStan";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.btnPovratak);
            this.panel1.Controls.Add(this.lblKvadratura);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.txtKvadratura);
            this.panel1.Controls.Add(this.btbIzvrsiIzmenu);
            this.panel1.Controls.Add(this.lblBrojSoba);
            this.panel1.Controls.Add(this.txtBrojSoba);
            this.panel1.Controls.Add(this.lblNaselje);
            this.panel1.Controls.Add(this.chkKlima);
            this.panel1.Controls.Add(this.cmbNaselje);
            this.panel1.Controls.Add(this.lblCenaPoDanu);
            this.panel1.Controls.Add(this.chkIznajmljen);
            this.panel1.Controls.Add(this.txtCenaPoDanu);
            this.panel1.Location = new System.Drawing.Point(398, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 309);
            this.panel1.TabIndex = 27;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(361, 271);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(106, 23);
            this.btnSacuvaj.TabIndex = 28;
            this.btnSacuvaj.Text = "Sacuvaj stan";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(17, 271);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(106, 23);
            this.btnPovratak.TabIndex = 27;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            // 
            // panelPocetni
            // 
            this.panelPocetni.Controls.Add(this.btnSacuvajClick);
            this.panelPocetni.Controls.Add(this.textBox1);
            this.panelPocetni.Controls.Add(this.label1);
            this.panelPocetni.Controls.Add(this.button2);
            this.panelPocetni.Controls.Add(this.label2);
            this.panelPocetni.Controls.Add(this.textBox2);
            this.panelPocetni.Controls.Add(this.button1);
            this.panelPocetni.Location = new System.Drawing.Point(16, 35);
            this.panelPocetni.Name = "panelPocetni";
            this.panelPocetni.Size = new System.Drawing.Size(311, 288);
            this.panelPocetni.TabIndex = 28;
            // 
            // btnSacuvajClick
            // 
            this.btnSacuvajClick.Location = new System.Drawing.Point(187, 239);
            this.btnSacuvajClick.Name = "btnSacuvajClick";
            this.btnSacuvajClick.Size = new System.Drawing.Size(106, 23);
            this.btnSacuvajClick.TabIndex = 10;
            this.btnSacuvajClick.Text = "Sacuvaj";
            this.btnSacuvajClick.UseVisualStyleBackColor = true;
            // 
            // UCStanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.SlikaStanovi;
            this.Controls.Add(this.panelPocetni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCStanovi";
            this.Size = new System.Drawing.Size(949, 674);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPocetni.ResumeLayout(false);
            this.panelPocetni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button button2;
        private TextBox txtKvadratura;
        private TextBox txtBrojSoba;
        private TextBox txtCenaPoDanu;
        private Label lblKvadratura;
        private Label lblBrojSoba;
        private Label lblCenaPoDanu;
        private ComboBox cmbNaselje;
        private Label lblNaselje;
        private CheckBox chkIznajmljen;
        private CheckBox chkKlima;
        private Button btbIzvrsiIzmenu;
        private Button btnObrisi;
        private Panel panel1;
        private Panel panelPocetni;
        private Button btnPovratak;
        private Button btnSacuvaj;
        private Button btnSacuvajClick;

        public TextBox KvadraturaDo { get => textBox1; }
        public TextBox BrojSoba { get => textBox2; }
       
        public Button Button { get => button1; }
        public Button ButtPrikaziDetalje { get => button2; }
        public Button DugmeZaBrisanje { get => btnObrisi; }
        public DataGridView DataGridView { get => dataGridView1; set => dataGridView1 = value;}
        public Button DugmeIzvrsiIzmenu { get => btbIzvrsiIzmenu; }
        public Button DugmeSacuvajStan { get => btnSacuvaj; }
        public Button DugmeSacuvajClick { get => btnSacuvajClick; }
        
        public Button DugmePovratak { get => btnPovratak; }
        public TextBox StanKvadratura { get => txtKvadratura; }
        public TextBox StanBrojSoba { get => txtBrojSoba; }
        public TextBox StanCenaPoDanu { get => txtCenaPoDanu; }
        public ComboBox StanNaselje { get => cmbNaselje; }
        public CheckBox StanIznajmljen { get => chkIznajmljen; }
        public CheckBox StanKlima { get => chkKlima; }
        public Panel Panel { get => panel1; set => panel1 = value; }
        public Panel PanelPocetni { get => panelPocetni; set => panelPocetni = value; }
    }
}
