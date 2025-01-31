using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class ObrisiStanSO : OpstaSistemskaOperacija
    {
        private Stan stan;
        public ObrisiStanSO(Stan s)
        {
            stan = s;
        }
        protected override void ExecuteConcreteOperation()
        {
            
            broker.Delete(stan);
        }
    }
}
