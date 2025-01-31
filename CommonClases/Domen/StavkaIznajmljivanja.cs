using CommonClases.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Domen
{
    [Serializable]
    public class StavkaIznajmljivanja : GenerickiObjekat
    {
        public Iznajmljivanje Iznajmljivanje { get; set; }
        public int RedniBroj  { get; set; }
        public  DateTime DatumDo { get; set; }
        public double CenaStavke  { get; set; }
        public Stan Stan { get; set; }

        public StavkaIznajmljivanja(Iznajmljivanje i ,int Rbr,DateTime d,double r , Stan s) { 
        
            Iznajmljivanje = i;
            RedniBroj = Rbr;
            DatumDo = d;
            CenaStavke = r;
            Stan = s;
        }

        public StavkaIznajmljivanja()
        {
        }

        public void postaviId(int id)
        {
           this.RedniBroj = id;
        }

        public string VratiImeKolonaVrednostiZaUpadate()
        {
            return $"IznajmljivanjeID={Iznajmljivanje.Id},RedniBroj={RedniBroj},DatumDo='{DatumDo}',CenaStavke={CenaStavke},StanID={Stan.Id}";
        }

        public string VratiImenaKolona()
        {
            return "(IznajmljivanjeID,RedniBroj,DatumDo,CenaStavke,StanID)";
        }

        public string VratiJoinUslov()
        {
            return "s join Iznajmljivanje i on(s.IznajmljivanjeID=i.IznajmljivanjeID) join Klijent k on(i.KlijentID=k.KlijentID ) join Stan st on(s.StanID=st.StanID) join Naselje n on(st.NaseljeID=n.NaseljeID)";
        }

        public string VratiNazivKolonaZaVratiSve()
        {
            return "*";
        }

        public string VratiNazivTabele()
        {
            return "StavkaIznajmljivanja";
        }

        public string VratiOrderByUslov()
        {
            return $" ORDER BY s.IznajmljivanjeID ASC, s.Rednibroj ASC";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"({Iznajmljivanje.Id},{RedniBroj},'{DatumDo}',{CenaStavke},{Stan.Id})";
        }

        public string VratiWhereUslovaZaDeleteIUpdate()
        {
            return $"IznajmljivanjeID={Iznajmljivanje.Id} AND RedniBroj={RedniBroj}";
        }

        public string VratiWhereZaVratiSve()
        {
            return $" WHERE s.IznajmljivanjeID={Iznajmljivanje.Id}";
        }

        public string NazivIdKolone()
        {
            return "RedniBroj";
        }
    }
}
