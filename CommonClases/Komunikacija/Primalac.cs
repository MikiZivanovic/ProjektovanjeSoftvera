using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CommonClases.Komunikacija
{
    public class Primalac
    {
        Socket socket;
        BinaryFormatter formatter;
        NetworkStream stream;

        public Primalac(Socket s)
        {
            socket = s;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public Object Prihvati()
        {

            return formatter.Deserialize(stream);
        }
    }
}
