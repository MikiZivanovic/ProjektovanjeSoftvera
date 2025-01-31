using CommonClases.Komunikacija;
using CommonLib.Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Klijent.GuiController
{
    public class KlijentiController
    {
        private UCKlijenti klijentiKontrola;
        public KlijentiController()
        {

        }
        private bool Validacija() {
            if (string.IsNullOrEmpty(klijentiKontrola.DetaljiIme.Text) || klijentiKontrola.DetaljiIme.Text.All(char.IsLetter) ==false|| string.IsNullOrEmpty(klijentiKontrola.DetaljiPrezime.Text) || klijentiKontrola.DetaljiPrezime.Text.All(char.IsLetter)==false|| string.IsNullOrEmpty(klijentiKontrola.DetaljiTelefon.Text) || klijentiKontrola.DetaljiTelefon.Text.All(char.IsNumber)==false || string.IsNullOrEmpty(klijentiKontrola.DetaljiImejl.Text)) { 
            
                return false;
            } ;
            


            return true;
        }
        public void NadjiKljiente(Object o, EventArgs e) {

            CommonLib.Domen.Klijent kl = new CommonLib.Domen.Klijent();
            kl.Ime = klijentiKontrola.PoljeIme.Text;
            
            Odgovor ob = Communication.Instance.PretraziKlijente(kl);

            if (ob.Exception == null)
            {

                klijentiKontrola.DataGridView.DataSource = null;
                klijentiKontrola.DataGridView.DataSource = new BindingList<CommonLib.Domen.Klijent>((List<CommonLib.Domen.Klijent>)ob.Result);

                MessageBox.Show("Sistem je nasao klijente po zadatoj vrednosti", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da nadje klijente po zadatoj vrednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void Povratak(Object sender,EventArgs eventArgs) {
            klijentiKontrola.PanelPocetni.Visible = true;
            klijentiKontrola.Panel.Visible = false;

        }
        public void PrikaziDetalje(Object s, EventArgs e)
        {

            if (klijentiKontrola.DataGridView.SelectedRows.Count == 1)
            {
                klijentiKontrola.PanelPocetni.Visible = false;
                klijentiKontrola.Panel.Visible = true;
                klijentiKontrola.DugmeSacuvaj.Visible = false;
                CommonLib.Domen.Klijent klijentZaPrikaz = (CommonLib.Domen.Klijent)klijentiKontrola.DataGridView.SelectedRows[0].DataBoundItem;
                Odgovor odgovor = Communication.Instance.PretraziKlijente(klijentZaPrikaz);

                if (odgovor.Exception == null)
                {

                    CommonLib.Domen.Klijent kl = ((List<CommonLib.Domen.Klijent>)odgovor.Result)[0];
                    klijentiKontrola.DetaljiIme.Text = kl.Ime;
                    klijentiKontrola.DetaljiPrezime.Text = kl.Prezime;
                    klijentiKontrola.DetaljiTelefon.Text = kl.BrojTelefona;
                    klijentiKontrola.DetaljiImejl.Text = kl.Imejl;

                    MessageBox.Show("Sistem je ucitao klijenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita klijenta","Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
        public void Izmeni(Object o, EventArgs e)
        {

            if (klijentiKontrola.DataGridView.SelectedRows.Count == 1)
            {
                CommonLib.Domen.Klijent st = (CommonLib.Domen.Klijent)klijentiKontrola.DataGridView.SelectedRows[0].DataBoundItem;
                if (Validacija()==false) {
                   
                    
                        MessageBox.Show("Netacno uneti podaci");
                        return;
                    
                    
                }
                st.Ime = klijentiKontrola.DetaljiIme.Text;
                st.Prezime = klijentiKontrola.DetaljiPrezime.Text;
                st.BrojTelefona = klijentiKontrola.DetaljiTelefon.Text;
                st.Imejl= klijentiKontrola.DetaljiImejl.Text;
                
                Odgovor odgovor = Communication.Instance.IzmeniKlijenta(st);
                if (odgovor.Exception == null)
                {

                    klijentiKontrola.DataGridView.DataSource = new BindingList<CommonLib.Domen.Klijent>((List<CommonLib.Domen.Klijent>)Communication.Instance.UcitajListuKlijenata());
                    MessageBox.Show("Sistem je izmenio klijenta", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da izmeni klijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }




        }
        public void ZapamtiKklijenta(Object s, EventArgs eventArgs) {
            CommonLib.Domen.Klijent kl = new CommonLib.Domen.Klijent();
            if (Validacija() == false) {
                MessageBox.Show("Netacno uneti podaci");
            return;
             }
            kl.Ime = klijentiKontrola.DetaljiIme.Text;
            kl.Prezime = klijentiKontrola.DetaljiPrezime.Text;
            kl.BrojTelefona = klijentiKontrola.DetaljiTelefon.Text;
            kl.Imejl = klijentiKontrola.DetaljiImejl.Text;

           Odgovor o= Communication.Instance.ZapamtiKlijenta(kl);
            if (o.Exception==null) {
                MessageBox.Show("Sistem je zapamtio klijenta","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Sistem ne moze da zapamti klijenta", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           // klijentiKontrola.PanelPocetni.Visible = true;
            //klijentiKontrola.Panel.Visible = false;
                //klijentiKontrola.Invoke(new Action(() => {
               // klijentiKontrola.DataGridView.DataSource = null;
                
               // klijentiKontrola.DataGridView.DataSource = new BindingList<CommonLib.Domen.Klijent>((List<CommonLib.Domen.Klijent>)Communication.Instance.ucitajListuKlijenata());
            //}));
            //klijentiKontrola.DataGridView.DataSource = null;
            //klijentiKontrola.DataGridView.DataSource = new BindingList<CommonLib.Domen.Klijent>((List<CommonLib.Domen.Klijent>)Communication.Instance.ucitajListuKlijenata());

        }
        public void SacuvajClick(Object s, EventArgs eventArgs) {
            klijentiKontrola.PanelPocetni.Visible = false;
            klijentiKontrola.Panel.Visible = true;
            klijentiKontrola.DugmeIzmeni.Visible = false;
            klijentiKontrola.DugmeSacuvaj.Visible = true;

        }
        public Control kreirajKontroluKlijenti() { 
        
                klijentiKontrola = new UCKlijenti();
                klijentiKontrola.DugmePretrazi.Click += NadjiKljiente;
                klijentiKontrola.DugmeIzmeni.Click += Izmeni;
                klijentiKontrola.DugmeSacuvaj.Click += ZapamtiKklijenta;
                klijentiKontrola.DugmeDetalji.Click += PrikaziDetalje;
                klijentiKontrola.DugmePovratak.Click += Povratak;
                 klijentiKontrola.DugmeSacuvajClick.Click += SacuvajClick;
                klijentiKontrola.Panel.Visible = false;
                return klijentiKontrola;
        }
    }
}
