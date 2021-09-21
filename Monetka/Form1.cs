using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace Monetka
{
    public partial class Form1 : Form
    {
        bool TrueMonetka;

        Thread Lis;


        MonetcaServer server = new MonetcaServer();
        MonetkaClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            if (server.serverlisen)
            {
                server.MyChoseHeadsOrTails = Heads.Checked;
                server.MyReady = true;
                TrueMonetka = server.Chose();
            }
            else
            {
                client.WriteMyChose(Heads.Checked);
                TrueMonetka = client.ReadMonetka();
            }
            if (TrueMonetka)
            {
                pictureMonetka.Image= Image.FromFile("C:/Users/vlad/source/repos/Monetka/Monetka/head.jpg");
            }
            else
            {
                pictureMonetka.Image = Image.FromFile("C:/Users/vlad/source/repos/Monetka/Monetka/Tail.jpg");

            }
        }

        private void ConectButton_Click(object sender, EventArgs e)
        {
            ServerButton.Enabled = !ServerButton.Enabled;
            if (ServerButton.Text == "Conect")
            {
                ConectButton.Text = "Disconect";
                client = new MonetkaClient(int.Parse(PortTextBox.Text),IPAddress.Parse(textBoxIp.Text));
                
            }
            else
            {
                ConectButton.Text = "Conect";
                
            }
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            ConectButton.Enabled = !ConectButton.Enabled;
            if (ServerButton.Text=="Open Server")
            {
                ServerButton.Text = "Close Server";
                server = new MonetcaServer();
                textBoxIp.Text = "" + server.tcpListener.LocalEndpoint;
                PortTextBox.Text = "" + server.port;
                server.serverlisen = true;
                Lis = new Thread(new ThreadStart(server.ServerListen));
                Lis.Start();
            }
            else 
            {
                ServerButton.Text = "Open Server";
                server.serverlisen = false;
            }
        }  
    }
}
