using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class UcitajListuKlijenataSO : OpstaSistemskaOperacija
    {
        private List<Klijent> klijenti = new List<Klijent>();

        public List<Klijent> Result { get => klijenti; set => klijenti = value; }
        protected override void ExecuteConcreteOperation()
        {
            foreach (GenerickiObjekat g in broker.GetAll(new Klijent())) {

                klijenti.Add((Klijent)g);
            } 
        }
    }
}
