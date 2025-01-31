using Klijent.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
            kreirajSToolStripMenuItem.Click += (s, e) => { MainController.Instance.prikaziKreirajStanControlu(); };
            stanoviToolStripMenuItem.Click += (s, e) => { MainController.Instance.prikaziKreirajControluStanovi(); };
            klijentToolStripMenuItem.Click += (s, e) => { MainController.Instance.prikaziKreirajControluKlijenti(); };
            iznajmljivanjeToolStripMenuItem.Click += (s, e) => { MainController.Instance.prikaziKreirajControluInzajmljivanje(); };
        }
        public void promeniControlu(Control controla) {

            panelMain.Controls.Clear();
            panelMain.Controls.Add(controla);
            controla.Dock = DockStyle.Fill;
            panelMain.AutoSize = true;
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {

        }

        private void FRMMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
