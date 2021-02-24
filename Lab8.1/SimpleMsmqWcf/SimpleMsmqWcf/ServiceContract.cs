using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleMsmqWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceContract : IServiceContract
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
