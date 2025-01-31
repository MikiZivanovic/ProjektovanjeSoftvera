using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class ZapamtiStanSO : OpstaSistemskaOperacija
    {
        private Stan stan;
        public ZapamtiStanSO(Stan s)
        {
            stan = s;
        }
        protected override void ExecuteConcreteOperation()
        {
            
            broker.Insert(stan);
        }

    }
}
