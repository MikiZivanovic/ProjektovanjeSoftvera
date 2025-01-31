using CommonClases.Komunikacija;
using CommonLib.Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class StanoviController
    {
        private UCStanovi kontrolaStanovi;

        

        public void povratak(Object sender, EventArgs eventArgs)
        {
            kontrolaStanovi.PanelPocetni.Visible = true;
            kontrolaStanovi.Panel.Visible = false;

        }
        public void sacuvajClick(Object sender, EventArgs eventArgs)
        {
            kontrolaStanovi.PanelPocetni.Visible = false;
            kontrolaStanovi.Panel.Visible = true;
            kontrolaStanovi.DugmeIzvrsiIzmenu.Visible = false;

        }
        public void pretrazi(Object s,EventArgs e)
        {
            Stan stan = new Stan();
            stan.Kvadratura = (int.TryParse(kontrolaStanovi.KvadraturaDo.Text,out int se))?int.Parse(kontrolaStanovi.KvadraturaDo.Text):0;
            stan.BrojSoba = (int.TryParse(kontrolaStanovi.BrojSoba.Text, out int set)) ? int.Parse(kontrolaStanovi.BrojSoba.Text) : 0;
            
            stan.CenaPoDanu = 1.0;
            Odgovor o = Communication.Instance.PretrazStanove(stan);

            if (o.Exception == null)
            {

                kontrolaStanovi.DataGridView.DataSource = null;
                kontrolaStanovi.DataGridView.DataSource = (List<Stan>)o.Result;

                MessageBox.Show("Sistem je nasao stanove po zadatoj vrednosti", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Sistem ne moze da nadje stan po zadatoj vrednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void prikaziDetalje(Object s, EventArgs e)
        {

            if (kontrolaStanovi.DataGridView.SelectedRows.Count == 1) {
                kontrolaStanovi.PanelPocetni.Visible = false ;
                kontrolaStanovi.Panel.Visible = true;
                kontrolaStanovi.DugmeIzvrsiIzmenu.Visible = true;
                kontrolaStanovi.DugmeSacuvajStan.Visible = false;
                Stan stanZaPrikaz= (Stan)kontrolaStanovi.DataGridView.SelectedRows[0].DataBoundItem;
                Odgovor odgovor = Communication.Instance.PretrazStanove(stanZaPrikaz);
                if (odgovor.Exception == null)
                {

                    Stan st = ((List<Stan>)odgovor.Result)[0];
                       kontrolaStanovi.StanKvadratura.Text = st.Kvadratura.ToString();
                       kontrolaStanovi.StanBrojSoba.Text= st.BrojSoba.ToString();
                       kontrolaStanovi.StanCenaPoDanu.Text = st.CenaPoDanu.ToString();
                       kontrolaStanovi.StanIznajmljen.Checked  = st.Iznajmljen;
                       kontrolaStanovi.StanKlima.Checked  = st.Klima;
                       kontrolaStanovi.StanNaselje.SelectedItem= st.Naselje;

                    MessageBox.Show("Sistem je ucitao stan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita stan", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                
            }
        }
        public void izbrisiOdabranog(Object s, EventArgs e)
        {

            if (kontrolaStanovi.DataGridView.SelectedRows.Count == 1)
            {
                Stan stanZaBrisanje = (Stan)kontrolaStanovi.DataGridView.SelectedRows[0].DataBoundItem;
                Odgovor odgovor = Communication.Instance.ObrisiStan(stanZaBrisanje);
                if (odgovor.Exception == null)
                {

                    kontrolaStanovi.DataGridView.DataSource = new BindingList<Stan>((List<Stan>)Communication.Instance.UcitajListuStanova());
                    MessageBox.Show("Sistem je izbrisao podatke o stanu", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da izbrise podatke o stanu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
        private bool Validacija() {
            if (string.IsNullOrEmpty(kontrolaStanovi.StanKvadratura.Text) || kontrolaStanovi.StanKvadratura.Text.All(char.IsNumber) == false|| string.IsNullOrEmpty(kontrolaStanovi.StanBrojSoba.Text) || kontrolaStanovi.StanBrojSoba.Text.All(char.IsNumber) == false) {
                return false;
            
            }


            return true;
        }
        public void dodajStan(Object s, EventArgs e)
        {
            Stan st = new Stan();
            if (Validacija()==false)
            {
                MessageBox.Show("Netacno uneti podaci");
                return;

            }
            st.Kvadratura = int.Parse(kontrolaStanovi.StanKvadratura.Text);
            st.BrojSoba = int.Parse(kontrolaStanovi.StanBrojSoba.Text);
            st.CenaPoDanu = float.Parse(kontrolaStanovi.StanCenaPoDanu.Text);
            st.Iznajmljen = (kontrolaStanovi.StanIznajmljen.Checked) ? true : false;
            st.Klima = (kontrolaStanovi.StanKlima.Checked) ? true : false;
            st.Naselje = (Naselje)kontrolaStanovi.StanNaselje.SelectedItem;
            Odgovor odgovor = Communication.Instance.ZapamtiStan(st);
            if (odgovor.Exception == null)
            {
                kontrolaStanovi.DataGridView.DataSource = new BindingList<Stan>((List<Stan>)Communication.Instance.UcitajListuStanova());
               
                MessageBox.Show("Sistem je zapamtio stan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti stan", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Izmeni(Object o,EventArgs e) {

            if (kontrolaStanovi.DataGridView.SelectedRows.Count == 1)
            {
                Stan st = (Stan)kontrolaStanovi.DataGridView.SelectedRows[0].DataBoundItem;
                if (Validacija() == false)
                {
                    MessageBox.Show("Netacno uneti podaci");
                    return;

                }
                st.Kvadratura=int.Parse( kontrolaStanovi.StanKvadratura.Text);
                st.BrojSoba= int.Parse(kontrolaStanovi.StanBrojSoba.Text); 
                st.CenaPoDanu= float.Parse(kontrolaStanovi.StanCenaPoDanu.Text);
                st.Iznajmljen=  kontrolaStanovi.StanIznajmljen.Checked;
                st.Klima=  kontrolaStanovi.StanKlima.Checked;
                st.Naselje= (Naselje)kontrolaStanovi.StanNaselje.SelectedItem;
                Odgovor odgovor = Communication.Instance.IzmeniStan(st);
                if (odgovor.Exception == null)
                {

                    kontrolaStanovi.DataGridView.DataSource = new BindingList<Stan>((List<Stan>)Communication.Instance.UcitajListuStanova());
                    
                    MessageBox.Show("Sistem je izmenio stan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da izmeni stan", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
          
            


        }

        internal Control kreirajKontroluStanovi()
        {
            kontrolaStanovi = new UCStanovi();
            kontrolaStanovi.Button.Click += pretrazi;
            kontrolaStanovi.ButtPrikaziDetalje.Click += prikaziDetalje;
            kontrolaStanovi.DugmeIzvrsiIzmenu.Click += Izmeni;
            kontrolaStanovi.DugmeZaBrisanje.Click += izbrisiOdabranog;
            kontrolaStanovi.DugmePovratak.Click += povratak;
            kontrolaStanovi.DugmeSacuvajClick.Click += sacuvajClick;
            kontrolaStanovi.DugmeSacuvajStan.Click += dodajStan;
            kontrolaStanovi.Panel.Visible = false;

            return kontrolaStanovi;

        }
       
    }
}
