using CommonClases.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Domen
{
    [Serializable]
    public class Klijent : GenerickiObjekat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Imejl { get; set; }

        public Klijent(int id,string ime,string prezime,string brojTelefona,string imejl) { 
            
            Id = id;
            Ime = ime;
            Prezime = prezime;
            BrojTelefona = brojTelefona;
            Imejl = imejl;
        }

        public Klijent()
        {
        }

        public string VratiNazivTabele()
        {
            return "Klijent";
        }

        public string VratiImenaKolona()
        {
            return "(Ime,Prezime,BrojTelefona,Imejl)";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{Ime}','{Prezime}','{BrojTelefona}','{Imejl}')";
        }

        public string VratiImeKolonaVrednostiZaUpadate()
        {
            return $"Ime='{Ime}',Prezime='{Prezime}',BrojTelefona='{BrojTelefona}',Imejl='{Imejl}'";
        }

        public string VratiWhereUslovaZaDeleteIUpdate()
        {
            return $"KlijentID={Id}";
        }

        public string VratiNazivKolonaZaVratiSve()
        {
            return "*";
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
            return "ORDER BY KlijentID";
        }

        public void postaviId(int id)
        {
            this.Id = id;
        }
        public override string ToString()
        {
            return  this.Ime + " " + this.Prezime;
        }

        public string NazivIdKolone()
        {
            return "KlijentID";
        }
    }
}
