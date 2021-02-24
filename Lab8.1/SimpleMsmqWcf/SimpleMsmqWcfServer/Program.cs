using System;
using System.ServiceModel;
using System.Threading;

namespace SimpleMsmqWcfServer
{
    class Program
    {
        public static ServiceHost _host;
        public static Thread _heartBeatThread;

        static void Main(string[] args)
        {
            _host = new ServiceHost(typeof(ServiceContract));
            _host.Open();

            _heartBeatThread = new Thread(new ThreadStart(WriteHeartBeat));
            _heartBeatThread.Start();
            _heartBeatThread.Join();

        }

        public static void WriteHeartBeat()
        {
            while (true)
            {
                Console.WriteLine("{0} Sleeping...", DateTime.Now);
                Thread.Sleep(1000);
            }
        }
    }

}
