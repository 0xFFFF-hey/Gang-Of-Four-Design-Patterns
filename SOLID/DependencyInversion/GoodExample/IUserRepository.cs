using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.GoodExample
{
    internal interface IUserRepository
    {
        void SaveUser(string username);
    }
}
