using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class IzmeniStanSO : OpstaSistemskaOperacija
    {
        private Stan stan;
        public Stan Result { get => stan; set => stan = value; }
        public IzmeniStanSO(Stan stan)
        {
            this.stan = stan;

           

        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(this.stan);   
        }
    }
}
