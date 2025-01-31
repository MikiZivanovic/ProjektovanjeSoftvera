using CommonClases.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Domen
{
    [Serializable]
    public class Administrator : GenerickiObjekat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime{ get; set; }
        public string KrisnickoIme{ get; set; }
        public string Lozinka{ get; set; }

        public Administrator()
        {
            
        }
        public Administrator(string ime,string prezime,string korisnickoIme,string lozinka)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.KrisnickoIme= korisnickoIme;
            this.Lozinka = lozinka;
        }

        public string VratiNazivTabele()
        {
            return "Administrator";
        }

        public string VratiImenaKolona()
        {
            return "(Ime,Prezime,KorisnickoIme,Lozinka)";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{Ime}','{Prezime}','{KrisnickoIme}','{Lozinka}')";
        }

        public string VratiImeKolonaVrednostiZaUpadate()
        {
            return $"Ime='{Ime}',Prezime='{Prezime}',KorisnickoIme='{KrisnickoIme}',Lozinka='{Lozinka}'";
        }

        public string VratiWhereUslovaZaDeleteIUpdate()
        {
            return $"Id={Id}";
        }

        public string VratiNazivKolonaZaVratiSve()
        {
            return "Ime,Prezime,KorisnickoIme,Lozinka";
        }

        public string VratiJoinUslov()
        {
            return "";
        }

        public string VratiWhereZaVratiSve()
        {
            return "";
        }

        public string VratiOrderByUslov()
        {
            return ""; 
        }

        public void postaviId(int id)
        {
            this.Id = id;
        }

        public string NazivIdKolone()
        {
            return "AdministratorID";
        }
    }
}
