using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.BadExample
{
    internal class MySQLRepository
    {
        public void SaveUser(string username)
        {
            Console.WriteLine($"User {username} saved to MySQL database.");
        }
    }
}
