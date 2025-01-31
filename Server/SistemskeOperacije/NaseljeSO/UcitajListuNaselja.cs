using CommonClases.Domen;
using CommonLib.Domen;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class UcitajListuNaselja : OpstaSistemskaOperacija
    {
        
        private List<Naselje> listaNaselja;
        public List<Naselje> Result { get; set; }
        public UcitajListuNaselja()
        {
            
            
        }
        protected override void ExecuteConcreteOperation()
        {
           List<Naselje> naseljes = new List<Naselje>();
            foreach (GenerickiObjekat n in broker.GetAll(new Naselje())) {
                naseljes.Add((Naselje)n);
            }
          Result= naseljes;
        }
    }
}
