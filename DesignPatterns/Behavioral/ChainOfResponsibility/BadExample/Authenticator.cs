using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.BadExample
{
    internal class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            return username == "danny" && password == "123";
        }
    }
}
