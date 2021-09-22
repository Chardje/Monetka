using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Monetka
{
    class MonetkaClient
    {
        public int port;
        public IPEndPoint remoteEndpoint;
        public IPEndPoint localEndpoint;
        public Stream stream;
        public Tru tru1;

        public delegate void Tru(bool tru);
        public MonetkaClient(int remotePort, IPAddress local, IPAddress remoute)
        {
            port = new Random().Next(1, 9999);
            remoteEndpoint = new IPEndPoint(local,remotePort);
            localEndpoint = new IPEndPoint(remoute, port);

            using (TcpClient tcpClient = new TcpClient(localEndpoint))
            {
                tcpClient.Connect(remoteEndpoint);
                stream = tcpClient.GetStream();
            }
        }
        public MonetkaClient(int remotePort, IPAddress local,Tru tru)
        {
            port = new Random().Next(1, 9999);
            remoteEndpoint = new IPEndPoint(local, remotePort);
            localEndpoint = new IPEndPoint(local, port);
            tru1 = tru;
        }

        public void Usingg()
        {
            using (TcpClient tcpClient = new TcpClient(localEndpoint))
            {
                tcpClient.Connect(remoteEndpoint);
                stream = tcpClient.GetStream();
                while (true)
                {
                    bool tr = ReadMonetka();
                    tru1(tr);
                }

            }
        }

        public void WriteMyChose(bool MyChose)
        {
            stream.WriteByte(Convert.ToByte(MyChose));
        }

        public bool ReadMonetka()
        {
            byte[] array = new byte[1];
            stream.Read(array, 0, 1);

            return array[0] > 0;
        }
    }
}
