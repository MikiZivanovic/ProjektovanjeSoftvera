using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CommonClases.Komunikacija
{
    public class Posiljalac
    {
        Socket socket;
        BinaryFormatter formatter;
        NetworkStream stream;

        public Posiljalac(Socket s) { 
            socket = s; 
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Posalji(Object o) {


            formatter.Serialize(stream, o);
        }

    }
}
