using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.Iznajmljivanje
{
    internal class NadjiIznajmljivanjeSO : OpstaSistemskaOperacija
    {
        private CommonLib.Domen.Iznajmljivanje iznajmljivanje;
        private List<CommonLib.Domen.Iznajmljivanje> listaIznajmljivanja = new List<CommonLib.Domen.Iznajmljivanje>();
        public List<CommonLib.Domen.Iznajmljivanje> Result { get => listaIznajmljivanja; set => listaIznajmljivanja = value; }
        public NadjiIznajmljivanjeSO(CommonLib.Domen.Iznajmljivanje iznajmljivanje)
        {

            this.iznajmljivanje = iznajmljivanje;

        }

        protected override void ExecuteConcreteOperation()
        {
            List<CommonLib.Domen.Iznajmljivanje> svaIznajmljivanja = new List<CommonLib.Domen.Iznajmljivanje>();
            List<CommonLib.Domen.StavkaIznajmljivanja> sveStavke = new List<CommonLib.Domen.StavkaIznajmljivanja>();
            List<GenerickiObjekat> objekti = broker.GetAll(new CommonLib.Domen.Iznajmljivanje());
            foreach (GenerickiObjekat g in objekti)
            {
                svaIznajmljivanja.Add((CommonLib.Domen.Iznajmljivanje)g);

            }
            

            foreach (CommonLib.Domen.Iznajmljivanje s in svaIznajmljivanja)
            {
                if (iznajmljivanje.Id != 0 && s.Id == iznajmljivanje.Id)
                {
                    StavkaIznajmljivanja stavka = new StavkaIznajmljivanja();
                    stavka.Iznajmljivanje = s;
                    List<GenerickiObjekat> objektiStavki = broker.GetAll(stavka);
                    foreach (GenerickiObjekat l in objektiStavki)
                    {
                        sveStavke.Add((CommonLib.Domen.StavkaIznajmljivanja)l);

                    }

                    s.StavkeIznajmljivanja = sveStavke;



                    listaIznajmljivanja.Clear();
                    listaIznajmljivanja.Add(s);
                    break;
                }
                if (s.Klijent.Ime.ToLower().Contains(iznajmljivanje.Klijent.Ime.ToLower()) && iznajmljivanje.Id ==0)
                {
                   

                    listaIznajmljivanja.Add(s);

                }

            }
            if (listaIznajmljivanja.Count == 0)
            {
                throw new Exception("Nije moguce pronaci iznajmljivanje/a sa zadatim vrednostima");
            }
        }
    }
}
