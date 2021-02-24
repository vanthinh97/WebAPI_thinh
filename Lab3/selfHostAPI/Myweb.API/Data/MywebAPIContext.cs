using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Myweb.API.Models;

namespace Myweb.API.Data
{
    public class MywebAPIContext : DbContext
    {
        public MywebAPIContext (DbContextOptions<MywebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Myweb.API.Models.Blog> Blog { get; set; }
    }
}
