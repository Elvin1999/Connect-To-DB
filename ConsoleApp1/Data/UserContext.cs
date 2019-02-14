using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base("UserDb")
        {           
        }
    }
}
