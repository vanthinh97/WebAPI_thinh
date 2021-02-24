using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WcfServiceLibrary2
{
    public class BankDbContext : DbContext
    {
        public BankDbContext()
            : base("BankDB")
        {
        }
        public DbSet<Account> Accounts
        {
            get;
            set;
        }

    }
}
