using CommonClases.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Domen
{
    [Serializable]
    public class Stan: GenerickiObjekat
    {
        public int Id { get; set; }
        public int Kvadratura { get; set; }
        public int BrojSoba{ get; set; }
        public double CenaPoDanu{ get; set; }
        public bool Iznajmljen { get; set; }
        public bool Klima {get; set; }
        public Naselje Naselje { get; set; }


        public Stan(int id,int kv,int brojS,double cenaPoDan, bool iznaj, bool kli,Naselje n) {
            id = id;
            Kvadratura = kv;
            BrojSoba = brojS;
            CenaPoDanu = cenaPoDan;
            Iznajmljen = iznaj;
            Klima = kli;
            Naselje = n;
        }

        public Stan()
        {
        }

        public string VratiNazivTabele()
        {
            return "Stan";
        }

        public string VratiImenaKolona()
        {
            return "(Kvadratura,BrojSoba,CenaPoDanu,Iznajmljen,Klima,NaseljeID)";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"({Kvadratura},{BrojSoba},{CenaPoDanu},'{Iznajmljen}','{Klima}',{Naselje.Id})";
        }

        public string VratiImeKolonaVrednostiZaUpadate()
        {
            return $"Kvadratura={Kvadratura},BrojSoba={BrojSoba},CenaPoDanu={CenaPoDanu},Iznajmljen='{Iznajmljen}',Klima='{Klima}',NaseljeID={Naselje.Id}";
        }

        public string VratiWhereUslovaZaDeleteIUpdate()
        {
            return $"StanID={Id}";
        }

        public string VratiNazivKolonaZaVratiSve()
        {
            return "s.StanID,s.Kvadratura,s.BrojSoba,s.CenaPoDanu,s.Iznajmljen,s.Klima,s.NaseljeID,n.NaseljeID,n.NazivNaselja,n.KlasaNaselja";
        }

        public string VratiJoinUslov()
        {
            return "s join Naselje n on(s.NaseljeID=n.NaseljeID)";
        }

        public string VratiWhereZaVratiSve()
        {
            return "";
        }

        public string VratiOrderByUslov()
        {
            return "Order by s.StanID ASC";
        }

        public void postaviId(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return "Naselje:" +this.Naselje.NazivNaselja +" Kvadratura:"+  this.Kvadratura +" BrojSoba:"+ this.BrojSoba+" CenaPoDanu:"+ this.CenaPoDanu + " Klima:" + this.Klima ;
        }

        public string NazivIdKolone()
        {
            return "StanID";
        }
    }
}
