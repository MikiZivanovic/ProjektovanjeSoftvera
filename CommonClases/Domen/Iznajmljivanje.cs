using CommonClases.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Domen
{
    [Serializable]
    public class Iznajmljivanje : GenerickiObjekat
    {
        public int Id { get; set; }
        public DateTime DatumOd { get; set; }
        public double UkupanIznos { get; set; }
        public Klijent Klijent { get; set; }
        
        public List<StavkaIznajmljivanja> StavkeIznajmljivanja { get; set; }

        public Iznajmljivanje()
        {
            
        }
        public Iznajmljivanje(DateTime datum,double UkupanI,Klijent Kl)
        {
            DatumOd = datum;
            UkupanIznos = UkupanI;
            Klijent = Kl;
        }

        public string VratiNazivTabele()
        {
            return "Iznajmljivanje";
        }

        public string VratiImenaKolona()
        {
            return "(DatumOd,UkupanIznos,KlijentID)";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{DatumOd}',{UkupanIznos},{Klijent.Id})";
        }

        public string VratiImeKolonaVrednostiZaUpadate()
        {
            return $"DatumOd='{DatumOd}',UkupanIznos={UkupanIznos},KlijentID={Klijent.Id}";
        }

        public string VratiWhereUslovaZaDeleteIUpdate()
        {
            return $"IznajmljivanjeID={Id}";
        }

        public string VratiNazivKolonaZaVratiSve()
        {
            return "*";
        }

        public string VratiJoinUslov()
        {
            return $"i join Klijent k on(i.KlijentID=k.KlijentID)";
        }

        public string VratiWhereZaVratiSve()
        {
            return "";
        }

        public string VratiOrderByUslov()
        {
            return "ORDER BY i.IznajmljivanjeID asc";
        }

        public void postaviId(int id)
        {
            this.Id = id;
        }

        public string NazivIdKolone()
        {
            return "IznajmljivanjeID";
        }
    }
}
