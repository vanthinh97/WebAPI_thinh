using System.Data.Entity;
using System.Linq;

namespace WcfServiceLibrary2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private BankDbContext db = new BankDbContext();
        //Tạo account mới
        public bool Register(string name, float balance, string pin)
        {
            
            //Viet code them mot hang account
            Account acc = new Account();
            acc.Balance = balance;
            acc.Name = name;
            acc.PIN = pin;
            db.Accounts.Add(acc);
            db.SaveChanges();
            return true;
        }

        public bool ValidateAccount(int accId, string pin)
        {
            bool b = false;
            var account = db.Accounts.Find(accId);

            if (account != null) {
                if (account.PIN.Equals(pin))
                {
                    b = true;
                }
            }
            return b;
        }

        public bool WithDraw(int accId, float amount)
        {
            Account acc = db.Accounts.Find(accId);

            if (acc != null)
            {
                acc.Balance = acc.Balance - amount;
                db.Entry(acc).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;//false
        }
        public bool Deposit(int accId, float amount)
        {
            Account acc = db.Accounts.Find(accId);

            if (acc != null)
            {
                acc.Balance = acc.Balance + amount;
                db.Entry(acc).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;//false
        }

    }
}
