using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlSimulator.Receivers
{
    internal class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("The fan is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("The fan is OFF");
        }
    }
}
