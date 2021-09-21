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
    class MonetcaServer
    {
        public TcpListener tcpListener;
        public int port;
        public bool serverlisen = false;
        Stream stream;

        public bool MyChoseHeadsOrTails;
        public bool ClientChoseHeadsOrTails;
        public bool ClientReady = false;
        public bool MyReady = false;

        public MonetcaServer()
        {
            port = new Random().Next(1, 9999);
            tcpListener = new TcpListener(IPAddress.Any, port);
            serverlisen = false;
        }
        public void ServerListen()
        {
            tcpListener.Start();
            serverlisen = true;
            using (TcpClient tcpClient = tcpListener.AcceptTcpClient())
            {
                stream = tcpClient.GetStream();
                while (!serverlisen)
                {
                    ClientChoseHeadsOrTails = ReadChose();
                    ClientReady = true;
                }
            }
        }

        bool ReadChose()
        {
            byte[] array = new byte[1];
            stream.ReadAsync(array,0,1);
            
            return array[0] > 0;
        }

        void WriteChose(bool chose)
        {
            byte[] array = { Convert.ToByte(chose) };
            stream.WriteAsync(array, 0, 1);

            
        }

        public bool Chose()
        {
            while (true)
            {
                if (MyReady&&ClientReady)
                {
                    bool HeadsOrTails = Convert.ToBoolean(new Random().Next(0, 2));

                    WriteChose(HeadsOrTails==ClientChoseHeadsOrTails);

                    MyReady = false;
                    ClientReady = false;

                    return HeadsOrTails == MyChoseHeadsOrTails;
                }
            }
        }
    }
}
