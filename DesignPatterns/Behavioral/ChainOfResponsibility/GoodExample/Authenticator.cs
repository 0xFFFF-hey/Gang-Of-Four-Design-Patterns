using DesignPatterns.Behavioral.ChainOfResponsibility.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample
{
    internal class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authenticating");
            var username = request.GetUsername();
            var password = request.GetPassword();
            return !(username == "danny" && password == "123");
        }
    }
}
