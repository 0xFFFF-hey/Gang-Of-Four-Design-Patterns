using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.GoodExample
{
    internal class MySQLRepository : IUserRepository
    {
        public void SaveUser(string username)
        {
            Console.WriteLine($"User {username} saved to MySQL database.");
        }
    }
}
