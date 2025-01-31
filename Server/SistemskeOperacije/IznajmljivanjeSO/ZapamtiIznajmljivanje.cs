using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class ZapamtiIznajmljivanje : OpstaSistemskaOperacija
    {
        private CommonLib.Domen.Iznajmljivanje iznajmljivanje;
        public ZapamtiIznajmljivanje(CommonLib.Domen.Iznajmljivanje i)
        {
            iznajmljivanje = i;
        }
        protected override void ExecuteConcreteOperation()
        {
           
            int id =broker.Insert(iznajmljivanje);
            
            foreach (StavkaIznajmljivanja  s in iznajmljivanje.StavkeIznajmljivanja) {
                s.Iznajmljivanje.Id = id;
                broker.Insert(s);
            }
        }
    }
}
