using CommonLib.Domen;
using DBBroker;
using Server.SistemskeOperacije;
using Server.SistemskeOperacije.Iznajmljivanje;
using Server.SistemskeOperacije.IznajmljivanjeSO;
using Server.SistemskeOperacije.KlijentSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private DBBrokerBaze broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { broker = new DBBrokerBaze(); }

        public Administrator login(Administrator admin) {

            LoginSO so = new LoginSO(admin);
            so.ExecuteTemplate();
            so.login();
            return so.Result;

        }

        internal List<Naselje> UcitajNaselja()
        {
            UcitajListuNaselja so = new UcitajListuNaselja();
            so.ExecuteTemplate();
            return so.Result;   
        }

        internal void ZapamtiStan(Stan argument)
        {
            ZapamtiStanSO so = new ZapamtiStanSO(argument);
            so.ExecuteTemplate();

        }

        internal List<Stan> NadjiStanove(Stan s)
        {
            NadjiStanoveSO so = new NadjiStanoveSO(s);
            so.ExecuteTemplate();
            return so.Result;   
        }

        internal void IzmeniStan(Stan argument)
        {
           IzmeniStanSO so = new IzmeniStanSO(argument);
            so.ExecuteTemplate();
           
        }

        internal List<Stan> UcitajListuStanova()
        {
            UcitajListuStanovaSO so = new UcitajListuStanovaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void ObrisiStan(Stan argument)
        {
           ObrisiStanSO so= new ObrisiStanSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Klijent> UcitajListuKlijenata()
        {
            UcitajListuKlijenataSO so = new UcitajListuKlijenataSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void ZapamtiKlijenta(Klijent argument)
        {
            ZapamtiKlijentaSO so = new ZapamtiKlijentaSO(argument);
            so.ExecuteTemplate();
            
        }

        internal List<Klijent> NadjiKlijente(Klijent argument)
        {
            NadjiKlijenteSO so = new NadjiKlijenteSO(argument);
            so.ExecuteTemplate();
            return so.Result;
        }
        internal void IzmeniKlijenta(Klijent argument)
        {
            IzmeniKlijentaSO so = new IzmeniKlijentaSO(argument);
            so.ExecuteTemplate();

        }

        internal void ZapamtiIznajmljivanje(Iznajmljivanje argument)
        {
            ZapamtiIznajmljivanje so = new ZapamtiIznajmljivanje(argument);
            so.ExecuteTemplate() ;
        }
        internal List<Iznajmljivanje> UcitajIznajmljivanja()
        {
            UcitajListuIznajmljivanjaSO so = new UcitajListuIznajmljivanjaSO();
            so.ExecuteTemplate();
            return so.Result;
        }
        internal List<Iznajmljivanje> NadjiIznajmljivanje(Iznajmljivanje argument)
        {
            NadjiIznajmljivanjeSO so = new NadjiIznajmljivanjeSO(argument);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void IzmeniIznajmljivanje(Iznajmljivanje argument)
        {
            IzmeniIznajmljivanjeSO so = new IzmeniIznajmljivanjeSO(argument);
            so.ExecuteTemplate();
        }
    }
}
