using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.KlijentSO
{
    internal class IzmeniKlijentaSO : OpstaSistemskaOperacija
    {
        private Klijent klijent;
        public IzmeniKlijentaSO(Klijent k)
        {
            klijent = k;    
        }
        protected override void ExecuteConcreteOperation()
        {
            
            broker.Update(klijent);
        }
    }
}
