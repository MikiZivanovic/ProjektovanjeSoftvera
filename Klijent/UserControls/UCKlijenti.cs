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
    public partial class UCKlijenti : UserControl
    {
        public UCKlijenti()
        {
            InitializeComponent();

            dataGridView1.DataSource = new BindingList<CommonLib.Domen.Klijent>((List<CommonLib.Domen.Klijent>)Communication.Instance.UcitajListuKlijenata()) ;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.RemoveAt(0);
            
        }

       
    }
}
