using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.GoodExample
{
    internal class UserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) // Injecting the dependency
        {
            _repository = repository;
        }

        public void RegisterUser(string username)
        {
            _repository.SaveUser(username);
        }
    }
}
