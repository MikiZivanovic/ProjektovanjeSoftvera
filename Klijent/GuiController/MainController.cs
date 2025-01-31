using CommonLib.Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.GuiController
{
    public class MainController
    {
        private static MainController instance;
        public static MainController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainController();
                }
                return instance;
            }
        }
        public FRMMain mainForma;
        private DodajStanController kontrolerDodajStan;
        private StanoviController stanoviController;
        private KlijentiController klijentiController;
        private DodajIznajmljivanjeController kontrolerIznajmljivanje;

        private MainController()
        {

            kontrolerDodajStan = new DodajStanController();
            stanoviController = new StanoviController();
            klijentiController = new KlijentiController();
            kontrolerIznajmljivanje = new DodajIznajmljivanjeController();
        }
        public void show(Administrator administrator) {
            mainForma = new FRMMain();
            UCMain kontrolaMain = new UCMain();
            kontrolaMain.LabelZaImeAdmina.Text ="Dobrodosli "+ administrator.Ime;
            mainForma.AutoSize = true;
            mainForma.promeniControlu(kontrolaMain);
            mainForma.Show();

        }
        public void prikaziKreirajStanControlu() {
            mainForma.promeniControlu(kontrolerDodajStan.kreirajKontrolu());
            
        }
        public void prikaziKreirajControluStanovi()
        {
            mainForma.promeniControlu(stanoviController.kreirajKontroluStanovi());

        }
        public void prikaziKreirajControluKlijenti()
        {
            mainForma.promeniControlu(klijentiController.kreirajKontroluKlijenti());

        }

        internal void prikaziKreirajControluInzajmljivanje()
        {
            mainForma.promeniControlu(kontrolerIznajmljivanje.kreirajKontroluDodajIznajmljivanje());
        }
    }
}
