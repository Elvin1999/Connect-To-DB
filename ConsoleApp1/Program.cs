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
                Email="camalzade1@gmail.com",
                Password="123456"
            };

            UserContext userContext = new UserContext();
            userContext.Users.Add(user);
        }
    }
}
