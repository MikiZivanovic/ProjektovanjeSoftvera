using CommonLib.Domen;
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

namespace Klijent.UserControls
{
    public partial class UCDodajIznajmljivanje : UserControl
    {
        public UCDodajIznajmljivanje()
        {
            InitializeComponent();

            cmbStan.DataSource = DodajIznajmljivanjeController.stanovi;
            cmbKlijent.DataSource = new BindingList<CommonLib.Domen.Klijent>((List<CommonLib.Domen.Klijent>)Communication.Instance.UcitajListuKlijenata());
            dataGridIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>((List<Iznajmljivanje>)Communication.Instance.UcitajListuIznajmljivanja());
        }

       
    }
}
