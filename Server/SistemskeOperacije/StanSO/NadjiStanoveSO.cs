using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class NadjiStanoveSO : OpstaSistemskaOperacija
    {
        private  List<Stan> listaStanova =  new List<Stan>();
        public List<Stan> Result { get { return listaStanova; } }
        private Stan stan;
        public NadjiStanoveSO(Stan stan)
        {
            this.stan = stan;
        }
        protected override void ExecuteConcreteOperation()
        {
            
            List<Stan> sviStanovi = new List<Stan>();
            List<GenerickiObjekat> objekti = broker.GetAll(new Stan());
            foreach (GenerickiObjekat g in objekti) {
                sviStanovi.Add((Stan)g);
                
            }

            foreach (Stan s in sviStanovi) {
                if (stan.Id != 0 && s.Id == stan.Id)
                {
                    listaStanova.Clear();
                    listaStanova.Add(s);
                    break;
                }
                if (stan.Kvadratura == 0 && stan.BrojSoba != 0  && s.BrojSoba == stan.BrojSoba)
                {


                    listaStanova.Add(s);

                }
                if (stan.Kvadratura != 0 && stan.BrojSoba == 0 && s.Kvadratura <= stan.Kvadratura )
                {


                    listaStanova.Add(s);

                }
                if (stan.Kvadratura!=0 && stan.BrojSoba!=0 &&   s.Kvadratura <= stan.Kvadratura && s.BrojSoba == stan.BrojSoba ) {
                    
                    
                    listaStanova.Add(s);
                    
                }
               
            }
            if(listaStanova.Count == 0)
            {
                throw new Exception("Nema stanova koji zadovoljavaju kriterijume");
            }

        }
    }
}
