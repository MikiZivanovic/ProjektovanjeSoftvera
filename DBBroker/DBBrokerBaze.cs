using CommonClases.Domen;
using CommonLib.Domen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class DBBrokerBaze : IBroker<GenerickiObjekat>
    {
        private DBKonekcija connection;

        public DBBrokerBaze()
        {
            connection = new DBKonekcija();
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public int Insert(GenerickiObjekat objekat)
        {
           
            SqlCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO "+ objekat.VratiNazivTabele() +""+objekat.VratiImenaKolona()+" output inserted."+objekat.NazivIdKolone()+" VALUES "+objekat.VratiVrednostiZaInsert() ;
            int id =(int)com.ExecuteScalar();
            
            com.Dispose();
            return id;
        }

        public void Update(GenerickiObjekat objekat)
        {
            SqlCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE " + objekat.VratiNazivTabele() + " SET "+objekat.VratiImeKolonaVrednostiZaUpadate() + " WHERE "+ objekat.VratiWhereUslovaZaDeleteIUpdate();
            com.ExecuteNonQuery();

            com.Dispose();
        }

        public void Delete(GenerickiObjekat objekat)
        {
            SqlCommand com = connection.CreateCommand();
            com.CommandText = "DELETE FROM " + objekat.VratiNazivTabele()  + " WHERE " + objekat.VratiWhereUslovaZaDeleteIUpdate();
            com.ExecuteNonQuery();

            com.Dispose();
        }

        public List<GenerickiObjekat> GetAll(GenerickiObjekat objekat)
        {
            List<GenerickiObjekat> lista = new List<GenerickiObjekat> ();   
            SqlCommand com = connection.CreateCommand();
            com.CommandText = "Select " + objekat.VratiNazivKolonaZaVratiSve() + " From " + objekat.VratiNazivTabele() + " " + objekat.VratiJoinUslov() + " " + objekat.VratiWhereZaVratiSve() + ""+ objekat.VratiOrderByUslov();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
               
                lista.Add(TransformatorObjekata.Transformisi(objekat,reader));
            }
            reader.Close();
            return lista;
        }

        public List<GenerickiObjekat> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
