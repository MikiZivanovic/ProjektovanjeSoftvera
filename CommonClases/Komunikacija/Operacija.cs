using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClases.Komunikacija
{
    [Serializable]
    public enum Operacija
    {
         LOGIN = 1,
        UCITAJ_LISTU_KLIJENATA = 2,
        UCITAJ_LISTU_STANOVA = 3,
         UCITAJ_LISTU_IZNAJMLJIVANJA = 4,
         ZAPAMTI_KLIJENTA = 5,
       ZAPAMTI_STAN = 6,
        ZAPAMTI_IZNAJMLJIVANJE = 7,
         PROMENI_KLIJENTA = 8,
         PROMENI_STAN = 9,
        PROMENI_IZNAJMLJIVANJE = 10,
         OBRISI_STAN = 11,
         UCITAJ_LISTU_NASELJA = 12,
        
        NADJI_STANOVE= 13,
         NADJI_KLIJENTE = 15,
         NADJI_IZNAJMLJIVANJA = 16,
        PROMENI_ADMINISTRATORA = 17
    }
}
