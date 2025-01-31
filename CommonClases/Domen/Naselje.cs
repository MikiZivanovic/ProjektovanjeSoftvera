using CommonClases.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Domen
{
    [Serializable]
    public class Naselje : GenerickiObjekat
    {

        public int Id { get; set; }
        public string NazivNaselja { get; set; }
        public string KlasaNaselja { get; set; }

        public Naselje(string naziv,string klasa) {
           
            NazivNaselja= naziv;
            KlasaNaselja = klasa;
        }

        public Naselje()
        {
        }

        public void postaviId(int id)
        {
           Id = id;
        }

        public string VratiImeKolonaVrednostiZaUpadate()
        {
            return $"(NazivNaselja='{NazivNaselja}',KlasaNaselja='{KlasaNaselja}')";
        }

        public string VratiImenaKolona()
        {
            return "(NazivNaselja,KlasaNaselja)";
        }

        public string VratiJoinUslov()
        {
            return "";
        }

        public string VratiNazivKolonaZaVratiSve()
        {
            return "*";
        }

        public string VratiNazivTabele()
        {
            return "Naselje";
        }

        public string VratiOrderByUslov()
        {
            return "";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"{NazivNaselja},{KlasaNaselja}";
        }

        public string VratiWhereUslovaZaDeleteIUpdate()
        {
            return $"NaseljeID={Id}";
        }

        public string VratiWhereZaVratiSve()
        {
            return "";
        }
        public override string ToString()
        {
            return NazivNaselja;
        }

        public string NazivIdKolone()
        {
            return "NaseljeID";
        }
    }
}
