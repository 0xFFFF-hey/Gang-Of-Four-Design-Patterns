using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.GoodExample
{
    internal class SonyRadio : Device
    {
        public void TurnOff()
        {
            System.Console.WriteLine("Turning Sony radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning Sony radio on");
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting Sony radio channel to " + channel);
        }
    }
}
