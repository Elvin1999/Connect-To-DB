using ConsoleApp1.Data;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() {
                Email="Elvin",
                Password="eee"
            };

            UserContext userContext = new UserContext();
            //userContext.Users.Add(user);
            //userContext.SaveChanges();
            var item = userContext.Users.SingleOrDefault(x => x.Password == "eee");
            Console.WriteLine(item.Email);
        }
    }
}
