using CommonClases.Komunikacija;
using CommonLib.Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    internal class DodajStanController
    {
        UCDodajStan kontrolaDodajStan;

        public void dodajStan(Object s,EventArgs e)
        {
            Stan stan = new Stan(0,int.Parse(kontrolaDodajStan.TextBox1.Text),int.Parse(kontrolaDodajStan.TextBox2.Text),Double.Parse(kontrolaDodajStan.TextBox2.Text),(kontrolaDodajStan.CheckBox1.Checked)?true:false, (kontrolaDodajStan.CheckBox2.Checked ) ? true : false, (Naselje)kontrolaDodajStan.ComboBox1.SelectedItem);

            Odgovor odgovor = Communication.Instance.ZapamtiStan(stan);
            if (odgovor.Exception == null)
            {
                MessageBox.Show("Sistem je izmenio klijenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("<<<<" + odgovor.Exception);
            }
        }

        public Control kreirajKontrolu() {
            kontrolaDodajStan = new UCDodajStan();
            kontrolaDodajStan.Button1.Click += dodajStan;
            return kontrolaDodajStan;
        }


    }
}
