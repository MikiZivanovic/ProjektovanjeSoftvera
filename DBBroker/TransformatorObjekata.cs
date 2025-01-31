using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class TransformatorObjekata
    {
        public static GenerickiObjekat Transformisi(GenerickiObjekat objekat, SqlDataReader reader)
        {
            if (objekat is Klijent)
            {

                Klijent klijent = new Klijent();
                klijent.Id = reader.GetInt32(reader.GetOrdinal("KlijentID"));
                klijent.Ime = reader.GetString(reader.GetOrdinal("Ime"));
                klijent.Prezime = reader.GetString(reader.GetOrdinal("Prezime"));
                klijent.BrojTelefona = reader.GetString(reader.GetOrdinal("BrojTelefona"));
                klijent.Imejl = reader.GetString(reader.GetOrdinal("Imejl"));
                return klijent;
            }
            else if (objekat is Administrator)
            {
                Administrator administrator = new Administrator();
                administrator.Ime = reader.GetString(reader.GetOrdinal("Ime"));
                administrator.Prezime = reader.GetString(reader.GetOrdinal("Prezime"));
                administrator.KrisnickoIme = reader.GetString(reader.GetOrdinal("KorisnickoIme"));
                administrator.Lozinka = reader.GetString(reader.GetOrdinal("Lozinka"));


                return administrator;
            }
            else if (objekat is Naselje)
            {
                Naselje naselje = new Naselje();
                
                naselje.NazivNaselja = reader.GetString(reader.GetOrdinal("NazivNaselja"));
                naselje.KlasaNaselja = reader.GetString(reader.GetOrdinal("KlasaNaselja"));
                naselje.postaviId(reader.GetInt32(reader.GetOrdinal("NaseljeID")));
                return naselje;
            }
            else if (objekat is Stan)
            {
                Stan stan = new Stan();
                stan.Id = reader.GetInt32(reader.GetOrdinal("StanID"));
                stan.Kvadratura = reader.GetInt32(reader.GetOrdinal("Kvadratura"));
                stan.BrojSoba = reader.GetInt32(reader.GetOrdinal("BrojSoba"));
                stan.CenaPoDanu = reader.GetFloat(reader.GetOrdinal("CenaPoDanu"));
                stan.Iznajmljen = reader.GetBoolean(reader.GetOrdinal("Iznajmljen"));
                stan.Klima = reader.GetBoolean(reader.GetOrdinal("Klima"));



                Naselje naselje = new Naselje();
                naselje.postaviId(reader.GetInt32(reader.GetOrdinal("NaseljeID")));
                naselje.NazivNaselja = reader.GetString(reader.GetOrdinal("NazivNaselja"));
                naselje.KlasaNaselja = reader.GetString(reader.GetOrdinal("KlasaNaselja"));
                stan.Naselje = naselje;
                return stan;
            }

            else if (objekat is Iznajmljivanje)
            {
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje();
                iznajmljivanje.Id = reader.GetInt32(reader.GetOrdinal("IznajmljivanjeID"));
                iznajmljivanje.DatumOd = reader.GetDateTime(reader.GetOrdinal("DatumOd"));
                iznajmljivanje.UkupanIznos = reader.GetDouble(reader.GetOrdinal("UkupanIznos"));

                Klijent klijent = new Klijent();
                klijent.Id = reader.GetInt32(reader.GetOrdinal("KlijentID"));
                klijent.Ime = reader.GetString(reader.GetOrdinal("Ime"));
                klijent.Prezime = reader.GetString(reader.GetOrdinal("Prezime"));
                klijent.BrojTelefona = reader.GetString(reader.GetOrdinal("BrojTelefona"));
                klijent.Imejl = reader.GetString(reader.GetOrdinal("Imejl"));
                iznajmljivanje.Klijent = klijent;



                return iznajmljivanje;
            }
            else if (objekat is StavkaIznajmljivanja)
            {
                StavkaIznajmljivanja stavkaIznajmljivanja = new StavkaIznajmljivanja();
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje();
                iznajmljivanje.Id = reader.GetInt32(reader.GetOrdinal("IznajmljivanjeID"));
                iznajmljivanje.DatumOd = reader.GetDateTime(reader.GetOrdinal("DatumOd"));
                iznajmljivanje.UkupanIznos = reader.GetDouble(reader.GetOrdinal("UkupanIznos"));

                Klijent klijent = new Klijent();
                klijent.Id = reader.GetInt32(reader.GetOrdinal("KlijentID"));
                klijent.Ime = reader.GetString(reader.GetOrdinal("Ime"));
                klijent.Prezime = reader.GetString(reader.GetOrdinal("Prezime"));
                klijent.BrojTelefona = reader.GetString(reader.GetOrdinal("BrojTelefona"));
                klijent.Imejl = reader.GetString(reader.GetOrdinal("Imejl"));
                iznajmljivanje.Klijent = klijent;

                stavkaIznajmljivanja.Iznajmljivanje = iznajmljivanje;
                stavkaIznajmljivanja.RedniBroj = reader.GetInt32(reader.GetOrdinal("RedniBroj"));
                stavkaIznajmljivanja.DatumDo = reader.GetDateTime(reader.GetOrdinal("DatumDo"));
                stavkaIznajmljivanja.CenaStavke = reader.GetDouble(reader.GetOrdinal("CenaStavke"));


                Stan stan = new Stan();
                stan.Id = reader.GetInt32(reader.GetOrdinal("StanID"));
                stan.Kvadratura = reader.GetInt32(reader.GetOrdinal("Kvadratura"));
                stan.BrojSoba = reader.GetInt32(reader.GetOrdinal("BrojSoba"));
                stan.CenaPoDanu = reader.GetFloat(reader.GetOrdinal("CenaPoDanu"));
                stan.Iznajmljen = reader.GetBoolean(reader.GetOrdinal("Iznajmljen"));
                stan.Klima = reader.GetBoolean(reader.GetOrdinal("Klima"));



                Naselje naselje = new Naselje();
                naselje.NazivNaselja = reader.GetString(reader.GetOrdinal("NazivNaselja"));
                naselje.KlasaNaselja = reader.GetString(reader.GetOrdinal("KlasaNaselja"));
                stan.Naselje = naselje;

                stavkaIznajmljivanja.Stan = stan;
                return stavkaIznajmljivanja;
            }
            return null;
        }
    }
}