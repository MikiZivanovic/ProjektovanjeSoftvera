using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class UcitajListuStanovaSO : OpstaSistemskaOperacija
    {
        private List<Stan> stanovi;
        
        public List<Stan> Result { get; set; }
        public UcitajListuStanovaSO()
        {
          
        }
        protected override void ExecuteConcreteOperation()
        {
            List<Stan> stans = new List<Stan>();
            foreach (GenerickiObjekat n in broker.GetAll(new Stan()))
            {
                stans.Add((Stan)n);
            }
            Result = stans;
        }
    }
}
