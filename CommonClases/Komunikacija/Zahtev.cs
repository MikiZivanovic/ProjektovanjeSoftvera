using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClases.Komunikacija
{
    [Serializable]
    public class Zahtev
    {
        public Object Argument { get; set; }
        public Operacija Operacija { get; set; }
        
    }
}
