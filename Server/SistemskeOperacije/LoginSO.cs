using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    internal class LoginSO : OpstaSistemskaOperacija
    {
        private readonly Administrator user;
        public Administrator Result { get; set; }
        private List<Administrator> listaAdministratora= new List<Administrator>();
        public LoginSO(Administrator user)
        {
            this.user = user;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach (Administrator g in broker.GetAll(user))
            {
                listaAdministratora.Add(g);
            }
        }
        public void login()
        {
            Result = null;
            foreach (Administrator adm in listaAdministratora)
            {
                if (adm.KrisnickoIme == user.KrisnickoIme && adm.Lozinka == user.Lozinka)
                {
                    Result = adm;
                }
            }
            if (Result==null) { throw new Exception("Nema datog administratora u bazi"); }
        }

    }
}