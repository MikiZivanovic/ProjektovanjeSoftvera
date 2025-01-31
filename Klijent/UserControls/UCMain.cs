using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.UserControls
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }
        private int slika = 1;
        private void loadingSlike() {

            if (slika == 4) { 
                slika= 1;
            }
            pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", slika);
            slika++; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingSlike();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
