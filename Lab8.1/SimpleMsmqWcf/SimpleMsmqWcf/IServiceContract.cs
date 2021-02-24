using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleMsmqWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://MyServices/IServiceContract")]
    public interface IServiceContract
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
        [OperationContract(IsOneWay = true)]
        void SendNumber(long message);

    }
}
