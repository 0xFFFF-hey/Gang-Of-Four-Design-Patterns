using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.BadExample
{
    internal class Restaurant : Client
    {
        public Restaurant(string name, string email) : base(name, email) { }

        public override void SendEmail()
        {
            Console.WriteLine("Sending restaurant marketing tips email to " + _email);
        }
    }
}
