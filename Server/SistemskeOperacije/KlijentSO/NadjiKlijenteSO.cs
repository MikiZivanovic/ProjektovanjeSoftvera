using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    internal class NadjiKlijenteSO : OpstaSistemskaOperacija
    {
        private Klijent klijent;
        private List<Klijent> klijenti= new List<Klijent>();
        public List<Klijent> Result { get => klijenti; }
        public NadjiKlijenteSO(Klijent k)
        {
            klijent = k;
        

        }

        protected override void ExecuteConcreteOperation()
        {
            List<Klijent> sviKlijenti= new List<Klijent>();
            List<GenerickiObjekat> objekti = broker.GetAll(new Klijent());
            foreach (GenerickiObjekat g in objekti)
            {
                sviKlijenti.Add((Klijent)g);

            }

            foreach (Klijent s in sviKlijenti)
            {
                if (klijent.Id != 0 && s.Id == klijent.Id)
                {
                    klijenti.Clear();
                    klijenti.Add(s);
                    break;
                }
                if (s.Ime.ToLower().Contains(klijent.Ime.ToLower()) && klijent.Id==0)
                {
                   

                    klijenti.Add(s);

                }

            }
            if (klijenti.Count == 0) {
                throw new Exception("Nije moguce pronaci klijente/a sa zadatim vrednostima");
            }
        }
    }
}
