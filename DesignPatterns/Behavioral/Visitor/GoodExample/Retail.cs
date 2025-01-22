using DesignPatterns.Behavioral.Visitor.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.GoodExample
{
    internal class Retail : Client
    {
        public Retail(string name, string email) : base(name, email)
        {
        }
        public override void Accept(Visitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}
