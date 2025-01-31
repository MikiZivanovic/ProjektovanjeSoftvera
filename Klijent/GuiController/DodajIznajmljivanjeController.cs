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
    public class DodajIznajmljivanjeController
    {

        private UCDodajIznajmljivanje kontrolaIznajmljivanje;
        private BindingList<StavkaIznajmljivanja> stavke =  new BindingList<StavkaIznajmljivanja>();
        public static BindingList<Stan> stanovi = new BindingList<Stan>();
        private int RBR = 0;
        double  UkupanIznos = 0;

        public Control kreirajKontroluDodajIznajmljivanje() {
            stanovi = new BindingList<Stan>(((List<Stan>)Communication.Instance.UcitajListuStanova()).Where(s => s.Iznajmljen == false).ToList()) ;
           // kontrolaIznajmljivanje.DataGridView.DataSource = stavke;
            kontrolaIznajmljivanje = new UCDodajIznajmljivanje();
           
            kontrolaIznajmljivanje.DugmeIzvrsiIzmenu.Visible = false;
            kontrolaIznajmljivanje.DugmeSacuvajIznaj.Click += sacuvajIznajmljivanje;
            kontrolaIznajmljivanje.DugmeDodajjStavku.Click += dodajStavku;
            kontrolaIznajmljivanje.DugmeObrisi.Click += obrisiStavku;
            kontrolaIznajmljivanje.DugmeIzmeni.Click += IzmeniStavku;
            kontrolaIznajmljivanje.DugmeIzvrsiIzmenu.Click += izvrsiIzmenuStavke;
            kontrolaIznajmljivanje.DugmePretrazi.Click += pretraziIznajmljivanja;
            kontrolaIznajmljivanje.DugmeDetalji.Click += detaljiIznajmljivanja;
            kontrolaIznajmljivanje.DugmeIzmeniIznajmljivanje.Click += izmeniIznajmljivanje;
            kontrolaIznajmljivanje.DugmePOvratak.Click += povratak;
            kontrolaIznajmljivanje.Panel.Visible = false;
            kontrolaIznajmljivanje.DugmeSacuvajClick.Click += sacuvajIzmeniPrikaz;
            kontrolaIznajmljivanje.DugmeIzmeniClick.Click += detaljiIznajmljivanja;
            kontrolaIznajmljivanje.DataGridView.DataSource = new BindingList<StavkaIznajmljivanja>();
            kontrolaIznajmljivanje.DataGridView.AutoGenerateColumns = false;
            kontrolaIznajmljivanje.DataGridView.Columns.RemoveAt(0);
            return kontrolaIznajmljivanje;
        
        
        }
        public void sacuvajIzmeniPrikaz(Object o, EventArgs e) {
            kontrolaIznajmljivanje.PanelPocetni.Visible = false;
            kontrolaIznajmljivanje.Panel.Visible = true;
            kontrolaIznajmljivanje.DugmeIzmeniIznajmljivanje.Visible = false;
        }
        public void povratak(Object sender, EventArgs eventArgs)
        {
            kontrolaIznajmljivanje.PanelPocetni.Visible = true;
            kontrolaIznajmljivanje.Panel.Visible = false;

        }
        private int maxRedniBrorjStavki()
        {
            int br = int.MinValue;
            if (stavke.Count==0) {
                br = 0;
                return br;
            } 
            foreach (StavkaIznajmljivanja s in stavke) {

                if (s.RedniBroj > br) { 
                br = s.RedniBroj;}
            }
            return br;

        }
        private bool Validacija() {

            if (DateTime.TryParse(kontrolaIznajmljivanje.PoleDatumDo.Text,out DateTime r)==false  ) { 
                return false;
            }
            return true;
        
        }
        public void dodajStavku(Object sender,EventArgs eventArgs) { 
        
             StavkaIznajmljivanja st=  new StavkaIznajmljivanja();
            if (Validacija() == false) {
                MessageBox.Show("Morate uneti datum u formatu mesec dan godina");
                return;
            }
                
             st.RedniBroj = maxRedniBrorjStavki()+1;

            st.Stan = (Stan)kontrolaIznajmljivanje.PoleStan.SelectedItem;
             st.DatumDo = DateTime.Parse( kontrolaIznajmljivanje.PoleDatumDo.Text);
             double cenaStavke = st.DatumDo.Subtract(DateTime.Parse(kontrolaIznajmljivanje.PoljeDatumOd.Text)).Days*st.Stan.CenaPoDanu;
             UkupanIznos += cenaStavke;
             st.CenaStavke = cenaStavke;
             
             kontrolaIznajmljivanje.LabelaVrednostUkupanIznos.Text = UkupanIznos.ToString();
             kontrolaIznajmljivanje.PoleStan.SelectedIndex = 0;  
             kontrolaIznajmljivanje.PoleDatumDo.Text = "";
             stavke.Add(st);
            
            kontrolaIznajmljivanje.DataGridView.DataSource = stavke;
           


        }
        public void obrisiStavku(Object sender, EventArgs eventArgs)
        {
            if (kontrolaIznajmljivanje.DataGridView.SelectedRows.Count == 1)
            {
                StavkaIznajmljivanja st = (StavkaIznajmljivanja)kontrolaIznajmljivanje.DataGridView.SelectedRows[0].DataBoundItem;
               
               
              
                UkupanIznos = UkupanIznos - st.CenaStavke;
                kontrolaIznajmljivanje.LabelaVrednostUkupanIznos.Text = UkupanIznos.ToString();
                stavke.Remove(st);
                kontrolaIznajmljivanje.DataGridView.DataSource = null;
                kontrolaIznajmljivanje.DataGridView.DataSource = stavke;

            }


        }
        public void IzmeniStavku(Object sender, EventArgs eventArgs) {

            if (kontrolaIznajmljivanje.DataGridView.SelectedRows.Count == 1)
            {
                
                kontrolaIznajmljivanje.DugmeIzvrsiIzmenu.Visible = true;
                StavkaIznajmljivanja st = (StavkaIznajmljivanja)kontrolaIznajmljivanje.DataGridView.SelectedRows[0].DataBoundItem;
                kontrolaIznajmljivanje.PoleStan.SelectedItem = st.Stan;
                kontrolaIznajmljivanje.PoleDatumDo.Text = st.DatumDo.ToString();
               

            }


        }
        public void izvrsiIzmenuStavke(Object sender, EventArgs eventArgs)
        {
            StavkaIznajmljivanja st = (StavkaIznajmljivanja)kontrolaIznajmljivanje.DataGridView.SelectedRows[0].DataBoundItem;
            if (Validacija() == false) {
                MessageBox.Show("Morate unerti datum u formatu mesec dan godina");
                return;
            }
            st.Stan = (Stan)kontrolaIznajmljivanje.PoleStan.SelectedItem;
            st.DatumDo = DateTime.Parse(kontrolaIznajmljivanje.PoleDatumDo.Text);
            
            UkupanIznos = 0;
            foreach (StavkaIznajmljivanja s in stavke) {
                double cenaStavke = s.DatumDo.Subtract(DateTime.Parse(kontrolaIznajmljivanje.PoljeDatumOd.Text)).Days * s.Stan.CenaPoDanu;
                UkupanIznos += cenaStavke;  
            }
             kontrolaIznajmljivanje.DataGridView.DataSource = null;
             kontrolaIznajmljivanje.DataGridView.DataSource =stavke;
             kontrolaIznajmljivanje.LabelaVrednostUkupanIznos.Text = UkupanIznos.ToString();

        }

        public void sacuvajIznajmljivanje(Object sender,EventArgs e) {
            if (DateTime.TryParse(kontrolaIznajmljivanje.PoljeDatumOd.Text, out DateTime r) == false)
            {
                MessageBox.Show("Morate uneti datum u formatu mesec dan godina");
                return ;
            }
            Iznajmljivanje i = new Iznajmljivanje();
                 i.DatumOd = DateTime.Parse( kontrolaIznajmljivanje.PoljeDatumOd.Text);
                 i.Klijent = (CommonLib.Domen.Klijent)kontrolaIznajmljivanje.CMBKlijenti.SelectedItem;
                 i.StavkeIznajmljivanja = stavke.ToList();
                 i.UkupanIznos = UkupanIznos;
                foreach (StavkaIznajmljivanja s in stavke) {
                s.Iznajmljivanje = i;
                }
                Odgovor odgovor = Communication.Instance.ZapamtiIznajmljivanje(i);
                if (odgovor.Exception == null)
                {
                    kontrolaIznajmljivanje.DataGridViewIznajmljivanja.DataSource = null;
                    kontrolaIznajmljivanje.DataGridViewIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>((List<Iznajmljivanje>)Communication.Instance.UcitajListuIznajmljivanja());
                    stavke = new BindingList<StavkaIznajmljivanja>();
                    UkupanIznos = 0;
                    kontrolaIznajmljivanje.LabelaVrednostUkupanIznos.Text = UkupanIznos.ToString();
                MessageBox.Show("Sistem je zapamtio iznajmljivanje","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
               

                }
                else
                {
                MessageBox.Show("Sistem ne moze da zapamti iznajmljivanje", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            




        }
        public void pretraziIznajmljivanja(Object sender, EventArgs e)
        {

            Iznajmljivanje i = new Iznajmljivanje();
            i.Klijent = new CommonLib.Domen.Klijent();
            i.Klijent.Ime = kontrolaIznajmljivanje.PoljePretraga.Text;
            
            Odgovor odgovor = Communication.Instance.NadjiIznajmljivanje(i);
            if (odgovor.Exception == null)
            {
               
                kontrolaIznajmljivanje.DataGridViewIznajmljivanja.DataSource = null;
                kontrolaIznajmljivanje.DataGridViewIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>((List<Iznajmljivanje>)odgovor.Result);
                MessageBox.Show("Sistem je nasao iznajmljivanja po zadatoj vrednosti", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da nadje iznajmljivanje po zadatoj vrednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        public void detaljiIznajmljivanja(Object sender, EventArgs e)
        {


            if (kontrolaIznajmljivanje.DataGridViewIznajmljivanja.SelectedRows.Count == 1)
            {
                kontrolaIznajmljivanje.Panel.Visible = true;
                kontrolaIznajmljivanje.PanelPocetni.Visible = false;
                
                Iznajmljivanje iznajmljivanjeZaPrikaz = (Iznajmljivanje)kontrolaIznajmljivanje.DataGridViewIznajmljivanja.SelectedRows[0].DataBoundItem;
                Odgovor odgovor = Communication.Instance.NadjiIznajmljivanje(iznajmljivanjeZaPrikaz);
                if (odgovor.Exception == null)
                {

                    CommonLib.Domen.Iznajmljivanje kl = ((List<CommonLib.Domen.Iznajmljivanje>)odgovor.Result)[0];
                    kontrolaIznajmljivanje.PoljeDatumOd.Text = kl.DatumOd.ToString();
                    kontrolaIznajmljivanje.CMBKlijenti.SelectedItem = kl.Klijent;
                    kontrolaIznajmljivanje.LabelaVrednostUkupanIznos.Text = kl.UkupanIznos.ToString();
                    kontrolaIznajmljivanje.DataGridView.DataSource = new BindingList<StavkaIznajmljivanja>(kl.StavkeIznajmljivanja);
                    stavke = new BindingList<StavkaIznajmljivanja>(kl.StavkeIznajmljivanja);
                    UkupanIznos = kl.UkupanIznos;

                    MessageBox.Show("Sistem je ucitao iznajmljivanje", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita iznanjmljivanje", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else {
                MessageBox.Show("Morate odabrati tacnojedno iznajmljivanje iz tabele");
            }
            


        }
        public void izmeniIznajmljivanje(Object sender, EventArgs e)
        {
            if (DateTime.TryParse(kontrolaIznajmljivanje.PoljeDatumOd.Text, out DateTime r) == false)
            {
                MessageBox.Show("Morate uneti datum u formatu mesec dan godina");
                return;
            }
            Iznajmljivanje i = (Iznajmljivanje)kontrolaIznajmljivanje.DataGridViewIznajmljivanja.SelectedRows[0].DataBoundItem;
            i.DatumOd = DateTime.Parse(kontrolaIznajmljivanje.PoljeDatumOd.Text);
            i.Klijent = (CommonLib.Domen.Klijent)kontrolaIznajmljivanje.CMBKlijenti.SelectedItem;
            foreach (StavkaIznajmljivanja st in stavke) {
                st.Iznajmljivanje = i;
            }
            i.StavkeIznajmljivanja = stavke.ToList();
            i.UkupanIznos = UkupanIznos;
            
            Odgovor odgovor = Communication.Instance.IzmeniIznajmljivanje(i);

            if (odgovor.Exception == null)
            {
                kontrolaIznajmljivanje.DataGridViewIznajmljivanja.DataSource = null;
                kontrolaIznajmljivanje.DataGridViewIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>((List<Iznajmljivanje>)Communication.Instance.UcitajListuIznajmljivanja());
                MessageBox.Show("Sistem je izmenio iznajmljivanje", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Sistem ne moze da izmeni iznanjmljivanje", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        
     
        public void izmeniClick(Object sender,EventArgs eventArgs) {

            kontrolaIznajmljivanje.PanelPocetni.Visible = false;
            kontrolaIznajmljivanje.Panel.Visible = true;


        }


    }
}
