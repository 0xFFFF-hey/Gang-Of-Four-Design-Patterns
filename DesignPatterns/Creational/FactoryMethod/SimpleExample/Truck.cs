using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.SimpleExample
{
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck");
        }
    }
}
