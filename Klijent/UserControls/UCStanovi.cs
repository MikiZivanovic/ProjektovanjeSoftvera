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
    public partial class UCStanovi : UserControl
    {
       
        
   
        public UCStanovi()
        {
            InitializeComponent();
            
            
           
            cmbNaselje.DataSource = (List<Naselje>)Communication.Instance.UcitajListuNaselja();

            dataGridView1.DataSource = new BindingList<Stan>( (List<Stan>)Communication.Instance.UcitajListuStanova());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.RemoveAt(0);
        }

       

       
    }
}
