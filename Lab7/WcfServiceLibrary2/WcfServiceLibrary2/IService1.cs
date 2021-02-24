using System.ServiceModel;


namespace WcfServiceLibrary2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IService1
    {
        [OperationContract]
        bool Register(string name, float balance, string pin);

        [OperationContract]
        bool ValidateAccount(int accId, string pin);

        [OperationContract]
        bool WithDraw(int accId, float amount);

        [OperationContract]
        bool Deposit(int accId, float amt);
    }
}
