using CommonClases.Komunikacija;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Communication
    {

        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication()
        {

        }

        Socket socket;
        Posiljalac sender;
        Primalac receiver;

        public bool Connect()
        {
            try
            {

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                sender = new Posiljalac(socket);
                receiver = new Primalac(socket);
                return true;
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>nije upaljen server>>>" + se.ToString());
                return false;
            }

        }

        internal Odgovor Login(CommonLib.Domen.Administrator user)
        {
            Zahtev req = new Zahtev
            {
                Argument = user,
                Operacija = Operacija.LOGIN
            };
            sender.Posalji(req);
            Odgovor response = (Odgovor)receiver.Prihvati();
            return response;
        }
        public object UcitajListuNaselja() {

            Zahtev z = new Zahtev { Operacija = Operacija.UCITAJ_LISTU_NASELJA };
            sender.Posalji(z);

            Odgovor odgovor = (Odgovor)receiver.Prihvati();

            return odgovor.Result;
        }

        internal Odgovor ZapamtiStan(Stan stan)
        {
            Zahtev z = new Zahtev
            {
                Argument = stan,
                Operacija = Operacija.ZAPAMTI_STAN
            };
            sender.Posalji(z);
            Odgovor response = (Odgovor)receiver.Prihvati();
            return response;
        }

        internal Odgovor PretrazStanove(Stan stan)
        {
            Zahtev z = new Zahtev
            {
                Argument = stan,
                Operacija = Operacija.NADJI_STANOVE
            };
            sender.Posalji(z);  
            Odgovor odgovor= (Odgovor)receiver.Prihvati();
            return odgovor;
        }

        internal object UcitajListuStanova()
        {
            Zahtev z = new Zahtev { Operacija = Operacija.UCITAJ_LISTU_STANOVA };
            sender.Posalji(z);

            Odgovor odgovor = (Odgovor)receiver.Prihvati();

            return odgovor.Result;
        }

        internal Odgovor IzmeniStan(Stan st)
        {
            Zahtev z = new Zahtev
            {
                Argument = st,
                Operacija = Operacija.PROMENI_STAN
            };
            sender.Posalji(z);
            Odgovor response = (Odgovor)receiver.Prihvati();
            return response;
        }

        internal Odgovor ObrisiStan(Stan stanZaBrisanje)
        {
            Zahtev z = new Zahtev
            {
                Argument = stanZaBrisanje,
                Operacija = Operacija.OBRISI_STAN
            };
            sender.Posalji(z);
            Odgovor response = (Odgovor)receiver.Prihvati();
            return response;
        }

        internal Object UcitajListuKlijenata()
        {
            Zahtev z = new Zahtev { Operacija = Operacija.UCITAJ_LISTU_KLIJENATA };
            sender.Posalji(z);

            Odgovor odgovor = (Odgovor)receiver.Prihvati();

            return odgovor.Result;
        }

        internal Odgovor PretraziKlijente(CommonLib.Domen.Klijent k)
        {
            Zahtev z = new Zahtev
            {
                Argument = k,
                Operacija = Operacija.NADJI_KLIJENTE
            };
            sender.Posalji(z);
            Odgovor odgovor = (Odgovor)receiver.Prihvati();
            return odgovor;

        }

        internal Odgovor ZapamtiKlijenta(CommonLib.Domen.Klijent k)
        {
            Zahtev z = new Zahtev
            {
                Argument = k,
                Operacija = Operacija.ZAPAMTI_KLIJENTA
            };
            sender.Posalji(z);
            Odgovor response = (Odgovor)receiver.Prihvati();
            return response;

        }

        internal Odgovor IzmeniKlijenta(CommonLib.Domen.Klijent st)
        {
            Zahtev z = new Zahtev
            {
                Argument = st,
                Operacija = Operacija.PROMENI_KLIJENTA
            };
            sender.Posalji(z);
            Odgovor response = (Odgovor)receiver.Prihvati();
            return response;
        }
        internal Odgovor NadjiIznajmljivanje(Iznajmljivanje i)
        {
            Zahtev z = new Zahtev
            {
                Argument = i,
                Operacija = Operacija.NADJI_IZNAJMLJIVANJA
            };
            sender.Posalji(z);
            Odgovor odgovor = (Odgovor)receiver.Prihvati();
            return odgovor;
        }
        internal Odgovor ZapamtiIznajmljivanje(Iznajmljivanje i)
        {
            Zahtev z = new Zahtev
            {
                Argument = i,
                Operacija = Operacija.ZAPAMTI_IZNAJMLJIVANJE
            };
            sender.Posalji(z);
            Odgovor odgovor = (Odgovor)receiver.Prihvati();
            return odgovor;
        }
        internal Odgovor IzmeniIznajmljivanje(Iznajmljivanje i)
        {
            Zahtev z = new Zahtev
            {
                Argument = i,
                Operacija = Operacija.PROMENI_IZNAJMLJIVANJE
            };
            sender.Posalji(z);
            Odgovor odgovor = (Odgovor)receiver.Prihvati();
            return odgovor;
        }
        internal Object UcitajListuIznajmljivanja()
        {
            Zahtev z = new Zahtev { Operacija = Operacija.UCITAJ_LISTU_IZNAJMLJIVANJA };
            sender.Posalji(z);

            Odgovor odgovor = (Odgovor)receiver.Prihvati();

            return odgovor.Result;
        }
    }
}
