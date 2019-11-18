using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPNumberSender
{
    class Program
    {
        static void Main(string[] args)
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            UdpClient udpClient = new UdpClient("127.0.0.1", 9999);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Broadcast, 9999); 


            while (true)

            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(" Pollution sensor v.1.0.\r\n Location: Maglegårdsvej 2 Time: 04-Oct-17/12:34:42 PM\r\n CO: 0.38 r \r\n NOx: 140.30 \r\n Particle level: Medium \r\n");

                udpClient.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint); 
                Thread.Sleep(4000);
            }
        }
    }
}
