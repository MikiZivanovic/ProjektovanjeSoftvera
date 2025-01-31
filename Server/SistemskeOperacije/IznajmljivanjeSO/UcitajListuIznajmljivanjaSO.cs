using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    internal class UcitajListuIznajmljivanjaSO : OpstaSistemskaOperacija
    {
        private List<CommonLib.Domen.Iznajmljivanje> iznajmljivanja;
        private List<CommonLib.Domen.Iznajmljivanje> listaIznajmljivanja= new List<CommonLib.Domen.Iznajmljivanje>();
        public List<CommonLib.Domen.Iznajmljivanje> Result { get=> listaIznajmljivanja; set=>listaIznajmljivanja=value; }
        public UcitajListuIznajmljivanjaSO()
        {
            
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach (GenerickiObjekat g in broker.GetAll(new CommonLib.Domen.Iznajmljivanje()))
            {

                listaIznajmljivanja.Add((CommonLib.Domen.Iznajmljivanje)g);
            }
        }
    }
}
