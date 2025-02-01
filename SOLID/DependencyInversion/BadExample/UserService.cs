using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.BadExample
{
    internal class UserService
    {
        private MySQLRepository _repository;

        public UserService()
        {
            _repository = new MySQLRepository(); // 🚨 Direct dependency on a concrete class
        }

        public void RegisterUser(string username)
        {
            _repository.SaveUser(username);
        }
    }
}
