using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.IznajmljivanjeSO
{
    public class IzmeniIznajmljivanjeSO : OpstaSistemskaOperacija
    {
        private CommonLib.Domen.Iznajmljivanje iznajmljivanje;
        public IzmeniIznajmljivanjeSO(CommonLib.Domen.Iznajmljivanje iznajmljivanje)
        {

            this.iznajmljivanje = iznajmljivanje;

        }

        protected override void ExecuteConcreteOperation()
        {
            
            broker.Update(iznajmljivanje);
            StavkaIznajmljivanja stavka = new StavkaIznajmljivanja();
            List<CommonLib.Domen.StavkaIznajmljivanja> sveStavke = new List<CommonLib.Domen.StavkaIznajmljivanja>();
            stavka.Iznajmljivanje = iznajmljivanje;
            List<GenerickiObjekat> objektiStavki = broker.GetAll(stavka);
            foreach (GenerickiObjekat l in objektiStavki)
            {
                sveStavke.Add((CommonLib.Domen.StavkaIznajmljivanja)l);

            }
            foreach (StavkaIznajmljivanja s in sveStavke)
            {
                broker.Delete(s);
            }
            foreach (StavkaIznajmljivanja s in iznajmljivanje.StavkeIznajmljivanja) {
                broker.Insert(s);
            }

        }
    }
}
