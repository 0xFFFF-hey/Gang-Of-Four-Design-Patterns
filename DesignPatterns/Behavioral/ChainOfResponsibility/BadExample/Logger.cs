using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.BadExample
{
    internal class Logger
    {
        public void Log(HttpRequest request)
        {
            System.Console.WriteLine("Log");
        }
    }
}
