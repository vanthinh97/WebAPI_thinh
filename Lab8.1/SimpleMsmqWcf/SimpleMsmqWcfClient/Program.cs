using SimpleMsmqWcfClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMsmqWcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpointAddress = "net.msmq://localhost/private/SimpleMsmqWcfQueue";

            String strPath = ".\\private$\\SimpleMsmqWcfQueue";
            if (!MessageQueue.Exists(strPath))
            {
                MessageQueue.Create(strPath, true);
            }

            NetMsmqBinding binding = new NetMsmqBinding(NetMsmqSecurityMode.None);

            EndpointAddress myEndpoint = new EndpointAddress(endpointAddress);

            ChannelFactory<IServiceContract> channel = new ChannelFactory<IServiceContract>(binding, myEndpoint);
            IServiceContract service = channel.CreateChannel();
            try
            {
                service.SendMessage($"The current time is {DateTime.Now}");
                service.SendNumber(DateTime.Now.Ticks);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Client is running ....");
            Console.WriteLine("Messages was sent....");
            Console.ReadLine();

        }
    }
}
