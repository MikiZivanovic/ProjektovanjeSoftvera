using CommonClases.Komunikacija;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class ClientHandler
    {
        private Posiljalac posiljalac;
        private Primalac primalac;
        public Socket socket;
        public Administrator admin;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            posiljalac = new Posiljalac(socket);
            primalac= new Primalac(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Zahtev req = (Zahtev)primalac.Prihvati();
                    Odgovor r = ProcessRequest(req);
                    posiljalac.Posalji(r);
                }
            }
            catch (System.IO.IOException exce)
            {
                //Session.administratori.Remove(admin);
                MessageBox.Show("Korisnik je napustio aplikaciju");
                
              
            }
        }

        private Odgovor ProcessRequest(Zahtev req)
        {
            Odgovor r = new Odgovor();
            try
            {
                switch (req.Operacija)
                {
                    case Operacija.LOGIN:
                        Administrator a =Controller.Instance.login((Administrator)req.Argument);
                        r.Result = a;
                        admin = a;
                        Session.administratori.Add(a);
                        break;
                    case Operacija.UCITAJ_LISTU_KLIJENATA:
                        List<Klijent> klijentiLista = Controller.Instance.UcitajListuKlijenata();
                        r.Result = klijentiLista;
                        break;
                    case Operacija.UCITAJ_LISTU_STANOVA:
                        List<Stan> stanoviLista = Controller.Instance.UcitajListuStanova();
                        r.Result = stanoviLista;
                        break;
                    case Operacija.UCITAJ_LISTU_IZNAJMLJIVANJA:
                        List<Iznajmljivanje> iznajmlljivanjeLista = Controller.Instance.UcitajIznajmljivanja();
                        r.Result = iznajmlljivanjeLista;
                        break;
                    case Operacija.ZAPAMTI_KLIJENTA:
                        Controller.Instance.ZapamtiKlijenta((Klijent)req.Argument);
                        break;
                    case Operacija.ZAPAMTI_STAN:
                        Controller.Instance.ZapamtiStan((Stan)req.Argument);
                        break;
                    case Operacija.ZAPAMTI_IZNAJMLJIVANJE:
                        Controller.Instance.ZapamtiIznajmljivanje((Iznajmljivanje)req.Argument);

                        break;
                    case Operacija.PROMENI_KLIJENTA:
                        Controller.Instance.IzmeniKlijenta((Klijent)req.Argument);
                        break;
                    case Operacija.PROMENI_STAN:
                        Controller.Instance.IzmeniStan((Stan)req.Argument);
                        break;
                    case Operacija.PROMENI_IZNAJMLJIVANJE:
                        Controller.Instance.IzmeniIznajmljivanje((Iznajmljivanje)req.Argument);
                        break;
                    case Operacija.OBRISI_STAN:
                        Controller.Instance.ObrisiStan((Stan)req.Argument);
                        break;
                    case Operacija.UCITAJ_LISTU_NASELJA:
                        List<Naselje> naselja = Controller.Instance.UcitajNaselja();
                        r.Result= naselja;
                        break;
                    case Operacija.NADJI_STANOVE:
                        List<Stan> stanovi = Controller.Instance.NadjiStanove((Stan)req.Argument);
                        r.Result= stanovi;  
                        break;
                    case Operacija.NADJI_KLIJENTE:
                        List<Klijent> klijentiPretrazeni = Controller.Instance.NadjiKlijente((Klijent)req.Argument);
                        r.Result = klijentiPretrazeni;
                        break;
                    case Operacija.NADJI_IZNAJMLJIVANJA:
                        List<Iznajmljivanje> nadjiIzna = Controller.Instance.NadjiIznajmljivanje((Iznajmljivanje)req.Argument);
                        r.Result = nadjiIzna;
                        break;
                    case Operacija.PROMENI_ADMINISTRATORA:
                        break;
                }
            }
            catch (Exception ex)
            {
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return r;
        }
    }
}
