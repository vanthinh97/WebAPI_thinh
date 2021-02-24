using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMSMQ
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyWish1 : IWish1
    {
        public string SayYourWish(string wisherName, string yourWish)
        {
            Console.WriteLine("Client (Wisher): " + wisherName + " wish is :" + yourWish);
            string u = "Client (Wisher): " + wisherName + " wish is :" + yourWish;
            return u;
        }
    }
}
