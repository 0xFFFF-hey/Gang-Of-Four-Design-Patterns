using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.SimpleExample
{
    public class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck(); // Creates a Truck
        }
    }
}
