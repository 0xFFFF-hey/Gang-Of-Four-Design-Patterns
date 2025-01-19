using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.BadExample
{
    internal class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Turned On!");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turned Off!");
        }
        public void Dim()
        {
            Console.WriteLine("Dimmed!");
        }
    }
}
