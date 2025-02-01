using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.BadExample
{
    internal class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }

        public void Eat()
        {
            throw new NotImplementedException(); // 🚨 Robots don't eat!
        }
    }
}
