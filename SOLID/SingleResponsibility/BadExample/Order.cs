using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility.BadExample
{
    internal class Order
    {
        public string CustomerEmail { get; set; }
        public string Product { get; set; }
    }
}
