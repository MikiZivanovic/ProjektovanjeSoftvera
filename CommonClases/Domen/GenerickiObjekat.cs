using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClases.Domen
{
    public interface GenerickiObjekat
    {
        string VratiNazivTabele();
        string VratiImenaKolona();
        string VratiVrednostiZaInsert();
        string VratiImeKolonaVrednostiZaUpadate();
        string VratiWhereUslovaZaDeleteIUpdate();
        string VratiNazivKolonaZaVratiSve();
        string VratiJoinUslov();

        string VratiWhereZaVratiSve();
        string VratiOrderByUslov();
        string NazivIdKolone();
        void postaviId(int id);
        
    }
}
