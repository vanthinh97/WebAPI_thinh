using SimpleMsmqWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMsmqWcfServer
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any, InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public sealed class ServiceContract : IServiceContract
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now} [{nameof(SendMessage)}]: {message}");
        }

        public void SendNumber(long message)
        {
            Console.WriteLine($"{DateTime.Now} [{nameof(SendNumber)}]: {message}");
        }
    }

}
