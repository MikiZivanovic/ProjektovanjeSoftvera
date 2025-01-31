using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class ZapamtiKlijentaSO : OpstaSistemskaOperacija
    {
        private Klijent klijent;
        public ZapamtiKlijentaSO(Klijent k)
        {
            klijent = k;
        }
        protected override void ExecuteConcreteOperation()
        {
            
            broker.Insert(klijent);
           
        }
    }
}
