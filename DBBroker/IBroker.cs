using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public interface IBroker <T> where T : class
    {
        List<T> getAll();
        
        int Insert(T entity);

        void Update(T entity);
        void Delete(T entity);

        List<T> GetAll(T entitiy);

    }
}
