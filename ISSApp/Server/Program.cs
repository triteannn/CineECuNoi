using Server.Networking;
using System;
using System.Collections;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Lifetime;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            LifetimeServices.LeaseTime = TimeSpan.FromMinutes(30);
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = int.Parse(ConfigurationManager.AppSettings["Port"]);

            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);

            var service = new ServerImpl();

            RemotingServices.Marshal(service, "DonareSangeISS");

            //Console.WriteLine(DateTime.Now);

            Console.WriteLine("Server is up on " + GetLocalIPAddress() + " on port: " + props["port"]);
            //Console.ReadLine();


            DeleteExpired.StartTimer();
            Console.WriteLine("Started separate thread -- stergere produs sanguin expirat");
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
