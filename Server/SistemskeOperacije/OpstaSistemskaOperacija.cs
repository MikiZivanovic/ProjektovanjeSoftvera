using DBBroker;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected DBBrokerBaze broker;

        public OpstaSistemskaOperacija()
        {
            broker = new DBBrokerBaze();
        }
        public void ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                ExecuteConcreteOperation();

                broker.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                broker.Rollback();
                throw ex;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        protected abstract void ExecuteConcreteOperation();
    }
}
