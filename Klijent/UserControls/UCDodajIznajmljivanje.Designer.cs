using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCDodajIznajmljivanje
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
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.lblVrednostUkupnogIzraza = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnSacuvajIznajmljivanje = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblStan = new System.Windows.Forms.Label();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.btnIzvrsiIzmenu = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.cmbStan = new System.Windows.Forms.ComboBox();
            this.dataGridIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.llblPretragaIme = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnSacuvajClick = new System.Windows.Forms.Button();
            this.btnIzmeniClick = new System.Windows.Forms.Button();
            this.btnVratiSeNazad = new System.Windows.Forms.Button();
            this.btnIzmeniIznajmljivanje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPocetni = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIznajmljivanja)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPocetni.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(161, 45);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(231, 22);
            this.txtDatumOd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DatumOd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klijent";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(161, 100);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(231, 24);
            this.cmbKlijent.TabIndex = 3;
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Location = new System.Drawing.Point(59, 147);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(88, 16);
            this.lblUkupanIznos.TabIndex = 4;
            this.lblUkupanIznos.Text = "Ukupan iznos";
            // 
            // lblVrednostUkupnogIzraza
            // 
            this.lblVrednostUkupnogIzraza.AutoSize = true;
            this.lblVrednostUkupnogIzraza.Location = new System.Drawing.Point(158, 147);
            this.lblVrednostUkupnogIzraza.Name = "lblVrednostUkupnogIzraza";
            this.lblVrednostUkupnogIzraza.Size = new System.Drawing.Size(59, 16);
            this.lblVrednostUkupnogIzraza.TabIndex = 5;
            this.lblVrednostUkupnogIzraza.Text = "vrednost";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 146);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(778, 182);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(108, 48);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni stavku";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajIznajmljivanje
            // 
            this.btnSacuvajIznajmljivanje.Location = new System.Drawing.Point(11, 340);
            this.btnSacuvajIznajmljivanje.Name = "btnSacuvajIznajmljivanje";
            this.btnSacuvajIznajmljivanje.Size = new System.Drawing.Size(746, 39);
            this.btnSacuvajIznajmljivanje.TabIndex = 8;
            this.btnSacuvajIznajmljivanje.Text = "Sacuvaj iznajmljivanje";
            this.btnSacuvajIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(778, 283);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(102, 48);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obrisi stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblStan
            // 
            this.lblStan.AutoSize = true;
            this.lblStan.Location = new System.Drawing.Point(59, 387);
            this.lblStan.Name = "lblStan";
            this.lblStan.Size = new System.Drawing.Size(34, 16);
            this.lblStan.TabIndex = 11;
            this.lblStan.Text = "Stan";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Location = new System.Drawing.Point(161, 424);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.Size = new System.Drawing.Size(428, 22);
            this.txtDatumDo.TabIndex = 12;
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(59, 424);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(64, 16);
            this.lblDatumDo.TabIndex = 13;
            this.lblDatumDo.Text = "DatumDo";
            // 
            // btnIzvrsiIzmenu
            // 
            this.btnIzvrsiIzmenu.Location = new System.Drawing.Point(631, 420);
            this.btnIzvrsiIzmenu.Name = "btnIzvrsiIzmenu";
            this.btnIzvrsiIzmenu.Size = new System.Drawing.Size(126, 30);
            this.btnIzvrsiIzmenu.TabIndex = 14;
            this.btnIzvrsiIzmenu.Text = "IzvrsiIzmenu";
            this.btnIzvrsiIzmenu.UseVisualStyleBackColor = true;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(631, 387);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(126, 30);
            this.btnDodajStavku.TabIndex = 15;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // cmbStan
            // 
            this.cmbStan.FormattingEnabled = true;
            this.cmbStan.Location = new System.Drawing.Point(161, 387);
            this.cmbStan.Name = "cmbStan";
            this.cmbStan.Size = new System.Drawing.Size(428, 24);
            this.cmbStan.TabIndex = 16;
            // 
            // dataGridIznajmljivanja
            // 
            this.dataGridIznajmljivanja.AllowUserToOrderColumns = true;
            this.dataGridIznajmljivanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIznajmljivanja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridIznajmljivanja.Location = new System.Drawing.Point(0, 509);
            this.dataGridIznajmljivanja.Name = "dataGridIznajmljivanja";
            this.dataGridIznajmljivanja.RowHeadersWidth = 51;
            this.dataGridIznajmljivanja.RowTemplate.Height = 24;
            this.dataGridIznajmljivanja.Size = new System.Drawing.Size(1385, 221);
            this.dataGridIznajmljivanja.TabIndex = 17;
            // 
            // llblPretragaIme
            // 
            this.llblPretragaIme.AutoSize = true;
            this.llblPretragaIme.Location = new System.Drawing.Point(21, 14);
            this.llblPretragaIme.Name = "llblPretragaIme";
            this.llblPretragaIme.Size = new System.Drawing.Size(86, 16);
            this.llblPretragaIme.TabIndex = 19;
            this.llblPretragaIme.Text = "Naziv klijenta";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(113, 14);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(244, 22);
            this.txtPretraga.TabIndex = 20;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(113, 51);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(126, 30);
            this.btnPretrazi.TabIndex = 21;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(13, 173);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(116, 30);
            this.btnDetalji.TabIndex = 22;
            this.btnDetalji.Text = "Prikazi detaljnije iznajmljivanje";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajClick
            // 
            this.btnSacuvajClick.Location = new System.Drawing.Point(135, 173);
            this.btnSacuvajClick.Name = "btnSacuvajClick";
            this.btnSacuvajClick.Size = new System.Drawing.Size(126, 30);
            this.btnSacuvajClick.TabIndex = 23;
            this.btnSacuvajClick.Text = "Sacuvaj iznajmljivanje";
            this.btnSacuvajClick.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniClick
            // 
            this.btnIzmeniClick.Location = new System.Drawing.Point(267, 173);
            this.btnIzmeniClick.Name = "btnIzmeniClick";
            this.btnIzmeniClick.Size = new System.Drawing.Size(119, 30);
            this.btnIzmeniClick.TabIndex = 24;
            this.btnIzmeniClick.Text = "Izmeni";
            this.btnIzmeniClick.UseVisualStyleBackColor = true;
            // 
            // btnVratiSeNazad
            // 
            this.btnVratiSeNazad.Location = new System.Drawing.Point(767, 3);
            this.btnVratiSeNazad.Name = "btnVratiSeNazad";
            this.btnVratiSeNazad.Size = new System.Drawing.Size(119, 41);
            this.btnVratiSeNazad.TabIndex = 25;
            this.btnVratiSeNazad.Text = "Vrati se nazad";
            this.btnVratiSeNazad.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniIznajmljivanje
            // 
            this.btnIzmeniIznajmljivanje.Location = new System.Drawing.Point(3, 452);
            this.btnIzmeniIznajmljivanje.Name = "btnIzmeniIznajmljivanje";
            this.btnIzmeniIznajmljivanje.Size = new System.Drawing.Size(743, 30);
            this.btnIzmeniIznajmljivanje.TabIndex = 26;
            this.btnIzmeniIznajmljivanje.Text = "Izmeni iznajmljivanje";
            this.btnIzmeniIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDatumOd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIzmeniIznajmljivanje);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnVratiSeNazad);
            this.panel1.Controls.Add(this.cmbKlijent);
            this.panel1.Controls.Add(this.lblUkupanIznos);
            this.panel1.Controls.Add(this.lblVrednostUkupnogIzraza);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnIzmeni);
            this.panel1.Controls.Add(this.lblDatumDo);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.lblStan);
            this.panel1.Controls.Add(this.btnSacuvajIznajmljivanje);
            this.panel1.Controls.Add(this.btnIzvrsiIzmenu);
            this.panel1.Controls.Add(this.btnDodajStavku);
            this.panel1.Controls.Add(this.cmbStan);
            this.panel1.Controls.Add(this.txtDatumDo);
            this.panel1.Location = new System.Drawing.Point(435, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 485);
            this.panel1.TabIndex = 27;
            // 
            // panelPocetni
            // 
            this.panelPocetni.Controls.Add(this.llblPretragaIme);
            this.panelPocetni.Controls.Add(this.txtPretraga);
            this.panelPocetni.Controls.Add(this.btnIzmeniClick);
            this.panelPocetni.Controls.Add(this.btnPretrazi);
            this.panelPocetni.Controls.Add(this.btnSacuvajClick);
            this.panelPocetni.Controls.Add(this.btnDetalji);
            this.panelPocetni.Location = new System.Drawing.Point(3, 22);
            this.panelPocetni.Name = "panelPocetni";
            this.panelPocetni.Size = new System.Drawing.Size(399, 211);
            this.panelPocetni.TabIndex = 28;
            // 
            // UCDodajIznajmljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.SlikaIznajmljivanje;
            this.Controls.Add(this.panelPocetni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridIznajmljivanja);
            this.Name = "UCDodajIznajmljivanje";
            this.Size = new System.Drawing.Size(1385, 730);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIznajmljivanja)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPocetni.ResumeLayout(false);
            this.panelPocetni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.Label lblVrednostUkupnogIzraza;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnSacuvajIznajmljivanje;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblStan;
        private System.Windows.Forms.TextBox txtDatumDo;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.Button btnIzvrsiIzmenu;
        private System.Windows.Forms.Button btnDodajStavku;
        private ComboBox cmbStan;
        private DataGridView dataGridIznajmljivanja;
        private Label llblPretragaIme;
        private TextBox txtPretraga;
        private Button btnPretrazi;
        private Button btnDetalji;
        private Button btnSacuvajClick;
        private Button btnIzmeniClick;
        private Button btnVratiSeNazad;
        private Button btnIzmeniIznajmljivanje;
        private Panel panel1;
        private Panel panelPocetni;

        public Button DugmeIzmeni { get => btnIzmeni; }
        public Button DugmeIzvrsiIzmenu { get => btnIzvrsiIzmenu; }
        public Button DugmeSacuvajIznaj { get => btnSacuvajIznajmljivanje; }
        public Button DugmeDodajjStavku { get => btnDodajStavku; }
        public Button DugmePretrazi { get => btnPretrazi; }
        public Button ObrisiStavku { get => btnObrisi; }
        public Button DugmeDetalji{ get => btnDetalji; }
        public Button DugmePOvratak{ get => btnVratiSeNazad; }
        public Button DugmeIzmeniIznajmljivanje{ get => btnIzmeniIznajmljivanje; }
        public Button DugmeObrisi{ get => btnObrisi; }
        public Button DugmeSacuvajClick{ get => btnSacuvajClick; }
        public Button DugmeIzmeniClick{ get => btnIzmeniClick; }


        public ComboBox CMBKlijenti { get => cmbKlijent; set => cmbKlijent = value; }
        public TextBox PoljeDatumOd { get => txtDatumOd; set => txtDatumOd = value; }
        public ComboBox PoleStan { get => cmbStan; set => cmbStan = value; }
        public TextBox PoleDatumDo { get => txtDatumDo; set => txtDatumDo = value; }
        public DataGridView DataGridView { get => dataGridView1; set => dataGridView1 = value; }
        public DataGridView DataGridViewIznajmljivanja { get => dataGridIznajmljivanja; set => dataGridIznajmljivanja = value; }
        public Label LabelaVrednostUkupanIznos { get => lblVrednostUkupnogIzraza; set => lblVrednostUkupnogIzraza = value; }
        public Label LabelDatumOd { get => label1; set => label1 = value; }
        public Label LabelKlijent { get => label2; set => label2 = value; }
        public Label LabelStan { get => lblStan; set => lblStan = value; }
        public Label LabelDatumDO { get => lblDatumDo; set => lblDatumDo = value; }
        public Label LabelaUkupanIznos { get => lblUkupanIznos; set => lblUkupanIznos = value; }
        public TextBox PoljePretraga { get => txtPretraga; set => txtPretraga = value; }
        public Panel Panel { get => panel1; set => panel1 = value; }
        public Panel PanelPocetni { get => panelPocetni; set => panelPocetni = value; }


    }
}
