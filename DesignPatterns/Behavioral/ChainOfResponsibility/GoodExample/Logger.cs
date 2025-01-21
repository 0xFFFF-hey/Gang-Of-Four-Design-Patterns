using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample
{
    internal class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Logging");
            return false;
        }
    }
}
