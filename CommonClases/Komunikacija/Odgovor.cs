using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClases.Komunikacija
{
    [Serializable]
    public class Odgovor
    {
        public Object Result { get; set; }
        public Exception Exception { get; set; }
    }
}
