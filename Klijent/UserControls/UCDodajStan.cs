using CommonLib.Domen;
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
    public partial class UCDodajStan : UserControl
    {
        private BindingList<Naselje> naselja = new BindingList<Naselje>();
        public UCDodajStan()
        {
            InitializeComponent();

            naselja= new BindingList<Naselje>((List<Naselje>)Communication.Instance.UcitajListuNaselja());
            comboBox1.DataSource = naselja;
        }
    }
}
